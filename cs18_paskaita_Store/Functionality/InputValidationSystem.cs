﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cs18_paskaita_Store.Functionality
{
    public class InputValidationSystem
    {
        #region THEORY

        //https://dev.to/zacharypatten/beginner-s-guide-to-console-input-in-c-1654

        #endregion

        public static void ConsoleDelay(int milliseconds) // <-- planavau naudoti plačiau, bet be to, kad atidėtų console clean'ą, kad spėtų errorą parodyti, nelabai yra kur
        {
            Thread.Sleep(milliseconds);
        }

        public static int InputValidation(int selectorSize)
        {
            string input = Console.ReadLine();
            int inputValue;
            bool success = int.TryParse(input, out inputValue) && inputValue > 0 && inputValue <= selectorSize;
            while (!success)
            {
                Console.WriteLine("(!) Netinkama įvestis");
                Console.Write(" -> Bandykite dar kartą:");
                input = Console.ReadLine();
                success = int.TryParse(input, out inputValue) && inputValue > 0 && inputValue <= selectorSize;
            }
            Console.Clear();
            return inputValue;
        }
        public static int InputValidation() // Overload'as be argumentų (Galima naudoti ten, kur nėra list'as indeksuojamas, kad nemestų klaidos)
        {                                   // jeigu norėčiau listą plėsti tiesiog susiečiau kintamąjį selectorSize su listo dydžiu list.count, o ne vesčiau manually, kaip ankstesniame metode
            string input = Console.ReadLine(); //                                                                                                Taip padaryta yra CartAndChequeSystem.RemoveFromCart metode.
            int inputValue;
            bool success = int.TryParse(input, out inputValue) && inputValue > 0;
            while (!success)
            {
                Console.WriteLine("(!) Netinkama įvestis");
                Console.Write(" -> Bandykite dar kartą:");
                input = Console.ReadLine();
                success = int.TryParse(input, out inputValue) && inputValue > 0;
            }
            Console.Clear();
            return inputValue;
        }
        public static decimal InputValidationDecimal()
        {
            string input = Console.ReadLine();
            decimal inputValue;
            bool success = decimal.TryParse(input, out inputValue) && inputValue > 0;
            while (!success)
            {
                Console.WriteLine("(!) Netinkama įvestis");
                Console.Write(" -> Bandykite dar kartą:");
                input = Console.ReadLine();
                success = decimal.TryParse(input, out inputValue) && inputValue > 0;
            }
            Console.Clear();
            return inputValue;
        }
    }
}
