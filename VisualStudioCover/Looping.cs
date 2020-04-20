using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudioCover
{
    public class Looping
    {
        public int loop1(int start, int end, int interval)
        {
            int i;
            int total = 0;
            for (i = start; i <= end; i += interval)
            {
                total += i;
            }

            return total;
        }

        public int loop2(int start, int end, int interval)
        {
            int i = start;
            int total = 0;
            while (i <= end)
            {
                total += i;
                i += interval;
            }

            return total;
        }

        public int loop3(int start, int end, int interval)
        {
            int i = start;
            int total = 0;
            do
            {
                total += i;
                i += interval;
            } while (i <= end);

            return total;
        }

        public int loop4(String text)
        {
            int len = text.Length;
            int i = 0;
            int count = 0;
            text = text.ToLower();
            for (i = 0; i < len; i++)
            {
                if (text[i] == 'a')
                {
                    count += 1;
                }
            }

            return count;
        }

        public int loop5(String text)
        {
            int len = text.Length;
            int i = 0;
            int count = 0;
            text = text.ToLower();
            while (i < len)
            {
                if (text[i] == 'a')
                {
                    count += 1;
                }
            }

            return count;
        }

        public int loop6(String text)
        {
            int len = text.Length;
            int i = 0;
            int count = 0;
            text = text.ToLower();
            do
            {
                if (text[i] == 'a')
                {
                    count += 1;
                }
            } while (i < len);

            return count;
        }

        public int loop7(String text)
        {
            int len = text.Length;
            int i = 0;
            int stack = 0;
            text = text.ToLower();
            for (i = 0; i < len; i++)
            {
                if (text[i] == '(')
                {
                    stack += 1;
                }
                else
                {
                    stack -= 1;
                }
            }

            // Return 0 kalau '(' dan ')' jumlahnya sama
            return stack;
        }

        public int loop8(String text)
        {
            int len = text.Length;
            int i = 0;
            int stack = 0;
            text = text.ToLower();
            while (i < len)
            {
                if (text[i] == '(')
                {
                    stack += 1;
                }
                else
                {
                    stack -= 1;
                }
            }

            // Return 0 kalau '(' dan ')' jumlahnya sama
            return stack;
        }

        public int loop9(String text)
        {
            int len = text.Length;
            int i = 0;
            int stack = 0;
            text = text.ToLower();
            do
            {
                if (text[i] == '(')
                {
                    stack += 1;
                }
                else
                {
                    stack -= 1;
                }
            } while (i < len);

            // Return 0 kalau '(' dan ')' jumlahnya sama
            return stack;
        }

        public int loop10(String text)
        {
            int len = text.Length;
            int i = 0;
            int hole = 0;
            text = text.ToUpper();

            for (i = 0; i < len; i++)
            {
                switch (text[i])
                {
                    case 'A':
                    case 'D':
                    case 'O':
                    case 'P':
                    case 'Q':
                    case 'R':
                        hole += 1;
                        break;
                    case 'B':
                        hole += 2;
                        break;
                }
            }

            return hole;
        }

        public int loop11(String text)
        {
            int len = text.Length;
            int i = 0;
            int hole = 0;
            text = text.ToUpper();

            while (i < len)
            {
                switch (text[i])
                {
                    case 'A':
                    case 'D':
                    case 'O':
                    case 'P':
                    case 'Q':
                    case 'R':
                        hole += 1;
                        break;
                    case 'B':
                        hole += 2;
                        break;
                }
            }

            return hole;
        }

        public int loop12(String text)
        {
            int len = text.Length;
            int i = 0;
            int hole = 0;
            text = text.ToUpper();

            do
            {
                switch (text[i])
                {
                    case 'A':
                    case 'D':
                    case 'O':
                    case 'P':
                    case 'Q':
                    case 'R':
                        hole += 1;
                        break;
                    case 'B':
                        hole += 2;
                        break;
                }
            } while (i < len);

            return hole;
        }

        public String loop13(int len1, int len2)
        {
            int i = 0;
            int j = 0;
            String str = "";
            for (i = 0; i < len1; i++)
            {
                str = str + "(";
                for (j = 0; j < len2; j++)
                {
                    str = str + "+";
                }
                str = str + ")";
            }

            return str;
        }

        public String loop14(int len1, int len2)
        {
            int i = 0;
            int j = 0;
            String str = "";
            while (i < len1)
            {
                str = str + "(";
                for (j = 0; j < len2; j++)
                {
                    str = str + "+";
                }
                str = str + ")";
            }

            return str;
        }

        public String loop15(int len1, int len2)
        {
            int i = 0;
            int j = 0;
            String str = "";
            do
            {
                str = str + "(";
                for (j = 0; j < len2; j++)
                {
                    str = str + "+";
                }
                str = str + ")";
            } while (i < len1);

            return str;
        }

        public String loop16(int len1, int len2)
        {
            int i = 0;
            int j = 0;
            String str = "";
            for (i = 0; i < len1; i++)
            {
                str = str + "(";
                j = 0;
                while (j < len2)
                {
                    str = str + "+";
                    j += 1;
                }
                str = str + ")";
            }
            return str;
        }
    }
}
