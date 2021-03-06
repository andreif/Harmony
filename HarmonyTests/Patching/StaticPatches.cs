﻿using Harmony;
using HarmonyTests.Assets;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace HarmonyTests
{
	[TestClass]
	public class StaticPatches
	{
		/*
		[TestMethod]
		public void TestMethod1()
		{
			// TODO: this test fails within VisualStudio when the patch tries to emit the
			// call to the original method (the delegate to the copy of it).
			//
			// This actually works fine from within a Unity application and probably has
			// something to do with the fact that VS does not allow .NET 2.0 targets to
			// run unit tests. Or something else.

			var originalClass = typeof(Class1);
			Assert.IsNotNull(originalClass);
			var originalMethod = originalClass.GetMethod("Method1");
			Assert.IsNotNull(originalMethod);

			var patchClass = typeof(Class1Patch);
			var realPrefix = patchClass.GetMethod("Prefix");
			var realPostfix = patchClass.GetMethod("Postfix");
			Assert.IsNotNull(realPrefix);
			Assert.IsNotNull(realPostfix);

			Class1Patch._reset();

			MethodInfo prefixMethod;
			MethodInfo postfixMethod;
			PatchTools.GetPatches(typeof(Class1Patch), originalMethod, out prefixMethod, out postfixMethod);

			Assert.AreSame(realPrefix, prefixMethod);
			Assert.AreSame(realPostfix, postfixMethod);

			var instance = HarmonyInstance.Create("test");
			Assert.IsNotNull(instance);

			var patcher = new Patcher(instance);
			Assert.IsNotNull(patcher);

			patcher.Patch(originalMethod, new HarmonyMethod(prefixMethod), new HarmonyMethod(postfixMethod));
			Class1.Method1();

			Assert.IsTrue(Class1Patch.prefixed);
			Assert.IsTrue(Class1Patch.originalExecuted);
			Assert.IsTrue(Class1Patch.postfixed);
		}
		*/
	}
}