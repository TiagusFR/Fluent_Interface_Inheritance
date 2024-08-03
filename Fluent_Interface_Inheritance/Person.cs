using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent_Interface_Inheritance
{
    public class Person
    {
        public class Builder : PersonJobBuilder<Builder>
        {
            internal Builder() { }
        }

        public static Builder New => new Builder();

        public string Name { get; set; }
        public string Position { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
