
int a,c=999999 ,n=0,s=0,w=0;
a=Convert.ToInt32(Console.ReadLine());
int[] b =new int [a];
for (int i = 0; i < a; i++)
{
    b[i]=Convert.ToInt32(Console.ReadLine());
}
for (int j = 0; j < a; j++){
if( c>b[j]){
    c=b[j];
    s=j;
}
if(n<b[j]){
    n=b[j];
    w=j;

}}

//System.Console.WriteLine(s);

//System.Console.WriteLine(w);


    for (int i = s; i <= w; i++)
    {
        System.Console.WriteLine(b[i]);
    }





