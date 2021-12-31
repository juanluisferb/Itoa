using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

// Tiempo empleado: 1.5 horas
public class IntegerToString
{
    public static void Main(string[] args)
    {
        int value = 769;
        int base_n = 10;

        IntegerToString integerToString = new IntegerToString();

        Console.WriteLine(integerToString.itoa(value, base_n));
        Console.In.ReadLine();
    }


    string itoa(int num, int base1)
    {

        string stringBuffer = "0123456789ABCDEF";
        string charBuffer = string.Empty;

        //Se calcula el resto entre el número y la base, y se extrae de la posición del stringBuffer.
        //Se anexa al string que se va a componer.
        charBuffer += stringBuffer[num % base1];

        //En el bucle se repite el proceso pero dividiendo previamente el número entre la base siempre que éste sea mayor que ella.
        while (num > base1)
        {
            num /= base1;
            charBuffer += stringBuffer[num % base1];

        }

        //Obtenemos los dígitos en un string, pero hay que invertirlo
        return ReverseString(charBuffer);

    }

    //Método que devuelve un string revertido intercambiando elementos desde el principio y el final hasta la mitad de la cadena
    static string ReverseString(string s)
    {
        char[] rstring = new char[s.Length];
        for (int i = 0, j = s.Length - 1; i <= j; i++, j--)
        {
            rstring[i] = s[j];
            rstring[j] = s[i];
        }

        return new string(rstring);
    }
}