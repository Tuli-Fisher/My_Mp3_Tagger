namespace MyMp3Renamer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Gobutton = new Button();
            AlbumtextBox1 = new TextBox();
            TitletextBox2 = new TextBox();
            ArtistTextBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            PerformertextBox4 = new TextBox();
            SelectFilebutton1 = new Button();
            FolderNametextBox1 = new TextBox();
            GoAllbutton1 = new Button();
            CountLabel = new Label();
            SingleFileLabel = new Label();
            GoAlllabel = new Label();
            SuspendLayout();
            // 
            // Gobutton
            // 
            Gobutton.Location = new Point(549, 319);
            Gobutton.Name = "Gobutton";
            Gobutton.Size = new Size(90, 49);
            Gobutton.TabIndex = 0;
            Gobutton.Text = "Begin Naming";
            Gobutton.UseVisualStyleBackColor = true;
            Gobutton.Click += BeginNaming_button_Click;
            // 
            // AlbumtextBox1
            // 
            AlbumtextBox1.Location = new Point(185, 221);
            AlbumtextBox1.Name = "AlbumtextBox1";
            AlbumtextBox1.Size = new Size(489, 23);
            AlbumtextBox1.TabIndex = 1;
            // 
            // TitletextBox2
            // 
            TitletextBox2.Location = new Point(185, 161);
            TitletextBox2.Name = "TitletextBox2";
            TitletextBox2.Size = new Size(489, 23);
            TitletextBox2.TabIndex = 2;
            // 
            // ArtistTextBox3
            // 
            ArtistTextBox3.Location = new Point(185, 98);
            ArtistTextBox3.Name = "ArtistTextBox3";
            ArtistTextBox3.Size = new Size(489, 23);
            ArtistTextBox3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 98);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 4;
            label1.Text = "artist";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 169);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 5;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 229);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 6;
            label3.Text = "Album";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 48);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 7;
            label4.Text = "Performer";
            // 
            // PerformertextBox4
            // 
            PerformertextBox4.Location = new Point(185, 40);
            PerformertextBox4.Name = "PerformertextBox4";
            PerformertextBox4.Size = new Size(489, 23);
            PerformertextBox4.TabIndex = 8;
            // 
            // SelectFilebutton1
            // 
            SelectFilebutton1.Location = new Point(30, 319);
            SelectFilebutton1.Name = "SelectFilebutton1";
            SelectFilebutton1.Size = new Size(172, 44);
            SelectFilebutton1.TabIndex = 9;
            SelectFilebutton1.Text = "Select Folder";
            SelectFilebutton1.UseVisualStyleBackColor = true;
            SelectFilebutton1.Click += selectBtn_Click;
            // 
            // FolderNametextBox1
            // 
            FolderNametextBox1.Location = new Point(241, 333);
            FolderNametextBox1.Name = "FolderNametextBox1";
            FolderNametextBox1.Size = new Size(285, 23);
            FolderNametextBox1.TabIndex = 10;
            FolderNametextBox1.Click += BeginNaming_button_Click;
            // 
            // GoAllbutton1
            // 
            GoAllbutton1.Location = new Point(675, 319);
            GoAllbutton1.Name = "GoAllbutton1";
            GoAllbutton1.Size = new Size(96, 49);
            GoAllbutton1.TabIndex = 11;
            GoAllbutton1.Text = "Name All";
            GoAllbutton1.UseVisualStyleBackColor = true;
            // 
            // CountLabel
            // 
            CountLabel.AutoSize = true;
            CountLabel.Location = new Point(380, 264);
            CountLabel.Name = "CountLabel";
            CountLabel.Size = new Size(0, 15);
            CountLabel.TabIndex = 12;
            // 
            // SingleFileLabel
            // 
            SingleFileLabel.AutoSize = true;
            SingleFileLabel.Location = new Point(549, 264);
            SingleFileLabel.Name = "SingleFileLabel";
            SingleFileLabel.Size = new Size(90, 45);
            SingleFileLabel.TabIndex = 13;
            SingleFileLabel.Text = "Cycles Through\r\nLabel Every \r\nFile Individually";
            SingleFileLabel.Click += SingleFileLabel_Click;
            // 
            // GoAlllabel
            // 
            GoAlllabel.AutoSize = true;
            GoAlllabel.Location = new Point(675, 271);
            GoAlllabel.Name = "GoAlllabel";
            GoAlllabel.Size = new Size(81, 45);
            GoAlllabel.TabIndex = 14;
            GoAlllabel.Text = "Renames The \r\nWhole Batch \r\nAt Once";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GoAlllabel);
            Controls.Add(SingleFileLabel);
            Controls.Add(CountLabel);
            Controls.Add(GoAllbutton1);
            Controls.Add(FolderNametextBox1);
            Controls.Add(SelectFilebutton1);
            Controls.Add(PerformertextBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ArtistTextBox3);
            Controls.Add(TitletextBox2);
            Controls.Add(AlbumtextBox1);
            Controls.Add(Gobutton);
            Name = "Form1";
            Text = "My Mp3 File Manager";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Gobutton;
        private TextBox AlbumtextBox1;
        private TextBox TitletextBox2;
        private TextBox ArtistTextBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox PerformertextBox4;
        private Button SelectFilebutton1;
        private TextBox FolderNametextBox1;
        private Button GoAllbutton1;
        private Label CountLabel;
        private Label SingleFileLabel;
        private Label GoAlllabel;
    }
}
