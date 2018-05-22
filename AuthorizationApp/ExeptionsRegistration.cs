using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizationApp
{
    static class ExeptionsRegistration
    {
        public enum Exeption
        {
            login = 1,
            password=2
        }

        public static string  WhatException(int exp)
        {
            return " ";
        }
    }
}
