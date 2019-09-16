using System;

namespace Cars
{
    public class Class1
    {
        private string _make;
        private string _model;
        private int _year;

        public Class1()
        {
            Make = "";
            Model = "";
            Year = 0;
        }
        public Class1(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public string Make
        {
            get
            {
                return _make;
            }

            set
            {
                _make = value;
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }

            set
            {
                _model = value;
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }

            set
            {
                _year = value;
            }
        }
    }
}
