using System.Diagnostics;
using TagLib;

namespace MyMp3Renamer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] mp3Files;
        string mp3CountString;
        int index = 0;
        bool batchProcess = true;
        private void selectBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog()) {
                dialog.Description = "Select the folder with MP3 files";
                if (dialog.ShowDialog() == DialogResult.OK) {
                    string folderPath = dialog.SelectedPath;
                    mp3Files = Directory.GetFiles(folderPath, "*.mp3");

                    mp3CountString = $" {index} / {mp3Files.Length} Files Completed";
                    CountLabel.Text = mp3CountString;

                    FolderNametextBox1.Text = folderPath;

                    //put this in the if so that it wont error if no file is picked
                    TagInfoToUI(mp3Files[index]);
                }
            }
            
            
        }
        private void BeginNaming_button_Click(object sender, EventArgs e)
        {
           if(mp3Files == null || mp3Files.Length == 0) {
                MessageBox.Show("No Files Found! Please Choose A File");
                return;
           }

            //index = 0;  already done earlier

            batchProcess = false;

            GoAllbutton1.Text = "Confirm and Next";

            GoAlllabel.Text = " Confirm The \n Tag Information";

            ProcessTagUpdate(mp3Files[index]);

        }

        private void TagInfoToUI(string filePath)
        {
            try {

                string fileName = Path.GetFileNameWithoutExtension(filePath);
                string folderName = new DirectoryInfo(Path.GetDirectoryName(filePath)).Name; // folder that contains the file


                //first saving the filename to a text box so that it can be checked before confirming
                PerformertextBox4.Text = folderName;
                ArtistTextBox3.Text = folderName;
                TitletextBox2.Text = fileName;
                AlbumtextBox1.Text = folderName;
            }
            catch (Exception ex) {
                Debug.WriteLine($"There Seems To Be Something Wrong With This File!  \n {ex.Message}");
            }
        }

        private void ProcessTagUpdate(string filePath)
        {
            try {
                var tfile = TagLib.File.Create(filePath);

                tfileEditor(tfile);
            }
            catch (Exception ex) {
                MessageBox.Show($"Error tagging file {filePath}:\n{ex.Message}");
            }

            mp3CountString = $" {++index} / {mp3Files.Length} Files Completed";
            CountLabel.Text = mp3CountString;

            if (index < mp3Files.Length) {

                TagInfoToUI(mp3Files[index]);
            }
            if (index >= mp3Files.Length) {

                index = 0;
                MessageBox.Show("Tagging complete.");
                mp3Files = null;
                FolderNametextBox1.Clear();
                PerformertextBox4.Clear();
                ArtistTextBox3.Clear();
                TitletextBox2.Clear();
                AlbumtextBox1.Clear();
            }
        }

        // a method which checks if the tag name is correct or the input is null or empty
        private void nullChecker(Func<string> oldName, Action action, string input)
        {
            if (!string.IsNullOrWhiteSpace(input) && oldName() != input) {
                action();
            }
        }

        private void tfileEditor(TagLib.File tfile)
        {
            nullChecker(() => tfile.Tag.Performers?.FirstOrDefault() ?? " ", () => tfile.Tag.Performers = new[] { PerformertextBox4.Text }, PerformertextBox4.Text);

            nullChecker(() => tfile.Tag.AlbumArtists?.FirstOrDefault() ?? " ", () => tfile.Tag.AlbumArtists = new[] { ArtistTextBox3.Text }, ArtistTextBox3.Text);

            nullChecker(() => tfile.Tag.Title, () => tfile.Tag.Title = TitletextBox2.Text, TitletextBox2.Text);

            nullChecker(() => tfile.Tag.Album, () => tfile.Tag.Album = AlbumtextBox1.Text, AlbumtextBox1.Text);

            tfile.Save();
        }

        private void GoAllbutton1_Click(object sender, EventArgs e)
        {
            if (mp3Files == null || mp3Files.Length == 0) {

                MessageBox.Show("No Files Found!");
                return;

            }

            if (batchProcess == true) {

                foreach (var file in mp3Files) {

                    ProcessTagUpdate(file);

                }
            }

            if (batchProcess == false) {

                ProcessTagUpdate(mp3Files[index]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SingleFileLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
