using System;
using System.ComponentModel;
using System.Reflection.PortableExecutable;// in that way we can use some methods with shorter way such as console.writeline
namespace CS{   //namespaces uses to class to organize 

class Syntax {
         static void Main(string [] args){

     /*   System.Console.WriteLine("hello world");
        Console.WriteLine("Hello World");
        Syntax obj=new Syntax();
        string input=Console.ReadLine();
        obj.print(input+ "this is the user input  ");
        obj.print($"Hello user input is {input}!!!!!");
*/
        int b; // declaration
        b=2; // initialization
        int a=5;
        int? not=null;
        Syntax obj=new Syntax();
        uint pozitif=123; // uint can be only pozitif
        char c='C';
        float f=5.5f;
        float fl=(float) 5.6;
        double d=123.123;
        decimal dec=5.5m;
        bool bo =true;
        Console.WriteLine(" "+f+" "+d+" "+dec+ bo);
        Math.Min(12,123);
        Console.WriteLine(Math.Round(12.491213123));
                Console.WriteLine(Math.Round(12.501));

        int [] ry={5,-5,3};
        uint [] dasd={1,2,3,4};
        int a1=int.MaxValue;
        uint ds=uint.MaxValue;
        
        Console.WriteLine(Math.Floor(50.9)); // it grounds the number closest int value decimali cikartioy
        Console.WriteLine(Math.Ceiling(50.1)); // it upgrades number to closest int value , decimali tamamliyor
        Console.WriteLine(Math.Truncate(51.231923123));   // it will remove everything after decimal 
        obj.print(Math.Sign(-12));  // it will return negative or pozitif -1 vs 1 
        /////********
        char chars='C';
        obj.print(chars);
        char [] chart={'x','y','z','a'};
        string chrtostring=new string(chart);   /// this is cool  char to string
        Console.WriteLine(chrtostring);
        string my="gokhan";
        string ln="kara";
        Console.WriteLine($"hello {my}, from C# {ln}");
        obj.print(my.Length);

        // how to sort string array names 
        string [] name={"Gokhan","Hokgan","Tokhan","Yokhan","Aokhan","Yokhan","Zokhan"};
         string change="";
     /*    for (int i = 0;i<name.Length;i++){ 
                    for (int j = 0; j < name.Length; j++)
                    {
                         if (name[i].CompareTo(name[j])==-1){
                      change=name[i];
                      name[i]=name[j];
                      name[j] = change;
                    }}
         }   

         foreach(var item in name){
                Console.WriteLine(item);
         }
        string g="gokhan";
        Console.WriteLine(g.CompareTo("Gokhan"));  //-1
        Console.WriteLine(g.CompareTo("gokhan")); //0
        Console.WriteLine(g.CompareTo("gokhano")); //-1
        int position =g.IndexOf("ha");
        obj.print(position);
        Console.WriteLine("sadaa\a\a\a\a\a\a\a dadda ");

        class1 person=new class1();
        person.FirstName="Casper";
        person.LastName="Duman";
        Console.WriteLine(person.getFullName());
        Console.WriteLine(person.FullName);
   Console.WriteLine("Guess Full name");
   string guess=Console.ReadLine();
   if(guess==person.FullName){
    Console.WriteLine("Correct Answer");
   }else{
    Console.WriteLine(" Wrong Answerss!!!");
   }

    person.guessAge();
    LogicalDefines ps=new LogicalDefines();

    ps.passwordMatch();

*/
   Looops lp=new Looops();
     lp.printTriAngle();
    lp.AnglePrint(10);
int [] loo=new int[2];
loo[1]=999999;
    MultiDimArray md=new MultiDimArray();
    md.marrays();

        int [,] multi={{1,2},{1,2}};
        int [][] jarray={   // this is jagged array
           new int [] {1,2,3},
         new int []{1,2,3,4}};

         int [] [] deneme={
            new int []{},
            loo,};
            Console.WriteLine(deneme[1][1]);

            md.arrayfill();
    }


    void print(object t){
        Console.WriteLine(t);
    }
      void print(int t){
        Console.WriteLine(t);
   }




   
}

}

//namespace->classes->members->method->statements

