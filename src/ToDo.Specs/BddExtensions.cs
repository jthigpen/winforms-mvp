using System.Collections;
using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;

namespace ToDo.Specs
{
    public static class BddExtensions
    {
        public static void ShouldBe(this object dis, object that)
        {
            Assert.That(dis, Is.SameAs(that));
        }

        public static void ShouldBeNull(this object dis)
        {
            Assert.That(dis, Is.Null);
        }

        public static void ShouldNotBeNull(this object dis)
        {
            Assert.That(dis, Is.Not.Null);
        }

        public static void ShouldBeTrue(this bool dis)
        {
            Assert.That(dis, Is.True);
        }            

        public static void ShouldBeFalse(this bool dis)
        {
            Assert.That(dis, Is.False);
        }

        public static void ShouldEqual(this object dis, object that)
        {
            Assert.That(dis, Is.EqualTo(that));
        }

        public static void ShouldNotEqual(this object dis, object that)
        {
            Assert.That(dis, Is.Not.EqualTo(that));
        }

        public static void ShouldBeOfType<T>(this object dis)
        {
            Assert.That(dis, Is.TypeOf(typeof(T)));
        }

        public static void ShouldBeInstanceOf<T>(this object dis)
        {
            Assert.That(dis, Is.InstanceOfType(typeof(T)));
        }

        public static void ShouldContain(this IEnumerable collection, object item)
        {
            CollectionAssert.Contains(collection, item);
        }

        public static void ShouldNotContain(this IEnumerable collection, object item)
        {
            CollectionAssert.DoesNotContain(collection, item);
        }

        public static void ShouldContainOnly(this IEnumerable collection, IEnumerable collectionToCompare)
        {
            CollectionAssert.AreEquivalent(collection, collectionToCompare);
        }

        public static void ShouldBeEmpty(this IEnumerable collection)
        {
            CollectionAssert.IsEmpty(collection);
        }
    }
}