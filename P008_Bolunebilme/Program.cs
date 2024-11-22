/*
1 ile 50 arasındaki (ikisi de dahil) tek ve dörde bölünebilen sayıları listeleyen bir uygulama yazın.
*/

int[] number = [];
for (int i =1 ; i <51 ; i++){
    if(i % 2 ==1 || i / 4 == 0){
        Console.WriteLine(i);
    } 
}

/*  ----------------------------------------------------------------------------------------------------------------- */

    //1'den başlayıp 50'ye kadar (50 dahil) tüm sayıları
    // kontrol edeceğimiz için döngümüzdeki iterasyon değişkeni
    // olan i'i 0'dan değil 1'den başlattık ve bitiş koşulunu
    // i < 50 değil i<=50 yaptık. 1-50 arasındaki tüm sayıları
    // kontrol etmek istediğimiz için i'yi her seferinde i++
    // ile bir arttırdık.
    for (int i = 1; i <= 50; i++)
    {
        //i % 2 ile sayının tek olup olmadığını kontrol ediyoruz
        //i % 4 ile dörde tam bölünüp bölünmediğini kontrol ediyoruz
        //araya koyulan || ile iki koşuldan herhangi birini sağlaması
        // durumunda if bloğunun içerisine girmesini sağlıyo ve
        // bu sayıyı ekrana yazıyoruz.
        if (i % 2 == 1 || i % 4 == 0)
        {
            //öncesinde herhangi bir mesaj yazmaya ihtiyaç duymadık
            // bu nedenle içeriye sadece i yazmamız yetiyor.
            Console.WriteLine(i);
        }
        //sayı çiftse ve dörde tam bölünmüyorsa ekrana bir mesaj
        // yazmayacağımız için else yazmadık
    }