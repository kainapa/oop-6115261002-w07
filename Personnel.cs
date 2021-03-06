﻿using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261002_e07
{
    class Personnel : Person
    {
        private double performanceLevel;

        public double PerformanceLevel { get => performanceLevel; set => performanceLevel = value; }
        public Personnel(string name, string lastname, int salary, int workedYear, int intentYearlyActivity, double assessFromAdmin, double performanceLevel)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Salary = salary;
            this.WorkedYear = workedYear;
            this.IntentYearlyActivity = intentYearlyActivity;
            this.AssessedFromAdmin = assessFromAdmin;
            this.PerformanceLevel = performanceLevel;
        }
        public double calculateSalaryRaise()
        {
            double score = this.IntentYearlyActivity + this.AssessedFromAdmin + this.PerformanceLevel;
            double salaryRaise = 0;

            if (score < 70)
            {
                return 0;
            }
            else if (score <= 80)
            {
                salaryRaise = Salary * 0.01;
            }
            else if (score <= 85)
            {
                salaryRaise = Salary * 0.015;
            }
            else if (score <= 90)
            {
                salaryRaise = Salary * 0.02;
            }
            else if (score <= 95)
            {
                salaryRaise = Salary * 0.025;
            }
            else if (score > 95)
            {
                salaryRaise = Salary * 0.03;
            }
            return salaryRaise;
        }

        public override string ToString()
        {
            return base.ToString() + "Salary Raise :" + this.calculateSalaryRaise();
        }
    }
}
