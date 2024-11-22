int number ;
int sum = 0 ;

do
{
    Console.WriteLine("Bir sayı giriniz:");
    number = Convert.ToInt32(Console.ReadLine());

    if(number != -1){
        sum += number;
    }
} while (number != -1);

Console.WriteLine("girilen sayıların toplamı :" + sum);
