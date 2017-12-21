using Microsoft.VisualStudio.TestTools.UnitTesting;
using Thickener;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thickener.Tests.ThickenerTests
{
    [TestClass]
    public class Thicken
    {

        [TestMethod]
        [DataRow("Whatup", "山卄卂丅凵尸")]
        [DataRow("Hello World", "卄乇乚乚口 山口尺乚刀")]
        [DataRow("the quick brown fox jumps over the lazy dog", "丅卄乇 㔿凵工匚长 乃尺口山几 下口乂 丁凵从尸丂 口リ乇尺 丅卄乇 乚卂乙丫 刀口厶")]
        public void Given_Known_String_Should_Return_Desired_Output(string toThicken, string thick)
        {
            Assert.AreEqual(toThicken.Thicken(), thick);
        }

        [TestMethod]
        [DataRow("Spaces In Here", "丂尸卂匚乇丂 工几 卄乇尺乇")]
        [DataRow("New\nLine", "几乇山\n乚工几乇")]
        public void Given_White_Space_Character_Should_Not_Replace(string toThicken, string thick)
        {
            Assert.AreEqual(toThicken.Thicken(), thick);
        }

        [TestMethod]
        [DataRow("Hi!", "卄工!")]
        [DataRow("Or, Hi?", "口尺, 卄工?")]
        [DataRow("hi-hi", "卄工-卄工")]
        [DataRow("yo_yo?", "丫口_丫口?")]
        [DataRow("#", "#")]
        [DataRow("/", "/")]
        [DataRow("@", "@")]
        [DataRow("£", "£")]
        public void Given_Unknown_Characters_Should_Ignore_Conversion(string toThicken, string thick)
        {
            Assert.AreEqual(toThicken.Thicken(), thick);
        }
    }
}
