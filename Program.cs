﻿using System;

public class exchar
{
    static void Main(string[] args)
    {
        char chr;

        Console.WriteLine("Enter the character: ");
        chr = Convert.ToChar(Console.ReadLine());

        // Alphabet checking condition
        if ((chr >= 'a' && chr <= 'z') || (chr >= 'A' && chr <= 'Z'))
        {
            Console.WriteLine(chr + " is an Alphabet. ");
        }
        else if (chr >= '0' && chr <= '9')
        {
            Console.WriteLine(chr + " is a Digit. ");
        }
        else
        {
            Console.WriteLine(chr + " is a Special character.. ");
        }

        Console.ReadLine();
    }
}