﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityProvider
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CHOOZAEntities : DbContext
    {
        public CHOOZAEntities()
            : base("name=CHOOZAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Academic_Credentials> Academic_Credentials { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<aspnet_Applications> aspnet_Applications { get; set; }
        public DbSet<aspnet_Membership> aspnet_Membership { get; set; }
        public DbSet<aspnet_Paths> aspnet_Paths { get; set; }
        public DbSet<aspnet_PersonalizationAllUsers> aspnet_PersonalizationAllUsers { get; set; }
        public DbSet<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser { get; set; }
        public DbSet<aspnet_Profile> aspnet_Profile { get; set; }
        public DbSet<aspnet_Roles> aspnet_Roles { get; set; }
        public DbSet<aspnet_SchemaVersions> aspnet_SchemaVersions { get; set; }
        public DbSet<aspnet_Users> aspnet_Users { get; set; }
        public DbSet<aspnet_WebEvent_Events> aspnet_WebEvent_Events { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Counsellor> Counsellors { get; set; }
        public DbSet<Counsellor_Rating> Counsellor_Rating { get; set; }
        public DbSet<Discussion_Question> Discussion_Question { get; set; }
        public DbSet<Fee_Structure> Fee_Structure { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<Program_University> Program_University { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Recommendation> Recommendations { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<University> Universities { get; set; }
    }
}
