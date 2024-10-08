﻿using RestWithASPNET5.Controllers.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNET5.Controllers.Model
{
    [Table("person")]
    public class Person : BaseEntity
    {
        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("gender")]
        public string Gender { get; set; }

        [Column("enabled")]
        public bool Enabled { get; set; }

        [Column("birth_date")]
        public DateTime? BirthDate { get; set; }
    }
}
