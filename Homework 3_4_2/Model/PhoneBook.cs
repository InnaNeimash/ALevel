using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_4_2.Model
{
    public class PhoneBook
    {
        public string FoolName { get; set; }
        public string Number { get; set; }
        public override string ToString()
        {
            return $"Fool name {FoolName}| phone number {Number}";
        }
    }
}
