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


        static void Main(string[] args)
        {

           
            int ncs = 0;
            var uniqueItemsList = args.Distinct().ToList();
            if (args.Length >= 3 & args.Length % 2 != 0)
            {
                for (int c = 1; c < args.Length; c++)
                {
                    if (uniqueItemsList.Count != args.Length)
                    {
                        Console.WriteLine("Arguments not unique");
                        Environment.Exit(0);
                    }
                  
                }
            }
            else
            {
                Console.WriteLine("Error");
                Environment.Exit(0);
            }
            RNGCryptoServiceProvider csp = new RNGCryptoServiceProvider();
              byte[] bra = new byte[16];
              csp.GetBytes(bra);
              string my_key = BitConverter.ToString(bra).Replace("-", string.Empty).ToLower();
              int op = 1;
              int length = args.Length;
              int saq = length / 2;
              Random randooms = new Random();
              int value = randooms.Next(1, args.Length + 1);
              byte[] bkey = Encoding.Default.GetBytes(my_key);
              var pc_hmac = new HMACSHA1(bkey);
              byte[] getbytes = Encoding.Default.GetBytes(args[value-1]);
              var hashpc = pc_hmac.ComputeHash(getbytes);
              Console.WriteLine("HMAC "+ BitConverter.ToString(hashpc).Replace("-", string.Empty).ToLower());
              Console.WriteLine("0" + " - " + "Exit");
              foreach (var s in args)
              {
                Console.WriteLine(op + " - " + s.ToString());
                op++;
              }
              Console.WriteLine("Select one arg");
              ncs = Convert.ToInt32(Console.ReadLine());
              if (ncs == 0)
              {
                Environment.Exit(0);
                Console.WriteLine("THE END");
              }
              int ce = ncs;
              int eqy = value;
              int ute = ncs;
              int kd = value;
              for (int i = 0; i <= saq; i++)
              {
                if (ce == eqy & i == 0)
                {
                    break;
                }
                else
                if (ce == eqy)
                {
                    Console.WriteLine("PC WIN");
                    i = saq + 1;
                }
                else
                    if (ute == kd)
                {
                    Console.WriteLine("USER WIN");
                    i = saq + 1;
                }
                if (ute == 1)
                    ute = args.Length;
                else
                    ute--;

                if (ce == args.Length)
                    ce = 1;
                else
                    ce++;
              }
              Console.WriteLine("HMAC KEY: " + my_key);
              Console.WriteLine("USER SELECT  " + ncs + " -  " + args[ncs - 1]);
              Console.WriteLine("PC SELECT  " + value + " -  " + args[value - 1]);
              }


    }
}