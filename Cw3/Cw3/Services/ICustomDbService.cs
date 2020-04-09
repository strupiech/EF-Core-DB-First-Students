﻿using System.Collections.Generic;
using Cw3.Models;

namespace Cw3.Services
{
    public interface ICustomDbService
    {
        public IEnumerable<Student> GetStudents();
        
        public Student GetStudent(string id);
    }
}