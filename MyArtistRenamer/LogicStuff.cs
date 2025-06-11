using TagLib;
namespace MyShiurRenamer
{
    internal class LogicStuff
    {
        static void Main(string[] args)
        {
           new LogicStuff();
        }
        public LogicStuff()
        {
            //Button btn = new Button() { Text = "Select Folder & Tag Files", AutoSize = true };
            //btn.Click += Btn_Click;
            //Controls.Add(btn);
        }

        //private void Btn_Click(object sender, EventArgs e)
        //{
        //    using (FolderBrowserDialog dialog = new FolderBrowserDialog()) {
        //        dialog.Description = "Select the folder with MP3 files";
        //        if (dialog.ShowDialog() == DialogResult.OK) {
        //            string folderPath = dialog.SelectedPath;
        //            string[] mp3Files = Directory.GetFiles(folderPath, "*.mp3");

        //            foreach (string filePath in mp3Files) {
        //                try {
        //                    var tfile = TagLib.File.Create(filePath);
        //                    string fileName = Path.GetFileNameWithoutExtension(filePath);
        //                    tfile.Tag.Performers = new[] { fileName };
        //                    tfile.Save();
        //                }
        //                catch (Exception ex) {
        //                    MessageBox.Show($"Error tagging file {filePath}:\n{ex.Message}");
        //                }
        //            }

        //            MessageBox.Show("Tagging complete.");
        //        }
        //    }
        //}

    }
}
