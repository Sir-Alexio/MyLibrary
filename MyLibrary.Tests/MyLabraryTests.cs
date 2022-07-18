using NUnit.Framework;
using MyLibrary;
using System;

namespace MyLibrary.Tests
{
    public class Tests
    {

        [Test]
        public void CheckTriangleSquareInt()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            Assert.AreEqual(6, triangle.MakeSquare());

        }

        [Test]
        public void CheckTriangleSquareDoubleFirst()
        {
            Triangle triangle = new Triangle(3.6, 4.9, 8.1);

            Assert.AreEqual(5.1504174588085725, triangle.MakeSquare());

        }

        [Test]
        public void CheckTriangleSquareDoubleSecond()
        {
            Triangle triangle = new Triangle(3.2, 4.4, 6.1);

            Assert.AreEqual(6.7780597334340431, triangle.MakeSquare());

        }

        [Test]
        public void CheckTriangleError()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(3, 4, 8));
        }

        [Test]
        public void CheckTriangleRightFirst()
        {
            Triangle triangle = new Triangle(3,4,5);

            Assert.AreEqual(true, triangle.isTriangleRight());

        }

        [Test]
        public void CheckTriangleRightSecond()
        {
            Triangle triangle = new Triangle(4, 5, 6);

            Assert.AreEqual(false, triangle.isTriangleRight());

        }

        [Test]
        public void CheckMyCircleError()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new My—ircle(-10));
        }

        [Test]
        public void CheckMyCircleSquareFirst()
        {
            My—ircle my—ircle = new My—ircle(10);

            Assert.AreEqual(314.15926535897933, my—ircle.MakeSquare());

        }

        [Test]
        public void CheckMyCircleSquareSecond()
        {
            My—ircle my—ircle = new My—ircle(12.44);

            Assert.AreEqual(486.17277287657339, my—ircle.MakeSquare());

        }
    }
}