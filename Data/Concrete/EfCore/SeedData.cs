using BlogAppWeb.Data.Concrete.EfCore;
using BlogAppWeb.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlogAppWeb.Data.Concrete.EfCore
{
    public static class SeedData
    {
        public static void TestVerileriniDoldur(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<BlogContext>();

            if (context != null)
            {
                if (context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }

                if (!context.Tags.Any())
                {
                    context.Tags.AddRange(
                        new Tag { Text = "web programlama", Url = "web-programlama", Color = TagColors.warning },
                        new Tag { Text = "backend", Url = "backend", Color = TagColors.info },
                        new Tag { Text = "frontend", Url = "frontend", Color = TagColors.success },
                        new Tag { Text = "fullstack", Url = "fullstack", Color = TagColors.secondary },
                        new Tag { Text = "php", Url = "php", Color = TagColors.primary }
                    );
                    context.SaveChanges();
                }

                if (!context.Users.Any())
                {
                    context.Users.AddRange(
                        new User { UserName = "sadikturan", Name = "Sadık Turan", Email = "info@sadikturan.com", Password = "123456", Image = "p1.jpeg" },
                        new User { UserName = "cinarturan", Name = "Çınar Turan", Email = "info@cinarturan.com", Password = "123456", Image = "p2.jpeg" }
                    );
                    context.SaveChanges();
                }

                if (!context.Posts.Any())
                {
                    context.Posts.AddRange(
                        new Post
                        {
                            Title = "Asp.net core",
                            Description = "Asp.net core dersleri",
                            Content = "Asp.net core dersleri",
                            Url = "aspnet-core",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-10),
                            Tags = context.Tags.Take(3).ToList(),
                            Image = "1.jpeg",
                            UserId = 1,
                            Comments = new List<Comment> {
                                new Comment { Text = "iyi bir kurs", PublishedOn = DateTime.Now.AddDays(-20), UserId = 1},
                                new Comment { Text = "çok faydalandığım bir kurs", PublishedOn = DateTime.Now.AddDays(-10), UserId = 2},
                            }
                        },
                        new Post
                        {
                            Title = "Php",
                            Description = "Asp.net core dersleri",
                            Content = "Php core dersleri",
                            Url = "php",
                            IsActive = true,
                            Image = "2.jpeg",
                            PublishedOn = DateTime.Now.AddDays(-20),
                            Tags = context.Tags.Take(2).ToList(),
                            UserId = 1
                        },
                        new Post
                        {
                            Title = "Django",
                            Description = "Asp.net core dersleri",
                            Content = "Django dersleri",
                            Url = "django",
                            IsActive = true,
                            Image = "3.jpeg",
                            PublishedOn = DateTime.Now.AddDays(-30),
                            Tags = context.Tags.Take(4).ToList(),
                            UserId = 2
                        }
                        ,
                        new Post
                        {
                            Title = "React Dersleri",
                            Description = "Asp.net core dersleri",
                            Content = "React dersleri",
                            Url = "react-dersleri",
                            IsActive = true,
                            Image = "3.jpeg",
                            PublishedOn = DateTime.Now.AddDays(-40),
                            Tags = context.Tags.Take(4).ToList(),
                            UserId = 2
                        }
                        ,
                        new Post
                        {
                            Title = "Angular",
                            Description = "Asp.net core dersleri",
                            Content = "Angular dersleri",
                            Url = "angular",
                            IsActive = true,
                            Image = "3.jpeg",
                            PublishedOn = DateTime.Now.AddDays(-50),
                            Tags = context.Tags.Take(4).ToList(),
                            UserId = 2
                        }
                        ,
                        new Post
                        {
                            Title = "Web Tasarım",
                            Description = "Asp.net core dersleri",
                            Content = "Web tasarım dersleri",
                            Url = "web-tasarim",
                            IsActive = true,
                            Image = "3.jpeg",
                            PublishedOn = DateTime.Now.AddDays(-60),
                            Tags = context.Tags.Take(4).ToList(),
                            UserId = 2
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}