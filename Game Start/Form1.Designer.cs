namespace Game_Start
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
            this.startButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.gameScreen = new System.Windows.Forms.PictureBox();
            this.beginLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Firebrick;
            this.startButton.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(277, 361);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(365, 62);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(281, 448);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(353, 33);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.Text = "Game starting in 3";
            this.outputLabel.Visible = false;
            // 
            // gameScreen
            // 
            this.gameScreen.Image = ((System.Drawing.Image)(resources.GetObject("gameScreen.Image")));
            this.gameScreen.InitialImage = ((System.Drawing.Image)(resources.GetObject("gameScreen.InitialImage")));
            this.gameScreen.Location = new System.Drawing.Point(0, -1);
            this.gameScreen.Name = "gameScreen";
            this.gameScreen.Size = new System.Drawing.Size(895, 512);
            this.gameScreen.TabIndex = 2;
            this.gameScreen.TabStop = false;
            this.gameScreen.Visible = false;
            // 
            // beginLabel
            // 
            this.beginLabel.BackColor = System.Drawing.Color.Transparent;
            this.beginLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginLabel.ForeColor = System.Drawing.Color.White;
            this.beginLabel.Location = new System.Drawing.Point(283, 22);
            this.beginLabel.Name = "beginLabel";
            this.beginLabel.Size = new System.Drawing.Size(353, 63);
            this.beginLabel.TabIndex = 3;
            this.beginLabel.Text = "Begin!";
            this.beginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.beginLabel.Visible = false;
            this.beginLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(892, 506);
            this.Controls.Add(this.beginLabel);
            this.Controls.Add(this.gameScreen);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gameScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.PictureBox gameScreen;
        private System.Windows.Forms.Label beginLabel;
    }
}

