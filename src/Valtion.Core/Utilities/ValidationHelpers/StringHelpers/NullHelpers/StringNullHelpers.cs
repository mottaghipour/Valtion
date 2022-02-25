﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valtion.Core.Utilities.Exceptions.StringExceptions;

namespace Valtion.Core.Utilities.ValidationHelpers.StringHelpers
{
    public static class StringNullHelpers
    {
        /// <summary>
        /// String should not be <see langword="null"/> helper
        /// </summary>
        /// <param name="value"></param>
        /// <returns>String <paramref name="value"/></returns>
        /// <exception cref="StringNullReferenceException"></exception>
        public static string ShouldNotBeNull(this string value, string message = "String null reference exception occurred;")
        {
            if (value == null)
                StringNullReferenceException.Throw();

            return value;
        }
    }
}