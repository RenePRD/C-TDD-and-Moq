using NUnit.Framework;
using SourceCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestFixture]
    internal class GradeCalculatorTest
    {
        private GradeCalculator? _classUnderTest;

        [TestCase(70)]
        public void TestMethodGetClassificationReturnsFailWhenMarkInputtedIsLowerThan75(double mark)
        {
            //arrange
            var _classUnderTest = new GradeCalculator();

            //act
            string classification = _classUnderTest.GetClassification(mark);

            //assert
            Assert.AreEqual("fail", classification);
            
        }

        [TestCase(75, ExpectedResult ="pass")]
        public string TestMethodGetClassificationReturnsPassWhenMarkInputtedIsGreaterThanOrEqualTo75ButLessThan80(double mark)
        {
            //arrange
            var _classUnderTest = new GradeCalculator();

            //act && assert
            return _classUnderTest.GetClassification(mark);
        }

        [TestCase(80, ExpectedResult ="merit")]
        public string TestMethodGetClassificationReturnsMeritWhenMarkInputtedIsGreaterThanOrEqualTo80ButLess90(double mark)
        {
            //arrange
            var _classUnderTest = new GradeCalculator();

            //act && assert
            return _classUnderTest.GetClassification(mark);
        }

        [TestCase(90, ExpectedResult = "distinction")]
        public string TestMethodGetClassificationReturnsMeritWhenMarkInputtedIsGreaterThanOrEqualTo90ButLessThanOrEquakTo100(double mark)
        {
            //arrange
            var _classUnderTest = new GradeCalculator();

            //act && assert
            return _classUnderTest.GetClassification(mark);
        }

    }
}
