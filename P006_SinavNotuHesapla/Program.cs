 int midterm1, midterm2, final;
    double grade;
 
    Console.WriteLine("Birinci vize notunu giriniz: ");
    midterm1 = Convert.ToInt32(Console.ReadLine());
 
    Console.WriteLine("İkinci vize notunu giriniz: ");
    midterm2 = Convert.ToInt32(Console.ReadLine());
 
    Console.WriteLine("Final notunu giriniz: ");
    final = Convert.ToInt32(Console.ReadLine());
 
    //matematikteki işlem öncelikleri ve parantez kullanımı birebir geçerlidir
    //önce parantez içindeki işlemler yapılır.
    // parantez içerisinde de önce çarpma-bölme sonra toplama-çıkarma işlemleri yapılır
    grade = (midterm1 * 30/100) + (midterm2 * 0.3) + (final * 0.4);
    Console.WriteLine("Yılsonu not ortalaması: " + grade);