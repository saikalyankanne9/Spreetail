using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Spreetail.MultiValueDictionary.Services.Implementation.v1;
using Spreetail.MultiValueDictionary.Services.Interfaces.v1;
using System;
using Assert = NUnit.Framework.Assert;

namespace Spreetail.MultiValueDictionaryTest
{
    [TestClass]
    public class UnitTest1
    {
        IMultiValueDictionary<string, string> nvd;
        [SetUp]
        public void Setup()
        {
            nvd = new MultiValueDictionaryImpl<string, string>();
        }
        [TestMethod]
        public void TestAddAndGetAllMethod()
        {
            IMultiValueDictionary<string, string> nvd = new MultiValueDictionaryImpl<string, string>();
            nvd.Add("foo", "bar");
            nvd.Add("baz", "bang");
            Assert.AreEqual(nvd.GetAllMembers().Count, 2);
        }
        [TestMethod]
        public void TestAddMethodException()
        {
            IMultiValueDictionary<string, string> nvd = new MultiValueDictionaryImpl<string, string>();
            nvd.Add("foo", "bar");
            Assert.Throws<Exception>(() => nvd.Add("hello", "world"));
        }
        [TestMethod]
        public void TestMembersMethod()
        {
            IMultiValueDictionary<string, string> nvd = new MultiValueDictionaryImpl<string, string>();
            nvd.Add("foo", "bar");
            nvd.Add("foo", "bar2");
            Assert.AreEqual(nvd.GetMembers("foo").Count, 2);
        }
        [TestMethod]
        public void TestMembersException()
        {
            IMultiValueDictionary<string, string> nvd = new MultiValueDictionaryImpl<string, string>();
            nvd.Add("foo", "bar");
            nvd.Add("foo", "bar2");
            Assert.Throws<Exception>(() => nvd.GetMembers("foo2"));
        }
        [TestMethod]
        public void TestGetKeyMethod()
        {
            IMultiValueDictionary<string, string> nvd = new MultiValueDictionaryImpl<string, string>();
            nvd.Add("foo", "bar");
            nvd.Add("foo3", "bar2");
            Assert.AreEqual(nvd.GetKeys().Count, 2);
        }
        [TestMethod]
        public void TestGetKeyException()
        {
            IMultiValueDictionary<string, string> nvd = new MultiValueDictionaryImpl<string, string>();
            Assert.Throws<Exception>(() => nvd.GetKeys());
        }
        [TestMethod]
        public void TestRemoveAllMethod()
        {
            IMultiValueDictionary<string, string> nvd = new MultiValueDictionaryImpl<string, string>();
            nvd.Add("foo", "bar");
            nvd.Add("foo3", "bar2");
            nvd.RemoveAll("foo3");
            Assert.AreEqual(nvd.GetKeys().Count, 1);
        }
        [TestMethod]
        public void TestRemoveAllException()
        {
            IMultiValueDictionary<string, string> nvd = new MultiValueDictionaryImpl<string, string>();
            Assert.Throws<Exception>(() => nvd.RemoveAll("foo3"));
        }
        [TestMethod]
        public void TestClearMethod()
        {
            IMultiValueDictionary<string, string> nvd = new MultiValueDictionaryImpl<string, string>();
            nvd.Add("foo", "bar");
            nvd.Add("foo3", "bar2");
            nvd.Clear();
            Assert.AreEqual(nvd.GetKeys().Count, 0);
        }
        [TestMethod]
        public void TestItemsMethod()
        {
            IMultiValueDictionary<string, string> nvd = new MultiValueDictionaryImpl<string, string>();
            nvd.Add("foo", "bar");
            nvd.Add("foo3", "bar2");
            Assert.AreEqual(nvd.GetItems().Count, 2);
        }
        [TestMethod]
        public void TestAllMembersMethod()
        {
            IMultiValueDictionary<string, string> nvd = new MultiValueDictionaryImpl<string, string>();
            nvd.Add("foo", "bar");
            nvd.Add("foo3", "bar2");
            Assert.AreEqual(nvd.GetAllMembers().Count, 2);
        }
        [TestMethod]
        public void TestKeyExistMethod()
        {
            IMultiValueDictionary<string, string> nvd = new MultiValueDictionaryImpl<string, string>();
            nvd.Add("foo", "bar");
            nvd.Add("foo3", "bar2");
            Assert.AreEqual(nvd.CheckKeyExists("foo3"), true);
        }
        [TestMethod]
        public void TestValueExistMethod()
        {
            IMultiValueDictionary<string, string> nvd = new MultiValueDictionaryImpl<string, string>();
            nvd.Add("foo", "bar");
            nvd.Add("foo3", "bar2");
            Assert.AreEqual(nvd.CheckValueExists("foo", "bar"), true);
        }
    }
}
