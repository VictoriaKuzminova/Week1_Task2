
namespace _4
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
            this.res_button = new System.Windows.Forms.Button();
            this.res_textBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // res_button
            // 
            this.res_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res_button.Location = new System.Drawing.Point(125, 25);
            this.res_button.Name = "res_button";
            this.res_button.Size = new System.Drawing.Size(165, 36);
            this.res_button.TabIndex = 0;
            this.res_button.Text = "Вывести";
            this.res_button.UseVisualStyleBackColor = true;
            this.res_button.Click += new System.EventHandler(this.res_button_Click);
            // 
            // res_textBox
            // 
            this.res_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res_textBox.Location = new System.Drawing.Point(45, 95);
            this.res_textBox.Name = "res_textBox";
            this.res_textBox.Size = new System.Drawing.Size(332, 177);
            this.res_textBox.TabIndex = 1;
            this.res_textBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 312);
            this.Controls.Add(this.res_textBox);
            this.Controls.Add(this.res_button);
            this.Name = "Form1";
            this.Text = "Вывод чисел по образцу";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button res_button;
        private System.Windows.Forms.RichTextBox res_textBox;
    }
}

