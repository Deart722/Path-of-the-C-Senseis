using Path_of_the_C_Senseis.Path_of_the_C_Sensei_.Kata8;
using System;
using NUnit.Framework;



namespace Path_of_the_C_Senseis.Path_of_the_C_Sensei_.Kata8.Tests
{
    [TestFixture]
    public class VariableNameExampleTests
    {
        [Test, Order(1)]
        public void TestBoolVariable()
        {
            VariableName variables = new VariableName();
            Assert.That(CheckType(variables, "bool", typeof(bool)), Is.True);
        }

        [Test, Order(2)]
        public void TestCharVariable()
        {
            VariableName variables = new VariableName();
            Assert.That(CheckType(variables, "char", typeof(char)), Is.True);
        }

        [Test, Order(3)]
        public void TestSbyteVariable()
        {
            VariableName variables = new VariableName();
            Assert.That(CheckType(variables, "sbyte", typeof(sbyte)), Is.True);
        }

        private bool CheckType(object obj, string fieldName, Type expectedType)
        {
            var field = obj.GetType().GetField(fieldName);
            if (field == null) return false;

            return field.FieldType == expectedType;
        }
    }

}