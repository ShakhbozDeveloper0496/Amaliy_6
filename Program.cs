// See https://aka.ms/new-console-template for more information

System.Console.WriteLine("Click 1 to add data");

int enterAdd = Convert.ToInt32(Console.ReadLine());
List<string> strings= new List<string>();
 //string[] addString;
// addString[0]="dushanba";

if(enterAdd == 1)
{
    System.Console.WriteLine("kiritmoqchi bo'lgan malumotingiz miqdori:");
    int miqdori = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Enter add: (but you can only add string type)");
    for(int i=1; i<=miqdori; i++)
    {
        strings.Add(Console.ReadLine());
    }
    foreach(string chiqar in strings)
    {
        System.Console.WriteLine($"siz kiritgan malumotlar: {chiqar}");
    string chiqaBir= chiqar;
    }

System.Console.WriteLine("Click 2 to delete data \nClick 3 to view data");
int enterAddadd = Convert.ToInt32(Console.ReadLine());
 if(enterAddadd == 2)
{
    System.Console.WriteLine("All data deleting!");
    strings.Clear();
System.Console.WriteLine($"there is not data");
System.Console.WriteLine("Click 3 to view data");
int enterAddaddadd = Convert.ToInt32(Console.ReadLine());
     if(enterAddaddadd == 3)
{
    foreach(string viewData in strings)
    {
        System.Console.WriteLine(viewData);
    }
}
}
else if(enterAddadd == 3)
{
    foreach(string viewData in strings)
    {
        System.Console.WriteLine(viewData);
    }
}
else
{
    System.Console.WriteLine("You Entered wrong number");
}
}




