﻿using Eisk.Domains.Employee.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eisk.Domains.Employee.Models.Bases
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Title of Courtesy")]
        public TitleOfCourtesy? TitleOfCourtesy { get; set; }

        [Required(ErrorMessage = "First name required.")]
        [StringLength(10)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name required.")]
        [StringLength(20)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Birth Date")]
        public DateTime? BirthDate { get; set; }

        //public Address Address { get; set; }

        [Required(ErrorMessage = "Phone required")]
        [StringLength(24)]
        public string Phone { get; set; }

        [StringLength(4)]
        public string Extension { get; set; }

        [DataType(DataType.MultilineText)]
        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }

    }
}