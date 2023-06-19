Option Strict On
Option Explicit On
Option Infer Off
<Serializable> Public Class Country

    Private _CountryName As String
    Private _Population As Integer
    Private _HungerLevel As Integer
    Private _City() As City
    Private _nCities As Integer
    Private _Least As Integer

    Public Sub New(CountryName As String, Population As Integer, nCities As Integer)
        _CountryName = CountryName
        _Population = ValidInt(Population)
        _nCities = nCities
        ReDim _City(_nCities)
    End Sub

    Public Property Name As String
        Get
            Return _CountryName
        End Get
        Set(value As String)
            _CountryName = value
        End Set
    End Property
    Public Property Population As Integer
        Get
            Return _Population
        End Get
        Set(value As Integer)
            _Population = ValidInt(value)
        End Set
    End Property
    Public Property NumCities As Integer
        Get
            Return _nCities
        End Get
        Set(value As Integer)
            _nCities = ValidInt(value)
        End Set
    End Property
    Public Property City(index As Integer) As City
        Get
            Return _City(index)
        End Get
        Set(value As City)
            _City(index) = value
        End Set
    End Property

    Public Property HungerLevel As Integer
        Get
            Return _HungerLevel
        End Get
        Set(value As Integer)
            _HungerLevel = ValidInt(value)
        End Set
    End Property

    Public Property Least As Integer
        Get
            Return _Least
        End Get
        Set(value As Integer)
            _Least = value
        End Set
    End Property
    Private Function ValidInt(value As Integer) As Integer
        If value < 0 Then
            Return 0
        Else
            Return value
        End If
    End Function

    Private Function Hunger() As String
        Dim Level As String = ""
        If HungerLevel = 1 Then
            Level = "Partial Starvation"
        End If
        If HungerLevel = 2 Then
            Level = "Severe Starvation"
        End If
        If HungerLevel = 3 Then
            Level = "Extreme Starvation"
        End If
        Return Level
    End Function

    Public Function FindLowest() As Integer
        'Use of Minimum calculation..
        Dim min As Double = 0
        _Least = 1
        min = City(1).Unemployed
        For t As Integer = 1 To NumCities
            If City(t).Unemployed() < min Then
                min = City(t).Unemployed()
                _Least = t
            End If
        Next t
        Return _Least
    End Function


    Public Function Display() As String
        Dim dis As String = " "

        dis &= "Country Name: " & _CountryName & " / Population: " & _Population & " / Number of Cities : " & _nCities & " / Level Of Starvation: " & Hunger() & Environment.NewLine
        For a As Integer = 1 To _nCities
            dis &= City(a).CDisplay()
        Next a
        dis &= "Area with Least Unemployment : " & FindLowest() & Environment.NewLine

        Return dis
    End Function

End Class
