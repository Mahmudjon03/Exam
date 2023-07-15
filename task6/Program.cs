
int a,
s=0;
a=Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <a; i++){
    s+=(Math.Pow(2,i));
}
System.Console.WriteLine(s);

