namespace PIngPong
{
    partial class Form1
    {
       

        private System.ComponentModel.IContainer components = null;

        

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.background = new System.Windows.Forms.Panel();
            this.loseLabel = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.gameBall = new System.Windows.Forms.PictureBox();
            this.gamePanel = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePanel)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.SystemColors.ControlLight;
            this.background.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("background.BackgroundImage")));
            this.background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.background.Controls.Add(this.loseLabel);
            this.background.Controls.Add(this.result);
            this.background.Controls.Add(this.gameBall);
            this.background.Controls.Add(this.gamePanel);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Margin = new System.Windows.Forms.Padding(4);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1067, 554);
            this.background.TabIndex = 0;
            this.background.Paint += new System.Windows.Forms.PaintEventHandler(this.background_Paint);
            // 
            // loseLabel
            // 
            this.loseLabel.AutoSize = true;
            this.loseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loseLabel.Location = new System.Drawing.Point(339, 229);
            this.loseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loseLabel.Name = "loseLabel";
            this.loseLabel.Size = new System.Drawing.Size(401, 59);
            this.loseLabel.TabIndex = 3;
            this.loseLabel.Text = "Игра окончена!";
            // 
            // result
            // 
            this.result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Arial Black", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(800, 32);
            this.result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(223, 41);
            this.result.TabIndex = 2;
            this.result.Text = "Результат: 0";
            // 
            // gameBall
            // 
            this.gameBall.BackColor = System.Drawing.Color.White;
            this.gameBall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameBall.BackgroundImage")));
            this.gameBall.Location = new System.Drawing.Point(264, 229);
            this.gameBall.Margin = new System.Windows.Forms.Padding(4);
            this.gameBall.Name = "gameBall";
            this.gameBall.Size = new System.Drawing.Size(76, 68);
            this.gameBall.TabIndex = 1;
            this.gameBall.TabStop = false;
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.White;
            this.gamePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gamePanel.BackgroundImage")));
            this.gamePanel.Location = new System.Drawing.Point(52, 450);
            this.gamePanel.Margin = new System.Windows.Forms.Padding(4);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(607, 32);
            this.gamePanel.TabIndex = 0;
            this.gamePanel.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.background);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.PictureBox gameBall;
        private System.Windows.Forms.PictureBox gamePanel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label loseLabel;
    }
}

