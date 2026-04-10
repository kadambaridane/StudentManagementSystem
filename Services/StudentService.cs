using StudentManagementSystem.Models;
using StudentManagementSystem.Repositories;
using StudentManagementSystem.Services;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _repo;

    public StudentService(IStudentRepository repo)
    {
        _repo = repo;
    }

    public async Task<List<Student>> GetAll()
    {
        return await _repo.GetAll();
    }

    public async Task<Student?> GetById(int id)
    {
        return await _repo.GetById(id);
    }

    public async Task<Student> Add(Student student)
    {
        return await _repo.Add(student);
    }

    public async Task<Student?> Update(int id, Student student)
    {
        var existing = await _repo.GetById(id);
        if (existing == null) return null;

        existing.Name = student.Name;
        existing.Email = student.Email;
        existing.Age = student.Age;
        existing.Course = student.Course;

        return await _repo.Update(existing);
    }

    public async Task<bool> Delete(int id)
    {
        return await _repo.Delete(id);
    }
}