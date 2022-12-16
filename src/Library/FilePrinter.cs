using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public class FilePrinter : IPrinter
    {
        //Principio SRP, se usa el patrón de única responsabilidad
        public void PrintBuilding(Building building)
        {
            File.WriteAllText("Building.txt", building.PrintBuilding());
        }
    }
}