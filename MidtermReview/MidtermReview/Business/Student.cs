using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MidtermReview.DataAccess;

namespace MidtermReview.Business
{
    public  class Student
    {
        private  int studentNumber;
        private string firstname;
        private string lastname;
        private string email;

        public int StudentNumber { get => studentNumber; set => studentNumber = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Email { get => email; set => email = value; }
        public Student SearchStudent(int sId)
        {
            return (StudentDB.SearchRecord(sId));
        }

    }
}