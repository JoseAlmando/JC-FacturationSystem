
namespace JCFracturationSystem
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.welcomeLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.msgLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timerLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.timerHours = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AllowParentOverrides = false;
            this.welcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.welcomeLabel.AutoEllipsis = false;
            this.welcomeLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.welcomeLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(70, 51);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.welcomeLabel.Size = new System.Drawing.Size(142, 45);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome:";
            this.welcomeLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.welcomeLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.welcomeLabel.Click += new System.EventHandler(this.welcomeLabel_Click);
            // 
            // msgLabel
            // 
            this.msgLabel.AllowParentOverrides = false;
            this.msgLabel.AutoEllipsis = false;
            this.msgLabel.CursorType = null;
            this.msgLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.msgLabel.ForeColor = System.Drawing.Color.White;
            this.msgLabel.Location = new System.Drawing.Point(321, 190);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.msgLabel.Size = new System.Drawing.Size(388, 45);
            this.msgLabel.TabIndex = 1;
            this.msgLabel.Text = "we are building the system";
            this.msgLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.msgLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.pictureBox1.Image = global::JCFracturationSystem.Properties.Resources.Construction_cuate;
            this.pictureBox1.Location = new System.Drawing.Point(288, 271);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 398);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // timerLabel
            // 
            this.timerLabel.AllowParentOverrides = false;
            this.timerLabel.AutoEllipsis = false;
            this.timerLabel.CursorType = null;
            this.timerLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.timerLabel.ForeColor = System.Drawing.Color.White;
            this.timerLabel.Location = new System.Drawing.Point(933, 643);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timerLabel.Size = new System.Drawing.Size(122, 45);
            this.timerLabel.TabIndex = 3;
            this.timerLabel.Text = "00:00:00";
            this.timerLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.timerLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.timerLabel.Click += new System.EventHandler(this.timerLabel_Click);
            // 
            // timerHours
            // 
            this.timerHours.Enabled = true;
            this.timerHours.Interval = 1000;
            this.timerHours.Tick += new System.EventHandler(this.timerHours_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1067, 700);
            this.ControlBox = false;
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.welcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public Bunifu.UI.WinForms.BunifuLabel msgLabel;
        public Bunifu.UI.WinForms.BunifuLabel welcomeLabel;
        public Bunifu.UI.WinForms.BunifuLabel timerLabel;
        private System.Windows.Forms.Timer timerHours;
    }
}