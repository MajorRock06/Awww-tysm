Console.WriteLine("Hello, write af word you want in reverse:\n");
string Word = Console.ReadLine()!;

char[] stringarray = Word.ToCharArray();
Array.Reverse(stringarray);
string revWord = new string(stringarray);

Console.WriteLine("the reversed Word is: {0}", revWord);




int Age = 0; 
 
Console.WriteLine("Hello, Write your age:\n"); 
Age = Convert.ToInt32(Console.ReadLine()); 
 
int kAge = Age + 1; 
 
Console.WriteLine("you're age next year is: " + kAge);