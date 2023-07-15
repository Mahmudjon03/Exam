int a,c=1;
a=Convert.ToInt32(Console.ReadLine());
int[] b =new int [a];
for (int i = 0; i < a; i++)
{
    b[i]=Convert.ToInt32(Console.ReadLine());
}
for (int j = 0; j < a; j++)
{
    for (int k = 0; k < a-j-1; k++)
    {
         if (b[j]!=b[j+1]){
         c++;
    }
   
    }

}
System.Console.WriteLine(c/2-1);
