using System.Drawing;

namespace CW_01_19_07
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.numbers_gb = new System.Windows.Forms.GroupBox();
            this.result_tb = new System.Windows.Forms.TextBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.history_cb = new System.Windows.Forms.ComboBox();
            this.div_btn = new System.Windows.Forms.Button();
            this.multi_btn = new System.Windows.Forms.Button();
            this.minus_btn = new System.Windows.Forms.Button();
            this.plus_btn = new System.Windows.Forms.Button();
            this.nine_btn = new System.Windows.Forms.Button();
            this.eight_btn = new System.Windows.Forms.Button();
            this.seven_btn = new System.Windows.Forms.Button();
            this.six_btn = new System.Windows.Forms.Button();
            this.five_btn = new System.Windows.Forms.Button();
            this.four_btn = new System.Windows.Forms.Button();
            this.enter_btn = new System.Windows.Forms.Button();
            this.three_btn = new System.Windows.Forms.Button();
            this.two_btn = new System.Windows.Forms.Button();
            this.one_btn = new System.Windows.Forms.Button();
            this.dot_btn = new System.Windows.Forms.Button();
            this.zero_btn = new System.Windows.Forms.Button();
            this.numbers_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // numbers_gb
            // 
            this.numbers_gb.Controls.Add(this.dot_btn);
            this.numbers_gb.Controls.Add(this.zero_btn);
            this.numbers_gb.Controls.Add(this.enter_btn);
            this.numbers_gb.Controls.Add(this.three_btn);
            this.numbers_gb.Controls.Add(this.two_btn);
            this.numbers_gb.Controls.Add(this.one_btn);
            this.numbers_gb.Controls.Add(this.six_btn);
            this.numbers_gb.Controls.Add(this.five_btn);
            this.numbers_gb.Controls.Add(this.four_btn);
            this.numbers_gb.Controls.Add(this.plus_btn);
            this.numbers_gb.Controls.Add(this.nine_btn);
            this.numbers_gb.Controls.Add(this.eight_btn);
            this.numbers_gb.Controls.Add(this.seven_btn);
            this.numbers_gb.Controls.Add(this.minus_btn);
            this.numbers_gb.Controls.Add(this.multi_btn);
            this.numbers_gb.Controls.Add(this.div_btn);
            this.numbers_gb.Location = new System.Drawing.Point(12, 104);
            this.numbers_gb.Name = "numbers_gb";
            this.numbers_gb.Size = new System.Drawing.Size(560, 445);
            this.numbers_gb.TabIndex = 0;
            this.numbers_gb.TabStop = false;
            this.numbers_gb.Text = "Циферблат";
            // 
            // result_tb
            // 
            this.result_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_tb.Location = new System.Drawing.Point(12, 13);
            this.result_tb.Multiline = true;
            this.result_tb.Name = "result_tb";
            this.result_tb.ReadOnly = true;
            this.result_tb.Size = new System.Drawing.Size(418, 56);
            this.result_tb.TabIndex = 1;
            this.result_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.result_tb.TextChanged += new System.EventHandler(this.result_tb_TextChanged);
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_btn.Location = new System.Drawing.Point(437, 13);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(135, 56);
            this.delete_btn.TabIndex = 2;
            this.delete_btn.Text = "Remove";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // history_cb
            // 
            this.history_cb.Enabled = false;
            this.history_cb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.history_cb.FormattingEnabled = true;
            this.history_cb.Location = new System.Drawing.Point(12, 76);
            this.history_cb.Name = "history_cb";
            this.history_cb.Size = new System.Drawing.Size(560, 21);
            this.history_cb.TabIndex = 3;
            // 
            // div_btn
            // 
            this.div_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.div_btn.Location = new System.Drawing.Point(10, 20);
            this.div_btn.Name = "div_btn";
            this.div_btn.Size = new System.Drawing.Size(225, 75);
            this.div_btn.TabIndex = 1;
            this.div_btn.Text = "/";
            this.div_btn.UseVisualStyleBackColor = true;
            this.div_btn.Click += new System.EventHandler(this.div_btn_Click);
            // 
            // multi_btn
            // 
            this.multi_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multi_btn.Location = new System.Drawing.Point(320, 20);
            this.multi_btn.Name = "multi_btn";
            this.multi_btn.Size = new System.Drawing.Size(75, 75);
            this.multi_btn.TabIndex = 2;
            this.multi_btn.Text = "*";
            this.multi_btn.UseVisualStyleBackColor = true;
            this.multi_btn.Click += new System.EventHandler(this.multi_btn_Click);
            // 
            // minus_btn
            // 
            this.minus_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus_btn.Location = new System.Drawing.Point(470, 19);
            this.minus_btn.Name = "minus_btn";
            this.minus_btn.Size = new System.Drawing.Size(75, 75);
            this.minus_btn.TabIndex = 3;
            this.minus_btn.Text = "-";
            this.minus_btn.UseVisualStyleBackColor = true;
            this.minus_btn.Click += new System.EventHandler(this.minus_btn_Click);
            // 
            // plus_btn
            // 
            this.plus_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus_btn.Location = new System.Drawing.Point(470, 100);
            this.plus_btn.Name = "plus_btn";
            this.plus_btn.Size = new System.Drawing.Size(75, 156);
            this.plus_btn.TabIndex = 7;
            this.plus_btn.Text = "+";
            this.plus_btn.UseVisualStyleBackColor = true;
            this.plus_btn.Click += new System.EventHandler(this.plus_btn_Click);
            // 
            // nine_btn
            // 
            this.nine_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nine_btn.Location = new System.Drawing.Point(320, 101);
            this.nine_btn.Name = "nine_btn";
            this.nine_btn.Size = new System.Drawing.Size(75, 75);
            this.nine_btn.TabIndex = 6;
            this.nine_btn.Text = "9";
            this.nine_btn.UseVisualStyleBackColor = true;
            this.nine_btn.Click += new System.EventHandler(this.nine_btn_Click);
            // 
            // eight_btn
            // 
            this.eight_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eight_btn.Location = new System.Drawing.Point(160, 101);
            this.eight_btn.Name = "eight_btn";
            this.eight_btn.Size = new System.Drawing.Size(75, 75);
            this.eight_btn.TabIndex = 5;
            this.eight_btn.Text = "8";
            this.eight_btn.UseVisualStyleBackColor = true;
            this.eight_btn.Click += new System.EventHandler(this.eight_btn_Click);
            // 
            // seven_btn
            // 
            this.seven_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seven_btn.Location = new System.Drawing.Point(10, 101);
            this.seven_btn.Name = "seven_btn";
            this.seven_btn.Size = new System.Drawing.Size(75, 75);
            this.seven_btn.TabIndex = 4;
            this.seven_btn.Text = "7";
            this.seven_btn.UseVisualStyleBackColor = true;
            this.seven_btn.Click += new System.EventHandler(this.seven_btn_Click);
            // 
            // six_btn
            // 
            this.six_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.six_btn.Location = new System.Drawing.Point(320, 182);
            this.six_btn.Name = "six_btn";
            this.six_btn.Size = new System.Drawing.Size(75, 75);
            this.six_btn.TabIndex = 10;
            this.six_btn.Text = "6";
            this.six_btn.UseVisualStyleBackColor = true;
            this.six_btn.Click += new System.EventHandler(this.six_btn_Click);
            // 
            // five_btn
            // 
            this.five_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.five_btn.Location = new System.Drawing.Point(160, 182);
            this.five_btn.Name = "five_btn";
            this.five_btn.Size = new System.Drawing.Size(75, 75);
            this.five_btn.TabIndex = 9;
            this.five_btn.Text = "5";
            this.five_btn.UseVisualStyleBackColor = true;
            this.five_btn.Click += new System.EventHandler(this.five_btn_Click);
            // 
            // four_btn
            // 
            this.four_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.four_btn.Location = new System.Drawing.Point(10, 182);
            this.four_btn.Name = "four_btn";
            this.four_btn.Size = new System.Drawing.Size(75, 75);
            this.four_btn.TabIndex = 8;
            this.four_btn.Text = "4";
            this.four_btn.UseVisualStyleBackColor = true;
            this.four_btn.Click += new System.EventHandler(this.four_btn_Click);
            // 
            // enter_btn
            // 
            this.enter_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter_btn.Location = new System.Drawing.Point(470, 262);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(75, 157);
            this.enter_btn.TabIndex = 15;
            this.enter_btn.Text = "Enter";
            this.enter_btn.UseVisualStyleBackColor = true;
            this.enter_btn.Click += new System.EventHandler(this.enter_btn_Click);
            // 
            // three_btn
            // 
            this.three_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.three_btn.Location = new System.Drawing.Point(320, 263);
            this.three_btn.Name = "three_btn";
            this.three_btn.Size = new System.Drawing.Size(75, 75);
            this.three_btn.TabIndex = 14;
            this.three_btn.Text = "3";
            this.three_btn.UseVisualStyleBackColor = true;
            this.three_btn.Click += new System.EventHandler(this.three_btn_Click);
            // 
            // two_btn
            // 
            this.two_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.two_btn.Location = new System.Drawing.Point(160, 263);
            this.two_btn.Name = "two_btn";
            this.two_btn.Size = new System.Drawing.Size(75, 75);
            this.two_btn.TabIndex = 13;
            this.two_btn.Text = "2";
            this.two_btn.UseVisualStyleBackColor = true;
            this.two_btn.Click += new System.EventHandler(this.two_btn_Click);
            // 
            // one_btn
            // 
            this.one_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.one_btn.Location = new System.Drawing.Point(10, 263);
            this.one_btn.Name = "one_btn";
            this.one_btn.Size = new System.Drawing.Size(75, 75);
            this.one_btn.TabIndex = 12;
            this.one_btn.Text = "1";
            this.one_btn.UseVisualStyleBackColor = true;
            this.one_btn.Click += new System.EventHandler(this.one_btn_Click);
            // 
            // dot_btn
            // 
            this.dot_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dot_btn.Location = new System.Drawing.Point(320, 344);
            this.dot_btn.Name = "dot_btn";
            this.dot_btn.Size = new System.Drawing.Size(75, 75);
            this.dot_btn.TabIndex = 18;
            this.dot_btn.Text = ".";
            this.dot_btn.UseVisualStyleBackColor = true;
            // 
            // zero_btn
            // 
            this.zero_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zero_btn.Location = new System.Drawing.Point(10, 344);
            this.zero_btn.Name = "zero_btn";
            this.zero_btn.Size = new System.Drawing.Size(225, 75);
            this.zero_btn.TabIndex = 16;
            this.zero_btn.Text = "0";
            this.zero_btn.UseVisualStyleBackColor = true;
            this.zero_btn.Click += new System.EventHandler(this.zero_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.history_cb);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.result_tb);
            this.Controls.Add(this.numbers_gb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.numbers_gb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox numbers_gb;
        private System.Windows.Forms.TextBox result_tb;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.ComboBox history_cb;
        private System.Windows.Forms.Button dot_btn;
        private System.Windows.Forms.Button zero_btn;
        private System.Windows.Forms.Button enter_btn;
        private System.Windows.Forms.Button three_btn;
        private System.Windows.Forms.Button two_btn;
        private System.Windows.Forms.Button one_btn;
        private System.Windows.Forms.Button six_btn;
        private System.Windows.Forms.Button five_btn;
        private System.Windows.Forms.Button four_btn;
        private System.Windows.Forms.Button plus_btn;
        private System.Windows.Forms.Button nine_btn;
        private System.Windows.Forms.Button eight_btn;
        private System.Windows.Forms.Button seven_btn;
        private System.Windows.Forms.Button minus_btn;
        private System.Windows.Forms.Button multi_btn;
        private System.Windows.Forms.Button div_btn;
    }
}

