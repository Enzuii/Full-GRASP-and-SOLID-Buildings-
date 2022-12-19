using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter : IPrinter
    {
        //Principio SRP, se usa el patrón de única responsabilidad
        public void Print(IStringConverter stringConverter)
        {
            Console.WriteLine(stringConverter.PrintBuilding());
        }
    }
}