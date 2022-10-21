using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProjects_Dev_Extreme.Models
{
    public class StudentsData
    {
        public static List<Student> aaa = new List<Student>()
        {
            new Student
            {
                SchedulerID = 1,
                DoB = new DateTime(2000,07,26),
                Name = "Tran Huu Sang",
                Address = "Binh Tan",
                ClassStudent = "A3",
                Maths = 8,
                Physical = 9,
                Chemistry = 7,
                


            },
            new Student
            {
                SchedulerID= 2,
                DoB= new DateTime(2001,03,05),
                Name =" Tran Duc Toan",
                Address ="Long An",
                ClassStudent = "A3",
                Maths = 5,
                Physical = 6,
                Chemistry = 7,
            },
            new Student
            {
                SchedulerID = 3,
                DoB = new DateTime(1995, 12, 05),
                Name = "Ta Thai Bao",
                Address = "Long An",
                ClassStudent = "B5",
                Maths = 8,
                Physical = 9,
                Chemistry = 9,

            },
            new Student
            {
                SchedulerID = 4,
                DoB = new DateTime(2000, 03, 05),
                Name = "Nguyen Van A",
                Address = "nha trang",
                ClassStudent = "B5",
                Maths = 8,
                Physical = 8,
                Chemistry = 7,
            },
            new Student
            {
                SchedulerID = 5,
                DoB = new DateTime(1995, 12, 05),
                Name = "Nguyen Van B",
                Address = "Long An",
                ClassStudent = "B9",
                Maths = 7,
                Physical = 6,
                Chemistry = 7,
            },
             new Student
             {
                 SchedulerID = 6,
                 DoB = new DateTime(1996, 11, 08),
                 Name = "Nguyen Van C",
                 Address = "HCM",
                 Maths = 8,
                 Physical = 9,
                 Chemistry = 7,
             },
              new Student
              {
                  SchedulerID = 7,
                  DoB = new DateTime(2003, 09, 15),
                  Name = "Nguyen Van D",
                  Address = "Dĩ An",
                  ClassStudent = "A1",
                  Maths = 8,
                  Physical = 9,
                  Chemistry = 9,
              },
               new Student
               {
                   SchedulerID = 8,
                   DoB = new DateTime(1995, 12, 05),
                   Name = "Nguyen Van F",
                   Address = "Da Nang",
                   ClassStudent = "A9",
                   Maths = 5,
                   Physical = 4,
                   Chemistry = 4,
               },
        };
    }
}