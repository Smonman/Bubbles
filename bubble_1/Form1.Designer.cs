namespace bubble_1 {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.numericUpDown_thickness = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_startRadius = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.numericUpDown_maxAttemptsPerTick = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_maxCircelsPerTick = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_Intervall = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button_start = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label_totalCircles = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.button_remove = new System.Windows.Forms.Button();
			this.button_open = new System.Windows.Forms.Button();
			this.textBox_imagePath = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.numericUpDown_maxSize = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_thickness)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_startRadius)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxAttemptsPerTick)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxCircelsPerTick)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Intervall)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxSize)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Black;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(809, 324);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Resize += new System.EventHandler(this.pictureBox1_Resize);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(815, 470);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.button_start, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this.groupBox3, 2, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 333);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(809, 94);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numericUpDown_maxSize);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.numericUpDown_thickness);
			this.groupBox1.Controls.Add(this.numericUpDown_startRadius);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(155, 88);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Circle";
			// 
			// numericUpDown_thickness
			// 
			this.numericUpDown_thickness.Location = new System.Drawing.Point(80, 40);
			this.numericUpDown_thickness.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.numericUpDown_thickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown_thickness.Name = "numericUpDown_thickness";
			this.numericUpDown_thickness.Size = new System.Drawing.Size(50, 20);
			this.numericUpDown_thickness.TabIndex = 3;
			this.numericUpDown_thickness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numericUpDown_startRadius
			// 
			this.numericUpDown_startRadius.Location = new System.Drawing.Point(80, 14);
			this.numericUpDown_startRadius.Name = "numericUpDown_startRadius";
			this.numericUpDown_startRadius.Size = new System.Drawing.Size(50, 20);
			this.numericUpDown_startRadius.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Thickness";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Start Radius";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.numericUpDown_maxAttemptsPerTick);
			this.groupBox2.Controls.Add(this.numericUpDown_maxCircelsPerTick);
			this.groupBox2.Controls.Add(this.numericUpDown_Intervall);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(164, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(398, 88);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tick";
			// 
			// numericUpDown_maxAttemptsPerTick
			// 
			this.numericUpDown_maxAttemptsPerTick.Location = new System.Drawing.Point(301, 14);
			this.numericUpDown_maxAttemptsPerTick.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDown_maxAttemptsPerTick.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown_maxAttemptsPerTick.Name = "numericUpDown_maxAttemptsPerTick";
			this.numericUpDown_maxAttemptsPerTick.Size = new System.Drawing.Size(50, 20);
			this.numericUpDown_maxAttemptsPerTick.TabIndex = 5;
			this.numericUpDown_maxAttemptsPerTick.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			// 
			// numericUpDown_maxCircelsPerTick
			// 
			this.numericUpDown_maxCircelsPerTick.Location = new System.Drawing.Point(106, 40);
			this.numericUpDown_maxCircelsPerTick.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown_maxCircelsPerTick.Name = "numericUpDown_maxCircelsPerTick";
			this.numericUpDown_maxCircelsPerTick.Size = new System.Drawing.Size(50, 20);
			this.numericUpDown_maxCircelsPerTick.TabIndex = 4;
			this.numericUpDown_maxCircelsPerTick.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// numericUpDown_Intervall
			// 
			this.numericUpDown_Intervall.Location = new System.Drawing.Point(106, 14);
			this.numericUpDown_Intervall.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDown_Intervall.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown_Intervall.Name = "numericUpDown_Intervall";
			this.numericUpDown_Intervall.Size = new System.Drawing.Size(50, 20);
			this.numericUpDown_Intervall.TabIndex = 3;
			this.numericUpDown_Intervall.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(200, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(95, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Max attemps / tick";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 42);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Max circels / tick";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Intervall";
			// 
			// button_start
			// 
			this.button_start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button_start.Location = new System.Drawing.Point(729, 3);
			this.button_start.Name = "button_start";
			this.button_start.Size = new System.Drawing.Size(77, 88);
			this.button_start.TabIndex = 6;
			this.button_start.Text = "Start";
			this.button_start.UseVisualStyleBackColor = true;
			this.button_start.Click += new System.EventHandler(this.button_start_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label_totalCircles);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(568, 3);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(155, 88);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Status";
			// 
			// label_totalCircles
			// 
			this.label_totalCircles.AutoSize = true;
			this.label_totalCircles.Location = new System.Drawing.Point(74, 16);
			this.label_totalCircles.Name = "label_totalCircles";
			this.label_totalCircles.Size = new System.Drawing.Size(87, 13);
			this.label_totalCircles.TabIndex = 1;
			this.label_totalCircles.Text = "TOTALCIRCLES";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Total Circles";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.button_remove);
			this.groupBox4.Controls.Add(this.button_open);
			this.groupBox4.Controls.Add(this.textBox_imagePath);
			this.groupBox4.Controls.Add(this.label7);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox4.Location = new System.Drawing.Point(3, 433);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(809, 34);
			this.groupBox4.TabIndex = 2;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Image";
			// 
			// button_remove
			// 
			this.button_remove.Location = new System.Drawing.Point(645, 10);
			this.button_remove.Name = "button_remove";
			this.button_remove.Size = new System.Drawing.Size(75, 23);
			this.button_remove.TabIndex = 3;
			this.button_remove.Text = "Remove";
			this.button_remove.UseVisualStyleBackColor = true;
			this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
			// 
			// button_open
			// 
			this.button_open.Location = new System.Drawing.Point(564, 10);
			this.button_open.Name = "button_open";
			this.button_open.Size = new System.Drawing.Size(75, 23);
			this.button_open.TabIndex = 2;
			this.button_open.Text = "Open";
			this.button_open.UseVisualStyleBackColor = true;
			this.button_open.Click += new System.EventHandler(this.button_open_Click);
			// 
			// textBox_imagePath
			// 
			this.textBox_imagePath.Location = new System.Drawing.Point(73, 12);
			this.textBox_imagePath.Name = "textBox_imagePath";
			this.textBox_imagePath.Size = new System.Drawing.Size(489, 20);
			this.textBox_imagePath.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 15);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(61, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Image Path";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 68);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(50, 13);
			this.label8.TabIndex = 4;
			this.label8.Text = "Max Size";
			// 
			// numericUpDown_maxSize
			// 
			this.numericUpDown_maxSize.Location = new System.Drawing.Point(80, 66);
			this.numericUpDown_maxSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown_maxSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericUpDown_maxSize.Name = "numericUpDown_maxSize";
			this.numericUpDown_maxSize.Size = new System.Drawing.Size(50, 20);
			this.numericUpDown_maxSize.TabIndex = 5;
			this.numericUpDown_maxSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(815, 470);
			this.Controls.Add(this.tableLayoutPanel1);
			this.DoubleBuffered = true;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.Text = "Bubblefill";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_thickness)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_startRadius)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxAttemptsPerTick)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxCircelsPerTick)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Intervall)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxSize)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown numericUpDown_thickness;
		private System.Windows.Forms.NumericUpDown numericUpDown_startRadius;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown numericUpDown_Intervall;
		private System.Windows.Forms.NumericUpDown numericUpDown_maxCircelsPerTick;
		private System.Windows.Forms.NumericUpDown numericUpDown_maxAttemptsPerTick;
		private System.Windows.Forms.Button button_start;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label_totalCircles;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox_imagePath;
		private System.Windows.Forms.Button button_open;
		private System.Windows.Forms.Button button_remove;
		private System.Windows.Forms.NumericUpDown numericUpDown_maxSize;
		private System.Windows.Forms.Label label8;
	}
}

