using System;
using static System.Console;
namespace TempConverter
{
    class Program
    {
        public static float ConvertFahrenheitToCelsius(){
            string input;
            float Fahrenheit, Celsius;

            Write("\n[*] Convert how many degree(s) Fahrenheit to Celsius: ");
            input = ReadLine();
            float.TryParse(input, out Fahrenheit);

            Celsius = (Fahrenheit - 32) * 5/9;

            WriteLine("{0} degree(s) Fahrenheit is {1} degree(s) Celsius", Fahrenheit, Math.Round(Celsius, 1));
            return Celsius;
        }

        public static float ConvertCelsiusToFahrenheit(){
            string input;
            float Celsius, Fahrenheit;

            Write("\n[*] Convert how many degree(s) Celsius to Fahrenheit: ");
            input = ReadLine();
            float.TryParse(input, out Celsius);

            Fahrenheit = (Celsius * 9/5) + 32;
            
            WriteLine("{0} degree(s) Celsius is {1} degree(s) Fahrenheit", Celsius, Math.Round(Fahrenheit, 1));
            return Fahrenheit;
        }

        public static float ConvertCelsiusToKelvin(){
            string input;
            float Celsius, Kelvin;

            Write("\n[*] Convert how many degree(s) Celsius to Kelvin: ");
            input = ReadLine();
            float.TryParse(input, out Celsius);

            Kelvin = Celsius + (float)273.15;
        
            WriteLine("{0} degree(s) Celsius is {1} degree(s) Kelvin", Celsius, Math.Round(Kelvin, 1));
            return Kelvin;
        }

        public static float ConvertFahrenheitToKelvin(){
            string input;
            float Fahrenheit, Celsius, Kelvin;

            Write("\n[*] Convert how many degree(s) Fahrenheit to Kelvin: ");
            input = ReadLine();
            float.TryParse(input, out Fahrenheit);

            Celsius = (Fahrenheit + 32) * 5/9;
            Kelvin = Celsius + (float)273.15;

            WriteLine("{0} degree(s) Fahrenheit is {1} degree(s) Kelvin", Fahrenheit, Math.Round(Kelvin, 1));
            return Kelvin;
        }

        public static float ConvertKelvinToFahrenheit(){
            string input;
            float Fahrenheit, Celsius, Kelvin;

            Write("\n[*] Convert how many degree(s) Kelvin to Fahrenheit: ");
            input = ReadLine();
            float.TryParse(input, out Kelvin);

            Celsius = Kelvin - (float)273.15;
            Fahrenheit = (Celsius + 32) * 5/9;

            WriteLine("{0} degree(s) Kelvin is {1} degree(s) Fahrenheit", Kelvin, Math.Round(Fahrenheit, 1));
            return Fahrenheit;

        }
        public static float ConvertKelvinToCelsius(){
            string input;
            float Celsius, Kelvin;

            Write("\n[*] Convert how many degree(s) Kelvin to Fahrenheit: ");
            input = ReadLine();
            float.TryParse(input, out Kelvin);

            Celsius = Kelvin - (float)273.15;

            WriteLine("{0} degree(s) Kelvin is {1} degree(s) Celsius", Kelvin, Math.Round(Celsius, 1));
            return Celsius;

        }

        public static float ConvertFahrenheitToRankine(){
            string input;
            float Fahrenheit, Rankine;

            Write("[*] Convert how many degree(s) Fahrenheit to Ralkine: ");
            input = ReadLine();
            float.TryParse(input, out Fahrenheit);

            Ralkine = Fahrenheit + (float)491.67;

            WriteLine("{0} degree(s) Fahrenheit is {1} degree(s) Ralkine", Fahrenheit, Math.Round(Rankine, 1));
            return Ralkine;
        }

        public static float ConvertCelsiusToRankine(){
            string input;
            float Celsius, Fahrenheit, Rankine;

            Write("[*] Convert how many degree(s) Celsius to Ralkine: ");
            input = ReadLine();
            float.TryParse(input, out Celsius);

            Fahrenheit = (Celsius * 9/5) + 32;
            Rankine = (Fahrenheit - 32) + (float)491.67;

            WriteLine("{0} degree(s) Celsius is {1} degree(s) Ralkine", Celsius, Math.Round(Rankine, 1));
            return Ralkine;

        }

        public static float ConvertKelvinToRankineWithFahrenheit(){
            string input;
            float Kelvin, Rankine, Fahrenheit, Celsius;

            Write("[*] Convert how many degree(s) Kelvin to Rankine using Fahrenheit: ");
            input = ReadLine();
            float.TryParse(input, out Kelvin);

            Celsius = Kelvin - (float)273.15;
            Fahrenheit = (Celsius * 9/5) + 32;
            Rankine = (Fahrenheit - 32) + (float)491.67;

            Write("{0} degree(s) Kelvin is {1} degree(s) Rankine using Fahrenheit", Kelvin, Math.Round(Rankine, 1));
            return Rankine;

        }
        public static float ConvertKelvinToRankineWithCelsius(){
            string input;
            float Kelvin, Rankine, Celsius, Fahrenheit;

            Write("[*] Convert how many degree(s) Kelvin to Ralkine using Celsius: ");
            input = ReadLine();
            float.TryParse(input, out Kelvin);

            Celsius = Kelvin - (float)273.15;
            Fahrenheit = (Celsius * 9/5) + 32;
            Rankine = (Fahrenheit - 32) + (float)491.67;            

            Write("{0} degree(s) Kelvin is {1} degree(s) Rankine using Celsius", Kelvin, Math.Round(Rankine, 1));
            return Rankine;

        }

        static void Main(string[] args)
        {
            int choice;
            string input;

            WriteLine("SharpTempConverter\n===========================\n[1] Fahrenheit -> Celsius\n[2] Celsius -> Fahrenheit\n[3] Celsius -> Kelvin \n[4] Fahrenheit -> Kelvin\n[5] Kelvin -> Celsius\n[6] Kelvin -> Fahrenheit\n[7] Fahrenheit -> Rankine\n[8] Celsius -> Rankine\n[9] Kelvin -> Rankine w/ Fahrenheit\n[10] Kelvin -> Rankine w/ Celsius");
            Write("\nChoice > ");
            input = ReadLine();
            int.TryParse(input, out choice);

            switch(choice){
                case 1:
                    ConvertFahrenheitToCelsius();
                    break;
                case 2:
                    ConvertCelsiusToFahrenheit();
                    break;
                case 3:
                    ConvertCelsiusToKelvin();
                    break;
                case 4:
                    ConvertFahrenheitToKelvin();
                    break;
                case 5:
                    ConvertKelvinToCelsius();
                    break;
                case 6:
                    ConvertKelvinToFahrenheit();
                    break;
                case 7:
                    ConvertFahrenheitToRankine();
                    break;
                case 8:
                    ConvertCelsiusToRankine();
                    break;
                case 9:
                    ConvertKelvinToRankineWithFahrenheit();
                    break;
                case 10:
                    ConvertKelvinToRankineWithCelsius();
                    break;
                default:
                    WriteLine("Invalid choice selected");
                    break;

            }
        }
    }
}
