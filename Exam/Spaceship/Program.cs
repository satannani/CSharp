using System;

class Spacecraft
{
    static void Main()
    {
       
        double width = double.Parse(Console.ReadLine());
        double length = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double averageAstronautHeight = double.Parse(Console.ReadLine());

        // volume of the spaceship
        double spacecraftVolume = width * length * height;

        //volume of one room
        double roomHeight = averageAstronautHeight + 0.4;
        double roomVolume = roomHeight * 2 * 2;

       
        int numberOfAstronauts = (int)(spacecraftVolume / roomVolume);

        if (numberOfAstronauts >= 3 && numberOfAstronauts <= 10)
        {
            Console.WriteLine($"The spacecraft holds {numberOfAstronauts} astronauts.");
        }
        else if (numberOfAstronauts < 3)
        {
            Console.WriteLine("The spacecraft is too small.");
        }
        else
        {
            Console.WriteLine("The spacecraft is too big.");
        }
    }
}
