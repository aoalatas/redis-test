using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace redis_test.api.Models
{
    public class TestModel
    {
        public TestModel()
        {

        }

        public TestModel(string name, string lastName)
        {
            Id = Guid.NewGuid();
            Name = name;
            LastName = lastName;            
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}

