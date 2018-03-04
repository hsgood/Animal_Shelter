using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Customer
    {
        public string FirstName;
        public string LastName;
        private DateTime _Birthday;
        //private int _Age;
        private bool _IsQualified;
        public string Address;
        public string Description;

        public Customer(string firstname, string lastname, DateTime birthday)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            //this._Age = age;
            this._Birthday = birthday;

            //this._IsQualified = age >= 18;
            this._IsQualified = Age >= 18;
        }

        public DateTime Birthday
        {
            get { return _Birthday; }
            set
            {
                _Birthday = value;
                _IsQualified = Age >= 18;
            }
        }

        // private 로 선언된 속성은 읽고 쓸수 있는 메소드를 만들어 준다
        /**
        public int GetAge()
        {
            return _Age;
        }
        public void SetAge(int age)
        {
            _Age = age;
            _IsQualified = age >= 18;
        }
        **/


        //속성 정의
        public int Age
        {
            get { return DateTime.Now.Year - _Birthday.Year; }
        }

        /**
        public int Age
        {
            get { return _Age; }
            set
            {
                _Age = value;  //value는 int로 들어오는 매개변수이다
                _IsQualified = value >= 18;
            }
        }
        **/

        /**
        public bool GetIsQualified()
        {
            return _IsQualified;
        }
        **/

        public bool IsQualified
        {
            get
            {
                return _IsQualified;
            }
        }


        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
