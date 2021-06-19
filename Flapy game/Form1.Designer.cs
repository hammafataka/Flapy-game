
namespace Flapy_game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TopPipe = new System.Windows.Forms.PictureBox();
            this.ObjectPlayer = new System.Windows.Forms.PictureBox();
            this.BottumPipe = new System.Windows.Forms.PictureBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Ground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TopPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottumPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPipe
            // 
            this.TopPipe.Image = global::Flapy_game.Properties.Resources.pipedown;
            this.TopPipe.Location = new System.Drawing.Point(542, -220);
            this.TopPipe.Name = "TopPipe";
            this.TopPipe.Size = new System.Drawing.Size(146, 526);
            this.TopPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TopPipe.TabIndex = 1;
            this.TopPipe.TabStop = false;
            // 
            // ObjectPlayer
            // 
            this.ObjectPlayer.Image = global::Flapy_game.Properties.Resources.bird1;
            this.ObjectPlayer.Location = new System.Drawing.Point(105, 346);
            this.ObjectPlayer.Name = "ObjectPlayer";
            this.ObjectPlayer.Size = new System.Drawing.Size(120, 84);
            this.ObjectPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ObjectPlayer.TabIndex = 2;
            this.ObjectPlayer.TabStop = false;
            // 
            // BottumPipe
            // 
            this.BottumPipe.Image = global::Flapy_game.Properties.Resources.pipe;
            this.BottumPipe.Location = new System.Drawing.Point(542, 552);
            this.BottumPipe.Name = "BottumPipe";
            this.BottumPipe.Size = new System.Drawing.Size(146, 486);
            this.BottumPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BottumPipe.TabIndex = 3;
            this.BottumPipe.TabStop = false;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScoreLabel.Location = new System.Drawing.Point(12, 12);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(172, 57);
            this.ScoreLabel.TabIndex = 4;
            this.ScoreLabel.Text = "Score: 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.Game_Timer_Event);
            // 
            // Ground
            // 
            this.Ground.Image = global::Flapy_game.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(-6, 823);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(1857, 91);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 5;
            this.Ground.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1540, 907);
            this.Controls.Add(this.ObjectPlayer);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.BottumPipe);
            this.Controls.Add(this.TopPipe);
            this.Controls.Add(this.ScoreLabel);
            this.Name = "Form1";
            this.Text = "Flappy game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_Key_Down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_Key_Up);
            ((System.ComponentModel.ISupportInitialize)(this.TopPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottumPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox TopPipe;
        private System.Windows.Forms.PictureBox ObjectPlayer;
        private System.Windows.Forms.PictureBox BottumPipe;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox Ground;
    }
}

