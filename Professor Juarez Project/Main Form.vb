' Name:         Professor Juarez Project
' Purpose:      Display the names and number of students earning a specific grade.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click, ToolStripMenuItem2.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Display the names and number of students earning a specific grade.

        Dim strNames() As String = {"Helen", "Peter", "Yolanda", "Carl", "Jennifer", "Charles", "Addison", "Aiden", "Treyson", "Sydney", "Jacob", "Nancy", "George", "Ursula", "Jack"}
        Dim strGrades() As String = {"A", "B", "B", "A", "D", "F", "A", "B", "A", "B", "F", "C", "C", "B", "D"}

        Dim count As Integer = 0
        Dim strResult(strNames.Length) As String
        For counter As Integer = 0 To strNames.Length - 1
            If strGrades(counter).Equals(lstGrades.SelectedItem.ToString) Then
                count += 1
                strResult(count - 1) = strNames(counter)

            End If

        Next

        lstNames.SelectionMode = SelectionMode.One
        lstNames.DataSource = strResult
        lstNames.Refresh()

        lblNumber.Text = count.ToString

    End Sub

    Private Sub lstGrades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGrades.SelectedIndexChanged
        lstNames.DataSource = Nothing
        For i As Integer = 0 To lstNames.Items.Count - 1
            lstNames.Items.RemoveAt(0)
        Next
        lstNames.Refresh()

        lblNumber.Text = ""

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstGrades.SelectedIndex = 0

    End Sub

End Class
