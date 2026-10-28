namespace test
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
            this.birb = new System.Windows.Forms.PictureBox();
            this.JumpButton = new System.Windows.Forms.Button();
            this.FrameTimer = new System.Windows.Forms.Timer(this.components);
            this.UpperPipe2 = new System.Windows.Forms.PictureBox();
            this.LowerPipe1 = new System.Windows.Forms.PictureBox();
            this.UpperPipe1 = new System.Windows.Forms.PictureBox();
            this.LowerPipe2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpperPipe3 = new System.Windows.Forms.PictureBox();
            this.LowerPipe3 = new System.Windows.Forms.PictureBox();
            this.EndText = new System.Windows.Forms.Label();
            this.Debug0 = new System.Windows.Forms.Label();
            this.Debug1 = new System.Windows.Forms.Label();
            this.Debug2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.birb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpperPipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerPipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpperPipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerPipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpperPipe3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerPipe3)).BeginInit();
            this.SuspendLayout();
            // 
            // birb
            // 
            this.birb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.birb.Image = ((System.Drawing.Image)(resources.GetObject("birb.Image")));
            this.birb.Location = new System.Drawing.Point(125, 150);
            this.birb.Name = "birb";
            this.birb.Size = new System.Drawing.Size(80, 80);
            this.birb.TabIndex = 0;
            this.birb.TabStop = false;
            // 
            // JumpButton
            // 
            this.JumpButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.JumpButton.Location = new System.Drawing.Point(451, 513);
            this.JumpButton.Name = "JumpButton";
            this.JumpButton.Size = new System.Drawing.Size(121, 104);
            this.JumpButton.TabIndex = 1;
            this.JumpButton.Text = "Jump";
            this.JumpButton.UseVisualStyleBackColor = true;
            this.JumpButton.Click += new System.EventHandler(this.jumpButton_Click);
            // 
            // FrameTimer
            // 
            this.FrameTimer.Enabled = true;
            this.FrameTimer.Interval = 20;
            this.FrameTimer.Tick += new System.EventHandler(this.FrameTimer_Tick);
            // 
            // UpperPipe2
            // 
            this.UpperPipe2.Image = ((System.Drawing.Image)(resources.GetObject("UpperPipe2.Image")));
            this.UpperPipe2.Location = new System.Drawing.Point(576, -211);
            this.UpperPipe2.Name = "UpperPipe2";
            this.UpperPipe2.Size = new System.Drawing.Size(160, 480);
            this.UpperPipe2.TabIndex = 2;
            this.UpperPipe2.TabStop = false;
            // 
            // LowerPipe1
            // 
            this.LowerPipe1.Image = ((System.Drawing.Image)(resources.GetObject("LowerPipe1.Image")));
            this.LowerPipe1.Location = new System.Drawing.Point(576, 333);
            this.LowerPipe1.Name = "LowerPipe1";
            this.LowerPipe1.Size = new System.Drawing.Size(160, 480);
            this.LowerPipe1.TabIndex = 3;
            this.LowerPipe1.TabStop = false;
            // 
            // UpperPipe1
            // 
            this.UpperPipe1.Image = ((System.Drawing.Image)(resources.GetObject("UpperPipe1.Image")));
            this.UpperPipe1.Location = new System.Drawing.Point(566, -188);
            this.UpperPipe1.Name = "UpperPipe1";
            this.UpperPipe1.Size = new System.Drawing.Size(160, 480);
            this.UpperPipe1.TabIndex = 4;
            this.UpperPipe1.TabStop = false;
            // 
            // LowerPipe2
            // 
            this.LowerPipe2.Image = ((System.Drawing.Image)(resources.GetObject("LowerPipe2.Image")));
            this.LowerPipe2.Location = new System.Drawing.Point(566, 333);
            this.LowerPipe2.Name = "LowerPipe2";
            this.LowerPipe2.Size = new System.Drawing.Size(160, 480);
            this.LowerPipe2.TabIndex = 5;
            this.LowerPipe2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 64.25F);
            this.label1.Location = new System.Drawing.Point(-2, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 97);
            this.label1.TabIndex = 6;
            this.label1.Text = "score";
            // 
            // UpperPipe3
            // 
            this.UpperPipe3.Image = ((System.Drawing.Image)(resources.GetObject("UpperPipe3.Image")));
            this.UpperPipe3.Location = new System.Drawing.Point(566, -188);
            this.UpperPipe3.Name = "UpperPipe3";
            this.UpperPipe3.Size = new System.Drawing.Size(160, 480);
            this.UpperPipe3.TabIndex = 7;
            this.UpperPipe3.TabStop = false;
            // 
            // LowerPipe3
            // 
            this.LowerPipe3.Image = ((System.Drawing.Image)(resources.GetObject("LowerPipe3.Image")));
            this.LowerPipe3.Location = new System.Drawing.Point(576, 333);
            this.LowerPipe3.Name = "LowerPipe3";
            this.LowerPipe3.Size = new System.Drawing.Size(160, 480);
            this.LowerPipe3.TabIndex = 8;
            this.LowerPipe3.TabStop = false;
            // 
            // EndText
            // 
            this.EndText.AutoSize = true;
            this.EndText.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F);
            this.EndText.Location = new System.Drawing.Point(238, 240);
            this.EndText.Name = "EndText";
            this.EndText.Size = new System.Drawing.Size(609, 76);
            this.EndText.TabIndex = 11;
            this.EndText.Text = "Click This To Reset";
            this.EndText.Click += new System.EventHandler(this.label2_Click);
            // 
            // Debug0
            // 
            this.Debug0.AutoSize = true;
            this.Debug0.Location = new System.Drawing.Point(939, 66);
            this.Debug0.Name = "Debug0";
            this.Debug0.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Debug0.Size = new System.Drawing.Size(45, 13);
            this.Debug0.TabIndex = 12;
            this.Debug0.Text = "Debug0";
            this.Debug0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Debug1
            // 
            this.Debug1.AutoSize = true;
            this.Debug1.Location = new System.Drawing.Point(939, 82);
            this.Debug1.Name = "Debug1";
            this.Debug1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Debug1.Size = new System.Drawing.Size(45, 13);
            this.Debug1.TabIndex = 13;
            this.Debug1.Text = "Debug1";
            this.Debug1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Debug2
            // 
            this.Debug2.AutoSize = true;
            this.Debug2.Location = new System.Drawing.Point(939, 95);
            this.Debug2.Name = "Debug2";
            this.Debug2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Debug2.Size = new System.Drawing.Size(45, 13);
            this.Debug2.TabIndex = 14;
            this.Debug2.Text = "Debug2";
            this.Debug2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1048, 629);
            this.Controls.Add(this.birb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Debug0);
            this.Controls.Add(this.Debug1);
            this.Controls.Add(this.Debug2);
            this.Controls.Add(this.EndText);
            this.Controls.Add(this.JumpButton);
            this.Controls.Add(this.LowerPipe3);
            this.Controls.Add(this.UpperPipe3);
            this.Controls.Add(this.LowerPipe2);
            this.Controls.Add(this.UpperPipe1);
            this.Controls.Add(this.LowerPipe1);
            this.Controls.Add(this.UpperPipe2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.birb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpperPipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerPipe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpperPipe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerPipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpperPipe3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerPipe3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox birb;
		private System.Windows.Forms.Button JumpButton;
		private System.Windows.Forms.Timer FrameTimer;
		private System.Windows.Forms.PictureBox UpperPipe2;
		private System.Windows.Forms.PictureBox LowerPipe1;
		private System.Windows.Forms.PictureBox UpperPipe1;
		private System.Windows.Forms.PictureBox LowerPipe2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox UpperPipe3;
		private System.Windows.Forms.PictureBox LowerPipe3;
		private System.Windows.Forms.Label EndText;
		private System.Windows.Forms.Label Debug0;
		private System.Windows.Forms.Label Debug1;
		private System.Windows.Forms.Label Debug2;
	}
}

