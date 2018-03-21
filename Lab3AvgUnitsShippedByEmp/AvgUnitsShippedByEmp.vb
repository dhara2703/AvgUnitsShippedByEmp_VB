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
    Dim daysCounter As Integer 'Used as a counter and displayed as days
    Dim loopCounterForColumns As Integer 'This is used to access the columns in 2d Array
    Dim loopCounterForRows As Integer 'This is used to access the rows in 2d Array
    Dim totalInputValues As Integer 'This is used to count total for all employee's individual unit input and overall units to find average

    Private Sub frmAvgUnitsShippedByEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeAll() 'calling a function to intialize set form properties and variables 
    End Sub

    Private Function InputValidation(userInput As String) As Integer
        'This funcion is used to check valid user input, else user gets an error message showing to fix the error
        Dim userInputDouble As Double = 0.00 ' used for validate the user input for double data type
        Dim userInputInteger As Integer = 0 ' used for validate the user input for integer data type
        Dim userInputIntegerCheck As Integer = 0 ' used for validate the user input for integer data type
        If (Integer.TryParse(userInput, userInputIntegerCheck)) Then 'try to parse the userinput in integer
            If userInputIntegerCheck >= 0 And userInputIntegerCheck <= 1000 Then ' if it is integer then it will check the range
                userInputInteger = userInputIntegerCheck ' if yes than store it in userInputInteger
            Else
                'Message displays that not in range more than 1000 and less than 0
                MessageBox.Show("Please Ensure The Shipped Units Are Between 0 and 1000!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                'Selects the user input to make it more flexible for enter new values 
                txtUnitsPerDay.SelectionStart = 0
                txtUnitsPerDay.SelectionLength = txtUnitsPerDay.Text.Length
                userInputInteger = -1 'return with -1 to repeat the user input process again
            End If
        ElseIf (Double.TryParse(userInput, userInputDouble)) Then 'try to parse the userinput in double
            'Message display that not a whole number
            MessageBox.Show("Please Ensure The Unit Shipped Are Whole Numbers!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            'Selects the user input to make it more flexible for enter new values
            txtUnitsPerDay.SelectionStart = 0
            txtUnitsPerDay.SelectionLength = txtUnitsPerDay.Text.Length
            userInputInteger = -1 'return with -1 to repeat the user input process again
        ElseIf userInput = "" Then
            'Message display that no input is given
            MessageBox.Show("Please Ensure To Enter The Value For Unit Numbers!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Selects the user input to make it more flexible for enter new values
            txtUnitsPerDay.SelectionStart = 0
            txtUnitsPerDay.SelectionLength = txtUnitsPerDay.Text.Length
            userInputInteger = -1 'return with -1 to repeat the user input process again
        Else
            'Message display that number input is not given, character is entered as an input
            MessageBox.Show("Please Ensure To Enter Numbers Only For Shipped Units!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Selects the user input to make it more flexible for enter new values
            txtUnitsPerDay.SelectionStart = 0
            txtUnitsPerDay.SelectionLength = txtUnitsPerDay.Text.Length
            userInputInteger = -1 'return with -1 to repeat the user input process again
        End If
        'returns the userinput based on the entered value. if is is between 0 to 1000 it will send the number else it will send -1
        Return userInputInteger
    End Function

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim userTextInput As String = String.Empty ' used to store the values entered by user as string
        userTextInput = Trim(txtUnitsPerDay.Text) 'Trims the extra space in input
        Dim validUserInput As Integer = InputValidation(userTextInput) 'Holds a return value which is get by calling  a function 

        'if it is -1 which means need to ask user to allow user to enter value again else store it in an array
        'If is is valid input then it will enter in if statement
        If validUserInput <> -1 Then
            empUserInput(loopCounterForRows, loopCounterForColumns) = validUserInput 'assigning the value to the array
            'dispalying the units in the multiline textbox one by one as it gets 
            DisplayUnitsInTextbox(loopCounterForColumns, empUserInput(loopCounterForRows, loopCounterForColumns))
            totalInputValues += 1 'It calulates the occurance of assigning values to array

            ' if totalInputValues is 21 which means need to end for entering user input values
            If totalInputValues < 21 Then

                'if rows are less than 6 then it will continue
                If loopCounterForRows < 6 Then
                    loopCounterForRows += 1 'add 1 row in array
                ElseIf loopCounterForRows = 6 Then 'if total rows are 6 then it will stop adding rows and assign them to 0 
                    loopCounterForRows = 0 ' assisgning to 0
                    CalculateAverage(loopCounterForColumns) 'calling a function to calculate the average

                    'if columns are less than 2 then ad 1 to them to change the next employee 
                    If loopCounterForColumns < 2 Then 'checks taht it is less than 2
                        loopCounterForColumns = loopCounterForColumns + 1 'adds the columns for the next employee
                    End If
                End If
            Else
                'if data entry for all employee's 7 days is finished and displayed then it will set this things
                txtUnitsPerDay.Text = "" 'set text box to empty
                txtUnitsPerDay.ReadOnly() = True 'set to read only so user can not update it
                btnReset.Focus() 'set focus on reset button
                btnEnter.Enabled = False 'disable the enter button so user can not use it until he clicks on reset button
                lblDaysCounter.Text = "Done!" 'This mean for all days and all employee valid user input is given and calulated
                CalculateAverage(loopCounterForColumns) 'calling a function to calculate the average
                lblEmployee3.Font = New Font(lblEmployee3.Font, FontStyle.Regular) 'Set regular font on label to finish the overall calculation

            End If
        End If
    End Sub

    Private Sub CalculateAverage(columnDisplay As Integer)
        'This function is used to find the sum and based on it to calculate the average
        Dim totalColumns(2) As Double 'This is an array to hold total for each employee
        Dim totalDays As Integer = 7 ' used as to count totalDays 
        Dim columnAverage(2) As Double 'Used to find average per employee/column
        Dim overallTotalOfAvg As Double = 0.00 'used to store all average totals
        Dim overallAverage As Double = 0.00 ' used to find overall average 
        totalColumns = {0.00, 0.00, 0.00} 'it makes sure that there are no null values in the array
        columnAverage = {0.00, 0.00, 0.00} 'it makes sure that there are no null values in the array

        For columns As Integer = 0 To 2 'will run 3 times for three columns/employees
            For rows As Integer = 0 To totalDays - 1 'will run for 6 times

                totalColumns(columns) += empUserInput(rows, columns) ' every time for each emploee/column it will add the data into it. 
            Next
            columnAverage(columns) = totalColumns(columns) / totalDays 'finds average of each column
            overallTotalOfAvg += columnAverage(columns) 'Adds each column average in overallaverage
        Next
        overallAverage = overallTotalOfAvg / 3 'finds the overall average based on all 3 averages and divides it with 3
        Select Case columnDisplay 'Checks the column number and displays results based on it
            Case 0 'first employee
                lblAvgEmp1.Text = Format(columnAverage(columnDisplay), "n2").ToString 'displays in label with 2 decimal points
            Case 1
                lblAvgEmp2.Text = Format(columnAverage(columnDisplay), "n2").ToString 'displays in label with 2 decimal points
            Case 2

                lblAvgEmp3.Text = Format(columnAverage(columnDisplay), "n2").ToString 'displays in label with 2 decimal points
                lblOverallResult.Text = Format(overallAverage, "n2").ToString 'also displays overall average
        End Select
    End Sub
    Private Sub DisplayUnitsInTextbox(ByRef columnCounter As Integer, parsedInput As Integer)
        'This function is used to set labels to bold or regular and add the valid input to the multiline textboxes according to the employee name
        If columnCounter = 0 Then 'This means first employee
            lblEmployee1.Font = New Font(lblEmployee1.Font, FontStyle.Bold) 'Sets the above label to bold
            txtEmp1WeeklyUnits.Text += Convert.ToString(parsedInput) + vbCrLf ' adding new records each time it get called
            txtUnitsPerDay.Text = "" 'sets textbox for input empty and set focus
            txtUnitsPerDay.Focus()
        ElseIf columnCounter = 1 Then
            lblEmployee1.Font = New Font(lblEmployee1.Font, FontStyle.Regular) 'Sets the above label back to Regular
            lblEmployee2.Font = New Font(lblEmployee2.Font, FontStyle.Bold) 'Sets the above label to bold
            txtEmp2WeeklyUnits.Text += Convert.ToString(parsedInput) + vbCrLf ' adding new records each time it get called
            txtUnitsPerDay.Text = "" 'sets textbox for input empty and set focus
            txtUnitsPerDay.Focus()
        Else
            lblEmployee2.Font = New Font(lblEmployee2.Font, FontStyle.Regular) 'Sets the above label back to Regular
            lblEmployee3.Font = New Font(lblEmployee3.Font, FontStyle.Bold) 'Sets the above label to bold
            txtEmp3WeeklyUnits.Text += Convert.ToString(parsedInput) + vbCrLf ' adding new records each time it get called
            txtUnitsPerDay.Text = "" 'sets textbox for input empty and set focus
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
        'Empty the multiline textboxes
        txtEmp1WeeklyUnits.Text = ""
        txtEmp2WeeklyUnits.Text = ""
        txtEmp3WeeklyUnits.Text = ""
        'resets the label displays by default
        lblDaysCounter.Text = ""
        lblAvgEmp1.Text = ""
        lblAvgEmp2.Text = ""
        lblAvgEmp3.Text = ""
        lblOverallResult.Text = ""
        totalInputValues = 0 'clears buffer to start from 0 to calculate better
        loopCounterForRows = 0 ' clears the buffer for row counter
        loopCounterForColumns = 0 ' clears the buffer for column counter
        daysCounter = 1 ' default day is set to 1

        'Sets the caption(above) labels for the multiline textboxes to regular fonts 
        lblEmployee1.Font = New Font(lblEmployee1.Font, FontStyle.Regular)
        lblEmployee2.Font = New Font(lblEmployee2.Font, FontStyle.Regular)
        lblEmployee3.Font = New Font(lblEmployee3.Font, FontStyle.Regular)


    End Sub

    Private Sub txtUnitsPerDay_TextChanged(sender As Object, e As EventArgs) Handles txtUnitsPerDay.TextChanged
        'If days are 8 or greater than it and columns are 3 o grater than 3 then control some labels and a button
        If daysCounter >= 8 And loopCounterForColumns >= 3 Then
            btnEnter.Enabled() = False ' Disables enter button
        Else
            lblDaysCounter.Text = "Days: " & loopCounterForRows + 1 ' Adds days to the days counter label
        End If
    End Sub
End Class
