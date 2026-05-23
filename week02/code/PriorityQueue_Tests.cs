using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add one item and remove it.
    // Expected Result: The same item should be returned.
    // Defect(s) Found: No defects found in basic enqueue/dequeue behavior.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
         priorityQueue.Enqueue("Bob", 1);

        var result = priorityQueue.Dequeue(); //

        Assert.AreEqual("Bob", result); //
    }

    [TestMethod]
    // Scenario: Add multiple items with different priorities
    // Expected Result: Item with highest priority should be removed first.
    // Defect(s) Found: Queue removed lowest priority item instead of highest priority item.
    public void TestPriorityQueue_HighestPriority()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Tim", result);
    }


    [TestMethod]
    // Scenario:  Add multiple items with the same highest priority
    // Expected Result: First inserted highest-priority item should be removed first (FIFO).
    // Defect(s) Found: Queue violated FIFO ordering for equal priorities.
    public void TestPriorityQueue_FIFOForSamePriority()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("Bob", 5);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Bob", result);
    }    

    [TestMethod]
    // Scenario: Attempt to dequeue from an empty queue.
    // Expected Result: InvalidOperationException should be thrown
    // with message "The queue is empty."
    // Defect(s) Found:
    // Incorrect exception type/message thrown for empty queue.
    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();

            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("The queue is empty.", ex.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception ex)
        {
            Assert.Fail(
                $"Unexpected exception type: {ex.GetType()} - {ex.Message}"
            );
        }
    }
}
