using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using NetCoreTFCms.Models;

namespace NetCoreTFCms
{

    
    public class MyContext : DbContext
    {
        public DbSet<Navigation> Navigations { get; set; }

        public DbSet<ArticleCategory> ArticleCategorys { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleAlbums> ArticleAlbumss { get; set; }
        public DbSet<ArticleAttach> ArticleAttachs { get; set; }
        public DbSet<ArticleComment> ArticleComments { get; set; }
        public DbSet<ArticleDiggs> ArticleDiggss { get; set; }

        public DbSet<Manager> Managers { get; set; }
        public DbSet<ManagerRole> ManagerRoles { get; set; }
        public DbSet<ManagerRoleValue> ManagerRoleValues { get; set; }




        //public MyContext()
        //{

        //}

        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Navigation>().ToTable("Navigation");

            modelBuilder.Entity<ArticleCategory>().ToTable("ArticleCategory");
            modelBuilder.Entity<Article>().ToTable("Article");
            modelBuilder.Entity<ArticleAlbums>().ToTable("ArticleAlbums");
            modelBuilder.Entity<ArticleAttach>().ToTable("ArticleAttach");
            modelBuilder.Entity<ArticleComment>().ToTable("ArticleComment");
            modelBuilder.Entity<ArticleDiggs>().ToTable("ArticleDiggs");

            modelBuilder.Entity<Manager>().ToTable("Manager");
            modelBuilder.Entity<ManagerRole>().ToTable("ManagerRole");
            modelBuilder.Entity<ManagerRoleValue>().ToTable("ManagerRoleValue");
            
        }
    }

}