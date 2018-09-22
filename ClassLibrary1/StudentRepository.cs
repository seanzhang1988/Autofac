using IRepository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{

    public class StudentRepository : IStudentRepository
    {
        private List<Student> Articles = new List<Student>(){
            new Student { name = "张三", gender = "male", age = 12 },
            new Student { name = "李四", gender = "fmale", age = 15 },
            new Student { name = "王五", gender = "fmale", age = 13 }};

        /// <summary>
        /// 获取全部学生信息
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Student> GetAll()
        {
            return Articles;
        }
    }
}

