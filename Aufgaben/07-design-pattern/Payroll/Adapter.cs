using Payroll.ThirdParty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    public class Adapter : Employable, IAccountHolder
    {
        private Employable employee;

        public Adapter(Employable employee) { 
        this.employee = employee;
        }
        public void AddNote(string type, string note)
        {
            employee.AddNote(type, note);
        }

        public string GetFullName()
        {
        return   employee.GetFullName();
        }

        public string GetNote(string type)
        {
          return employee.GetNote(type);
        }

        public float GetSalary()
        {
          return employee.GetSalary();
        }

    
        string IAccountHolder.GetAccountDetails()
        {
            return employee.GetFullName + "\n" + employee.GetSalary + "\n";
        }
    }
}
