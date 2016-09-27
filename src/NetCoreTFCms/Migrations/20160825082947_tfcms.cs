using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NetCoreTFCms.Migrations
{
    public partial class tfcms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddTime = table.Column<DateTime>(nullable: false),
                    CallIndex = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    Click = table.Column<int>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    GroupidsView = table.Column<string>(nullable: true),
                    ImgUrl = table.Column<string>(nullable: true),
                    IsHot = table.Column<byte>(nullable: false),
                    IsMsg = table.Column<byte>(nullable: false),
                    IsRed = table.Column<byte>(nullable: false),
                    IsSlide = table.Column<byte>(nullable: false),
                    IsSys = table.Column<byte>(nullable: false),
                    IsTop = table.Column<byte>(nullable: false),
                    LinkUrl = table.Column<string>(nullable: true),
                    ModuleId = table.Column<int>(nullable: false),
                    SeoDescription = table.Column<string>(nullable: true),
                    SeoKeywords = table.Column<string>(nullable: true),
                    SeoTitle = table.Column<string>(nullable: true),
                    SortId = table.Column<int>(nullable: false),
                    Status = table.Column<byte>(nullable: false),
                    Tags = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    VoteId = table.Column<int>(nullable: false),
                    Zhaiyao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleAlbums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddTime = table.Column<DateTime>(nullable: false),
                    ArticleId = table.Column<int>(nullable: false),
                    OriginalPath = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    ThumbPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleAlbums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleAttach",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddTime = table.Column<DateTime>(nullable: false),
                    ArticleId = table.Column<int>(nullable: false),
                    DownNum = table.Column<int>(nullable: false),
                    FileExt = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    FilePath = table.Column<string>(nullable: true),
                    FileSize = table.Column<int>(nullable: false),
                    Point = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleAttach", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArticleRule = table.Column<string>(nullable: true),
                    ArticleTemplate = table.Column<string>(nullable: true),
                    CallIndex = table.Column<string>(nullable: true),
                    ChannelListRule = table.Column<string>(nullable: true),
                    ChannelRule = table.Column<string>(nullable: true),
                    ChannelTemplate = table.Column<string>(nullable: true),
                    ClassLayer = table.Column<int>(nullable: false),
                    ClassList = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    ImgUrl = table.Column<string>(nullable: true),
                    LinkUrl = table.Column<string>(nullable: true),
                    ListTemplate = table.Column<string>(nullable: true),
                    MobileArticleTemplate = table.Column<string>(nullable: true),
                    MobileChannelTemplate = table.Column<string>(nullable: true),
                    MobileListTemplate = table.Column<string>(nullable: true),
                    ModuleId = table.Column<int>(nullable: false),
                    ParentId = table.Column<int>(nullable: false),
                    SeoDescription = table.Column<string>(nullable: true),
                    SeoKeywords = table.Column<string>(nullable: true),
                    SeoTitle = table.Column<string>(nullable: true),
                    SortId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleComment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddTime = table.Column<DateTime>(nullable: false),
                    ArticleId = table.Column<int>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    IsLock = table.Column<byte>(nullable: false),
                    IsReply = table.Column<byte>(nullable: false),
                    ModuleId = table.Column<int>(nullable: false),
                    ParentId = table.Column<int>(nullable: false),
                    ReplyContent = table.Column<string>(nullable: true),
                    ReplyTime = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserIp = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleComment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleDiggs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArticleId = table.Column<int>(nullable: false),
                    DiggBad = table.Column<int>(nullable: false),
                    DiggGood = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleDiggs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manager",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddTime = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    IsLock = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    RealName = table.Column<string>(nullable: true),
                    RoleId = table.Column<int>(nullable: false),
                    RoleType = table.Column<int>(nullable: false),
                    Salt = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manager", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManagerRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsSys = table.Column<byte>(nullable: false),
                    RoleName = table.Column<string>(nullable: true),
                    RoleType = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManagerRoleValue",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActionType = table.Column<string>(nullable: true),
                    NavName = table.Column<string>(nullable: true),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerRoleValue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Navigation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActionType = table.Column<string>(nullable: true),
                    ClassLayer = table.Column<int>(nullable: false),
                    ClassList = table.Column<string>(nullable: true),
                    IconUrl = table.Column<string>(nullable: true),
                    IsLock = table.Column<byte>(nullable: false),
                    IsSys = table.Column<byte>(nullable: false),
                    LinkUrl = table.Column<string>(nullable: true),
                    ModuleId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NavType = table.Column<string>(nullable: true),
                    ParentId = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    SortId = table.Column<int>(nullable: false),
                    SubTitle = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Navigation", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Article");

            migrationBuilder.DropTable(
                name: "ArticleAlbums");

            migrationBuilder.DropTable(
                name: "ArticleAttach");

            migrationBuilder.DropTable(
                name: "ArticleCategory");

            migrationBuilder.DropTable(
                name: "ArticleComment");

            migrationBuilder.DropTable(
                name: "ArticleDiggs");

            migrationBuilder.DropTable(
                name: "Manager");

            migrationBuilder.DropTable(
                name: "ManagerRole");

            migrationBuilder.DropTable(
                name: "ManagerRoleValue");

            migrationBuilder.DropTable(
                name: "Navigation");
        }
    }
}
