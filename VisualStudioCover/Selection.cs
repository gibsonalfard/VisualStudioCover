using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudioCover
{
    public class Selection
    {
        public int select1(int x, int y)
        {
            double result;
            if (x > y)
            {
                x += 2;
            }

            result = (x - y) + (Math.Pow(y, 2));

            return (int)result;
        }

        public double select2(int x, int y)
        {
            int res = 0;
            if (x > y)
            {
                res += x % 2;
            }
            else
            {
                res = (int)Math.Pow(x, 2);
            }

            return res;
        }

        public double select3(int x, int y, int opr)
        {
            var result = 0;
            switch (opr)
            {
                case 1: result = x + y; break;
                case 2: result = x - y; break;
                case 3: result = x * y; break;
                case 4: result = x / y; break;
                default: result = x; break;
            }

            return result;
        }

        public int select4(int x, int saldo, int limit)
        {
            if (saldo > x)
            {
                if (limit > x)
                {
                    return saldo - x;
                }
            }
            return -1;
        }

        public bool select5(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        public int select6(int x, int saldo, int limit)
        {
            if (saldo < x)
            {
                return -1;
            }
            else
            {
                if (limit > x)
                {
                    return saldo - x;
                }
            }
            return limit;
        }

        public int select7(int x, int saldo, int limit)
        {
            var limUtang = 25;

            if (saldo > x)
            {
                if (limit - x >= 0)
                {
                    return saldo - x;
                }
            }
            else
            {
                if (Math.Abs(saldo - x) < limUtang)
                {
                    return limUtang;
                }
            }
            return -1;
        }

        public double select8(int amount)
        {
            double tax = 0;
            double tmpAmount = amount;
            if (amount >= 1000)
            {
                if (amount >= 2000)
                {
                    tax = (7.5 / 100) * tmpAmount;
                    tmpAmount -= tax;
                }
                tax += (5 / 100) * tmpAmount;
            }
            else
            {
                if (amount > 500)
                {
                    tax = (2.5 / 100) * tmpAmount;
                }
                else
                {
                    tax = (1 / 100) * tmpAmount;
                }
            }

            return tax;
        }

        public double select9(int amount)
        {
            double tax = 0;
            double tmpAmount = amount;
            if (amount < 1000)
            {
                if (amount > 500)
                {
                    tax = (2.5 / 100) * tmpAmount;
                }
                else
                {
                    tax = (1 / 100) * tmpAmount;
                }
            }
            else
            {
                if (amount >= 2000)
                {
                    tax = (7.5 / 100) * tmpAmount;
                    tmpAmount -= tax;
                }
                tax += (5 / 100) * tmpAmount;
            }

            return tax;
        }

        public int select10(int opsi, int amount, int saldo)
        {
            if (opsi != 6)
            {
                if (saldo > 120)
                {
                    return saldo - 20;
                }
                else
                {
                    return -2;
                }
            }
            else
            {
                if (amount % 20 == 0)
                {
                    return saldo - amount;
                }
                else
                {
                    return -1;
                }
            }
        }

        public int select11(int x, int y, int opsi)
        {
            int result = 0;
            if (opsi > 0)
            {
                switch (opsi)
                {
                    case 1: result = x + y; break;
                    case 2: result = x - y; break;
                    case 3: result = x * y; break;
                    case 4: result = x / y; break;
                    default: result = -1; break;
                }
            }
            return result;
        }

        public String select12(int auth, int menu)
        {
            if (auth == 1)
            {
                switch (menu)
                {
                    case 1: return "This is Your Balance : $1000"; break;
                    case 2: return "Withdrawal menu"; break;
                    case 3: return "Transfer Menu"; break;
                    default: return "Menu not found"; break;
                }
            }
            else
            {
                switch (menu)
                {
                    case 1: return "Admin menu : Change User Password"; break;
                    case 2: return "Admin menu : Show monthly report"; break;
                    default: return "Admin menu : Menu not found"; break;
                }
            }
        }

        public bool select13(int month, int year, int day)
        {
            bool valid = true;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (day > 31)
                    {
                        valid = false;
                    }
                    break;
                case 2:
                    if (day > 28)
                    {
                        valid = false;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (day > 30)
                    {
                        valid = false;
                    }
                    break;
                default:
                    valid = false;
                    break;
            }
            return valid;
        }

        public bool select14(int month, int year, int day)
        {
            bool leap = this.select5(year);
            bool valid = false;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (day >= 31)
                    {
                        valid = false;
                    }
                    else
                    {
                        valid = true;
                    }
                    break;
                case 2:
                    if (leap)
                    {
                        valid = day <= 29;
                    }
                    else
                    {
                        valid = day <= 28;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (day >= 30)
                    {
                        valid = false;
                    }
                    else
                    {
                        valid = true;
                    }
                    break;
                default:
                    valid = false;
                    break;
            }

            return valid;
        }

        public String select15(int number)
        {
            var mod = number % 2;
            var text = "";
            switch (mod)
            {
                case 0:
                    if (number > 0)
                    {
                        text = text + "Bilangan Genap Positif, ";
                    }
                    if (number > 7)
                    {
                        text = text + "Bilangan lebih besar dari 7";
                    }
                    else
                    {
                        text = text + "Bilangan kecil dari 7";
                    }
                    break;
                case 1:
                    if (number > 0)
                    {
                        text = text + "Bilangan Ganjil Positif, ";
                    }
                    if (number > 7)
                    {
                        text = text + "Bilangan lebih besar dari 7";
                    }
                    else
                    {
                        text = text + "Bilangan kecil dari 7";
                    }
                    break;
            }

            return text;
        }

        public String select16(int ops1, int ops2)
        {
            String text = "";

            switch (ops1)
            {
                case 1:
                    switch (ops2)
                    {
                        case 1:
                            text = "Melihat saldo";
                            break;
                        default:
                            text = "Menu Saldo : Masukan Invalid";
                            break;
                    }
                    break;
                case 2:
                    switch (ops2)
                    {
                        case 1:
                            text = "Menu Withdraw $20";
                            break;
                        case 2:
                            text = "Menu Withdraw $40";
                            break;
                        case 3:
                            text = "Nominal Withdraw lainnya";
                            break;
                        default:
                            text = "Menu Withdraw : Masukan Invalid";
                            break;
                    }
                    break;
                default:
                    text = "Keluar";
                    break;
            }

            return text;
        }
    }
}
