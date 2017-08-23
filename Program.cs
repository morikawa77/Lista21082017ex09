using System;

namespace Lista21082017ex09
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int valor1, valor2;
            Console.WriteLine("Digite o valor 1: ");
            valor1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Digite o valor 2: ");
			valor2 = Convert.ToInt32(Console.ReadLine());
            if (valor1 != valor2){
                if(valor1 < valor2){
                    Console.WriteLine("{0}\n{1}", valor1, valor2);
					Console.ReadKey();
                }else{
					Console.WriteLine("{1}\n{0}", valor1, valor2);
					Console.ReadKey();
                }
            }else{
                Console.WriteLine("Os valores são iguais.");
                Console.ReadKey();
            }
        }
    }
}
