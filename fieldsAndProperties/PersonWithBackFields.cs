using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace fieldsAndProperties
{

    internal class PersonWithBackFields
    {
        private string _firstName; //Backing field
        private string _lastName;//Backing field
        private string _SSN;//Backing field
        private DateTime _dob;//Backing field

       
        public PersonWithBackFields(string first, string last, string ssn, DateTime dob)
        {
            
            _firstName = first;//initialize backing field
            _lastName = last;//initialize backing field
            _SSN = ssn;//   initialize backing field
            _dob = dob;//   initialize backing field
        }
        public DateTime DOB
        {
            get
            {

                if (_dob != null && _dob < DateTime.Now)
                    return _dob;
                else
                    return new DateTime(0, 0, 0); //default date
            }

        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (value.Length < 1)
                {
                    Console.WriteLine("Input is not accepted.");
                    return;
                }
                _lastName = value;
            }
        }
        public String Name => $"{_firstName} {_lastName}";
    
}

}
