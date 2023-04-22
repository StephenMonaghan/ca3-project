using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca3
{
    

    
      public  class PassengersData
        {
            private string _firstName;
            private string _lastName;
            private string _gender;
            private string _age;
           private string _nativeCountry;
            private string _occupation;
            private string _destination;
            private string _embarkationPort;
            private string _mainifestIdentification;
            private string _arivalDate;




            public string FirstNamee
            {
                get { return _firstName; }
                set { _firstName = value; }
            }
            public string LastName
            {
                get { return _lastName; }
                set { _lastName = value; }
            }

            public string Gender
            {
                get { return _gender; }
                set { _gender = value; }
            }

            public string  Age
            {
                get { return _age; }    
                set { _age = value; }
            }

            public string NativeCountry
            {

                get { return _nativeCountry; }  
                set { _nativeCountry = value; }
            }

            public string Occupation
            {
                get { return _occupation; }
                set { _occupation = value; }
              
            }
            public string Destination
            {
                get { return _destination; }
                set { _destination = value; }
            }
            public string EmbarkationPort
            {
                get { return _embarkationPort; }
                set { _embarkationPort = value; }

            }
            public string MainifestIdentification
            {
                get { return _mainifestIdentification; }
                set { _mainifestIdentification = value; }
              
            }

            public string ArivalDate
            {
                get { return ArivalDate; }
                set { _arivalDate = value; }

            }

            public PassengersData (string firstName , string lastName,string gender,string age,string nativeCountry,string occupation,string destination,
                string embarkationPort,string mainifestIdentification, string  arivalDate)
            {
                _firstName=firstName;
                _lastName=lastName;
                _gender=gender;
                _age=age;
                _nativeCountry=nativeCountry;
                _occupation=occupation;
                _destination=destination;
                    _embarkationPort=embarkationPort;
                _mainifestIdentification=mainifestIdentification;
                _arivalDate=arivalDate;

            }






        }
    }
 
    









