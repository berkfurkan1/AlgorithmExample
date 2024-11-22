/*
10.000 TL'yi yıllık %10 oran ile 5 yıllığına faize yatırdığımıza 5 yıl boyunca her yıl sonunda elde edilecek parayı ekranda görüntüleyen uygulama yazın.

Notlar

faizli getiri = anapara * (1 + faiz oranı)^süre

Beklenen çıktı:

1. yıl sonunda toplam anapara: 11.000,00 TL
2. yıl sonunda toplam anapara: 12.100,00 TL
3. yıl sonunda toplam anapara: 13.310,00 TL
4. yıl sonunda toplam anapara: 14.641,00 TL
5. yıl sonunda toplam anapara: 16.105,10 TL
*/
/*
double para = 100000 ;
double faizOrani = 0.1 ;

for(int i = 1 ; i<=5 ; i++){
    double faizGeliri = para * faizOrani;
    para += faizGeliri; 
    //Console.WriteLine(" {a}. yılında ki faiz geliri {b}, toplam para {c}",i,faizGeliri,para);
}
Console.WriteLine("toplam para tutarı :" + para);

*/
/* ------------------------------------------------------------------------------------------------------------------------ */

/* 10.000 TL'yi yıllık %10 oran ile 5 yıllığına faize yatırdığımıza 5 yıl
    boyunca her yıl sonunda elde edilecek parayı ekranda görüntüleyen
    uygulama yazın.
    faizli getiri = anapara * (1 + faiz oranı)^süre
 
    Beklenen çıktı:
    1. yıl sonunda toplam anapara: 11.000,00 TL
    2. yıl sonunda toplam anapara: 12.100,00 TL
    3. yıl sonunda toplam anapara: 13.310,00 TL
    4. yıl sonunda toplam anapara: 14.641,00 TL
    5. yıl sonunda toplam anapara: 16.105,10 TL
*/


    //her yıl anaparaya o yıl kazanılan faiz eklenecek
    // ve faiz hesabı ondalıklı bir işlem, bu nedenle 
    // anapara değişkenini ondalıklı tanımlıyoruz
    double capital = 10000;
 
    //%10 faiz oranı demek 10/100 = 1/10 = 0.1 (ondalıklı sayı gösterimi)
    double interestRate = 0.1;
 
    int year = 5;
    
    //her yıl için faiz getirisi hesaplayıp ekrana yazacağız
    for (int i = 1; i <= year; i++)
    {
        //işlem önceliğini toplamaya vermek için parantez içine aldık
        // yoksa capital ile 1'i çarpıp üstüne interestRate'i ekleyecekti
        capital = capital * (1 + interestRate);
        // faiz = anapara * (1 + faiz oranı)^süre formülündeki süre'yi hiç
        // kullanmadık çünkü her yıl 1 yıllık yeni faiz hesaplıyoruz.
 
        //yıllık faiz gelirini anaparaya eklediğimiz için (üstteki satır)
        // ekrana capital değişkenini yazarak yıllık net parayı ekrana
        // yazmış oluyoruz
        Console.WriteLine(i + ". yıl sonunda toplam anapara: {0:N2}", capital);
    }
