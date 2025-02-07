﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NETCore.Models
{
    [Table("tb_m_universities")]
    public class University
    {
        [Key] //anotasi primari key
        public int UniversityId { get; set; }

        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<Education> Educations { get; set; }

    }
}
