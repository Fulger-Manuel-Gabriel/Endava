using SchoolOf.Data.Models;
using System;
using System.Collections.Generic;

namespace SchoolOf.Data.Seed
{
    public static class OrderInitialData
    {
        public static IList<Order> GetData()
        {
            var list = new List<Order>
            {
                new Order
                {
                    Id = 1,
                    Name = "TestName1",
                    Adress = "Test Adress11111",
                    Total = 300,
                    Email = "TestEmail11111@gmail.com",
                    PhoneNo =11111,
                    CreatedAt = DateTimeOffset.UtcNow,
                    ModifiedAt = DateTimeOffset.UtcNow
                },
                new Order {
                    Id = 2,
                    Name = "TestName2",
                    Adress = "Test Adress222222",
                    Total = 1000,
                    Email = "TestEmail222222@gmail.com",
                    PhoneNo = 222222,
                    CreatedAt = DateTimeOffset.UtcNow,
                    ModifiedAt = DateTimeOffset.UtcNow
                },
                new Order {
                    Id = 3,
                    Name = "TestName3",
                    Adress = "Test Adress33333333",
                    Total = 500,
                    Email = "TestEmail333333@gmail.com",
                    PhoneNo = 33333333,
                    CreatedAt = DateTimeOffset.UtcNow,
                    ModifiedAt = DateTimeOffset.UtcNow
                }
            };

            return list;
        }
    }
}
