using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listbox_Datasource_demo
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
//        public string Grade { get; set; }
        public override string ToString() => $" {Name}, {Age}"; // щоб відображати ім'я студента у ListBox
    }
}
