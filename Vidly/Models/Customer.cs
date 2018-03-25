using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }

        public Customer()
        {
            Id = 0;
            Name = "";
        }
        public Customer(string name)
        {
            this.Name = name;
        }

        public Customer(int custId,string name)
        {
            this.Id = custId;
            this.Name = name;
        }
    }
}