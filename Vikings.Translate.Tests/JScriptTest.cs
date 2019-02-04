// <copyright file="JScriptTest.cs" company="Vikings">Copyright ©  2019</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vikings.Translate;

namespace Vikings.Translate.Tests
{
    /// <summary>此类包含 JScript 的参数化单元测试</summary>
    [PexClass(typeof(JScript))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class JScriptTest
    {
        [TestMethod]
        public void TK()
        {
            var text = "中文测试abc123";
            var tkk = "430353.1135737054";
            string result1 = JScript.GetTK(text, tkk);
            string result2 = JScript.TK(text, tkk);
            Assert.AreEqual(result1, result2);
        }

        [PexMethod(MaxBranches = 20000)]
        internal string TK(string a, string TKK)
        {
            //TKK = "430353.1135737054";
            string result = JScript.TK(a, TKK);
            string result1 = JScript.GetTK(a, TKK);
            Assert.AreEqual(result, result1);
            return result;
            // TODO: 将断言添加到 方法 JScriptTest.TK(String, String)
        }
    }
}
