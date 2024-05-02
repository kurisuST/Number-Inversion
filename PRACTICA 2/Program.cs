int num, num1, num2, num3,num4;

Console.WriteLine("Write a 3 digit number");
num = int.Parse(Console.ReadLine());
num1 = num % 10;
num3= num / 100;
num2 = num / 10;
num4 = num2 % 10;
Console.WriteLine("Number inversion: "+num1 + num4 + num3);