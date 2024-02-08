using System;
using System.Dynamic;
namespace CS{

    public class class1
    {
    
    public string FirstName{get;set;}
    public string LastName{get;set;}

    string _middleName=" this is not accessable from other class";

public string getFullName(){
    return FirstName+ " "+ LastName;
}
    
public string FullName{

    get{ return FirstName+" "+ LastName;}       // this is how to use get method 
}


public string guessAge(){
    Console.WriteLine("Guess Ageee");
    int guessage=Int32.Parse(Console.ReadLine());
    string result="";
    if(guessage>0){
        if(guessage>15){
            Console.WriteLine("you are on the right way keep guessing");
            int guess2=Int32.Parse(Console.ReadLine());
            if(guess2==33){
                result="you are correct";
            }else{
                result=" you LOSTTTT :( ";
            }
        }
    }else if(guessage>50){
        result="wrong answers";
    }
    Console.WriteLine(result);
    return result;
}







    }
}