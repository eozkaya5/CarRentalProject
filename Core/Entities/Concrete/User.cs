using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public byte[] Email { get; set; }
        public byte[] Password { get; set; }
        public bool Status { get; set; }


    }
}
