using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal static class StaticClass
{
    public static void Extension(this PublicClass publicClassInstance)
    {
        Console.WriteLine("Extension method called for PublicClass instance.");
        publicClassInstance.VoidMethod();
    }
}