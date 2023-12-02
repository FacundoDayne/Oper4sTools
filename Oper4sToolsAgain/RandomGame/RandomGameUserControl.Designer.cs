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
			gameLayoutPanel = new TableLayoutPanel();
			panel1 = new Panel();
			btnPlay = new Button();
			btnRemove = new Button();
			btnRandom = new Button();
			gameNameLabel = new Label();
			label2 = new Label();
			label1 = new Label();
			panel1.SuspendLayout();
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
			gameLayoutPanel.Location = new Point(257, 23);
			gameLayoutPanel.Margin = new Padding(3, 3, 3, 150);
			gameLayoutPanel.Name = "gameLayoutPanel";
			gameLayoutPanel.RowCount = 1;
			gameLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
			gameLayoutPanel.Size = new Size(437, 150);
			gameLayoutPanel.TabIndex = 0;
			// 
			// panel1
			// 
			panel1.AutoScroll = true;
			panel1.Controls.Add(btnPlay);
			panel1.Controls.Add(btnRemove);
			panel1.Controls.Add(btnRandom);
			panel1.Controls.Add(gameNameLabel);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.MaximumSize = new Size(240, 450);
			panel1.MinimumSize = new Size(240, 450);
			panel1.Name = "panel1";
			panel1.Size = new Size(240, 450);
			panel1.TabIndex = 1;
			// 
			// btnPlay
			// 
			btnPlay.BackColor = Color.DimGray;
			btnPlay.ForeColor = Color.White;
			btnPlay.Location = new Point(19, 237);
			btnPlay.Name = "btnPlay";
			btnPlay.Size = new Size(94, 49);
			btnPlay.TabIndex = 6;
			btnPlay.Text = "Play Game";
			btnPlay.UseVisualStyleBackColor = false;
			btnPlay.Click += playSelected;
			// 
			// btnRemove
			// 
			btnRemove.BackColor = Color.DimGray;
			btnRemove.ForeColor = Color.White;
			btnRemove.Location = new Point(129, 237);
			btnRemove.Name = "btnRemove";
			btnRemove.Size = new Size(94, 49);
			btnRemove.TabIndex = 5;
			btnRemove.Text = "Remove Game";
			btnRemove.UseVisualStyleBackColor = false;
			btnRemove.Click += btnRemove_Click;
			// 
			// btnRandom
			// 
			btnRandom.BackColor = Color.DimGray;
			btnRandom.ForeColor = Color.White;
			btnRandom.Location = new Point(72, 323);
			btnRandom.Name = "btnRandom";
			btnRandom.Size = new Size(94, 49);
			btnRandom.TabIndex = 4;
			btnRandom.Text = "Play Random Game";
			btnRandom.UseVisualStyleBackColor = false;
			// 
			// gameNameLabel
			// 
			gameNameLabel.AutoSize = true;
			gameNameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			gameNameLabel.ForeColor = Color.White;
			gameNameLabel.Location = new Point(39, 131);
			gameNameLabel.MaximumSize = new Size(162, 0);
			gameNameLabel.Name = "gameNameLabel";
			gameNameLabel.Size = new Size(0, 17);
			gameNameLabel.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.White;
			label2.Location = new Point(13, 83);
			label2.Name = "label2";
			label2.Size = new Size(78, 32);
			label2.TabIndex = 1;
			label2.Text = "Name";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.White;
			label1.Location = new Point(52, 23);
			label1.Name = "label1";
			label1.Size = new Size(146, 32);
			label1.TabIndex = 0;
			label1.Text = "Game Menu";
			// 
			// RandomGameUserControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			BackColor = Color.Black;
			Controls.Add(panel1);
			Controls.Add(gameLayoutPanel);
			Name = "RandomGameUserControl";
			Size = new Size(800, 450);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TableLayoutPanel gameLayoutPanel;
		private Panel panel1;
		private Label label1;
		private Label gameNameLabel;
		private Label label2;
		private Button btnRemove;
		private Button btnRandom;
		private Button btnPlay;
	}
}
