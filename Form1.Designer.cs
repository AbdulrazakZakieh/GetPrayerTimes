namespace GettıngPrayersTime
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
			this.getDataButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.fajrLabel = new System.Windows.Forms.Label();
			this.zuhrLabel = new System.Windows.Forms.Label();
			this.asrLabel = new System.Windows.Forms.Label();
			this.maghrebLabel = new System.Windows.Forms.Label();
			this.ishaLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// getDataButton
			// 
			this.getDataButton.Location = new System.Drawing.Point(322, 346);
			this.getDataButton.Name = "getDataButton";
			this.getDataButton.Size = new System.Drawing.Size(146, 73);
			this.getDataButton.TabIndex = 0;
			this.getDataButton.Text = "Get Data";
			this.getDataButton.UseVisualStyleBackColor = true;
			this.getDataButton.Click += new System.EventHandler(this.getDataButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(674, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "الفجر";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(674, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "الظهر";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(674, 155);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "العصر";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(664, 211);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 17);
			this.label4.TabIndex = 2;
			this.label4.Text = "المغرب";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(664, 269);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 17);
			this.label5.TabIndex = 2;
			this.label5.Text = "العشاء";
			// 
			// fajrLabel
			// 
			this.fajrLabel.AutoSize = true;
			this.fajrLabel.Location = new System.Drawing.Point(571, 44);
			this.fajrLabel.Name = "fajrLabel";
			this.fajrLabel.Size = new System.Drawing.Size(0, 17);
			this.fajrLabel.TabIndex = 1;
			// 
			// zuhrLabel
			// 
			this.zuhrLabel.AutoSize = true;
			this.zuhrLabel.Location = new System.Drawing.Point(571, 97);
			this.zuhrLabel.Name = "zuhrLabel";
			this.zuhrLabel.Size = new System.Drawing.Size(0, 17);
			this.zuhrLabel.TabIndex = 2;
			// 
			// asrLabel
			// 
			this.asrLabel.AutoSize = true;
			this.asrLabel.Location = new System.Drawing.Point(571, 155);
			this.asrLabel.Name = "asrLabel";
			this.asrLabel.Size = new System.Drawing.Size(0, 17);
			this.asrLabel.TabIndex = 2;
			// 
			// maghrebLabel
			// 
			this.maghrebLabel.AutoSize = true;
			this.maghrebLabel.Location = new System.Drawing.Point(561, 211);
			this.maghrebLabel.Name = "maghrebLabel";
			this.maghrebLabel.Size = new System.Drawing.Size(0, 17);
			this.maghrebLabel.TabIndex = 2;
			// 
			// ishaLabel
			// 
			this.ishaLabel.AutoSize = true;
			this.ishaLabel.Location = new System.Drawing.Point(561, 269);
			this.ishaLabel.Name = "ishaLabel";
			this.ishaLabel.Size = new System.Drawing.Size(0, 17);
			this.ishaLabel.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ishaLabel);
			this.Controls.Add(this.maghrebLabel);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.asrLabel);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.zuhrLabel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.fajrLabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.getDataButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button getDataButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label fajrLabel;
		private System.Windows.Forms.Label zuhrLabel;
		private System.Windows.Forms.Label asrLabel;
		private System.Windows.Forms.Label maghrebLabel;
		private System.Windows.Forms.Label ishaLabel;
	}
}

