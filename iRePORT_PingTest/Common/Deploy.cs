using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace iRePORT_PingTest.Common
{
    [TestClass]
    public class Deploy
    {
        [DeploymentItem(@"SpecRun.SpecFlowPlugin.dll")]
        [DeploymentItem(@"SpecFlow.Assist.Dynamic.dll")]
        [DeploymentItem(@"geckodriver.exe")]
        [TestMethod]
        public void CheckDeployment()
        {
            Console.WriteLine("Successfully Deployed");
        }
    }
}
