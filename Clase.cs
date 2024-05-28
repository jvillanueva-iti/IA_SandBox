public class Clase
{
    public string nombre { get; set; }
    public int ID { get; set; }

    public string test()
    {
        string result = "";
        
        for (int i = 0; i < 1000; i++)
        {
            result += i.ToString();
        }

        return "Clase";
    }
}