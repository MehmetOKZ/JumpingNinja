namespace FlappyBİrd
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.templeTop = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.templeBottom = new System.Windows.Forms.PictureBox();
            this.jumpingninja = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.templeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumpingninja)).BeginInit();
            this.SuspendLayout();
            // 
            // templeTop
            // 
            this.templeTop.BackColor = System.Drawing.Color.Transparent;
            this.templeTop.Image = ((System.Drawing.Image)(resources.GetObject("templeTop.Image")));
            this.templeTop.Location = new System.Drawing.Point(435, -28);
            this.templeTop.Name = "templeTop";
            this.templeTop.Size = new System.Drawing.Size(116, 231);
            this.templeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.templeTop.TabIndex = 0;
            this.templeTop.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-8, 588);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(580, 78);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // templeBottom
            // 
            this.templeBottom.BackColor = System.Drawing.Color.Transparent;
            this.templeBottom.Image = ((System.Drawing.Image)(resources.GetObject("templeBottom.Image")));
            this.templeBottom.Location = new System.Drawing.Point(347, 381);
            this.templeBottom.Name = "templeBottom";
            this.templeBottom.Size = new System.Drawing.Size(124, 229);
            this.templeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.templeBottom.TabIndex = 2;
            this.templeBottom.TabStop = false;
            // 
            // jumpingninja
            // 
            this.jumpingninja.BackColor = System.Drawing.Color.Transparent;
            this.jumpingninja.Image = ((System.Drawing.Image)(resources.GetObject("jumpingninja.Image")));
            this.jumpingninja.Location = new System.Drawing.Point(52, 252);
            this.jumpingninja.Name = "jumpingninja";
            this.jumpingninja.Size = new System.Drawing.Size(66, 66);
            this.jumpingninja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jumpingninja.TabIndex = 3;
            this.jumpingninja.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.scoreText.Font = new System.Drawing.Font("Javanese Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(-5, 588);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(223, 109);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(563, 660);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.jumpingninja);
            this.Controls.Add(this.templeBottom);
            this.Controls.Add(this.templeTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.templeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumpingninja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox templeTop;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox templeBottom;
        private System.Windows.Forms.PictureBox jumpingninja;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label scoreText;
    }
}

