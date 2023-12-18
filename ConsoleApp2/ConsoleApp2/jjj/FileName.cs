using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public class PublicClass
{
    private object field;
    public object Property { get; set; }

    public PublicClass()
    {
        Print("constructor vyzvan");
    }

    public PublicClass(object propertyValue) : this()
    {
        Property = propertyValue;
    }

    public void VoidMethod()
    {
        int result = IntMethod(10);
        Console.WriteLine("resultaty: " + result);
    }

    private int IntMethod(int number)
    {
        return number;
    }

    public static void Print(string text)
    {
        Console.WriteLine(text);
    }

    public void VoidMethod(int param)
    {
        Console.WriteLine("Vyzvan VoidMethod s parametrom: " + param);
    }
}