namespace RipeLookup
{
	partial class MainForm
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
			this.button1 = new System.Windows.Forms.Button();
			this.QueryBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.XMLBox = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.JSONBox = new System.Windows.Forms.TextBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.DNSResultBox = new System.Windows.Forms.TextBox();
			this.DNSBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(656, 13);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 22);
			this.button1.TabIndex = 1;
			this.button1.Text = "Request Query";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.DNSLookupRequest_Click);
			// 
			// QueryBox
			// 
			this.QueryBox.Location = new System.Drawing.Point(50, 11);
			this.QueryBox.Name = "QueryBox";
			this.QueryBox.Size = new System.Drawing.Size(110, 20);
			this.QueryBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Query";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(166, 9);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(68, 22);
			this.button2.TabIndex = 7;
			this.button2.Text = "Request";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.QueryLookup_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(12, 41);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(748, 423);
			this.tabControl1.TabIndex = 8;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.XMLBox);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(740, 397);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "XML";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// XMLBox
			// 
			this.XMLBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.XMLBox.Location = new System.Drawing.Point(0, 0);
			this.XMLBox.Multiline = true;
			this.XMLBox.Name = "XMLBox";
			this.XMLBox.ReadOnly = true;
			this.XMLBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.XMLBox.Size = new System.Drawing.Size(740, 397);
			this.XMLBox.TabIndex = 10;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.JSONBox);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(816, 313);
			this.tabPage2.TabIndex = 0;
			this.tabPage2.Text = "JSON";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// JSONBox
			// 
			this.JSONBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.JSONBox.Location = new System.Drawing.Point(0, 0);
			this.JSONBox.Multiline = true;
			this.JSONBox.Name = "JSONBox";
			this.JSONBox.ReadOnly = true;
			this.JSONBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.JSONBox.Size = new System.Drawing.Size(871, 453);
			this.JSONBox.TabIndex = 9;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.DNSResultBox);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(816, 313);
			this.tabPage3.TabIndex = 1;
			this.tabPage3.Text = "DNS";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// DNSResultBox
			// 
			this.DNSResultBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DNSResultBox.Location = new System.Drawing.Point(3, 3);
			this.DNSResultBox.Multiline = true;
			this.DNSResultBox.Name = "DNSResultBox";
			this.DNSResultBox.ReadOnly = true;
			this.DNSResultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.DNSResultBox.Size = new System.Drawing.Size(865, 447);
			this.DNSResultBox.TabIndex = 2;
			// 
			// DNSBox
			// 
			this.DNSBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DNSBox.Location = new System.Drawing.Point(484, 13);
			this.DNSBox.Name = "DNSBox";
			this.DNSBox.Size = new System.Drawing.Size(96, 20);
			this.DNSBox.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(448, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "DNS";
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.Location = new System.Drawing.Point(586, 13);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(64, 22);
			this.button3.TabIndex = 10;
			this.button3.Text = "Lookup";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.DNSLookup_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(772, 476);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.DNSBox);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.QueryBox);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox QueryBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TextBox XMLBox;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TextBox DNSBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox JSONBox;
		private System.Windows.Forms.TextBox DNSResultBox;
		private System.Windows.Forms.Button button3;
	}
}