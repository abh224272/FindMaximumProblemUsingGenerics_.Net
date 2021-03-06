﻿using FindMaximumNumber_Generics;
using NUnit.Framework;

namespace FindMaximumTest
{
    class MaximumNumberCheckGenericTestClass
    {
        [Test]
        public void GivenIntGeneric_ShouldValidate_AndReturnMaximumNumber()
        {
            int output = new MaximumNumberCheckGenericClass<int>(34, 18, 6).MaxValue();
            Assert.AreEqual(34, output);
        }
        [Test]
        public void GivenFloatGeneric_ShouldValidate_AndReturnMaximumNumber()
        {
            float output = new MaximumNumberCheckGenericClass<float>(15.25f, 25.45f, 55.55f).MaxValue();
            Assert.AreEqual(55.55f, output);
        }
        [Test]
        public void GivenstringGeneric_ShouldValidate_AndReturnMaximumStringValue()
        {
            string output = new MaximumNumberCheckGenericClass<string>("Apple", "Peach", "Banana").MaxValue();
            Assert.AreEqual("Peach", output);
        }
    }
}
