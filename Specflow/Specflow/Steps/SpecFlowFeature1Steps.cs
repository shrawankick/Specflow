using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;


namespace UnitTestProjectSpecFlow.Steps
{
    [Binding]
    [TestClass]
    public class SpecFlowFeature1Steps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            Console.WriteLine(p0);
        }
        

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("Pressed add button");
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int result)
        {
            if (result == 150)
            {
                Console.WriteLine("test passed");
            }
            else
                Console.WriteLine("Test Failed");
            throw new Exception("test failed");
        }

        [When(@"when i fill all the mandatory details in the form")]
        
        public void WhenWhenIFillAllTheMandatoryDetailsInTheForm(Table table)
        {
            //Employee employee = table.CreateInstance<Employee>();
            //Console.WriteLine(employee.Name);
            //Console.WriteLine(employee.Age);
            //Console.WriteLine(employee.Phone);
            //Console.WriteLine(employee.Email);

           // accessing multiple values in the data 
            var details = table.CreateSet<Employee>();

            foreach (Employee emp in details)
            {
                Console.WriteLine("details of all the employes ");
                Console.WriteLine("###################################");
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Age);
                Console.WriteLine(emp.Phone);
                Console.WriteLine(emp.Email);
            }
        }

    }
}
