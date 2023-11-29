namespace Oper4sToolsAgain.RandomGame
{
	partial class RandomGameUserControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomGameUserControl));
			gameLayoutPanel = new TableLayoutPanel();
			pictureBox1 = new PictureBox();
			logoPictureBox = new PictureBox();
			gameLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
			SuspendLayout();
			// 
			// gameLayoutPanel
			// 
			gameLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			gameLayoutPanel.AutoSize = true;
			gameLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			gameLayoutPanel.ColumnCount = 3;
			gameLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
			gameLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
			gameLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
			gameLayoutPanel.Controls.Add(pictureBox1, 0, 0);
			gameLayoutPanel.Location = new Point(257, 23);
			gameLayoutPanel.Margin = new Padding(3, 3, 3, 150);
			gameLayoutPanel.Name = "gameLayoutPanel";
			gameLayoutPanel.RowCount = 1;
			gameLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
			gameLayoutPanel.Size = new Size(509, 150);
			gameLayoutPanel.TabIndex = 0;
			// 
			// pictureBox1
			// 
			pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pictureBox1.BackColor = Color.FromArgb(0, 43, 54);
			pictureBox1.Image = Properties.Resources.haxxor_icon;
			pictureBox1.Location = new Point(10, 10);
			pictureBox1.Margin = new Padding(10);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(149, 130);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			// 
			// logoPictureBox
			// 
			logoPictureBox.Image = Properties.Resources.haxxor_icon;
			logoPictureBox.Location = new Point(27, 23);
			logoPictureBox.Name = "logoPictureBox";
			logoPictureBox.Size = new Size(140, 137);
			logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
			logoPictureBox.TabIndex = 1;
			logoPictureBox.TabStop = false;
			// 
			// RandomGameUserControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Black;
			Controls.Add(logoPictureBox);
			Controls.Add(gameLayoutPanel);
			Name = "RandomGameUserControl";
			Size = new Size(800, 450);
			gameLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TableLayoutPanel gameLayoutPanel;
		private PictureBox logoPictureBox;
		private PictureBox pictureBox1;
	}
}
