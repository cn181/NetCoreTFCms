using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using NetCoreTFCms;

namespace NetCoreTFCms.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20160825082947_tfcms")]
    partial class tfcms
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NetCoreTFCms.Models.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddTime");

                    b.Property<string>("CallIndex");

                    b.Property<int>("CategoryId");

                    b.Property<int>("Click");

                    b.Property<string>("Content");

                    b.Property<string>("GroupidsView");

                    b.Property<string>("ImgUrl");

                    b.Property<byte>("IsHot");

                    b.Property<byte>("IsMsg");

                    b.Property<byte>("IsRed");

                    b.Property<byte>("IsSlide");

                    b.Property<byte>("IsSys");

                    b.Property<byte>("IsTop");

                    b.Property<string>("LinkUrl");

                    b.Property<int>("ModuleId");

                    b.Property<string>("SeoDescription");

                    b.Property<string>("SeoKeywords");

                    b.Property<string>("SeoTitle");

                    b.Property<int>("SortId");

                    b.Property<byte>("Status");

                    b.Property<string>("Tags");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UserName");

                    b.Property<int>("VoteId");

                    b.Property<string>("Zhaiyao");

                    b.HasKey("Id");

                    b.ToTable("Article");
                });

            modelBuilder.Entity("NetCoreTFCms.Models.ArticleAlbums", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddTime");

                    b.Property<int>("ArticleId");

                    b.Property<string>("OriginalPath");

                    b.Property<string>("Remark");

                    b.Property<string>("ThumbPath");

                    b.HasKey("Id");

                    b.ToTable("ArticleAlbums");
                });

            modelBuilder.Entity("NetCoreTFCms.Models.ArticleAttach", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddTime");

                    b.Property<int>("ArticleId");

                    b.Property<int>("DownNum");

                    b.Property<string>("FileExt");

                    b.Property<string>("FileName");

                    b.Property<string>("FilePath");

                    b.Property<int>("FileSize");

                    b.Property<int>("Point");

                    b.HasKey("Id");

                    b.ToTable("ArticleAttach");
                });

            modelBuilder.Entity("NetCoreTFCms.Models.ArticleCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ArticleRule");

                    b.Property<string>("ArticleTemplate");

                    b.Property<string>("CallIndex");

                    b.Property<string>("ChannelListRule");

                    b.Property<string>("ChannelRule");

                    b.Property<string>("ChannelTemplate");

                    b.Property<int>("ClassLayer");

                    b.Property<string>("ClassList");

                    b.Property<string>("Content");

                    b.Property<string>("ImgUrl");

                    b.Property<string>("LinkUrl");

                    b.Property<string>("ListTemplate");

                    b.Property<string>("MobileArticleTemplate");

                    b.Property<string>("MobileChannelTemplate");

                    b.Property<string>("MobileListTemplate");

                    b.Property<int>("ModuleId");

                    b.Property<int>("ParentId");

                    b.Property<string>("SeoDescription");

                    b.Property<string>("SeoKeywords");

                    b.Property<string>("SeoTitle");

                    b.Property<int>("SortId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("ArticleCategory");
                });

            modelBuilder.Entity("NetCoreTFCms.Models.ArticleComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddTime");

                    b.Property<int>("ArticleId");

                    b.Property<string>("Content");

                    b.Property<byte>("IsLock");

                    b.Property<byte>("IsReply");

                    b.Property<int>("ModuleId");

                    b.Property<int>("ParentId");

                    b.Property<string>("ReplyContent");

                    b.Property<DateTime>("ReplyTime");

                    b.Property<int>("UserId");

                    b.Property<string>("UserIp");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("ArticleComment");
                });

            modelBuilder.Entity("NetCoreTFCms.Models.ArticleDiggs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ArticleId");

                    b.Property<int>("DiggBad");

                    b.Property<int>("DiggGood");

                    b.HasKey("Id");

                    b.ToTable("ArticleDiggs");
                });

            modelBuilder.Entity("NetCoreTFCms.Models.Manager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddTime");

                    b.Property<string>("Email");

                    b.Property<int>("IsLock");

                    b.Property<string>("Password");

                    b.Property<string>("RealName");

                    b.Property<int>("RoleId");

                    b.Property<int>("RoleType");

                    b.Property<string>("Salt");

                    b.Property<string>("Telephone");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Manager");
                });

            modelBuilder.Entity("NetCoreTFCms.Models.ManagerRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte>("IsSys");

                    b.Property<string>("RoleName");

                    b.Property<byte>("RoleType");

                    b.HasKey("Id");

                    b.ToTable("ManagerRole");
                });

            modelBuilder.Entity("NetCoreTFCms.Models.ManagerRoleValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ActionType");

                    b.Property<string>("NavName");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.ToTable("ManagerRoleValue");
                });

            modelBuilder.Entity("NetCoreTFCms.Models.Navigation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ActionType");

                    b.Property<int>("ClassLayer");

                    b.Property<string>("ClassList");

                    b.Property<string>("IconUrl");

                    b.Property<byte>("IsLock");

                    b.Property<byte>("IsSys");

                    b.Property<string>("LinkUrl");

                    b.Property<int>("ModuleId");

                    b.Property<string>("Name");

                    b.Property<string>("NavType");

                    b.Property<int>("ParentId");

                    b.Property<string>("Remark");

                    b.Property<int>("SortId");

                    b.Property<string>("SubTitle");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Navigation");
                });
        }
    }
}
