﻿using System;

namespace CSharpClasses
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
}
