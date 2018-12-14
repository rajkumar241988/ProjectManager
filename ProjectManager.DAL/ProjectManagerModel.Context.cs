﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectManager.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ProjectManagerEntities : DbContext
    {
        public ProjectManagerEntities()
            : base("name=ProjectManagerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ParentTask> ParentTasks { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<vw_ProjectSearch> vw_ProjectSearch { get; set; }
        public virtual DbSet<vw_TaskSearch> vw_TaskSearch { get; set; }
    
        public virtual ObjectResult<SP_GetProjectSearch_Result> SP_GetProjectSearch()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetProjectSearch_Result>("SP_GetProjectSearch");
        }
    
        public virtual int SP_UpdateExistingUsersTask(Nullable<int> task_ID)
        {
            var task_IDParameter = task_ID.HasValue ?
                new ObjectParameter("Task_ID", task_ID) :
                new ObjectParameter("Task_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UpdateExistingUsersTask", task_IDParameter);
        }
    }
}
