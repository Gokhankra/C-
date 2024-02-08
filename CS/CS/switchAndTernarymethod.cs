using System;
namespace CS;

public class switchAndTernarymethod
{


public void guessday(){
string day="monday";
switch (day)
{
    case "tuesday":
    Console.WriteLine("today tuesday");
    break;
    case "monday":
    Console.WriteLine("today is monday");
    break;
    default:
    break;
}

string tern="gokhan";
bool result=tern=="gok"?true:false;
//////
/// single line if statement 
/// 

if(tern=="gokhan") Console.WriteLine($"this is from single line if statement as tern equal {tern}");

}
}
