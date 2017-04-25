﻿using System;
using System.Linq;
using Alan.WebApiDoc.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Alan.WebApiDoc.Utils;

namespace Alan.WebApiDoc.UnitTest
{
    [TestClass]
    public class XRawNodeTest
    {
        [TestMethod]
        public void ReadTest()
        {
            var doc1 = XRawMemberNode.Parse(@"C:\Users\Alan\Workspace\Projects\Alan.WebApiDoc\Alan.WebApiDoc\Alan.WebApiDoc.Demonstration\App_Data\Alan.WebApiDoc.Demonstration.XML").ToList();
            var doc2 = XRawMemberNode.Parse(@"C:\Users\Alan\Workspace\Projects\WebApiDoc\Alan.WebApiDoc.Demonstration\App_Data\WebApiDoc.XML").ToList();

            var result = doc2.Select(d => d.Convert<Member, Parameter>()).ToList();
        }
    }
}