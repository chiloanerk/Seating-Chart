Imports System.Text.RegularExpressions

Public Class Form1
    ' 2D array for seating chart
    Dim seatingChart(9, 3) As String
    ' Array for the waiting list
    Dim waitingList As New List(Of String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialise the seating chart with all available seats
        For row As Integer = 0 To 9
            For seat As Integer = 0 To 3
                seatingChart(row, seat) = "."
            Next
        Next

        ' Create columns for the ListView
        lvSeatingChart.Columns.Add("Row", 80)
        lvSeatingChart.Columns.Add("A", 60)
        lvSeatingChart.Columns.Add("B", 80)
        lvSeatingChart.Columns.Add("C", 60)
        lvSeatingChart.Columns.Add("D", 60)

        ' Load reservations from file
        LoadReservationsFromFile()

        ' Display initial seating chart on form load
        UpdateSeatingChartDisplay()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim name As String = txtName.Text.Trim()
        Dim seatInput As String = txtSeat.Text.Trim().ToUpper() ' Convert to uppercase for case-insensitive comparison

        'Check if the name and seat input are provided
        If name = "" Or seatInput = "" Then
            MessageBox.Show("Please provide passenger name and seat number.")
            Return
        End If

        'Check if the seat input is valid
        If Not IsValidSeatInput(seatInput) Then
            MessageBox.Show("Invalid seat number format. Please enter a valid seat number (e.g., 1A, 2B, 10D).")
            Return
        End If

        Dim row As Integer
        Dim seatIndex As Integer

        'Check number of characters for seat number
        If seatInput.Length = 2 Then
            ' Seat numbers from 1A to 9D 
            row = CInt(seatInput.Substring(0, 1)) - 1
            seatIndex = Asc(seatInput.Substring(1, 1)) - Asc("A")
        ElseIf seatInput.Length = 3 Then
            ' Seat numbers for rows 10A to 10D
            row = CInt(seatInput.Substring(0, 2)) - 1
            seatIndex = Asc(seatInput.Substring(2, 1)) - Asc("A")
        Else
            ' Invalid seat number format
            MessageBox.Show("Invalid seat number format. Please enter a valid seat number (e.g., 1A, 2B, 10D).")
            Return
        End If

        'Check if the seat is available
        If seatingChart(row, seatIndex) = "." Then
            seatingChart(row, seatIndex) = name
            UpdateSeatingChartDisplay()
        Else
            'If the seat is occupied, add the passenger to the waiting list
            waitingList.Add(name)
            MessageBox.Show("Seat already taken. Passenger added to the waiting list.")
            lstWait.Items.Add(name)
        End If

        'Clear the name and seat input textboxes
        txtName.Clear()
        txtSeat.Clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim name As String = txtName.Text.Trim().ToUpper() ' Convert to uppercase for case-insensitive comparison

        ' Check if the name is provided
        If name = "" Then
            MessageBox.Show("Please enter the passenger's name.")
            Return
        End If

        ' Search the seating chart for the passenger's name and delete it
        For row As Integer = 0 To 9
            For seat As Integer = 0 To 3
                If String.Equals(seatingChart(row, seat), name, StringComparison.OrdinalIgnoreCase) Then
                    seatingChart(row, seat) = "."
                    UpdateSeatingChartDisplay()

                    ' If the waiting list is not empty, assign the next passenger from the waiting list
                    If waitingList.Count > 0 Then
                        Dim waitingPassenger As String = waitingList(0)
                        waitingList.RemoveAt(0)
                        seatingChart(row, seat) = waitingPassenger
                        UpdateSeatingChartDisplay()
                        lstWait.Items.RemoveAt(0)
                    End If

                    ' Clear the name textbox
                    txtName.Clear()
                    Return
                End If
            Next
        Next

        ' If the passenger's name is not found in the seating chart or waiting list
        MessageBox.Show("Passenger not found on the flight or waiting list.")
        txtName.Clear()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Function IsPlaneFull() As Boolean
        For row As Integer = 0 To 9
            For seat As Integer = 0 To 3
                If seatingChart(row, seat) = "." Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    'Get the first available seat in the seating chart
    Private Function GetAvailableSeat() As String
        For row As Integer = 0 To 9
            For seat As Integer = 0 To 3
                If seatingChart(row, seat) = "." Then
                    Return (row + 1) & Chr(seat + 65)
                End If
            Next
        Next
        Return Nothing
    End Function

    Private Function IsValidSeatInput(seatInput As String) As Boolean
        Dim validSeatRegex As New Regex("^([1-9]|10)[A-D]$", RegexOptions.IgnoreCase)
        Return validSeatRegex.IsMatch(seatInput)
    End Function

    'Update the seating chart display in the ListView
    Private Sub UpdateSeatingChartDisplay()
        lvSeatingChart.Items.Clear()
        For row As Integer = 0 To 9
            Dim rowDisplay As New List(Of String)()
            rowDisplay.Add((row + 1).ToString()) ' Add the row number as the first column

            For seat As Integer = 0 To 3
                If seatingChart(row, seat) = "." Then
                    rowDisplay.Add(".")
                Else
                    rowDisplay.Add("X")
                End If
            Next

            Dim listViewItem As New ListViewItem(rowDisplay.ToArray())
            lvSeatingChart.Items.Add(listViewItem)
        Next
    End Sub

    Private Sub SaveReservationsToFile()
        Dim filePath As String = "reservations.txt"
        Using writer As New System.IO.StreamWriter(filePath)
            For row As Integer = 0 To 9
                For seat As Integer = 0 To 3
                    writer.WriteLine(seatingChart(row, seat))
                Next
            Next

            For Each passenger As String In waitingList
                writer.WriteLine(passenger)
            Next
        End Using
    End Sub

    Private Sub LoadReservationsFromFile()
        Dim filePath As String = "reservations.txt"
        If System.IO.File.Exists(filePath) Then
            Dim lines As String() = System.IO.File.ReadAllLines(filePath)
            Dim index As Integer = 0
            For row As Integer = 0 To 9
                For seat As Integer = 0 To 3
                    seatingChart(row, seat) = lines(index)
                    index += 1
                Next
            Next

            waitingList.Clear()
            While index < lines.Length
                waitingList.Add(lines(index))
                index += 1
            End While

            UpdateSeatingChartDisplay()
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SaveReservationsToFile()
    End Sub
End Class
