namespace MVP_Prac.View
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NbPensja = new System.Windows.Forms.NumericUpDown();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.rButZlicenia = new System.Windows.Forms.RadioButton();
            this.rButCzasOkreślony = new System.Windows.Forms.RadioButton();
            this.rButNieokreślony = new System.Windows.Forms.RadioButton();
            this.comBxStanowisko = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ListDanePracownika = new System.Windows.Forms.ListBox();
            this.butSave = new System.Windows.Forms.Button();
            this.butLoad = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NbPensja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NbPensja);
            this.groupBox1.Controls.Add(this.textBoxNazwisko);
            this.groupBox1.Controls.Add(this.textBoxImie);
            this.groupBox1.Controls.Add(this.rButZlicenia);
            this.groupBox1.Controls.Add(this.rButCzasOkreślony);
            this.groupBox1.Controls.Add(this.rButNieokreślony);
            this.groupBox1.Controls.Add(this.comBxStanowisko);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.buttAdd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 435);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane Pracownica";
            // 
            // NbPensja
            // 
            this.NbPensja.Location = new System.Drawing.Point(145, 170);
            this.NbPensja.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NbPensja.Name = "NbPensja";
            this.NbPensja.Size = new System.Drawing.Size(201, 22);
            this.NbPensja.TabIndex = 15;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(143, 80);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(201, 22);
            this.textBoxNazwisko.TabIndex = 14;
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(143, 36);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(201, 22);
            this.textBoxImie.TabIndex = 13;
            // 
            // rButZlicenia
            // 
            this.rButZlicenia.AutoSize = true;
            this.rButZlicenia.Location = new System.Drawing.Point(143, 335);
            this.rButZlicenia.Name = "rButZlicenia";
            this.rButZlicenia.Size = new System.Drawing.Size(122, 20);
            this.rButZlicenia.TabIndex = 12;
            this.rButZlicenia.TabStop = true;
            this.rButZlicenia.Text = "Umowa zlicenia";
            this.rButZlicenia.UseVisualStyleBackColor = true;
            // 
            // rButCzasOkreślony
            // 
            this.rButCzasOkreślony.AutoSize = true;
            this.rButCzasOkreślony.Location = new System.Drawing.Point(143, 296);
            this.rButCzasOkreślony.Name = "rButCzasOkreślony";
            this.rButCzasOkreślony.Size = new System.Drawing.Size(185, 20);
            this.rButCzasOkreślony.TabIndex = 11;
            this.rButCzasOkreślony.TabStop = true;
            this.rButCzasOkreślony.Text = "Umowa na czas określony";
            this.rButCzasOkreślony.UseVisualStyleBackColor = true;
            // 
            // rButNieokreślony
            // 
            this.rButNieokreślony.AutoSize = true;
            this.rButNieokreślony.Location = new System.Drawing.Point(143, 254);
            this.rButNieokreślony.Name = "rButNieokreślony";
            this.rButNieokreślony.Size = new System.Drawing.Size(203, 20);
            this.rButNieokreślony.TabIndex = 10;
            this.rButNieokreślony.TabStop = true;
            this.rButNieokreślony.Text = "Umowa na czas nieokreślony";
            this.rButNieokreślony.UseVisualStyleBackColor = true;
            // 
            // comBxStanowisko
            // 
            this.comBxStanowisko.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBxStanowisko.FormattingEnabled = true;
            this.comBxStanowisko.Items.AddRange(new object[] {
            "Tester ",
            "Projektant",
            "Inżynier",
            "Mładszy programista",
            "Starszy programista"});
            this.comBxStanowisko.Location = new System.Drawing.Point(143, 209);
            this.comBxStanowisko.Name = "comBxStanowisko";
            this.comBxStanowisko.Size = new System.Drawing.Size(201, 24);
            this.comBxStanowisko.TabIndex = 9;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(144, 127);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 8;
            // 
            // buttAdd
            // 
            this.buttAdd.Location = new System.Drawing.Point(21, 393);
            this.buttAdd.Name = "buttAdd";
            this.buttAdd.Size = new System.Drawing.Size(346, 27);
            this.buttAdd.TabIndex = 6;
            this.buttAdd.Text = "Dodaj";
            this.buttAdd.UseVisualStyleBackColor = true;
            this.buttAdd.Click += new System.EventHandler(this.buttAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rodzaj umowy:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stanowisko:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pencja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data urodzenia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię:";
            // 
            // ListDanePracownika
            // 
            this.ListDanePracownika.FormattingEnabled = true;
            this.ListDanePracownika.ItemHeight = 16;
            this.ListDanePracownika.Location = new System.Drawing.Point(428, 12);
            this.ListDanePracownika.Name = "ListDanePracownika";
            this.ListDanePracownika.Size = new System.Drawing.Size(786, 500);
            this.ListDanePracownika.TabIndex = 6;
            this.ListDanePracownika.Click += new System.EventHandler(this.ListDanePracownicaButton_Cilck);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(33, 470);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(167, 31);
            this.butSave.TabIndex = 7;
            this.butSave.Text = "Zapisz";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butLoad
            // 
            this.butLoad.Location = new System.Drawing.Point(212, 470);
            this.butLoad.Name = "butLoad";
            this.butLoad.Size = new System.Drawing.Size(167, 31);
            this.butLoad.TabIndex = 8;
            this.butLoad.Text = "Wczsytaj";
            this.butLoad.UseVisualStyleBackColor = true;
            this.butLoad.Click += new System.EventHandler(this.butLoad_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 531);
            this.Controls.Add(this.butLoad);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.ListDanePracownika);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Pracownicy";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NbPensja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.RadioButton rButZlicenia;
        private System.Windows.Forms.RadioButton rButCzasOkreślony;
        private System.Windows.Forms.RadioButton rButNieokreślony;
        private System.Windows.Forms.ComboBox comBxStanowisko;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListDanePracownika;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butLoad;
        private System.Windows.Forms.NumericUpDown NbPensja;
        public System.Windows.Forms.ErrorProvider error;
    }
}