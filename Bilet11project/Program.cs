// bilet 11 egor maximenko
// напиши программу на языке с# для вычисления значения выражения y = (x - 10) / (x * 10)
{ 
        Console.WriteLine("Vvedite znachenie x:");
        double x = Convert.ToDouble(Console.ReadLine());

        double y = (x - 10) / (x * 10);

        Console.WriteLine("Znachenie y: " + y);

}