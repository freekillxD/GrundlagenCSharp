// See https://aka.ms/new-console-template for more information


int x = 9,z = 6; double y = 8;


Console.WriteLine(x-- == y);
//False


Console.WriteLine(x == (int)y);
//True


Console.WriteLine("{0:F1}", 0.123);
//0,1


Console.WriteLine(z / y);
//0,75


Console.WriteLine(x -= 10);
//-2


Console.WriteLine(x-- == y & true);
//False


Console.WriteLine(!(z == 6) | false);
//False


Console.WriteLine((x *= -2) == z);
//True





Console.WriteLine("was wollen sie nehmen");



Console.WriteLine("1) Celsius nach fahrenheit");
Console.WriteLine("2) Celsius nach Kelvin");
Console.WriteLine("3) Kelvin nach Celsius");
Console.WriteLine("4) Kelvin nach fahrenheit");



int x = Convert.ToInt32(Console.ReadLine());




if (x == 1)
{
    Console.WriteLine("gib eine zahl ein");



   int zahl1 = Convert.ToInt32(Console.ReadLine());



   
    
    Console.WriteLine(zahl1 * 1.8 + 32);
    Console.ReadLine();




}






if (x == 2)
{
    Console.WriteLine("gib eine zahl ein");



   int zahl1 = Convert.ToInt32(Console.ReadLine());





   Console.WriteLine(zahl1 + 273.15);



   Console.ReadLine();



}





if (x == 3)
{
    Console.WriteLine("gib eine zahl ein");



   int zahl1 = Convert.ToInt32(Console.ReadLine());





   Console.WriteLine(273.15 + zahl1);



   Console.ReadLine();




}





if (x == 4)
{
    Console.WriteLine("gib eine zahl ein");



   int zahl1 = Convert.ToInt32(Console.ReadLine());





   Console.WriteLine(zahl1 * 9/5 + 32);



   Console.ReadLine();



}



Console.ReadKey();
