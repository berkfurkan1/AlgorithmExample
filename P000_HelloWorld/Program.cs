Console.WriteLine("ilk sayıyı giriniz:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ikinci sayıyı giriniz:");
int b = Convert.ToInt32(Console.ReadLine());


if (a<b){
    Console.WriteLine("{0} sayısı {1} sayısından küçüktür.",a,b);
}else{
    if(a>b){
        Console.WriteLine("{0} sayısı {1} sayısından büyüktür." ,a,b);
    }else{
        Console.WriteLine("sayılar birbirine eşittir.");
    }
}