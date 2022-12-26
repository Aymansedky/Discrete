using System;  

namespace Project
{
    public class PerfectNumber 
    {  
        public static void Main()
        {
            int n,i,sum;
            int start,end;
            
            Console.Write("Start : ");
            start = int.Parse(Console.ReadLine());  
            Console.Write("End : ");
            end = int.Parse(Console.ReadLine());  

            for(n=start;n<=end;n++)
                {
                i=1;
                sum = 0;
                while(i<n)
                {
                if(n%i==0)
                    sum=sum+i;
                    i++;
                }
                if(sum==n)
                Console.WriteLine(n);
                }
        }  
    }
}
