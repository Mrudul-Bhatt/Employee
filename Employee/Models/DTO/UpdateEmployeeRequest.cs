﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Models.DTO
{
    public class UpdateEmployeeRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long Salary { get; set; }
        public string Department { get; set; }
    }
}
