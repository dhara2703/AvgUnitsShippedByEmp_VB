Option Strict On

Public Class frmAvgUnitsShippedByEmp
    ''' 
    ''' Name:           Lab3AvgUnitShippedByEmp.vb
    ''' Student Name:   Dhara Savaliya
    ''' Student ID:     100648840
    ''' Date:           05-March-2018
    ''' Description:    This project calculates average of the units which are entered per week for three employees and lastly it shows overall average. 
    '''                 Based on the given input it verifies the user input for validating rules and stores the valid input in 2D array. 

    Dim empUserInput(6, 2) As Integer ' this is 2D array of 7 (0-6)rows and 3(0-2) columns  integers dayatypes to store units for 3 eloyees for 7 days. 
    Dim daysCounter As Integer
    Dim loopCounterForColumns As Integer
    Dim loopCounterForRows As Integer
    Dim totalInputValues As Integer

    'Dim totalUnits As Integer ' this will store the total of all units per week
    'Dim daysCounter As Integer ' this counter is used to count days to receive values from user 
    'Dim averageUnits As Double ' this will store the average units per day 

    Private Sub frmAvgUnitsShippedByEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeAll()
    End Sub

    Private Function InputValidation(userInput As String) As Integer
        Dim userInputDouble As Double = 0.00 ' used for validate the user input for double data type
        Dim userInputInteger As Integer = 0 ' used for validate the user input for integer data type
        If (Integer.TryParse(userInput, userInputInteger)) Then
            If userInputInteger >= 0 And userInputInteger <= 1000 Then
                Return userInputInteger
            Else
                MessageBox.Show("Please Ensure The Shipped Units Are Between 0 and 1000!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                txtUnitsPerDay.SelectionStart = 0
                txtUnitsPerDay.SelectionLength = txtUnitsPerDay.Text.Length
                userInputInteger = -1
            End If
        ElseIf (Double.TryParse(userInput, userInputDouble)) Then
            MessageBox.Show("Please Ensure The Unit Shipped Are Whole Numbers!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtUnitsPerDay.SelectionStart = 0
            txtUnitsPerDay.SelectionLength = txtUnitsPerDay.Text.Length
            userInputInteger = -1
        ElseIf userInput = "" Then
            MessageBox.Show("Please Ensure To Enter The Value For Unit Numbers!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUnitsPerDay.SelectionStart = 0
            txtUnitsPerDay.SelectionLength = txtUnitsPerDay.Text.Length
            userInputInteger = -1
        Else
            MessageBox.Show("Please Ensure To Enter Numbers Only For Shippend Units!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUnitsPerDay.SelectionStart = 0
            txtUnitsPerDay.SelectionLength = txtUnitsPerDay.Text.Length
            userInputInteger = -1
        End If
        Return userInputInteger
    End Function

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim userTextInput As String = String.Empty ' used to store the values entered by user as string
        userTextInput = Trim(txtUnitsPerDay.Text)
        Dim validUserInput As Integer = InputValidation(userTextInput)
        If validUserInput <> -1 Then
            empUserInput(loopCounterForRows, loopCounterForColumns) = validUserInput
            DisplayUnitsInTextbox(loopCounterForColumns, empUserInput(loopCounterForRows, loopCounterForColumns))
            totalInputValues = totalInputValues + 1
            If totalInputValues < 21 Then
                If loopCounterForRows < 6 Then
                    loopCounterForRows = loopCounterForRows + 1
                ElseIf loopCounterForRows = 6 Then
                    loopCounterForRows = 0
                    CalculateAverage(loopCounterForColumns)
                    If loopCounterForColumns < 2 Then loopCounterForColumns = loopCounterForColumns + 1
                End If
            Else
                txtUnitsPerDay.Text = ""
                txtUnitsPerDay.ReadOnly() = True
                btnReset.Focus()
                btnEnter.Enabled = False
                lblDaysCounter.Text = "Done!"
                CalculateAverage(loopCounterForColumns)
            End If
        End If
    End Sub
    Private Sub DisableFormComponents()
        txtUnitsPerDay.Text = ""
        txtUnitsPerDay.ReadOnly() = True
        btnEnter.Enabled = False
        btnReset.Focus()
    End Sub

    Private Sub CalculateAverage(columnDisplay As Integer)
        Dim TotalCols(2) As Double
        Dim totalDays As Integer = 7
        Dim columnAverage(2) As Double
        Dim overallAverage As Double = 0.00
        TotalCols = {0.00, 0.00, 0.00}
        columnAverage = {0.00, 0.00, 0.00}

        For columns As Integer = 0 To 2
            For rows As Integer = 0 To totalDays - 1
                TotalCols(columns) = TotalCols(columns) + empUserInput(rows, columns)
            Next
            columnAverage(columns) = TotalCols(columns) / totalDays
            overallAverage += columnAverage(columns)
        Next

        Select Case columnDisplay
            Case 0 : lblAvgEmp1.Text = Format(columnAverage(columnDisplay), "#.##").ToString
            Case 1 : lblAvgEmp2.Text = Format(columnAverage(columnDisplay), "#.##").ToString
            Case 2
                lblAvgEmp3.Text = Format(columnAverage(columnDisplay), "#.##").ToString
                lblOverallResult.Text = Format(overallAverage / 3, "#.##").ToString

        End Select
    End Sub

    Private Function TotalAndAverageCalculate(empUserInputFuntion() As Integer, columnColunter As Integer) As Double
        Dim totalCounter As Integer
        Dim totalDays As Integer = 7
        Dim totalDaysForAllEmp As Integer = 21
        Dim totalForFirstEmp As Integer = 0
        Dim totalForSecondEmp As Integer = 0
        Dim totalForThirdEmp As Integer = 0
        Dim totalForOverallAvg As Integer = 0
        Dim averageCalulator As Double = 0.00
        If loopCounterForColumns = 0 Then
            For totalCounter = 0 To 6
                totalForFirstEmp += empUserInput(totalCounter, 0)
            Next totalCounter
            averageCalulator = totalForFirstEmp / totalDays
            lblAvgEmp1.Text = Convert.ToString(averageCalulator)
        ElseIf loopCounterForColumns = 1 Then
            For totalCounter = 0 To 6
                totalForSecondEmp += empUserInput(totalCounter, 0)
            Next totalCounter
            averageCalulator = totalForFirstEmp / totalDays
            lblAvgEmp2.Text = Convert.ToString(averageCalulator)
        Else
            For totalCounter = 0 To 6
                totalForSecondEmp += empUserInput(totalCounter, 0)
            Next totalCounter
            averageCalulator = totalForFirstEmp / totalDays
            lblAvgEmp3.Text = Convert.ToString(averageCalulator)
            averageCalulator = totalForFirstEmp / totalDaysForAllEmp
            lblOverallResult.Text = Convert.ToString(averageCalulator)
        End If
        Return averageCalulator
    End Function
    Private Sub DisplayUnitsInTextbox(ByRef columnCounter As Integer, parsedInput As Integer)
        If columnCounter = 0 Then
            lblEmployee1.Font = New Font(lblEmployee1.Font, FontStyle.Bold)
            txtEmp1WeeklyUnits.Text += Convert.ToString(parsedInput) + vbCrLf
            txtUnitsPerDay.Text = ""
            txtUnitsPerDay.Focus()
        ElseIf columnCounter = 1 Then
            lblEmployee1.Font = New Font(lblEmployee1.Font, FontStyle.Regular)
            lblEmployee2.Font = New Font(lblEmployee2.Font, FontStyle.Bold)
            txtEmp2WeeklyUnits.Text += Convert.ToString(parsedInput) + vbCrLf
            txtUnitsPerDay.Text = ""
            txtUnitsPerDay.Focus()
        Else
            lblEmployee2.Font = New Font(lblEmployee2.Font, FontStyle.Regular)
            lblEmployee3.Font = New Font(lblEmployee3.Font, FontStyle.Bold)
            txtEmp3WeeklyUnits.Text += Convert.ToString(parsedInput) + vbCrLf
            txtUnitsPerDay.Text = ""
            txtUnitsPerDay.Focus()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' this will close the form 
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        InitializeAll() ' calling a funtion to itialize all default values
    End Sub

    Private Sub InitializeAll()
        'This function is used to initalizing all values to its default one to let user to reenter the units 
        'For that we require to clean their memory with old stored values
        'Moreover, it also focuses on labels and textboxs to take care

        txtUnitsPerDay.Text = ""
        txtUnitsPerDay.Focus()
        txtUnitsPerDay.ReadOnly() = False
        btnEnter.Enabled() = True
        txtEmp1WeeklyUnits.Text = ""
        txtEmp2WeeklyUnits.Text = ""
        txtEmp3WeeklyUnits.Text = ""
        lblDaysCounter.Text = ""
        lblAvgEmp1.Text = ""
        lblAvgEmp2.Text = ""
        lblAvgEmp3.Text = ""
        lblOverallResult.Text = ""
        totalInputValues = 0
        loopCounterForRows = 0
        loopCounterForColumns = 0
        daysCounter = 1
        'Clearing buffer values for variables
        'daysCounter = 1
        'totalUnits = 0
        'averageUnits = 0.00

    End Sub

    Private Sub txtUnitsPerDay_TextChanged(sender As Object, e As EventArgs) Handles txtUnitsPerDay.TextChanged

        If daysCounter >= 8 And loopCounterForColumns >= 3 Then
            btnEnter.Enabled() = False
            lblDaysCounter.Text = "Done!"
        Else
            lblDaysCounter.Text = "Days: " & loopCounterForRows + 1
        End If
    End Sub
End Class
