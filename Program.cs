using System;


namespace ConverterProgram
{
    class InPhoneNumberConverter
    {
        public static string PhoneNumberMeth1(int[] number)
        {

            return String.Concat("(", String.Join("", String.Join("", number[0..3])), ")", " ",
                String.Join("", String.Join("", number[3..6])), "-",
                String.Join("", String.Join("", number[6..10])));
        }

        public static string PhoneNumberMeth2(int[] numbers)
        {
            return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int[] phonenumber = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Console.WriteLine(InPhoneNumberConverter.PhoneNumberMeth1(phonenumber));
        }
    }
}
