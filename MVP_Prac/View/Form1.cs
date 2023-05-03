using System;
using System.Windows.Forms;



namespace MVP_Prac.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker.MaxDate = DateTime.Now;
        }

        public event Action AddEmployee;//1.Событиe(event) сигнализируeт системе о том, что произошло определенное действие.
        public event Action SaveEmployee;
        public event Action LoadEmployee;
        public event Action <string> LoadEmployeeButton;
        public System.Windows.Forms.TextBox UserName { get => textBoxImie; set => textBoxImie = value; }

        public System.Windows.Forms.TextBox UserSurname { get => textBoxNazwisko; set => textBoxNazwisko = value; }

        public DateTimePicker SelectedDate { get => dateTimePicker; set => dateTimePicker = value; }

        public NumericUpDown Salary { get => NbPensja; set => NbPensja = value; }

        public System.Windows.Forms.ComboBox Position { get => comBxStanowisko; set => comBxStanowisko = value; }

        public ListBox DataPracownikow { get => ListDanePracownika; set => ListDanePracownika = value; }

        public string Contract
        {
            get
            {
                if (rButCzasOkreślony.Checked) return "umowa na czas określony";
                else if (rButNieokreślony.Checked) return "umowa na czas nie określony";
                else if (rButZlicenia.Checked) return "umowa zlecenia";
                return "";//должен что то возвращать
            }set => Contract = value;
        }

        public RadioButton FixedTerm { get => rButCzasOkreślony; set => rButCzasOkreślony = value; }
        public RadioButton NonFixedTerm { get => rButNieokreślony; set => rButNieokreślony = value; }
        public RadioButton FeeForTaskAgreement { get => rButZlicenia; set => rButZlicenia = value; }

        //add data of new employee
        private void buttAdd_Click(object sender, EventArgs e) { AddEmployee?.Invoke(); }// 2.Вызов события 
        private void butSave_Click(object sender, EventArgs e) { SaveEmployee?.Invoke(); }
        private void butLoad_Click(object sender, EventArgs e) { LoadEmployee?.Invoke(); }
        private void ListDanePracownicaButton_Cilck(object sender, EventArgs e)
        {
            ListBox dataEmpl = sender as ListBox;
            if(dataEmpl.SelectedItem != null) { LoadEmployeeButton?.Invoke(dataEmpl.SelectedItem.ToString()); }
        }

       
    }
}
