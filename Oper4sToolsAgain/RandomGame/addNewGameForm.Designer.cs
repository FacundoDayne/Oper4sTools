namespace Oper4sToolsAgain.RandomGame
{
	partial class addNewGameForm
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
			label1 = new Label();
			tbName = new TextBox();
			label2 = new Label();
			lblFilePath = new Label();
			btnFilePath = new Button();
			btnCancel = new Button();
			btnAccept = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(12, 14);
			label1.Name = "label1";
			label1.Size = new Size(115, 21);
			label1.TabIndex = 0;
			label1.Text = "Name of Game";
			// 
			// tbName
			// 
			tbName.Location = new Point(133, 12);
			tbName.Name = "tbName";
			tbName.Size = new Size(219, 23);
			tbName.TabIndex = 1;
			tbName.TextChanged += tbName_TextChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(59, 48);
			label2.Name = "label2";
			label2.Size = new Size(68, 21);
			label2.TabIndex = 2;
			label2.Text = "File Path";
			// 
			// lblFilePath
			// 
			lblFilePath.AutoSize = true;
			lblFilePath.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblFilePath.Location = new Point(133, 48);
			lblFilePath.MaximumSize = new Size(224, 21);
			lblFilePath.MinimumSize = new Size(224, 21);
			lblFilePath.Name = "lblFilePath";
			lblFilePath.Size = new Size(224, 21);
			lblFilePath.TabIndex = 3;
			lblFilePath.Text = "<null>";
			// 
			// btnFilePath
			// 
			btnFilePath.BackColor = Color.DimGray;
			btnFilePath.ForeColor = Color.White;
			btnFilePath.Location = new Point(133, 85);
			btnFilePath.Name = "btnFilePath";
			btnFilePath.Size = new Size(115, 32);
			btnFilePath.TabIndex = 4;
			btnFilePath.Text = "Get File Path";
			btnFilePath.UseVisualStyleBackColor = false;
			btnFilePath.Click += btnFilePath_Click;
			// 
			// btnCancel
			// 
			btnCancel.BackColor = Color.DimGray;
			btnCancel.ForeColor = Color.White;
			btnCancel.Location = new Point(12, 123);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(168, 39);
			btnCancel.TabIndex = 5;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = false;
			btnCancel.Click += btnCancel_Click;
			// 
			// btnAccept
			// 
			btnAccept.BackColor = Color.DimGray;
			btnAccept.ForeColor = Color.White;
			btnAccept.Location = new Point(186, 123);
			btnAccept.Name = "btnAccept";
			btnAccept.Size = new Size(171, 39);
			btnAccept.TabIndex = 6;
			btnAccept.Text = "Accept";
			btnAccept.UseVisualStyleBackColor = false;
			btnAccept.Click += btnAccept_Click;
			// 
			// addNewGameForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Black;
			ClientSize = new Size(380, 168);
			Controls.Add(btnAccept);
			Controls.Add(btnCancel);
			Controls.Add(btnFilePath);
			Controls.Add(lblFilePath);
			Controls.Add(label2);
			Controls.Add(tbName);
			Controls.Add(label1);
			ForeColor = Color.White;
			FormBorderStyle = FormBorderStyle.None;
			MaximumSize = new Size(380, 168);
			MinimumSize = new Size(380, 168);
			Name = "addNewGameForm";
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "addNewGameForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox tbName;
		private Label label2;
		private Label lblFilePath;
		private Button btnFilePath;
		private Button btnCancel;
		private Button btnAccept;
	}
}