Public Class Form2
    Dim front, up, down As Boolean
    Private WithEvents Tmr As New Timer With {.Interval = 40}
    'Private water As New Bitmap("C:\Users\Students\Downloads\DurrrSpaceShip.png")
    Private water As New Bitmap("C:\Users\Students\Downloads\FinalGameIntroCompSci-master\FinalGameIntroCompSci-master\FinalGame\FinalGame\img\untitled.png")


    Private waterposition As Integer = 0

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Size = New Size(510, 510)
        Tmr.Start()
    End Sub

    Private Sub Tmr_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tmr.Tick
        If front = True Then
            waterposition += 100
            If waterposition >= water.Width Then waterposition = 0
            PictureBox1.Invalidate()
        End If

        If up = True Then
            PictureBox2.Top -= 5
        End If

        If down = True Then
            PictureBox2.Top += 5
        End If
    End Sub

    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
        e.Graphics.DrawImage(water, waterposition, 0)
        If waterposition > 0 Then e.Graphics.DrawImage(water, 0 - (water.Width - waterposition), 0)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.A Then
            front = True
        End If

        If e.KeyCode = Keys.W Then
            up = True
        End If
        If e.KeyCode = Keys.S Then
            down = True
        End If

        If e.KeyCode = Keys.A And e.KeyCode = Keys.W Then
            front = True
            up = True
        End If

        If e.KeyCode = Keys.A And e.KeyCode = Keys.S Then
            front = True
            down = True
        End If
    End Sub

    Private Sub Form2_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.A Then
            front = False
        End If

        If e.KeyCode = Keys.W Then
            up = False
        End If
        If e.KeyCode = Keys.S Then
            down = False
        End If
    End Sub
End Class