using System;
using System.Collections.Generic;
using System.Linq;
using WinterRental.Data;
using WinterRental.Models;

namespace WinterRental
{
    public class Seed
    {
        private readonly DataContext dataContext;

        public Seed(DataContext context)
        {
            this.dataContext = context;
        }

        public void SeedDataContext()
        {
            if (!dataContext.Users.Any())
            {
                var rentalInfos = new List<RentalInfo>()
                {
                    new RentalInfo()
                    {
                        OpenHour = new TimeSpan(8, 0, 0),
                        CloseHour = new TimeSpan(18, 0, 0),
                        Address = "ul. Centralna 1",
                        PhoneNumber = "123456789",
                        OpenDays = "Mon-Fri",
                        Email = "info@rental.com",

                        Users = new List<User>()
                        {
                            new User()
                            {
                                First_name = "Paweł",
                                Last_name = "Kowalski",
                                Email = "pawel@example.com",
                                Phone_number = "111222333",
                                Address = "ul. Przykładowa 1",
                                Role = "user"
                            },
                            new User()
                            {
                                First_name = "Anna",
                                Last_name = "Nowak",
                                Email = "anna@example.com",
                                Phone_number = "444555666",
                                Address = "ul. Przykładowa 2",
                                Role = "user"
                            }
                        },

                        Workers = new List<Worker>()
                        {
                            new Worker()
                            {
                                First_name = "Jan",
                                Last_name = "Kowal",
                                Email = "jan@example.com",
                                Phone_number = "777888999",
                                Role = "administrator",
                                WorkStart = new TimeSpan(8, 0, 0),
                                WorkEnd = new TimeSpan(16, 0, 0),
                                Working_Days = "Mon-Fri",
                                Job_Title = "Manager"
                            },
                            new Worker()
                            {
                                First_name = "Ewa",
                                Last_name = "Zielińska",
                                Email = "ewa@example.com",
                                Phone_number = "222333444",
                                Role = "worker",
                                WorkStart = new TimeSpan(10, 0, 0),
                                WorkEnd = new TimeSpan(18, 0, 0),
                                Working_Days = "Mon-Fri",
                                Job_Title = "Cashier"
                            }
                        },

                        Equipment = new List<Equipment>()
                        {
                            new Equipment()
                            {
                                size = "M",
                                Is_In_Werehouse = true,
                                Price = 100
                            },
                            new Equipment()
                            {
                                size = "L",
                                Is_In_Werehouse = true,
                                Price = 150
                            }
                        },

                        Orders = new List<Order>()
                        {
                            new Order()
                            {
                                Rented_Items = "Equipment 1",
                                OrderDate = DateTime.Now,
                                price = 100,
                                Date_Of_submission = DateOnly.FromDateTime(DateTime.Now),
                                Was_It_Returned = false
                            }
                        }
                    }
                };

                dataContext.RentalInfo.AddRange(rentalInfos);
                dataContext.SaveChanges();
            }
        }
    }
}
