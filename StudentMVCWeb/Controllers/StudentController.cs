using Microsoft.AspNetCore.Mvc;
using StudentMVCWeb.Data;
using StudentMVCWeb.Models;

namespace StudentMVCWeb.Controllers
{
    public class StudentController : Controller
    {
        public readonly DataContext _db;

        public StudentController(DataContext db)
        {
                _db = db;
        }
        public IActionResult Index()
        {
            try
            {
                return View(_db.students);
            }
            catch(Exception aa)
            {
                return View(aa.Message.ToString());
            }
        }

        public IActionResult AddStudent(int Id)
        {
            try
            {
                if (Id == 0)
                    return View();
                else
                    return View(_db.students.Find(Id));
            }
            catch(Exception aa)
            {
                return View(aa.Message.ToString());
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent(Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (student.Id == 0)
                        _db.students.Add(student);
                    else
                        _db.students.Update(student);

                    await _db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception aa)
            {
                return View(aa.Message.ToString());
            }
            return View();
        }

        //public IActionResult Edit(int Id)
        //{
        //    Student stu = _db.students.Find(Id);
        //    if(stu != null)
        //    {

        //    }

        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> Edit(Student student)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            _db.students.Add(student);
        //            await _db.SaveChangesAsync();
        //            return RedirectToAction("Index");
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return View();
        //    }
        //    return View();
        //}

        
        public IActionResult Delete(int? Id)
        {
            try
            {
                 Student? stu  = _db.students.Find(Id);
                _db.students.Remove(stu);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception aa)
            {
                return View(aa.Message.ToString());
            }
        }
    }
}
