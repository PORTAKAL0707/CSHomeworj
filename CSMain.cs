using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClass
{
    public class Math
    {
        public float pinum = 3.14f;
        public float diameter;
        public float result;
        public float twoTimesPinum = 9.85f;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Daire alani ---> 1\nKüre Alani --> 2");
            string secim = Console.ReadLine();
            if (secim == "1")
            {
                Console.WriteLine("Lutfen daire capini giriniz");
                math.diameter = Single.Parse(Console.ReadLine());
                float twoTimesDiameter = math.diameter * math.diameter;
                math.result = twoTimesDiameter * math.pinum;
                Console.WriteLine("Dairenizin alani --> " + math.result);
                Console.ReadKey();
            }
            else if (secim == "2")
            {
                Console.WriteLine("Lutfen kurenin capini giriniz");
                math.diameter = Single.Parse(Console.ReadLine());
                float twoTimeDiameter = math.diameter * math.diameter;
                math.result = 4 * math.pinum * twoTimeDiameter;
                Console.WriteLine("Kurenizin alani --> " + math.result);
                Console.ReadKey();
            }
        }

    }
}
