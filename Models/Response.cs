using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Response
    {
        [Key]
        public int ResponseId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string? name { get; set; }
        [Required(ErrorMessage = "Please enter a problem.")]
        public string? problem { get; set; }
        [Required(ErrorMessage = "Please enter an state.")]
        public string? state { get; set; }
        [Required(ErrorMessage = "Please enter an zipcode.")]
        public string? zipcode { get; set; }
        [Required(ErrorMessage = "Please enter an address.")]
        public string? address { get; set; }
        [Required(ErrorMessage = "Please enter a priority.")]
        public string? priorityId { get; set; }
        public Priority priority { get; set; }

        public string? printResponse()
        {
            return "Name: " + name + " Problem: " + " Address: " + address + ", " + state + " " + zipcode; 
        }
    }
}
