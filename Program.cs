using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Dynamic;
using System.Globalization;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Xml.Serialization;

//class Program
//{
/*  static void Main(String[] args)
  {
    //WriteLine Methods
    /* Console.WriteLine("Hello World!");
     Console.WriteLine("I am learning C#");
     Console.WriteLine("It is  awesome");
     Console.WriteLine(3 + 3);*/

//Write Methods
/* Console.Write("Hello World !");
 Console.Write("I will print on the same line");*/

//Variables-{String}
/*  string name = "John";
  Console.WriteLine(name);*/
//Example
/*  string greeting = "hello world \n";
  string name = "john";
  string message;
   message = greeting + name;
  Console.WriteLine(message);*/

/* int myNum = 15;
 Console.WriteLine(myNum);*/

//OR
/* int myNum;
 myNum = 15;
 Console.WriteLine(myNum);*/
//Example
/* int number = 42;
 Console.WriteLine(number);
 int sum = number + 10;
 Console.WriteLine(sum);
 int updatenumber = 100;
 Console.WriteLine(updatenumber);*/



//{double}
/* double myDoubleNum = 19.99;
   Console.WriteLine(myDoubleNum);*/
//Example
/* double price = 19.99 ;
 double tempreture = -3.5;
 double scientificValue = 6.023456;
 double radius = 5.5;
 double area = Math.PI * radius * radius;
 Console.WriteLine(price);
 Console.WriteLine(tempreture);
 Console.WriteLine(scientificValue);
 Console.WriteLine(area);*/

/*double a = 0.1;
double b = 0.2;
double sum = a + b;
Console.WriteLine(sum);*/

//{char}
/* char myLetter = 'D';
 Console.WriteLine(myLetter);*/
//Example
/*char myChar = 'A';
Console.WriteLine(myChar);
char ch1 = 'a';
Console.WriteLine(ch1);
char ch3 = '\x0061';  // 'a'
Console.WriteLine(ch3);
char ch4 = (char)97;  // 'a'
Console.WriteLine(ch4);
char letter = 'B';
Console.WriteLine(letter);
char digit = '7';
Console.WriteLine(digit);
char lower = 'c';
Console.WriteLine(lower);
char newLine = '\n';
char tab = '\t';
char backslash = '\\';
char singleQuote = '\'';
Console.WriteLine(newLine);
Console.WriteLine(tab);
Console.WriteLine(backslash);
Console.WriteLine(singleQuote);*/


//{Bool}
/*bool myBool = true;
Console.WriteLine(myBool);*/
//Example
/* int x = 10;
 int y = 20;
 bool isXGreaterThanY = x > y; 
    Console.WriteLine($"Is x greater than y? {isXGreaterThanY}");*/

//Display variables {1}
/* string name = "John";
 Console.WriteLine("Hello"+ name  );*/
//{2}
/*string firstName = "John";
string lastName = "Doe";
string fullName = firstName + lastName;
Console.WriteLine(fullName);*/
//{3}
/*int x = 5;
int y = 6;
Console.WriteLine(x + y);*/

//Multiple variables {1}
/* int x = 5, y = 6, z = 50;
 Console.WriteLine(x + y + z);*/
//{2}
/* int x, y, z;
 x = y = z = 50;
 Console.WriteLine(x + y + z);*/

//Integer types -Int 
/*  int myNum = 100000;
  Console.WriteLine(myNum);*/
//long
/*long myNum = 15000000L;
Console.WriteLine(myNum);*/

//Floting types - Float
/* float myNum = 5.75F;
 Console.WriteLine(myNum);*/
//double
/*double myNum = 19.99D;
Console.WriteLine(myNum);*/

//Scientific Numbers
/* float f1 = 35e3F;
 double d1 = 12D;
 Console.WriteLine(f1);
 Console.WriteLine(d1);*/

//Type Casting
//Implicity-{Example}
/* int myInt = 9;
 double myDouble = myInt;
 Console.WriteLine(myInt);
 Console.WriteLine(myDouble);*/
//Explicit-}{Example}
/* double myDouble = 9.78;
 int myInt = (int)myDouble;
 Console.WriteLine(myDouble);
 Console.WriteLine(myInt);*/

//Type Conversion Method-{Example}
/*int myInt = 10;
double myDouble = 5.25;
bool myBool = true;
Console.WriteLine(Convert.ToString(myInt));
Console.WriteLine(Convert.ToDouble(myInt));
Console.WriteLine(Convert.ToInt32(myDouble));
Console.WriteLine(Convert.ToInt64(myInt));
Console.WriteLine(Convert.ToString(myBool));*/

//User Input - {Example 1}
/*Console.WriteLine("Enter username");
string userName = Console.ReadLine();
Console.WriteLine("Username is" + userName);*/
//{Example 2}-Error
/*Console.WriteLine("Enter your age");
int age = Console.ReadLine();
Console.WriteLine("your age is" + age);*/
//not error
/* Console.WriteLine("Enter your age");
 int age = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Your age is" + age);*/

//OPERATORS-{Example 1}
/*int x = 100 + 50;
Console.WriteLine(x);*/

//{Example 2}

/*int sum1 = 100 + 50;
int sum2 = sum1 + 250;
int sum3 = sum2 + sum2;
Console.WriteLine(sum1);
Console.WriteLine(sum2);
Console.WriteLine(sum3);*/

//Arithmetic Operators
/* int x = 45;
 x++;
x--;
 int y = 15;
 Console.WriteLine(x + y); //Addition
 Console.WriteLine(x - y); //Subtraction
 Console.WriteLine(x * y); //Multiplication
 Console.WriteLine(x / y); //Division
 Console.WriteLine(x % y); //Modulus
Console.WriteLine(x); //Increment
 Console.WriteLine(x); //Decrement*/

//Assignment Operator {Example}
/* int x = 10;
 // x += 5; //Addition
 //x -= 3;  //subtraction
 //x *= 3; //multiplication
 //  x /= 3; //division
 // x %= 3; //modulus
 // x &= 3; //bitwise and
 //x |= 3; //bitwise or
 //  x ^= 3; //bitwise xor
 // x >>= 3; //right shift
// x <<= 3; //left shift
 Console.WriteLine(x);*/

//Comparision Operator-{Example}
/* int x = 5;
 int y = 3;
 Console.WriteLine(x == y); //equal to
 Console.WriteLine(x != y); //not equal
 Console.WriteLine(x > y); //greater than
 Console.WriteLine(x < y); //less than
 Console.WriteLine(x >= y); //greater than and equal to
 Console.WriteLine(x <= y);*/ //less than and equal to


//Logical Operators -{Example}
/* int x = 5;
 Console.WriteLine(x > 3 && x < 10);     // logical and
 Console.WriteLine(x > 5 || x < 4);       //logical or
  Console.WriteLine(!(x > 3 && x < 10));*/  //logical not

//Math tools {Example}
//Math.Max
/* Console.WriteLine(Math.Max(5, 10));
 //Math.Min
 Console.WriteLine(Math.Min(5, 10));
 //Math.Sqrt
 Console.WriteLine(Math.Sqrt(64));
 //Math.Abs
 Console.WriteLine(Math.Abs(-4));
 //Math.Round
 Console.WriteLine(Math.Round(9.99));*/

//STRING -{EXAMPLE}
/* string greeting = "Hello";
 Console.WriteLine(greeting);
 string greeting2 = "Nice to meet you";
 Console.WriteLine(greeting2);
 //STRING LENGTH
 string txt = "ABCDEFGHI";
 Console.WriteLine("The length of the txt string " + txt.Length);*/
//OTHER METHODS-{TOUPPERCASE}
/* string txt = "Hello World!";
 Console.WriteLine(txt.ToUpper());
 Console.WriteLine(txt.ToLower());*/
//STRING CONCATENATION {Example 1}
/* string firstName = "John";
 string lastName = "Doe";
 //string name = firstName + lastName;
 string name = string.Concat(firstName, lastName);
 Console.WriteLine(name);
 //{Example 2}
 string x = "10";
 string y = "20";
 // string z = x + y;
 string z = string.Concat(x, y);
 Console.WriteLine(z);*/
//STRING INTERPOLATION -{EXAMPLE}
/*  string firstName = "John";
  string lastName = "Doe";
  string name = $"My full name is  {firstName}  {lastName}";
  Console.WriteLine(name);
  //ACESS STRING {EXAMPLE 1}
  string myString = "Hello";
  Console.WriteLine(myString[0]);
  Console.WriteLine(myString[1]);
  //{EXAMPLE 2} SPECIFIC METHOD
  Console.WriteLine(myString.IndexOf("e"));*/
//LOCATION 
/* string name = "John Doe";
 int charPos = name.IndexOf("D");
 string lastName = name.Substring(charPos);
 Console.WriteLine(lastName);*/

//SPECIAL CHARACTER
//{\"- double quotes}
// string txt = "we are the so-called\" vikings \" from the north";
//{\'- single quotes}
// string txt = "It\'s alright";
//{\\- backslash}
// string txt = "The character \\ is called backslash";
//{\n- new line}
//string txt = "Hello\nWorld";
//{\t- new tab}
// string txt = "Hello\t World";
//{\b- backspace}
// string txt = "hel\b lo World";
//Console.WriteLine(txt);


//BOOLEANS EXAMPLE
/*  bool isCSharpFun = true;
  bool isFishTasty = false;
  Console.WriteLine(isCSharpFun);
  Console.WriteLine(isFishTasty);
  //COMPARISION OPERATOR{>}
  int x = 10;
  int y = 15;
  Console.WriteLine(x > y);
  //Or
  // Console.WriteLine(10 > 15);*/
//EQUAL TO {==}
/*int x = 10;
Console.WriteLine(x == 10);
//or
//Console.WriteLine(10 == 15);
//EQUAL TO GREATER THAN{>=}
int myAge = 25;
int votinAge = 18;
Console.WriteLine(myAge >= votinAge);*/

//IF STATEMENTG{EXAMPLE}
/*if (20 > 18)
{
  Console.WriteLine("20 is greater than 18");
}
//{2}
int x = 20;
int y = 18;
if (x > y)
{
  Console.WriteLine("x is greater than y");
}
//{3}
int age = 18;
if (age >= 18)
{
  Console.WriteLine("you are an adult");
}
//{4}
int Score = 85;
if (Score > 90)
{
  Console.WriteLine("Excellent");
}
if (Score > 75)
{
  Console.WriteLine("good job");
}
if (Score > 50)
{
  Console.WriteLine("you passes");
}*/

// ELSE STATEMENT{1}
/* int tempreature = 20;
 if (tempreature > 18)
 {
   Console.WriteLine("good day");
 }
 else
 {
   Console.WriteLine("bad day");
 }
 //{2}
 int score = 75;
 if (score >= 90)
 {
   Console.WriteLine("grade A");
 }
 else
 {
   Console.WriteLine("grade B");
 }*/
//IF ELSE IS STATEMENT {1}
/*int score = 75;
if (score >= 90)
{
  Console.WriteLine("grade A");
}
else if (score >= 80)
{
  Console.WriteLine("grade B");
}
else if (score >= 70)
{
  Console.WriteLine("grade C");
}
else
{
  Console.WriteLine("fail");
}*/

//Example - to check if a number is positive or negative
/* int x = Convert.ToInt32(Console.ReadLine());
 if (x > 0)
 {
   Console.WriteLine("it is a positive number");
 }
 else if (x < 0)
 {
   Console.WriteLine("it is negative number");
 }
 else
 {
   Console.WriteLine("zero");
 }*/
// program even or odd
/* int x = Convert.ToInt32(Console.ReadLine());
 if (x % 2 == 0)
 {
   Console.WriteLine("it is a even number");
 }
 else 
 {
   Console.WriteLine("it is odd number");
 }*/

//eligible to vote
/* int age = Convert.ToInt32(Console.ReadLine());
 if (age > 18)
 {
   Console.WriteLine("it is eligible for vote");
 }
 else
 {
   Console.WriteLine("it is not eligible for vote ");
 }*/
//largest two numbers
/* Console.Write("print the first num1");
 int num1 = Convert.ToInt32(Console.ReadLine());
 Console.Write("print the second num2");
 int num2 = Convert.ToInt32(Console.ReadLine());
 if (num1 > num2)
 {
   Console.WriteLine( " largest num1 = " +num1);
 }
 else if (num2 > num1)
 {
   Console.WriteLine(" largest num2 = " +num2);
 }
 else
 {
   Console.WriteLine(num1 = num2);
 }*/
//check character value ia a vowel or constant
/*Console.Write("print the alphabet value");
char ch = Convert.ToChar(Console.ReadLine().ToLower());
if (char.IsLetter(ch))
{
  if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
  {
    Console.WriteLine("it is a vowel alphabet");
  }
  else
  {
    Console.WriteLine("it is a constant value");
  }
}*/

// program  find the grade of a student 
/* Console.Write("print the number");
 int x = Convert.ToInt32(Console.ReadLine());

 if (x >= 90)
 {
   Console.WriteLine("Grade A");
 }
 if (x >= 90)
 {
   Console.WriteLine("Grade B");
 }
 else if (x >= 80)
 {
   Console.WriteLine("Grade C");
 }
 else if (x >= 70)
 {
   Console.WriteLine("Grade C");
 }
 else if (x >= 60)
 {
   Console.WriteLine("Grade D");
 }
 else
 {
   Console.WriteLine("Fail");
  }*/

//print three largest number
/* Console.Write("Enter the first number");
 int a = Convert.ToInt32(Console.ReadLine());

 Console.Write("Enter the second number");
 int b = Convert.ToInt32(Console.ReadLine());

 Console.Write("Enter the third number");
 int c = Convert.ToInt32(Console.ReadLine());

 if (a > b && a > c)
 {
   Console.WriteLine(" Largest A");
 }
 else if (b > c && b > a)
 {
   Console.WriteLine("Largest B");
 }
 else
 {
   Console.WriteLine("Largest C");
 }*/

//temprature condition in celsius
/* Console.Write("Enter tempreature in celsius");
 int temp = Convert.ToInt32(Console.ReadLine());

 string description;
 if (temp >= 0 && temp <= 20)
 {
   description = "Freezing";
 }
 else if (temp >= 21 && temp <= 40)
 {
   description = "Cold";
 }
 else if (temp >= 41 && temp <= 60)
 {
   description = "Warm";
 }
 else
 {
   description = "hot";
 }
 Console.WriteLine("Temperature description:" + description);*/

//Leap Year
/*Console.Write("Enter the number of n");
int x = Convert.ToInt32(Console.ReadLine());

if (x % 4 == 0)
{
  Console.WriteLine("it is a leap year");
}
else
{
  Console.WriteLine("It is not a leap year");
}*/
//day of the week
/* Console.Write("enter the number of n");
 int x = Convert.ToInt32(Console.ReadLine());

 string description;
 if (x == 1)
 {
   description = "Sunday";
 }
 else if (x == 2)
 {
   description = "Monday";
 }
 else if (x == 3)
 {
   description = "Tuesday";
 }
 else if (x == 4)
 {
   description = "Wednesday";
 }
 else if (x == 5)
 {
   description = "Thrusday";
 }
 else if (x == 6)
 {
   description = "Friday";
 }
 else
 {
   description = "Saturday";
 }
 Console.WriteLine("The day of week is " + description);*/

// electricity bills usage in base usage slab
/* Console.Write("Enter the electricity usage in units(KWh)");
 int units = Convert.ToInt32(Console.ReadLine());

 double billAmount = 0;
 if (units <= 100)
 {
   billAmount = units * 1.5;
 }
 else if (units <= 200)
 {
   billAmount = (100 * 1.5) + (units - 200) * 2.5;
 }
 else if (units <= 300)
 {
   billAmount = (100 * 1.5) + (100 * 2.5) + (units - 300) * 4.0;
 }
 else if (units <= 400)
 {
   billAmount = (100 * 1.5) + (100 * 2.5) + (100 * 4.0) + (units - 400) * 6.0;
 }
 Console.WriteLine("Electricity bill for {0} units is ₹ {1} " + units, billAmount);*/

//assign salary grade based on salary amount
/*Console.Write("Enter the salary amount");
double salary = Convert.ToDouble(Console.ReadLine());

string grade;
if (salary >= 100000)
{
  grade = "A (Excellent)";
}
else if (salary >= 75000)
{
  grade = "B (Very Good)";
}
else if (salary >= 50000)
{
  grade = "C (Good)";
}
else if (salary >= 30000)
{
  grade = "D (Average)";
}
else
{
  grade = "Below Average";
}
Console.WriteLine($"salary: {salary}, grade: {grade}");*/

//print season based on the month number
/*Console.Write("Enter the month number(1-12)");
int month = Convert.ToInt32(Console.ReadLine());

string season;
if (month == 12 || month == 1 || month == 2)
{
  season = "winter month";
}
else if (month >= 3 && month <= 5)
{
  season = "spring month";
}
else if (month >= 6 && month <= 8)
{
  season = "summer month";
}
else if (month >= 9 && month <= 11)
{
  season = "autumn month";
}
else
{
  season = "Invalid month";
}
Console.WriteLine($"Season:{season}");*/

//check range number
/* Console.Write("Enter the value of num");
 int num = Convert.ToInt32(Console.ReadLine());

 if (num < 0)
 {
   Console.WriteLine("Negative");
 }
 else if (num == 0)
 {
   Console.WriteLine("Zero");
 }
 else if (num >= 1 && num <= 10)
 {
   Console.WriteLine("Between numbers 1 to 10");
 }
 else if (num >= 11 && num <= 100)
 {
   Console.WriteLine("Between numbers 11 to 100");
 }
 else if (num >= 100)
 {
   Console.WriteLine("More than 100");
 }
 else
 {
   Console.WriteLine("Invalid numbers");
 }*/

//calculate simple income tax for different slabs
/* Console.Write("Enter the value of income");
 double income = Convert.ToDouble(Console.ReadLine());

 double tax = 0;
 if (income <= 2500000)
 {
   tax = 0;
 }
 else if (income <= 5000000)
 {
   tax = (income - 2500000) * 0.05;
 }
 else if (income <= 1000000)
 {
   tax = (2500000 * 0.05) + (income - 5000000) * 0.20;
 }
 else
 {
   tax = (2500000 * 0.05) + (5000000 * 0.20) + (income - 1000000) * 0.30;
 }
 Console.WriteLine($"your income tax is ₹{tax}");*/

//identify the quadrant of a point in the cartesion plane
/* Console.Write("Enter the value of x");
 int x = Convert.ToInt32(Console.ReadLine());

 Console.Write("Enter the value of y");
 int y = Convert.ToInt32(Console.ReadLine());

 if (x > 0 && y > 0)
 {
   Console.WriteLine("it is a 1st quadrant");
 }
 else if (x < 0 && y > 0)
 {
   Console.WriteLine("it is a 2nd quadrant");
 }
 else if (x < 0 && y < 0)
 {
   Console.WriteLine("it is a 3rd quadrant");
 }
 else if (x > 0 && y < 0)
 {
   Console.WriteLine("its is a 4th quadrant");
 }
 else if (x == 0 && y == 0)
 {
   Console.WriteLine("it is origin");
 }
 else if (x == 0)
 {
   Console.WriteLine("lies on the x-axis");
 }
 else if (y == 0)
 {
   Console.WriteLine("lies on the y-axis");
 }
 else
 {
   Console.WriteLine("Invalid point");
 }*/

// check a triangle based on side length

/* Console.Write("Enter sidec 1");
 int a = Convert.ToInt32(Console.ReadLine());

 Console.Write("Enter side 2");
 int b = Convert.ToInt32(Console.ReadLine());

 Console.Write("Enter side 3");
 int c = Convert.ToInt32(Console.ReadLine());

 if (a + b > c && a + c > b && b + c > a)
 {
   if (a == b && b == c && c == a)
   {
     Console.WriteLine("it is equilateral triangle");
   }
   else if (a == b || b == c || a == c)
   {
     Console.WriteLine("it is a isosceles triangle");
   }
   else
   {
     Console.WriteLine("it is a scalene triangle");
   }
 }*/

//time mangement system in a day
/*Console.Write("Enter the hour");
int hour = Convert.ToInt32(Console.ReadLine());

if (hour >= 5 && hour < 12) {
  Console.WriteLine("Good Morning");
}
else if (hour >= 12 && hour < 17) {
  Console.WriteLine("Good Afternoon");
}
else if (hour >= 17 && hour < 21) {
  Console.WriteLine("Good Evening");
}
else {
  Console.WriteLine("Good Night");
}*/

//SWITCH STATEMENT {EXAMPLE} - use the case , break, default 
/* Console.Write("Enter the day");
 int day = Convert.ToInt32(Console.ReadLine());

 switch (day)
 {
   case 1: Console.WriteLine("Monday"); break;
   case 2: Console.WriteLine("Tuesday"); break;
   case 3: Console.WriteLine("Wednesday"); break;
   case 4: Console.WriteLine("Thrusday"); break;
   case 5: Console.WriteLine("Friday"); break;
   case 6: Console.WriteLine("Saturday"); break;
   case 7: Console.WriteLine("Sunday"); break;
   default: Console.WriteLine("Invalid Day"); break;

 }*/

//WHILE LOOP -{EXAMPLE}
//simple example
/* int i = 0;
 while (i < 5)
 {
   Console.WriteLine("i is: " + i);
   i++;
 }*/
//while loop with break
/* int i = 0;
 while (true)
 {
   Console.WriteLine("i is: " + i);
   if (i == 5)
     break;
   i++;
 }*/
// user input until valid with while loop
/* string input = " ";
 while (input != "yes")
 {
   Console.WriteLine("Type 'yes' to continue");
   input = Console.ReadLine();
 }
 Console.WriteLine("Thanks");*/

//DO-WHILE LOOP -{EXAMPLE}
/* int count = 1;
 do
 {
   Console.WriteLine("count is: " + count);
   count++;
 }
 while (count <= 5);*/
//user input validation do while
/* string input;
 do
 {
   Console.Write("Enter 'yes' to continue");
   input = Console.ReadLine();
 }
 while (input != "yes");*/
//do while with break
/*int num = 1;
do
{
  Console.WriteLine(num);
  if (num == 0)
  {
    break;
  }
  num++;
}
while (num <= 5);*/

//FOR LOOP - {EXAMPLE}
//simple example
/*for (int i = 1; i <= 5; i++)
{
  Console.WriteLine(i);
}*/
//reverse loop
/* for (int i = 7; i >= 6; i--)
 {
   Console.WriteLine(i);
 }*/
// loop with custom step
/*  for (int i = 1; i <= 10; i += 2)
  {
    Console.WriteLine(i);
  }*/
//nested loops
/* for (int row = 1; row <= 3; row++)
 {
   for (int col = 1; col <= 3; col++)
   {
     Console.Write($"({row}, {col})");
   }
   Console.WriteLine();
 }*/
//FOR EACH LOOP -{EXAMPLE}
//looping through an array
/*string[] fruits = { "Apple", "Banana", "Cherry" };
foreach (string fruit in fruits)
{
  Console.WriteLine(fruit);
} */
//looping through a list
/* List<int> numbers = new List<int> { 10, 20, 30 };
 foreach (int num in numbers)
 {
   Console.WriteLine(num * 2);
 }*/

//BREAK STATEMENT IN LOOPS
//for loop
/*for (int i = 0; i < 10; i++)
{
  if (i == 5)
  {
    break;
  }
  Console.WriteLine(i);
}*/
//while loop
/* int counter = 0;
 while (true)
 {
   Console.WriteLine("counter: " + counter);
   counter++;
   if (counter == 5)
   {
     Console.WriteLine("Breaking the loop");
     break;
   }
 }*/
//do-while loop
/* int i = 0;
 do
 {
   Console.WriteLine("Iteration: " + i);
   i++;
   if (i > 5)
   {
     Console.WriteLine("breaking the loop");
     break;
   }
 }
 while (i < 10);
 Console.WriteLine("Loop finished");*/
//list do while
/*  List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David" };
  string target = "Charlie";
  bool found = false;
  do
  {
    foreach (string name in names)
    {
      Console.WriteLine("Checkin: " + name);
      if (name == target)
      {
        Console.WriteLine("found: " + name);
        found = true;
        break;
      }
    }
  }
  while (false);
  if (!found)
  {
    Console.WriteLine("target: " );
  }*/

//ARRAY- ONE DIMENSIONAL ARRAY
//simple\
/*Console.Write("Enter the value of i");
int i = Convert.ToInt32(Console.ReadLine());
int[] ages = new int[3];
ages[0] = 25;
ages[1] = 30;
ages[2] = 35;
Console.WriteLine(ages [i] );*/
//for loop
/* string[] colors = { "Red", "Green", "Blue" };
 for (int i = 0; i < colors.Length; i++)
 {
   Console.WriteLine(i);
 }
//Foreach loop
foreach (string color in colors)
{
  Console.WriteLine(color);
}*/
//changing array elements
/*  int[] numbers = { 10, 20, 30, 40 };
  numbers[2] = 99;
  Console.WriteLine(numbers[2]);*/
//array length -1
/* int[] numbers = { 5, 10, 15, 20, 25 };
 Console.WriteLine(numbers.Length);*/
//2
/*  string[] fruits = { "Apple", "Banana", "Cherry" };
  double[] prices = { 1.99, 2.49, 3.75, 4.10 };
  Console.WriteLine("Numbers of fruits " +fruits.Length );
  Console.WriteLine("Numbers of prices " + prices.Length);*/
//using a short array - 3
/*  short[] scores = new short[5];
  scores[0] = 120;
  scores[1] = -300;
  scores[2] = 32676;
  scores[3] = -32768;
  scores[4] = 0;
  foreach (short score in scores)
  {
    Console.WriteLine(score);
  }*/

//MULTIDIMENSIONAL ARRAY- 2D AARAY
//simple
/*  int[,] matrix = new int[3, 2];
  matrix[0, 0] = 1;
  matrix[0, 1] = 2;
  matrix[1, 0] = 3;
  matrix[1, 1] = 4;
  matrix[2, 0] = 5;
  matrix[2, 1] = 6;
  Console.WriteLine(matrix[1, 1]);*/
//example 3D aaray
/* int[,,] cube = new int[2, 2, 2];

 cube[0, 0, 0] = 10;
 cube[1, 1, 1] = 20;
 Console.WriteLine(cube[1, 1, 1]);*/
//acess element-2D
/*int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
for (int i = 0; i <numbers.Length ; i++)
{
Console.WriteLine(i); 
}*/
//change
/*int[,] matrix = {
{1,2,3},
{4,5,6},
{7,8,9},
};
matrix[1, 2] = 99;
for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    Console.Write(matrix[i, j] + "\t");
  }
  Console.WriteLine();
}*/

//ARRAY 1D EXAMPLES -{1}
/* string[] Books = new string[5];
 Books[0] = "C#";
 Books[1] = "Java";
 Books[2] = "VB.net";
 Books[3] = "C++";
 Books[4] = "C";
 foreach (string Book in Books)
 {
   Console.WriteLine("The name is: " +Book);
 }*/
//{2}
/* int[] numbers = new int[] { 1, 2, 3, 4, 5 };

   foreach (int number in numbers)
{
 Console.WriteLine(number);
}*/
//{3}
/* string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

 foreach (string weekDay in weekDays)
 {
   Console.WriteLine(weekDay);
 }*/
//{4}
/* int[] numbers = { 10, 20, 30, 40, 50 };

 for (int i = 0; i < numbers.Length; i++)
 {
   Console.WriteLine(numbers[i]);
}*/
//{5}
/*  int[] arr = new int[5];
  for (int i = 0; i < 5; i++)
  {
    Console.Write("Enter element[{0}]:", 1);
    arr[i] = Convert.ToInt32(Console.ReadLine());
  }*/

//TWO DIMENSINAL ARRAY - EXAMPLE -{1}
/* int[,] arr = { { 1, 2 }, { 3, 4 } };

 for (int i = 0; i < arr.GetLength(0); i++)
 {
   for (int j = 0; j < arr.GetLength(1); j++)
   {
     Console.Write(arr[i, j] + " ");
   }
   Console.WriteLine();
 }*/
//{2}
/* int[,] x = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
 for (int i = 0; i < x.GetLength(0); i++)
 {
   for (int j = 0; j < x.GetLength(1); j++)
   {
     Console.Write(x[i, j] + " ");
   }
   Console.WriteLine();
  }*/
//{3}
/*int[,] numbers = { { 2, 3 }, { 4, 5 } };
Console.WriteLine(numbers[0, 1]);
Console.WriteLine(numbers[1, 0]);*/
//{4}
/*int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
foreach (int i in numbers)
{
  Console.WriteLine(i);
}*/
//{5}
/* int[,] numbers = { { 1, 4, 2 }, { 3, 4, 6 } };
 for (int i = 0; i < numbers.GetLength(0); i++)
 {
   for (int j = 0; j < numbers.GetLength(1); j++)
   {
     Console.WriteLine(numbers[i, j]);
   }
 }*/
//{6}
/* int[,] myArray = new int[3, 4];

 for (int i = 0; i < 3; i++)
 {
   for (int j = 0; j < 4; j++)
   {
     Console.Write(myArray[i, j] + " ");
   }
   Console.WriteLine();
 }*/
//SHORT ARRAY - EXAMPLE-{1}
/* short[] numbers = { 1, 2, 3, 4, 5 };
 foreach (short num in numbers)
 {
   Console.WriteLine(num + " ");
 }*/
//{2}
/* short[] numbers = new short[3];
 numbers[0] = 10;
 numbers[1] = 20;
 numbers[2] = 30;


foreach (short num in numbers)
{
 Console.Write(num + " ");
}*/
//{3}
/*short[] numbers = new short[] { 5, 10, 15 };

foreach (short num in numbers)
{
Console.Write(num + " ");
}*/
//{4}
/* short[] data = { 100, 200, 300 };
 for (int i = 0; i < data.GetLength(0); i++)
 {
   Console.WriteLine(data[i]);
 }*/
//{5}
/*short[] ages = { 18, 21, 30 };
short firstAge = ages[0];

ages[1] = 25;
foreach (int age in ages)
{
  Console.WriteLine(age);
}*/
//{6}
/* short[] temps = { 22, 23, 24 };
 foreach (short t in temps)
 {
   Console.WriteLine(t);
 }

}*/
//  EXAMPLES OF FUNCTION CALL - PARAMETTERS
/*  static int FindHCF(int a, int b)
  {
    while (b != 0)
    {
      int temp = 0;
      b = a % b;
      a = temp;
    }
    return a;
  }*/
/*public static bool IsPerfect(int number)
{
    int sum = 0;
    for (int i = 1; i < number; i++)
    {
        if (number % i == 0)
        {
            sum += i;
        }
    }
    return sum == number; // Added return statement
}*/

//static void Main(String[] args)
//{

/*Console.Write("Enter the value of num");
int num = Convert.ToInt32(Console.ReadLine());
int reverse = 0;
while (num != 0)
{
  reverse = reverse * 10 * num % 10;
  num = num / 10;
}*/

/* Console.Write("Enter a number");
      int number = Convert.ToInt32(Console.ReadLine());

      if (IsPerfect(number))
      {
        Console.WriteLine("{0} is a perfect number", number);
      }
      else
      {
        Console.WriteLine("{0} is not a perfect number", number);
      }*/
/*  Console.Write("Enter first number");
              int num1 = Convert.ToInt32(Console.ReadLine());

              Console.Write("Enter the second number");
              int num2 = Convert.ToInt32(Console.ReadLine());

              int hcf = FindHCF(num1, num2);
              Console.WriteLine("HCF of {0} and {1} is: {2}", num1, num2, hcf);*/
//  }
//}


//EXAMPLES OF  CALSS MEMBERS 
//{1}
/*class Car
{
  string color = "red";//field
  int maxSpeed = 200;//field
  public void Drive()
  {
    Console.WriteLine($"The {color} car is driving at {maxSpeed} km/h");
  }

    }
class Program
{
  static void Main(string[] args)
  {
    Car myCar = new Car();
    myCar.Drive();
      }
    }*/

//EXAMPLE OF CLASS MEMBERS - {FIELDS}
//{1}
/*class Car
{
  string color = "red";
  int maxSpeed = 200;
  public static void Main(string[] args)
  {
    Car myObj = new Car();
    Console.WriteLine(myObj.color);
    Console.WriteLine(myObj.maxSpeed);
  }
    }*/
//{2}
/*class Car
{
  string Model;
  string color;
  int year;
  static void Main(string[] args)
  {
    Car Ford = new Car();
    Ford.Model = "Mustang";
    Ford.color = "red";
    Ford.year = 1969;

    Car Opel = new Car();
    Opel.Model = "Astra";
    Opel.color = "white";
    Opel.year = 2005;

    Console.WriteLine(Ford.Model);
    Console.WriteLine(Ford.color);
    Console.WriteLine(Ford.year);
    Console.WriteLine(Opel.Model);
    Console.WriteLine(Opel.color);
     Console.WriteLine(Opel.year);
  }
    }*/
//{3}
/*public class Circle
{
  public double Radius;
  public double Area()
  {
    return Radius * Radius * Math.PI;
  }
    }
class Program
{
  static void Main(string[] args)
  {
    Circle circle = new Circle();
    circle.Radius = 5.0;
    double area = circle.Area();
    Console.WriteLine("Area of the circle: " + area);
      }
    }*/

//{4}
/*public class Circle
{
    public double Radius { get; set; }

    public double Area()
    {
        return Math.PI * Radius * Radius;
    }
}

public abstract class CircleBasedSolid
{
    protected Circle Based = new Circle();

    public double Radius
    {
        get { return Based.Radius; }
        set { Based.Radius = value; }
    }

    public double Height { get; set; }
}

public class Cylinder : CircleBasedSolid
{
    public double Volume()
    {
        return Based.Area() * Height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cylinder c = new Cylinder();
        c.Radius = 3;
        c.Height = 5;

        Console.WriteLine("Volume of cylinder: " + c.Volume());
    }
}*/

//EXAMPLES OF OBJECT METHODS IN CLASS MEMBERS -{1}
/*class Dog
{
  public string breed;
  public void bark()
  {
    Console.WriteLine("Bark Bark!!");
  }
}

class Program
{
  static void Main(string[] args)
  {
    Dog bullDog = new Dog();
    bullDog.breed = "Bull Dog";
    Console.WriteLine(bullDog.breed);
    bullDog.bark();
  }
}*/

//{2}
/*class Emplyoee
{
  public string name;
  public void work(string job)
  {
    Console.WriteLine("Work: " + job);
  }
}
class Program
{
  public static void Main(string[] args)
  {
    Emplyoee e1 = new Emplyoee();
    e1.name = "Gloria";
    e1.work("Coding");

    Emplyoee e2 = new Emplyoee();
    e2.name = "John";
    e2.work("Documentation");
  }
}*/

//CONSTRUCTORS WITH PARAMETERS
/*class Car
{
  public string model;
  public Car(string modelName)
  {
    model = modelName;
  }
}
class Program
{
  static void Main(string[] args)
  {
    Car Ford = new Car("Mustang");
    Console.WriteLine(Ford.model);
  }
}*/

//CONSTRUCTORS SAVE EXAMPLES
/*class Car
{
  public string model;
  public string color;
  public int year;
  public Car(string modelName, string modelColor, int modelYear)
  {
    model = modelName;
    color = modelColor;
    year = modelYear;

  }
}
class Program
{
  static void Main(string[] args)
  {
    Car Ford = new Car("Mustang", "Red", 1969);
    Console.WriteLine($"{Ford.color}, {Ford.year}, {Ford.model}");
  }
}*/

//ACCESS MODIFIER - EXAMPLE 
//{1} - PUBLIC
/*public class car
{
  public string Model = "Sedar";
}

class Program
{
  static void Main(string[] args)
  {
    car MyCar = new car();
    Console.WriteLine(MyCar.Model);
  }
}*/
//{2} PRIVATE
/*public class Car
{
  private int speed = 0;
  private void Accelerate()
  {
    speed += 10;
  }
}
class Program
{
  static void Main(string[] args)
  {
    Car MyCar = new Car();
    Console.WriteLine(MyCar.Accelerate()); //not accessible for outside the class
  }
}*/
//{3}PROTECTED
/*public class Vehicle {
    protected void StartEngine() {
        Console.WriteLine("Engine started");
    }
}

public class Bike : Vehicle {
    public void Ride() {
        StartEngine(); 
    }
}
class Program {
    static void Main(string[] args) {
        Bike myBike = new Bike();
        myBike.Ride();
    }
}*/

//{4} INTERNAL
/*internal class Helper {
    internal void Log(string message) {
        Console.WriteLine(message);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Helper helper = new Helper();  
        helper.Log("Hello, this is a log message.");  
    }
}*/

//{5} PROTECTED INTERNAL
/*public class Base {
    protected internal void Show() {
        Console.WriteLine("Visible in same assembly or derived class");
    }
}
public class Program {
    public static void Main() {
        Base obj = new Base();
        obj.Show();  
    }
}*/

//{6} PRIVATE PROTECTED
/*public class Base {
    private protected void Configure() {
        Console.WriteLine("Restricted to derived classes in same assembly");
    }
}
class Program
{
  static void Main()
  {
    Derived obj = new Derived();
    obj.CallConfigure();  
  }
}*/

//PROPERTY METHODS  ENCAPSULATION - {EXAMPLES}
/*class Person
{
  private string name;
  public string Name
  {
    get { return name; }
    set { name = value; }
  }
  }
class Program
{
  static void Main(string[] args)
  {
    Person p = new Person();
    p.Name = "Anjel";
    Console.WriteLine(p.Name);
    }
  }*/
//{2}
/*class Car
{
  public string password;
  public string Password
  {
    set { password = value; }
  }
}
class Program
{
  static void Main(string[] args)
  {
    Car myCar = new Car();
    myCar.Password = "mySecret123";
    string currentPassword = myCar.password; 
  }
}*/
//COMPUTED PROPERTIES {3}
/*public class Rectangle
{
  public int width { get; set; }
  public int Height { get; set; }
  public int Area
  {
    get{ return width * Height; }
  }
}
class Program
{
  static void Main(string[] args)
  {
    Rectangle rect = new Rectangle();

    Console.WriteLine($"Width: {rect.width}");
    Console.WriteLine($"Height: {rect.Height}");
    Console.WriteLine($"Area: {rect.Area}");

rect.width = 8;
rect.Height = 12;
Console.WriteLine($"Updated Area: {rect.Area}");

  }
}*/

//INHERITANCE IN OOPs - EXAMPLE{1}
//base class
/*public class Animal
{
  public void Eat()
  {
    Console.WriteLine("The animal eats foods");
  }
}
//derived class
public class Dog : Animal
{
  public void Bark()
  {
    Console.WriteLine("The dog barks.");
  }
  }
class Program
{
  static void Main()
  {
    Dog myDog = new Dog();
    myDog.Eat();
    myDog.Bark();
    }
  }*/

//METHODS DECLARE AND CALLING METHODS -{EXAPLME}


//class Program
//{
//{1}
/*  static void GreetUser()
  {
    Console.WriteLine("Hello Anjel!");
  }

  static void Main(string[] args)
  {
    GreetUser();
    }*/
//{2}
/*public int Add(int a, int b)
{
  return a + b;
}
static void Main(string[] args)
{
  int a = 5;
  int b = 7;
  int sum = (a + b);
  Console.WriteLine(sum);
  }*/
//{3}
/*static void OuterMethod()
{
  void InnerMethod()
  {
    Console.WriteLine("This is a local function inside a outermethod()");
  }
  InnerMethod();
}
static void Main(string[] args)
{
  OuterMethod();
}*/

//PARAMETERS -{NAMED, OPTIONAL, PARAMS}
//{1} - named
/*static void Greet(string name, int age)
{
  Console.WriteLine($"Hello {name}, age {age}");
}

static void Main(string[] args)
{
  Greet(age: 25, name: "Anjel");
}*/
//{2} - optional
/*static void Greet(string name = "Guest", int age = 18)
{
  Console.WriteLine($"Hello, {name}, age {age}");
}
static void Main(string[] args)
{
  Greet();
}*/
//{3} - params
/*  static void PrintNumbers(params int[] numbers)
  {
    foreach (int num in numbers)
      Console.WriteLine(num);
  }
  static void Main(string[] args)
  {
    PrintNumbers(1, 2, 3, 4);
  }*/
//{4} combine example
/*static void Display(string title = "Info", params string[] message)
{
  Console.WriteLine($"Title: {title}");
  foreach (var msg in message)
    Console.WriteLine($"-{msg}");
}
static void Main(string[] args)
{
  Display(message: new[] { "Hello", "World" });
}*/
//}

//METHODS OVERTLOADING AND RECURISON
//{1}
/*class Calculator {
  static public int Add(int a, int b)
  {
    return a + b;
  }
  static double Add(double c, double d)
  {
    return c + d;
  }
  static void Main(string[] args)
  {
    int a = 5;
    int b = 10;
    int sumInt = a + b;
    Console.WriteLine(sumInt);
    double c = 5.5;
    double d = 7.3;
    double sumDouble = c + d;
    Console.WriteLine(sumDouble);
  }
}*/
//{2} - factorial calculation
/*class Program
{
  static int factorial(int n)
  {
    if (n == 0) return 1;
    return n * factorial(n - 1);
  }
  static void Main(string[] args)
  {
    Console.WriteLine(factorial(5));
  }
}*/

//{2} fibonacci series
/*class Program
{
  static int fibonacci(int n)
  {
    if (n <= 1) return n;
    return fibonacci(n - 1) + fibonacci(n - 2);
  }
  static void Main(string[] args)
  {
    
    Console.WriteLine(fibonacci(6));
  }
}*/

//{3} CountDown Timer
/*class Program
{
  static void Countdown(int seconds)
  {
    if (seconds == 0)
    {
      Console.WriteLine("Time up!");
      return;
    }
    Console.WriteLine(seconds);
    Countdown(seconds - 1);
  }
  static void Main(string[] args)
  {
    Countdown(5);
   }
  }*/

//{4} Sum of array elements
/*class Program
{
  static int Sum(int[] arr, int index)
  {
    if (index >= arr.Length) return 0;
    return arr[index] + Sum(arr, index + 1);
  }
  static void Main(string[] args)
  {
    int[] nums = { 2, 4, 5, 6 };
    Console.WriteLine(Sum(nums, 0));
  }
  }*/

//{5} Reverse a string
/*class Program
{
  static string Reverse(string str)
  {
    if (str.Length <= 1) return str;
    return str[1] + Reverse(str.Substring(0, str.Length - 1));
  }
  static void Main(string[] args)
  {
    Console.WriteLine(Reverse("hello"));
    }
  }*/

//{6} Power Calculation
/*class Program
{
  static int Power(int x, int n)
  {
    if (n == 0) return 1;
    return x * Power(x, n - 1);
  }
  static void Main(string[] args)
  {
    Console.WriteLine(Power(2, 3));
    }
  }*/

//EXAMPLES OOPS
//1. CLASSES AND OBJECTS
/*class Car
{
  public string color;
  public int speed;
  public void Drive()
  {
    Console.WriteLine($"car is {color} driving at {speed} km/h");
  }
     }
class Program
{
  static void Main(string[] args)
  {
    Car myCar = new Car();
    myCar.color = "Red";
    myCar.speed = 100;
    myCar.Drive();
  }
  
     }*/
//2
/*class Car
{
  public string brand;
  public int year;
  public void Honk()
  {
    Console.WriteLine("Beep beep!");
  }
}
class Program
{
  static void Main(string[] args)
  {
    Car myCar = new Car();
    myCar.brand = "Toyato";
    myCar.year = 2020;
    myCar.Honk();
  }
}*/
//CONSTRUCTOR EXAMPLE .1
/*class Person
{
  public string Name;
  public Person(string name)
  {
    Name = name;
  }
}
class Program
{
  static void Main(string[] args)
  {
   Person person1 = new Person("Anjel");
Console.WriteLine(person1.Name);

  }
}*/
//DESTRUCTOR EXAMPLE
/*class Person
{
  ~Person()
  {
    Console.WriteLine("Anjel");
  }
}
class Program
{
  static void Main(string[] args)
  {
Person p = new Person();
        

        GC.Collect();      // Force garbage collection
        GC.WaitForPendingFinalizers(); // Wait for destructor to run

        Console.WriteLine("Main finished");
  }
}*/

//INHERITANCE EXAMPLE 
/*public class Animal()
{
  public void Eat()
  {
    Console.WriteLine("Barking...");
  }
}
public class Dog : Animal
{
  public void Bark()
  {
    Console.WriteLine("Barking...");
  }
}
class Programn
{
  static void Main(string[] args)
  {
    Dog myDog = new Dog();
    myDog.Eat();
    myDog.Bark();
  }
}*/

//POLYMORPHISM EXAMPLE
/*public class Animal
{
  public virtual void MakeSound()
  {
    Console.WriteLine("some generic sound");
  }
}
public class Dog : Animal
{
  public override void MakeSound()
  {
    Console.WriteLine("Meow");
  }
}
class Program
{
  static void Main(string[] args)
  {
    Animal a = new Animal();
    a.MakeSound();
    Dog d = new Dog();
    d.MakeSound();
    Animal ad = new Dog();
    ad.MakeSound();
  }
}*/

//ENCAPSULATION EXAMPLE 
/*public class Person
{
  private string name;
  private int age;
  public string GetName()
  {
    return name;
  }
  public void SetName(string newName)
  {
    name = newName;
  }
}
class Program
{
  static void Main(string[] args)
  {
    Person person = new Person();           
    person.SetName("Anjel");                
    Console.WriteLine("Person's name is: " + person.GetName()); 
  }
  }*/

//ABSTRACT EXAMPLE
/*public abstract class Shape
{
  public abstract double Area();
    public int radius;
  }

public class Circle : Shape
{
  public override double Area() =>
    Math.PI * radius * radius;

}
class Program
{
  static void Main(string[] args)
  {
    Circle circle = new Circle();
    circle.radius = 5;

    double area = circle.Area();
    Console.WriteLine($"Area of the circle with radius {circle.radius} is {area:F2}");
  }
}*/

//INTERFACE EXAMPLE
/*public interface IShape
{
  double Area();
 
}
public class Circle : IShape
{
  public int radius;
  public double Area() => Math.PI * radius * radius;
}

class Program
{
  static void Main(string[] args)
  {
    Circle circle = new Circle();
    circle.radius = 5;

    double area = circle.Area();
    Console.WriteLine($"Area of the circle with radius {circle.radius} is {area:F2}");
  }
}*/

//DELEGATE EXAMPLE
/*public delegate void MyDelegate(string message);

class Program {
    public static void ShowMessage(string msg) {
        Console.WriteLine(msg);
    }

    static void Main() {
        MyDelegate del = ShowMessage;
        del("Hello from delegate!");
    }
}*/

//EVENTS EXAMPLE
/*public class Publisher
{
  public event EventHandler MyEvent;

  public void RaiseEvent()
  {
    MyEvent?.Invoke(this, EventArgs.Empty);
  }
}
public class Subscriber
{
  public void HandleEvent(object sender, EventArgs e)
  {
    Console.WriteLine("Event received!");
  }
}
class Program
{
  static void Main()
  {
    Publisher Pub = new Publisher();
    Subscriber sub = new Subscriber();

    Pub.MyEvent += sub.HandleEvent;
    Pub.RaiseEvent();
 
  }
}*/

//MULTIPLE EXAMPLE DELEGATES
/*public delegate void Notify();

public class Alert
{
  public void Email() => Console.WriteLine("Email sent!");
  public void SMS() => Console.WriteLine("SMS sent!");
}

class Program
{
  static void Main()
  {
    Alert a = new Alert();
    Notify notify = a.Email;
    notify += a.SMS;

    notify();

  }
}*/
//{3}
/*public delegate int MyDelegate(int x, int y);

class Program
{
  static int Add(int a, int b) => a + b;

  static void Main()
  {
    MyDelegate del = Add;
    Console.WriteLine(del(5, 3));
  }
}*/
//Action<T>
/*Action<string> greet = name => Console.WriteLine($"Hello, {name}!");
greet("Anjel"); // Output: Hello, Anjel!*/

//Function<T>Results
/*Func<int, int, int> multiply = (a, b) => a * b;
Console.WriteLine(multiply(4, 5)); */

//Predicate <T>
/*Predicate<string> isLong = str => str.Length > 5;
Console.WriteLine(isLong("Copilot")); */

//COLLECTION EXAMPLE 
// 1. List
/*List<string> fruits = new List<string>();
fruits.Add("Apple");
fruits.Add("Banana");
Console.WriteLine(fruits[1]);*/

//2. Dictionary
/*Dictionary<string, int> ageMap = new Dictionary<string, int>();
ageMap["Alice"] = 25;
ageMap["Bob"] = 30;
Console.WriteLine(ageMap["Alice"]);*/

//3. Hashset 
/*HashSet<int> uniqueNumbers = new HashSet<int>();
uniqueNumbers.Add(1);
uniqueNumbers.Add(2);
uniqueNumbers.Add(1);
Console.WriteLine(uniqueNumbers.Count);*/

//4. Queue<T> 
/*Queue<string> ticketQueue = new Queue<string>();
ticketQueue.Enqueue("Anjel");
ticketQueue.Enqueue("Ravi");
ticketQueue.Enqueue("priya");

Console.WriteLine(ticketQueue.Dequeue()); */

//5. stack<T>
/*Stack<string> plateStack = new Stack<string>();

plateStack.Push("Plate 1");
plateStack.Push("Plate 2");
plateStack.Push("Plate 3");

Console.WriteLine(plateStack.Pop());*/

//EXCEPTION HANDLING EXAMPLE { try, catch, finally}
//1.
/*class Program
{
    static void Main(string[] args)
    {
        try
        {
            int a = 10;
            int b = 0;
            int result = a / b;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException )
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        finally
        {
            Console.WriteLine("Finally block executed.");
        }
    }
}*/
//2. 
/*try
        {
            // Simulating an error by throwing a custom exception
            throw new DeliveryFailException("Package not delivered.");
        }
        catch (DeliveryFailException e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        catch (ExceptionRefund ex)
        {
            Console.WriteLine("Not Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("This block always runs.");
        }
        public class DeliveryFailException : Exception
{
    public DeliveryFailException(string message) : base(message) { }
}

public class ExceptionRefund : Exception
{
    public ExceptionRefund(string message) : base(message) { }
}*/
//3. Array index out of bounds
/*class Progrm
{
  static void Main(string[] args)
  {
    try
    {
      int[] numbers = { 1, 2, 3 };
      Console.WriteLine(numbers[5]);
    }
    catch (IndexOutOfRangeException)
    {
      Console.WriteLine("Error: Index is out of range");
    }
    finally
    {
      Console.WriteLine("Clean Up");
    }
  }
}*/

//4. file not found
/*class Program
{
  static void Main(string[] args)
  {
    try
    {
      string content = File.ReadAllText("nonexicient.txt");
      Console.WriteLine(content);
    }
    catch (FileNotFoundException)
    {
      Console.WriteLine("Error: File Not Found");
    }
    finally
    {
      Console.WriteLine("File operation attempted");
    }
  }
}*/

//5. MULTIPLE CATCH BLOCK
/*class Program
{
  static void Main(string[] args)
  {
    try
    {
      string input = null;
      Console.WriteLine(input.Length);
    }
    catch (NullReferenceException )
    {
      Console.WriteLine("Error: Null Reference");
    }
    catch (Exception ex)
    {
      Console.WriteLine("General Error : " + ex.Message);
    }
    finally
    {
      Console.WriteLine("Execution completed");
    }
  }
}*/

//5. No Exception(control flow)
/*class Program
{
  static void Main(string[] args)
  {
    try
    {
      Console.WriteLine("Everything is fine: ");
    }
    catch (Exception)
    {
      Console.WriteLine("Error occured");
    }
    finally
    {
      Console.WriteLine("Always run");
    }
  }
}*/

//lIST<T> DYANAMIC ARRAY
/*class Program
{
  static void Main(string[] args)
  {
    List<string> fruits = new List<string>();
fruits.Add("Apple");
fruits.Add("Banana");
Console.WriteLine(fruits[0]);

  }
}*/
//DICTIONARY<K,V> - KEY VALUE STORE
/*class Program
{
  static void Main(string[] args)
  {
    Dictionary<int, string> students = new Dictionary<int, string>();
    students.Add(101, "Ravi");
    students.Add(102, "Anjel");
    Console.WriteLine(students[101]);
      }
}*/

//QUEUE<T> - FIFO STRUCTURE
/*class Program
{
  static void Main(string[] args)
  {
    Queue<string> tasks = new Queue<string>();
    tasks.Enqueue("Tasks1");
    tasks.Enqueue("Tasks2");
    Console.WriteLine(tasks.Dequeue());
  }
}*/

//STACK<T> - LIFO STRUCTURE
/*class Program
{
  static void Main(string[] args)
  {
    Stack<string> plates = new Stack<string>();
plates.Push("Plate1");
plates.Push("Plate2");
Console.WriteLine(plates.Pop());
  }
}*/

//PROPERTIES ERXAMPLE 1.
/*class Student
{
  private string name;
  public string Name
  {
    get { return name; }
    set { name = value; }
  }
}
class Program
{
  static void Main(string[] args)
  {
    Student s1 = new Student();


        s1.Name = "Anjel";
  }
}*/

//INDEXERS EXAMPLE 2.
/*class BookShelt
{
  private string[] books = new string[10];
  public string this[int index]
  {
    get { return books[index]; }
    set{ books[index] = value; }
  }
}*/

//LAMBDA EXPRESSION EXAMPLE
//1. Basic lambda with function delegate
/*Func<int, int> doubleIt = x => x + 2;
Console.WriteLine(doubleIt(4));

//Lambda with Multiple expression
Func<int, int, int> add = (a, b) => a + b;
Console.WriteLine(add(3, 7));

//Statement lambda with block
Func<int, int> factorial = n =>
{
  int result = 1;
  for (int i = 1; i <= n; i++)
    result *= 1;
  return result;
};
Console.WriteLine(factorial(5));

//Lambda with LINQ filtering
List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6 };
var even = nums.Where(n => n % 2 == 0);
foreach (var e in even)
{
  Console.WriteLine(e);
}

//Lambda with sorting
List<string> names = new List<string> { "Anjel", "Zara", "Bob", "Charlie" };
names.Sort((a, b) => a.Length.CompareTo(b.Length));
foreach (var name in names)
  Console.WriteLine(name);

//Lambda with event handling
//button.Click += (sender, e) => Console.WriteLine("Button clicked!");

//Lambda with delegate


//EXAMPLES 1.
Func<string, string> chaiOrder = taste => "Serving" + taste + "chai";
Console.WriteLine(chaiOrder("Kadak"));

//EXAMPLE 2.
Func<string, string> snackOrder = item => "Giving You" + item;
Console.WriteLine(snackOrder("Smosa"));*/

//SMALL PROJECTS LAMBDA EXPRESSION
/*class Student
{
  public string Name { get; set; }
  public int Grade { get; set; }
}

class Program
{
  static void Main()
  {
    List<Student> students = new List<Student>
    {
      new Student { Name = "Anjali", Grade = 85 },
            new Student { Name = "Ravi", Grade = 72 },
            new Student { Name = "Neha", Grade = 90 },
            new Student { Name = "Amit", Grade = 65 }
   };
    var topStudents = students.Where(s => s.Grade >= 80).ToList();

    Console.WriteLine("top students");
    topStudents.ForEach(s => Console.WriteLine($"{s.Name} - {s.Grade}"));
  }
}*/

//EXAMPLE PRATICE IN CLASSES AND OBJECTS
/*public class Car
{
  public string brand { get; set; }
  public string Model { get; set; }
  public int Year { get; set; }
}

class Program
{
  static void Main(string[] args)
  {
    Car mustang = new Car();
    mustang.brand = "Ford";
    mustang.Model = "Mustang";
    mustang.Year = 2020;
    Console.WriteLine("Brand" + mustang.brand);
    Console.WriteLine("Mustang" + mustang.Model);
    Console.WriteLine("Year" + mustang.Year);
  }
}*/

//2.
/*class Student
{
  public string Name { get; set; }
  public int RollNumber { get; set; }
  public string Branch { get; set; }
  public void DisplayStudentInfo()
  {
    Console.WriteLine("Student Information");
    Console.WriteLine($"Name: {Name}");
    Console.WriteLine($"RollNumber: {RollNumber}");
    Console.WriteLine($"Branch: {Branch}");
  }
}

class Program
{
  static void Main(string[] args)
  {
    Student Students1 = new Student();
    Students1.Name = "Anjel";
    Students1.RollNumber = 4;
    Students1.Branch = "BCA";

    Students1.DisplayStudentInfo();
    Console.WriteLine();
  }
}*/

//3.
/*class Book
{
  public string Chapter { get; set; }
  public string Theme { get; set; }
  public string Topic { get; set; }
  public int Character { get; set; }

  public void DisplayBookInfo()
  {
    Console.WriteLine("Book Information");
    Console.WriteLine($"Chapter: {Chapter}");
    Console.WriteLine($"Theme: {Theme}");
    Console.WriteLine($"Topic: {Topic}");
    Console.WriteLine($"Character: {Character}");

  }
}

class Program
{
  static void Main(string[] args)
  {
    Book book1 = new Book();
    book1.Chapter = "The Last Lesson";
    book1.Theme = "god to pray";
    book1.Topic = "The Enevelop";
    book1.Character = 4;

    book1.DisplayBookInfo();
    Console.WriteLine();


  }
}*/

//4.
/*public class Car
{
  public string Make;
  public string Model;
  public int Year;
  public string Color;
  public double speed;
  public bool IsEngineOn;

  public void StartEngine()
  {
    IsEngineOn = true;
    Console.WriteLine("Engine Started");

  }
  public void stopEngine()
  {
    IsEngineOn = false;
    speed = 0;
    Console.WriteLine("Engine stoped");
  }
  public void Accelerate(double increment)
  {
    if (IsEngineOn)
    {
      speed += increment;
      Console.WriteLine($"Accelerated to {speed} km/h");
    }
    else
    {
      Console.WriteLine("Can not Accelerate");
    }
  }
  public void Honk()
  {
    Console.WriteLine("beep beep");
  }
  public void Brake()
  {
    speed = 0;
    Console.WriteLine("Stopped");
  }
  
}

class Program
{
  static void Main(String[] args)
  {
    Car car1 = new Car();
    car1.Make = "Honda";
    car1.Model = "Civin";
    car1.Year = 2019;
    car1.Color = "Black";
    car1.speed = 60;
    car1.IsEngineOn = false;

    car1.StartEngine();
    car1.stopEngine();
    car1.Accelerate(10);
    car1.Honk();
    car1.Brake();
    Console.WriteLine();

  }
 }*/

//5.
/*public class Dog
{
  public string Breed;
  public string Color;
  public int Year;
  public string Food;

  public void DogModel()
  {
    Console.WriteLine($"Breed: {Breed}");
    Console.WriteLine($"Color: {Color}");
    Console.WriteLine($"Year: {Year}");
    Console.WriteLine($"Food: {Food}");
  }
 }

class Program
{
  static void Main(string[] args)
  {
    Dog dog1 = new Dog();
    dog1.Breed = "Pitbul";
    dog1.Color = "White";
    dog1.Year = 2022;
    dog1.Food = "Bone and Meet";

    dog1.DogModel();
    Console.WriteLine();
  }
 }*/

//6.
/*public class SmartPhone
{
  public string Company;
  public string Model;
  public string strongGB;
  public int gurantee;

  public void Phone()
  {
    Console.WriteLine($"Company: {Company}");
    Console.WriteLine($"Model: {Model}");
    Console.WriteLine($"strongGB: {strongGB}");
    Console.WriteLine($"gurantee: {gurantee}");
  }
  
 }

class Program
{
  static void Main(string[] args)
  {
    SmartPhone phone1 = new SmartPhone();
    phone1.Company = "Realme16c";
    phone1.Model = "GalaxyS1";
    phone1.strongGB = "16mb";
    phone1.gurantee = 5;

    phone1.Phone();
    Console.WriteLine();
  }
 }*/

//7.
/*public class ShoppingCart
{
  public int ProductID;
  public string Name;
  public decimal Price;
  public int Quantity;

  public void DisplayShopping()
  {
    Console.WriteLine($"ProductID: {ProductID}");
    Console.WriteLine($"Name: {Name}");
    Console.WriteLine($"Price: {Price}");
    Console.WriteLine($"Quantity.: {Quantity}");
  }
 }

class Program
{
  public static void Main(string[] args)
  {
    ShoppingCart Shopping1 = new ShoppingCart();
    Shopping1.ProductID = 1;
    Shopping1.Name = "Anjel Malik";
    Shopping1.Price = 234.0m;
    Shopping1.Quantity = 2;

    Shopping1.DisplayShopping();
    Console.WriteLine();

  }
}*/

// EXAMPLE CONSTRUCTOR
/*public class Book
{
  public string Title;
  public string Author;
  public bool IsAvailable;

    public Book(string title, string author)
    {
 ]       Title = title;              
        Author = author;           
        IsAvailable = true;         
    }
}
class Program
{
  static void Main(string[] args)
  {
    Book myNewBook = new Book("The C# Way", "John Doe");

Console.WriteLine("Title: " + myNewBook.Title);
Console.WriteLine("Author: " + myNewBook.Author);
Console.WriteLine("Available: " + myNewBook.IsAvailable);

  }
}*/

//1.
/*public class User
{
  public string Username;
  public string Email;
  public int ID;

   public User(string username, string email, int Id)
    {
        Username = username;
        Email = email;
    Id = 0;
    }
}
class Program
{
  static void Main(string[] args)
  {
    User myNewUser = new User("Anjel Chaudhary", "anjelchaudhary28@gmail.com", 1);
    Console.WriteLine($"Username: " + myNewUser.Username);
    Console.WriteLine($"Email: " + myNewUser.Email);
    Console.WriteLine($"ID: " + myNewUser.ID);
  }
}*/

//2. private constructor
/*public class Logger
{
  private static readonly Logger instance = new Logger();

  private Logger()
  {
    Console.WriteLine("Logger instance created");
  }
  public static Logger Instance
  {
    get
    {
      return instance;
    }
  }
  public void Log(string message)
  {
    Console.WriteLine($"[LOG]: {message}");
  }
}

class Program
{
  static void Main(string[] args)
  {
    Logger Logger1 = Logger.Instance;
    Logger Logger2 = Logger.Instance;

    Logger1.Log("Application instead");
    Logger2.Log("User Logged in");

    Console.WriteLine(ReferenceEquals(Logger1, Logger2));
  }
}*/

//DESTRUCTOR EXAMPLE
/*class FileHandler
{
    private FileStream file;

    public FileHandler(string filePath)
    {
        file = new FileStream(filePath, FileMode.Open);
        Console.WriteLine("File opened.");
    }

    ~FileHandler()
    {
        file.Close();
        Console.WriteLine("File closed in destructor.");
    }
}

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Program Started");
    FileHandler handler = new FileHandler("example.txt");

    handler = null;
    GC.Collect();
    GC.WaitForPendingFinalizers();

    Console.WriteLine("Program Ended");
  }
}*/

//2.

/*class Geeks
{
    public Geeks()
    {
        Console.WriteLine("Object Created.");
    }

    ~Geeks()
    {
        Console.WriteLine("Object Destroyed.");
    }

    public void DisplayMessage()
    {
        Console.WriteLine("Message Printed.");
    }

  public static void Main()
  {
    Geeks g = new Geeks();
    g.DisplayMessage();
        
    }
}*/

//3.
/*class Complex
{
  private int real, img;
  public Complex()
  {
    real = 0;
    img = 0;
  }
  public void SetValue(int r, int i)
  {
    real = r;
    img = i;
  }
  public void DisplayValue()
  {
    Console.WriteLine($"Real = {real}, Imaginary = {img}");
  }
  ~Complex()
  {
    Console.WriteLine("Object Destroyed");
  }
}
class Greek
{
  static void Main()
  {
    Complex c = new Complex();
    c.SetValue(2, 3);
    c.DisplayValue();
  }
}*/

//4.
/*class FileHandler
{
  private FileStream stream;
  public FileHandler(string fileName)
  {
    stream = new FileStream(fileName, FileMode.OpenOrCreate);
    Console.WriteLine("File Opened");
  }
  ~FileHandler()
  {
    stream.Close();
    Console.WriteLine("Closed File");
  }
}
class Program
{
  static void Main()
  {
    FileHandler myFile = new FileHandler("example.txt");
     Console.WriteLine("Main method finished. Press any key to exit.");
        Console.ReadKey();
  }
}*/

//5.
/*class Logger
{
  public Logger()
  {
    Console.WriteLine("Logger Intalized");
  }
  public void Log(string message)
  {
    Console.WriteLine($"Log: {message}");
  }
  ~Logger()
  {
    Console.WriteLine("logger cleaned Up");
  }
}
class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Application started");

    Logger mylogger = new Logger();
    mylogger.Log("This is a test message");

    Console.WriteLine("Applicatin finished");

  }
}*/

//6.
/*public class NetworkClient
{
  private Socket _socket;
  public NetworkClient(string host, int port)
  {
    _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    _socket.Connect(host, port);
    Console.WriteLine("NetworkClient created and connected");
  }

  public void SendData(string data)
  {
    Console.WriteLine($"Sending data: {data}");
  }

  ~NetworkClient()
  {
    if (_socket != null && _socket.Connected)
    {
      _socket.Shutdown(SocketShutdown.Both);
      _socket.Close();
      _socket = null;
      Console.WriteLine("NetworkClient destructor called. Socket closed.");
    }
  }
}
class Program
{
  static void Main()
  {
    Console.WriteLine("Starting the application...");

    var client = new NetworkClient("127.0.0.1", 8080);
    try
    {
      client.SendData("Hello, Server!");

    }
    finally
    {
     
      client = null;
    }
        
        Console.WriteLine("Application finished. The garbage collector will now decide when to clean up the object.");
        Console.ReadKey(); 
  }
}*/

//PUBLIC ACCESS MODIFIER 1.
/*public class VendingMachine
{
  public void InsertCoin(int amount)
  {
    Console.WriteLine("Coin insert " + amount);
  }
  public void PressButton(string productcode)
  {
    Console.WriteLine("Press Button " + productcode);
  }

}
class Program
{
  static void Main()
  {
    VendingMachine vendingmachine1 = new VendingMachine();
    vendingmachine1.InsertCoin(1);
    vendingmachine1.PressButton("A1");
  }
}*/

//2.
/*class Product
{
  public string Name;
  public double price;
  public int stock;
  public void DisplayProduct()
  {
    Console.WriteLine($"Product Name: {Name}");
    Console.WriteLine($"Product Price: {price}");
    Console.WriteLine($"Product Stock: {stock}");
  }
}
class Program
{
  static void Main(string[] args)
  {
    Product product1 = new Product();
    product1.Name = "Laptop";
    product1.price = 3000.00;
    product1.stock = 5;

    product1.DisplayProduct();
  }
}*/

//3.
/*class MathUtills
{
  public int Add(int a, int b)
  {
    return a + b;
  }
  public int Subtract(int a, int b)
  {
    return a - b;
  }
  public int Multiply(int a, int b)
  {
    return a * b;
  }
}
class Program
{
  static void Main(string[] args)
  {
    MathUtills math = new MathUtills();
    int sum = math.Add(5, 4);
    int subtract = math.Subtract(8, 1);
    int multiply = math.Multiply(4, 5);

    Console.WriteLine($"Sum: " + sum);
    Console.WriteLine($"Subtract: " + subtract);
    Console.WriteLine($"Multiply: " + multiply);

  }
}*/

/*class UserInterface
{
  public string Name;
  public string email;

  public void Data()
  {
    Console.WriteLine($"Name: {Name}");
    Console.WriteLine($"Email: {email}");
  }
}
class Program
{
  static void Main(string[] args)
  {
    UserInterface user1 = new UserInterface();
    user1.Name = "Lakshya panwar";
    user1.email = "lakshyapanwar21@gmail.com";

    user1.Data();
  }
}*/

//PRIVATE ACCESS MODIFIER EXAMPLE 1.
/*public class BankAccount
{
  private decimal balance;
  public BankAccount(decimal initialbalance)
  {
    balance = initialbalance;

  }
  public void Deposit(decimal amount)
  {
    if (amount > 0)
    {
      balance += amount;
      Console.WriteLine($"Deposit: {amount}. New balance: {balance}");
    }
    else
    {
      Console.WriteLine("Invalid Deposit amount");
    }
  }
  public decimal GetBalance()
  {
    return balance;
  }
}
class Program
{
  static void Main()
  {
    BankAccount b = new BankAccount(100m);
    b.Deposit(500m);

    decimal currentbalance = b.GetBalance();
    Console.WriteLine($"CurrentBalance: {currentbalance}");
  }
}*/

//2.
/*public class Car
{
  private int _rpm;
  public int RPM
  {
     get { return _rpm; }
  }

  private void IncreaseRpm(int change)
  {
    if (_rpm + change <= 8000)
    {
      _rpm += change;
      Console.WriteLine($"RPM increased to {_rpm}");
    }
    else
    {
      Console.WriteLine("Engine readLine! Cannot increase further");
    }
  }


  public void Accelerate()
  {
    IncreaseRpm(500);

  }
}

class Program
{
  static void Main(string[] args)
  {
    Car myCar = new Car();

    Console.WriteLine($"Intially RPM: {myCar.RPM} ");

    myCar.Accelerate();
    myCar.Accelerate();

    
  }
}*/

/*public class Television
{
  private bool _isOn = false;
  private int _currentChannel;

  private void PowerOn()
  {
    _isOn = true;
    Console.WriteLine("start Television");
  }
  private void PowerOff()
  {
    _isOn = false;
    Console.WriteLine("stop Television");
  }

  public void ChangeChannel(int newChannel)
  {
    if (!_isOn)
    {
      PowerOn();
    }
    else
    {
      _currentChannel = newChannel;
      Console.WriteLine($"channel {newChannel} change");
    }
  }
  public void TogglePower()
  {
    if (!_isOn)
    {
      PowerOff();
    }
    else
    {
      PowerOn();
    }
  }
}
class Program
{
  static void Main(string[] args)
  {
    Television myTv = new Television();
    myTv.TogglePower();
    myTv.TogglePower();
  }
}*/

//3.
/*public class Player
{
  private int healthPoints;
  private int score;

  public void TakeDamage(int damage)
  {
    healthPoints -= damage;
    Console.WriteLine($"Player took {damage} damage. Health now: {healthPoints}");
  }
  public void AddScore(int points)
  {
    healthPoints += points;
    Console.WriteLine($"Player gained {points} points. Score now: {score}");
  }
}
class Program
{
  static void Main(string[] args)
  {
    Player player1 = new Player();

    player1.TakeDamage(20);
    player1.AddScore(50);
  }
}*/

//PROTECTED ACCESS MODIFIER EXAMPLE
//1.
/*public class Vehicle
{
 protected int engineSize = 1200;
 public void DisplayVehicleInfo()
 {
   Console.WriteLine($"The Vehicle has an engine size of {engineSize}ccc");
 }
 }
public class Car : Vehicle
{
 public void DisplayCarInfo()
 {
   Console.WriteLine($"The car 's engine size is {engineSize}cc");
   }
 }
public class Program
{
 static void Main(string[] args)
 {
   Car myCar = new Car();
   myCar.DisplayCarInfo();

   Vehicle myVehicle = new Vehicle();
   myVehicle.DisplayVehicleInfo();
   }
 }*/


//2.
/*public class Account
{
  protected decimal _balance;

  public Account(decimal initialBalance)
  {
    initialBalance += _balance;
  }

  protected virtual void CalculateInterest()
  {
  }
  public decimal GetBalance()
  {
    return _balance;
  }
}
public class SavingsAccount : Account
{
  public SavingsAccount(decimal initialBalance) : base(initialBalance)
  {
  }
  protected override void CalculateInterest()
  {
    decimal interestRate = 0.05m;
    decimal interest = _balance * interestRate;
    _balance += interest;
    Console.WriteLine($"Savings account me {interest} la interest joda gaya. Naya balance : {_balance}");
  }
  public void AddInterest()
  {
    CalculateInterest();
    }
  }
public class CurrentAccount : Account
{
  public CurrentAccount(decimal initialBalance) : base(initialBalance)
  {
  }
  protected override void CalculateInterest()
  {
    Console.WriteLine("Currennt account me koi interest nhii joda jata hai");
  }
  public void AddInterest()
  {
    CalculateInterest();
    }
  }
class Program
{
  static void Main(string[] args)
  {
      SavingsAccount mySavings = new SavingsAccount(10000);
    Console.WriteLine($"Shuruati savings balance: {mySavings.GetBalance()}");

    mySavings.AddInterest(); // Public method ko call kar rahe hain
    Console.WriteLine($"Naya savings balance: {mySavings.GetBalance()}");

    Console.WriteLine("---------------------");
        

        CurrentAccount myCurrent = new CurrentAccount(50000);
        Console.WriteLine($"Shuruati current balance: {myCurrent.GetBalance()}");

        myCurrent.AddInterest(); // Public method ko call kar rahe hain
        Console.WriteLine($"Naya current balance: {myCurrent.GetBalance()}");
  }
  }*/

//3.
/*public class Car
{
  protected string name = "nano";
  public void DisplayCar()
  {
    Console.WriteLine("Car's name: " + name);
  }
  }
public class Bike : Car
{
  public void DisplayBike()
  {
    Console.WriteLine("Bike's name: " + name);
  }
}
class Program
{
  static void Main(string[] args)
  {
    Bike bike1 = new Bike();

    bike1.DisplayBike();
    bike1.DisplayCar(); 
  }
}*/

//4.
/*public class Character
{
  protected int health;
  public Character(int initialhealth)
  {
    this.health = initialhealth;
  }
  protected virtual void TakeDamage(int amount)
  {
    this.health -= amount;
    Consoleewprice;.WriteLine($"Take Character took {amount} damage. Current health: {this.health}");
  }
}
public class Enemy : Character
{
  public Enemy(int initialhealth) : base(initialhealth)
  {
  }
  protected override void TakeDamage(int amount)
  {
    if (amount < 10)
    {
      Console.WriteLine("Enemy ignored the small damage");
      return;
    }
    this.health -= amount;
    Console.WriteLine($"Enemy Took: {amount} damage. Current health: {this.health}");
  }
}*/

//5.
/*public class Book
{
    protected decimal price;

    public void SetPrice(decimal newPrice)
    {
        
        if (newPrice < 0)
        {
            Console.WriteLine("Price cannot be negative. Setting to 0.");
            price = 0;
        }
        else
        {
            this.price = newPrice;
        }
    }

    public decimal GetPrice()
    {
        return this.price;
    }
}

public class Ebook : Book
{
    public void ApplyDiscount(decimal discountPercentage)
    {
        if (discountPercentage > 1 || discountPercentage < 0)
        {
            Console.WriteLine("Invalid discount percentage.");
            return;
        }
        
        this.price = this.price * (1 - discountPercentage);
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Ebook myEbook = new Ebook();

        
        myEbook.SetPrice(50.00m);
        Console.WriteLine($"Original price of the ebook: {myEbook.GetPrice():C}");

        myEbook.ApplyDiscount(0.20m); 
        Console.WriteLine($"Price after a 20% discount: {myEbook.GetPrice():C}");

        
    }
}*/

//6.
/*namespace Myproject.Utilities
{
  public class Logger
  {
    public void logger()
    {
      Console.WriteLine("It is a Anjel Malik");
    }
  }
}
namespace ThirdParty.Logging
{
  public class Logger
  {
    public void logger()
    {
      Console.WriteLine("It ia a Anjel Chaudhary");
    }
  }
}
class Program
{
  static void Main(string[] args)
  {
    Myproject.Utilities.Logger myLogger = new Myproject.Utilities.Logger();
    ThirdParty.Logging.Logger thirdPartyLogger = new ThirdParty.Logging.Logger();
     }
}*/

//INHERITANCE CLASS - 1. BASE AND DERIVED CLASS
/*class Animal
{
  public void Eat()
  {
    Console.WriteLine("The animal is eating");
  }
}
class Dog : Animal
{
  public void Bark()
  {
    Console.WriteLine("The dog is barking");
  }
}
class Program
{
  static void Main(string[] args)
  {
    Dog myDog = new Dog();
    myDog.Bark();
    myDog.Eat();
  }
}*/

//PUBLIC CLASS INHERTANCE EXAMPLE
/*public class Vehicle
{
  public string Brand { get; set; }
  public void StartEngine()
  {
    Console.WriteLine($"{Brand}'s engine is starting");
  }
}
public class Car : Vehicle
{
  public int NumberOfDoors { get; set; }
  public void Honk()
  {
    Console.WriteLine("Honk! Honk!");
  }
}
class Program
{
  static void Main(string[] args)
  {
    Car myCar = new Car();
    myCar.Brand = "Toyato";
    myCar.StartEngine();
    myCar.NumberOfDoors = 4;
    myCar.Honk();

    Console.WriteLine($"My Car is a {myCar.Brand} with {myCar.NumberOfDoors}");
  }
}*/

//PROTECTED INHERITANCE CLASS - 1. EXAMPLE
/*  class BankAccount
{
  protected decimal balance;
  public BankAccount(decimal initialBalance)
  {
    balance = initialBalance;
  }
  protected void CalculateInterest()
  {
    decimal interest = balance * 0.04m;
    balance += interest;
    Console.WriteLine($"Interest  added: {interest: C}");
  }
  public void ShowBalance()
  {
    Console.WriteLine($"Current Balance: {balance: C}");
  }
}


class SavingsAccount : BankAccount
{
  public SavingsAccount(decimal initialBalance) : base(initialBalance) { }

  public void ApplyInterest()
  {

    CalculateInterest();
  }
}
class Program
{
  static void Main(string[] args)
  {
    SavingsAccount myAccount = new SavingsAccount(1000);
    myAccount.ShowBalance();
    myAccount.ApplyInterest();
    myAccount.ShowBalance();
  }
}*/

//2.
/*public class Patient
{
  protected string MedicalHistory()
  {
    return "Typhide , Infection";
  }

}
public class Doctors : Patient
{
  public void PatientHistory()
  {
    string history = MedicalHistory();
    Console.WriteLine("Patient History: " + history);
  }
}
class Program
{
  static void Main()
  {
    Doctors doctor = new Doctors();
    doctor.PatientHistory();
  }
}*/

//3.
/*public class Student
{
  protected string PrivateDetails()
  {
    return "Name: Rahul, Grade: A+, Address: Kanpur";
  }
}
public class TeacherPortal : Student
{
  public void ShowDetails()
  {
    string details = PrivateDetails();
    Console.WriteLine("Teacher's view: " + details);
  }
}
class Program
{
  static void Main()
  {
    TeacherPortal teacher = new TeacherPortal();
    teacher.ShowDetails();
  }
}*/

//4.
/*public class Login
{
  protected string Details()
  {
    return "usename: Anjel Chaudhary, password: anjel28@";
  }
}
public class Form : Login
{
  public void ShowDetails()
  {
    string details = Details();
    Console.WriteLine("Login : " + details);
  }
}
class Program
{
  static void Main()
  {
    Form form = new Form();
    form.ShowDetails();
  }

}*/

//POLYMORPHISM EXAMPLES - 1.
/*class Calculator
{
  public int Add(int a, int b)
  {
    return a + b;
  }
  public double Add(double a, double b)
  {
    return a + b;
  }
}
class Program
{
  static void Main(string[] args)
  {
    Calculator calculator = new Calculator();

    int resultINT = calculator.Add(5, 10);
    Console.WriteLine($"Integer Addition Result: {resultINT}");

    double resultDOUBLE = calculator.Add(10.5, 12.5);
    Console.WriteLine($"Double Addition Result: {resultDOUBLE}");

  }
}*/

//2.
/*public class HospitalStaff
{
  public virtual void PerformDuty()
  {
    Console.WriteLine("Hospital staff is performing duty");
  }

}
public class Doctor : HospitalStaff
{
  public override void PerformDuty()
  {
    Console.WriteLine("Doctor is diagonsing");
  }

}
public class Nurse : HospitalStaff
{
  public override void PerformDuty()
  {
    Console.WriteLine("Nurse is caring for patient");
  }
}
public class Surgeon : HospitalStaff
{
  public override void PerformDuty()
  {
    Console.WriteLine("Surgeon treats for operation");
    }
}
class Program
{
  static void Main()
  {
    HospitalStaff staff1 = new Doctor();
        HospitalStaff staff2 = new Nurse();
        HospitalStaff staff3 = new Surgeon();

        staff1.PerformDuty();  
        staff2.PerformDuty(); 
        staff3.PerformDuty();  
  }
}*/

//2.
/*public abstract class PaymentMethod
{
   
    public decimal Amount { get; set; }

   
    public PaymentMethod(decimal amount)
    {
        Amount = amount;
    }

       public abstract void ProcessPayment();

   
    public void DisplayPaymentDetails()
    {
        Console.WriteLine($"Initiating payment for: {Amount:C}");
    }
}

public class CreditCard : PaymentMethod
{
    public string CardNumber { get; set; }

    public CreditCard(decimal amount, string cardNumber) : base(amount)
    {
        CardNumber = cardNumber;
    }

    
    public override void ProcessPayment()
    {
        DisplayPaymentDetails(); 
        Console.WriteLine($"-> Processing **Credit Card** payment for {Amount:C}.");
        Console.WriteLine($"-> Transaction authorized for card ending in {CardNumber.Substring(CardNumber.Length - 4)}.");
       
    }
}

public class PayPal : PaymentMethod
{
    public string Email { get; set; }

    public PayPal(decimal amount, string email) : base(amount)
    {
        Email = email;
    }

    
    public override void ProcessPayment()
    {
        DisplayPaymentDetails();
        Console.WriteLine($"-> Processing **PayPal** payment for {Amount:C}.");
        Console.WriteLine($"-> User verification required for email: {Email}.");
        
    }
}


public class UPI : PaymentMethod
{
    public string VPA { get; set; }

    public UPI(decimal amount, string vpa) : base(amount)
    {
        VPA = vpa;
    }

    
    public override void ProcessPayment()
    {
        DisplayPaymentDetails();
        Console.WriteLine($"-> Processing **UPI** payment for {Amount:C}.");
        Console.WriteLine($"-> Sending payment request to VPA: {VPA}. Waiting for confirmation.");
       
    }
}


public class PaymentDemo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Payment Processor Simulation ---");

        
        PaymentMethod creditCardPayment = new CreditCard(1500.75m, "1234-5678-9012-3456");
        PaymentMethod payPalPayment = new PayPal(299.99m, "student@example.com");
        PaymentMethod upiPayment = new UPI(500m, "myname@ybl");

        Console.WriteLine("\nProcessing Credit Card...");
        creditCardPayment.ProcessPayment();

        Console.WriteLine("\nProcessing PayPal...");
        payPalPayment.ProcessPayment();

        Console.WriteLine("\nProcessing UPI...");
        upiPayment.ProcessPayment();
    }
}*/

//3.
/*public class Vehicle
{
  public virtual void Drive()
  {
    Console.WriteLine("The Vehicle is driving");
  }
}
public class Car : Vehicle
{
  public override void Drive()
  {
    Console.WriteLine("The car is driving smoothly");
  }
}
public class Truck : Vehicle
{
  public override void Drive()
  {
    Console.WriteLine("The truck is hauling heavy load");
  }
}
class Program
{
  static void Main()
  {
    Vehicle vehicle1 = new Car();
    Vehicle vehicle2 = new Truck();

    vehicle1.Drive();
    vehicle2.Drive();
  }
}*/

//3.
/*public class Vehicle
{
  public virtual void Honk()
  {
    Console.WriteLine("Generic vehicle Honk");
  }
}
public class Car : Vehicle
{
  public override void Honk()
  {
    Console.WriteLine("Car horn: beep beep");
  }
}
public class Bike : Vehicle
{
  public override void Honk()
  {
    Console.WriteLine("Bike horn: Peep peep!");
  }
}
class Program
{
  static void Main()
  {
    Vehicle v = new Vehicle();
    v.Honk();

    v = new Car();
    v.Honk();

    v = new Bike();
    v.Honk();

  }
}*/

//4.
/*public class Animal
{
  public virtual void Speak()
  {
    Console.WriteLine("Animal is Speaking");
  }
}
public class Dog : Animal
{
  public override void Speak()
  {
    Console.WriteLine("Dog Says: Woof!");
  }
}
public class Cat : Animal
{
    public override void Speak()
    {
    Console.WriteLine("Cat says: Meow!");
    }
}*/

//ENCAPSULATION CLASS EXAMPLE - 1.
/*public class BankAccount
{
  private double balance;
  public void Deposit(double amount)
  {
    if (amount > 0)
      balance += amount;
  }
  public void WithDraw(double amount)
  {
    if (amount > 0 && amount <= balance)
      balance -= amount;
  }
  public double GetBalance()
  {
    return balance;
  }
}
class Program
{
  static void Main()
  {
    BankAccount account = new BankAccount();
    account.Deposit(10000);
    account.WithDraw(3000);

    Console.WriteLine("Current Balance: " + account.GetBalance());
  }
}*/

//2.
/*public class BankAccount
{
  private int accountNumber;
  private string accountHolderName;
  public BankAccount(int accNumber, string holdername)
  {
    accountNumber = accNumber;
    accountHolderName = holdername;
  }
  public int AccountNumber
  {
    get { return accountNumber; }
  }

  public string AccountHolderName
  {
    get { return accountHolderName; }
    set { accountHolderName = value; }
  }

}
class Program
{
  static void Main()
  {
    BankAccount bankaccount = new BankAccount(12345670, "Rahul Sharma");

    Console.WriteLine("Account Number:  " + bankaccount.AccountNumber);
    Console.WriteLine("Account Holder: " + bankaccount.AccountHolderName); 
     
      bankaccount.AccountHolderName = "Priya Verma";
        Console.WriteLine("Updated Holder: " + bankaccount.AccountHolderName);
  }
}*/

//3.
/*public class Patient
{
  private string name;
  private int age;
  private string medicalHistory;
  public void setPatientDetails(string PatientName, int PatientAge, string history)
  {
    name = PatientName;
    age = PatientAge;
    medicalHistory = history;

  }
  public string GetPatientSummary()
  {
    return $"Name: {name}, age: {age}, ";
  }
  private string GetmedicalHistory()
  {
    return medicalHistory;
  }
}
class Program
{
  static void Main()
  {
    Patient patient = new Patient();
    patient.setPatientDetails("Rahul Sharma", 17, "Typhide, Infection");

    string summary = patient.GetPatientSummary();
    Console.WriteLine(summary);


  }
}*/

//ADVANCED OOPs - INTERFACE
// 1. School
/*public interface ITeacher
{
  void Teach();
  void GiveHomework();
  void TakeAttendance();
}
public class MathTeacher : ITeacher
{
  public void Teach()
  {
    Console.WriteLine("Teaching Mathematics...");
  }
  public void GiveHomework()
  {
    Console.WriteLine("Solve 10 Algebric problems");
  }
  public void TakeAttendance()
  {
    Console.WriteLine("Markig Attendance for Maths Class");
  }
}
class Program
{
  static void Main(string[] args)
  {
    ITeacher teacher = new MathTeacher();
    teacher.Teach();
    teacher.GiveHomework();
    teacher.TakeAttendance();
  }
  

}*/

//2. payment process
/*public interface IPaymentProcessor
{
  void ProcessPayment(decimal amount);
}
public class CreditCardPayment : IPaymentProcessor
{
  public void ProcessPayment(decimal amount)
  {
    Console.WriteLine($"Processing rupee{amount} via Credit Card...");
  }
}
public class UpiPayment : IPaymentProcessor
{
  public void ProcessPayment(decimal amount)
  {
    Console.WriteLine($"processing rupee{amount} via UPI...");
  }
}
class Program
{
  static void Main(string[] args)
  {
    List<IPaymentProcessor> payments = new List<IPaymentProcessor>{
      new CreditCardPayment(),
      new UpiPayment()

    };

    decimal[] amounts = { 1200, 750 };
    for (int i = 0; i < payments.Count; i++) {
      payments[i].ProcessPayment(amounts[i]);
    }
  }
}*/

//3.
/*public interface ISmartHome
{
  void Remote();
  void Wire();
  void Dish();
}
public class TV : ISmartHome
{
  public void Remote()
  {
    Console.WriteLine("Channel Change");
  }
  public void Wire()
  {
    Console.WriteLine("TV connect to board through wire");
  }
  public void Dish()
  {
    Console.WriteLine("Every channel show from the Tv to help the dish");
  }
}
class Program
{
  static void Main(string[] args)
  {
    ISmartHome home = new TV();
    home.Remote();
    home.Wire();
    home.Dish();
  }
}*/

//4.
/*public interface ILogger
{
  void LogInfo(string message);
  void LogWarning(string message);
  void LogError(string message);
}
public class ConsoleLogger : ILogger
{
  public void LogInfo(string message)
  {
    Console.WriteLine($"[INFO] {message}");
  }
  public void LogWarning(string message)
  {
    Console.WriteLine($"[WARNING] {message}");
  }
  public void LogError(string message)
  {
    Console.WriteLine($"[ERROR] {message}");
  }
}
class Program
{
  static void Main(string[] args)
  {
    ILogger logger = new ConsoleLogger();
    logger.LogInfo("System started successfully");
    logger.LogWarning("Low disk space detected");
    logger.LogError("Unable to connect to database");
  }
}*/

//5.
/*public interface IVehicle
{
  void StartRide(string pickup, string drop);
  void EndRide();
  string GetVehicleType();
}
public class Car : IVehicle
{
  public void StartRide(string pickup, string drop)
  {
    Console.WriteLine($"Car ride started from {pickup} to {drop}");
  }
  public void EndRide()
  {
    Console.WriteLine("Car ride ended");
  }
  public string GetVehicleType()
  {
    return "Car";
  }
}
public class Bike : IVehicle {
  public void StartRide(string pickup, string drop)
  {
    Console.WriteLine($"Bike ride started from {pickup} to {drop}");
  }
  public void EndRide()
  {
    Console.WriteLine("Bike ride ended");
  }
  public string GetVehicleType()
  {
    return "Bike";
  }
}
class Program
{
  static void Main(string[] args)
  {
    List<IVehicle> rides = new List<IVehicle>
    {
      new Car(),
      new Bike(),
    };
    string pickup = "Aligarh";
    string drop = "Agra";

    foreach (var ride in rides)
    {
      Console.WriteLine($"Vehicle: {ride.GetVehicleType()}");
      ride.StartRide(pickup, drop);
      ride.EndRide();
      Console.WriteLine();
    }
  }
}*/

//6.
/*public interface IMenuItem
{
    string GetName();
    decimal GetPrice();
}
public class Pizza : IMenuItem
{
    public string GetName()
    {
        return "Margherita Pizza";
    }

    public decimal GetPrice()
    {
        return 299.00m;
    }
}
public class Burger : IMenuItem
{
    public string GetName()
    {
        return "Veg Burger";
    }

    public decimal GetPrice()
    {
        return 149.00m;
    }
}
class Program
{
    static void Main(string[] args)
    {
        List<IMenuItem> order = new List<IMenuItem>
        {
            new Pizza(),
            new Burger()
        };

        decimal total = 0;
        Console.WriteLine("🧾 Your Order:");

        foreach (var item in order)
        {
            Console.WriteLine($"{item.GetName()} - ₹{item.GetPrice()}");
            total += item.GetPrice();
        }

        Console.WriteLine($"\n💰 Total Bill: ₹{total}");
    }
}*/

//7.
/*public interface IUser
{
  void Login(string username, string password);
  void LogOut();
  string GetRole();
}
public class Student : IUser
{
  public void Login(string username, string password)
  {
    Console.WriteLine($"Student '{username}' logged in. '{password}'.");
  }
  public void LogOut()
  {
    Console.WriteLine("Student Logged Out");
  }
  public string GetRole()
  {
    return "Student";
  }
}
public class Teacher : IUser
{
  public void Login(string username, string password)
  {
    Console.WriteLine($"Teacher '{username}' logged in '{password}'.");
  }
  public void LogOut()
  {
    Console.WriteLine("Teacher Logged Out");
  }
  public string GetRole()
  {
    return "Teacher";
  }
}
public class Admin : IUser
{
  public void Login(string username, string password)
  {
    Console.WriteLine($"Admin is '{username}' logged in '{password}'.");
  }
  public void LogOut()
  {
    Console.WriteLine("Admin logged out");
  }
  public string GetRole()
  {
    return "Admin";
  }
}
class Program
{
  static void Main(string[] args)
  {
    List<IUser> users = new List<IUser>
    {
      new Student(),
      new Teacher(),
      new Admin(),
    };
    string username = "rahul123";
    string password = "pass@123";

    foreach (var user in users)
    {
      Console.WriteLine($"Role: {user.GetRole()}");
      user.Login(username, password);
      user.LogOut();
      Console.WriteLine();
    }
  }

}*/

//8.
/*public interface IFileConverter
{
  void Convert(string inputFilePath, string outputFilePath);
  string GetFormat();
}
public class WordToPdfConverter : IFileConverter
{
    public void Convert(string inputFilePath, string outputFilePath)
    {
        Console.WriteLine($"Converting Word file '{inputFilePath}' to PDF at '{outputFilePath}'...");
        
    }

    public string GetFormat()
    {
        return "Word to PDF";
    }
}
public class ExcelToCsvConverter : IFileConverter
{
  public void Convert(string inputFilePath, string outputFilePath)
  {
    Console.WriteLine($"Converting Excel File '{inputFilePath}' to CSV at'{outputFilePath}'");
  }
  public string GetFormat()
  {
    return "Excel To CSV";
  }
}
class Program
{
    static void Main(string[] args)
    {
        List<IFileConverter> converters = new List<IFileConverter>
        {
            new WordToPdfConverter(),
            new ExcelToCsvConverter()
        };

        foreach (var converter in converters)
        {
            Console.WriteLine($"Conversion Type: {converter.GetFormat()}");
            converter.Convert("input.docx", "output.pdf");
            Console.WriteLine();
        }
    }
}*/

//ADVANCED OOPs CLASS EXAMPLE - 1.
/*public abstract class Vehicle
{
  public int speed;
  public void start()
  {
    Console.WriteLine("Vahicle Started");
  }
  public abstract void Drive();
}
public class Car : Vehicle
{
  public override void Drive()
  {
    Console.WriteLine("Car is driving at speed" + speed);
  }
}
public class Bike : Vehicle
{
  public override void Drive()
  {
    Console.WriteLine("Bike is driving at speed" + speed);
  }
}
class Program
{
  static void Main(string[] args)
  {
    Vehicle myCar = new Car();
    myCar.speed = 80;
    myCar.start();
    myCar.Drive();

    Vehicle myBike = new Bike();
    myBike.speed = 60;
    myCar.start();
    myCar.Drive();
  }
}*/

//2.
//INTERFCAE OR ABSTRACT CLASS - DIFFERENCE
/*public abstract class Vehicle
{
  public int speed;
  public string fuelType;
  public void StartEngine()
  {
    Console.WriteLine("Started Engine");
  }
  public void StopEngine()
  {
    Console.WriteLine("Stop Engine");
  }
  public abstract double CalculateMilega();
}
public class Car : Vehicle
{
  public override double CalculateMilega()
  {
    return 15.5;
  }
}
public class Truck : Vehicle
{
  public override double CalculateMilega()
  {
    return 8.0;
  }
}
class Program
{
  static void Main(string[] args)
  {
    Vehicle myCar = new Car();
    myCar.speed = 120;
    myCar.fuelType = "Petrol";

    myCar.StartEngine();
    Console.WriteLine($"speed: {myCar.speed} km/h");
    Console.WriteLine($"fueltype: {myCar.fuelType}");
    myCar.StopEngine();

    Vehicle myTruck = new Truck();
    myTruck.speed = 180;
    myTruck.fuelType = "CNG";
    
     myTruck.StartEngine();
    Console.WriteLine($"speed: {myTruck.speed} km/h");
    Console.WriteLine($"fueltype: {myTruck.fuelType}");
    myTruck.StopEngine();
  } 
}*/

//CONSTRUCTOR CLASS EXAMPLE - 1.
/*abstract class Animal
{
  public string Name;
  //constructor
  public Animal(string name)
  {
    Name = name;
    Console.WriteLine("Animal Constructor Called");
  }

  public abstract void Speak();
}
class Dog : Animal
{
  public Dog(string name) : base(name)
  {
    Console.WriteLine("Dog Constructor Called");
  }
  public override void Speak()
  {
    Console.WriteLine($"{Name} says: Woof!");
  }
}
class Program
{
  static void Main(string[] args)
  {
    Dog myDog = new Dog("Buddy");
    myDog.Speak();
  }
}*/

//METHOD OVERLOADING AND OVERRIDE - EXAMPLE 
//1.
/*class Calculator
{
  public int Add(int a, int b)
  {
    return a + b;
  }
  public double Add(double a, double b)
  {
    return a + b;
  }
  public int Add(int a, int b, int c)
  {
    return a + b + c;
  }
}
class Program
{
    static void Main(string[] args)
    {
    Calculator cal = new Calculator();

    int result1 = cal.Add(5, 10);
    Console.WriteLine("Add(int, int): " + result1);

    double result2 = cal.Add(5.5, 3.2);
    Console.WriteLine("Add(double, double): " + result2);

    int result3 = cal.Add(3, 4, 5);
    Console.WriteLine("Add(int,int,int): "+result3);

    }
}*/

//2.
/*class Restaurant
{
  public void Order(string dish)
  {
    Console.WriteLine($"Ordered Placed: {dish}");
  }
  public void Order(string dish, int Quantity)
  {
    Console.WriteLine($"Ordered Placed: {Quantity} * {dish}");
  }
  public void Order(string dish, int Quantity, int tableNumber)
  {
    Console.WriteLine($"Ordered Placed: {Quantity}*{dish} for Table #{tableNumber}");
  }
}
class Program
{
    static void Main(string[] args)
    {
    Restaurant res = new Restaurant();

    res.Order("Pasta");
    res.Order("Burger", 2);
    res.Order("Pizza", 2, 5); 
    }
}*/

//3.
/*class Machine
{
  public void WithDraw(string DebitCard, int pin, int amount)
  {
    Console.WriteLine("WithDrawel using DebitCard");
    Console.WriteLine($"Card Number: " + DebitCard);
    Console.WriteLine($"PIN: " + pin);
    Console.WriteLine($"Amount: ₹" + amount);
  }
  public void WithDraw(string qrCodeData, int amount)
  {
    Console.WriteLine($"QR code withdrawel");
    Console.WriteLine($"QR Data: {qrCodeData}, Amount: {amount}");
  }
  public void WithDraw(byte[] fingerprintData, double amount)
  {
    Console.WriteLine($"Biometric Authetication WithDrawel");
    Console.WriteLine($"FingerPrint verified, Amount: ₹{amount} ");
  }
  public void WithDraw(long AccountNumber, int pin, double amount)
  {
    Console.WriteLine($"Account Number WithDrrawel");
    Console.WriteLine($"Account: {AccountNumber}, PIN: {pin}, Amount: {amount}");
  }
}
class Program
{
    static void Main(string[] args)
    {
    Machine mac = new Machine();

    mac.WithDraw("1234-456-789", 1234, 5000);
    mac.WithDraw("QR123QAN", 7000);
    mac.WithDraw(new byte[] { 1, 2, 3 }, 1500);
    mac.WithDraw("87918410", 1234, 30900);
    }
}*/

//4.
/*class School
{
  public void Attendance(byte[] fingerprint)
  {
    Console.WriteLine($"FingerPrint Attendance");
    Console.WriteLine($"fingerprint: " + fingerprint);
  }
  public void Attendance(string IDCardNumber)
  {
    Console.WriteLine($"Card Attendance");
    Console.WriteLine($"IDCardNumber: " + IDCardNumber);
  }
    
}
class Program
{
    static void Main(string[] args)
    {
    School school = new School();
    school.Attendance(new byte[] { 1, 2, 3, 4 });
    school.Attendance("ID123456");
    }
}*/

//5.
/*class MessageService
{
    public void SendMessage(string message, string recipient)
    {
        Console.WriteLine($"Sending to single user: {recipient} → {message}");
    }

    public void SendMessage(string message, List<string> recipients)
    {
        foreach (var recipient in recipients)
        {
            Console.WriteLine($"Sending to user: {recipient} → {message}");
        }
    }

    public void SendMessageToGroup(string message, string groupName, List<string> groupMembers)
    {
        Console.WriteLine($"Sending to group '{groupName}':");
        foreach (var member in groupMembers)
        {
            Console.WriteLine($" → {member}: {message}");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        MessageService service = new MessageService();

        
        service.SendMessage("Hello Alice!", "Alice");

        
        var users = new List<string> { "Bob", "Charlie", "Diana" };
        service.SendMessage("Hello everyone!", users);

        
        var groupMembers = new List<string> { "Eve", "Frank", "Grace" };
        service.SendMessageToGroup("Team meeting at 3 PM", "Dev Team", groupMembers);
    }
}*/

//METHOD OVERRIDE 
//1.
/*class Animal
{
  public virtual void MakeSound()
  {
    Console.WriteLine("Some generic animal sound");
  }
}
class Dog : Animal
{
  public override void MakeSound()
  {
    Console.WriteLine("Dog");
  }
}
class Cat : Animal
{
  public override void MakeSound()
  {
    Console.WriteLine("Meow");
  }
}
class Program
{
    static void Main(string[] args)
    {
    Animal myAnimal = new Animal();
    Animal myDog = new Dog();
    Animal myCat = new Cat();

    myDog.MakeSound();
    myCat.MakeSound();
    myAnimal.MakeSound();
    }
}*/

//2.
/*class Vehicle
{
  public virtual void Start()
  {
    Console.WriteLine("Some Vehicle  start horn");
  }
}
class Car: Vehicle
{
    public override void Start()
    {
    Console.WriteLine("peon peon");
    }
}
class Program
{
    static void Main(string[] args)
    {
    Vehicle myVehicle = new Vehicle();
    Vehicle myCar = new Car();

    myVehicle.Start();
    myCar.Start();
    
    }
}*/

//3.
/*class Printer
{
  public virtual void Print()
  {
    Console.WriteLine("Print any form text and space");
  }
}
class InkjetPrinter : Printer
{
  public override void Print()
  {
    Console.WriteLine("this is a computer printer and printout the image/text with small dots of in ink added to it ");

  }

}
class LaserPrinter : Printer
{
  public override void Print()
  {
    Console.WriteLine("It Print high-quality text and graphics quickly.This is laser technology");
  }

}
class Program
{
    static void Main(string[] args)
    {
    Printer myPrinter = new Printer();
    Printer myInkjetPrinter = new InkjetPrinter();
    Printer myLaserPrinter = new LaserPrinter();

    myPrinter.Print();
    myInkjetPrinter.Print();
    myLaserPrinter.Print();
    }
}*/

//4.
/*class Emplyoee
{
  public string Name { get; set; }
  public Double BaseSalary { get; set; }

  public Emplyoee(string name, Double baseSalary)
  {
    Name = name;
    BaseSalary = baseSalary;

  }
  public virtual double CalculateSalary()
  {
    return BaseSalary;
  }

}
class Manager : Emplyoee
{
  public double Bonus { get; set; }
  public Manager(string name, double baseSalary, double bonus) : base(name, baseSalary)
  {
    Bonus = bonus;
  }
  public override double CalculateSalary()
  {
    return BaseSalary + Bonus;
  }
}
class Developer : Emplyoee
{
  public int OvertimeHours { get; set; }
  public int RatePerHour { get; set; }
  public Developer(string name, double baseSalary, int overtimeHours, int ratePerHour) : base(name, baseSalary)
  {
    OvertimeHours = overtimeHours;
    RatePerHour = ratePerHour;
  }
  public override double CalculateSalary()
  {
    return BaseSalary + (OvertimeHours * RatePerHour);
  }
}
class Program
{
    static void Main(string[] args)
    {
    Emplyoee emp1 = new Manager("Ravi", 50000, 10000);
    Emplyoee emp2 = new Developer("Priya", 40000, 10, 500);

    Console.WriteLine($"{emp1.Name}'s Salary: ₹{emp1.CalculateSalary()}");
    Console.WriteLine($"{emp2.Name}'s Salary: ₹{emp2.CalculateSalary()}");
    }
}*/

//5.
/*class Shape
{
  public virtual void Draw()
  {
    Console.WriteLine("Drawing a Generic Shape");
  }
}
class Circle : Shape
{
  public override void Draw()
  {
    Console.WriteLine("Drawing a Circle with Radius and centre...");
  }
}
class Rectangle : Shape
{
  public override void Draw()
  {
    Console.WriteLine("Drawing a Rectangle with width and height...");
  }
}
class Program
{
    static void Main(string[] args)
    {
    Shape shape = new Shape();
    Shape Circle = new Circle();
    Shape Reactangle = new Rectangle();

    shape.Draw();
    Circle.Draw();
    Reactangle.Draw();
    }
}*/

//6. - METHOD HIDING
/*class BasicRemote
{
  public void OperateTV()
  {
    Console.WriteLine("TV is turned ON/OFF");
  }
}
class AdvanceRemote : BasicRemote
{
  public new void OperateTV()
  {
    Console.WriteLine("TV is turned ON/OFF with your youtube access");
  }
}
class Program
{
    static void Main(string[] args)
    {
    BasicRemote remote1 = new BasicRemote();
    remote1.OperateTV();

    AdvanceRemote remote2 = new AdvanceRemote();
    remote2.OperateTV();

    BasicRemote remote3 = new AdvanceRemote();
    remote3.OperateTV();
    }
}*/

//7. - with override
/*public class Animal
{
  public virtual void Speak()
  {
    Console.WriteLine("Animal speaks make sound");
  }
}
public class Dog: Animal
{
    public override void Speak()
    {
    Console.WriteLine("Dog barks");
    }
}
class Program
{
    static void Main(string[] args)
    {
    Animal animal = new Animal();
    Animal Dog = new Dog();

    animal.Speak();
    Dog.Speak();
    }
}*/

//8. without override
/*public class Animal
{
  public virtual void Speak()
  {
    Console.WriteLine("Animal make sound");
  }
}
public class Dog
{
  public void Speak()
  {
    Console.WriteLine("Dog barks");
  }
}
class Program
{
    static void Main(string[] args)
    {
    Animal mypet = new Dog();
    mypet.Speak();
    }
}*/

//9.
/*class Notification
{
  public virtual void Send()
  {
    Console.WriteLine("Notifications send ");
  }
}
class EmailNotification : Notification
{
  public override void Send()
  {
    Console.WriteLine("open the notification of email");
  }
}
class SMSNotification : Notification
{
  public override void Send()
  {
    Console.WriteLine("notificaftion come without network");
  }
}
class Program
{
    static void Main(string[] args)
    {
    Notification notification = new Notification();
    Notification notification1 = new EmailNotification();
    Notification notification2 = new SMSNotification();

    notification.Send();
    notification1.Send();
    notification2.Send();
    }
}*/

// METHOD OVERLOADING -EXAMPLES 
//1. - caculatoe app
/*class Calculator
{
  public int Add(int a, int b)
  {
    return a + b;
  }
  public int Add(int a, int b, int c)
  {
    return a + b + c;
  }
}
class Program
{
static void Main(string[] args)
  {
    Calculator calculator = new Calculator();

    int result1 = calculator.Add(10, 20);
    Console.WriteLine("Addition of 10 and 20 is: " + result1);

    int result2 = calculator.Add(30, 10, 20);
    Console.WriteLine("Adittion of 30,10 and 20 is: " + result2);
    }
}*/

//2.
/*class BankAccount
{
  public string AccountHolder;
  public double Balance;
  public void Deposit(int amount)
  {
    Balance += amount;
    Console.WriteLine($"cash deposit: ₹{amount}. new balance: ₹{Balance}");
  }
  public void Deposit(string chequeNumber, int amount)
  {
    Balance += amount;
    Console.WriteLine($"cheque : #{chequeNumber} deposited: ₹{amount}. new balance: ₹{Balance}");
  }
}
class Program
{
  static void Main(string[] args)
  {
    BankAccount bankAccount = new BankAccount { AccountHolder = "Rahul" };

    bankAccount.Deposit(30000);
    bankAccount.Deposit("CHQ123456", 40000);
    }
}*/

//3.
/*class Warrior
{
  public void Attack(string weapon)
  {
    Console.WriteLine($"Warrior attacks with {weapon}");
  }
  public void Attack(string spell, int manaCost)
  {
    Console.WriteLine($"warrior cast {spell} using {manaCost}");
  }
}
   class Program
{
    static void Main(string[] args)
    {
    Warrior warrior = new Warrior();

    warrior.Attack("sword");
    warrior.Attack("Jadu", 30);
    }
}*/

//4.
/*class Product
{
  public string Name;
  public double Price;

  public Product(string name, double price)
  {
    Name = name;
    Price = price;
  }
  public void ApplyDiscount(double percentage)
  {

    double discountAmount = Price * (percentage / 100);
    Price -= discountAmount;
    Console.WriteLine($"Percentage Discount Applied: {percentage}%");
    Console.WriteLine($"New Price of {Name} ₹{Price}");
  }
  public void ApplyDiscount(int fixedAmount)
  {
    Price -= fixedAmount;
    Console.WriteLine($"Fixed Discount Applied : {fixedAmount}");
    Console.WriteLine($"New Price of {Name} ₹{Price}");
  }
}
class Program
{
    static void Main(string[] args)
    {
    Product product = new Product("Laptop", 28000);
    product.ApplyDiscount(10.0);
    product.ApplyDiscount(2000);
    }
}*/

//5.
/*class HotelBooking
{
  public void BookRoom(string GuestName)
  {
    Console.WriteLine($"Single room nbooked for {GuestName}");
  }
  public void BookRoom(string GuestName, bool isDoubleRoom)
  {
    if (isDoubleRoom)
      Console.WriteLine($"double room booked for {GuestName}");
    else
      Console.WriteLine($"Single room booked for {GuestName}");
  }
  public void BookRoom(string guestname, int NumberOfDays, string specialrequest)
  {
    Console.WriteLine($"suit room booked for {guestname} for {NumberOfDays} day");
    Console.WriteLine($"Special Request: {specialrequest}");
  }
}
class Program
{
    static void Main(string[] args)
    {
    HotelBooking hotelBooking = new HotelBooking();
    hotelBooking.BookRoom("Rahul");
    hotelBooking.BookRoom("priya", true);
    hotelBooking.BookRoom("Mr. Sharma ", 3, "Sea-facing room with breakfast");
    }
}*/

//STATIC NUMBERS EXAMPLES - 1.
/*class School
{
  public static int PassingMark = 33;
  public string Name;
  public int Marks;
  public School(string name, int marks)
  {
    Name = name;
    Marks = marks;
  }
  public void CheckResult()
  {
    if (Marks >= PassingMark)
    {
      Console.WriteLine($"{Name} passed");
    }
    else
    {
      Console.WriteLine($"{Name} failed ");
    }
  }
}
class Program
{
    static void Main()
    {
    School student1 = new School("Amit", 45);
    School student2 = new School("Riya", 30);


    student1.CheckResult();
    student2.CheckResult();

    Console.WriteLine($"All students are passing Marks: {School.PassingMark}");
    }
}*/

//2.
class Company
{
  public static double BonusRate = 0.10;

  public string Name;
  public double Salary;
  public Company(string name, double salary)
  {
    Name = name;
    Salary = salary;
  }
  public void ShowBonus()
  {
    double bonous = Salary + BonusRate;
    Console.WriteLine($"{Name} bonus milaga: ₹{BonusRate} ");
  }
}
class Program
{
    static void Main()
    {
    Company emp1 = new Company("Rahul", 50000);
    Company emp2 = new Company("Neha", 70000);

    emp1.ShowBonus();
    emp2.ShowBonus();

    Console.WriteLine($"Sabhi k liya bonousRate: {Company.BonusRate * 100}%");
    }
}
