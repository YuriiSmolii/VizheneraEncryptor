
namespace CaesarEncryptor
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
            if (disposing && (components != null))
            {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OriginalText = new System.Windows.Forms.RichTextBox();
            this.DecryptedText = new System.Windows.Forms.RichTextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.inputBoxLable = new System.Windows.Forms.Label();
            this.resultBoxLable = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frequencyTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukrainianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.inputFrequency = new System.Windows.Forms.Button();
            this.outputFreuency = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.choseLanguageLable = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.textBoxGaslo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OriginalText
            // 
            this.OriginalText.Location = new System.Drawing.Point(12, 42);
            this.OriginalText.Name = "OriginalText";
            this.OriginalText.Size = new System.Drawing.Size(342, 372);
            this.OriginalText.TabIndex = 0;
            this.OriginalText.Text = "";
            // 
            // DecryptedText
            // 
            this.DecryptedText.Location = new System.Drawing.Point(446, 42);
            this.DecryptedText.Name = "DecryptedText";
            this.DecryptedText.ReadOnly = true;
            this.DecryptedText.Size = new System.Drawing.Size(342, 372);
            this.DecryptedText.TabIndex = 1;
            this.DecryptedText.Text = "";
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(359, 361);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 23);
            this.encryptButton.TabIndex = 4;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(359, 390);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(75, 23);
            this.decryptButton.TabIndex = 5;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // inputBoxLable
            // 
            this.inputBoxLable.AutoSize = true;
            this.inputBoxLable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputBoxLable.Location = new System.Drawing.Point(12, 24);
            this.inputBoxLable.Name = "inputBoxLable";
            this.inputBoxLable.Size = new System.Drawing.Size(146, 15);
            this.inputBoxLable.TabIndex = 10;
            this.inputBoxLable.Text = "Opened file / Input text :";
            // 
            // resultBoxLable
            // 
            this.resultBoxLable.AutoSize = true;
            this.resultBoxLable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultBoxLable.Location = new System.Drawing.Point(446, 24);
            this.resultBoxLable.Name = "resultBoxLable";
            this.resultBoxLable.Size = new System.Drawing.Size(104, 15);
            this.resultBoxLable.TabIndex = 11;
            this.resultBoxLable.Text = "Operation result :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.frequencyTablesToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.printToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // frequencyTablesToolStripMenuItem
            // 
            this.frequencyTablesToolStripMenuItem.Checked = true;
            this.frequencyTablesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.frequencyTablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ukrainianToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.frequencyTablesToolStripMenuItem.Name = "frequencyTablesToolStripMenuItem";
            this.frequencyTablesToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.frequencyTablesToolStripMenuItem.Text = "Frequency Tables";
            // 
            // ukrainianToolStripMenuItem
            // 
            this.ukrainianToolStripMenuItem.Name = "ukrainianToolStripMenuItem";
            this.ukrainianToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.ukrainianToolStripMenuItem.Text = "Ukrainian";
            this.ukrainianToolStripMenuItem.Click += new System.EventHandler(this.ukrainianToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItem1.Text = "About";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Program";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // inputFrequency
            // 
            this.inputFrequency.Location = new System.Drawing.Point(12, 419);
            this.inputFrequency.Name = "inputFrequency";
            this.inputFrequency.Size = new System.Drawing.Size(104, 23);
            this.inputFrequency.TabIndex = 13;
            this.inputFrequency.Text = "Frequency table";
            this.inputFrequency.UseVisualStyleBackColor = true;
            this.inputFrequency.Click += new System.EventHandler(this.inputFrequency_Click);
            // 
            // outputFreuency
            // 
            this.outputFreuency.Location = new System.Drawing.Point(682, 419);
            this.outputFreuency.Name = "outputFreuency";
            this.outputFreuency.Size = new System.Drawing.Size(104, 23);
            this.outputFreuency.TabIndex = 14;
            this.outputFreuency.Text = "Frequency table";
            this.outputFreuency.UseVisualStyleBackColor = true;
            this.outputFreuency.Click += new System.EventHandler(this.outputFreuency_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ukrainian",
            "English"});
            this.comboBox1.Location = new System.Drawing.Point(360, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(76, 23);
            this.comboBox1.TabIndex = 16;
            // 
            // choseLanguageLable
            // 
            this.choseLanguageLable.AutoSize = true;
            this.choseLanguageLable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.choseLanguageLable.Location = new System.Drawing.Point(360, 42);
            this.choseLanguageLable.Name = "choseLanguageLable";
            this.choseLanguageLable.Size = new System.Drawing.Size(60, 30);
            this.choseLanguageLable.TabIndex = 17;
            this.choseLanguageLable.Text = "Select a \r\nlanguage:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // textBoxGaslo
            // 
            this.textBoxGaslo.Location = new System.Drawing.Point(359, 198);
            this.textBoxGaslo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxGaslo.Name = "textBoxGaslo";
            this.textBoxGaslo.Size = new System.Drawing.Size(76, 23);
            this.textBoxGaslo.TabIndex = 25;
            this.textBoxGaslo.TextChanged += new System.EventHandler(this.textBoxGaslo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(361, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Gaslo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGaslo);
            this.Controls.Add(this.choseLanguageLable);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.outputFreuency);
            this.Controls.Add(this.inputFrequency);
            this.Controls.Add(this.resultBoxLable);
            this.Controls.Add(this.inputBoxLable);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.DecryptedText);
            this.Controls.Add(this.OriginalText);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Vizhenera";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox OriginalText;
        private System.Windows.Forms.RichTextBox DecryptedText;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Label inputBoxLable;
        private System.Windows.Forms.Label resultBoxLable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frequencyTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ukrainianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button inputFrequency;
        private System.Windows.Forms.Button outputFreuency;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label choseLanguageLable;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox textBoxGaslo;
        private System.Windows.Forms.Label label1;
    }
}

