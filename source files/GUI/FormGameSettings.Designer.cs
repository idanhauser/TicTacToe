namespace TicTacToeGUI
{
    public partial class FormGameSettings
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
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.checkBoxPlayer2 = new System.Windows.Forms.CheckBox();
            this.textBoxNamePlayer2 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelPlayers = new System.Windows.Forms.Label();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.labelBoardSize = new System.Windows.Forms.Label();
            this.textBoxPlayer1Name = new System.Windows.Forms.TextBox();
            this.labelRows = new System.Windows.Forms.Label();
            this.labelCols = new System.Windows.Forms.Label();
            this.numericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCols = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCols)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(90, 607);
            this.buttonStartGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(564, 79);
            this.buttonStartGame.TabIndex = 0;
            this.buttonStartGame.Text = "Start!";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.button_StartGame);
            // 
            // checkBoxPlayer2
            // 
            this.checkBoxPlayer2.AutoSize = true;
            this.checkBoxPlayer2.Location = new System.Drawing.Point(87, 223);
            this.checkBoxPlayer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxPlayer2.Name = "checkBoxPlayer2";
            this.checkBoxPlayer2.Size = new System.Drawing.Size(157, 36);
            this.checkBoxPlayer2.TabIndex = 1;
            this.checkBoxPlayer2.Text = "Player 2";
            this.checkBoxPlayer2.UseVisualStyleBackColor = true;
            this.checkBoxPlayer2.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // textBoxNamePlayer2
            // 
            this.textBoxNamePlayer2.Enabled = false;
            this.textBoxNamePlayer2.Location = new System.Drawing.Point(275, 221);
            this.textBoxNamePlayer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNamePlayer2.Name = "textBoxNamePlayer2";
            this.textBoxNamePlayer2.Size = new System.Drawing.Size(378, 38);
            this.textBoxNamePlayer2.TabIndex = 2;
            this.textBoxNamePlayer2.Text = "[computer]";
            this.textBoxNamePlayer2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(329, 335);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 32);
            this.linkLabel1.TabIndex = 3;
            // 
            // labelPlayers
            // 
            this.labelPlayers.AutoSize = true;
            this.labelPlayers.Location = new System.Drawing.Point(70, 37);
            this.labelPlayers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(118, 32);
            this.labelPlayers.TabIndex = 4;
            this.labelPlayers.Text = "Players:";
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Location = new System.Drawing.Point(125, 138);
            this.labelPlayer1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(119, 32);
            this.labelPlayer1.TabIndex = 5;
            this.labelPlayer1.Text = "Player 1";
            // 
            // labelBoardSize
            // 
            this.labelBoardSize.AutoSize = true;
            this.labelBoardSize.Location = new System.Drawing.Point(70, 421);
            this.labelBoardSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBoardSize.Name = "labelBoardSize";
            this.labelBoardSize.Size = new System.Drawing.Size(157, 32);
            this.labelBoardSize.TabIndex = 6;
            this.labelBoardSize.Text = "Board size:";
            // 
            // textBoxPlayer1Name
            // 
            this.textBoxPlayer1Name.Location = new System.Drawing.Point(275, 134);
            this.textBoxPlayer1Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPlayer1Name.Name = "textBoxPlayer1Name";
            this.textBoxPlayer1Name.Size = new System.Drawing.Size(378, 38);
            this.textBoxPlayer1Name.TabIndex = 7;
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.Location = new System.Drawing.Point(125, 515);
            this.labelRows.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(93, 32);
            this.labelRows.TabIndex = 8;
            this.labelRows.Text = "Rows:";
            // 
            // labelCols
            // 
            this.labelCols.AutoSize = true;
            this.labelCols.Location = new System.Drawing.Point(441, 515);
            this.labelCols.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCols.Name = "labelCols";
            this.labelCols.Size = new System.Drawing.Size(80, 32);
            this.labelCols.TabIndex = 9;
            this.labelCols.Text = "Cols:";
            // 
            // numericUpDownRows
            // 
            this.numericUpDownRows.Location = new System.Drawing.Point(230, 532);
            this.numericUpDownRows.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownRows.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownRows.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownRows.Name = "numericUpDownRows";
            this.numericUpDownRows.Size = new System.Drawing.Size(175, 38);
            this.numericUpDownRows.TabIndex = 11;
            this.numericUpDownRows.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownRows.ValueChanged += new System.EventHandler(this.numericUpDownRows_ValueChanged);
            // 
            // numericUpDownCols
            // 
            this.numericUpDownCols.Location = new System.Drawing.Point(534, 532);
            this.numericUpDownCols.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownCols.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownCols.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownCols.Name = "numericUpDownCols";
            this.numericUpDownCols.Size = new System.Drawing.Size(175, 38);
            this.numericUpDownCols.TabIndex = 12;
            this.numericUpDownCols.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownCols.ValueChanged += new System.EventHandler(this.numericUpDownCols_ValueChanged);
            // 
            // FormGameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 717);
            this.Controls.Add(this.numericUpDownCols);
            this.Controls.Add(this.numericUpDownRows);
            this.Controls.Add(this.labelCols);
            this.Controls.Add(this.labelRows);
            this.Controls.Add(this.textBoxPlayer1Name);
            this.Controls.Add(this.labelBoardSize);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.labelPlayers);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBoxNamePlayer2);
            this.Controls.Add(this.checkBoxPlayer2);
            this.Controls.Add(this.buttonStartGame);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormGameSettings";
            this.Text = "TicTacToe - GameSettings";
            this.Load += new System.EventHandler(this.FormWindowControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.CheckBox checkBoxPlayer2;
        private System.Windows.Forms.TextBox textBoxNamePlayer2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labelPlayers;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Label labelBoardSize;
        private System.Windows.Forms.TextBox textBoxPlayer1Name;
        private System.Windows.Forms.Label labelRows;
       private System.Windows.Forms.Label labelCols;
        private System.Windows.Forms.NumericUpDown numericUpDownRows;
        private System.Windows.Forms.NumericUpDown numericUpDownCols;
    }
}