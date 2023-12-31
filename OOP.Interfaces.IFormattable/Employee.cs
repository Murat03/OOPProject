﻿
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces.IFormattable
{
    public class Employee : System.IFormattable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{Title} {FirstName} {LastName}";

        public override string ToString()
        {
            return this.ToString("F", CultureInfo.CurrentCulture);
        }
        public string ToString(string? format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }
        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            if(String.IsNullOrEmpty(format))
            {
                format = "F";
            }
            if(formatProvider == null)
            {
                formatProvider = CultureInfo.CurrentCulture;
            }
            switch(format.ToUpper()) 
            {
                case "F":
                    return $"{Id, -5} {Title, -15} {FirstName, -15} {LastName,-15}";
                case "FL":
                    return $"{FirstName} {LastName}";
                case "S":
                    return $"{LastName} {FirstName[0]}.";
                default:
                    throw new FormatException(String.Format($"The {format} is not supported"));
            }
        }
    }
}
