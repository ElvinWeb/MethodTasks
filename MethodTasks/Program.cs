namespace MethodTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SumOfEvenNumbers(15);
            //Console.WriteLine(ReturnSumOfEvenNumbers(15));
            //Console.WriteLine(RemoveSpaceInString("  Hello  World  "));
            //PrintFirstLetter("Print First  Letter");

        }
        //Bir int parametr qəbul edən və o ədədə qədər bütün cüt ədədlərin cəmini ekrana yazdıran,
        //həm return type-ı olan bir method, həm də void bir method yazırsız
        #region Task-1 
        static void SumOfEvenNumbers(int num)
        {
            int sum = 0;

            for (int i = 0; i < num; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
        static int ReturnSumOfEvenNumbers(int num)
        {
            int sum = 0;

            for (int i = 0; i < num; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        #endregion
        //Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri icində bosluqlar qalmayacaq hala gətirən metod.
        //Misal olaraq, name = "  Code  Acacemy   " deyə bir variable-mız varsa onu yaratdigimiz metoda göndərdikdə variable-daki dəyər "CodeAcademy" olmalıdır.
        #region Task-2
        //static string RemoveSpaceInString(string str)
        //{
        //    string newWord = String.Empty;
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (str[i] == ' ')
        //        {
        //            continue;
        //        }
        //        else
        //        {
        //            newWord += str[i];
        //        }
        //    }
        //    return newWord;
        //}
        #endregion
        //İstənilən verilən cümlədə sözlərin baş hərflərini ekrana yazdıran method yazın  məs .("Hello World --> "H" "W" )
        #region Task-3
        //static void PrintFirstLetter(string str)
        //{
        //    string result = String.Empty;
        //    bool check = true;

        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (str[i] == ' ')
        //        {
        //            check = true;
        //        }
        //        else if (str[i] != ' ' && check == true)
        //        {
        //            result += str[i] + " ";
        //            check = false;
        //        }

        //    }
        //    Console.WriteLine(result);
        //}

        #endregion
    }
}