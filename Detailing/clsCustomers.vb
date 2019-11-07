Option Strict On
Option Explicit On
Imports System.IO ' this is required for the IO

Public Class Customer

    'The description of my new data type
    Private strName As String
    Private strAddress As String
    Private strCity As String
    Private strState As String
    Private strZip As String
    Private strPhone As String
    'if good data input the display data
    Private _GoodData As Boolean



    Public Property Name() As String
        Get 'Output the name property
            Return strName
            'Return the actual property value
        End Get
        Set(ByVal value As String)  'Input the name property
            If Not ProperName(value) Or value = "" Then
                ErrorMsg("Name")
                _GoodData = False
                Exit Property
            Else
                strName = FormatName(value)
            End If

        End Set
    End Property

    Public Property Address() As String
        Get 'Output the Address property
            Return strAddress
            'Return the actual Address value
        End Get
        Set(ByVal value As String)  'Input the Address property
            If value = "" OrElse IsNumeric(value) OrElse Alphabetic(value) Then
                ErrorMsg("Address")
                _GoodData = False
                Exit Property
            End If
            strAddress = StrConv(value.Trim, VbStrConv.ProperCase)
        End Set
    End Property

    Public Property City() As String
        Get 'Output the City property
            Return strCity
            'Return the actual City value
        End Get
        Set(ByVal value As String)  'Input the City property
            If Not Alphabetic(value) OrElse value = "" Then
                ErrorMsg("City")
                _GoodData = False
                Exit Property
            End If
            strCity = StrConv(value.Trim, VbStrConv.ProperCase)
        End Set
    End Property

    Public Property State() As String
        Get 'Output the State property
            Return strState
            'Return the actual State value
        End Get
        Set(ByVal value As String)  'Input the State property
            If value.Length <> 2 OrElse Not Alphabetic(value) OrElse value = "" Then
                ErrorMsg("State")
                _GoodData = False
                Exit Property
            End If
            strState = StrConv(value.Trim, VbStrConv.ProperCase)
        End Set
    End Property

    Public Property Zip() As String
        Get 'Output the Zip property
            Return strZip
            'Return the actual Zip value
        End Get
        Set(ByVal value As String)  'Input the Zip property
            If value.Length <> 5 OrElse Not IsNumeric(value) OrElse value = "" Then
                ErrorMsg("Zip")
                _GoodData = False
                Exit Property
            End If
            strZip = StrConv(value.Trim, VbStrConv.ProperCase)
        End Set
    End Property

    Public Property Phone() As String
        Get 'Output the Phone property
            Return strPhone
            'Return the actual Phone value
        End Get
        Set(ByVal value As String)  'Input the Phone property
            If value.Length <> 10 OrElse Not IsNumeric(value) OrElse value = "" Then
                ErrorMsg("Phone")
                _GoodData = False
                Exit Property
            End If
            strPhone = StrConv(value.Trim, VbStrConv.ProperCase)
        End Set
    End Property
    Public ReadOnly Property GoodData As Boolean
        Get
            Return _GoodData
        End Get
    End Property

    Public Sub New()

        _GoodData = True
    End Sub

    Private Function Alphabetic(ByVal strInput As String) As Boolean
        'This function checks each character of the string parameter for one that is not alphabetic.
        'If it finds one, it returns "False". If not, it returns a "True".
        Dim i As Integer

        strInput = strInput.ToUpper

        For i = 0 To strInput.Length - 1

            'If it's blank skip it
            If strInput(i) = " " Then Continue For

            If Not (strInput(i) >= "A" And strInput <= "Z'") Then 'Is it alphabetic?
                Return False  'No, so return "False"
            End If
        Next i
        Return True
    End Function
    'Formats the name to Last, First
    Private Function FormatName(ByVal strName As String) As String
        Dim intBlankPosition As Integer
        Dim intCommaPosition As Integer
        Dim strFirst As String
        Dim strLast As String

        strName = strName.Trim
        intCommaPosition = strName.IndexOf(", ")
        If intCommaPosition >= 0 Then
            Return strName
        End If
        intBlankPosition = strName.IndexOf(" ")
        If intBlankPosition < 0 Then
            Return StrConv(strName, VbStrConv.ProperCase)
        Else
            strFirst = strName.Substring(0, intBlankPosition)
            strLast = strName.Substring(intBlankPosition)
            Return Trim(StrConv(strLast, VbStrConv.ProperCase) & ", " & StrConv(strFirst, VbStrConv.ProperCase))
        End If
    End Function


    Public Function ProperName(ByVal strInput As String) As Boolean
        'Same function as Alphabetic except it also looks for a comma
        Dim i As Integer

        strInput = Trim(strInput.ToUpper)
        If strInput = "" Then Return False

        For i = 0 To strInput.Length - 1
            If strInput(i) = " " OrElse strInput(i) = "," Then Continue For

            If Not (strInput(i) >= "A" And strInput(i) <= "Z") Then
                Return False
            End If
        Next i
        Return True
    End Function


    'This is an error message that is generated when input is not correct
    Public Sub ErrorMsg(strText As String)
        MessageBox.Show("You entered an invalid " & strText, "Input Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class
