﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace project.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Project1Entities : DbContext
    {
        public Project1Entities()
            : base("name=Project1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Batch> Batches { get; set; }
        public virtual DbSet<Batch_Semester_Mapping> Batch_Semester_Mapping { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Option> Options { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Question_option_mapping> Question_option_mapping { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Scheme> Schemes { get; set; }
        public virtual DbSet<Semesters> Semesters1 { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Student_feedback> Student_feedback { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject_staff_mapping> Subject_staff_mapping { get; set; }
        public virtual DbSet<Subjecy> Subjecys { get; set; }
    }
}