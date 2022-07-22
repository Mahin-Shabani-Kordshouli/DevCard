using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devcard_MVC.Models
{
    public class Project
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Client { get; set; }
        public  string  Image { get; set; }

        public Project(long id, string name , string description, string image ,string client )
        {
            Id = id;
            Description = description;
            Name = name;
            Client = client;
            Image = image;
        }
    }

    
    
}
