namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter
    {
        //Utilizamos el patrón de polimorfismo 
        void Print(IStringConverter stringConverter);
    }
}