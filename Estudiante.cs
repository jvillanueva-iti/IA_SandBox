public class Estudiante : Persona
{
    public void Estudiar() 
    {
        Console.WriteLine("Estoy estudiando");
    }
 
    public void VerEdad()
    {
        Console.WriteLine("My edad es {0}", edad);
    }
}