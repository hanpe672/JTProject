Imports System

Public Module Module1

    Sub Main()

        Dim declaredINT1, declaredINT2 As Integer
        declaredINT1 = 20
        declaredINT2 = 20
        declaredINT1 = declaredINT1 + declaredINT2
        For index As Integer = 1 To 5
            Console.WriteLine(index)
        Next
        declaredINT1 = Console.Read()
    End Sub
End Module
