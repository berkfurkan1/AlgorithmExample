/*   
Klavyeden a ve b sayıları giriliyor. Girilen a sayısının b sayısının tam katı olup olmadığını bulan uygulama yazın.
*/

Console.WriteLine("A sayısını giriniz:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("B sayısını giriniz:");
int b = Convert.ToInt32(Console.ReadLine());

if (a%b == 0 ){
    Console.WriteLine("A sayısı B sayısının tam katıdır.");
}else{
    Console.WriteLine("A sayısı B sayısının tam katı değildir.");
}

/* ------------------------------------------------------------------------------------------------------------------------------------------------- */

  int a;
    int b;
 
    Console.WriteLine("Birinci sayı: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("İkinci sayı: ");
    b = Convert.ToInt32(Console.ReadLine());
 
    if (a % b == 0) //a b'ye bölündüğünde kalan sıfır ise a b'nin bir katı demektir.
    {
        Console.WriteLine(a + " sayısı " + b + " sayısının tam katıdır.");
    }
    else
    {
        Console.WriteLine(a + " sayısı " + b + " sayısının tam katı değildir."); 
    }