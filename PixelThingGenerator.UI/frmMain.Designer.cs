namespace PixelThingGenerator
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
            this.picResult = new System.Windows.Forms.PictureBox();
            this.btnGenerateSpaceship = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.SuspendLayout();
            // 
            // picResult
            // 
            this.picResult.BackColor = System.Drawing.Color.White;
            this.picResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picResult.Location = new System.Drawing.Point(12, 12);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(162, 142);
            this.picResult.TabIndex = 0;
            this.picResult.TabStop = false;
            // 
            // btnGenerateSpaceship
            // 
            this.btnGenerateSpaceship.Location = new System.Drawing.Point(180, 12);
            this.btnGenerateSpaceship.Name = "btnGenerateSpaceship";
            this.btnGenerateSpaceship.Size = new System.Drawing.Size(127, 56);
            this.btnGenerateSpaceship.TabIndex = 1;
            this.btnGenerateSpaceship.Text = "Generate spaceship";
            this.btnGenerateSpaceship.UseVisualStyleBackColor = true;
            this.btnGenerateSpaceship.Click += new System.EventHandler(this.btnGenerateSpaceship_click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 166);
            this.Controls.Add(this.btnGenerateSpaceship);
            this.Controls.Add(this.picResult);
            this.Name = "frmMain";
            this.Text = "PixelThingGenerator test";
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.Button btnGenerateSpaceship;
    }
}

