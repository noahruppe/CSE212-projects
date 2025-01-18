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
    // Defect(s) Found: had a problem with the way things were beign dequed needed to get rid of
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
        


        var remaining = priorityQueue.ToString();

        if (remaining.Contains(item1.Value) && remaining.Contains(item2.Value))
        {
            // Both items are in the queue
        }
        else
        {
            Assert.Fail("The expected items were not found in the queue.");
        }

       

        

    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: if all are the same priority the first one in should be the first one out
    // Expected Result: Item1 should be the one that is being disqueued 
    // Defect(s) Found: had to get rid of the >= so that it would take the first one out in the dequeue function
    public void TestPriorityQueue_3(){

        var priorityQueue = new PriorityQueue();


        var item1 = new PriorityItem("broom",3);
        var item2 = new PriorityItem("lamp",4);
        var item3 = new PriorityItem("shoes",4);

        priorityQueue.Enqueue(item1.Value, item1.Priority);
        priorityQueue.Enqueue(item2.Value, item2.Priority);
        priorityQueue.Enqueue(item3.Value, item3.Priority);

        var takeAway = priorityQueue.Dequeue();
        
        Assert.AreEqual(takeAway, item2.Value);
        


        var remaining = priorityQueue.ToString();

        if (remaining.Contains(item3.Value) && remaining.Contains(item1.Value))
        {
            // Both items are in the queue
        }
        else
        {
            Assert.Fail("The expected items were not found in the queue.");
        }
    }

    [TestMethod]
    // Scenario: If queue is empty.
    // Expected Result: error will happen because queue is empty
    // Defect(s) Found: none
    public void TestPriorityQueue_4(){

         var priorityQueue = new PriorityQueue();

        Assert.ThrowsException<InvalidOperationException>(() =>
        {
            priorityQueue.Dequeue();
        }, "Expected an InvalidOperationException to be thrown when dequeueing an empty queue.");
            
    }
}