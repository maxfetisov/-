using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Pension
    {
        decimal coefficientPrice = 93.00M;
        decimal minimum = 5686.25M;
        string gender;
        uint year;
        uint warDays;
        uint chAmount;
        uint stash;
        decimal money;
        public Pension() {
            gender = "Мужской";
            year = 1900;
            warDays = 0;
            chAmount = 0;
            stash = 0;
            money = 12130.00M;
        }
        public Pension(string gender, uint year, uint warDays, uint chAmount, uint stash, decimal money) {
            this.gender = gender;
            this.year = year;
            this.warDays = warDays;
            this.chAmount = chAmount;
            this.stash = stash;
            this.money = money;
        }
        public decimal GetCoefficient()
        {
            decimal coefficient = 0.00M;
            coefficient += (decimal)1.8 / 365 * warDays;
            switch (chAmount)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {
                        coefficient += 1.8M;
                        break;
                    }
                case 2:
                    {
                        coefficient += 5.4M;
                        break;
                    }
                case 3:
                    {
                        coefficient += 10.8M;
                        break;
                    }
                default:
                    {
                        coefficient += 16.2M;
                        break;
                    }
            }
            coefficient += stash * (money * 12M * 0.16M / 206500 * 10);
            if (gender == "Мужской" && stash >= 35) { coefficient += stash - 34; }
            if (gender == "Женский" && stash >= 30) { coefficient += stash - 29; }
            return decimal.Round(coefficient, 2);
        }
        public decimal GetPension() => decimal.Round(GetCoefficient() * coefficientPrice + minimum, 2);
        public bool IsValid()
        {
            if (2020 - (int)year - 14 < (int)stash) return false;
            if (gender != "Мужской" && gender != "Женский") return false;
            if (money < 12130) return false;
            return true;
        }
    }
}
