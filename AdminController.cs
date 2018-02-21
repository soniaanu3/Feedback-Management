using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using project.Models;

namespace project.Controllers
{
    public class AdminController : Controller
    {
        public SqlConnection con;
        public SqlCommand cmd;
        List<Course> courses = new List<Course>();
        public void connection()
        {
            //con = new SqlConnection(@"Data Source=(localdb)\ProjectsV12;Initial Catalog=master;Integrated Security=True");
            con = new SqlConnection(@"Data Source=NBPRJLAB6\SQLEXPRESS;Initial Catalog=Project1;Integrated Security=False;User ID=sa;Password=admin28;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
        }
        //
        // GET: /admin/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult course(Course c)
        {
            if (c.Course_name == "" || c.Course_name == null)
                return View();
            else
            {
                connection();
                string str = "insert into Course(Course_name) values('" + c.Course_name + "')";
                cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                ViewBag.Message = "Course Added Successfully";
               
            }
            return View(c);
        }

        public ActionResult batch(Batch b)
        {
            connection();
            cmd = new SqlCommand("select Course_id,Course_name from Course", con);
            SqlDataReader drc = cmd.ExecuteReader();
            while (drc.Read())
            {
                Course c = new Course();
                c.Course_id = Int32.Parse(drc[0].ToString());
                c.Course_name = drc[1].ToString();
                courses.Add(c);
            }
            drc.Close();
            ViewBag.course_id = new SelectList(courses, "Course_id", "Course_name");

            if (b.Batch_name == null || b.Batch_id == null)
            {
                return View();
            }
            else
            {
                string query = "Select batch_name from Batch where batch_name='" + b.Batch_name + "'";
                cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    ViewBag.Message = "Batch already exist";
                }
                else
                {
                    dr.Close();
                    string str = "insert into Batch(Batch_name,Course_id) values('" + b.Batch_name + "','" + b.Course_id + "')";
                    cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    ViewBag.Message = "Batch Added Successfully";
                }
                return View(b);
            }
        }

        public ActionResult semester(Semesters s)
        {
            connection();
            
            
            if (s.Semestername == "" || s.Semestername == null)
                return View();
            else
            {

                string query = "Select Semesterid from Semesters where Semesterid='" + s.Semesterid + "'";
                cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    ViewBag.Message = "Semester already exist";
                }
                else
                {
                    dr.Close();
                    string str = "insert into Semesters(Semestername) values('" + s.Semestername + "')";
                    cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    ViewBag.Message = "Semester Added Successfully";
                }
                return View(s);
            }
        }
        public ActionResult batchsemestermapping()
        {
            return View();
        }
        public ActionResult subject()
        {
            return View();
        }
        public ActionResult staff()
        {
            return View();
        }
        public ActionResult subjectstaffmapping()
        {
            return View();
        }
        public ActionResult question()
        {
            return View();
        }
        public ActionResult student()
        {
            return View();
        }
        public ActionResult viewfeedback()
        {
            return View();
        }
        public ActionResult Schedule()
        {
            return View();
        }

        public System.Collections.IEnumerable Courses { get; set; }
    }
}