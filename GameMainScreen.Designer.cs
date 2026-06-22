namespace Guess_Game
{
    partial class frmGameMainScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labStartRange = new System.Windows.Forms.Label();
            this.labEndRange = new System.Windows.Forms.Label();
            this.labNumOfRounds = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UserInput = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Range";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "End Range";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Remaining Num Of Rounds";
            // 
            // labStartRange
            // 
            this.labStartRange.AutoSize = true;
            this.labStartRange.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labStartRange.Location = new System.Drawing.Point(146, 78);
            this.labStartRange.Name = "labStartRange";
            this.labStartRange.Size = new System.Drawing.Size(38, 40);
            this.labStartRange.TabIndex = 3;
            this.labStartRange.Text = "1";
            // 
            // labEndRange
            // 
            this.labEndRange.AutoSize = true;
            this.labEndRange.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEndRange.Location = new System.Drawing.Point(146, 219);
            this.labEndRange.Name = "labEndRange";
            this.labEndRange.Size = new System.Drawing.Size(38, 40);
            this.labEndRange.TabIndex = 4;
            this.labEndRange.Text = "1";
            // 
            // labNumOfRounds
            // 
            this.labNumOfRounds.AutoSize = true;
            this.labNumOfRounds.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNumOfRounds.Location = new System.Drawing.Point(146, 366);
            this.labNumOfRounds.Name = "labNumOfRounds";
            this.labNumOfRounds.Size = new System.Drawing.Size(38, 40);
            this.labNumOfRounds.TabIndex = 5;
            this.labNumOfRounds.Text = "1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.labNumOfRounds);
            this.groupBox1.Controls.Add(this.labEndRange);
            this.groupBox1.Controls.Add(this.labStartRange);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 454);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // UserInput
            // 
            this.UserInput.BackColor = System.Drawing.SystemColors.MenuBar;
            this.UserInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserInput.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.UserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInput.Location = new System.Drawing.Point(551, 280);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(300, 54);
            this.UserInput.TabIndex = 7;
            this.UserInput.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(544, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter Your Answer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Guess_Game.Properties.Resources.question_mark_96;
            this.pictureBox1.Location = new System.Drawing.Point(646, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCheck.Location = new System.Drawing.Point(551, 360);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(309, 51);
            this.btnCheck.TabIndex = 10;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // frmGameMainScreen
            // 
            this.AcceptButton = this.btnCheck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1022, 454);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGameMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameMainScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameMainScreen_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labStartRange;
        private System.Windows.Forms.Label labEndRange;
        private System.Windows.Forms.Label labNumOfRounds;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox UserInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCheck;
    }
}