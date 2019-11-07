Imports Detailing
Public Class Calculate
    'Variables for Calculate Function
    Dim saleamount As Decimal
    Dim taxamount As Decimal
    Dim totalamount As Decimal

    Const BasicCost As Decimal = 79.99D      'To Declare Basic Service cost as a Constant
    Const DeluxeCost As Decimal = 129.99D    'To Declare Deluxe Service cost as a Constant
    Const SalesTax As Decimal = 0.088D      'To Declare Sales Tax as a Constant

    'Project #2 declared values for Extras
    Const Carpets As Decimal = 19.99D
    Const Upholstery As Decimal = 24.99D
    Const Tire_Dressing As Decimal = 7.99D
    Const WhiteWalls As Decimal = 8.99D
    Const Paste_Wax As Decimal = 14.99D
    Const Fluids As Decimal = 10.99D


    Dim decSubTotal As Decimal
    ' Public _GoodData As Boolean
    'Basic extras declared as boolean
    Public blnCarpets As Boolean
    Public blnUpholstery As Boolean
    Public blnTireDressing As Boolean
    Public blnWhiteWalls As Boolean
    Public blnPasteWax As Boolean
    Public blnFluids As Boolean
    Public blnDeluxe As Boolean
    Private Shared strSubTotal As Decimal
    'SubTotal Object
    Public ReadOnly Property SubTotal() As Decimal
        Get 'Output the SubTotal
            If blnDeluxe = True Then
                decSubTotal = DeluxeCost
            Else
                decSubTotal = (AdjustedPrice(decSubTotal))
            End If

            Return decSubTotal
        End Get
    End Property

    'Tax Object
    Public ReadOnly Property Tax() As Decimal
        Get 'Output the Tax property
            taxamount = (SalesTax * decSubTotal)

            Return taxamount
            'Return the actual Tax value
        End Get

    End Property


    Public ReadOnly Property Total() As Decimal
        Get 'Output the Total property

            totalamount = (taxamount + decSubTotal)

            Return totalamount
            'Return the actual Total value
        End Get

    End Property

    Public Function AdjustedPrice(decSubTotal As Decimal) As Decimal
        'Adjusts the Subtotal amount
        If blnCarpets = True Then
            decSubTotal += Carpets
        End If
        If blnUpholstery = True Then
            decSubTotal += Upholstery
        End If
        If blnTireDressing = True Then
            decSubTotal += Tire_Dressing
        End If
        If blnWhiteWalls = True Then
            decSubTotal += WhiteWalls
        End If
        If blnPasteWax = True Then
            decSubTotal += Paste_Wax
        End If
        If blnFluids = True Then
            decSubTotal += Fluids
        End If
        Return decSubTotal
    End Function

    Function CalcTax(ByVal decSubTotal As Decimal) As Decimal
        ' This function gets the decSubTotal and multiplies 
        'it by the decTax for the current Sales Tax

        Return decSubTotal * SalesTax

    End Function
End Class
