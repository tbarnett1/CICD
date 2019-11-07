Option Explicit On
Option Strict On  'Forces explicit casting
Imports System.IO



Public Class frmMain
    'Program code for Project#1 Dot's Detailing by Brian Johnson, 07/07/2018
    'Updated for Project#2 Dot's Detailing by Brian Johnson, 07/11/2018
    'Updated for Project#3 Dot's Detailing by Brian Johnson, 07/18/2018
    'Updated for Project#4 Dot's Detailing by Brian Johnson, 07/31/2018to 
    'Updated for Project#5 Dot's Detailing by Brian Joohnson, 08/08/2018
    'to change Customers from global to a self contained object, and to include
    'a self contained object for the Calculation for extra credit.


    Dim TempCustomer As Customer
    Public blnArrayChanged As Boolean 'When Customer list changes this will ask yes/no
    Public blnNewCustomer As Boolean  'Declaring new customer to array
    Dim datCustomersIn As StreamReader 'Reads the info
    Dim datCustomersOut As StreamWriter 'Writes the info
    'this is shows where the txt file needs to be saved
    Public strDataFile As String = "..\..\..\Customers.txt"


    'Form load event
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        If File.Exists(strDataFile) Then
            'Yes file does exist
            datCustomersIn = New StreamReader(strDataFile)
            FillArray()  'Populate the listbox
            datCustomersIn.Close()
        End If


        'Displays todays date 
        Text += "  Today's Date: " & DateString
        'Sets the Initial State drop down
        cboState.Text = "WA"
        'Date equal to today or greater than today for scheduling
        dtpDate.Value = Today
    End Sub

    'gives user a dialog box for if they want to close the form and exit
    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        'Ask for clsing Confirmation
        Dim dlgResponse As DialogResult
        If Not blnArrayChanged Then
            'if not, ask user to confirm closing:
            dlgResponse = MessageBox.Show("Are you sure?", "Exiting Program",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dlgResponse = DialogResult.No Then
                e.Cancel = True

            End If
            Exit Sub
        End If
        dlgResponse = MessageBox.Show("Do you wish to save the Customers file?", "Exiting Program",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        'What did user choose?
        Select Case dlgResponse
            Case DialogResult.No
                Exit Sub
            Case Else ' Yes, so call the file save routine
                mnuFileSave.PerformClick() 'Save file
        End Select
    End Sub
    '  *** Button & menu event procedures ***
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim sale = New Calculate


        'Declared variables for calculation

        TempCustomer = New Customer

        'Assign Name:
        TempCustomer.Name = txtName.Text
        If Not TempCustomer.GoodData Then
            txtName.Focus()
            TempCustomer = Nothing
            Exit Sub
        End If

        'Assign Address:
        TempCustomer.Address = txtAddress.Text
        If Not TempCustomer.GoodData Then
            txtAddress.Focus()
            TempCustomer = Nothing
            Exit Sub
        End If

        'Assign City:
        TempCustomer.City = txtCity.Text
        If Not TempCustomer.GoodData Then
            txtCity.Focus()
            TempCustomer = Nothing
            Exit Sub
        End If

        'Assign State:
        TempCustomer.State = cboState.Text
        If Not TempCustomer.GoodData Then
            cboState.Focus()
            TempCustomer = Nothing
            Exit Sub
        End If

        'Assign Zip:
        TempCustomer.Zip = mskZipCode.Text
        If Not TempCustomer.GoodData Then
            mskZipCode.Focus()
            TempCustomer = Nothing
            Exit Sub
        End If

        'Assign Phone:
        TempCustomer.Phone = mskPhone.Text
        If Not TempCustomer.GoodData Then
            mskPhone.Focus()
            TempCustomer = Nothing
            Exit Sub
        End If

        blnArrayChanged = True 'Array has been changed

        'Boolean True/False for Calculate Object
        If radDeluxe.Checked = True Then
            sale.blnDeluxe = True
        Else
            sale.blnDeluxe = False

        End If

        If chkCarpets.Checked Then
            sale.blnCarpets = True
        End If

        If chkFluids.Checked Then
            sale.blnFluids = True
        End If


        If blnNewCustomer Then

        End If
        If MsgBox("Do you want Save the Customers Information to the array?", MsgBoxStyle.YesNo, "Save?") = MsgBoxResult.Yes Then

        Else
            MessageBox.Show("The Customer is already in the array.", "No duplicates.")
            txtName.Focus()
            Exit Sub
        End If

        SaveCustomerRecord()
        blnNewCustomer = False



        'SubTotal, Tax, and GrandTotal output labels
        lblTotalSale.Text = sale.SubTotal.ToString("c")
        lblSalesTax.Text = sale.Tax.ToString("c")
        lblGrandTotal.Text = sale.Total.ToString("c")




        ''Display the correct input values:
        'MessageBox.Show("You entered the following:" & ControlChars.NewLine &
        '                txtName.Text & ControlChars.NewLine &
        '                txtAddress.Text & ControlChars.NewLine &
        '                txtCity.Text & "," & cboState.Text & "," & mskZipCode.Text & "" & ControlChars.NewLine &
        '                String.Format("{0:(###) ###-####}", Long.Parse(mskPhone.Text)) & ControlChars.NewLine &
        '                ControlChars.NewLine & ("Total Sale: ") & ControlChars.NewLine & lblGrandTotal.Text, "Order Information")

    End Sub


    'Checks all checkboxes if Deluxe checked
    Private Sub radDeluxe_CheckedChanged(sender As Object, e As EventArgs) Handles radDeluxe.CheckedChanged
        chkPasteWax.Checked = radDeluxe.Checked
        chkFluids.Checked = radDeluxe.Checked
        chkUpholstery.Checked = radDeluxe.Checked
        chkCarpets.Checked = radDeluxe.Checked
        chkTireDressing.Checked = radDeluxe.Checked
        chkWhiteWalls.Checked = radDeluxe.Checked
        'Sets the enable Property if Deluxe not checked
        chkPasteWax.Enabled = Not radDeluxe.Checked
        chkFluids.Enabled = Not radDeluxe.Checked
        chkUpholstery.Enabled = Not radDeluxe.Checked
        chkCarpets.Enabled = Not radDeluxe.Checked
        chkTireDressing.Enabled = Not radDeluxe.Checked
        chkWhiteWalls.Enabled = Not radDeluxe.Checked

    End Sub
    'Clears all applicable info and Starts at Name TextBox
    Public Sub btnClearAll_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnClearAll.Click, mnuClearAll.Click

        If MessageBox.Show("Do you want to clear the whole form?", "Clear Form", MessageBoxButtons.YesNo) _
            = DialogResult.Yes Then


            mnuClearOrder.PerformClick()

            txtName.Clear()
            txtAddress.Clear()
            txtCity.Clear()
            cboState.Text = "WA"
            mskZipCode.Clear()
            mskPhone.Clear()

            txtName.Focus()
        End If
    End Sub
    'Clears all applicable Order info and Starts at Basic Service Button
    Private Sub btnClearOrder_Click(sender As Object, e As EventArgs) Handles btnClearOrder.Click, mnuClearOrder.Click
        'Message if you want to clear order yes/no
        If MessageBox.Show("Do you want to clear the order?", "Clear Form", MessageBoxButtons.YesNo) _
            = DialogResult.Yes Then
            'Clears Cost, SalesTax, and Total
            radBasic.Checked = True
            radDeluxe.PerformClick()
            lblTotalSale.Text = ""
            lblSalesTax.Text = ""
            lblGrandTotal.Text = ""

            dtpDate.Value = Today
            radBasic.Focus() 'puts focus on Service

        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click, mnuFileExit.Click
        'Exits the program
        Me.Close()
    End Sub

    'Saves the File
    Public Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        If Not blnArrayExists Then Exit Sub
        datCustomersOut = New StreamWriter(strDataFile)  'Open file w/ overwrite ability
        SaveArray()  'Call the subroutine that saves the list items to the file
        datCustomersOut.Close()  'Close the file
        blnArrayChanged = False 'if Save has been choose then ok box shows where it was saved
        MessageBox.Show(Strings.Right(strDataFile, 13) & " Saved")

    End Sub


    'brings up the about form when mnuHelpAbout is clicked
    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        frmAbout.ShowDialog()
    End Sub
    Private Sub mnuViewDisplayCustomers_Click(sender As Object, e As EventArgs) Handles mnuViewDisplayCustomers.Click
        'Displays the Array in the frmDisplay 
        frmDisplay.ShowDialog()
    End Sub

    'Select all text:
    Private Sub txtBoxes_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtAddress.Enter, txtName.Enter, txtCity.Enter
        Dim txtBox As TextBox
        txtBox = CType(sender, TextBox)
        txtBox.SelectAll()
    End Sub

    'Select all Masked text boxes:
    Private Sub mskBoxes_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskZipCode.Enter, mskPhone.Enter
        Dim mskBox As MaskedTextBox
        mskBox = CType(sender, MaskedTextBox)
        mskBox.SelectAll()
    End Sub
    'Keypress event to allow only Alphabetic characters and a space for City
    Private Sub Alphabetic_Characters(sender As Object, e As KeyPressEventArgs) Handles txtCity.KeyPress
        Dim stracceptableChars As String = "abcdefghijklmnopqrstuvwxyz "
        If Not (stracceptableChars.Contains(e.KeyChar.ToString.ToLower) OrElse e.KeyChar = Chr(Keys.Back)) Then
            e.KeyChar = Nothing
            e.Handled = True
        End If
    End Sub
    'Keypress event to allow only Alphabetic characters, a comma and a space for Name
    Private Sub AlphaComma_Characters(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        Dim stracceptableChars As String = "abcdefghijklmnopqrstuvwxyz ,"
        If Not (stracceptableChars.Contains(e.KeyChar.ToString.ToLower) OrElse e.KeyChar = Chr(Keys.Back)) Then
            e.KeyChar = Nothing
            e.Handled = True
        End If
    End Sub
    'Keypress event to allow only Alphabetic characters,a space, and Numbers for Address
    Private Sub AlphaNumeric_Characters(sender As Object, e As KeyPressEventArgs) Handles txtAddress.KeyPress
        Dim stracceptableChars As String = "abcdefghijklmnopqrstuvwxyz 1234567890"
        If Not (stracceptableChars.Contains(e.KeyChar.ToString.ToLower) OrElse e.KeyChar = Chr(Keys.Back)) Then
            e.KeyChar = Nothing
            e.Handled = True
        End If
    End Sub

    'sub for what happens when you leave the txtName field
    Private Sub txtName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtName.Leave
        Dim index As Integer
        index = SearchArray(txtName.Text) 'Searches the array for name
        If index > -1 Then
            DisplayFields(index) 'display the name if found
            radBasic.Focus()
            blnNewCustomer = False
        Else
            blnNewCustomer = True
        End If

    End Sub


    Private Sub DisplayFields(ByVal i As Integer)
        'If Customers Is Nothing Then Exit Sub
        txtName.Text = Customers(i).Name
        txtAddress.Text = Customers(i).Address
        txtCity.Text = Customers(i).City
        cboState.Text = Customers(i).State
        mskZipCode.Text = Customers(i).Zip
        mskPhone.Text = Customers(i).Phone
    End Sub

    Private Function GetIndex() As Integer
        'Do I have an array?
        If blnArrayExists Then

            ReDim Preserve Customers(Customers.Length) 'Yes, so increase by one

        Else

            ReDim Customers(0) 'No, so allocate the first element
            blnArrayExists = True
        End If
        Return UBound(Customers)
    End Function
    'Saves the customer record
    Private Sub SaveCustomerRecord()
        Dim i As Integer
        i = GetIndex()

        SaveFields(i)
        DisplayFields(i)
    End Sub

    Private Sub SaveFields(ByVal i As Integer)

        Customers(i) = New Customer
        Customers(i) = TempCustomer
        TempCustomer = Nothing

        txtName.AutoCompleteCustomSource.Add(Customers(i).Name)
        blnArrayChanged = True
    End Sub

    Private Function SearchArray(strName As String) As Integer
        If Not blnArrayExists OrElse strName = "" Then Return -1

        For i As Integer = 0 To Customers.Length - 1
            If Customers(i).Name.ToUpper.StartsWith(strName.ToUpper) Then
                Return i
            End If
        Next i
        Return -1

    End Function

    Private Sub FillArray()
        'Populate the array from the input file

        Dim i As Integer

        Do Until (datCustomersIn.Peek = -1)   'End Of File?

            'Get the next higher subscript: 
            i = GetIndex()
            Customers(i) = New Customer
            'Assign the values

            Customers(i).Name = datCustomersIn.ReadLine
            Customers(i).Address = datCustomersIn.ReadLine
            Customers(i).City = datCustomersIn.ReadLine
            Customers(i).State = datCustomersIn.ReadLine
            Customers(i).Zip = datCustomersIn.ReadLine
            Customers(i).Phone = datCustomersIn.ReadLine
            txtName.AutoCompleteCustomSource.Add(Customers(i).Name) ' auto completes 

        Loop
    End Sub

    Private Sub SaveArray()

        For i As Integer = 0 To Customers.Length - 1
            'Write a line to the file 
            'if mark to delete then skip it
            datCustomersOut.WriteLine(Customers(i).Name)
            datCustomersOut.WriteLine(Customers(i).Address)
            datCustomersOut.WriteLine(Customers(i).City)
            datCustomersOut.WriteLine(Customers(i).State)
            datCustomersOut.WriteLine(Customers(i).Zip)
            datCustomersOut.WriteLine(Customers(i).Phone)
        Next

    End Sub


    'Calander date picker for selecting the date service will be done
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        dtpDate.MinDate = Now.Date
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) 

    End Sub
End Class


