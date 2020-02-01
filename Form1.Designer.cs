namespace CD_Minder
{
    partial class frmMain
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
            this.txtDataEntry = new System.Windows.Forms.TextBox();
            this.lblArtistInformation = new System.Windows.Forms.Label();
            this.cD_DatabaseDataSet = new CD_Minder.CD_DatabaseDataSet();
            this.lstArtistInformation = new System.Windows.Forms.ListBox();
            this.lstSongInformation = new System.Windows.Forms.ListBox();
            this.lblSongInformation = new System.Windows.Forms.Label();
            this.btnAddArtist = new System.Windows.Forms.Button();
            this.lblDataEntry = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnUpdateArtist = new System.Windows.Forms.Button();
            this.btnUpdateSongName = new System.Windows.Forms.Button();
            this.lstAllSongs = new System.Windows.Forms.ListBox();
            this.lblAllSongs = new System.Windows.Forms.Label();
            this.butSongs = new System.Windows.Forms.Button();
            this.btnDeleteArtist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cD_DatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDataEntry
            // 
            this.txtDataEntry.Location = new System.Drawing.Point(12, 36);
            this.txtDataEntry.Name = "txtDataEntry";
            this.txtDataEntry.Size = new System.Drawing.Size(379, 20);
            this.txtDataEntry.TabIndex = 0;
            // 
            // lblArtistInformation
            // 
            this.lblArtistInformation.AutoSize = true;
            this.lblArtistInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistInformation.Location = new System.Drawing.Point(12, 76);
            this.lblArtistInformation.Name = "lblArtistInformation";
            this.lblArtistInformation.Size = new System.Drawing.Size(132, 17);
            this.lblArtistInformation.TabIndex = 1;
            this.lblArtistInformation.Text = "Artist Information";
            // 
            // cD_DatabaseDataSet
            // 
            this.cD_DatabaseDataSet.DataSetName = "CD_DatabaseDataSet";
            this.cD_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lstArtistInformation
            // 
            this.lstArtistInformation.FormattingEnabled = true;
            this.lstArtistInformation.Location = new System.Drawing.Point(15, 96);
            this.lstArtistInformation.Name = "lstArtistInformation";
            this.lstArtistInformation.Size = new System.Drawing.Size(120, 173);
            this.lstArtistInformation.TabIndex = 2;
            this.lstArtistInformation.SelectedIndexChanged += new System.EventHandler(this.lstArtistInformation_SelectedIndexChanged);
            // 
            // lstSongInformation
            // 
            this.lstSongInformation.FormattingEnabled = true;
            this.lstSongInformation.Location = new System.Drawing.Point(170, 96);
            this.lstSongInformation.Name = "lstSongInformation";
            this.lstSongInformation.Size = new System.Drawing.Size(205, 173);
            this.lstSongInformation.TabIndex = 4;
            // 
            // lblSongInformation
            // 
            this.lblSongInformation.AutoSize = true;
            this.lblSongInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongInformation.Location = new System.Drawing.Point(167, 76);
            this.lblSongInformation.Name = "lblSongInformation";
            this.lblSongInformation.Size = new System.Drawing.Size(76, 17);
            this.lblSongInformation.TabIndex = 3;
            this.lblSongInformation.Text = "Song List";
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.Location = new System.Drawing.Point(15, 275);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(75, 23);
            this.btnAddArtist.TabIndex = 5;
            this.btnAddArtist.Text = "Add Artist";
            this.btnAddArtist.UseVisualStyleBackColor = true;
            this.btnAddArtist.Click += new System.EventHandler(this.btnAddArtist_Click);
            // 
            // lblDataEntry
            // 
            this.lblDataEntry.AutoSize = true;
            this.lblDataEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntry.Location = new System.Drawing.Point(12, 16);
            this.lblDataEntry.Name = "lblDataEntry";
            this.lblDataEntry.Size = new System.Drawing.Size(139, 17);
            this.lblDataEntry.TabIndex = 6;
            this.lblDataEntry.Text = "Insert values here";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(407, 36);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear Value";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(407, 275);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(75, 36);
            this.btnAddSong.TabIndex = 8;
            this.btnAddSong.Text = "Add Song To Artist";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // btnUpdateArtist
            // 
            this.btnUpdateArtist.Location = new System.Drawing.Point(15, 305);
            this.btnUpdateArtist.Name = "btnUpdateArtist";
            this.btnUpdateArtist.Size = new System.Drawing.Size(75, 35);
            this.btnUpdateArtist.TabIndex = 9;
            this.btnUpdateArtist.Text = "Update Artist";
            this.btnUpdateArtist.UseVisualStyleBackColor = true;
            this.btnUpdateArtist.Click += new System.EventHandler(this.btnUpdateArtist_Click_1);
            // 
            // btnUpdateSongName
            // 
            this.btnUpdateSongName.Location = new System.Drawing.Point(475, 318);
            this.btnUpdateSongName.Name = "btnUpdateSongName";
            this.btnUpdateSongName.Size = new System.Drawing.Size(75, 35);
            this.btnUpdateSongName.TabIndex = 10;
            this.btnUpdateSongName.Text = "Update Song";
            this.btnUpdateSongName.UseVisualStyleBackColor = true;
            this.btnUpdateSongName.Click += new System.EventHandler(this.btnUpdateSongName_Click);
            // 
            // lstAllSongs
            // 
            this.lstAllSongs.FormattingEnabled = true;
            this.lstAllSongs.Location = new System.Drawing.Point(407, 96);
            this.lstAllSongs.Name = "lstAllSongs";
            this.lstAllSongs.Size = new System.Drawing.Size(205, 173);
            this.lstAllSongs.TabIndex = 12;
            // 
            // lblAllSongs
            // 
            this.lblAllSongs.AutoSize = true;
            this.lblAllSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllSongs.ForeColor = System.Drawing.Color.Black;
            this.lblAllSongs.Location = new System.Drawing.Point(404, 76);
            this.lblAllSongs.Name = "lblAllSongs";
            this.lblAllSongs.Size = new System.Drawing.Size(88, 17);
            this.lblAllSongs.TabIndex = 11;
            this.lblAllSongs.Text = "Master List";
            // 
            // butSongs
            // 
            this.butSongs.Location = new System.Drawing.Point(537, 275);
            this.butSongs.Name = "butSongs";
            this.butSongs.Size = new System.Drawing.Size(75, 36);
            this.butSongs.TabIndex = 13;
            this.butSongs.Text = "Add To Master List";
            this.butSongs.UseVisualStyleBackColor = true;
            this.butSongs.Click += new System.EventHandler(this.butSongs_Click);
            // 
            // btnDeleteArtist
            // 
            this.btnDeleteArtist.Location = new System.Drawing.Point(15, 347);
            this.btnDeleteArtist.Name = "btnDeleteArtist";
            this.btnDeleteArtist.Size = new System.Drawing.Size(75, 39);
            this.btnDeleteArtist.TabIndex = 14;
            this.btnDeleteArtist.Text = "Remove Artist";
            this.btnDeleteArtist.UseVisualStyleBackColor = true;
            this.btnDeleteArtist.Click += new System.EventHandler(this.btnDeleteArtist_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(628, 406);
            this.Controls.Add(this.btnDeleteArtist);
            this.Controls.Add(this.butSongs);
            this.Controls.Add(this.lstAllSongs);
            this.Controls.Add(this.lblAllSongs);
            this.Controls.Add(this.btnUpdateSongName);
            this.Controls.Add(this.btnUpdateArtist);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblDataEntry);
            this.Controls.Add(this.btnAddArtist);
            this.Controls.Add(this.lstSongInformation);
            this.Controls.Add(this.lblSongInformation);
            this.Controls.Add(this.lstArtistInformation);
            this.Controls.Add(this.lblArtistInformation);
            this.Controls.Add(this.txtDataEntry);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "CD Minder";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cD_DatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDataEntry;
        private System.Windows.Forms.Label lblArtistInformation;
        private CD_DatabaseDataSet cD_DatabaseDataSet;
        private System.Windows.Forms.ListBox lstArtistInformation;
        private System.Windows.Forms.ListBox lstSongInformation;
        private System.Windows.Forms.Label lblSongInformation;
        private System.Windows.Forms.Button btnAddArtist;
        private System.Windows.Forms.Label lblDataEntry;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btnUpdateArtist;
        private System.Windows.Forms.Button btnUpdateSongName;
        private System.Windows.Forms.ListBox lstAllSongs;
        private System.Windows.Forms.Label lblAllSongs;
        private System.Windows.Forms.Button butSongs;
        private System.Windows.Forms.Button btnDeleteArtist;
    }
}

