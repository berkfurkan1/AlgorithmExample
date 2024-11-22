/*  
Yarıçapı klavyeden girilen bir dairenin alanını hesaplayan uygulama yazın. Hesaplanan alanı ekrana 4 basamak ondalık hassasiyeti ile yazdırın.

Notlar

alan = pi * r^2

pi = 3.14
*/

Console.WriteLine("Dairenin yarıçapını giriniz:");
int r = Convert.ToInt32(Console.ReadLine());
double pi = 3.14;
double area = pi *  r * r ;

Console.WriteLine("Dairenin alanı {0:N4}" , area); // virgülden sonra 4 basamak ondalık hassasiyeti için.

/* ----------------------------- --------------------------------------------------------------------------------------------------------------------  */
/*
int r; //klavyeden alacağımız yarıçapı bir değişkende tutmalıyız
    double pi = 3.14; //pi ondalıklı bir sayı olduğu için int kullanmamalıyız
 
    Console.WriteLine("Dairenin yarıçapını girin: ");
    r = Convert.ToInt32(Console.ReadLine());
 
    double a = pi * r * r; //ondalıklı bir sayı ile işlem yaparken a değişkenini tamsayı yapamayız
    Console.WriteLine("Alan: {0:N4}", a); //virgülden sonra 4 basamak göstermek için formatlamalıyız
*/