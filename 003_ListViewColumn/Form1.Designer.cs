namespace ListViewColumn
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
            this.listBoxColumns = new System.Windows.Forms.ListBox();
            this.listViewDate = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listBoxColumns
            // 
            this.listBoxColumns.FormattingEnabled = true;
            this.listBoxColumns.Location = new System.Drawing.Point(592, 12);
            this.listBoxColumns.Name = "listBoxColumns";
            this.listBoxColumns.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxColumns.Size = new System.Drawing.Size(120, 303);
            this.listBoxColumns.TabIndex = 0;
            this.listBoxColumns.SelectedIndexChanged += new System.EventHandler(this.ListBoxColumnChange_SelectedIndexChange);
            // 
            // listViewDate
            // 
            this.listViewDate.Location = new System.Drawing.Point(12, 12);
            this.listViewDate.Name = "listViewDate";
            this.listViewDate.Size = new System.Drawing.Size(549, 371);
            this.listViewDate.TabIndex = 1;
            this.listViewDate.UseCompatibleStateImageBehavior = false;
            this.listViewDate.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 395);
            this.Controls.Add(this.listViewDate);
            this.Controls.Add(this.listBoxColumns);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxColumns;
        private System.Windows.Forms.ListView listViewDate;
    }
}

