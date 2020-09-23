using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BubbleSort
{
    class Bubble
    {

        private int[] nums; 
        public void Inicio() 
        {
            String num; 

            Console.Write("Cuantos números desea ordenar???");

            int Num;
            Num = Convert.ToInt32(Console.ReadLine());

            nums = new int[Num]; 

            for (int i = 0; i < Num; i++) 
            {
                Console.Write("Inserte un número");
                num = Console.ReadLine();
                nums[i] = int.Parse(num);  
            }
        }

       public void MetBubble() 
        {
            int a;
            for (int j = 1; j < nums.Length; j++) 

                for (int k = nums.Length - 1; k >= j; k--)
                {
                    if (nums[k - 1] > nums[k])
                    {
                        a = nums[k - 1];
                        nums[k - 1] = nums[k];
                        nums[k] = a;
                    }
                }
        }

        public void Imprimir() 
        {
            Console.WriteLine("Metodo Burbuja:");
            for (int f = 0; f< nums.Length; f++)
            {
                Console.Write(nums[f]+"  ");
            }
        }

        static void Main(string[] args)
        {
            Bubble metodoBurbuja = new Bubble();
            metodoBurbuja.Inicio();
            metodoBurbuja.MetBubble();
            metodoBurbuja.Imprimir();
        }
    }
}