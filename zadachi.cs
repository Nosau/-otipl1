2.3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your word or any sumbol: ");
            string s = Console.ReadLine(), ss = "";
            char a, b;

            Console.WriteLine("Type the letter you want to replace");

            a = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Replace by which letter?");
            b = Convert.ToChar(Console.ReadLine());
            int c = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] == 'a')
                {
                    ss += "b";
                    ++c;
                    continue;
                }
                ss += s[i];
            }
            Console.WriteLine(ss);
            Console.WriteLine(c);
        }
    }
}


/*какую букву поменять, на какую букву поменять*/

2.4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, s2 = 2;
            while (true)
            { 

            Console.WriteLine("for {0}: left side = {1}, right side = {2}", x, (x * x + 500 * x + 1000), s2);

                if (x * x + 500 * x + 1000 < s2)

                {
                   
                    break;
                }

                ++x;
                s2 *= 2;

            }
        }
    }
}


/*n = 12 правая часть, левая часть.
3 переменной , х = , n =   к*/


2.5
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
  class Program
  {
    static void Main(string[] args)
    {
        float i = 1;
        float a, sum = 0;
        a = Convert.ToSingle(Console.ReadLine());
        while(true) 
        {
            float k = (1 / i);
            sum += k;
            if(sum > a)
                break;
              ++i;
        }
        Console.WriteLine(i);
    }
  }
}




2.6
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Type any number");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while(a != 0)
            {
                sum += a%10;
                a /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}

2.7
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a sentence");
            string s = Console.ReadLine();
            int L = 0;
            for (int R = 0; R < s.Length; ++R)
            {
                if (s[R] == ' ' || R == s.Length -1)
                {
                    string ss = s.Substring(L, R - L + 1);
                    while (s[R] == ' ' && R != s.Length - 1)
                    ++R;
                    L = R;
                    Console.WriteLine(ss);

                }
            }
        }
    }
}



2.8

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
  class Program
  {
    static void Main(string[] args)
    {
      int a, min, max;
      a = Convert.ToInt32(Console.ReadLine());
      max = a;
      min = a;
      while(true)
      {
          a = Convert.ToInt32(Console.ReadLine());
          if(a == 0)
              break;
          if(a > max)
              max = a;;
          if(min > a)
              min = a;
          Console.Write(min + " ");
          Console.WriteLine(max);
      }
    }
  }
}


2.9
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
  class Program
  {
    static void Main(string[] args)
    {
      int a, plus = 0, minus = 0;
      while(true)
      {
          a = Convert.ToInt32(Console.ReadLine());
          if(a == 0)
              break;
          if(a > 0)
              ++plus;
          if(a < 0)
              ++minus;
          if(plus > minus)
              Console.WriteLine("Positive");
          if(plus < minus)
              Console.WriteLine("Negative");
          if(plus == minus)          
              Console.WriteLine("Equally");
      }
    }
  }
}
2.10
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {

            int age = Convert.ToInt32(Console.ReadLine());
            if (age % 10 == 1 && age% 100!= 11)
                Console.WriteLine("Вам {0} год",age);
            else if (age % 10 < 5 && (age%100 > 20 || age < 9) && age % 10 != 0)
                Console.WriteLine("Вам {0} годa", age);
            else 
                Console.WriteLine("Вам {0} лет", age);


        }
    }
} 

3.1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[10];
            for (int i = 0; i < 10; ++i)
                mas[i] = Convert.ToInt32(Console.ReadLine());
            for (int i = 9; i >= 0; --i)
                Console.Write(mas[i] + " ");
        }
    }
}


3.2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string n, k;
            n = Console.ReadLine();
            k = Console.ReadLine();

            string[] s = n.Split(' ');
            string[] ss = k.Split(' ');

            for (int i = 0; i < s.Length; ++i)
                for (int j = 0; j <ss.Length; ++j)


                    Console.WriteLine(ss[i] + " " + s[j]);
        }
    }
} 


3.3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
  class Program
  {
    static void Main(string[] args)
    {
        const int SZ = 'z' - 'a' + 1;
        //int n = Convert.ToInt32(Console.ReadLine());
        int [] mas = new int[SZ];
        string s = Console.ReadLine();
        for(int i = 0; i < SZ; ++i)
            mas[i] = 0;
        s = s.ToLower();
        for(int i = 0; i < s.Length; ++i)
        {
            if(s[i] <= 'z' && s[i] >= 'a')
                ++mas[s[i] - 'a'];
        }
        for(int i = 0; i < SZ; ++i) 
        {
            char a;
            a = Convert.ToChar('a' + i);
            Console.WriteLine(a + ":" + mas[i]);
        }
    }
  }
}

3.4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
  class Program
  {
    static void Main(string[] args)
    {
        int n, k;
        n = Convert.ToInt32(Console.ReadLine());
        k = Convert.ToInt32(Console.ReadLine());
        int[,] mas = new int[n, k];
        string s;
        for(int i = 0; i < n; ++i)
            for(int j = 0; j < k; ++j)
                  mas[i, j] = Convert.ToInt32(Console.ReadLine());
     /*         int j = 0;
            s = Console.ReadLine();
            int L = 0;
            string ss;
              for(int R = 0; R < s.Length; ++R)
              {
     
                 if((s[R] == ' ') || (R == s.Length - 1))
                 {
                     ss = s.Substring(L, R - L);
                     mas[i, j] = Convert.ToInt32(ss);
                     L = R;
                     ++j;
                 }
              }
     */
        for(int j = 0; j < k; ++j)
        {
            for(int i = 0; i < n; ++i)
            {
                Console.Write(mas[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
  }
}

3.5
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
  class Program
  {
    static void Main(string[] args)
    {
        int n;
        string k;
        n = Convert.ToInt32(Console.ReadLine());
        string[][] mas = new string[n][];
        for(int i = 0; i < n; ++i) 
        {
                  k = Console.ReadLine();
                  mas[i] = k.Split(' ');
        }
        Console.WriteLine("sum of elements of each line:");
        for(int i = 0; i < n; ++i)
        {
            int sum = 0;
            for(int j = 0; j < mas[0].Length; ++j)
                sum += Convert.ToInt32(mas[i][j]);
            Console.WriteLine(i + ":" + sum);
        }
        Console.WriteLine("sum of elements of each column:");
        for(int j = 0; j < mas[0].Length; ++j)
        {
            int sum = 0;
            for(int i = 0; i < n; ++i) 
                sum += Convert.ToInt32(mas[i][j]);
            Console.WriteLine(j + ":" + sum);
        }
        Console.WriteLine("sum of all elements:");
        int s = 0;
        for(int i = 0; i < n; ++i)
            for(int j = 0; j < mas[0].Length; ++j) 
                s += Convert.ToInt32(mas[i][j]);
        Console.WriteLine(s);
    }
  }
}

Пишу сколько у нас будет строк, а потом  массив. Пример:
4
1 2 3 
2 3 4
4 3 2
2 2 0
    
    
3.6     ввод по одному

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
  class Program
  {
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] mas = new int[n];
        for(int i = 0; i < n; ++i)
            mas[i] = Convert.ToInt32(Console.ReadLine());
       
        for(int i = 1; i < n; ++i)
            {
              for(int r = 0; r < n-i; r++)
              {
                if(mas[r] < mas[r+1])
                {
                  int t = mas[r];
                     mas[r] = mas[r+1];
                  mas[r+1] = t;
                }
              }
            }
        for(int i = 0; i < n; ++i)
            Console.Write(mas[i] + " ");
    }
  }
}

3.7  вводить и потом не ставить пробел в конце!
    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            text = Console.ReadLine();
            string[] arr = text.Split(' ');
            int n = arr.Length;
            int c = 0;
            for (int i = 0; i < n; ++i)
                if (Convert.ToInt32(arr[i]) == 0)
                    ++c;
            Console.WriteLine(c);
            int[] mas = new int[c];
            int pos = 0;
            for (int i = 0; i < n; ++i)
                if (Convert.ToInt32(arr[i]) == 0)
                {
                    mas[pos] = i;
                    ++pos;
                }
            for (int i = 0; i < c; ++i)
                Console.Write(mas[i] + " ");
            Console.WriteLine();

            int[] sum = new int[c - 1];
            int m = 0;
            pos = 0;
            for (int i = Convert.ToInt32(mas[0] + 1); i <= Convert.ToInt32(mas[c - 1]); ++i)
            {
                if (Convert.ToInt32(arr[i]) == 0)
                {
                    sum[pos] = m;
                    m = 0;
                    ++pos;
                    continue;
                }
                m += Convert.ToInt32(arr[i]);
            }
            for (int i = 0; i < c - 1; ++i)
                Console.Write(sum[i] + " ");
        }
    }
}







3.8  сначала то, сколько ввожу (например 5, 4) потом по одной вниз массивы


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
  class Program
  {
    static void Main(string[] args)
    {
       int n, k;
       n = Convert.ToInt32(Console.ReadLine());
       k = Convert.ToInt32(Console.ReadLine());
       int[] arr = new int[n];
       for(int i = 0; i < n; ++i)
             arr[i] = Convert.ToInt32(Console.ReadLine());
       int[] mas = new int[k];
       for(int i = 0; i < k; ++i)
             mas[i] = Convert.ToInt32(Console.ReadLine());
         int[] s = new int[n + k];
         for(int i = 0; i < n; ++i)
             s[i] = arr[i];
         for(int i = n; i < n + k; ++i)
             s[i] = mas[i - n];
         for(int i = 0; i < n + k; ++i)
              Console.Write(s[i] + " ");
    }
  }
}




