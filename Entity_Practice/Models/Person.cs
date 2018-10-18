using System.ComponentModel.DataAnnotations;

namespace Entity_Practice.Models
{
    public class Person
    {
        [Key]
        public int PersonId {get;set;}
        public string Name {get;set;}
        public string Email {get;set;}
        public string Password {get;set;}
        public int Age {get;set;}
        
        public int DoubleTheAge
        {
            get {return Age * 2;}
        }
    }
}