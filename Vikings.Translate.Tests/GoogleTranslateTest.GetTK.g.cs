﻿using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <auto-generated>
// 此文件包含自动生成的测试。
// 不要手动修改此文件。
// 
// 如果此文件的内容过时，你可以将它删除。
// 例如，它不再编译。
// </auto-generated>
using System;

namespace Vikings.Translate.Tests
{
    public partial class GoogleTranslateTest
    {

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void GetTKThrowsArgumentNullException521()
{
    string s;
    s = this.GetTK((string)null, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void GetTKThrowsArgumentNullException855()
{
    string s;
    s = this.GetTK("\0", (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
[ExpectedException(typeof(ArgumentException))]
public void GetTKThrowsArgumentException246()
{
    string s;
    s = this.GetTK("\0", "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
[ExpectedException(typeof(ArgumentException))]
public void GetTKThrowsArgumentException41()
{
    string s;
    s = this.GetTK(".", ".");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
[ExpectedException(typeof(ArgumentException))]
public void GetTKThrowsArgumentException880()
{
    string s;
    s = this.GetTK("\0", "\0\0");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
[ExpectedException(typeof(ArgumentException))]
public void GetTKThrowsArgumentException977()
{
    string s;
    s = this.GetTK("\0", "\0.");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
[ExpectedException(typeof(ArgumentException))]
public void GetTKThrowsArgumentException46()
{
    string s;
    s = this.GetTK("", ".");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
[ExpectedException(typeof(ArgumentException))]
public void GetTKThrowsArgumentException296()
{
    string s;
    s = this.GetTK("-", "-.");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
[ExpectedException(typeof(ArgumentException))]
public void GetTKThrowsArgumentException196()
{
    string s;
    s = this.GetTK("0", "0.");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
[ExpectedException(typeof(ArgumentException))]
public void GetTKThrowsArgumentException869()
{
    string s;
    s = this.GetTK(":", ":.");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
[ExpectedException(typeof(ArgumentException))]
public void GetTKThrowsArgumentException884()
{
    string s;
    s = this.GetTK("\0", "\0..");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
[ExpectedException(typeof(ArgumentException))]
public void GetTKThrowsArgumentException469()
{
    string s;
    s = this.GetTK("\0", "\0.\0");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
[ExpectedException(typeof(ArgumentException))]
public void GetTKThrowsArgumentException593()
{
    string s;
    s = this.GetTK("0", "0.\0");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
[ExpectedException(typeof(ArgumentException))]
public void GetTKThrowsArgumentException521()
{
    string s;
    s = this.GetTK(".", "..");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
[ExpectedException(typeof(ArgumentException))]
public void GetTKThrowsArgumentException277()
{
    string s;
    s = this.GetTK("\0", "\0\0.");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
[ExpectedException(typeof(ArgumentException))]
public void GetTKThrowsArgumentException24601()
{
    string s;
    s = this.GetTK("-", "-\0.");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
[ExpectedException(typeof(ArgumentException))]
public void GetTKThrowsArgumentException365()
{
    string s;
    s = this.GetTK("0", "0\0.");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
[ExpectedException(typeof(ArgumentException))]
public void GetTKThrowsArgumentException779()
{
    string s;
    s = this.GetTK("0", "00.");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
public void GetTK714()
{
    string s;
    s = this.GetTK("0", "0.0");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
public void GetTK679()
{
    string s;
    s = this.GetTK("", "0.0");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
public void GetTK656()
{
    string s;
    s = this.GetTK("ࢀ", "0.0");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
public void GetTK766()
{
    string s;
    s = this.GetTK("�", "0.0");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
public void GetTK218()
{
    string s;
    s = this.GetTK("�\0", "0.0");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
public void GetTK70()
{
    string s;
    s = this.GetTK("𐀀", "0.0");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
public void GetTK589()
{
    string s;
    s = this.GetTK("�", "0.0");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
public void GetTK330()
{
    string s;
    s = this.GetTK("�ࢀ", "0.0");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
[ExpectedException(typeof(ArgumentException))]
public void GetTKThrowsArgumentException412()
{
    string s;
    s = this.GetTK("\0", "\0.\0.");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
public void GetTK938()
{
    string s;
    s = this.GetTK("�", "0.0");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
public void GetTK591()
{
    string s;
    s = this.GetTK("��", "0.0");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
public void GetTK126()
{
    string s;
    s = this.GetTK("\00", "0.0");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
public void GetTK575()
{
    string s;
    s = this.GetTK("ࠀࢀ", "0.0");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
public void GetTK249()
{
    string s;
    s = this.GetTK("0", "0.0\0");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
public void GetTK884()
{
    string s;
    s = this.GetTK("0", "0.-0");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
public void GetTK948()
{
    string s;
    s = this.GetTK("��\0", "0.0");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
public void GetTK12()
{
    string s;
    s = this.GetTK("��.", "0.0");
}

[TestMethod]
[PexGeneratedBy(typeof(GoogleTranslateTest))]
public void GetTK442()
{
    string s;
    s = this.GetTK("𐀀𐀀", "0.0");
}
    }
}
