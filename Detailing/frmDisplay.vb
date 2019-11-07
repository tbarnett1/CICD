

Public Class frmDisplay
    'declare incustomer as a bookmark for the display
    Public intCustomer As Integer
    Private Sub frmDisplay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Not blnArrayExists Then Exit Sub
        For i As Integer = 0 To Customers.Length - 1
            lstDisplay.Items.Add(Customers(i).Name.PadRight(20) & vbTab & Customers(i).Phone)

        Next i


    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub


    Private Sub frmDisplay_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        lstDisplay.Items.Clear()
    End Sub
    Private Sub btnLoadCustomer_Click(sender As Object, e As EventArgs) Handles btnLoadCustomer.Click

        ' array start from 0 until loop is done
        Dim i As Integer = lstDisplay.SelectedIndex

        'Does the name contain the search string?
        'Display the elements
        frmMain.txtName.Text = Customers(i).Name
        frmMain.txtAddress.Text = Customers(i).Address
        frmMain.txtCity.Text = Customers(i).City
        frmMain.cboState.Text = Customers(i).State
        frmMain.mskZipCode.Text = Customers(i).Zip
        frmMain.mskPhone.Text = Customers(i).Phone
        Exit Sub


    End Sub

    Private Sub lstDisplay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDisplay.SelectedIndexChanged
        'Customer the current selected record in frmMain
        intCustomer = lstDisplay.SelectedIndex
    End Sub

    Public Sub FillList()
        'Loop though the elements I'm using in the Customers array & add each to lstDisplay

        'Make sure I have an array
        If Customers Is Nothing Then Exit Sub

        'Loop though the elements I'm using in the Customers array & add each to lstDisplay
        For i As Integer = 0 To Customers.Length - 1
            If Customers(i).Name = "" Then Continue For
            lstDisplay.Items.Add(Customers(i).Name & ControlChars.Tab & Customers(i).Phone & ControlChars.Tab)

        Next i

    End Sub

End Class