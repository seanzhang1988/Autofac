using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IRepository
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
    }
}
