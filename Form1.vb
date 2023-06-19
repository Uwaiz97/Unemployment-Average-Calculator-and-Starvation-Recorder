Option Strict On
Option Explicit On
Option Infer Off

Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class frmUNDP
    Enum HungerLevel
        PartialStarvation = 1
        Severe = 2
        Extreme = 3
    End Enum

    Private nCountries As Integer
    Private Country() As Country

    Private FS As FileStream
    Private Filename As String = "GroupProject.ipb"
    Private BF As BinaryFormatter

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        nCountries = CInt(InputBox("How many Countries are you recording for ?", "United Nations Development Programme"))

        While nCountries < 0
            MessageBox.Show("Number Entered is Invalid! , Please enter a valid number", "United Nations Development Programme")
            nCountries = CInt(InputBox("How many Provinces are you recording for ?", "United Nations Development Programme"))
        End While

        ReDim Country(nCountries)
        For p As Integer = 1 To nCountries
            Dim countryName As String = InputBox("What is the name of Country " & CStr(p), "United Nations Development Programme")
            Dim CountryPop As Integer = CInt(InputBox("Enter the Population size of Country " & CStr(p), "United Nations Development Programme"))
            Dim nCities As Integer = CInt(InputBox("How many Cities are there in Country " & CStr(p) & "?", "United Nations Development Programme"))

            Country(p) = New Country(countryName, CountryPop, nCities)

            Country(p).Name = countryName
            Country(p).Population = CountryPop
            Country(p).NumCities = nCities

            For m As Integer = 1 To nCities
                Country(p).City(m) = New City
                Country(p).City(m).Name = InputBox("Please Enter the name of City " & CStr(m) & " in Country " & CStr(p), "United Nations Development Programme")
                Country(p).City(m).Unemployed = CInt(InputBox("How many people are Unemployed in City " & CStr(m) & " in Country " & CStr(p), "United Nations Development Programme"))

            Next m
            Dim Level As Integer = CInt(InputBox("Please Enter the Level of Hunger in Country " & CStr(p) & Environment.NewLine & "Press 1 for Partial Starvation" & Environment.NewLine & "Press 2 for Severe Starvation" & Environment.NewLine & "Press 3 for Extreme Starvation", "United Nations Development Programme"))
                If Level = 1 Then
                    Country(p).HungerLevel = HungerLevel.PartialStarvation
                End If
                If Level = 2 Then
                    Country(p).HungerLevel = HungerLevel.Severe
                End If
                If Level = 3 Then
                    Country(p).HungerLevel = HungerLevel.Extreme
                End If

                txtDisplay.Text &= Country(p).Display & Environment.NewLine
        Next p
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        FS = New FileStream(Filename, FileMode.Create, FileAccess.ReadWrite)
        FS.Close()
        FS = Nothing
        BF = Nothing
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        FS = New FileStream(Filename, FileMode.Open, FileAccess.Write)
        BF = New BinaryFormatter()
        Dim index As Integer
        For p As Integer = 1 To nCountries
            index = Country(p).FindLowest
            Dim Lowest As City
            Lowest = Country(p).City(index)
            BF.Serialize(FS, Lowest)
        Next p

        FS.Close()
        FS = Nothing
        BF = Nothing
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Dim count As Integer = 1
        FS = New FileStream(Filename, FileMode.Open, FileAccess.Read)
        BF = New BinaryFormatter()
        Dim city As City
        While FS.Position < FS.Length
            Dim t As Object
            t = BF.Deserialize(FS)
            city = DirectCast(t, City)
            count += 1
        End While
        ' Average Calculation..
        Dim total As Double = 0
        For d As Integer = 1 To nCountries
            For c As Integer = 1 To country(d).NumCities
                total += country(d).City(c).Unemployed
            Next

            Dim Average As Double = total / country(d).NumCities

            txtAve.Text &= " For country" & CStr(d) & " :" & Format(Average, "0,00") & Environment.NewLine

        Next d
        FS.Close()
        FS = Nothing
        BF = Nothing
    End Sub

End Class
