﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent_Interface_Inheritance
{
    public abstract class PersonBuilder
    {
        protected Person person = new Person();
        public Person Build()
        {
            return person;
        }
    }
}
