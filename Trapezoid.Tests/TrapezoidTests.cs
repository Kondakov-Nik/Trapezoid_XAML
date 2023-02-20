// Автор Кондаков Никита
using System.Reflection.Metadata;

namespace Trapezoid.Tests //определение пространства имен Trapezoid
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPerimeter() // тест результата периметра трапеции
        {

            Trap t = new Trap();

            t.set_trap(6, 4, 6, 3);
            Assert.AreEqual(19, t.perimetr());

            Trap b = new Trap();
            b.set_trap(8, 5, 1, 9);
            Assert.AreEqual(23, b.perimetr());


        }
        [TestMethod]
        public void TestSquare() // тест результата площади трапеции
        {
            Trap t = new Trap();
            t.set_trap(4, 6, 2, 3);
            Assert.AreEqual(16.68645, t.square(), 0.00005);

            Trap b = new Trap();
            b.set_trap(6, 9, 11, 7);
            Assert.AreEqual(47.32864, b.square(), 0.00005);
        }
        
        [TestMethod]
        public void TestSide() // тест задания сторон трапеции
        {
            Trap t = new Trap();
            t.set_trap(4, 6, 2, 3);
            Assert.AreEqual(4, t.get_ab());
            Assert.AreEqual(6, t.get_bc());
            Assert.AreEqual(2, t.get_cd()); 
            Assert.AreEqual(3, t.get_ad());

            Trap b = new Trap();
            b.set_trap(15, 5, 8, 11);
            Assert.AreEqual(15, b.get_ab());
            Assert.AreEqual(5, b.get_bc());
            Assert.AreEqual(8, b.get_cd());
            Assert.AreEqual(11, b.get_ad());
        }


    }
}