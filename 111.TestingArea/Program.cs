#region ex1


//int a = 10;

//a += 10;
//Console.WriteLine("Orginal value of a: " + a + "\n");

//string input = Console.ReadLine();

//if ( int.TryParse(input, out a) )
//{
//    Console.WriteLine("User Input Value: " + a);
//}

//for ( int i = 0; i < a; i++ )
//{
//    Console.WriteLine(1 + 1);
//}
//Console.WriteLine("\n");

//int [] arr = { 1, 2, 3, 4, 5, 6, 7 };

//var res = arr.Where(a => a > 3);

//foreach ( int ii in res )
//{
//    Console.WriteLine(ii);
//}
#endregion

#region switchEX

int cardNo = 11;

string res = cardNo switch
{
    11 => "Jack",
    12 => "Queen",
    13 => "King",
    _ => "Normal"

};

Console.WriteLine(res);

#endregion