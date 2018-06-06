namespace FindProject
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
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Name", System.Windows.Forms.HorizontalAlignment.Left);
            this.PathLabel = new System.Windows.Forms.Label();
            this.PathTextBox1 = new System.Windows.Forms.TextBox();
            this.DotButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.MainListView1 = new System.Windows.Forms.ListView();
            this.NameColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FoldersColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FilesColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(9, 22);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(29, 13);
            this.PathLabel.TabIndex = 0;
            this.PathLabel.Text = "Path";
            // 
            // PathTextBox1
            // 
            this.PathTextBox1.Location = new System.Drawing.Point(71, 22);
            this.PathTextBox1.Name = "PathTextBox1";
            this.PathTextBox1.Size = new System.Drawing.Size(100, 20);
            this.PathTextBox1.TabIndex = 1;
            // 
            // DotButton
            // 
            this.DotButton.Location = new System.Drawing.Point(203, 22);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(75, 23);
            this.DotButton.TabIndex = 2;
            this.DotButton.Text = ". . .";
            this.DotButton.UseVisualStyleBackColor = true;
            this.DotButton.Click += new System.EventHandler(this.DotButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(12, 60);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(266, 54);
            this.FindButton.TabIndex = 3;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // MainListView1
            // 
            this.MainListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumnHeader1,
            this.SizeColumnHeader1,
            this.FoldersColumnHeader1,
            this.FilesColumnHeader1});
            this.MainListView1.FullRowSelect = true;
            listViewGroup2.Header = "Name";
            listViewGroup2.Name = "NameListViewGroup1";
            this.MainListView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.MainListView1.Location = new System.Drawing.Point(12, 136);
            this.MainListView1.Name = "MainListView1";
            this.MainListView1.Size = new System.Drawing.Size(266, 215);
            this.MainListView1.TabIndex = 4;
            this.MainListView1.UseCompatibleStateImageBehavior = false;
            this.MainListView1.View = System.Windows.Forms.View.Details;
            // 
            // NameColumnHeader1
            // 
            this.NameColumnHeader1.Text = "Name";
            // 
            // SizeColumnHeader1
            // 
            this.SizeColumnHeader1.Text = "Size";
            // 
            // FoldersColumnHeader1
            // 
            this.FoldersColumnHeader1.Text = "Folders";
            // 
            // FilesColumnHeader1
            // 
            this.FilesColumnHeader1.Text = "Files";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 363);
            this.Controls.Add(this.MainListView1);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.DotButton);
            this.Controls.Add(this.PathTextBox1);
            this.Controls.Add(this.PathLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.TextBox PathTextBox1;
        private System.Windows.Forms.Button DotButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.ListView MainListView1;
        private System.Windows.Forms.ColumnHeader NameColumnHeader1;
        private System.Windows.Forms.ColumnHeader SizeColumnHeader1;
        private System.Windows.Forms.ColumnHeader FoldersColumnHeader1;
        private System.Windows.Forms.ColumnHeader FilesColumnHeader1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

