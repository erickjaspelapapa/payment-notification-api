﻿using System;
using System.Collections.Generic;
using System.Text;

namespace xRepository._91128
{
    public interface IEntity
    {
        int uid { get; set; }
        DateTime created_dt { get; set; }
        DateTime updated_dt { get; set; }
    }
}