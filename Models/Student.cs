﻿using Swashbuckle.AspNetCore.Annotations;


namespace lab7.Models
{
    public class Student
    {
        
        [SwaggerSchema(ReadOnly = true)]
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Program { get; set; }
    }
}

