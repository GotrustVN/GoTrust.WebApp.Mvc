﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payment.SharedUltilities.Extensions
{
    public static class StringExtension
    {
        public static string FirstCharToUpper(this string input) =>
        input switch
        {
            null => throw new ArgumentNullException(nameof(input)),
            "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
            _ => input.First().ToString().ToUpper() + input.Substring(1)
        };

        public static string FirstCharToLower(this string input) =>
        input switch
        {
            null => throw new ArgumentNullException(nameof(input)),
            "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
            _ => input.First().ToString().ToLower() + input.Substring(1)
        };
    }
}
