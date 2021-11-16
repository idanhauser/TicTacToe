namespace TicTacToeGUI
{
   public partial class FormTicTacToeMisere
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
            this.player1Lable = new System.Windows.Forms.Label();
            this.player2Lable = new System.Windows.Forms.Label();
            this.player1Score = new System.Windows.Forms.Label();
            this.player2Score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // player1Lable
            // 
            this.player1Lable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.player1Lable.Location = new System.Drawing.Point(29, 342);
            this.player1Lable.Name = "player1Lable";
            this.player1Lable.Size = new System.Drawing.Size(124, 32);
            this.player1Lable.TabIndex = 0;
            this.player1Lable.Text = "player 1: ";
            // 
            // player2Lable
            // 
            this.player2Lable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.player2Lable.AutoSize = true;
            this.player2Lable.Location = new System.Drawing.Point(259, 342);
            this.player2Lable.Margin = new System.Windows.Forms.Padding(3);
            this.player2Lable.Name = "player2Lable";
            this.player2Lable.Size = new System.Drawing.Size(131, 32);
            this.player2Lable.TabIndex = 1;
            this.player2Lable.Text = "player 2: ";
            this.player2Lable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // player1Score
            // 
            this.player1Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.player1Score.AutoSize = true;
            this.player1Score.Location = new System.Drawing.Point(149, 342);
            this.player1Score.Name = "player1Score";
            this.player1Score.Size = new System.Drawing.Size(31, 32);
            this.player1Score.TabIndex = 2;
            this.player1Score.Text = "0";
            // 
            // player2Score
            // 
            this.player2Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.player2Score.AutoSize = true;
            this.player2Score.Location = new System.Drawing.Point(379, 342);
            this.player2Score.Name = "player2Score";
            this.player2Score.Size = new System.Drawing.Size(31, 32);
            this.player2Score.TabIndex = 3;
            this.player2Score.Text = "0";
            this.player2Score.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormTicTacToeMisere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 396);
            this.Controls.Add(this.player2Score);
            this.Controls.Add(this.player1Score);
            this.Controls.Add(this.player2Lable);
            this.Controls.Add(this.player1Lable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(500, 500);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormTicTacToeMisere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTicTacToeMisere";
            this.Load += new System.EventHandler(this.FormTicTacToeMisere_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player1Lable;
        private System.Windows.Forms.Label player2Lable;
        private System.Windows.Forms.Label player1Score;
        private System.Windows.Forms.Label player2Score;
    }
}