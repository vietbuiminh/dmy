Public Class Form1
    Dim dAy As Integer
    Dim mOnth As Integer
    Dim yEar As Integer
    Dim wEek As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            dAy = TextBox1.Text
            mOnth = TextBox2.Text
            yEar = TextBox3.Text

            If mOnth > 12 Then
                MsgBox("Please enter again the month")
            End If
            If (mOnth = 1) Or (mOnth = 3) Or (mOnth = 5) Or (mOnth = 7) Or (mOnth = 8) Or (mOnth = 10) Or (mOnth = 12) Then
                If dAy > 31 Then
                    MsgBox("Please enter again the day")
                End If
            End If
            If (mOnth = 4) Or (mOnth = 6) Or (mOnth = 9) Or (mOnth = 11) Then
                If dAy > 30 Then
                    MsgBox("Please enter again the day")
                End If
            End If
            If mOnth = 2 Then
                If (yEar Mod 4 = 0) And (yEar Mod 100 <> 0) Or (yEar Mod 400 = 0) Then
                    If dAy > 29 Then
                        MsgBox("Please enter again the day")
                    End If
                Else
                    If dAy > 28 Then
                        MsgBox("Please enter again the day")
                    End If
                End If
            End If


            If mOnth < 3 Then
                mOnth = mOnth + 12
                yEar = yEar - 1
            End If
            wEek = Fix(dAy + 2 * mOnth + (3 * (mOnth + 1)) / 5 + yEar + (yEar Mod 4)) Mod 7
            If wEek = 0 Then
                Label1.Text = "SUNDAY"
            End If
            If wEek = 1 Then
                Label1.Text = "MONDAY"
            End If
            If wEek = 2 Then
                Label1.Text = "TUESDAY"
            End If
            If wEek = 3 Then
                Label1.Text = "WEDNESDAY"
            End If
            If wEek = 4 Then
                Label1.Text = "THURSDAY"
            End If
            If wEek = 5 Then
                Label1.Text = "FRIDAY"
            End If
            If wEek = 6 Then
                Label1.Text = "SATURDAY"
            End If
        Catch ex As Exception
            MsgBox("Make sure entered all day, month and year!")
        End Try

    End Sub
End Class
