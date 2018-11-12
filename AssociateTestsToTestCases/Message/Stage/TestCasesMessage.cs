﻿namespace AssociateTestsToTestCases.Message.Stage
{
    public class TestCasesMessage
    {
        public readonly string Status = "Trying to retrieve the Azure DevOps Test Cases...";
        public readonly string Success = "Azure DevOps Test Cases have been obtained ({0}).\n";
        public readonly string Failure = "Could not retrieve the Azure DevOps Test Cases. Program has been terminated.\n";
    }
}
