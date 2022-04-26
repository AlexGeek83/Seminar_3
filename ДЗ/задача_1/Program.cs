// Программа, которая принимает на вход пятизначное число и проверяет
// является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

//bool IsPalindrome(string s)
//{
//    for (int i = 0; i < s.Length / 2; ++i)
//        if (s[i] != s[s.Length - 1 - i]) return false;
//    return true;
// }

System.Console.Write("Введите 5-значное число: ");
string num = Console.ReadLine();
if(num[0] == num[4] && num[1] == num[3])
System.Console.WriteLine($"Число {num} является палиндромом!");
else 
System.Console.WriteLine($"Число {num} не является палиндромом!");
