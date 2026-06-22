namespace Guess_Game
{
    partial class frmGameSettings
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
            this.label2 = new System.Windows.Forms.Label();
            this.UDStartOfRange = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.UDNumOfRounds = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.UDEndOfRange = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UDStartOfRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDNumOfRounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDEndOfRange)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 41);
            this.label2.TabIndex = 11;
            this.label2.Text = "Start Of Range";
            // 
            // UDStartOfRange
            // 
            this.UDStartOfRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UDStartOfRange.Location = new System.Drawing.Point(20, 146);
            this.UDStartOfRange.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.UDStartOfRange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDStartOfRange.Name = "UDStartOfRange";
            this.UDStartOfRange.Size = new System.Drawing.Size(233, 28);
            this.UDStartOfRange.TabIndex = 10;
            this.UDStartOfRange.Tag = "TStartOfRange";
            this.UDStartOfRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UDStartOfRange.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDStartOfRange.ValueChanged += new System.EventHandler(this.UDNumOfRounds_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 41);
            this.label1.TabIndex = 9;
            this.label1.Text = "Num Of Rounds";
            // 
            // UDNumOfRounds
            // 
            this.UDNumOfRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UDNumOfRounds.Location = new System.Drawing.Point(90, 240);
            this.UDNumOfRounds.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.UDNumOfRounds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDNumOfRounds.Name = "UDNumOfRounds";
            this.UDNumOfRounds.Size = new System.Drawing.Size(189, 28);
            this.UDNumOfRounds.TabIndex = 8;
            this.UDNumOfRounds.Tag = "TNumOfRounds";
            this.UDNumOfRounds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UDNumOfRounds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDNumOfRounds.ValueChanged += new System.EventHandler(this.UDNumOfRounds_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 41);
            this.label3.TabIndex = 13;
            this.label3.Text = "End Of Range";
            // 
            // UDEndOfRange
            // 
            this.UDEndOfRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UDEndOfRange.Location = new System.Drawing.Point(295, 146);
            this.UDEndOfRange.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.UDEndOfRange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDEndOfRange.Name = "UDEndOfRange";
            this.UDEndOfRange.Size = new System.Drawing.Size(233, 28);
            this.UDEndOfRange.TabIndex = 12;
            this.UDEndOfRange.Tag = "TEndOfRange";
            this.UDEndOfRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UDEndOfRange.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDEndOfRange.ValueChanged += new System.EventHandler(this.UDNumOfRounds_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.UDEndOfRange);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.UDStartOfRange);
            this.groupBox1.Location = new System.Drawing.Point(438, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 253);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1018, 47);
            this.label4.TabIndex = 15;
            this.label4.Text = "Game Settings";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.UseMnemonic = false;
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnStartGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnStartGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(326, 390);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(321, 48);
            this.btnStartGame.TabIndex = 16;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // frmGameSettings
            // 
            this.AcceptButton = this.btnStartGame;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1018, 450);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UDNumOfRounds);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmGameSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Settings";
            ((System.ComponentModel.ISupportInitialize)(this.UDStartOfRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDNumOfRounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDEndOfRange)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown UDStartOfRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown UDNumOfRounds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown UDEndOfRange;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStartGame;
    }
}

