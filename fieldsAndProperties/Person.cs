using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fieldsAndProperties
{
    public class Person
    {
        private string _firstName; //Backing field
        private string _lastName;//Backing field
        private string _SSN;//Backing field

        public Person(string first, string last, string ssn)
        {
            _firstName = first;//initialize backing field
            _lastName = last;//initialize backing field
            _SSN = ssn;//   initialize backing field
        }

        public string SSN
        {
            set
            {
                // Replace 'valid_condition' with your actual validation logic
                bool valid_condition = !string.IsNullOrWhiteSpace(value);
                if (!valid_condition)
                {
                    Console.WriteLine("Input is not accepted.");
                    return;
                }
                _SSN = value;
            }
        }
    }
}

