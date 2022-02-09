using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._3
{
    enum Grade
    {
        A, B, C, D, F
    }

    enum MonthOfAdmission
    {
        Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec
    }

    enum House
    {
        Gryffindor, Hufflepuff, Ravenclaw, Slytherin
    }

    struct Student
    {
        public int StudID { get;set;}
        public string FirstName { get;set;}
        public string LastName { get;set;}
        public string Address { get;set;}
        public Grade Grade { get;set;}
        public MonthOfAdmission MonthOfAdmission { get; set;}
        public House House { get; set;}
    }
}
