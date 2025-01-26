using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Activities.Any()) return;
            
            var activities = new List<Activity>
            {
                new Activity
                {
                    Title = "Past Activity 1",
                    Date = DateTime.UtcNow.AddMonths(-2),
                    Description = "Activity 2 months ago",
                    Category = "drinks",
                    City = "London",
                    Venue = "Pub",
                },
                new Activity
                {
                    Title = "Past Activity 2",
                    Date = DateTime.UtcNow.AddMonths(-1),
                    Description = "Activity 1 month ago",
                    Category = "culture",
                    City = "Paris",
                    Venue = "Louvre",
                },
                new Activity
                {
                    Title = "Future Activity 1",
                    Date = DateTime.UtcNow.AddMonths(1),
                    Description = "Activity 1 month in future",
                    Category = "culture",
                    City = "London",
                    Venue = "Natural History Museum",
                },
                new Activity
                {
                    Title = "Future Activity 2",
                    Date = DateTime.UtcNow.AddMonths(2),
                    Description = "Activity 2 months in future",
                    Category = "music",
                    City = "London",
                    Venue = "O2 Arena",
                },
                new Activity
                {
                    Title = "Future Activity 3",
                    Date = DateTime.UtcNow.AddMonths(3),
                    Description = "Activity 3 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Another pub",
                },
                new Activity
                {
                    Title = "Future Activity 4",
                    Date = DateTime.UtcNow.AddMonths(4),
                    Description = "Activity 4 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Yet another pub",
                },
                new Activity
                {
                    Title = "Future Activity 5",
                    Date = DateTime.UtcNow.AddMonths(5),
                    Description = "Activity 5 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Just another pub",
                },
                new Activity
                {
                    Title = "Future Activity 6",
                    Date = DateTime.UtcNow.AddMonths(6),
                    Description = "Activity 6 months in future",
                    Category = "music",
                    City = "London",
                    Venue = "Roundhouse Camden",
                },
                new Activity
                {
                    Title = "Future Activity 7",
                    Date = DateTime.UtcNow.AddMonths(7),
                    Description = "Activity 2 months ago",
                    Category = "travel",
                    City = "London",
                    Venue = "Somewhere on the Thames",
                },
                new Activity
                {
                    Title = "Future Activity 8",
                    Date = DateTime.UtcNow.AddMonths(8),
                    Description = "Activity 8 months in future",
                    Category = "film",
                    City = "London",
                    Venue = "Cinema",
                }
            };

            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }

        public static async Task SeedDataCourse(DataContext context)
        {
            if (context.Courses.Any()) return;
            var courses = new List<Course>
            {
                new Course
                {
                    Id = 1,
                    Title = "Lập Trình Cơ Bản với Python",
                    Slug = "basic-python",
                    Description = "Khóa học này cung cấp những kiến thức cơ bản nhất về Python.",
                    ImageUrl = "https://files.fullstack.edu.vn/f8-prod/courses/1.png",
                    IconUrl = "https://files.fullstack.edu.vn/f8-prod/courses/1/6200b81f52d83.png",
                    Price = 0,
                    OldPrice = 0,
                    IsPro = false,
                    IsPublished = true,
                    StudentsCount = 50000,
                    VideosCount = 15,
                    Duration = 5400,
                    DurationText = "1h30m",
                    UserProgress = 0,
                    LastCompletedAt = null,
                    PublishedAt = new DateTime(2020, 01, 20)
                },
                new Course
                {
                    Id = 2,
                    Title = "Web Development for Beginners",
                    Slug = "web-development-beginners",
                    Description = "An ideal starting point for those new to web development.",
                    ImageUrl = "https://files.fullstack.edu.vn/f8-prod/courses/2.png",
                    IconUrl = "https://files.fullstack.edu.vn/f8-prod/courses/2/6200b81f52d83.png",
                    Price = 0,
                    OldPrice = 0,
                    IsPro = false,
                    IsPublished = true,
                    StudentsCount = 75000,
                    VideosCount = 25,
                    Duration = 9000,
                    DurationText = "2h30m",
                    UserProgress = 0,
                    LastCompletedAt = null,
                    PublishedAt = new DateTime(2020, 05, 15)
                },
                new Course
                {
                    Id = 3,
                    Title = "Intermediate JavaScript",
                    Slug = "intermediate-javascript",
                    Description = "Deepen your understanding of JavaScript with this intermediate course.",
                    ImageUrl = "https://files.fullstack.edu.vn/f8-prod/courses/3.png",
                    IconUrl = "https://files.fullstack.edu.vn/f8-prod/courses/3/6200b81f52d83.png",
                    Price = 50,
                    OldPrice = 100,
                    IsPro = true,
                    IsPublished = true,
                    StudentsCount = 30000,
                    VideosCount = 30,
                    Duration = 10800,
                    DurationText = "3h",
                    UserProgress = 20,
                    LastCompletedAt = new DateTime(2021, 08, 10),
                    PublishedAt = new DateTime(2020, 08, 25)
                },
                new Course
                {
                    Id = 4,
                    Title = "Advanced React Techniques",
                    Slug = "advanced-react",
                    Description = "Master advanced techniques in React including hooks and context.",
                    ImageUrl = "https://files.fullstack.edu.vn/f8-prod/courses/4.png",
                    IconUrl = "https://files.fullstack.edu.vn/f8-prod/courses/4/6200b81f52d83.png",
                    Price = 100,
                    OldPrice = 200,
                    IsPro = true,
                    IsPublished = true,
                    StudentsCount = 20000,
                    VideosCount = 20,
                    Duration = 7200,
                    DurationText = "2h",
                    UserProgress = 50,
                    LastCompletedAt = new DateTime(2021, 12, 01),
                    PublishedAt = new DateTime(2020, 11, 01)
                },
                new Course
                {
                    Id = 5,
                    Title = "Database Design Fundamentals",
                    Slug = "database-design",
                    Description = "Learn the fundamentals of database design, from ER diagrams to SQL queries.",
                    ImageUrl = "https://files.fullstack.edu.vn/f8-prod/courses/5.png",
                    IconUrl = "https://files.fullstack.edu.vn/f8-prod/courses/5/6200b81f52d83.png",
                    Price = 80,
                    OldPrice = 160,
                    IsPro = true,
                    IsPublished = true,
                    StudentsCount = 10000,
                    VideosCount = 18,
                    Duration = 6600,
                    DurationText = "1h50m",
                    UserProgress = 0,
                    LastCompletedAt = null,
                    PublishedAt = new DateTime(2021, 01, 05)
                }
            };

            await context.Courses.AddRangeAsync(courses);
            await context.SaveChangesAsync();
        }
    }
}