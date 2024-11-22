/* Bir dizideki en küçük elemanı bulan uygulama yazın.
   Dizi boyutu: 10
   Dizi elemanları : 8, 7, 9, 17, 3, -5, -1, 6, 20, 13
*/

//soruda verilen diziyi tanımlıyoruz
    int[] items = new int[] {8, 7, 9, 17, 3, -5, -1, 6, 20, 13};
    
    //öncelikle dizinin ilk elemanını "en küçük" olarak atıyoruz
    // bu sayede döngü içerisinde smallestNumber'dan daha küçük
    // bir değer olup olmadığını kontrol edebileceğiz.
    
    //alternatif olarak smallestNumber değişkenine başlangıç değeri
    // olarak çok büyük bir sayı da verebilirdik. ancak dizideki
    // tüm değerlerin bu sayıdan daha büyük olması durumunda hatalı
    // çalışacaktır.
    int smallestNumber = items[0];
 
    for (int i = 0; i < 10; i++)
    {
        //dizinin i'ninci elemanı var olan smallestNumber'dan
        // daha küçük ise bu değeri en küçük olarak atalım
        if (smallestNumber > items[i])
        {
            smallestNumber = items[i];
        }
    }
 
    Console.WriteLine("Dizideki en küçük eleman: " + smallestNumber);