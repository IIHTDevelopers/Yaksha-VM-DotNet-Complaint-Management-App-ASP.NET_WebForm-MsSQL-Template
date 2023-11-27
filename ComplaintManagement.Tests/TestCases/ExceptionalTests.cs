

using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ComplaintManagementApp.DAL.Interfaces;
using ComplaintManagementApp.DAL.Services;
using Xunit;
using Xunit.Abstractions;

namespace ComplaintManagementApp.Tests.TestCases
{
    public class ExceptionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IComplaintService _complaintService;
        public readonly Mock<IComplaintRepository> complaintservice = new Mock<IComplaintRepository>();

        private static string type = "Exception";

        public ExceptionalTests(ITestOutputHelper output)
        {
            _complaintService = new ComplaintService(complaintservice.Object);
            _output = output;
        }

        [Fact]
        public async Task<bool> Testfor_GetAll_Complaints_NotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                complaintservice.Setup(repos => repos.GetAll()).Returns("");
                var result = _complaintService.GetAll();
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Update_Complaints_NotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                complaintservice.Setup(repos => repos.Update()).Returns("");
                var result = _complaintService.Update();
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


    }
}