using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace ROCKPAPERSCISSORS
{
    class Program
    {



        static void Restart()
        {
            String[] n = new String[10];
            n[0] = "hi";
            Main(n);
        }




        static string calcHmac(string data)
        {

            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

            // Buffer storage.
            byte[] bra = new byte[16];
            // Ten iterations.
            rng.GetBytes(bra);
            string my_key = BitConverter.ToString(bra, 0);


            byte[] key = Encoding.ASCII.GetBytes(my_key);
                HMACSHA1 myhmacsha256 = new HMACSHA1(key);
                byte[] byteArray = Encoding.ASCII.GetBytes(data);
                System.IO.MemoryStream stream = new System.IO.MemoryStream(byteArray);
                string result = myhmacsha256.ComputeHash(stream).Aggregate("", (s, e) => s + String.Format("{0:x2}", e), s => s);
                //Console.WriteLine(result);
                return result;



    

        
        }

      

        static void Main(string[] args)
        {


          
               
           




            Console.Write("Введите строки: ");
            string input = Console.ReadLine();
            string[] share = input.Split(' ');
        
            string[] shufled = share.OrderBy(n => Guid.NewGuid()).ToArray();


            int count_s = share.Length;
            var uniqueItemsList = share.Distinct().ToList();
            int count_unic = uniqueItemsList.Count;
            if (count_s >= 3 && count_s% 2 == 1 && count_unic == count_s)
            {

           



                foreach (string s in shufled)
                {



                    


                    switch (s)
                    {
                     
                        case "A":
                          
                            string stepA = "PC select A";
                            // Console.WriteLine(calcHmac(stepA));
                          
                            string hmac = calcHmac(stepA);

                            Console.Write("Введите свою букву:");
                                string SelUs = Console.ReadLine();
                            if (SelUs == "A")
                            {
                               goto case "A";
                            }
                            if (SelUs == "B" | SelUs == "C" | SelUs == "D")
                                {
                                    Console.WriteLine("PC move: A "+ "USER MOVE: " + SelUs+" USER WIN");
                                }
                                if (SelUs == "E" | SelUs == "F" | SelUs == "G")
                                {
                                Console.WriteLine("PC move: A " + "USER MOVE: " + SelUs + " PC WIN");
                            }
                          
                            
                            break;

                           
                        case "B":
                            string stepB = "PC select B ";
                           Console.WriteLine(calcHmac(stepB));

                            Console.Write("Введите свою букву:");
                            string SelUsB = Console.ReadLine();
                            if (SelUsB == "B")
                            {
                                goto case "B";
                            }
                        

                            if (SelUsB == "A"  | SelUsB == "F" | SelUsB == "G")
                            {
                                Console.WriteLine("PC move: B " + "USER MOVE: " + SelUsB + " PC WIN");
                            }
                            if (SelUsB == "C" | SelUsB == "D" | SelUsB == "E")
                            {
                                Console.WriteLine("PC move: B " + "USER MOVE: " + SelUsB + " USER WIN");
                            }
                          
                            break;




                        case "C":


                            string stepC = "PC select C ";
                            Console.WriteLine(calcHmac(stepC));

                            Console.Write("Введите свою букву:");
                            string SelUsC = Console.ReadLine();

                            if (SelUsC == "C")
                            {
                                goto case "C";
                            }


                            if (SelUsC == "B" | SelUsC == "A" | SelUsC == "G")
                            {
                                Console.WriteLine("PC move: C " + "USER MOVE: " + SelUsC + " PC WIN");
                            }
                            if (SelUsC == "D" | SelUsC == "E" | SelUsC == "F")
                            {
                                Console.WriteLine("PC move: C " + "USER MOVE: " + SelUsC + " USER WIN");
                            }
                          
                            break;

                        case "D":


                            string stepD = "PC select D";
                            Console.WriteLine(calcHmac(stepD));

                            Console.Write("Введите свою букву:");
                            string SelUsD = Console.ReadLine();

                            if (SelUsD == "D")
                            {
                                goto case "D";
                            }


                            if (SelUsD == "C" | SelUsD == "B" | SelUsD == "A")
                            {
                                Console.WriteLine("PC move: D " + "USER MOVE: " + SelUsD + " PC WIN");
                            }
                            if (SelUsD == "E" | SelUsD == "F" | SelUsD == "G")
                            {
                                Console.WriteLine("PC move: D " + "USER MOVE: " + SelUsD + " USER WIN");
                            }
                           
                            break;



                        case "E":


                            string stepE = "PC select E";
                            Console.WriteLine(calcHmac(stepE));

                            Console.Write("Введите свою букву:");
                            string SelUsE = Console.ReadLine();

                            if (SelUsE == "E")
                            {
                                goto case "E";
                            }


                            if (SelUsE == "B" | SelUsE == "C" | SelUsE == "D")
                            {
                                Console.WriteLine("PC move: E " + "USER MOVE: " + SelUsE + " PC WIN");
                            }
                            if (SelUsE == "F" | SelUsE == "G" | SelUsE == "A")
                            {
                                Console.WriteLine("PC move: E " + "USER MOVE: " + SelUsE + " USER WIN");
                            }
                            
                            break;



                        case "F":


                            string stepF = "PC select F";
                            Console.WriteLine(calcHmac(stepF));

                            Console.Write("Введите свою букву:");
                            string SelUsF = Console.ReadLine();

                            if (SelUsF == "F")
                            {
                                goto case "F";
                            }

                            if (SelUsF == "C" | SelUsF == "D" | SelUsF == "E")
                            {
                                Console.WriteLine("PC move: F " + "USER MOVE: " + SelUsF + " PC WIN");
                            }
                            if (SelUsF == "G" | SelUsF == "A" | SelUsF == "B")
                            {
                                Console.WriteLine("PC move: F " + "USER MOVE: " + SelUsF + " USER WIN");
                            }
                            
                            break;


                        case "G":


                            string stepG = "PC select G";
                            Console.WriteLine(calcHmac(stepG));

                            Console.Write("Введите свою букву:");
                            string SelUsG = Console.ReadLine();

                            if (SelUsG == "G")
                            {
                                goto case "G";
                            }


                            if (SelUsG == "D" | SelUsG == "E" | SelUsG == "F")
                            {
                                Console.WriteLine("PC move: G " + "USER MOVE: " + SelUsG + " PC WIN");
                            }
                            if (SelUsG == "A" | SelUsG == "B" | SelUsG == "C")
                            {
                                Console.WriteLine("PC move: G " + "USER MOVE: " + SelUsG + " USER WIN");
                            }
                            
                            break;







                    }






                }



            }
             else
            {
                Console.WriteLine("Ошибка");
                Restart();

            }

            //Console.WriteLine("Вы выбрали" + Console.ReadLine());

            //Console.WriteLine(share[0]);





        }
    }
}