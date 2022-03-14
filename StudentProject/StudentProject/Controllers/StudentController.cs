using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentProject.Models;

namespace StudentProject.Controllers
{
    public class StudentController : Controller
    {
        StudentContext sc=new StudentContext();
        // GET: Student
        public ActionResult Index()
        {
            return RedirectToAction("GetStudentScaffolded");
        }
        public ActionResult GetStudentScaffolded()
        {
            List<StudentTable> st = sc.StudentTable.ToList();
            return View(st);
        }
        [HttpGet]
        public ActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Create(StudentTable st)
        {
            sc.StudentTable.Add(st);
            sc.SaveChanges();
            return RedirectToAction("GetStudentScaffolded");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            StudentTable c = sc.StudentTable.Find(id);
            return View(c);
        }
        [HttpPost]
        public ActionResult Edit(StudentTable st)
        {
            StudentTable sta = sc.StudentTable.Find(st.StudentId);
            sta.Name=st.Name;
            sta.Branch=st.Branch;
            sta.City=st.City;
            sta.Id=st.Id;
            sta.Percentage=st.Percentage;
            sc.SaveChanges();
            return RedirectToAction("GetStudentScaffolded");
        }
        public ActionResult Details(int id)
        {
            StudentTable c = sc.StudentTable.Find(id);
            return View(c);
        }
        public ActionResult Delete(int id)
        {
            StudentTable c = sc.StudentTable.Find(id);
            sc.StudentTable.Remove(c);
            sc.SaveChanges();
            return RedirectToAction("GetStudentScaffolded");
        }
        public ActionResult SearchBY(string searchBy,string search)
        {
            if(searchBy== "City")
            {
                return View(sc.StudentTable.Where(x=>x.City==search).ToList());
            }
            else if(searchBy=="Percentage")
            {
                return View(sc.StudentTable.Where(x => x.Percentage.ToString() == search).ToList());
            }
            else if(searchBy == "Branch")
            {
                return View(sc.StudentTable.Where(x => x.Branch == search).ToList());
            }
            else
            {
                //return View();
               return View(sc.StudentTable.Where(x => x.Id.ToString()==search).ToList());
            }
        }
    }
}