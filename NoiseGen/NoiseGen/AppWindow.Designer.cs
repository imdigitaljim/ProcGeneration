namespace NoiseGen
{
    partial class AppWindow
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
            this.MapBox = new System.Windows.Forms.PictureBox();
            this.Generate = new System.Windows.Forms.Button();
            this.TXTWidth = new System.Windows.Forms.TextBox();
            this.LBLWidth = new System.Windows.Forms.Label();
            this.LBLHeight = new System.Windows.Forms.Label();
            this.TXTHeight = new System.Windows.Forms.TextBox();
            this.BARnoise = new System.Windows.Forms.TrackBar();
            this.LBLnoise = new System.Windows.Forms.Label();
            this.BTNstart = new System.Windows.Forms.Button();
            this.BTNfinish = new System.Windows.Forms.Button();
            this.BTNbfs = new System.Windows.Forms.Button();
            this.BTNdji = new System.Windows.Forms.Button();
            this.BTNAstar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MapBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BARnoise)).BeginInit();
            this.SuspendLayout();
            // 
            // MapBox
            // 
            this.MapBox.Location = new System.Drawing.Point(13, 10);
            this.MapBox.Name = "MapBox";
            this.MapBox.Size = new System.Drawing.Size(500, 500);
            this.MapBox.TabIndex = 0;
            this.MapBox.TabStop = false;
            this.MapBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MapBox_MouseClick);
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(13, 526);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(75, 23);
            this.Generate.TabIndex = 1;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // TXTWidth
            // 
            this.TXTWidth.Location = new System.Drawing.Point(120, 529);
            this.TXTWidth.Name = "TXTWidth";
            this.TXTWidth.Size = new System.Drawing.Size(100, 20);
            this.TXTWidth.TabIndex = 2;
            this.TXTWidth.Text = "50";
            // 
            // LBLWidth
            // 
            this.LBLWidth.AutoSize = true;
            this.LBLWidth.Location = new System.Drawing.Point(117, 516);
            this.LBLWidth.Name = "LBLWidth";
            this.LBLWidth.Size = new System.Drawing.Size(35, 13);
            this.LBLWidth.TabIndex = 4;
            this.LBLWidth.Text = "Width";
            // 
            // LBLHeight
            // 
            this.LBLHeight.AutoSize = true;
            this.LBLHeight.Location = new System.Drawing.Point(226, 516);
            this.LBLHeight.Name = "LBLHeight";
            this.LBLHeight.Size = new System.Drawing.Size(38, 13);
            this.LBLHeight.TabIndex = 3;
            this.LBLHeight.Text = "Height";
            // 
            // TXTHeight
            // 
            this.TXTHeight.Location = new System.Drawing.Point(226, 529);
            this.TXTHeight.Name = "TXTHeight";
            this.TXTHeight.Size = new System.Drawing.Size(100, 20);
            this.TXTHeight.TabIndex = 5;
            this.TXTHeight.Text = "50";
            // 
            // BARnoise
            // 
            this.BARnoise.Location = new System.Drawing.Point(332, 516);
            this.BARnoise.Name = "BARnoise";
            this.BARnoise.Size = new System.Drawing.Size(181, 45);
            this.BARnoise.TabIndex = 6;
            this.BARnoise.Value = 5;
            this.BARnoise.Scroll += new System.EventHandler(this.BarNoise_Scroll);
            // 
            // LBLnoise
            // 
            this.LBLnoise.AutoSize = true;
            this.LBLnoise.Location = new System.Drawing.Point(520, 516);
            this.LBLnoise.Name = "LBLnoise";
            this.LBLnoise.Size = new System.Drawing.Size(40, 13);
            this.LBLnoise.TabIndex = 7;
            this.LBLnoise.Text = "Noise: ";
            // 
            // BTNstart
            // 
            this.BTNstart.Location = new System.Drawing.Point(519, 12);
            this.BTNstart.Name = "BTNstart";
            this.BTNstart.Size = new System.Drawing.Size(77, 23);
            this.BTNstart.TabIndex = 8;
            this.BTNstart.Text = "Start";
            this.BTNstart.UseVisualStyleBackColor = true;
            this.BTNstart.Visible = false;
            this.BTNstart.Click += new System.EventHandler(this.BTNstart_Click);
            // 
            // BTNfinish
            // 
            this.BTNfinish.Location = new System.Drawing.Point(519, 41);
            this.BTNfinish.Name = "BTNfinish";
            this.BTNfinish.Size = new System.Drawing.Size(77, 23);
            this.BTNfinish.TabIndex = 9;
            this.BTNfinish.Text = "Finish";
            this.BTNfinish.UseVisualStyleBackColor = true;
            this.BTNfinish.Visible = false;
            this.BTNfinish.Click += new System.EventHandler(this.BTNfinish_Click);
            // 
            // BTNbfs
            // 
            this.BTNbfs.Location = new System.Drawing.Point(519, 141);
            this.BTNbfs.Name = "BTNbfs";
            this.BTNbfs.Size = new System.Drawing.Size(77, 23);
            this.BTNbfs.TabIndex = 10;
            this.BTNbfs.Text = "BFS";
            this.BTNbfs.UseVisualStyleBackColor = true;
            this.BTNbfs.Click += new System.EventHandler(this.BTNbfs_Click);
            // 
            // BTNdji
            // 
            this.BTNdji.Location = new System.Drawing.Point(519, 170);
            this.BTNdji.Name = "BTNdji";
            this.BTNdji.Size = new System.Drawing.Size(77, 23);
            this.BTNdji.TabIndex = 11;
            this.BTNdji.Text = "DJISTRIKA";
            this.BTNdji.UseVisualStyleBackColor = true;
            this.BTNdji.Click += new System.EventHandler(this.BTNdfs_Click);
            // 
            // BTNAstar
            // 
            this.BTNAstar.Location = new System.Drawing.Point(519, 199);
            this.BTNAstar.Name = "BTNAstar";
            this.BTNAstar.Size = new System.Drawing.Size(77, 23);
            this.BTNAstar.TabIndex = 12;
            this.BTNAstar.Text = "A*";
            this.BTNAstar.UseVisualStyleBackColor = true;
            this.BTNAstar.Click += new System.EventHandler(this.BTNAstar_Click);
            // 
            // AppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 561);
            this.Controls.Add(this.BTNAstar);
            this.Controls.Add(this.BTNdji);
            this.Controls.Add(this.BTNbfs);
            this.Controls.Add(this.BTNfinish);
            this.Controls.Add(this.BTNstart);
            this.Controls.Add(this.LBLnoise);
            this.Controls.Add(this.BARnoise);
            this.Controls.Add(this.TXTHeight);
            this.Controls.Add(this.LBLWidth);
            this.Controls.Add(this.LBLHeight);
            this.Controls.Add(this.TXTWidth);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.MapBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppWindow";
            this.Text = "NoiseMap";
            ((System.ComponentModel.ISupportInitialize)(this.MapBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BARnoise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BTNdfs_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void BTNAstar_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }




        #endregion

        public System.Windows.Forms.PictureBox MapBox;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.TextBox TXTWidth;
        private System.Windows.Forms.Label LBLWidth;
        private System.Windows.Forms.Label LBLHeight;
        private System.Windows.Forms.TextBox TXTHeight;
        private System.Windows.Forms.TrackBar BARnoise;
        private System.Windows.Forms.Label LBLnoise;
        private System.Windows.Forms.Button BTNstart;
        private System.Windows.Forms.Button BTNfinish;
        private System.Windows.Forms.Button BTNbfs;
        private System.Windows.Forms.Button BTNdji;
        private System.Windows.Forms.Button BTNAstar;
    }
}

