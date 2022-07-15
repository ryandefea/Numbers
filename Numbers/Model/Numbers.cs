using System.Collections.Generic;

namespace Numbers.Models
{
  public class Number
  {
    public int Content { get; set;}

    public string Translator (int number)
    {
      return "four";
    }
    

    // public int number ()
    // {

    // }

    public Number(int content)
    { 
      Content = content;
      
    }

  }
}