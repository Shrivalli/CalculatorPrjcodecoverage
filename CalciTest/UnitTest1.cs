using NUnit.Framework;
using CalculatorPrj;
using System.Collections.Generic;
using Moq;
namespace CalciTest
{
    [TestFixture]
    public class Tests
    {
        public static ICalculator Iobj;
        public static IEmp Iempobj;
        public static Mock<ICalculator> mockcalci;
        [SetUp]
        public void Setup()
        {
            Iobj = new Calci();
            Iempobj = new Emp();
            mockcalci = new Mock<ICalculator>();
        }

        [Test]
        public void TestGetAllEmpMethodCount()
        {
            var actres = Iempobj.getAllEmps();
            int count = actres.Count;
            int expcount = 2;
            Assert.AreEqual(expcount, count);
        }

        [Test]
        public void TestGetAllEmpMethodEname()
        {
            List<Emp> actres = Iempobj.getAllEmps();
            Emp obj = new Emp();
            foreach (var item in actres)
            {
                obj.Eid = item.Eid;
                obj.Ename = item.Ename;
                obj.Sal = item.Sal;
            }
            float expsal = 12000;
            Assert.AreEqual(expsal, obj.Sal);
        }

        [Test]
        public void TestAddMethod()
        {
            //Assume, Act, Assert
            int actualresult=Iobj.add(10, 5);
            int expectedresult = 15;
            Assert.AreEqual(expectedresult,actualresult);
        }

        [Test]
        public void TestSubMethod()
        {
            int actualresult = Iobj.sub(10, 5);
            int expectedresult = 5;
            Assert.AreEqual(expectedresult, actualresult);

        }

        [Test]
        public void TestMessageMethod()
        {
            string actres = Iobj.message("Ram");
            string expres = "Hello Ram";
            Assert.AreEqual(expres, actres);
        }

        [Test]
        public void TestcheckagePass()
        {
            bool actualres = Iobj.checkage(22);
            bool expres = true;
            Assert.AreEqual(expres, actualres);

        }

        [Test]
        public void TestcheckageFail()
        {
            bool actualres = Iobj.checkage(12);
            bool expres = false;
            Assert.AreEqual(expres, actualres);

        }

        [Test]
        public void TestValiddataMethod()
        {
            mockcalci.Setup(x => x.checkage(19)).Returns(true);
            int actres = Iobj.validdata();
            int expres = 10;
            Assert.AreEqual(expres, actres);
        }
    }
}