namespace CS;

public class ArrayC
{

    public void arrayDefinitions(){
        int [] d=new int[4];
        d[0]=5;
        
        int [] fill=new int[5];

        for (int i = 0; i < fill.Length; i++)
        {
            fill[i]=Convert.ToInt32(Console.In.ReadLine());
        }
        
        Array.IndexOf(fill,3);
        Array.Sort(fill);
        

        }

}
