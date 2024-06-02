using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;


namespace TestGiaiPT
{
    [TestClass]
    public class TestGiaiPT_18
    {
        [TestMethod]
        public void Test_GiaiPT1_VoSoNghiem()
        {
            // Arrange
            float a = 0;
            float b = 0;
            string expected = "Phương trình vô số nghiệm.";
            // Act
            string actual = GiaiPT_18_Huynh.GiaiPT1(a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GiaiPT1_VoNghiem()
        {
            // Arrange
            float a = 0;
            float b = 1;
            string expected = "Phương trình vô nghiệm.";

            // Act
            string actual = GiaiPT_18_Huynh.GiaiPT1(a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GiaiPT1_MotNghiem()
        {
            // Arrange
            float a = 1;
            float b = -1;
            string expected = "1";

            // Act
            string actual = GiaiPT_18_Huynh.GiaiPT1(a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GiaiPT2_VoNghiem()
        {
            // Arrange
            float a = 1;
            float b = 1;
            float c = 1;
            string expected = "Phương trình vô nghiệm.";

            // Act
            string actual = GiaiPT_18_Huynh.GiaiPT2(a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GiaiPT2_CoHaiNghiem()
        {
            float a = 1;
            float b = -2;
            float c = 1;
            string expected = "x1=x2= 1";
            string actual = GiaiPT_18_Huynh.GiaiPT2(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GiaiPT2_HaiNghiemPhanBiet()
        {
            float a = 1;
            float b = -3;
            float c = 2;
            string expected = "x1=2  x2=1";
            string actual = GiaiPT_18_Huynh.GiaiPT2(a, b, c);
            Assert.AreEqual(expected, actual);
        }
    }
}
