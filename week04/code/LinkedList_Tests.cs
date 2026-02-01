using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

// DO NOT MODIFY THIS FILE

[TestClass]
public class InsertTailTests
{
    [TestMethod]
    public void InsertTail_Empty()
    {
         Debug.WriteLine("---- InsertTail_Empty ----");
        var ll = new LinkedList();

        Assert.IsTrue(ll.HeadAndTailAreNull());
        ll.InsertTail(1);
        Debug.WriteLine(ll.ToString());
        Assert.IsTrue(ll.HeadAndTailAreNotNull());
        Assert.AreEqual("<LinkedList>{1}", ll.ToString());
    }

    [TestMethod]
    public void InsertTail_Basic()
    {
        Debug.WriteLine("---- InsertTail_Basic ----");
        var ll = new LinkedList();

        ll.InsertTail(1);
        ll.InsertHead(2);
        ll.InsertHead(2);
        ll.InsertHead(2);
        ll.InsertHead(3);
        ll.InsertHead(4);
        ll.InsertHead(5);

        Debug.WriteLine(ll.ToString());
        Assert.AreEqual("<LinkedList>{5, 4, 3, 2, 2, 2, 1}", ll.ToString());

        ll.InsertTail(0);
        ll.InsertTail(-1);

        Debug.WriteLine(ll.ToString());
        Assert.AreEqual("<LinkedList>{5, 4, 3, 2, 2, 2, 1, 0, -1}", ll.ToString());
    }
}

[TestClass]
public class RemoveTailTests
{
    [TestMethod]
    public void RemoveTail_Empty()
    {
        var ll = new LinkedList();

        ll.RemoveTail();
        Assert.IsTrue(ll.HeadAndTailAreNull());
        Assert.AreEqual("<LinkedList>{}", ll.ToString());
    }

    [TestMethod]
    public void RemoveTail_Single()
    {
        var ll = new LinkedList();

        ll.InsertHead(1);
        ll.RemoveTail();
        Assert.IsTrue(ll.HeadAndTailAreNull());
        Assert.AreEqual("<LinkedList>{}", ll.ToString());
    }

    [TestMethod]
    public void RemoveTail_Basic()
    {
        var ll = new LinkedList();

        ll.InsertHead(2);
        ll.InsertHead(2);
        ll.InsertHead(2);
        ll.InsertHead(3);
        ll.InsertHead(4);
        ll.InsertHead(5);

        ll.RemoveTail();
        Assert.AreEqual("<LinkedList>{5, 4, 3, 2, 2}", ll.ToString());

        ll.RemoveTail();
        Assert.AreEqual("<LinkedList>{5, 4, 3, 2}", ll.ToString());
    }
}

[TestClass]
public class RemoveTests
{
    [TestMethod]
    public void Remove_NonExistant()
    {
        var ll = new LinkedList();

        ll.InsertHead(2);
        ll.InsertHead(2);
        ll.InsertHead(2);
        ll.InsertHead(3);
        ll.InsertHead(4);
        ll.InsertHead(5);

        ll.InsertAfter(3, 35);
        ll.InsertAfter(5, 6);

        Assert.AreEqual("<LinkedList>{5, 6, 4, 3, 35, 2, 2, 2}", ll.ToString());
        ll.Remove(-1);
        Assert.AreEqual("<LinkedList>{5, 6, 4, 3, 35, 2, 2, 2}", ll.ToString());
    }

    [TestMethod]
    public void Remove_Empty()
    {
        var ll = new LinkedList();
        ll.Remove(0);
        Assert.AreEqual("<LinkedList>{}", ll.ToString());
        Assert.IsTrue(ll.HeadAndTailAreNull());
    }

    [TestMethod]
    public void Remove_Single()
    {
        Debug.WriteLine("---- Remove_Single ----");
        var ll = new LinkedList();
        ll.InsertHead(2);
        Debug.WriteLine("Before: " + ll.ToString());

        ll.Remove(2);
        Debug.WriteLine("After: " + ll.ToString());
        Assert.AreEqual("<LinkedList>{}", ll.ToString());
        Assert.IsTrue(ll.HeadAndTailAreNull());
    }

    [TestMethod]
    public void Remove_Multiple()
    {
        var ll = new LinkedList();
        Debug.WriteLine("Before: " + ll.ToString());
        ll.InsertHead(2);
        ll.InsertHead(2);
        ll.InsertHead(3);
        ll.InsertHead(4);
        ll.InsertHead(2);
        ll.InsertHead(5);
        Debug.WriteLine("Before: " + ll.ToString());//Before: <LinkedList>{5, 2, 4, 3, 2, 2}
        ll.InsertAfter(3, 35);
        ll.InsertAfter(5, 6);
        Debug.WriteLine("Before: " + ll.ToString()); //Before: <LinkedList>{5, 6, 2, 4, 3, 35, 2, 2}

        Assert.AreEqual("<LinkedList>{5, 6, 2, 4, 3, 35, 2, 2}", ll.ToString());
        ll.Remove(3);
        Debug.WriteLine("Remuevo 3");
        Debug.WriteLine("After" + ll.ToString());
        Assert.AreEqual("<LinkedList>{5, 6, 2, 4, 35, 2, 2}", ll.ToString());
        ll.Remove(6);
        Debug.WriteLine("Remuevo 6");
        Debug.WriteLine("After" + ll.ToString());
        Assert.AreEqual("<LinkedList>{5, 2, 4, 35, 2, 2}", ll.ToString());
        ll.Remove(2);
        Debug.WriteLine("Remuevo 2");
        Debug.WriteLine("After" + ll.ToString());
        Assert.AreEqual("<LinkedList>{5, 4, 35, 2, 2}", ll.ToString());
        ll.Remove(2);
        Debug.WriteLine("Remuevo otra vez 2");
        Debug.WriteLine("After" + ll.ToString());
        Assert.AreEqual("<LinkedList>{5, 4, 35, 2}", ll.ToString());
        ll.Remove(2);
        Debug.WriteLine("Remuevo una vez mas el 2");
        Debug.WriteLine("After" + ll.ToString());
        Assert.AreEqual("<LinkedList>{5, 4, 35}", ll.ToString());
    }
}

[TestClass]
public class ReplaceTests
{
    [TestMethod]
    public void Replace_NonExistant()
    {
        var ll = new LinkedList();

        ll.InsertHead(2);
        ll.InsertHead(2);
        ll.InsertHead(3);
        ll.InsertHead(4);
        ll.InsertHead(2);
        ll.InsertHead(5);

        ll.Replace(-1, 4);
        Debug.WriteLine("After" + ll.ToString());
        Assert.AreEqual("<LinkedList>{5, 2, 4, 3, 2, 2}", ll.ToString());
    }

    [TestMethod]
    public void Replace_Empty()
    {
        var ll = new LinkedList();

        ll.Replace(-1, 4);
        Debug.WriteLine("asi queda:"+ ll.ToString());
        Assert.AreEqual("<LinkedList>{}", ll.ToString());
    }

    [TestMethod]
    public void Replace_Multiple()
    {
        var ll = new LinkedList();

        ll.InsertHead(2);
        ll.InsertHead(2);
        ll.InsertHead(3);
        ll.InsertHead(4);
        ll.InsertHead(2);
        ll.InsertHead(5);
        Debug.WriteLine("Asi queda" + ll.ToString());
        ll.Replace(2, 4);
        Debug.WriteLine("Asi ha quedado" + ll.ToString());
        Assert.AreEqual("<LinkedList>{5, 4, 4, 3, 4, 4}", ll.ToString());
        Debug.WriteLine("Asi ha quedado" + ll.ToString());
        ll.Replace(3, -1);
        
        Assert.AreEqual("<LinkedList>{5, 4, 4, -1, 4, 4}", ll.ToString());
    }
}

[TestClass]
public class ReverseTests
{
    [TestMethod]
    public void Reverse_Empty()
    {
        var ll = new LinkedList();
        Assert.AreEqual("<IEnumerable>{}", ll.Reverse().AsString());
    }

    [TestMethod]
    public void Reverse_Single()
    {
        var ll = new LinkedList();
        ll.InsertHead(5);
        Assert.AreEqual("<IEnumerable>{5}", ll.Reverse().AsString());
    }

    [TestMethod]
    public void Reverse_Basic()
    {
        var ll = new LinkedList();
        ll.InsertHead(2);
        ll.InsertHead(2);
        ll.InsertHead(3);
        ll.InsertHead(4);
        ll.InsertHead(2);
        ll.InsertHead(5);
        Assert.AreEqual("<IEnumerable>{2, 2, 3, 4, 2, 5}", ll.Reverse().AsString());
    }
}