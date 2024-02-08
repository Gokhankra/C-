using System;
using System.Data;
namespace CS;

public class LogicalDefines
{




public void passwordMatch(){
    string password=Console.ReadLine();

    if(password =="1234qweqwe" || password=="123"){
        Console.WriteLine("password is succesfull");
    }else if(!(password=="1")&& password=="2" && password !="3"){
        Console.WriteLine("Wrong Password try Again");
    }
}

}
