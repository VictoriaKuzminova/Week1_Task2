
namespace _1
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
            this.X_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Y_textBox = new System.Windows.Forms.TextBox();
            this.res_Button = new System.Windows.Forms.Button();
            this.res_TextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Координата точки x = ";
            // 
            // X_textBox
            // 
            this.X_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X_textBox.Location = new System.Drawing.Point(274, 30);
            this.X_textBox.Name = "X_textBox";
            this.X_textBox.Size = new System.Drawing.Size(182, 30);
            this.X_textBox.TabIndex = 1;
            this.X_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X_textBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(33, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Координата точки y = ";
            // 
            // Y_textBox
            // 
            this.Y_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y_textBox.Location = new System.Drawing.Point(274, 87);
            this.Y_textBox.Name = "Y_textBox";
            this.Y_textBox.Size = new System.Drawing.Size(182, 30);
            this.Y_textBox.TabIndex = 3;
            this.Y_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Y_textBox_KeyPress);
            // 
            // res_Button
            // 
            this.res_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.res_Button.Location = new System.Drawing.Point(360, 154);
            this.res_Button.Name = "res_Button";
            this.res_Button.Size = new System.Drawing.Size(143, 70);
            this.res_Button.TabIndex = 4;
            this.res_Button.Text = "Расположение\r\nточки";
            this.res_Button.UseVisualStyleBackColor = true;
            this.res_Button.Click += new System.EventHandler(this.res_Button_Click);
            // 
            // res_TextBox
            // 
            this.res_TextBox.Location = new System.Drawing.Point(38, 138);
            this.res_TextBox.Name = "res_TextBox";
            this.res_TextBox.Size = new System.Drawing.Size(301, 96);
            this.res_TextBox.TabIndex = 5;
            this.res_TextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 271);
            this.Controls.Add(this.res_TextBox);
            this.Controls.Add(this.res_Button);
            this.Controls.Add(this.Y_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.X_textBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Точка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox X_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Y_textBox;
        private System.Windows.Forms.Button res_Button;
        private System.Windows.Forms.RichTextBox res_TextBox;
    }
}

