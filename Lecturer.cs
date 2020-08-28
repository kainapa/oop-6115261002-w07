using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261002_e07
{
    class Lecturer : Person

    {
        private double academicWork;
        private double numberOfAcademic;
        private double numberOfResearches;
        
        public double AcademicWork { get => academicWork; set => academicWork = value; }
        public double NumberOfAcademic { get => numberOfAcademic; set => numberOfAcademic = value; }
        public double NumberOfResearches { get => numberOfResearches; set => numberOfResearches = value; }
        public Lecturer(string name, string lastname, int salary, int workedYear, int intentYearlyActivity, double assessFromAdmin,double academicWork, double numberOfAcademic, double numberOfResearches)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Salary = salary;
            this.WorkedYear = workedYear;
            this.IntentYearlyActivity = intentYearlyActivity;
            this.AssessedFromAdmin = assessFromAdmin;
            this.AcademicWork = academicWork;
            this.NumberOfAcademic = numberOfAcademic;
            this.NumberOfResearches = numberOfResearches;
        }
        public double calculateSalaryRaise()
        {
            double score = this.IntentYearlyActivity + this.AssessedFromAdmin + this.AcademicWork + this.NumberOfAcademic + this.NumberOfResearches;
            double salaryRaise = 0;

            if (score <70)
            {
                return 0;
            }
            else if (score <= 80)
            {
                salaryRaise = Salary * 0.01;
            }
            else if (score <= 85)
            {
                salaryRaise = Salary * 0.02;
            }
            else if (score <= 90)
            {
                salaryRaise = Salary * 0.025;
            }
            else if (score > 90)
            {
                salaryRaise = Salary * 0.03;
            }
            return salaryRaise;
        }

        public override string ToString()
        {
            return base.ToString() + "Salary Raise :"+ this.calculateSalaryRaise();
        }
    }
}
