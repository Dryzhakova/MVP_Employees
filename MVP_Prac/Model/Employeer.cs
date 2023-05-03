using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Prac.Model
{
    class Employeer
    {
       private EmployeeBuilder employeer;
        public EmployeeBuilder employee { get => employeer; set => employeer = value; }
    }
}
