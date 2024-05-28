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
        
        if(IsBoolMethod () == false)  
        {  
            // code  
        }  

        return "Clase";
    }
}