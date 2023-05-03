using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Prac.Presenter
{
    class Presenter
    {
        private View.Form1 _view;
        private Model.Employeer _employModel;

        public Presenter(View.Form1 view, Model.Employeer employeer) 
        {
            _view = view;
            _employModel = employeer;

            _view.AddEmployee += _view_AddEmployee;
            _view.SaveEmployee += _view_SaveEmployee;
            _view.LoadEmployee += _view_LoadEmployee;
            _view.LoadEmployeeButton += _view_LoadEmployeeButton;
        }

        private void _view_AddEmployee()
        {
            _employModel.employee = new Model.EmployeeBuilder(_view);
            _employModel.employee.AddEmployee();
        }

        private void _view_SaveEmployee()
        {
            _employModel.employee = new Model.EmployeeBuilder(_view);
            _employModel.employee.SaveEmployee();
        }

        private void _view_LoadEmployee()
        {
            _employModel.employee = new Model.EmployeeBuilder(_view);
            _employModel.employee.LoadEmployee();
        }
        private void _view_LoadEmployeeButton(string selectedEmployee)
        {
            _employModel.employee = new Model.EmployeeBuilder(_view);
            _employModel.employee.LoadEmployeeButton(selectedEmployee);
        }
    }
}
