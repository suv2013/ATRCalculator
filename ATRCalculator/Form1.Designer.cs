namespace ATRCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_inputArt = new TextBox();
            lbl_inputArt = new Label();
            lbl_inputSP = new Label();
            txt_HighPrice = new TextBox();
            btn_Calculate = new Button();
            lbl_lowPrice = new Label();
            txt_LowPrice = new TextBox();
            lbl_HighBelow = new Label();
            lbl_High = new Label();
            lbl_HighAbove = new Label();
            val_HighBelow = new Label();
            val_High = new Label();
            val_HighAbove = new Label();
            val_LowAbove = new Label();
            val_Low = new Label();
            val_LowBelow = new Label();
            lbl_LowAbove = new Label();
            lbl_Low = new Label();
            lbl_LowBelow = new Label();
            SuspendLayout();
            // 
            // txt_inputArt
            // 
            txt_inputArt.Location = new Point(326, 25);
            txt_inputArt.Name = "txt_inputArt";
            txt_inputArt.Size = new Size(100, 23);
            txt_inputArt.TabIndex = 0;
            // 
            // lbl_inputArt
            // 
            lbl_inputArt.AutoSize = true;
            lbl_inputArt.Location = new Point(255, 28);
            lbl_inputArt.Name = "lbl_inputArt";
            lbl_inputArt.Size = new Size(58, 15);
            lbl_inputArt.TabIndex = 1;
            lbl_inputArt.Text = "Input ATR";
            // 
            // lbl_inputSP
            // 
            lbl_inputSP.AutoSize = true;
            lbl_inputSP.Location = new Point(251, 63);
            lbl_inputSP.Name = "lbl_inputSP";
            lbl_inputSP.Size = new Size(62, 15);
            lbl_inputSP.TabIndex = 3;
            lbl_inputSP.Text = "High Price";
            // 
            // txt_HighPrice
            // 
            txt_HighPrice.Location = new Point(326, 60);
            txt_HighPrice.Name = "txt_HighPrice";
            txt_HighPrice.Size = new Size(100, 23);
            txt_HighPrice.TabIndex = 1;
            // 
            // btn_Calculate
            // 
            btn_Calculate.Location = new Point(274, 127);
            btn_Calculate.Name = "btn_Calculate";
            btn_Calculate.Size = new Size(113, 33);
            btn_Calculate.TabIndex = 4;
            btn_Calculate.Text = "Calculate";
            btn_Calculate.UseVisualStyleBackColor = true;
            btn_Calculate.Click += btn_Calculate_Click;
            // 
            // lbl_lowPrice
            // 
            lbl_lowPrice.AutoSize = true;
            lbl_lowPrice.Location = new Point(251, 98);
            lbl_lowPrice.Name = "lbl_lowPrice";
            lbl_lowPrice.Size = new Size(58, 15);
            lbl_lowPrice.TabIndex = 7;
            lbl_lowPrice.Text = "Low Price";
            // 
            // txt_LowPrice
            // 
            txt_LowPrice.Location = new Point(326, 95);
            txt_LowPrice.Name = "txt_LowPrice";
            txt_LowPrice.Size = new Size(100, 23);
            txt_LowPrice.TabIndex = 2;
            // 
            // lbl_HighBelow
            // 
            lbl_HighBelow.AutoSize = true;
            lbl_HighBelow.ForeColor = Color.LightGreen;
            lbl_HighBelow.Location = new Point(37, 199);
            lbl_HighBelow.Name = "lbl_HighBelow";
            lbl_HighBelow.Size = new Size(65, 15);
            lbl_HighBelow.TabIndex = 8;
            lbl_HighBelow.Text = "HighBelow";
            lbl_HighBelow.Visible = false;
            // 
            // lbl_High
            // 
            lbl_High.AutoSize = true;
            lbl_High.ForeColor = Color.Green;
            lbl_High.Location = new Point(274, 199);
            lbl_High.Name = "lbl_High";
            lbl_High.Size = new Size(33, 15);
            lbl_High.TabIndex = 9;
            lbl_High.Text = "High";
            lbl_High.Visible = false;
            // 
            // lbl_HighAbove
            // 
            lbl_HighAbove.AutoSize = true;
            lbl_HighAbove.ForeColor = Color.Lime;
            lbl_HighAbove.Location = new Point(436, 199);
            lbl_HighAbove.Name = "lbl_HighAbove";
            lbl_HighAbove.Size = new Size(67, 15);
            lbl_HighAbove.TabIndex = 10;
            lbl_HighAbove.Text = "HighAbove";
            lbl_HighAbove.Visible = false;
            // 
            // val_HighBelow
            // 
            val_HighBelow.AutoSize = true;
            val_HighBelow.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            val_HighBelow.ForeColor = Color.LightGreen;
            val_HighBelow.Location = new Point(128, 199);
            val_HighBelow.Name = "val_HighBelow";
            val_HighBelow.Size = new Size(89, 15);
            val_HighBelow.TabIndex = 11;
            val_HighBelow.Text = "val_HighBelow";
            val_HighBelow.Visible = false;
            // 
            // val_High
            // 
            val_High.AutoSize = true;
            val_High.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            val_High.ForeColor = Color.Green;
            val_High.Location = new Point(333, 199);
            val_High.Name = "val_High";
            val_High.Size = new Size(54, 15);
            val_High.TabIndex = 12;
            val_High.Text = "val_High";
            val_High.Visible = false;
            // 
            // val_HighAbove
            // 
            val_HighAbove.AutoSize = true;
            val_HighAbove.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            val_HighAbove.ForeColor = Color.Lime;
            val_HighAbove.Location = new Point(529, 199);
            val_HighAbove.Name = "val_HighAbove";
            val_HighAbove.Size = new Size(90, 15);
            val_HighAbove.TabIndex = 13;
            val_HighAbove.Text = "val_HighAbove";
            val_HighAbove.Visible = false;
            // 
            // val_LowAbove
            // 
            val_LowAbove.AutoSize = true;
            val_LowAbove.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            val_LowAbove.ForeColor = Color.Red;
            val_LowAbove.Location = new Point(529, 253);
            val_LowAbove.Name = "val_LowAbove";
            val_LowAbove.Size = new Size(87, 15);
            val_LowAbove.TabIndex = 19;
            val_LowAbove.Text = "val_LowAbove";
            val_LowAbove.Visible = false;
            // 
            // val_Low
            // 
            val_Low.AutoSize = true;
            val_Low.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            val_Low.ForeColor = Color.FromArgb(255, 128, 128);
            val_Low.Location = new Point(333, 253);
            val_Low.Name = "val_Low";
            val_Low.Size = new Size(51, 15);
            val_Low.TabIndex = 18;
            val_Low.Text = "val_Low";
            val_Low.Visible = false;
            // 
            // val_LowBelow
            // 
            val_LowBelow.AutoSize = true;
            val_LowBelow.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            val_LowBelow.ForeColor = Color.OrangeRed;
            val_LowBelow.Location = new Point(128, 253);
            val_LowBelow.Name = "val_LowBelow";
            val_LowBelow.Size = new Size(86, 15);
            val_LowBelow.TabIndex = 17;
            val_LowBelow.Text = "val_LowBelow";
            val_LowBelow.Visible = false;
            // 
            // lbl_LowAbove
            // 
            lbl_LowAbove.AutoSize = true;
            lbl_LowAbove.ForeColor = Color.Red;
            lbl_LowAbove.Location = new Point(436, 253);
            lbl_LowAbove.Name = "lbl_LowAbove";
            lbl_LowAbove.Size = new Size(63, 15);
            lbl_LowAbove.TabIndex = 16;
            lbl_LowAbove.Text = "LowAbove";
            lbl_LowAbove.Visible = false;
            // 
            // lbl_Low
            // 
            lbl_Low.AutoSize = true;
            lbl_Low.ForeColor = Color.FromArgb(255, 128, 128);
            lbl_Low.Location = new Point(274, 253);
            lbl_Low.Name = "lbl_Low";
            lbl_Low.Size = new Size(29, 15);
            lbl_Low.TabIndex = 15;
            lbl_Low.Text = "Low";
            lbl_Low.Visible = false;
            // 
            // lbl_LowBelow
            // 
            lbl_LowBelow.AutoSize = true;
            lbl_LowBelow.ForeColor = Color.OrangeRed;
            lbl_LowBelow.Location = new Point(37, 253);
            lbl_LowBelow.Name = "lbl_LowBelow";
            lbl_LowBelow.Size = new Size(61, 15);
            lbl_LowBelow.TabIndex = 14;
            lbl_LowBelow.Text = "LowBelow";
            lbl_LowBelow.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 369);
            Controls.Add(val_LowAbove);
            Controls.Add(val_Low);
            Controls.Add(val_LowBelow);
            Controls.Add(lbl_LowAbove);
            Controls.Add(lbl_Low);
            Controls.Add(lbl_LowBelow);
            Controls.Add(val_HighAbove);
            Controls.Add(val_High);
            Controls.Add(val_HighBelow);
            Controls.Add(lbl_HighAbove);
            Controls.Add(lbl_High);
            Controls.Add(lbl_HighBelow);
            Controls.Add(lbl_lowPrice);
            Controls.Add(txt_LowPrice);
            Controls.Add(btn_Calculate);
            Controls.Add(lbl_inputSP);
            Controls.Add(txt_HighPrice);
            Controls.Add(lbl_inputArt);
            Controls.Add(txt_inputArt);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_inputArt;
        private Label lbl_inputArt;
        private Label lbl_inputSP;
        private TextBox txt_HighPrice;
        private Button btn_Calculate;
        private Label lbl_lowPrice;
        private TextBox txt_LowPrice;
        private Label lbl_HighBelow;
        private Label lbl_High;
        private Label lbl_HighAbove;
        private Label val_HighBelow;
        private Label val_High;
        private Label val_HighAbove;
        private Label val_LowAbove;
        private Label val_Low;
        private Label val_LowBelow;
        private Label lbl_LowAbove;
        private Label lbl_Low;
        private Label lbl_LowBelow;
    }
}