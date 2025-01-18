using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Check to see if a value is being enqued properly 
    // Expected Result: it should log the enqued object 
    // Defect(s) Found: none
    public void TestPriorityQueue_1()
    {
       var priorityQueue = new PriorityQueue();

       var value = "broom";
       var priority = 3;

       priorityQueue.Enqueue(value, priority);

       var expectedResult =  new PriorityItem(value,priority);

       var content = priorityQueue.ToString();

       var expectedContent = $"[{expectedResult}]";

       Assert.AreEqual(expectedContent,content);

       var expectedOutcome = new [] {expectedResult};
       if (expectedOutcome.Length != 1){
            Assert.Fail("there is more than one item in the queue");
       }
    }

    [TestMethod]
    // Scenario: A object has a higher priority will it be the first to be removed?
    // Expected Result: the highest object will be removed and you will be left with the other two options
    // Defect(s) Found: had a problem with the way things were beign dequed needed to get rid of -1
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();


        var item1 = new PriorityItem("broom",3);
        var item2 = new PriorityItem("lamp",4);
        var item3 = new PriorityItem("shoes",5);

        priorityQueue.Enqueue(item1.Value, item1.Priority);
        priorityQueue.Enqueue(item2.Value, item2.Priority);
        priorityQueue.Enqueue(item3.Value, item3.Priority);

        var takeAway = priorityQueue.Dequeue();
        
        Assert.AreEqual(takeAway, item3.Value);


        var remaining = $"[{item1.Value},{item2.Value}]";

        
        if (priorityQueue.ToString() == remaining)
        {
            Assert.Fail($"The expected outcome was not correct.");
        }

       

        

    }

    // Add more test cases as needed below.
}