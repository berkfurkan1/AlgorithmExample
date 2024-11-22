int dayNumber ;

do
{
    Console.WriteLine("1 ile 7 arasında rakam giriniz.");
    dayNumber = Convert.ToInt32(Console.ReadLine());

    switch (dayNumber)
    {
        case 1:
        Console.WriteLine("Pazartesi");
        break;
        case 2:
        Console.WriteLine("Salı");
        break;
        case 3:
        Console.WriteLine("Çarşamba");
        break;
        case 4:
        Console.WriteLine("Perşembe");
        break;
        case 5:
        Console.WriteLine("Cuma");
        break;
        case 6:
        Console.WriteLine("Cumartesi");
        break;
        case 7:
        Console.WriteLine("Pazar");
        break;
        default:
        Console.WriteLine("Hatalı giriş yapıldı!!");
        break;
    }

} while (dayNumber<1 || dayNumber>7); // 1 ile 7 arasında rakam girene kadar tekrarlatıyor.