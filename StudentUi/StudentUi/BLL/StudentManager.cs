using System.Data;
using System.Collections.Generic;
using StudentUi.Repository;
using StudentUi.Model;

namespace StudentUi.BLL
{
    class StudentManager
    {
        StudentRepository _studentRepository = new StudentRepository();
        
        public bool Add(Student student)
        {
            return _studentRepository.Add(student);
        }

        public DataTable Display()
        {
            return _studentRepository.Display();
        }

        public bool SelectById(Student student)
        {
            return _studentRepository.SelectById(student);
        }

        public bool Update(Student student)
        {
            return _studentRepository.Update(student);
        }
        public bool IsNameExist(Student student)
        {
            return _studentRepository.IsNameExist(student);
        }
        public bool IsContactExist(Student student)
        {
            return _studentRepository.IsContactExist(student);
        }
        public List<Student> Search(Student student)
        {
            return _studentRepository.Search(student);
        }
    }
}
