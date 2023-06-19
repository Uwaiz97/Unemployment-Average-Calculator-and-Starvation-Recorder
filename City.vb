Option Strict On
Option Explicit On
Option Infer Off
<Serializable> Public Class City
    Inherits Counsel

    Private _CityName As String

    Public Property Name As String
        Get
            Return _CityName
        End Get
        Set(value As String)
            _CityName = value
        End Set
    End Property

    Public Overrides Function CDisplay() As String
        Dim Msg As String
        Msg = "City Name: " & _CityName & Environment.NewLine &
            MyBase.CDisplay & Environment.NewLine
        Return Msg
    End Function
End Class
