namespace Homework33
{
    partial class Val
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
            this.AnswerForm = new System.Windows.Forms.GroupBox();
            this.get_res = new System.Windows.Forms.Button();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.date_birthday = new System.Windows.Forms.DateTimePicker();
            this.city = new System.Windows.Forms.ComboBox();
            this.country = new System.Windows.Forms.ComboBox();
            this.phone = new System.Windows.Forms.TextBox();
            this._3name = new System.Windows.Forms.TextBox();
            this._2name = new System.Windows.Forms.TextBox();
            this._1name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AnswerForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnswerForm
            // 
            this.AnswerForm.Controls.Add(this.get_res);
            this.AnswerForm.Controls.Add(this.female);
            this.AnswerForm.Controls.Add(this.male);
            this.AnswerForm.Controls.Add(this.date_birthday);
            this.AnswerForm.Controls.Add(this.city);
            this.AnswerForm.Controls.Add(this.country);
            this.AnswerForm.Controls.Add(this.phone);
            this.AnswerForm.Controls.Add(this._3name);
            this.AnswerForm.Controls.Add(this._2name);
            this.AnswerForm.Controls.Add(this._1name);
            this.AnswerForm.Controls.Add(this.label8);
            this.AnswerForm.Controls.Add(this.label7);
            this.AnswerForm.Controls.Add(this.label6);
            this.AnswerForm.Controls.Add(this.label5);
            this.AnswerForm.Controls.Add(this.label4);
            this.AnswerForm.Controls.Add(this.label3);
            this.AnswerForm.Controls.Add(this.label2);
            this.AnswerForm.Controls.Add(this.label1);
            this.AnswerForm.Location = new System.Drawing.Point(12, 12);
            this.AnswerForm.Name = "AnswerForm";
            this.AnswerForm.Size = new System.Drawing.Size(268, 437);
            this.AnswerForm.TabIndex = 0;
            this.AnswerForm.TabStop = false;
            this.AnswerForm.Text = "AnswerForm";
            // 
            // get_res
            // 
            this.get_res.Location = new System.Drawing.Point(9, 336);
            this.get_res.Name = "get_res";
            this.get_res.Size = new System.Drawing.Size(253, 51);
            this.get_res.TabIndex = 20;
            this.get_res.Text = "ПОСМОТРЕТЬ РЕЗУЛЬТАТЫ!";
            this.get_res.UseVisualStyleBackColor = true;
            this.get_res.Click += new System.EventHandler(this.get_res_Click);
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(167, 298);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(72, 17);
            this.female.TabIndex = 19;
            this.female.TabStop = true;
            this.female.Text = "Женский";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(63, 300);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(71, 17);
            this.male.TabIndex = 18;
            this.male.TabStop = true;
            this.male.Text = "Мужской";
            this.male.UseVisualStyleBackColor = true;
            // 
            // date_birthday
            // 
            this.date_birthday.Location = new System.Drawing.Point(124, 255);
            this.date_birthday.Name = "date_birthday";
            this.date_birthday.Size = new System.Drawing.Size(138, 20);
            this.date_birthday.TabIndex = 17;
            // 
            // city
            // 
            this.city.FormattingEnabled = true;
            this.city.Location = new System.Drawing.Point(124, 169);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(138, 21);
            this.city.TabIndex = 16;
            // 
            // country
            // 
            this.country.FormattingEnabled = true;
            this.country.Items.AddRange(new object[] {
            "Россия",
            "Казахстан"});
            this.country.Location = new System.Drawing.Point(124, 134);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(138, 21);
            this.country.TabIndex = 15;
            this.country.SelectedIndexChanged += new System.EventHandler(this.country_SelectedIndexChanged);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(124, 198);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(138, 20);
            this.phone.TabIndex = 13;
            // 
            // _3name
            // 
            this._3name.Location = new System.Drawing.Point(124, 80);
            this._3name.Name = "_3name";
            this._3name.Size = new System.Drawing.Size(138, 20);
            this._3name.TabIndex = 10;
            // 
            // _2name
            // 
            this._2name.Location = new System.Drawing.Point(124, 51);
            this._2name.Name = "_2name";
            this._2name.Size = new System.Drawing.Size(138, 20);
            this._2name.TabIndex = 9;
            // 
            // _1name
            // 
            this._1name.Location = new System.Drawing.Point(124, 16);
            this._1name.Name = "_1name";
            this._1name.Size = new System.Drawing.Size(138, 20);
            this._1name.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "Пол:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Дата рождения:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Телефон";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Город";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Страна:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия: ";
            // 
            // Val
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 461);
            this.Controls.Add(this.AnswerForm);
            this.Name = "Val";
            this.Text = "Val";
            this.AnswerForm.ResumeLayout(false);
            this.AnswerForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AnswerForm;
        private System.Windows.Forms.Button get_res;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.DateTimePicker date_birthday;
        private System.Windows.Forms.ComboBox city;
        private System.Windows.Forms.ComboBox country;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox _3name;
        private System.Windows.Forms.TextBox _2name;
        private System.Windows.Forms.TextBox _1name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

