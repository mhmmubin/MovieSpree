﻿using MovieSpree.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieSpree.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedtonewsLetter { get; set; }

        //[Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }
        public MembershipTypeDto MembershipType { get; set; }

        public byte MembershipTypeId { get; set; }



    }
}