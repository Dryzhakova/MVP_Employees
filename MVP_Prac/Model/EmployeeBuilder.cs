using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml;


//using MVP_Prac.View;


namespace MVP_Prac.Model
{
    class EmployeeBuilder
    {
        private View.Form1 _view;
       // private Model _model;

        public EmployeeBuilder(View.Form1 view) { _view = view; }
        public void AddEmployee()
        {
            string name = _view.UserName.Text;
            string surname = _view.UserSurname.Text;

            DateTime date = _view.SelectedDate.Value;
            string BirthDay = date.ToString().Substring(0, 10);//возвращает подстроку строки между двумя индексами

            decimal salary =  _view.Salary.Value;
            string position = _view.Position.Text;
            string contract = _view.Contract;

            bool CheckName(string ckName)
            {

                if (ckName == "") { _view.error.SetError(_view.UserName, "You need to enter a name"); return false; }
                else if (!ckName.All(Char.IsLetter)) { _view.error.SetError(_view.UserName, "Only letters!"); return false; }
                else _view.error.SetError(_view.UserName, String.Empty); return true;
            }

            bool CheckSurame(String ckSurname)
            {
                if (ckSurname == "") { _view.error.SetError(_view.UserSurname, "You need to enter a Surname"); return false; }
                else if (!ckSurname.All(Char.IsLetter)) { _view.error.SetError(_view.UserSurname, "Only letters!"); return false; }
                else if (ckSurname.Length < 3) { _view.error.SetError(_view.UserSurname, "Short Surname"); return false; }
                else _view.error.SetError(_view.UserSurname, ""); return true;
            }

            string capitalizedData(string nonCapData)
            {
                var textInfo = new CultureInfo("en-EN").TextInfo;
                //преобразуем текст kate = Kate
                string capData = textInfo.ToTitleCase(textInfo.ToLower(nonCapData));
                return capData;
            }

            bool CheckPossition(String ckPosition) 
            {
                if (ckPosition == "") { _view.error.SetError(_view.Position, "Not mentioned"); return false; }
                else _view.error.SetError(_view.Position, ""); return true;
            }

            bool CheckSalary(decimal ckSalary)
            {
                if (ckSalary <= 1000) { _view.error.SetError(_view.Salary, "more than 1000!"); return false; }
                else _view.error.SetError(_view.Salary, ""); return true;
            }

            bool CheckContract(String ckContract)
            {
                if (ckContract == "") { _view.error.SetError(_view.NonFixedTerm, "Not mentioned"); return false; }
                else _view.error.SetError(_view.NonFixedTerm, ""); return true;
            }

            bool CheckDate(DateTime dt)
            {
                string selectedYear = dt.ToString().Substring(6,4);
                string nowYear = DateTime.Now.ToString().Substring(6,4);
                int checkAge = int.Parse(nowYear) - int.Parse(selectedYear);

                if (selectedYear == "" || checkAge < 18 || checkAge > 70)
                {
                    _view.error.SetError(_view.SelectedDate, "Not correct"); return false;
                }
                else _view.error.SetError(_view.SelectedDate, "");return true;
            }

            //add data for new employee
            int index = _view.DataPracownikow.FindStringExact(name, -1);//проверка есть ли уже такой человек в базе
            if (!CheckName(name) || !CheckSurame(surname) || !CheckPossition(position) || !CheckSalary(salary) || !CheckContract(contract) || !CheckDate(date) || index != 1) return; 
            else 
            {
                string outEmployee = $"{capitalizedData(name)} {capitalizedData(surname)}, {BirthDay}, {position}, {salary}PLN, {contract}";
                _view.DataPracownikow.Items.Add(outEmployee);
            }

            //обнуляем
            _view.UserName.Text = "";
            _view.UserSurname.Text = "";
            _view.Position.Text = null;
            _view.Salary.Value = Convert.ToDecimal("0");
            _view.FixedTerm.Checked = false;
            _view.NonFixedTerm.Checked = false;
            _view.FeeForTaskAgreement.Checked = false;
            _view.SelectedDate.Value = Convert.ToDateTime("08.07.2003");
            if (index != -1) _view.DataPracownikow.Items.RemoveAt(index);


        }

        public void SaveEmployee()
        {
            string fileName = "EmployeeData.xml";
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement root = xmlDocument.CreateElement("EmpData");

            for (int i = 0; i < _view.DataPracownikow.Items.Count; i++)
            {
                XmlElement child = xmlDocument.CreateElement("item");
                child.InnerText = _view.DataPracownikow.Items[i].ToString();
                root.AppendChild(child);
            }
            xmlDocument.AppendChild(root); 
            using (StreamWriter data = new StreamWriter(fileName)) xmlDocument.Save(data);

            //copy xml
            //string newfileName = "NewEmployeeData.xml";
            //var xdoc = XDocument.Load(fileName);
            //XDocument newXDoc = new XDocument();
            //var elem = new XElement("EmpData");//создаём корневой элемент
            //foreach (XElement elm in xdoc.Descendants())
            //{
            //    if ((elm.Name.ToString() == "item"))
            //    {
            //        elem.Add(new XElement(elm)); // добавляем в корневой, а не в документ!!!
            //    }
            //}
            //newXDoc.Add(elem);// помещаем заполненный корневой в документ
            //newXDoc.Save(newfileName);

            //xdoc.Root.RemoveAll();
        }

        public void LoadEmployee()
        {
            _view.DataPracownikow.Items.Clear();

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("EmployeeData.xml");
            XmlElement root = xmlDocument.DocumentElement;

            foreach (XmlNode data in root.ChildNodes) { _view.DataPracownikow.Items.Add(data.InnerText); }

        }

        public void LoadEmployeeButton(string savedemployeeData)
        {
            _view.DataPracownikow.SelectedIndex = -1;
            string[] coma = savedemployeeData.Split(',');
            string loadNameSurname = coma[0];
            string loadName = loadNameSurname.Split()[0];
            string loadSurmame = loadNameSurname.Substring(loadName.Length + 1);
            string birthday = coma[1].Substring(1);
            string position = coma[2].Substring(1);
            string salary = coma[3].Substring(1);
            string contract = coma[4].Substring(1);

            _view.UserName.Text = loadName;
            _view.UserSurname.Text = loadSurmame;
            _view.SelectedDate.Value = Convert.ToDateTime(birthday);
            _view.Salary.Value = Convert.ToDecimal(salary.Substring(0, salary.Length - 3));
            _view.Position.Text = position;

            if(contract == "umowa na czas nieokreślony")
            {
                _view.NonFixedTerm.Checked = true;
            }
            else if (contract == "umowa na czas określony")
            {
                _view.FixedTerm.Checked = true;
            }
            else
            {
                _view.FeeForTaskAgreement.Checked = true;
            }
        }
    }
}
