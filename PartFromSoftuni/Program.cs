using System;
using System.Collections.Generic;
using System.Linq;

namespace PartFromSoftuni
{
    class Program
    {
        static void Main(string[] args)
        {
            string guest = Console.ReadLine();

            bool isEnd = false;

            int count = 0;
            HashSet<string> AllPartyGuest = new HashSet<string>();
            
            while (guest != "END")
            {


                if(guest == "PARTY")
                {
                    while (guest != "END")
                    {
                        guest = Console.ReadLine();
                        if (AllPartyGuest.Contains(guest))
                        {
                            AllPartyGuest.Remove(guest);
                            count++;
                        }

                        if(guest == "END")
                        {
                            isEnd = true;
                            break;
                        }
                    }
                    
                }
                else
                {
                    AllPartyGuest.Add(guest);
                }
                if(isEnd)
                {
                    break;
                }
                guest = Console.ReadLine();
            }

            

            Console.WriteLine(AllPartyGuest.Count);
            foreach (var item in AllPartyGuest)
            {
                Console.WriteLine(item);
            }
        }
    }
}
