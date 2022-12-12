Console.WriteLine("ВВедите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine()); 

string array = number.ToString();
if (array [0] == array [4] && array [1] == array [3] )
{
    Console.WriteLine("Yes" );
    
}
    else
    {
        Console.WriteLine("No" );
    }
