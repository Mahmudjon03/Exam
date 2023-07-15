int a;
a=Convert.ToInt32(Console.ReadLine());
int[] b =new int [a];
for (int i = 0; i < a; i++)
{
    b[i]=Convert.ToInt32(Console.ReadLine());
}
 for (int i = 0; i < a; i++)
 {
    for (int j = 0; j < a-i-1; j++)
    {
        if(b[j]<b[j+1]){
    int c= b[j];

     b[j]=b[j+1];
     b[j+1]=c;

        }
      
    }
 }
 foreach (var elem in b)

 {
    System.Console.WriteLine(elem);
 }
