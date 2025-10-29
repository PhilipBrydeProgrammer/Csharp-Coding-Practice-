//Simpel debug af array og funktion
class Program
{
    public static void Main(string[] args)
    {
        int[] arr = new int[] { 4, 6, 2, 33, 5 };
        int svar = A(arr);
        Console.WriteLine(svar);
        int A(int[] arr)
        {
            int svar = 0;
            int pos = arr.Length - 1;
            svar = arr[pos];
            return svar;
        }

        Simple person = new Simple();
        person.ShowInfo();
    }
}

 class Simple
 { 
    
    int age = 23;
    string name = "Philip Bryde";
    string occupation = "*Athlete*";

    public void ShowInfo()
    {
        Console.WriteLine($"{name} {age} {occupation}");  
    }

    
 }