

//Console.Write("Enter Your name:  ");
//string myName = Console.ReadLine();
//Console.WriteLine(myName);


//TypeCasting -> conversion one DataType to another Datatype
//TypeCasting Type -> implicit (char-int-long-float-double) &
//explicit (double-float-long-int-char)


//implicit example
//char c = 'a';
//int i = c;
//Console.WriteLine(c);
//Console.WriteLine(i);

//explicit example
//double d = 123.45;
//int i = (int)d;
//Console.WriteLine(i);

//long l = 100000L;
//int i2 = (int)l;
//Console.WriteLine(i2);

//int code = 65;
//char c = (char)code;
//Console.WriteLine(c);

//int i3 = 255;
//byte b = (byte)i3;
//Console.WriteLine(b);

//object obj = 42;
//int unboxed = (int)obj;
//Console.WriteLine(unboxed);

// operators 
/*
 * Arithmetic operator (+,-,*,/)
 * logical operator(&&,||,!)
 * Assignment operator(=)
 * Comparision operator(<,>,>=,<=,!=)
 */


//Arithmetic operator (+,-,*,/)
//int a = 10, b = 5;
//Console.WriteLine(a+b);
//Console.WriteLine(a-b);
//Console.WriteLine(a*b);
//Console.WriteLine(a/b);

//logical operator(&&,||,!)

//Console.WriteLine(true && true);
//Console.WriteLine(true && false);
//Console.WriteLine(false && true);
//Console.WriteLine(false && false);
//Console.WriteLine(true || true);
//Console.WriteLine(true || false);
//Console.WriteLine(false || true);
//Console.WriteLine(false || false);

//Assignment operator(=)
//int c = 5;
//int d = c;
//Console.WriteLine(d);

//Comparision operator(<,>,>=,<=,!=)
//Console.WriteLine(10>5);
//Console.WriteLine(10==5);
//Console.WriteLine(50 !=20);
//Console.WriteLine(50<=90);
//Console.WriteLine(50 >= 20);

////Math function
////Math.Max()
//int a = Math.Max(23, 34);
//Console.WriteLine(a);
////min
//int b= Math.Max(23, 34);
//Console.WriteLine(b);
////Round
//double c= Math.Round(23.898);
//Console.WriteLine(c);

////sqrt squareroot
//double sqrt = Math.Sqrt(20);
//Console.WriteLine(sqrt);

////abs -> for positive value
//double abs = Math.Abs(-34);
//Console.WriteLine(abs);


////string in C#
//string name = "Rubina";
//Console.WriteLine(name.Length);
//Console.WriteLine(name.ToUpper());
//Console.WriteLine(name.ToLower());
//Console.WriteLine("Happy birthday " + name);
//string value = string.Concat("Hello ",name);
//Console.WriteLine(value);

//string interpolation
//String interpolation is a feature in programming languages like C#
//that allows you to embed expressions or variables directly inside a string.
//It is denoted by a $ symbol before the string, and
//the expressions are placed inside curly braces {}.
//The expressions are evaluated and replaced with their values when the string is output

//int a = 5, b = 5;
//Console.WriteLine($"The value of a is : {a} and b is : {b}");


//indexing in C#
//string myValue = "Kathmandu is a Beautiful city";
//Console.WriteLine(myValue[2]);
//Console.WriteLine(myValue.IndexOf("is"));
//Console.WriteLine(myValue.IndexOf("Beautiful"));
//Console.WriteLine(myValue.Substring(13));

//Decision control
//if
//if else
//else if ladder (else if dheraii vako)


//int a = 0;
//if(a < 0)
//{
//    Console.WriteLine("a is negative");
//}
//else if(a > 0)
//{
//    Console.WriteLine("a is positive");
//}
//else
//{
//    Console.WriteLine("a is zero");
//}


////switch statement 
//int a = 2;
//switch (a)
//{
//    case 0:
//        Console.WriteLine("The value is zero(0)"); 
//        break;
//    case 1:
//        Console.WriteLine("The value is 1"); 
//        break;
//    case 2:
//        Console.WriteLine("The value is 5"); 
//        break;
//    default: Console.WriteLine(" no value is match");
//        break;
//}


////looping in c#
////for 
//for (int i =0; i <6; i++)
//{
//    Console.WriteLine(i);
//}


////while 
//int i = 2;
//while(i < 6)
//{
//    Console.WriteLine(i);
//    i++;
//}

////do while
//int i = 10;
//do
//{
//    Console.WriteLine(i);
//    i++;
//} while (i < 5);

////function 
//void myFunction()
//{
//    int a, b;
//    Console.WriteLine("Enter the value of a and b");
//    a= int.Parse(Console.ReadLine());
//    b= int.Parse(Console.ReadLine());
//    Console.WriteLine("Addition :" + (a+b));
//}
//myFunction();


////escape character
////problem
//Console.WriteLine("This is my "code""); //error

////solution  use \ before symbol
//Console.WriteLine("This is my \"code\""); 

////Array -> store more data with same dataType
//int[] arr = { 1, 2, 3, 4, 5, 6 };
//Console.WriteLine(arr[4]);
//arr[4] = 25;
//Console.WriteLine(arr[4]);
//Console.WriteLine(arr.Length);
//string[] arr1 = { "rubina","sita","rita" };
//Console.WriteLine(arr1[0]);
////another method
//int[] arr2 = new int[4]; //array size matra define gareko value paxi dine gari
//int[] arr3 = new int[4] {1,3,4,5}; //array size and value both define
//int[] arr4 = new int[] {1,3,4,5}; //array size no define and values are define


//class and object 
// class(animal) -> lion,tiger,dog(properties,function) -object

//class Student
//{
//    int id = 1;
//    string name = "rubina";
//    static void Main(string[] args)
//    {
//        Student st = new Student();
//        Console.WriteLine(st.id);
//        Console.WriteLine(st.name);
//    } 
//}

//class members 

class Student
{
    int id;//field
    string name; //field
    void myFunction() //method
    { Console.WriteLine("This is a function..."); }
    static void Main(string[] args)
    {
        Student student = new Student();
        Console.WriteLine(student.id);
        student.myFunction();
    }
}