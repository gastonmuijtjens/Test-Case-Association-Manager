﻿using System.Collections.Generic;

namespace AssociateTestsToTestCases.Access.TestCase
{
    public class DuplicateTestCase
    {
        public readonly string Name;
        public readonly TestCase[] TestCases;

        public DuplicateTestCase(string name, TestCase[] testCases)
        {
            Name = name;
            TestCases = testCases;
        }
    }
}
