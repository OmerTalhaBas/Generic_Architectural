﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Mimari
{
    internal class BaseEntity<T> : Repository<T> where T : class //Inheritance-Kalıtım-Miras alma
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifieldOn { get; set; }
        public DateTime DeletedOn { get; set; }

    }
}