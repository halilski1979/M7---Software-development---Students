using Microsoft.EntityFrameworkCore;
using Project.Data;
using Project.Services;

namespace Project.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Create_Employee()
        {
            var option= new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName:"TestDb")
                .Options;

            using (var context = new AppDbContext(option))
            {
                var service = new EmployeeService();
                service.Create("Ivan","Ivanov",1111);
                Assert.True(true);
            }                
        }


    }
}