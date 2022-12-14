using System;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        //Principio SRP, se usa el patrón de única responsabilidad
        public void PrintBuilding(Building building)
        {
            Console.WriteLine(building.PrintBuilding());
        }
    }
}