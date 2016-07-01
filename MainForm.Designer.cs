namespace SecretGarden
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBeginCollect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOutputPath = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddLock = new System.Windows.Forms.Button();
            this.btnCollectDirectory = new System.Windows.Forms.Button();
            this.btnTestOne = new System.Windows.Forms.Button();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.btnProcessPic = new System.Windows.Forms.Button();
            this.tbPicPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1559, 1045);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBeginCollect);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbOutputPath);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1551, 1016);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Collection";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBeginCollect
            // 
            this.btnBeginCollect.Location = new System.Drawing.Point(753, 58);
            this.btnBeginCollect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBeginCollect.Name = "btnBeginCollect";
            this.btnBeginCollect.Size = new System.Drawing.Size(100, 29);
            this.btnBeginCollect.TabIndex = 2;
            this.btnBeginCollect.Text = "Download";
            this.btnBeginCollect.UseVisualStyleBackColor = true;
            this.btnBeginCollect.Click += new System.EventHandler(this.btnBeginCollect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Output Path";
            // 
            // tbOutputPath
            // 
            this.tbOutputPath.Location = new System.Drawing.Point(200, 60);
            this.tbOutputPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOutputPath.Name = "tbOutputPath";
            this.tbOutputPath.Size = new System.Drawing.Size(515, 25);
            this.tbOutputPath.TabIndex = 0;
            this.tbOutputPath.Click += new System.EventHandler(this.tbOutputPath_Click);
            this.tbOutputPath.TextChanged += new System.EventHandler(this.tbOutputPath_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAddLock);
            this.tabPage2.Controls.Add(this.btnCollectDirectory);
            this.tabPage2.Controls.Add(this.btnTestOne);
            this.tabPage2.Controls.Add(this.pic2);
            this.tabPage2.Controls.Add(this.pic1);
            this.tabPage2.Controls.Add(this.btnProcessPic);
            this.tabPage2.Controls.Add(this.tbPicPath);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1551, 1096);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Process";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddLock
            // 
            this.btnAddLock.Location = new System.Drawing.Point(169, 74);
            this.btnAddLock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddLock.Name = "btnAddLock";
            this.btnAddLock.Size = new System.Drawing.Size(100, 29);
            this.btnAddLock.TabIndex = 6;
            this.btnAddLock.Text = "AddLock";
            this.btnAddLock.UseVisualStyleBackColor = true;
            this.btnAddLock.Click += new System.EventHandler(this.btnAddLock_Click);
            // 
            // btnCollectDirectory
            // 
            this.btnCollectDirectory.Location = new System.Drawing.Point(28, 74);
            this.btnCollectDirectory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCollectDirectory.Name = "btnCollectDirectory";
            this.btnCollectDirectory.Size = new System.Drawing.Size(100, 29);
            this.btnCollectDirectory.TabIndex = 5;
            this.btnCollectDirectory.Text = "CollectDirectory";
            this.btnCollectDirectory.UseVisualStyleBackColor = true;
            this.btnCollectDirectory.Click += new System.EventHandler(this.btnCollectDirectory_Click);
            // 
            // btnTestOne
            // 
            this.btnTestOne.Location = new System.Drawing.Point(1308, 20);
            this.btnTestOne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTestOne.Name = "btnTestOne";
            this.btnTestOne.Size = new System.Drawing.Size(100, 29);
            this.btnTestOne.TabIndex = 4;
            this.btnTestOne.Text = "TestOne";
            this.btnTestOne.UseVisualStyleBackColor = true;
            this.btnTestOne.Click += new System.EventHandler(this.btnTestOne_Click);
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(797, 264);
            this.pic2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(736, 799);
            this.pic2.TabIndex = 3;
            this.pic2.TabStop = false;
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(13, 264);
            this.pic1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(764, 799);
            this.pic1.TabIndex = 3;
            this.pic1.TabStop = false;
            // 
            // btnProcessPic
            // 
            this.btnProcessPic.Location = new System.Drawing.Point(1181, 20);
            this.btnProcessPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProcessPic.Name = "btnProcessPic";
            this.btnProcessPic.Size = new System.Drawing.Size(100, 29);
            this.btnProcessPic.TabIndex = 2;
            this.btnProcessPic.Text = "ProcessPic";
            this.btnProcessPic.UseVisualStyleBackColor = true;
            this.btnProcessPic.Click += new System.EventHandler(this.btnProcessPic_Click);
            // 
            // tbPicPath
            // 
            this.tbPicPath.Location = new System.Drawing.Point(120, 22);
            this.tbPicPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPicPath.Name = "tbPicPath";
            this.tbPicPath.Size = new System.Drawing.Size(1025, 25);
            this.tbPicPath.TabIndex = 1;
            this.tbPicPath.Click += new System.EventHandler(this.tbPicPath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "PicPath";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 1045);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "SecretGarden";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOutputPath;
        private System.Windows.Forms.Button btnBeginCollect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPicPath;
        private System.Windows.Forms.Button btnProcessPic;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.Button btnTestOne;
        private System.Windows.Forms.Button btnCollectDirectory;
        private System.Windows.Forms.Button btnAddLock;
    }
}

