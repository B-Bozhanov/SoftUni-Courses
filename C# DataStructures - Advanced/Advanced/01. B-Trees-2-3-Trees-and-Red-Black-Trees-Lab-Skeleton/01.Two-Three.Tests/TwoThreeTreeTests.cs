using System;
using NUnit.Framework;
using _01.Two_Three;
using Microsoft.VisualBasic;

public class TwoThreeTreeTests
{
    [Test]
    public void Delete_Should_Rebalance_Tree_Coectly()
    {
        var tree = new TwoThreeTree<string>();

        String[] arr = { "F", "C", "G", "A", "B", "D", "E", "K", "I", "G", "H", "J", "K", "Z" };
        for (int i = 0; i < arr.Length; i++)
        {
            tree.Insert(arr[i]);
        }

        tree.Delete("I");

        string[] expectedResult1 = new string[] { "B", "C", "E", "G", "D", "F", "H", "J", "K", "Z", "I", "K", "G" };

        var result1 = tree.PostOrder();

        CollectionAssert.AreEqual(result1, expectedResult1);

        tree.Delete("F");

        string[] expectedResult2 = new string[] { "B", "D", "G", "C", "E", "H", "J", "K", "Z", "I", "K", "G"};

        var result2 = tree.PostOrder();

        CollectionAssert.AreEqual(result2, expectedResult2);

        tree.Delete("G");
        tree.Delete("G");
        tree.Delete("E");
        tree.Delete("D");
        tree.Delete("K");

        string[] expectedResult3 = new string[] { "B", "H", "C", "J", "Z", "K", "I"};

        var result3 = tree.PostOrder();

        CollectionAssert.AreEqual(result3, expectedResult3);
    }

    [Test]
    public void Delete_Leaf_ThreeNode_Should_Work_Corectly()
    {
        var tree = new TwoThreeTree<string>();

        String[] arr = { "F", "C", "G", "A", "B", "D", "E", "K", "I", "G", "H", "J", "K", "Z" };
        for (int i = 0; i < arr.Length; i++)
        {
            tree.Insert(arr[i]);
        }

        tree.Delete("Z");

        string[] expectedResult = new string[] { "A", "C", "B", "E", "G", "F", "H", "J", "K", "I", "K", "D", "G" };

        var result = tree.PostOrder();

        CollectionAssert.AreEqual(result, expectedResult);
    }

    [Test]
    public void SearchMax_Should_Work_Corectly()
    {
        var tree = new TwoThreeTree<string>();

        String[] arr = { "F", "C", "G", "A", "B", "D", "E", "K", "I", "G", "H", "J", "K", "Z" };
        for (int i = 0; i < arr.Length; i++)
        {
            tree.Insert(arr[i]);
        }

        string expectedResult = "Z";

        var result = tree.SearchMax();

        if (result.RightKey != null)
        {
            Assert.AreEqual(result.RightKey, expectedResult);
        }
        else
        {
            Assert.AreEqual(result.LeftKey, expectedResult);
        }
    }

    [Test]
    public void SearchMin_Should_Work_Corectly()
    {
        var tree = new TwoThreeTree<string>();

        String[] arr = { "F", "C", "G", "A", "B", "D", "E", "K", "I", "G", "H", "J", "K" };
        for (int i = 0; i < 13; i++)
        {
            tree.Insert(arr[i]);
        }

        string expectedResult = "A";

        var result = tree.SearchMin();

        Assert.AreEqual(result.LeftKey, expectedResult);
    }

    [Test]
    public void PostOrder_Should_Work_Corectly()
    {
        var tree = new TwoThreeTree<string>();

        String[] arr = { "F", "C", "G", "A", "B", "D", "E", "K", "I", "G", "H", "J", "K" };
        for (int i = 0; i < 13; i++)
        {
            tree.Insert(arr[i]);
        }

        string[] expectedResult = new string[] { "A", "C", "B", "E", "G", "F", "H", "J", "K", "I", "K", "D", "G" };

        var result = tree.PostOrder();

        CollectionAssert.AreEqual(result, expectedResult);
    }

    [Test]
    public void Search_Should_Work_Corectly()
    {
        var tree = new TwoThreeTree<string>();

        String[] arr = { "F", "C", "G", "A", "B", "D", "E", "K", "I", "G", "H", "J", "K" };
        for (int i = 0; i < 13; i++)
        {
            tree.Insert(arr[i]);
        }

        var result = tree.Search("K");

        if (result.RightKey.Equals("K"))
        {
            result.LeftKey = "K";
        }

        Assert.AreEqual("K", result.LeftKey);
    }

    [Test]
    public void Search_Should_Be_Null_If_Element_Dont_Exist()
    {
        var tree = new TwoThreeTree<string>();

        String[] arr = { "F", "C", "G", "A", "B", "D", "E", "K", "I", "G", "H", "J", "K" };
        for (int i = 0; i < 13; i++)
        {
            tree.Insert(arr[i]);
        }

        var result = tree.Search("W");

        Assert.IsTrue(result == null);
    }

    [Test]
    public void Insert_SingleElement()
    {
        var tree = new TwoThreeTree<string>();
        tree.Insert("13");

        Assert.AreEqual("13", tree.ToString().Trim());
    }

    [Test]
    public void Insert_FewElements()
    {
        var tree = new TwoThreeTree<string>();
        tree.Insert("A");
        tree.Insert("B");
        tree.Insert("C");
        Assert.AreEqual("B " + Environment.NewLine +
                        "A " + Environment.NewLine +
                        "C", tree.ToString().Trim());
    }

    [Test]
    public void Insert_LargeNumberOfElements()
    {
        var tree = new TwoThreeTree<string>();

        String[] arr = { "F", "C", "G", "A", "B", "D", "E", "K", "I", "G", "H", "J", "K" };
        for (int i = 0; i < 13; i++)
        {
            tree.Insert(arr[i]);
        }

        Assert.AreEqual("D G" + Environment.NewLine +
                        "B " + Environment.NewLine +
                        "A " + Environment.NewLine +
                        "C " + Environment.NewLine +
                        "F " + Environment.NewLine +
                        "E " + Environment.NewLine +
                        "G " + Environment.NewLine +
                        "I K" + Environment.NewLine +
                        "H " + Environment.NewLine +
                        "J " + Environment.NewLine +
                        "K", tree.ToString().Trim());
    }
}