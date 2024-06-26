﻿using System.ComponentModel.DataAnnotations;

namespace FlickFlow.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name ="Full Name")]
        public string FullName { get; set; }
        [Display(Name ="Biogrpahy")]
        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
