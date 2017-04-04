using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProstKlass
{
    public class schetchik
    {
        private int maxVal;
        private int minVal;
        private int XVal;
        public schetchik(int minVal, int maxVal, int XVal)
        {
            this.maxVal = maxVal;
            this.minVal = minVal;
            this.XVal = XVal;
        }

        public int PlusValue()
        {
            XVal += 10;
            IFXm();
            return XVal;

        }

        public int MinusValue()
        {
            XVal -= 10;
            IFXm();
            return XVal;
        }

        public void IFXm()
        {
            if (XVal < minVal) Err();
            if (XVal > maxVal) Err();
        }

        public void Err()
        {
            Console.WriteLine("ОШИБКА!Выход за пределы заданног диапозона!");
        }
        

    }
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Введите мин. знач.");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите макс. знач.");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите текущее знач.");
            int z = Convert.ToInt32(Console.ReadLine());
            schetchik XV = new schetchik(x,y,z);
            Console.WriteLine("Чтобы увеличить текущее значение введите: +, а чтобы уменьшить введите: -");
            string s = Convert.ToString(Console.ReadLine());
            if (s == "+")
            {
                int a = XV.PlusValue();
                Console.WriteLine("Текущее состояние счетчика: {0}", a);
            }
            if (s == "-")
            {
                int b = XV.MinusValue();
                Console.WriteLine("Текущее состояние счетчика: {0}", b);
            }
            Console.ReadKey();
        }
    }
}
