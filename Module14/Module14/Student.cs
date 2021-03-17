using System;
using System.Collections.Generic;
using System.Text;

namespace Module14
{
    public class Student
    {
        public string Name { get; internal set; }
        public int Age { get; internal set; }
        public List<string> Languages { get; internal set; }
    }
}
