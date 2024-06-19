using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadDB_ADO_sample.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string address { get; set; }

        public Student(int id, string name, int age, string address)
        {
            Id = id;
            this.name = name;
            this.age = age;
            this.address = address;
        }
    }
}
