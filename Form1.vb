Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form2.Visible = True
    End Sub


    Private Sub InitializeAcceleratedUpDown()

        NumericUpDown.Visible = True
        NumericUpDown.Location = New Point(40, 40)
        NumericUpDown.Maximum = 40000
        NumericUpDown.Minimum = -40000

        ' Add some accelerations to the control.
        NumericUpDown.Accelerations.Add(New NumericUpDownAcceleration(2, 100))
        NumericUpDown.Accelerations.Add(New NumericUpDownAcceleration(5, 1000))
        NumericUpDown.Accelerations.Add(New NumericUpDownAcceleration(8, 5000))
        Controls.Add(NumericUpDown)

    End Sub
End Class