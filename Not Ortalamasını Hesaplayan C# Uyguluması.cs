using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Not_Ortalaması_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            double not1, not2, not3, ortalama;
            Console.Write("1. Notu Giriniz :");
            not1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Notu Giriniz :");
            not2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. Notu Giriniz :");
            not3 = Convert.ToInt32(Console.ReadLine());
            ortalama = (not1 + not2 + not3) / 3;
            Console.WriteLine("1. Notunuz :{0}  2. Notunuz :{1}  3. Notunuz :{2}  Ve Ortalamanız :{3}", not1, not2, not3, ortalama);
            if (ortalama < 50)
            {
                Console.Write("KALDINIZ");
            }
            else
            { 
                Console.Write("GEÇTİNİZ");
            }
            Console.ReadKey();

               
                
                
                    
	
                            
                    


                }

            }
        }
    

