using System;
namespace patterns.Behavioral.MVC
{
    public class StudentController
    {
        private Student _model; 
        private StudentView _view; 

        public StudentController(Student model, StudentView view)
        {
            this._model = model;
            this._view = view;
        }

        public void SetStudentName(String name)
        {
            _model.Name=name;
        }

        public String GetStudentName()
        {
            return _model.Name;
        }

        public void SetStudentRollNo(String rollNo)
        {
            _model.RollNo=rollNo;
        }

        public String GetStudentRollNo()
        {
            return _model.RollNo;
        }

        public void UpdateView()
        {
            _view.PrintStudentDetails(_model.Name, _model.RollNo);
        }
    }
}
