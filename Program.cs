using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Member> members = new List<Member>();

            //                      !!!                 !!!                    !!!             !!!
            //                    !!!!!                 !!!                  !!!               !!!
            //                  !!! !!!                 !!!                !!!                 !!!
            //                !!!   !!!                 !!!              !!!                   !!!
            //              !!!     !!!                 !!!            !!!                     !!!
            //            !!!       !!!                 !!!          !!!                       !!!
            //          !!!         !!!                 !!!        !!!                         !!!
            //        !!!           !!!                 !!!      !!!                           !!!
            //      !!!             !!!                 !!!    !!!                             !!!
            //                      !!!                 !!!  !!!                               !!!
            //                      !!!                 !!!!!!                                 !!!
            //                      !!!                 !!!!!                                  !!!
            //                      !!!                 !!!!!!                                 !!!
            //                      !!!                 !!!  !!!                               !!!
            //                      !!!                 !!!    !!!                             !!!
            //                      !!!                 !!!      !!!                           !!!
            //                      !!!                 !!!        !!!                         !!!
            //                      !!!                 !!!          !!!                       !!!
            //                      !!!                 !!!            !!!                     !!!
            //                      !!!                 !!!              !!!
            //                      !!!                 !!!                !!!                 !!!
            //                      !!!                 !!!                  !!!               !!!


                         foreach (var member in members)

                               Console.WriteLine($"{ member.Name }, cieszę się, że jesteś!");



        }
    }
}
