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
            Assert.AreEqual(2,listRecord.Count);
        }

        [TestMethod]
        public void GetIdTest()
        {
            List<record> recordList = new List<record>(rntr.Get());
            Assert.AreEqual(1, recordList[0].Id);
        }

        [TestMethod]
        public void GetByTitleTest()
        {
            // arrange
            // i BeforeAllTest

            // action
            List<record> recordList = new List<record>(rntr.GetByTitle("hello"));


            // assert
            Assert.AreEqual(1,recordList.Count);
            Assert.AreEqual("hello",recordList[0].Title);
        }

        [TestMethod]
        public void GetByArtistTest()
        {
            // arrange
            // i BeforeAllTest

            // action
            List<record> recordList = new List<record>(rntr.GetByArtist("Steven Wilson"));

            // assert
            Assert.AreEqual(1,recordList.Count);
            Assert.AreEqual("Steven Wilson",recordList[0].Artist);
        }

        [TestMethod]
        public void GetByDurationTest()
        {
            // arrange
            FilterRecord filter = new FilterRecord(250,90);

            // action
            List<record> recordList = new List<record>(rntr.GetByDuration(filter));

            // assert
            Assert.AreEqual(2,recordList.Count);
        }
    }
}
