var number = 4566;

string numberInString = number.ToString();

for  (int i = 0; i < numberInString.Length; i++)
{
    Console.WriteLine(i + " => " + numberInString);
}