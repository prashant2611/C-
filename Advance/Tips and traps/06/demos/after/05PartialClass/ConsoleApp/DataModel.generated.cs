﻿namespace ConsoleApp
{
    // E.g. this could have been generated by a tool,visual designer, etc.
    public partial class DataModel
    {
        public string Status { get; private set; }

        public DataModel()
        {
            Status = "New";
        }

        public void ClearStatus()
        {
            Status = "";
            AfterStatusCleared();
        }

        partial void AfterStatusCleared(); // No implementation or {} 
    }
}
