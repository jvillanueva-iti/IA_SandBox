public class Clase
{
    public string nombre { get; set; }
    public int ID { get; set; }

    public string test()
    {
        try
        {
        string result = "";
        
        for (int i = 0; i < 1000; i++)
        {
            result += i.ToString();
        }

        bool isTrue= true;  
  
        if(isTrue == true)  
        {  
            // Code  
        }  
        
        if(isTrue == false)  
        {  
            // code  
        }  
        
        bool IsBoolMethod()  
        {  
            return true;  
        }  
        try
        {
            if(IsBoolMethod () == false)  
            {  
                // code  
            }
        }
        catch(Exception ex){}  
        }
        catch(Exception ex) {}


        return "Clase";
    }
}
