using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Identity;
namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context, UserManager<AppUser> userManager)
        {


            if (!userManager.Users.Any())
            {
                var users = new List<AppUser>
                {
                    new AppUser
                    {
                        DisplayName = "Arvis", UserName ="yourgurunet", Email = "info@yourgurunet.com"
                    },
                    new AppUser
                    {
                        DisplayName = "Irbe", UserName ="irbe", Email = "irbe@yourgurunet.com"
                    },
                    new AppUser
                    {
                        DisplayName = "Enzo", UserName ="enzo", Email = "enzo@yourgurunet.com"
                    },
                     new AppUser
                    {
                        DisplayName = "Niko", UserName ="niko", Email = "niko@yourgurunet.com"
                    },
                };

                foreach (var user in users)
                {
                    await userManager.CreateAsync(user, "Pa$$w0rd");
                }
            }

            //If the database Is not empty then return the list with activities, else return seed data
            if (context.Activities.Any()) return;

            var activities = new List<Activity>
            {
                new Activity
                {
                    Title = "Past Activity 1",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Activity 2 months ago",
                    Category = "drinks",
                    City = "London",
                    Venue = "Pub",
                    Attendees = new List<ActivityAttendee>
                        {
                            new ActivityAttendee
                            {
                                AppUser = {DisplayName = "Arvis", UserName ="yourgurunet", Email = "info@yourgurunet.com" },
                                IsHost = true
                            },
                            new ActivityAttendee
                            {
                                AppUser = {DisplayName = "Niko", UserName ="niko", Email = "niko@yourgurunet.com" },
                                IsHost = false
                            },
                             new ActivityAttendee
                            {
                                AppUser = {DisplayName = "Enzo", UserName ="enzo", Email = "enzo@yourgurunet.com" },
                                IsHost = false
                            },
                    },
                },
                new Activity
                {
                    Title = "Past Activity 2",
                    Date = DateTime.Now.AddMonths(-1),
                    Description = "Activity 1 month ago",
                    Category = "culture",
                    City = "Paris",
                    Venue = "Louvre",
                    Attendees = new List<ActivityAttendee>
                     {
                            new ActivityAttendee
                            {
                                AppUser = {DisplayName = "Arvis", UserName ="yourgurunet", Email = "info@yourgurunet.com" },
                                IsHost = true
                            },
                            new ActivityAttendee
                            {
                                AppUser = {DisplayName = "Niko", UserName ="niko", Email = "niko@yourgurunet.com" },
                                IsHost = false
                            },
                    },
                },
                new Activity
                {
                    Title = "Future Activity 1",
                    Date = DateTime.Now.AddMonths(1),
                    Description = "Activity 1 month in future",
                    Category = "culture",
                    City = "London",
                    Venue = "Natural History Museum",
                    Attendees = new List<ActivityAttendee>
                        {
                            new ActivityAttendee
                            {
                                AppUser = {DisplayName = "Arvis", UserName ="yourgurunet", Email = "info@yourgurunet.com" },
                                IsHost = false
                            },
                            new ActivityAttendee
                            {
                                AppUser = {DisplayName = "Niko", UserName ="niko", Email = "niko@yourgurunet.com" },
                                IsHost = true
                            },
                             new ActivityAttendee
                            {
                                AppUser = {DisplayName = "Enzo", UserName ="enzo", Email = "enzo@yourgurunet.com" },
                                IsHost = false
                            },
                    },
                },
                new Activity
                {
                    Title = "Future Activity 2",
                    Date = DateTime.Now.AddMonths(2),
                    Description = "Activity 2 months in future",
                    Category = "music",
                    City = "London",
                    Venue = "O2 Arena",
                    Attendees = new List<ActivityAttendee>
                        {
                            new ActivityAttendee
                            {
                                AppUser = {DisplayName = "Arvis", UserName ="yourgurunet", Email = "info@yourgurunet.com"},
                                IsHost = false
                            },
                            new ActivityAttendee
                            {
                                AppUser = {DisplayName = "Niko", UserName ="niko", Email = "niko@yourgurunet.com" },
                                IsHost = false
                            },
                             new ActivityAttendee
                            {
                                AppUser = {DisplayName = "Enzo", UserName ="enzo", Email = "enzo@yourgurunet.com" },
                                IsHost = false
                            },
                              new ActivityAttendee
                            {
                                 AppUser = {DisplayName = "Irbe", UserName ="irbe", Email = "irbe@yourgurunet.com" },
                                IsHost = true
                            },
                    },
                },
                new Activity
                {
                    Title = "Future Activity 3",
                    Date = DateTime.Now.AddMonths(3),
                    Description = "Activity 3 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Another pub",
                    Attendees = new List<ActivityAttendee>
                        {
                            new ActivityAttendee
                            {
                                AppUser = {DisplayName = "Arvis", UserName ="yourgurunet", Email = "info@yourgurunet.com" },
                                IsHost = false
                            },
                            new ActivityAttendee
                            {
                                AppUser = {DisplayName = "Niko", UserName ="niko", Email = "niko@yourgurunet.com" },
                                IsHost = true
                            },
                             new ActivityAttendee
                            {
                                AppUser = {DisplayName = "Enzo", UserName ="enzo", Email = "enzo@yourgurunet.com" },
                                IsHost = false
                            },
                              new ActivityAttendee
                            {
                                 AppUser = {DisplayName = "Irbe", UserName ="irbe", Email = "irbe@yourgurunet.com" },
                                IsHost = false
                            },
                    },
                },
                new Activity
                {
                    Title = "Future Activity 4",
                    Date = DateTime.Now.AddMonths(4),
                    Description = "Activity 4 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Yet another pub",
                    Attendees = new List<ActivityAttendee>
                        {
                            new ActivityAttendee
                            {
                                AppUser = {DisplayName = "Arvis", UserName ="yourgurunet", Email = "info@yourgurunet.com" },
                                IsHost = false
                            },
                            new ActivityAttendee
                            {
                                AppUser = {DisplayName = "Niko", UserName ="niko", Email = "niko@yourgurunet.com" },
                                IsHost = false
                            },
                             new ActivityAttendee
                            {
                                AppUser = {DisplayName = "Enzo", UserName ="enzo", Email = "enzo@yourgurunet.com" },
                                IsHost = true
                            },
                              new ActivityAttendee
                            {
                                 AppUser = {DisplayName = "Irbe", UserName ="irbe", Email = "irbe@yourgurunet.com" },
                                IsHost = false
                            },
                    },
                },
                new Activity
                {
                    Title = "Future Activity 5",
                    Date = DateTime.Now.AddMonths(5),
                    Description = "Activity 5 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Just another pub",
                    Attendees = new List<ActivityAttendee>
                        {
                            new ActivityAttendee
                            {
                                AppUser = {DisplayName = "Arvis", UserName ="yourgurunet", Email = "info@yourgurunet.com" },
                                IsHost = true
                            },
                            new ActivityAttendee
                            {
                                AppUser = {DisplayName = "Niko", UserName ="niko", Email = "niko@yourgurunet.com" },
                                IsHost = false
                            },
                             new ActivityAttendee
                            {
                                AppUser = {DisplayName = "Enzo", UserName ="enzo", Email = "enzo@yourgurunet.com" },
                                IsHost = false
                            },
                              new ActivityAttendee
                            {
                                 AppUser = {DisplayName = "Irbe", UserName ="irbe", Email = "irbe@yourgurunet.com" },
                                IsHost = false
                            },
                    },
                },
                new Activity
                {
                    Title = "Future Activity 6",
                    Date = DateTime.Now.AddMonths(6),
                    Description = "Activity 6 months in future",
                    Category = "music",
                    City = "London",
                    Venue = "Roundhouse Camden",
                    Attendees = new List<ActivityAttendee>
                        {
                            new ActivityAttendee
                            {
                                AppUser = {DisplayName = "Arvis", UserName ="yourgurunet", Email = "info@yourgurunet.com" },
                                IsHost = true
                            },
                            new ActivityAttendee
                            {
                                AppUser = {DisplayName = "Niko", UserName ="niko", Email = "niko@yourgurunet.com" },
                                IsHost = false
                            },
                             new ActivityAttendee
                            {
                                AppUser = {DisplayName = "Enzo", UserName ="enzo", Email = "enzo@yourgurunet.com" },
                                IsHost = false
                            },
                              new ActivityAttendee
                            {
                                 AppUser = {DisplayName = "Irbe", UserName ="irbe", Email = "irbe@yourgurunet.com" },
                                IsHost = false
                            },
                    },
                },
                new Activity
                {
                    Title = "Future Activity 7",
                    Date = DateTime.Now.AddMonths(7),
                    Description = "Activity 2 months ago",
                    Category = "travel",
                    City = "London",
                    Venue = "Somewhere on the Thames",
                    Attendees = new List<ActivityAttendee>
                        {
                            new ActivityAttendee
                            {
                                AppUser = {DisplayName = "Arvis", UserName ="yourgurunet", Email = "info@yourgurunet.com" },
                                IsHost = true
                            },
                            new ActivityAttendee
                            {
                                AppUser = {DisplayName = "Niko", UserName ="niko", Email = "niko@yourgurunet.com" },
                                IsHost = false
                            },
                             new ActivityAttendee
                            {
                                AppUser = {DisplayName = "Enzo", UserName ="enzo", Email = "enzo@yourgurunet.com" },
                                IsHost = false
                            },
                              new ActivityAttendee
                            {
                                 AppUser = {DisplayName = "Irbe", UserName ="irbe", Email = "irbe@yourgurunet.com" },
                                IsHost = false
                            },
                    },
                },
                new Activity
                {
                    Title = "Future Activity 8",
                    Date = DateTime.Now.AddMonths(8),
                    Description = "Activity 8 months in future",
                    Category = "film",
                    City = "London",
                    Venue = "Cinema",
                    Attendees = new List<ActivityAttendee>
                        {
                            new ActivityAttendee
                            {
                                AppUser = {DisplayName = "Arvis", UserName ="yourgurunet", Email = "info@yourgurunet.com" },
                                IsHost = true
                            },
                            new ActivityAttendee
                            {
                                AppUser = {DisplayName = "Niko", UserName ="niko", Email = "niko@yourgurunet.com" },
                                IsHost = false
                            },
                             new ActivityAttendee
                            {
                                AppUser = {DisplayName = "Enzo", UserName ="enzo", Email = "enzo@yourgurunet.com" },
                                IsHost = false
                            },
                              new ActivityAttendee
                            {
                                 AppUser = {DisplayName = "Irbe", UserName ="irbe", Email = "irbe@yourgurunet.com" },
                                IsHost = false
                            },
                    },
                }
            };

            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}