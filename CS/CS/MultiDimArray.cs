namespace CS;
using System;
using System.Diagnostics.CodeAnalysis;

public class MultiDimArray
{

public  void marrays(){
    int [,] mArry=new int [3,4] 
    {
        {1,2,3,4},
        {3,2,2,1},
        {5,4,1,0}};

        Console.WriteLine(mArry[0,1]);
// or 

    int [,] ArrayZ={
        {1,2,3,4},
        {3,2,2,1},
        {5,4,1,0}};

  Console.WriteLine(ArrayZ[0,1]);

        int [,] ArryAdded=new int[2,5];
         int result=   ArryAdded[0,2]=4;
    Console.WriteLine($"the value from ArrayAdded 0 index ,2 index as array[index,index] difference from getting value [2,3] {result}");

// Diff Jagged Vs 2d 
// when you call the value in the jagger array use z [] [];  but 2D use z [index,index];



// jagged array
 // biggest difference jager array vs 2d array row number could be different
int [] [] jagArray=
{
    new int[]    {1,2,3,4},
    new int []    {3,2,2,1},
    new int []    {5,4,1,0,9,8,6,4,1,1,6,7,8}};
Console.WriteLine($"{jagArray[2][5]}  this value comes from jagger array az [] [] difference of getting value [][]");
}


public void arrayfill(){
    int [][] fillarray=new int [3][];

    for (int i = 0; i < fillarray.Length; i++)
    {
        for (int j = 0; j < fillarray[i].Length; j++)
        {
            fillarray[i][j]=i;
        }
        
    }

    Console.WriteLine(fillarray[2][2]);
}



}
