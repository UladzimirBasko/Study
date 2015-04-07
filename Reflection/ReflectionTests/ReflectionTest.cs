// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReflectionTest.cs" company="VOVANCHO-PC">
//   Reflection
// </copyright>
// <summary>
//   The ReflectionTest.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReflectionTests
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Reflection;

    /// <summary>
    /// The ReflectionTest
    /// </summary>
    [TestClass]
    public class ReflectionTest
    {
        /// <summary>
        /// Classes the list test.
        /// </summary>
        [TestMethod]
        public void ClassesListTest()
        {
            const string DefaultTypes = "CumbustionEngine INoise GasolineEngine DieselEngine ElectricEngine AlternativeName ";

            var types = typeof(CumbustionEngine).Assembly.GetTypes();
            StringBuilder stringBuilder = new StringBuilder();

            foreach (Type type in types)
            {
                stringBuilder.Append(type.Name);
                stringBuilder.Append(" ");
            }

            Assert.AreEqual(stringBuilder.ToString(), DefaultTypes);
        }

        /// <summary>
        /// Childs the objects test.
        /// </summary>
        [TestMethod]
        public void ChildObjectsTest()
        {
            const int DefaultChildCount = 2;
            var objects = new List<object> { new DieselEngine(), new ElectricEngine(10), new GasolineEngine(20) };
            int childCount = 0;

            foreach (var classObject in objects)
            {
                if (classObject.GetType().BaseType == typeof(CumbustionEngine))
                {
                    childCount++;
                }
            }

            Assert.AreEqual(DefaultChildCount, childCount);
        }

        /// <summary>
        /// Implements the interface objects.
        /// </summary>
        [TestMethod]
        public void ImplementInterfaceObjects()
        {
            const int DefaultImplementInterfaceCount = 2;
            var objects = new List<object> { new DieselEngine(), new ElectricEngine(10), new GasolineEngine(20) };
            int implementsInterface = 0;

            foreach (var classObject in objects)
            {
                if (classObject.GetType().GetInterface("INoise") == typeof(INoise))
                {
                    implementsInterface++;
                }
            }

            Assert.AreEqual(DefaultImplementInterfaceCount, implementsInterface);
        }

        /// <summary>
        /// Properties the list test.
        /// </summary>
        [TestMethod]
        public void PropertyListTest()
        {
            const string DefaultTypes = "Weight Consumption Weight NumberOfCylinders Weight Power Value TypeId ";

            var types = typeof(CumbustionEngine).Assembly.GetTypes();
            StringBuilder stringBuilder = new StringBuilder();

            foreach (Type type in types)
            {
                foreach (var property in type.GetProperties())
                {
                    stringBuilder.Append(property.Name);
                    stringBuilder.Append(" ");
                }
            }

            Assert.AreEqual(stringBuilder.ToString(), DefaultTypes);
        }
    }
}
