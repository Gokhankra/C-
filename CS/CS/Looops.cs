using System.Security.Cryptography.X509Certificates;

namespace CS;

public class Looops
{


public void whileloop(){

int i=0;
while(0<6){
    Console.WriteLine(i);
    i++;
}
}

public void dowhile(){
    int i=0;
    do{
        Console.WriteLine(i);
        i++;
    }while(i<5);
}
public void forloop(){
    for (int i = 0; i < 6; i++)
    {
        Thread.Sleep(1000);
        Console.WriteLine($"number is {i}");
    }

}
public void printTriAngle(){


for (int i = 9; i >0;i--){

    for (int k = i; k >=0 ; k--)
    {
        if(k==3){
            Console.Write("*");
                        continue;
        }
        Console.Write(k+" ");
    }
    Console.WriteLine();
}
}

public void AnglePrint(int num){

int space=num;

    for(int i=0;i<=num;i+=2){
        for(int j=0;j<=i;j++){
         do{
         Console.Write("-");
        space--;}
        while(space-i > 0);
      
            Console.Write("*");
        }
    
        Console.WriteLine();
    }
}





}