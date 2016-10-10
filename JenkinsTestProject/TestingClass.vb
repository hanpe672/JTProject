Imports System
Imports NUnit.Framework

<TestFixture()>
Public Class TestingClass
    <Test()>
    Public Sub IsNull()
        Dim nada As Object = Nothing

        ' Classic syntax
        Assert.IsNull(nada)

        ' Helper syntax
        Assert.That(nada, [Is].Null)
    End Sub

    <Test()>
    Public Sub AdditionTest()
        Dim a, b, c, d As Integer
        a = 1
        b = 2
        d = 3
        c = a + b
        Assert.AreEqual(c, d)
    End Sub

End Class
