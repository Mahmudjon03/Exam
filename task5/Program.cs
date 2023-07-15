var list=new List<int>();
int a,c=999999 ,n=0;
a=Convert.ToInt32(Console.ReadLine());
int[] b =new int [a];
for (int i = 0; i < a; i++)
{
    b[i]=Convert.ToInt32(Console.ReadLine());
}
for (int j = 0; j < a; j++){
if( c>b[j]){
    c=b[j];
}
if(n<b[j]){
    n=b[j];

}}

//System.Console.WriteLine(c);
//System.Console.WriteLine(n);
for (int r = 0; r <= a; r++)
{    if(b[r]==c){
    System.Console.WriteLine();
 System.Console.WriteLine(b[r]);
}//else if(b[r{

//}
   
    
}





