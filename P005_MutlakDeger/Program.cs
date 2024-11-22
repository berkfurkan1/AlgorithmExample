/*  Klavyeden girilen bir sayının mutlak değerini bulan uygulama yazın. */

Console.WriteLine("Bir sayı giriniz: ");
    int a = Convert.ToInt32(Console.ReadLine());
    
    if (a < 0) //a sayısı negaif ise sayıyı -1 ile çarparak pozitif yapabiliriz
    {
        a = a * -1;
    }
    //a sayısı sıfır veya pozitif ise sayıya dokunmamıza gerek yok bu nedenle if'ten else yazmamıza gerek yok
 
    Console.WriteLine("Girilen sayının mutlak değeri: " + a);