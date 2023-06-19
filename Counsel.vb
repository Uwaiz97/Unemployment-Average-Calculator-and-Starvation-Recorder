Option Strict On
Option Explicit On
Option Infer Off
<Serializable> Public MustInherit Class Counsel

    Private _nUnemployed As Integer
    Private _Lowest As Integer


    Public Property Unemployed As Integer
        Get
            Return _nUnemployed
        End Get
        Set(value As Integer)
            _nUnemployed = ValidInt(value)
        End Set
    End Property
    Public Property Lowest As Integer
        Get
            Return _Lowest
        End Get
        Set(value As Integer)
            _Lowest = ValidInt(value)
        End Set
    End Property
    Private Function ValidInt(value As Integer) As Integer
        If value < 0 Then
            Return 0
        Else
            Return value
        End If
    End Function

    Public Function CalcTotol() As Integer
        Dim Total As Integer = 0

        Total += Unemployed

        Return Total
    End Function

    Public Overridable Function CDisplay() As String
        Return "No: Of People Unemployed: " & CalcTotol()
    End Function

End Class
