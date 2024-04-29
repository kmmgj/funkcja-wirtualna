using System;

public class Kształt

{

    public virtual double ObliczPowierzchnię()

    {

        return 0;

    }



    public virtual double ObliczObwód()

    {

        return 0;

    }

}



public class Prostokąt : Kształt

{

    public double Szerokość { get; set; }

    public double Wysokość { get; set; }



    public Prostokąt(double szerokość, double wysokość)

    {

        Szerokość = szerokość;

        Wysokość = wysokość;

    }



    public override double ObliczPowierzchnię()

    {

        return Szerokość * Wysokość;

    }



    public override double ObliczObwód()

    {

        return 2 * (Szerokość + Wysokość);

    }

}



public class Koło : Kształt

{

    public double Promień { get; set; }



    public Koło(double promień)

    {

        Promień = promień;

    }



    public override double ObliczPowierzchnię()

    {

        return Math.PI * Promień * Promień;

    }



    public override double ObliczObwód()

    {

        return 2 * Math.PI * Promień;

    }

}



class Program

{

    static void Main(string[] args)

    {

        // Tworzymy prostokąt 

        Prostokąt prostokąt = new Prostokąt(5, 3);

        Console.WriteLine("Prostokąt:");

        Console.WriteLine("Powierzchnia: " + prostokąt.ObliczPowierzchnię());

        Console.WriteLine("Obwód: " + prostokąt.ObliczObwód());



        // Tworzymy koło 

        Koło koło = new Koło(4);

        Console.WriteLine("\nKoło:");

        Console.WriteLine("Powierzchnia: " + koło.ObliczPowierzchnię());

        Console.WriteLine("Obwód: " + koło.ObliczObwód());

    }

}
