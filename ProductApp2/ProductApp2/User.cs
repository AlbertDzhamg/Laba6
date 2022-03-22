﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp2
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; } // внешний ключ
        public Company Company { get; set; } // навигационное свойство
    }
}
