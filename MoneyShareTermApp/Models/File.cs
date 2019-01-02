﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneyShareTermApp.Models
{
    [Table("file")]
    public partial class File
    {
        public File()
        {
            Person = new HashSet<Person>();
        }

        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        public string Name { get; set; }
        [Required]
        [Column("link")]
        public string Link { get; set; }
        [Column("post_id")]
        public int? PostId { get; set; }

        [ForeignKey("PostId")]
        [InverseProperty("File")]
        public virtual Post Post { get; set; }
        [InverseProperty("Photo")]
        public virtual ICollection<Person> Person { get; set; }
    }
}