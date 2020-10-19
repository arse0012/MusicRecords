using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicRecords;
using MusicRecords.Controllers;

namespace RecordsTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private RecordsController rntr = null;
        [TestInitialize]
        public void BeforeAllTest()
        {
            rntr = new RecordsController();
        }

        [TestMethod]
        public void GetTest()
        {
            //arrange
            List<record> listRecord = new List<record>();
            {
                
            };

            //action
            foreach (record Records in rntr.Get())
            {
                listRecord.Add(Records);
            }

            //assert
        }
    }
}
