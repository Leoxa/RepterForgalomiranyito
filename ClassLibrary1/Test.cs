using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    class Test
    {
        [TestFixture]
        public class ClassLibrary1
        {
            JaratKezelo b;

            [SetUp]
            public void Setup()
            {
                b = new JaratKezelo();
            }

            [Test]
            public void UjJaratTest()
            {
                b.UjJarat("123", "Budapest", "Hawaii", new DateTime(3, 4, 2019, 12, 12, 00));
                b.UjJarat("124", "Budapest", "Hawaii", new DateTime(4, 5, 2019, 12, 12, 00));
                b.UjJarat("125", "Budapest", "Hawaii", new DateTime(5, 6, 2019, 12, 12, 00));
                Assert.Throws<ArgumentException>(
                    () =>
                        {
                            b.UjJarat("123", "Budapest", "Hawaii", new DateTime(3, 4, 2019, 12, 12, 00));
                            b.UjJarat("124", "Budapest", "Hawaii", new DateTime(4, 5, 2019, 12, 12, 00));
                            b.UjJarat("125", "Budapest", "Hawaii", new DateTime(5, 6, 2019, 12, 12, 00));
                        }
                    );
            }

            [Test]
            public void MikorIndulTest()
            {
                b.UjJarat("123", "Budapest", "Hawaii", new DateTime(3, 4, 2019, 12, 12, 00));
                b.UjJarat("124", "Budapest", "Hawaii", new DateTime(4, 5, 2019, 12, 12, 00));
                b.UjJarat("125", "Budapest", "Hawaii", new DateTime(5, 6, 2019, 12, 12, 00));
                b.MikorIndul("123");
                b.MikorIndul("124");
                b.MikorIndul("125");
                Assert.Throws<ArgumentException>(
                    () =>
                    {
                        b.MikorIndul("123");
                        b.MikorIndul("124");
                        b.MikorIndul("125");
                    }
                    );
            }

            [Test]
            public void JaratokRepuloterrolTest()
            {
                b.UjJarat("123", "Budapest", "Hawaii", new DateTime(3, 4, 2019, 12, 12, 00));
                b.UjJarat("124", "Budapest", "Hawaii", new DateTime(4, 5, 2019, 12, 12, 00));
                b.UjJarat("125", "Budapest", "Hawaii", new DateTime(5, 6, 2019, 12, 12, 00));
                b.JaratokRepuloterrol("123");
                b.JaratokRepuloterrol("124");
                b.JaratokRepuloterrol("125");
                Assert.Throws<ArgumentException>(
                    () =>
                    {
                        b.JaratokRepuloterrol("123");
                        b.JaratokRepuloterrol("124");
                        b.JaratokRepuloterrol("125");
                    }
                    );
            }

            [Test]
            public void KesesTest()
            {
                b.UjJarat("123", "Budapest", "Hawaii", new DateTime(3, 4, 2019, 12, 12, 00));
                b.UjJarat("124", "Budapest", "Hawaii", new DateTime(4, 5, 2019, 12, 12, 00));
                b.UjJarat("125", "Budapest", "Hawaii", new DateTime(5, 6, 2019, 12, 12, 00));
                b.Keses("123", (2));
                b.Keses("124", (3));
                b.Keses("125", (4));
                Assert.Throws<ArgumentException>(
                    () =>
                    {
                        b.Keses("123", (2));
                        b.Keses("124", (3));
                        b.Keses("125", (4));
                    }
                    );
            }
        }
    }
}