using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test2.Controllers
{
    public class HomeController : Controller
    {
        public class Student
        {
            public string id { get; set; }
            public string name { get; set; }
            public int score { get; set; }
            public Student()
            {
                id = string.Empty;
                name = string.Empty;
                score = 0;
            }
            /// <summary>
            /// 建構子
            /// </summary>
            /// <param name="_id"></param>
            /// <param name="_name"></param>
            /// <param name="_score"></param>
            public Student(string _id,string _name,int _score)
            {
                id = _id;
                name = _name;
                score = _score;
            }
            /// <summary>
            /// 回傳字串資料
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return $"學號:{id},姓名:{name},分數:{score}";
            }
        }
        public ActionResult Index()
        {
            DateTime date = DateTime.Now;
            Student data = new Student();
            List<Student> list = new List<Student>();
            list.Add(new Student("1", "小明", 80));
            list.Add(new Student("2", "小華", 70));
            list.Add(new Student("3", "小英", 60));
            list.Add(new Student("4", "小李", 50));
            list.Add(new Student("5", "小張", 90));

            //ViewBag可讓View顯示資料
            ViewBag.Date = date;
            ViewBag.Student = data;
          // ViewData.Model = data;
            ViewBag.List = list;
            
            return View();
        }


    }
}