﻿using System;


namespace methodsAndObjects
{
    // Employee : Person is the inheritance statement
    public class Employee : Person, IQuittable
    {
            public int Id  { get; set; }

        public void Quit()
        {
            Console.WriteLine("Would you like to quit?");
        }
        
    }
}
