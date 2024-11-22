/*
Console.WriteLine("Bir sayı giriniz:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 100){
    Console.WriteLine("Girdiğiniz sayı 100 den büyüktür.");

}else if(number < 0){
    Console.WriteLine("Girdiğiniz sayı 0'dan küçüktür.")

}else{
    Console.WriteLine("Girdiğiniz sayı 0 <= number <= 100 aralığını sağlamaktadır.")

}
*/
 int number;
 
    //kullanıcıdan önce bir sayı okuyup sonra karşılaştırma yapacağız
    do {
        Console.WriteLine("Bir sayı giriniz: ");
        number = Convert.ToInt32(Console.ReadLine());
 
        if (number < 1) //sayı 1'den küçük mü?
        {
            Console.WriteLine("Girdiğiniz sayı 1'den küçük. Tekrar deneyin.");
        }
        else if (number > 100) //sayı 1'den büyük ama 100'den de büyük mü?
        {
            Console.WriteLine("Girdiğiniz sayı 100'den büyük. Tekrar deneyin.");
        }
        else //iki koşulu da sağlamıyorsa sayı 1 ile 100 arasında demektir
        {
            Console.WriteLine("Teşekkürler! 1 ile 100 arasında bir sayı girdiniz.");
        }
    } while(number < 1 || number > 100); //sayı 1'den küçük VEYA 100'den büyükse döngü devam ediyor
