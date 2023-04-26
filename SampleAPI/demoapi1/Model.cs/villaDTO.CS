using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace demoapi1.Model
{
    public class villaDTO
    {
        
    public int Id {get; set;}
    [Required]
    [MaxLength(30)]
    public string Name {get; set;}
     
     public int Occupancy{get;set;}
     public int sqft{get;set;} 

    } 
}