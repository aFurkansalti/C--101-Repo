namespace Değişkenler;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        byte b = 5; // 1 byte  0 to 255
        sbyte c = 5; // 1 byte  -128 to 127 

        short s = 5; // 2 byte  -32768 to 32767
        ushort us = 5; // 2 byte  0 to 65535

        Int16 i16 = 2; //2 byte   -32768 to 32768
        int i = 2; // 4 byte   -2147483648 to 2147483647
        Int32 i32 = 2; // 4 byte   -2147483648 to 2147483648
        Int64 i64 = 2; // 8 byte   -9223372036854775808 to 9223372036854775807

        uint ui = 2;  //4 byte  0 to 4,294,967,295
        long l = 4 ; // 8 byte  -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        ulong ul = 4; // 8 byte    0 to 18,446,744,073,709,551,615

        //Real sayılar
        float f = 5f; // 4 byte  ±1.5 x 10^−45 to ±3.4 x 10^38
        double d = 5; // 8 byte     ±5.0 × 10^−324 to ±1.7 × 10^308
        decimal de = 5m; // 16 byte      ±1.0 x 10^-28 to ±7.9228 x 10^28

        char ch = '2'; // 2 byte yer kaplar
        string str = "Kaan"; // Sınırsız

        bool b1 = true;
        bool b2 = false;

        DateTime dt = DateTime.Now;
            
        Console.WriteLine(dt);

        object o1 = "x";
        object o2 = 'y';
        object o3 = 4;
        object o4 = 4.3;

        // string ifadeler

        string str1 = string.Empty;
        str1 = "Kaan AKCAN";
        string ad = "Mehmet Kaan";
        string soyad = "AKCAN";
        string tamisim = ad + " " + soyad;

        // integer 

        int integer1 = 5;
        int integer2 = 3;
        int integer3 = integer1 + integer2;

        // boolean

        bool bool1 = 10>2;

        // Degisken Dönüşümleri
        string str20 = "20";
        int int20 =20;
        string yeniDeger = str20 + int20.ToString();
        Console.WriteLine(yeniDeger); // Çıktısı 2020

        int int21 = int20 + Convert.ToInt32(str20); 
        Console.WriteLine(int21); // çıktısı 40

        int int22 = int20 + int.Parse(str20); // Çıktısı 40

        // datetime

        string datetime = DateTime.Now.ToString("dd.MM.yyyy");
        Console.WriteLine(datetime);

        //saat
        datetime = DateTime.Now.ToString("HH:mm");
        Console.WriteLine(datetime);

        Console.ReadLine();

    }
}
