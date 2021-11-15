using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestExample
{
    // A Test behaves as an ordinary method
    [Test]
    public void TestExampleSimplePasses()
    {
        Assert.AreEqual(2 + 2, 4);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.

}
