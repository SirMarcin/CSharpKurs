using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Odcinek10;

namespace Odcinek10.Tests
{
    [TestClass]
    public class DiaryTest
    {
        [TestMethod]
        public void DiarCalculateMaxGrade()
        {
            Diary diary = new Diary();
            diary.AddRating(5f);
            diary.AddRating(2.5f);
            diary.AddRating(4f);
            diary.AddRating(3.5f);
            diary.AddRating(4.5f);
            diary.AddRating(6f);

            DiaryStatistics stats = diary.ComputStatistics();

            Assert.AreEqual(5f, stats.MaxGrade);
            Assert.AreNotEqual(6f, stats.MaxGrade);
        }

        [TestMethod]
        public void PassByValueClass()
        {
            Diary diary = new Diary();
            diary.Name = "Jacek";
            SetName(diary);
            Assert.AreEqual("Marcin", diary.Name);
        }

        [TestMethod]
        public void PassByValueInt()
        {
            int x1 = 5;
            IncrementNumber(x1);
            Assert.AreEqual(5, x1);
        }

        [TestMethod]
        public void PassByReferenceInt()
        {
            int x1 = 5;
            IncrementNumber(ref x1);
            Assert.AreEqual(15, x1);
        }

        private void IncrementNumber(int number)
        {
            number = 15;
        }

        private void IncrementNumber(ref int number)
        {
            number = 15;
        }

        private void SetName(Diary diary)
        {
            diary.Name = "Marcin";
        }
    }
}
