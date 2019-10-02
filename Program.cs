using System;

namespace C_Basics
{
    class Program
    {
        static void Main(string[] args)
        {       
            int num;
            Console.Write("input :");
            int.TryParse(Console.ReadLine(),out num); 
            int score;
            int count =1;
            switch(num)
            {
                    case 1:
                    Console.Write("input :");
                    int.TryParse(Console.ReadLine(),out score); 

                    while(count<=score)
                        {
                            Console.WriteLine("WTF " +count);
                            count++;
                        } break;
                    case 2:
                    for(int i=10;i>=0;i--)
                        {
                             Console.WriteLine("WTF = " +i);
                        }break;
                    case 3:
                        do
                        {
                            Console.Write("input :");
                            int.TryParse(Console.ReadLine(),out score);   


                        }while(score >0);break;


            }
          
             

          

             

                  
        }
    }
}
