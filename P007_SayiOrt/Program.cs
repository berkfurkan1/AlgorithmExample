/*
Klavyeden girilen 10 adet sayının ortalamasını hesaplayan uygulama yazın.
*/

int sumOfNumber = 0 ;

for(int i = 0; i<10 ; i++ ){
    Console.WriteLine("Bir sayı giriniz:");
    // klavyeden okudukça sayıların toplamını buluyoruz.
    sumOfNumber += Convert.ToInt32(Console.ReadLine());
}

//ortalamayı ayrı bir değişkene yazıp bu değişkeni ekrana yazdırabileceğimiz gibi
//doğrudan Console.WriteLine içerisinde de hesaplamayı yapabiliriz.

Console.WriteLine("Sayıların ortalaması : "+ sumOfNumber);