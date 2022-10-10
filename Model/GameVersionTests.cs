using Microsoft.VisualStudio.TestTools.UnitTesting;
using FTPExample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTPExample.Model.Tests
{
    [TestClass]
    public class GameVersionTests
    {
        GameVersion gameVersion;

        [TestMethod]
        public void GameVersionStringConstructorTest()
        {
            gameVersion = new GameVersion("1.2.3");
            Assert.AreEqual(1, gameVersion.Major);
            Assert.AreEqual(2, gameVersion.Minor);
            Assert.AreEqual(3, gameVersion.Patch);
            Assert.AreEqual("1.2.3", gameVersion.ToString());
        }

        [TestMethod]
        public void GameVersionNoArgsConstructorTest()
        {
            GameVersion gameVersion = new GameVersion();
            Assert.AreEqual(0, gameVersion.Major);
            Assert.AreEqual(0, gameVersion.Minor);
            Assert.AreEqual(0, gameVersion.Patch);
            Assert.AreEqual("0.0.0", gameVersion.ToString());
        }

        [ExpectedException(typeof(FormatException))]
        [TestMethod]
        public void GameVersionFormatErrorTest1()
        {
            GameVersion gameVersion = new GameVersion("1.2.3.4");
        }

        [ExpectedException(typeof(FormatException))]
        [TestMethod]
        public void GameVersionFormatErrorTest2()
        {
            GameVersion gameVersion = new GameVersion("1.4");
        }

        [ExpectedException(typeof(FormatException))]
        [TestMethod]
        public void GameVersionFormatErrorTest3()
        {
            GameVersion gameVersion = new GameVersion("x.y.z");
        }
    }
}