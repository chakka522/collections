using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesDemo
{
        class Program
        {
            static void Main(string[] args)
            {

            //Student student = new Student();
            //student.StudentId = 00120;
            //student.StudentName = "Kiran";

            //int res = student.addmarks(95, 96);
            ////string

            Console.WriteLine("Enter your city");
            string city = Console.ReadLine();

            Console.WriteLine("enter your pincode");
            int pin = Convert.toint32(console.readline());

            //collecting min interger            
            console.writeline("enter county code : ");
            short ccode = convert.toint16(console.readline());

            //collecting max interger
            console.writeline("enter your phonenumber");
            long phone = convert.toint64(console.readline());

            //collecting true or false interger
            console.writeline("are you are an indian?");
            bool iscitizen = convert.toboolean(console.readline());

            //collecting true or false interger
            console.writeline("enter your gender ('m' for male and 'f' for female)");
            char gender = convert.tochar(console.readline());



            console.writeline("=====================================");
            console.writeline("user input city is : " + city + " " + " and pincode is : " + pin + "and country code is : " + ccode);
            console.writeline("and pincode is : " + pin);
            console.writeline("and country code is : " + ccode);
            console.writeline("and phone number is : " + phone);
            console.writeline("and he/she is an indian citizen : " + iscitizen);
            console.writeline("and gender is : " + gender);
            console.writeline("=====================================");
            console.readline();

           // object ------classname objectname = new(keyword) classname
            candidate candi = new candidate();

            console.writeline("enter your candidate sno");
            candi.sno = convert.toint32(console.readline());

            console.writeline("enter your candidate name");
            candi.cname = console.readline();

            console.writeline("enter your candidate college name");
            candi.collegename = console.readline();

            console.writeline("candidate sno is : " + candi.sno + " " + "candidate name is : " + candi.cname + "candidate college name :" + candi.collegename);
            console.readline();
        }
        }

        //Access Specifier - Public or Private

        //Access Specifier "Keyword - class" "Name for the Class" { }
        public class employee
        {
            public int sNo;

            public string CName;

            public long Mobile;
        }

        public class Candidate
        {
            public int sNo;

            public string CName;

            public long Mobile;

            public string Email;

            public int SupersetId;

            public string CollegeName;
        }
    }
