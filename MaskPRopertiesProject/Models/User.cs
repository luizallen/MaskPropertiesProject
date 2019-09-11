using System;
using MaskPropertiesProject.Attributes;

namespace MaskPropertiesProject.Models
{
    public class User 
    {
        [IdAtt]
        public int Id { get; set; }

        [NameAtt]
        public string Name { get; set; }

        [DateAtt]
        public DateTime CreatedAt { get; set; }

        public User(int id, string name, DateTime createdAt)
        {
            Id = id;
            Name = name;
            CreatedAt = createdAt;
        }
    }
}