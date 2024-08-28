namespace SpaceSooterNew
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
            this.Timer_background = new System.Windows.Forms.Timer(this.components);
            this.MoveLeft = new System.Windows.Forms.Timer(this.components);
            this.MoveRight = new System.Windows.Forms.Timer(this.components);
            this.MoveUp = new System.Windows.Forms.Timer(this.components);
            this.MoveDown = new System.Windows.Forms.Timer(this.components);
            this.bulletsMove = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer_background
            // 
            this.Timer_background.Enabled = true;
            this.Timer_background.Interval = 10;
            this.Timer_background.Tick += new System.EventHandler(this.Timer_background_Tick);
            // 
            // MoveLeft
            // 
            this.MoveLeft.Interval = 5;
            this.MoveLeft.Tick += new System.EventHandler(this.MoveLeft_Tick);
            // 
            // MoveRight
            // 
            this.MoveRight.Interval = 5;
            this.MoveRight.Tick += new System.EventHandler(this.MoveRight_Tick);
            // 
            // MoveUp
            // 
            this.MoveUp.Interval = 5;
            this.MoveUp.Tick += new System.EventHandler(this.MoveTop_Tick);
            // 
            // MoveDown
            // 
            this.MoveDown.Interval = 5;
            this.MoveDown.Tick += new System.EventHandler(this.MoveDown_Tick);
            // 
            // bulletsMove
            // 
            this.bulletsMove.Interval = 1;
            this.bulletsMove.Tick += new System.EventHandler(this.bulletsMove_Tick);
            // 
            // Player
            // 
            this.Player.BackgroundImage = global::SpaceSooterNew.Properties.Resources.player;
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Player.Location = new System.Drawing.Point(224, 610);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(82, 58);
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(582, 680);
            this.Controls.Add(this.Player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 727);
            this.MinimumSize = new System.Drawing.Size(600, 727);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer_background;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer MoveLeft;
        private System.Windows.Forms.Timer MoveRight;
        private System.Windows.Forms.Timer MoveUp;
        private System.Windows.Forms.Timer MoveDown;
        private System.Windows.Forms.Timer bulletsMove;
    }
}

