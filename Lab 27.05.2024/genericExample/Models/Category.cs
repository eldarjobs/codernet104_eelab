using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericExample.Models
{
    public class Category : IEntity
    {
        private static int _id;
        public Category()
        {
            Id = _id;
            _id++;
        }
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

    }

}

