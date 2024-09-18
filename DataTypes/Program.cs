// See https://aka.ms/new-console-template for more information

//Strings
string myString;
myString = "Hello, World";
string MyString = "Hello, Nigeria";

Console.WriteLine(myString);
Console.WriteLine(MyString);
MyString = "Hello, I am";

string name = Console.ReadLine();
Console.WriteLine(MyString + " " + name);

Console.WriteLine("Your name has " + name.Length + " Characters");

//integers

int integer1;
integer1 = 5;
int integer2 = 100;
Console.WriteLine(integer1);
Console.WriteLine(integer2);

int sum = 2 + 2;
int minus = 80 - 27;
int divide = 80 / 25;
int multiply = 3 * 6;

Console.WriteLine(@$"Addition : {sum}, Subtraction : {minus}, Division : {divide}, Multiplication : {multiply}");


//Float and double
float myFloat;
myFloat = 4.5f;
Double myDouble = 8.8d;

double floatSum = 4.3f + 2.3f;
double floatMinus = 9.3f - 4.3f;
double floatDivide = 9.9d / 3.5d;
double floatMultiply = 3.4d * 3.2f;

Console.WriteLine(@$"Addition : {floatSum}, Subtraction : {floatMinus}, Division : {floatDivide}, Multiplication : {floatMultiply}");

//Boolean

bool myTrue;
myTrue = true;
bool myFalse = false;


bool taf = true && false;
bool tat = true && true;
bool faf = false && false;

bool tof = true || false;
bool tot = true || true;
bool fof = false || false;

bool notTrue = !(!(false));
bool notFalse = !false;


Console.WriteLine($"True and False : {taf}");
Console.WriteLine($"True and True : {tat}");
Console.WriteLine($"False and False : {faf}");
Console.WriteLine($"True or False : {tof}");
Console.WriteLine($"True or True : {tot}");
Console.WriteLine($"False or False : {fof}");
Console.WriteLine($"Not True : {notTrue}");
Console.WriteLine($"Not false : {notFalse}");

//DateTime

DateTime myDateTime;
DateOnly myDate;
TimeOnly myTime;

myDateTime = DateTime.Now;
myDate = new DateOnly(2004, 4, 26);
myTime = new TimeOnly( 8, 23, 34);

Console.WriteLine(myDateTime);
Console.WriteLine(myDate);
Console.WriteLine(myTime);

myDateTime = new DateTime(myDate, myTime);
Console.WriteLine(myDateTime);

