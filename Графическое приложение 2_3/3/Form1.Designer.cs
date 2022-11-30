
namespace _3
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
            this.label1 = new System.Windows.Forms.Label();
            this.price_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kol_TextBox = new System.Windows.Forms.TextBox();
            this.res_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.do_while_TextBox = new System.Windows.Forms.RichTextBox();
            this.for_TextBox = new System.Windows.Forms.RichTextBox();
            this.while_TextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(248, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Стоимость товара:";
            // 
            // price_TextBox
            // 
            this.price_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_TextBox.Location = new System.Drawing.Point(482, 34);
            this.price_TextBox.Name = "price_TextBox";
            this.price_TextBox.Size = new System.Drawing.Size(217, 30);
            this.price_TextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(135, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество выводимых строк: ";
            // 
            // kol_TextBox
            // 
            this.kol_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kol_TextBox.Location = new System.Drawing.Point(482, 89);
            this.kol_TextBox.Name = "kol_TextBox";
            this.kol_TextBox.Size = new System.Drawing.Size(217, 30);
            this.kol_TextBox.TabIndex = 3;
            // 
            // res_button
            // 
            this.res_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res_button.Location = new System.Drawing.Point(403, 146);
            this.res_button.Name = "res_button";
            this.res_button.Size = new System.Drawing.Size(166, 40);
            this.res_button.TabIndex = 4;
            this.res_button.Text = "Вывод";
            this.res_button.UseVisualStyleBackColor = true;
            this.res_button.Click += new System.EventHandler(this.res_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Цикл While";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Цикл Do...While";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(584, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Цикл For";
            // 
            // do_while_TextBox
            // 
            this.do_while_TextBox.Location = new System.Drawing.Point(307, 254);
            this.do_while_TextBox.Name = "do_while_TextBox";
            this.do_while_TextBox.Size = new System.Drawing.Size(262, 171);
            this.do_while_TextBox.TabIndex = 8;
            this.do_while_TextBox.Text = "";
            // 
            // for_TextBox
            // 
            this.for_TextBox.Location = new System.Drawing.Point(587, 254);
            this.for_TextBox.Name = "for_TextBox";
            this.for_TextBox.Size = new System.Drawing.Size(262, 171);
            this.for_TextBox.TabIndex = 9;
            this.for_TextBox.Text = "";
            // 
            // while_TextBox
            // 
            this.while_TextBox.Location = new System.Drawing.Point(30, 254);
            this.while_TextBox.Name = "while_TextBox";
            this.while_TextBox.Size = new System.Drawing.Size(252, 171);
            this.while_TextBox.TabIndex = 10;
            this.while_TextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.while_TextBox);
            this.Controls.Add(this.for_TextBox);
            this.Controls.Add(this.do_while_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.res_button);
            this.Controls.Add(this.kol_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.price_TextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Стоимость товара";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox price_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kol_TextBox;
        private System.Windows.Forms.Button res_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox do_while_TextBox;
        private System.Windows.Forms.RichTextBox for_TextBox;
        private System.Windows.Forms.RichTextBox while_TextBox;
    }
}

