using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorUAS276.Models;

namespace BlazorUAS276.Services
{
    public interface IStudentService
    {
         Task<IEnumerable<Student>> GetAll();
         Task<Student> GetById(string studentID);
        
    }
}