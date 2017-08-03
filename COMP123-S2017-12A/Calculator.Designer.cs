namespace COMP123_S2017_12A
{
    partial class Calculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.BackSpace = new System.Windows.Forms.Button();
            this.Devide = new System.Windows.Forms.Button();
            this.sevenB = new System.Windows.Forms.Button();
            this.eightB = new System.Windows.Forms.Button();
            this.nineB = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Button();
            this.fourB = new System.Windows.Forms.Button();
            this.fiveB = new System.Windows.Forms.Button();
            this.sixB = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.oneB = new System.Windows.Forms.Button();
            this.twoB = new System.Windows.Forms.Button();
            this.threeB = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.PlusMinus = new System.Windows.Forms.Button();
            this.zeroB = new System.Windows.Forms.Button();
            this.Decimal = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.Equal, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.Decimal, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.zeroB, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.PlusMinus, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Plus, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.threeB, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.twoB, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.oneB, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Minus, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.sixB, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.fiveB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.fourB, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Time, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.nineB, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.eightB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Devide, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.BackSpace, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Clear, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.sevenB, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 130);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 300);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(2, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 38);
            this.textBox1.TabIndex = 1;
            // 
            // Clear
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Clear, 2);
            this.Clear.Location = new System.Drawing.Point(3, 3);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(144, 54);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // BackSpace
            // 
            this.BackSpace.Location = new System.Drawing.Point(153, 3);
            this.BackSpace.Name = "BackSpace";
            this.BackSpace.Size = new System.Drawing.Size(69, 54);
            this.BackSpace.TabIndex = 2;
            this.BackSpace.Text = "⌫";
            this.BackSpace.UseVisualStyleBackColor = true;
            // 
            // Devide
            // 
            this.Devide.Location = new System.Drawing.Point(228, 3);
            this.Devide.Name = "Devide";
            this.Devide.Size = new System.Drawing.Size(69, 54);
            this.Devide.TabIndex = 3;
            this.Devide.Text = "÷";
            this.Devide.UseVisualStyleBackColor = true;
            // 
            // sevenB
            // 
            this.sevenB.BackColor = System.Drawing.Color.White;
            this.sevenB.Location = new System.Drawing.Point(3, 63);
            this.sevenB.Name = "sevenB";
            this.sevenB.Size = new System.Drawing.Size(69, 54);
            this.sevenB.TabIndex = 4;
            this.sevenB.Text = "7";
            this.sevenB.UseVisualStyleBackColor = false;
            // 
            // eightB
            // 
            this.eightB.BackColor = System.Drawing.Color.White;
            this.eightB.Location = new System.Drawing.Point(78, 63);
            this.eightB.Name = "eightB";
            this.eightB.Size = new System.Drawing.Size(69, 54);
            this.eightB.TabIndex = 5;
            this.eightB.Text = "8";
            this.eightB.UseVisualStyleBackColor = false;
            // 
            // nineB
            // 
            this.nineB.BackColor = System.Drawing.Color.White;
            this.nineB.Location = new System.Drawing.Point(153, 63);
            this.nineB.Name = "nineB";
            this.nineB.Size = new System.Drawing.Size(69, 54);
            this.nineB.TabIndex = 6;
            this.nineB.Text = "9";
            this.nineB.UseVisualStyleBackColor = false;
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(228, 63);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(69, 54);
            this.Time.TabIndex = 7;
            this.Time.Text = "x";
            this.Time.UseVisualStyleBackColor = true;
            // 
            // fourB
            // 
            this.fourB.BackColor = System.Drawing.Color.White;
            this.fourB.Location = new System.Drawing.Point(3, 123);
            this.fourB.Name = "fourB";
            this.fourB.Size = new System.Drawing.Size(69, 54);
            this.fourB.TabIndex = 8;
            this.fourB.Text = "4";
            this.fourB.UseVisualStyleBackColor = false;
            // 
            // fiveB
            // 
            this.fiveB.BackColor = System.Drawing.Color.White;
            this.fiveB.Location = new System.Drawing.Point(78, 123);
            this.fiveB.Name = "fiveB";
            this.fiveB.Size = new System.Drawing.Size(69, 54);
            this.fiveB.TabIndex = 9;
            this.fiveB.Text = "5";
            this.fiveB.UseVisualStyleBackColor = false;
            // 
            // sixB
            // 
            this.sixB.BackColor = System.Drawing.Color.White;
            this.sixB.Location = new System.Drawing.Point(153, 123);
            this.sixB.Name = "sixB";
            this.sixB.Size = new System.Drawing.Size(69, 54);
            this.sixB.TabIndex = 10;
            this.sixB.Text = "6";
            this.sixB.UseVisualStyleBackColor = false;
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(228, 123);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(69, 54);
            this.Minus.TabIndex = 11;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            // 
            // oneB
            // 
            this.oneB.BackColor = System.Drawing.Color.White;
            this.oneB.Location = new System.Drawing.Point(3, 183);
            this.oneB.Name = "oneB";
            this.oneB.Size = new System.Drawing.Size(69, 54);
            this.oneB.TabIndex = 12;
            this.oneB.Text = "1";
            this.oneB.UseVisualStyleBackColor = false;
            // 
            // twoB
            // 
            this.twoB.BackColor = System.Drawing.Color.White;
            this.twoB.Location = new System.Drawing.Point(78, 183);
            this.twoB.Name = "twoB";
            this.twoB.Size = new System.Drawing.Size(69, 54);
            this.twoB.TabIndex = 13;
            this.twoB.Text = "2";
            this.twoB.UseVisualStyleBackColor = false;
            // 
            // threeB
            // 
            this.threeB.BackColor = System.Drawing.Color.White;
            this.threeB.Location = new System.Drawing.Point(153, 183);
            this.threeB.Name = "threeB";
            this.threeB.Size = new System.Drawing.Size(69, 54);
            this.threeB.TabIndex = 14;
            this.threeB.Text = "3";
            this.threeB.UseVisualStyleBackColor = false;
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(228, 183);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(69, 54);
            this.Plus.TabIndex = 15;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            // 
            // PlusMinus
            // 
            this.PlusMinus.Location = new System.Drawing.Point(3, 243);
            this.PlusMinus.Name = "PlusMinus";
            this.PlusMinus.Size = new System.Drawing.Size(69, 54);
            this.PlusMinus.TabIndex = 16;
            this.PlusMinus.Text = "±";
            this.PlusMinus.UseVisualStyleBackColor = true;
            // 
            // zeroB
            // 
            this.zeroB.BackColor = System.Drawing.Color.White;
            this.zeroB.Location = new System.Drawing.Point(78, 243);
            this.zeroB.Name = "zeroB";
            this.zeroB.Size = new System.Drawing.Size(69, 54);
            this.zeroB.TabIndex = 17;
            this.zeroB.Text = "0";
            this.zeroB.UseVisualStyleBackColor = false;
            // 
            // Decimal
            // 
            this.Decimal.BackColor = System.Drawing.Color.White;
            this.Decimal.Location = new System.Drawing.Point(153, 243);
            this.Decimal.Name = "Decimal";
            this.Decimal.Size = new System.Drawing.Size(69, 54);
            this.Decimal.TabIndex = 18;
            this.Decimal.Text = ".";
            this.Decimal.UseVisualStyleBackColor = false;
            // 
            // Equal
            // 
            this.Equal.Location = new System.Drawing.Point(228, 243);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(69, 54);
            this.Equal.TabIndex = 19;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(304, 433);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Location = new System.Drawing.Point(0, 195);
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button Decimal;
        private System.Windows.Forms.Button zeroB;
        private System.Windows.Forms.Button PlusMinus;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button threeB;
        private System.Windows.Forms.Button twoB;
        private System.Windows.Forms.Button oneB;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button sixB;
        private System.Windows.Forms.Button fiveB;
        private System.Windows.Forms.Button fourB;
        private System.Windows.Forms.Button Time;
        private System.Windows.Forms.Button nineB;
        private System.Windows.Forms.Button eightB;
        private System.Windows.Forms.Button sevenB;
        private System.Windows.Forms.Button Devide;
        private System.Windows.Forms.Button BackSpace;
        private System.Windows.Forms.Button Clear;
    }
}

