namespace Igra
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mainPlayer = new System.Windows.Forms.PictureBox();
            this.RightMove = new System.Windows.Forms.Timer(this.components);
            this.moveUp = new System.Windows.Forms.Timer(this.components);
            this.moveDown = new System.Windows.Forms.Timer(this.components);
            this.LeftMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveSwordTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mainPlayer
            // 
            this.mainPlayer.BackColor = System.Drawing.Color.Transparent;
            this.mainPlayer.Image = global::Igra.Properties.Resources.sV7Mefu;
            this.mainPlayer.Location = new System.Drawing.Point(12, 426);
            this.mainPlayer.Name = "mainPlayer";
            this.mainPlayer.Size = new System.Drawing.Size(143, 243);
            this.mainPlayer.TabIndex = 0;
            this.mainPlayer.TabStop = false;
            // 
            // RightMove
            // 
            this.RightMove.Interval = 50;
            this.RightMove.Tick += new System.EventHandler(this.RightMove_Tick);
            // 
            // moveUp
            // 
            this.moveUp.Interval = 50;
            this.moveUp.Tick += new System.EventHandler(this.moveUp_Tick);
            // 
            // moveDown
            // 
            this.moveDown.Interval = 50;
            this.moveDown.Tick += new System.EventHandler(this.moveDown_Tick);
            // 
            // LeftMoveTimer
            // 
            this.LeftMoveTimer.Interval = 50;
            this.LeftMoveTimer.Tick += new System.EventHandler(this.LeftMoveTimer_Tick);
            // 
            // MoveSwordTimer
            // 
            this.MoveSwordTimer.Enabled = true;
            this.MoveSwordTimer.Tick += new System.EventHandler(this.MoveSwordTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.mainPlayer);
            this.Name = "Form1";
            this.Text = "2D Platformer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox mainPlayer;
        private System.Windows.Forms.Timer RightMove;
        private System.Windows.Forms.Timer moveUp;
        private System.Windows.Forms.Timer moveDown;
        private System.Windows.Forms.Timer LeftMoveTimer;
        private System.Windows.Forms.Timer MoveSwordTimer;
    }
}

