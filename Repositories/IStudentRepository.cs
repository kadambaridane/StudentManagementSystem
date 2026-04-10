using StudentManagementSystem.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentManagementSystem.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAll();
        Task<Student> GetById(int id);
        Task<Student> Add(Student student);
        Task<Student> Update(Student student);
        Task<bool> Delete(int id);
    }
}
