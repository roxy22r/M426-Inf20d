using System;
using Payroll.ThirdParty;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployable johnDoe = new Employee("John", "Doe", 120000);
            IEmployable jayneDone = new Employee("Jane", "Done", 125000);
            Console.WriteLine(johnDoe.GetFullName());
            Console.WriteLine(jayneDone.GetFullName());

            johnDoe.AddNote("AccountDetails", "ABC-123");
            johnDoe.AddNote("Position", "Lead Engineer");
            jayneDone.AddNote("AccountDetails", "XYZ-789");
            johnDoe.AddNote("Position", "Head of HR");

            var johnDoeAccount = new AccountHolderAdapter(johnDoe);
            var jayneDoneAccount = new AccountHolderAdapter(jayneDone);

            Banking.PayOut(johnDoeAccount, johnDoe.GetSalary() / 12);
            Banking.PayOut(jayneDoneAccount, jayneDone.GetSalary() / 12);
        }
    }
}
