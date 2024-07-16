namespace MusicPlayer
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
            this.previousbtn = new System.Windows.Forms.Button();
            this.nextbtn = new System.Windows.Forms.Button();
            this.volumeScroll = new System.Windows.Forms.TrackBar();
            this.addbtn = new System.Windows.Forms.Button();
            this.Ltb_Musics = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.volumeScroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // previousbtn
            // 
            this.previousbtn.BackColor = System.Drawing.Color.White;
            this.previousbtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousbtn.ForeColor = System.Drawing.Color.Blue;
            this.previousbtn.Location = new System.Drawing.Point(85, 398);
            this.previousbtn.Name = "previousbtn";
            this.previousbtn.Size = new System.Drawing.Size(32, 23);
            this.previousbtn.TabIndex = 7;
            this.previousbtn.Text = "<";
            this.previousbtn.UseVisualStyleBackColor = false;
            this.previousbtn.Click += new System.EventHandler(this.previousbtn_Click);
            // 
            // nextbtn
            // 
            this.nextbtn.BackColor = System.Drawing.Color.White;
            this.nextbtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextbtn.ForeColor = System.Drawing.Color.Blue;
            this.nextbtn.Location = new System.Drawing.Point(114, 398);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(30, 23);
            this.nextbtn.TabIndex = 8;
            this.nextbtn.Text = ">";
            this.nextbtn.UseVisualStyleBackColor = false;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // volumeScroll
            // 
            this.volumeScroll.Location = new System.Drawing.Point(523, 203);
            this.volumeScroll.Maximum = 100;
            this.volumeScroll.Name = "volumeScroll";
            this.volumeScroll.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volumeScroll.Size = new System.Drawing.Size(45, 104);
            this.volumeScroll.TabIndex = 17;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(423, 382);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(365, 23);
            this.addbtn.TabIndex = 19;
            this.addbtn.Text = "اضافه کردن ";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // Ltb_Musics
            // 
            this.Ltb_Musics.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltb_Musics.ForeColor = System.Drawing.Color.Blue;
            this.Ltb_Musics.FormattingEnabled = true;
            this.Ltb_Musics.ItemHeight = 18;
            this.Ltb_Musics.Location = new System.Drawing.Point(432, 48);
            this.Ltb_Musics.Name = "Ltb_Musics";
            this.Ltb_Musics.Size = new System.Drawing.Size(356, 328);
            this.Ltb_Musics.TabIndex = 20;
            this.Ltb_Musics.SelectedIndexChanged += new System.EventHandler(this.Ltb_Musics_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "جستجو در لیست";
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(509, 12);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(256, 21);
            this.searchtxt.TabIndex = 27;
            this.searchtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 55);
            this.label1.TabIndex = 28;
            this.label1.Text = "Music Player";
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(31, 67);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(386, 361);
            this.Player.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ltb_Musics);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.volumeScroll);
            this.Controls.Add(this.nextbtn);
            this.Controls.Add(this.previousbtn);
            this.Controls.Add(this.Player);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Music Player";
            ((System.ComponentModel.ISupportInitialize)(this.volumeScroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button previousbtn;
        private System.Windows.Forms.Button nextbtn;
        private System.Windows.Forms.TrackBar volumeScroll;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.ListBox Ltb_Musics;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Label label1;
    }
}

