using Oop;

internal class Program
{
    private static void Main(string[] args)
    {



       Date birthday = new Date(2016, new YearDate(2, 29));
       Child schoolchild =  new Child("Barnet er født den ", birthday);

       Console.WriteLine(birthday);
       Console.WriteLine(schoolchild);

    }

    
}