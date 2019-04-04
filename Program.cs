using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulConsoleApp
{
    class Program

    {
        delegate void coreClassForAnonymous();
        delegate void nameIsDelegate(string s);

        static void MethodIntia(string s)
        {
            Console.WriteLine(s);
        }
        static oprtionMethod oprObject = new oprtionMethod();

        static void Main(string[] args)
        {

            //// Basic Syntix of delegate //Anonymous
            nameIsDelegate firstDel = new nameIsDelegate(MethodIntia);

            firstDel("Hello. My name is MethodIntia and " +
                "I'm initialization with Basic Syntix of delegate and Anonymous.");

            ////Anonymous
            coreClassForAnonymous secondDel = delegate () {

           Console.WriteLine("Hi I'm Anonymous Method ");

            };
            ////lambda ///Anonymous
            coreClassForAnonymous thirdDel = () => { Console.WriteLine("Hi, I'm lambda" +
                " expression (Anonymous) "); };

            secondDel();
            thirdDel();


            Class2 obInterFaceRemainder = new Class2();

            int caseSwitch;

            Console.WriteLine("Enter number for make math opertion"+
                "\n 1-Sumation\n2-substriction\n 3-dividedby" +
                " \n 4-multipuction\n 5-rest of div");

            caseSwitch = int.Parse(Console.ReadLine());
            Console.WriteLine("enter two number");


            int x, y; x = 0; y = 0;
  
            if (caseSwitch !=3 && caseSwitch !=5) {
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            } 


            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("the sumation its : " + oprObject.sum(x, y));
                    break;
                case 2:
                    Console.WriteLine("the sumation its : " + oprObject.sub(x, y));
                    break;
                case 3:
                    Double m, n;
                    m = Double.Parse(Console.ReadLine());
                    n = Double.Parse(Console.ReadLine()); 
                    
                         Double thisMethode = oprObject.div(m, n);
                         Console.WriteLine("the sumation its : " + thisMethode);
                       
                   
                    break;
                case 4:
                    Console.WriteLine("the sumation its : " + oprObject.mult(x, y));
                    break;
                case 5:
                    float z, w;
                    z = float.Parse(Console.ReadLine());
                    w = float.Parse(Console.ReadLine());
                    Console.WriteLine("the rest of dividedby its : " + obInterFaceRemainder.per(z,w));
                    break;

            }


            Console.ReadKey();

        }
    }
}
