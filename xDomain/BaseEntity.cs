﻿using xRepository._91128;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace xDomain._91128
{
    public abstract class BaseEntity : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public DateTime created_dt { get; set; }
        public DateTime updated_dt { get; set; }
        //protected BaseEntity()
        //{
        //    created_dt = DateTime.Now;
        //    updated_dt = DateTime.Now;
        //}
    }
}
