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
            this.numSeed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numScale = new System.Windows.Forms.NumericUpDown();
            this.chkRandom = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScale)).BeginInit();
            this.SuspendLayout();
            // 
            // picResult
            // 
            this.picResult.BackColor = System.Drawing.Color.White;
            this.picResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picResult.Location = new System.Drawing.Point(12, 76);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(256, 256);
            this.picResult.TabIndex = 0;
            this.picResult.TabStop = false;
            // 
            // btnGenerateSpaceship
            // 
            this.btnGenerateSpaceship.Location = new System.Drawing.Point(12, 338);
            this.btnGenerateSpaceship.Name = "btnGenerateSpaceship";
            this.btnGenerateSpaceship.Size = new System.Drawing.Size(128, 43);
            this.btnGenerateSpaceship.TabIndex = 1;
            this.btnGenerateSpaceship.Text = "Generate spaceship";
            this.btnGenerateSpaceship.UseVisualStyleBackColor = true;
            this.btnGenerateSpaceship.Click += new System.EventHandler(this.btnGenerateSpaceship_click);
            // 
            // numSeed
            // 
            this.numSeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSeed.Location = new System.Drawing.Point(49, 12);
            this.numSeed.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numSeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSeed.Name = "numSeed";
            this.numSeed.ReadOnly = true;
            this.numSeed.Size = new System.Drawing.Size(219, 26);
            this.numSeed.TabIndex = 2;
            this.numSeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Scale";
            // 
            // numericUpDown1
            // 
            this.numScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numScale.Location = new System.Drawing.Point(49, 44);
            this.numScale.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numScale.Name = "numScale";
            this.numScale.Size = new System.Drawing.Size(58, 26);
            this.numScale.TabIndex = 5;
            this.numScale.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // chkRandom
            // 
            this.chkRandom.AutoSize = true;
            this.chkRandom.Checked = true;
            this.chkRandom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandom.Location = new System.Drawing.Point(176, 50);
            this.chkRandom.Name = "chkRandom";
            this.chkRandom.Size = new System.Drawing.Size(92, 17);
            this.chkRandom.TabIndex = 8;
            this.chkRandom.Text = "Random seed";
            this.chkRandom.UseVisualStyleBackColor = true;
            this.chkRandom.CheckedChanged += new System.EventHandler(this.chkRandom_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 390);
            this.Controls.Add(this.chkRandom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numScale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numSeed);
            this.Controls.Add(this.btnGenerateSpaceship);
            this.Controls.Add(this.picResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "PixelThingGenerator test";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.Button btnGenerateSpaceship;
        private System.Windows.Forms.NumericUpDown numSeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numScale;
        private System.Windows.Forms.CheckBox chkRandom;
    }
}

