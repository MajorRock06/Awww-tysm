Console.WriteLine("Hello, write af word you want in reverse:\n");
string Word = Console.ReadLine()!;

char[] stringarray = Word.ToCharArray();
Array.Reverse(stringarray);
string revWord = new string(stringarray);

Console.WriteLine("the reversed Word is: {0}", revWord);