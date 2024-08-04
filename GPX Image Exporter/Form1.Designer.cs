namespace GPX_Image_Exporter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loadedFiles = new System.Windows.Forms.ListBox();
            this.images_text = new System.Windows.Forms.Label();
            this.radio_multiFile = new System.Windows.Forms.RadioButton();
            this.radio_singleFile = new System.Windows.Forms.RadioButton();
            this.chpath = new System.Windows.Forms.Button();
            this.pathSelected = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.destSelect = new System.Windows.Forms.Button();
            this.destinationPath = new System.Windows.Forms.TextBox();
            this.log_text = new System.Windows.Forms.Label();
            this.logList = new System.Windows.Forms.ListBox();
            this.openFolder = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ssbtn = new System.Windows.Forms.Button();
            this.thread1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loadedFiles);
            this.groupBox1.Controls.Add(this.images_text);
            this.groupBox1.Controls.Add(this.radio_multiFile);
            this.groupBox1.Controls.Add(this.radio_singleFile);
            this.groupBox1.Controls.Add(this.chpath);
            this.groupBox1.Controls.Add(this.pathSelected);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 356);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GPX Selection";
            // 
            // loadedFiles
            // 
            this.loadedFiles.FormattingEnabled = true;
            this.loadedFiles.Location = new System.Drawing.Point(15, 105);
            this.loadedFiles.Name = "loadedFiles";
            this.loadedFiles.Size = new System.Drawing.Size(239, 238);
            this.loadedFiles.TabIndex = 10;
            // 
            // images_text
            // 
            this.images_text.AutoSize = true;
            this.images_text.Location = new System.Drawing.Point(12, 89);
            this.images_text.Name = "images_text";
            this.images_text.Size = new System.Drawing.Size(82, 13);
            this.images_text.TabIndex = 5;
            this.images_text.Text = "Loaded images:";
            // 
            // radio_multiFile
            // 
            this.radio_multiFile.AutoSize = true;
            this.radio_multiFile.Location = new System.Drawing.Point(140, 28);
            this.radio_multiFile.Name = "radio_multiFile";
            this.radio_multiFile.Size = new System.Drawing.Size(84, 17);
            this.radio_multiFile.TabIndex = 4;
            this.radio_multiFile.Text = "GPX Folders";
            this.radio_multiFile.UseVisualStyleBackColor = true;
            // 
            // radio_singleFile
            // 
            this.radio_singleFile.AutoSize = true;
            this.radio_singleFile.Checked = true;
            this.radio_singleFile.Location = new System.Drawing.Point(15, 28);
            this.radio_singleFile.Name = "radio_singleFile";
            this.radio_singleFile.Size = new System.Drawing.Size(71, 17);
            this.radio_singleFile.TabIndex = 3;
            this.radio_singleFile.TabStop = true;
            this.radio_singleFile.Text = "GPX Files";
            this.radio_singleFile.UseVisualStyleBackColor = true;
            // 
            // chpath
            // 
            this.chpath.Location = new System.Drawing.Point(192, 51);
            this.chpath.Name = "chpath";
            this.chpath.Size = new System.Drawing.Size(61, 23);
            this.chpath.TabIndex = 2;
            this.chpath.Text = "Choose";
            this.chpath.UseVisualStyleBackColor = true;
            this.chpath.Click += new System.EventHandler(this.chpath_Click);
            // 
            // pathSelected
            // 
            this.pathSelected.Enabled = false;
            this.pathSelected.Location = new System.Drawing.Point(15, 51);
            this.pathSelected.Name = "pathSelected";
            this.pathSelected.Size = new System.Drawing.Size(171, 20);
            this.pathSelected.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.destSelect);
            this.groupBox2.Controls.Add(this.destinationPath);
            this.groupBox2.Controls.Add(this.log_text);
            this.groupBox2.Controls.Add(this.logList);
            this.groupBox2.Controls.Add(this.openFolder);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.ssbtn);
            this.groupBox2.Location = new System.Drawing.Point(289, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 356);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Download";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Destination Folder";
            // 
            // destSelect
            // 
            this.destSelect.Location = new System.Drawing.Point(197, 35);
            this.destSelect.Name = "destSelect";
            this.destSelect.Size = new System.Drawing.Size(61, 23);
            this.destSelect.TabIndex = 6;
            this.destSelect.Text = "Choose";
            this.destSelect.UseVisualStyleBackColor = true;
            this.destSelect.Click += new System.EventHandler(this.destSelect_Click);
            // 
            // destinationPath
            // 
            this.destinationPath.Enabled = false;
            this.destinationPath.Location = new System.Drawing.Point(20, 37);
            this.destinationPath.Name = "destinationPath";
            this.destinationPath.Size = new System.Drawing.Size(171, 20);
            this.destinationPath.TabIndex = 8;
            // 
            // log_text
            // 
            this.log_text.AutoSize = true;
            this.log_text.Location = new System.Drawing.Point(18, 128);
            this.log_text.Name = "log_text";
            this.log_text.Size = new System.Drawing.Size(75, 13);
            this.log_text.TabIndex = 6;
            this.log_text.Text = "Download log:";
            // 
            // logList
            // 
            this.logList.FormattingEnabled = true;
            this.logList.Location = new System.Drawing.Point(20, 144);
            this.logList.Name = "logList";
            this.logList.Size = new System.Drawing.Size(239, 199);
            this.logList.TabIndex = 7;
            // 
            // openFolder
            // 
            this.openFolder.Enabled = false;
            this.openFolder.Location = new System.Drawing.Point(173, 63);
            this.openFolder.Name = "openFolder";
            this.openFolder.Size = new System.Drawing.Size(85, 23);
            this.openFolder.TabIndex = 6;
            this.openFolder.Text = "Open Folder";
            this.openFolder.UseVisualStyleBackColor = true;
            this.openFolder.Click += new System.EventHandler(this.openFolder_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(21, 99);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(238, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // ssbtn
            // 
            this.ssbtn.Enabled = false;
            this.ssbtn.Location = new System.Drawing.Point(21, 63);
            this.ssbtn.Name = "ssbtn";
            this.ssbtn.Size = new System.Drawing.Size(58, 23);
            this.ssbtn.TabIndex = 4;
            this.ssbtn.Text = "Start";
            this.ssbtn.UseVisualStyleBackColor = true;
            this.ssbtn.Click += new System.EventHandler(this.ssbtn_Click);
            // 
            // thread1
            // 
            this.thread1.WorkerSupportsCancellation = true;
            this.thread1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.thread1_DoWork);
            this.thread1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.threadFinished);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 380);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GPX Image Exporter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker thread1;
        private System.Windows.Forms.Button ssbtn;
        private System.Windows.Forms.RadioButton radio_multiFile;
        private System.Windows.Forms.RadioButton radio_singleFile;
        private System.Windows.Forms.Button chpath;
        private System.Windows.Forms.TextBox pathSelected;
        private System.Windows.Forms.Button openFolder;
        private System.Windows.Forms.Label images_text;
        private System.Windows.Forms.Label log_text;
        private System.Windows.Forms.ListBox logList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button destSelect;
        private System.Windows.Forms.TextBox destinationPath;
        private System.Windows.Forms.ListBox loadedFiles;
    }
}

