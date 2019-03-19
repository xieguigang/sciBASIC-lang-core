﻿Namespace Language

    Public Class UnionType(Of A, B) : Inherits Value(Of Object)

        Public Overrides Function GetUnderlyingType() As Type
            If Value Is Nothing Then
                Return GetType(Void)
            Else
                Return Value.GetType
            End If
        End Function

        Public ReadOnly Property VA As A
            Get
                Return Value
            End Get
        End Property

        Public ReadOnly Property VB As B
            Get
                Return Value
            End Get
        End Property

        Public Overloads Shared Narrowing Operator CType(obj As UnionType(Of A, B)) As A
            Return obj.VA
        End Operator

        Public Overloads Shared Narrowing Operator CType(obj As UnionType(Of A, B)) As B
            Return obj.VB
        End Operator

        Public Overloads Shared Widening Operator CType(a As A) As UnionType(Of A, B)
            Return New UnionType(Of A, B) With {.Value = a}
        End Operator

        Public Overloads Shared Widening Operator CType(b As B) As UnionType(Of A, B)
            Return New UnionType(Of A, B) With {.Value = b}
        End Operator
    End Class

    Public Class UnionType(Of A, B, C) : Inherits UnionType(Of A, B)

        Public ReadOnly Property VC As C
            Get
                Return Value
            End Get
        End Property

        Public Overloads Shared Narrowing Operator CType(obj As UnionType(Of A, B, C)) As C
            Return obj.VC
        End Operator

        Public Overloads Shared Widening Operator CType(c As C) As UnionType(Of A, B, C)
            Return New UnionType(Of A, B) With {.Value = c}
        End Operator
    End Class
End Namespace