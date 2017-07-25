using System;
using Moq;
using MoqExample.Models;

namespace MoqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            UnitTest();            



        }

        static void UnitTest()
        {
            var testClass =  new testclass();

            Console.Write("Enter number to verify prime");
            var numberToCheck = Console.ReadLine();

            testClass.NumberCheck(numberToCheck);

            testClass.PrimeCheck(Convert.ToInt64(numberToCheck));

        }




        static void MoqTest()
        {
            Console.WriteLine("MOQ Example Enjoy!");

            var userMock = new Mock<IUser>();
            userMock.Setup(x=> x.UserName).Returns("jlu676");
            userMock.Setup(x=> x.Password).Returns("password");

            var userRepo = new User(userMock.Object);
            var authCode = userRepo.Login();
            
            Console.WriteLine($"User Id:  {authCode.UserId}");
            Console.WriteLine($"Auth Code: {authCode.AuthKey}");
        }


    }
}
