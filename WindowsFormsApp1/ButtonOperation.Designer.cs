namespace CalculatorForms
{
    partial class calculatorForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculatorForm));
            this.n1 = new System.Windows.Forms.Button();
            this.firstScreen = new System.Windows.Forms.TextBox();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.nDecimal = new System.Windows.Forms.Button();
            this.changer = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.fullErase = new System.Windows.Forms.Button();
            this.exponent = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.substraction = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.nEqual = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_History = new System.Windows.Forms.Button();
            this.mainScreen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // n1
            // 
            this.n1.BackColor = System.Drawing.Color.CadetBlue;
            this.n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.n1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.n1.Location = new System.Drawing.Point(12, 446);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(62, 54);
            this.n1.TabIndex = 0;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = false;
            // 
            // firstScreen
            // 
            this.firstScreen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.firstScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.firstScreen.ForeColor = System.Drawing.SystemColors.Menu;
            this.firstScreen.Location = new System.Drawing.Point(-4, 65);
            this.firstScreen.Multiline = true;
            this.firstScreen.Name = "firstScreen";
            this.firstScreen.Size = new System.Drawing.Size(349, 61);
            this.firstScreen.TabIndex = 1;
            this.firstScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.firstScreen.WordWrap = false;
            this.firstScreen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstScreen_KeyPress);
            // 
            // n2
            // 
            this.n2.BackColor = System.Drawing.Color.CadetBlue;
            this.n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.n2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.n2.Location = new System.Drawing.Point(91, 445);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(62, 54);
            this.n2.TabIndex = 2;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = false;
            // 
            // n3
            // 
            this.n3.BackColor = System.Drawing.Color.CadetBlue;
            this.n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.n3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.n3.Location = new System.Drawing.Point(170, 445);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(62, 54);
            this.n3.TabIndex = 3;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = false;
            // 
            // n6
            // 
            this.n6.BackColor = System.Drawing.Color.CadetBlue;
            this.n6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.n6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.n6.Location = new System.Drawing.Point(170, 365);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(62, 54);
            this.n6.TabIndex = 4;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = false;
            // 
            // n5
            // 
            this.n5.BackColor = System.Drawing.Color.CadetBlue;
            this.n5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.n5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.n5.Location = new System.Drawing.Point(91, 365);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(62, 54);
            this.n5.TabIndex = 5;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = false;
            // 
            // n4
            // 
            this.n4.BackColor = System.Drawing.Color.CadetBlue;
            this.n4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.n4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.n4.Location = new System.Drawing.Point(13, 365);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(62, 54);
            this.n4.TabIndex = 6;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = false;
            // 
            // n9
            // 
            this.n9.BackColor = System.Drawing.Color.CadetBlue;
            this.n9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.n9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.n9.Location = new System.Drawing.Point(170, 280);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(62, 54);
            this.n9.TabIndex = 7;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = false;
            // 
            // n8
            // 
            this.n8.BackColor = System.Drawing.Color.CadetBlue;
            this.n8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.n8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.n8.Location = new System.Drawing.Point(91, 280);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(62, 54);
            this.n8.TabIndex = 8;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = false;
            // 
            // n7
            // 
            this.n7.BackColor = System.Drawing.Color.CadetBlue;
            this.n7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.n7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.n7.Location = new System.Drawing.Point(12, 280);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(62, 54);
            this.n7.TabIndex = 9;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = false;
            // 
            // n0
            // 
            this.n0.BackColor = System.Drawing.Color.CadetBlue;
            this.n0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.n0.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.n0.Location = new System.Drawing.Point(91, 531);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(62, 54);
            this.n0.TabIndex = 10;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = false;
            // 
            // nDecimal
            // 
            this.nDecimal.BackColor = System.Drawing.Color.Teal;
            this.nDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nDecimal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nDecimal.Location = new System.Drawing.Point(170, 529);
            this.nDecimal.Name = "nDecimal";
            this.nDecimal.Size = new System.Drawing.Size(62, 54);
            this.nDecimal.TabIndex = 11;
            this.nDecimal.Text = ".";
            this.nDecimal.UseVisualStyleBackColor = false;
            this.nDecimal.Click += new System.EventHandler(this.nDecimal_Click);
            // 
            // changer
            // 
            this.changer.BackColor = System.Drawing.Color.Teal;
            this.changer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.changer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.changer.Location = new System.Drawing.Point(12, 531);
            this.changer.Name = "changer";
            this.changer.Size = new System.Drawing.Size(62, 54);
            this.changer.TabIndex = 12;
            this.changer.Text = "+/-";
            this.changer.UseVisualStyleBackColor = false;
            this.changer.Click += new System.EventHandler(this.changer_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.Teal;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.divide.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.divide.Location = new System.Drawing.Point(248, 193);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(62, 54);
            this.divide.TabIndex = 16;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Chocolate;
            this.back.Font = new System.Drawing.Font("Microsoft Uighur", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back.Location = new System.Drawing.Point(236, 132);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(74, 35);
            this.back.TabIndex = 17;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // fullErase
            // 
            this.fullErase.BackColor = System.Drawing.Color.Teal;
            this.fullErase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fullErase.ForeColor = System.Drawing.Color.Red;
            this.fullErase.Location = new System.Drawing.Point(12, 196);
            this.fullErase.Name = "fullErase";
            this.fullErase.Size = new System.Drawing.Size(62, 54);
            this.fullErase.TabIndex = 18;
            this.fullErase.Text = "C";
            this.fullErase.UseVisualStyleBackColor = false;
            this.fullErase.Click += new System.EventHandler(this.fullErase_Click);
            // 
            // exponent
            // 
            this.exponent.BackColor = System.Drawing.Color.Teal;
            this.exponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.exponent.ForeColor = System.Drawing.Color.Snow;
            this.exponent.Location = new System.Drawing.Point(91, 193);
            this.exponent.Name = "exponent";
            this.exponent.Size = new System.Drawing.Size(62, 54);
            this.exponent.TabIndex = 19;
            this.exponent.Text = "^";
            this.exponent.UseVisualStyleBackColor = false;
            this.exponent.Click += new System.EventHandler(this.exponential_Click);
            // 
            // mod
            // 
            this.mod.BackColor = System.Drawing.Color.Teal;
            this.mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mod.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mod.Location = new System.Drawing.Point(170, 193);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(62, 54);
            this.mod.TabIndex = 20;
            this.mod.Text = "%";
            this.mod.UseVisualStyleBackColor = false;
            this.mod.Click += new System.EventHandler(this.mod_Click);
            // 
            // multiplication
            // 
            this.multiplication.BackColor = System.Drawing.Color.Teal;
            this.multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.multiplication.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.multiplication.Location = new System.Drawing.Point(248, 280);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(62, 54);
            this.multiplication.TabIndex = 21;
            this.multiplication.Text = "X";
            this.multiplication.UseVisualStyleBackColor = false;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // substraction
            // 
            this.substraction.BackColor = System.Drawing.Color.Teal;
            this.substraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.substraction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.substraction.Location = new System.Drawing.Point(248, 365);
            this.substraction.Name = "substraction";
            this.substraction.Size = new System.Drawing.Size(62, 54);
            this.substraction.TabIndex = 22;
            this.substraction.Text = "-";
            this.substraction.UseVisualStyleBackColor = false;
            this.substraction.Click += new System.EventHandler(this.substraction_Click);
            // 
            // addition
            // 
            this.addition.BackColor = System.Drawing.Color.Teal;
            this.addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addition.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addition.Location = new System.Drawing.Point(248, 446);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(62, 54);
            this.addition.TabIndex = 23;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = false;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // nEqual
            // 
            this.nEqual.BackColor = System.Drawing.Color.Teal;
            this.nEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nEqual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nEqual.Location = new System.Drawing.Point(248, 529);
            this.nEqual.Name = "nEqual";
            this.nEqual.Size = new System.Drawing.Size(62, 54);
            this.nEqual.TabIndex = 24;
            this.nEqual.Text = "=";
            this.nEqual.UseVisualStyleBackColor = false;
            this.nEqual.Click += new System.EventHandler(this.nEqual_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(19, 594);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(291, 24);
            this.textBox2.TabIndex = 25;
            this.textBox2.Text = "ALPER KAAN MAZINOGLU";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_History
            // 
            this.btn_History.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_History.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_History.Location = new System.Drawing.Point(13, 133);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(219, 34);
            this.btn_History.TabIndex = 26;
            this.btn_History.Text = "Geçmiş İşlemler";
            this.btn_History.UseVisualStyleBackColor = false;
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // mainScreen
            // 
            this.mainScreen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mainScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.mainScreen.ForeColor = System.Drawing.SystemColors.Menu;
            this.mainScreen.Location = new System.Drawing.Point(-4, -1);
            this.mainScreen.Multiline = true;
            this.mainScreen.Name = "mainScreen";
            this.mainScreen.ReadOnly = true;
            this.mainScreen.Size = new System.Drawing.Size(349, 69);
            this.mainScreen.TabIndex = 27;
            this.mainScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainScreen.WordWrap = false;
            // 
            // calculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(336, 630);
            this.Controls.Add(this.mainScreen);
            this.Controls.Add(this.btn_History);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.nEqual);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.substraction);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.exponent);
            this.Controls.Add(this.fullErase);
            this.Controls.Add(this.back);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.changer);
            this.Controls.Add(this.nDecimal);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.firstScreen);
            this.Controls.Add(this.n1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "calculatorForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.calculatorScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.TextBox firstScreen;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button nDecimal;
        private System.Windows.Forms.Button changer;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button fullErase;
        private System.Windows.Forms.Button exponent;
        private System.Windows.Forms.Button mod;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button substraction;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button nEqual;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_History;
        private System.Windows.Forms.TextBox mainScreen;
    }
}

