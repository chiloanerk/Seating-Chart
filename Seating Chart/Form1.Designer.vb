<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        btnAdd = New Button()
        btnDelete = New Button()
        btnQuit = New Button()
        txtName = New TextBox()
        txtSeat = New TextBox()
        Label3 = New Label()
        lstWait = New ListView()
        Label4 = New Label()
        lvSeatingChart = New ListView()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 15)
        Label1.TabIndex = 0
        Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(166, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(32, 15)
        Label2.TabIndex = 1
        Label2.Text = "Seat:"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(50, 35)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(110, 32)
        btnAdd.TabIndex = 2
        btnAdd.Text = "Add Passenger"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(50, 73)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(110, 34)
        btnDelete.TabIndex = 3
        btnDelete.Text = "Delete Passenger"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnQuit
        ' 
        btnQuit.Location = New Point(50, 113)
        btnQuit.Name = "btnQuit"
        btnQuit.Size = New Size(110, 37)
        btnQuit.TabIndex = 4
        btnQuit.Text = "Quit"
        btnQuit.UseVisualStyleBackColor = True
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(60, 6)
        txtName.Name = "txtName"
        txtName.Size = New Size(100, 23)
        txtName.TabIndex = 5
        ' 
        ' txtSeat
        ' 
        txtSeat.Location = New Point(204, 6)
        txtSeat.Name = "txtSeat"
        txtSeat.Size = New Size(58, 23)
        txtSeat.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(60, 153)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 15)
        Label3.TabIndex = 7
        Label3.Text = "Waiting List:"
        ' 
        ' lstWait
        ' 
        lstWait.Location = New Point(50, 171)
        lstWait.Name = "lstWait"
        lstWait.Size = New Size(110, 120)
        lstWait.TabIndex = 8
        lstWait.UseCompatibleStateImageBehavior = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(166, 32)
        Label4.Name = "Label4"
        Label4.Size = New Size(149, 15)
        Label4.TabIndex = 10
        Label4.Text = "(1A, 1B, 1C, 1D, 2A, ..., 10D)"
        ' 
        ' lvSeatingChart
        ' 
        lvSeatingChart.Location = New Point(166, 53)
        lvSeatingChart.Name = "lvSeatingChart"
        lvSeatingChart.Size = New Size(340, 238)
        lvSeatingChart.TabIndex = 11
        lvSeatingChart.UseCompatibleStateImageBehavior = False
        lvSeatingChart.View = View.Details
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(526, 311)
        Controls.Add(lvSeatingChart)
        Controls.Add(Label4)
        Controls.Add(lstWait)
        Controls.Add(Label3)
        Controls.Add(txtSeat)
        Controls.Add(txtName)
        Controls.Add(btnQuit)
        Controls.Add(btnDelete)
        Controls.Add(btnAdd)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Seating Chart"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSeat As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lstWait As ListView
    Friend WithEvents Label4 As Label
    Friend WithEvents lvSeatingChart As ListView
End Class
