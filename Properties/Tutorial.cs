
//namespace PracticeProject
//{
//  class MainClass
//method name like CalculateValue
//method argumanets in camelCase
//constants as fields
//const double Pi = 3.14;
//const int weeks = 52, months = 12;
//const string birthday = "02/16/1989";
//{
//  public static void Main(string[] args)
//  {

////can change all beginning identifiers to var
//byte number = 2; //var automatically makes intergal as int 
//int count = 10;
//float totalPrice = 20.95f; //need f to not make it auto double
//var character = 'A'; //char single quotes
//string firstName = "Mosh"; //string double quotes
//bool isWorking = true;
//Console.WriteLine(number);
//Console.WriteLine(count);
//Console.WriteLine(totalPrice);
//Console.WriteLine(character);
//Console.WriteLine(firstName);
//Console.WriteLine(isWorking);

//Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
//Console.WriteLine("{0} {1}"), float.MinValue, float.MaxValue;

//const float Pi = 3.14f;
//byte b = 1;
//int i = b;
//Console.WriteLine(i);

//int i = 1000;
//byte b = (byte)i;
//Console.WriteLine(b);

//string number = "1234";
//int i = Convert.ToInt32(number);
//Console.WriteLine(i);
//try {
//    var number = "1234";
//    byte b = Convert.ToByte(number); //if cannot be converted need to use try/catch
//    Console.WriteLine(b);
//}
//catch (Exception) //prevents application from crashing
//{
//    Console.WriteLine("The number could not be converted to a byte");
//}
//try {
//    string str = "true";
//    bool b = Convert.ToBoolean(str);
//    Console.WriteLine(b);
//}
//catch (Exception)
//{
//    Console.WriteLine("The number could not be converted to a byte.");
//}
//var a = 1;
//var b = 2;
//var c = 3;

//Console.WriteLine(c > b || c > a);
//  }
//}
//}


//implicit conversion
//int i = 1;
//float f = i;

//Explicit conversion
//int i = 1;
//byte b = 1; this will not compile
//casting
//byte b = (byte)i;
//non-compatible types
//string s = "1";
//int i = Convert.ToInt32(s);//convert string to int
//int j =int.Parse(s); //parse method takes string to target type
//Convert Methods: ToByte()/ToInt16()/ToInt32()/ToInt64()
//Postfix increment
//int a = 1;
//int b = a++; // a = 2, b = 1;
//prefix increment
//int a = 1;
//int b = ++a // a = 2, b = 2;

//Methods
//<Access Specifier> <Return Type> <Method Name>(Parameter List)
//{
// Method Body
//}
//Access Specifier-determines visitbility of a var or method from another class
//Return Type-  Method may return a value. Return type is the data type of the value
//the method returns. if RT returns no values it is void
//Method name- unique identifier and is case sensitive
//Parameter List- optional
//

//Constants
//Console.WriteLine("My birthday is always going to be: {0}", birthday);
//Console.Read();
//parsing
//string myString = "15";
//string mySecondString = "13";
//int num1 = Int32.Parse(myString);
//int num2 = Int32.Parse(mySecondString);
//int resultInt = num1 + num2;                       
//string result = myString + mySecondString;

//Console.WriteLine(resultInt);
//Console.Read();
////implicit conversion
//int num = 12437846;
//long bigNum = num;

//float myFloat = 12.37f;
//double myNewDouble = myFloat;
////explicit conversion
//double myDouble = 13.37;
//int myInt;
////cast double into int;
//myInt = (int)myDouble;

////type conversion
//string myString = myDouble.ToString();
//string myFloatString = myFloat.ToString();
//bool sunIsShining = false;
//string myBoolString = sunIsShining.ToString();

//Console.WriteLine(myFloatString); //will only read 13 int can only read whole numbers
//Console.Read();


//local variables in camelCase
//do not use numbers as starts of variables
//string myName = "Jaclyn";
//string message = "My name is " + myName;
//string capsMessage = message.ToUpper;
//string lowerCaseMessage = message.ToLower;

//Console.WriteLine(lowerCaseMessage);
//Console.Read();
//int num1 = 15;
//int num2 = 5;
//int num3;
//int sum = num1 + num2;

//double d1 = 3.5;
//double d2 = 1.337;
//double sumD = d1 + d2;

//float f1 = 3.5f;

//num3 = 15;

//Console.WriteLine("The sum of" + num1 + "and" + num2 + "is" + sum);
//Console.WriteLine("The sum of" + d1 + "and" + num2 + "is" + sumD);