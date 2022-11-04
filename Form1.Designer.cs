namespace Lecture_11_MoreList_Enum
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
            this.lbAlbumTracks = new System.Windows.Forms.ListBox();
            this.btnDebug = new System.Windows.Forms.Button();
            this.cmbAlbum = new System.Windows.Forms.ComboBox();
            this.btnRemoveTrack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAlbumTracks
            // 
            this.lbAlbumTracks.FormattingEnabled = true;
            this.lbAlbumTracks.ItemHeight = 24;
            this.lbAlbumTracks.Location = new System.Drawing.Point(495, 198);
            this.lbAlbumTracks.Name = "lbAlbumTracks";
            this.lbAlbumTracks.Size = new System.Drawing.Size(308, 508);
            this.lbAlbumTracks.TabIndex = 0;
            // 
            // btnDebug
            // 
            this.btnDebug.Location = new System.Drawing.Point(1106, 654);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(194, 52);
            this.btnDebug.TabIndex = 1;
            this.btnDebug.Text = "Debug";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // cmbAlbum
            // 
            this.cmbAlbum.FormattingEnabled = true;
            this.cmbAlbum.Location = new System.Drawing.Point(495, 107);
            this.cmbAlbum.Name = "cmbAlbum";
            this.cmbAlbum.Size = new System.Drawing.Size(308, 32);
            this.cmbAlbum.TabIndex = 2;
            this.cmbAlbum.SelectedIndexChanged += new System.EventHandler(this.cmbAlbum_SelectedIndexChanged);
            // 
            // btnRemoveTrack
            // 
            this.btnRemoveTrack.Location = new System.Drawing.Point(871, 659);
            this.btnRemoveTrack.Name = "btnRemoveTrack";
            this.btnRemoveTrack.Size = new System.Drawing.Size(162, 47);
            this.btnRemoveTrack.TabIndex = 3;
            this.btnRemoveTrack.Text = "Remove Track";
            this.btnRemoveTrack.UseVisualStyleBackColor = true;
            this.btnRemoveTrack.Click += new System.EventHandler(this.btnRemoveTrack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 765);
            this.Controls.Add(this.btnRemoveTrack);
            this.Controls.Add(this.cmbAlbum);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.lbAlbumTracks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbAlbumTracks;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.ComboBox cmbAlbum;
        private System.Windows.Forms.Button btnRemoveTrack;
    }
}

