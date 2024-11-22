Console.WriteLine("Faktöriyel hesabı yapılacak sayıyı giriniz : ");
int a =Convert.ToInt32(Console.ReadLine());
int f = 1;

while(a > 1){
    f = f * a;
    a = a - 1;
}
Console.WriteLine("Girilen sayının faktöriyeli :" + f);