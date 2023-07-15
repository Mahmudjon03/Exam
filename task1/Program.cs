int FindMinimum(int a, int b, int c,int d){
    if(a<b&&a<c&&a<d){
    return a;
    }else if(b<a&&b<c&&b<d){
        return b;
    }else if(c<a&&c<b&&c<d){
        return c;
    }else {
        return d;
    }
}
int a,b,c,d;
a=Convert.ToInt32(Console.ReadLine());
b=Convert.ToInt32(Console.ReadLine());
c=Convert.ToInt32(Console.ReadLine());
d=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
System.Console.WriteLine(FindMinimum(a,b,c,d));

  

