namespace DESAttack
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timerTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.attackButton = new System.Windows.Forms.Button();
            this.prepButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.encryptedTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.decodeTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.raundKeysTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.attackButton);
            this.groupBox2.Controls.Add(this.prepButton);
            this.groupBox2.Location = new System.Drawing.Point(578, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 562);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Атака";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.raundKeysTextBox);
            this.groupBox3.Controls.Add(this.keyTextBox);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.timerTextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(0, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(490, 405);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Результаты";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(171, 38);
            this.keyTextBox.Multiline = true;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(206, 36);
            this.keyTextBox.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(171, 137);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 36);
            this.textBox2.TabIndex = 4;
            // 
            // timerTextBox
            // 
            this.timerTextBox.Location = new System.Drawing.Point(171, 84);
            this.timerTextBox.Multiline = true;
            this.timerTextBox.Name = "timerTextBox";
            this.timerTextBox.Size = new System.Drawing.Size(206, 36);
            this.timerTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Биты ключа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Время работы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Исходный ключ";
            // 
            // attackButton
            // 
            this.attackButton.Location = new System.Drawing.Point(27, 89);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(203, 46);
            this.attackButton.TabIndex = 6;
            this.attackButton.Text = "Атака линейным криптоанализом";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // prepButton
            // 
            this.prepButton.Location = new System.Drawing.Point(27, 22);
            this.prepButton.Name = "prepButton";
            this.prepButton.Size = new System.Drawing.Size(203, 46);
            this.prepButton.TabIndex = 5;
            this.prepButton.Text = "Подготовительный этап";
            this.prepButton.UseVisualStyleBackColor = true;
            this.prepButton.Click += new System.EventHandler(this.prepButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.encryptedTextBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.codeTextBox);
            this.groupBox1.Controls.Add(this.decodeTextBox);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 346);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Декодированое ";
            // 
            // encryptedTextBox
            // 
            this.encryptedTextBox.Location = new System.Drawing.Point(201, 113);
            this.encryptedTextBox.Multiline = true;
            this.encryptedTextBox.Name = "encryptedTextBox";
            this.encryptedTextBox.Size = new System.Drawing.Size(363, 66);
            this.encryptedTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Кодировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(201, 20);
            this.codeTextBox.Multiline = true;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(363, 60);
            this.codeTextBox.TabIndex = 2;
            // 
            // decodeTextBox
            // 
            this.decodeTextBox.Location = new System.Drawing.Point(201, 207);
            this.decodeTextBox.Multiline = true;
            this.decodeTextBox.Name = "decodeTextBox";
            this.decodeTextBox.Size = new System.Drawing.Size(368, 66);
            this.decodeTextBox.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 134);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Декодировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // raundKeysTextBox
            // 
            this.raundKeysTextBox.Location = new System.Drawing.Point(114, 209);
            this.raundKeysTextBox.Multiline = true;
            this.raundKeysTextBox.Name = "raundKeysTextBox";
            this.raundKeysTextBox.Size = new System.Drawing.Size(370, 171);
            this.raundKeysTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Раундевые ключи";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 596);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "DES";
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox timerTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Button prepButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox encryptedTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox decodeTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox raundKeysTextBox;
        private System.Windows.Forms.Label label5;
    }
}

