using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringAssert_Demo;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Test_StringAssert_Contain()
    {
        StringAssert.Contains("abcdef","c");
    }
    
    [TestMethod]
    [ExpectedException(typeof(AssertFailedException))]
    public void Test_StringAssert_DoesNotContain()
    {
        StringAssert.Contains("abcdef","x");
    }
    
    [TestMethod]
    [ExpectedException(typeof(AssertFailedException))]
    public void Test_StringAssert_DoesNotContain_WithCurly()
    {
        StringAssert.Contains(":-{","x");
    }

    [TestMethod]
    [ExpectedException(typeof(AssertFailedException))]
    public void Test_StringAssert_DoesNotContain_WithCurly_Long()
    {
        StringAssert.Contains(":-{","x","",null);
    }

}