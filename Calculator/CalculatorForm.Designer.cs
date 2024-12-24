namespace calculator
{
    partial class CalculatorForm
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
            this.label_display = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_MS = new System.Windows.Forms.Button();
            this.button_MMinus = new System.Windows.Forms.Button();
            this.button_MPlus = new System.Windows.Forms.Button();
            this.button_MR = new System.Windows.Forms.Button();
            this.button_MC = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_equal = new System.Windows.Forms.Button();
            this.button_dot = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_convOper = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_multiply = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.button_root = new System.Windows.Forms.Button();
            this.button_square = new System.Windows.Forms.Button();
            this.button_multiInverse = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button_C = new System.Windows.Forms.Button();
            this.button_CE = new System.Windows.Forms.Button();
            this.button_percent = new System.Windows.Forms.Button();
            this.label_subDisplay = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_display
            // 
            this.label_display.Font = new System.Drawing.Font("Malgun Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_display.Location = new System.Drawing.Point(0, 45);
            this.label_display.Name = "label_display";
            this.label_display.Size = new System.Drawing.Size(382, 65);
            this.label_display.TabIndex = 1;
            this.label_display.Text = "0";
            this.label_display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.00001F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.button_MS, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_MMinus, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_MPlus, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_MR, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_MC, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 120);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(382, 60);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // button_MS
            // 
            this.button_MS.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_MS.Location = new System.Drawing.Point(307, 3);
            this.button_MS.Name = "button_MS";
            this.button_MS.Size = new System.Drawing.Size(72, 54);
            this.button_MS.TabIndex = 5;
            this.button_MS.Text = "MS";
            this.button_MS.UseVisualStyleBackColor = true;
            this.button_MS.Click += new System.EventHandler(this.button_MS_Click);
            // 
            // button_MMinus
            // 
            this.button_MMinus.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_MMinus.Location = new System.Drawing.Point(231, 3);
            this.button_MMinus.Name = "button_MMinus";
            this.button_MMinus.Size = new System.Drawing.Size(70, 54);
            this.button_MMinus.TabIndex = 4;
            this.button_MMinus.Text = "M-";
            this.button_MMinus.UseVisualStyleBackColor = true;
            this.button_MMinus.Click += new System.EventHandler(this.button_MMinus_Click);
            // 
            // button_MPlus
            // 
            this.button_MPlus.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_MPlus.Location = new System.Drawing.Point(155, 3);
            this.button_MPlus.Name = "button_MPlus";
            this.button_MPlus.Size = new System.Drawing.Size(70, 54);
            this.button_MPlus.TabIndex = 3;
            this.button_MPlus.Text = "M+";
            this.button_MPlus.UseVisualStyleBackColor = true;
            this.button_MPlus.Click += new System.EventHandler(this.button_MPlus_Click);
            // 
            // button_MR
            // 
            this.button_MR.Enabled = false;
            this.button_MR.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_MR.Location = new System.Drawing.Point(79, 3);
            this.button_MR.Name = "button_MR";
            this.button_MR.Size = new System.Drawing.Size(70, 54);
            this.button_MR.TabIndex = 2;
            this.button_MR.Text = "MR";
            this.button_MR.UseVisualStyleBackColor = true;
            this.button_MR.Click += new System.EventHandler(this.button_MR_Click);
            // 
            // button_MC
            // 
            this.button_MC.Enabled = false;
            this.button_MC.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_MC.Location = new System.Drawing.Point(3, 3);
            this.button_MC.Name = "button_MC";
            this.button_MC.Size = new System.Drawing.Size(70, 54);
            this.button_MC.TabIndex = 1;
            this.button_MC.Text = "MC";
            this.button_MC.UseVisualStyleBackColor = true;
            this.button_MC.Click += new System.EventHandler(this.button_MC_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.button_equal, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.button_dot, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.button_0, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.button_convOper, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.button_plus, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.button_3, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.button_2, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.button_1, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.button_minus, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.button_6, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.button_5, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.button_4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.button_multiply, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.button_9, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.button_8, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.button_7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button_divide, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_root, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_square, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_multiInverse, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_back, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_C, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_CE, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_percent, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 180);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(382, 391);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // button_equal
            // 
            this.button_equal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_equal.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_equal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_equal.Location = new System.Drawing.Point(288, 328);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(89, 59);
            this.button_equal.TabIndex = 30;
            this.button_equal.Text = "=";
            this.button_equal.UseVisualStyleBackColor = false;
            this.button_equal.Click += new System.EventHandler(this.button_equal_Click);
            // 
            // button_dot
            // 
            this.button_dot.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_dot.Location = new System.Drawing.Point(193, 328);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(89, 59);
            this.button_dot.TabIndex = 29;
            this.button_dot.Text = ".";
            this.button_dot.UseVisualStyleBackColor = true;
            this.button_dot.Click += new System.EventHandler(this.button_dot_Click);
            // 
            // button_0
            // 
            this.button_0.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_0.Location = new System.Drawing.Point(98, 328);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(89, 59);
            this.button_0.TabIndex = 28;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_convOper
            // 
            this.button_convOper.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_convOper.Location = new System.Drawing.Point(3, 328);
            this.button_convOper.Name = "button_convOper";
            this.button_convOper.Size = new System.Drawing.Size(89, 59);
            this.button_convOper.TabIndex = 27;
            this.button_convOper.Text = "+/-";
            this.button_convOper.UseVisualStyleBackColor = true;
            this.button_convOper.Click += new System.EventHandler(this.button_convOper_Click);
            // 
            // button_plus
            // 
            this.button_plus.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_plus.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_plus.Location = new System.Drawing.Point(288, 263);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(89, 59);
            this.button_plus.TabIndex = 26;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = false;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_3
            // 
            this.button_3.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_3.Location = new System.Drawing.Point(193, 263);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(89, 59);
            this.button_3.TabIndex = 25;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_2
            // 
            this.button_2.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_2.Location = new System.Drawing.Point(98, 263);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(89, 59);
            this.button_2.TabIndex = 24;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_1
            // 
            this.button_1.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_1.Location = new System.Drawing.Point(3, 263);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(89, 59);
            this.button_1.TabIndex = 23;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_minus
            // 
            this.button_minus.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_minus.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_minus.Location = new System.Drawing.Point(288, 198);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(89, 59);
            this.button_minus.TabIndex = 22;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = false;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_6
            // 
            this.button_6.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_6.Location = new System.Drawing.Point(193, 198);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(89, 59);
            this.button_6.TabIndex = 21;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_5
            // 
            this.button_5.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_5.Location = new System.Drawing.Point(98, 198);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(89, 59);
            this.button_5.TabIndex = 20;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_4
            // 
            this.button_4.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_4.Location = new System.Drawing.Point(3, 198);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(89, 59);
            this.button_4.TabIndex = 19;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_multiply
            // 
            this.button_multiply.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_multiply.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_multiply.Location = new System.Drawing.Point(288, 133);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(89, 59);
            this.button_multiply.TabIndex = 18;
            this.button_multiply.Text = "×";
            this.button_multiply.UseVisualStyleBackColor = false;
            this.button_multiply.Click += new System.EventHandler(this.button_multiply_Click);
            // 
            // button_9
            // 
            this.button_9.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_9.Location = new System.Drawing.Point(193, 133);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(89, 59);
            this.button_9.TabIndex = 17;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // button_8
            // 
            this.button_8.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_8.Location = new System.Drawing.Point(98, 133);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(89, 59);
            this.button_8.TabIndex = 16;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // button_7
            // 
            this.button_7.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_7.Location = new System.Drawing.Point(3, 133);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(89, 59);
            this.button_7.TabIndex = 15;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // button_divide
            // 
            this.button_divide.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_divide.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_divide.Location = new System.Drawing.Point(288, 68);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(89, 59);
            this.button_divide.TabIndex = 14;
            this.button_divide.Text = "÷";
            this.button_divide.UseVisualStyleBackColor = false;
            this.button_divide.Click += new System.EventHandler(this.button_divide_Click);
            // 
            // button_root
            // 
            this.button_root.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_root.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_root.Location = new System.Drawing.Point(193, 68);
            this.button_root.Name = "button_root";
            this.button_root.Size = new System.Drawing.Size(89, 59);
            this.button_root.TabIndex = 13;
            this.button_root.Text = "√x";
            this.button_root.UseVisualStyleBackColor = false;
            this.button_root.Click += new System.EventHandler(this.button_root_Click);
            // 
            // button_square
            // 
            this.button_square.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_square.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_square.Location = new System.Drawing.Point(98, 68);
            this.button_square.Name = "button_square";
            this.button_square.Size = new System.Drawing.Size(89, 59);
            this.button_square.TabIndex = 12;
            this.button_square.Text = "x²";
            this.button_square.UseVisualStyleBackColor = false;
            this.button_square.Click += new System.EventHandler(this.button_square_Click);
            // 
            // button_multiInverse
            // 
            this.button_multiInverse.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_multiInverse.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_multiInverse.Location = new System.Drawing.Point(3, 68);
            this.button_multiInverse.Name = "button_multiInverse";
            this.button_multiInverse.Size = new System.Drawing.Size(89, 59);
            this.button_multiInverse.TabIndex = 11;
            this.button_multiInverse.Text = "1/x";
            this.button_multiInverse.UseVisualStyleBackColor = false;
            this.button_multiInverse.Click += new System.EventHandler(this.button_multiInverse_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_back.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_back.Location = new System.Drawing.Point(288, 3);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(89, 59);
            this.button_back.TabIndex = 10;
            this.button_back.Text = "⌫";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_C
            // 
            this.button_C.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_C.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_C.Location = new System.Drawing.Point(193, 3);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(89, 59);
            this.button_C.TabIndex = 9;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = false;
            this.button_C.Click += new System.EventHandler(this.button_C_Click);
            // 
            // button_CE
            // 
            this.button_CE.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_CE.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_CE.Location = new System.Drawing.Point(98, 3);
            this.button_CE.Name = "button_CE";
            this.button_CE.Size = new System.Drawing.Size(89, 59);
            this.button_CE.TabIndex = 8;
            this.button_CE.Text = "CE";
            this.button_CE.UseVisualStyleBackColor = false;
            this.button_CE.Click += new System.EventHandler(this.button_CE_Click);
            // 
            // button_percent
            // 
            this.button_percent.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_percent.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_percent.Location = new System.Drawing.Point(3, 3);
            this.button_percent.Name = "button_percent";
            this.button_percent.Size = new System.Drawing.Size(89, 59);
            this.button_percent.TabIndex = 7;
            this.button_percent.Text = "%";
            this.button_percent.UseVisualStyleBackColor = false;
            this.button_percent.Click += new System.EventHandler(this.button_percent_Click);
            // 
            // label_subDisplay
            // 
            this.label_subDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_subDisplay.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_subDisplay.Location = new System.Drawing.Point(0, 0);
            this.label_subDisplay.Name = "label_subDisplay";
            this.label_subDisplay.Size = new System.Drawing.Size(382, 43);
            this.label_subDisplay.TabIndex = 0;
            this.label_subDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 583);
            this.Controls.Add(this.label_subDisplay);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label_display);
            this.Name = "CalculatorForm";
            this.Text = "Calculatorcs";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_display;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_MS;
        private System.Windows.Forms.Button button_MMinus;
        private System.Windows.Forms.Button button_MPlus;
        private System.Windows.Forms.Button button_MR;
        private System.Windows.Forms.Button button_MC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_equal;
        private System.Windows.Forms.Button button_dot;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_convOper;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_multiply;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.Button button_root;
        private System.Windows.Forms.Button button_square;
        private System.Windows.Forms.Button button_multiInverse;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button button_CE;
        private System.Windows.Forms.Button button_percent;
        private System.Windows.Forms.Label label_subDisplay;
    }
}