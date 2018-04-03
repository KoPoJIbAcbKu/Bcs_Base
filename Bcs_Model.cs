namespace Bsc_Base
{
    using Bsc_Base.Code;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Bcs_Model : DbContext
    {
        public Bcs_Model()
            : base("name=Bcs_Model")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<ArticleCommonTable> ArticleCommonTables { get; set; }
        public virtual DbSet<ArticleFirstTypeTable> ArticleFirstTypeTables { get; set; }
        public virtual DbSet<ArticleSecondTypeTable> ArticleSecondTypeTables { get; set; }
    }
}