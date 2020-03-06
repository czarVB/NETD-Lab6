'****************************************************************
'* Name: Evan Heath
'* Date: February 22nd, 2019
'* Program Name: Average Units Shipped for Multiple Employee's - NETD Lab 3
'* Purpose: Calculate the average units shipped for 3 employee's and then the overall average
'****************************************************************

Public Class frmShippingAverage

    Dim day As Integer = 0
    Dim employee As Integer = 0
    Dim overallAverage As Double = 0.0

    Const PACKAGE_MIN As Integer = 0
    Const PACKAGE_MAX As Integer = 1000

    Dim packages(2, 6) As Integer
    Dim employeeAverages() As Double = New Double(2) {0.0, 0.0, 0.0}

    Public Function displayPackages(ByVal e As Integer, ByVal d As Integer) As Boolean

        ' Declare a variable to save values to
        Dim employeePackages() As String = New String(6) {"", "", "", "", "", "", ""}

        For i As Integer = 0 To d
            employeePackages(i) = packages(e, i)
        Next

        ' Display the result accordingly
        If e = 0 Then
            txtEmployee1.Lines = employeePackages
        ElseIf e = 1 Then
            txtEmployee2.Lines = employeePackages
        ElseIf e = 2 Then
            txtEmployee3.Lines = employeePackages
        End If

        Return True
    End Function

    Public Function displayAverage(ByVal e As Integer, ByVal avg As Double) As Boolean

        ' Determine which text box to print the average to
        If e = 0 Then
            txtAverage1.Text = "Average: " + avg.ToString("f2")
        ElseIf e = 1 Then
            txtAverage2.Text = "Average: " + avg.ToString("f2")
        ElseIf e = 2 Then
            txtAverage3.Text = "Average: " + avg.ToString("f2")
        End If

    End Function

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        ' Declare a variable to parse the input to
        Dim parsedInput As Integer = -1

        ' Try to parse the input to integer and check if it's in the data range
        If Integer.TryParse(txtPackages.Text, parsedInput) And parsedInput >= PACKAGE_MIN And parsedInput <= PACKAGE_MAX Then

            ' Save the input
            packages(employee, day) = parsedInput

            ' Add the input to the employee's average
            employeeAverages(employee) += parsedInput

            ' Print the new input to the screen
            displayPackages(employee, day)

            ' Increment the day and employee variables accordingly
            If day = 6 Then

                ' Calculate the employee's average
                employeeAverages(employee) = employeeAverages(employee) / 7.0

                ' Display the average to the proper control
                displayAverage(employee, employeeAverages(employee))

                ' Add average to overallAverage
                overallAverage += employeeAverages(employee)

                ' Is this the last employee
                If employee = 2 Then

                    ' Calculate the average of all the employee's
                    overallAverage = overallAverage / 3.0

                    ' Display the overall average to the screen
                    txtFeedback.Text = "Employee Average: " + overallAverage.ToString("f2")

                    ' Disable the average button
                    btnEnter.Enabled = False

                    ' Erase the indicators
                    txtEmployee.Text = ""
                    txtDay.Text = ""

                    ' Disable the input textbox
                    txtPackages.Enabled = False

                Else
                    ' Increment employee
                    employee += 1
                    txtEmployee.Text = "Employee " + (employee + 1).ToString

                    ' Reset the day
                    day = 0
                End If
            Else
                ' Only increment the day
                day += 1
                txtDay.Text = "Day " + (day + 1).ToString
            End If

            ' Erase last input
            txtPackages.Text = ""

        Else ' The input couldn't parse to integer

            ' Input isn't an integer and post an error message
            txtFeedback.Text = "The input must be an integer between " + PACKAGE_MIN.ToString + " and " + PACKAGE_MAX.ToString + "."

        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        ' Reset the day and employee indicators
        employee = 0
        day = 0
        txtEmployee.Text = "Employee 1"
        txtDay.Text = "Day 1"

        ' Re-Enable the input textbox
        txtPackages.Enabled = True

        ' Erase any input
        txtPackages.Text = ""

        ' Erase the textboxes
        txtEmployee1.Lines = {}
        txtEmployee2.Lines = {}
        txtEmployee3.Lines = {}
        txtAverage1.Text = ""
        txtAverage2.Text = ""
        txtAverage3.Text = ""

        ' Clean the feedback
        txtFeedback.Text = ""

        ' Re-Enable Enter Button
        btnEnter.Enabled = True

        ' Clean the packages and 
        For x As Integer = 0 To 2
            For y As Integer = 0 To 6
                packages(x, y) = 0
            Next
            employeeAverages(x) = 0.0
        Next

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' Close the application
        Close()

    End Sub
End Class
