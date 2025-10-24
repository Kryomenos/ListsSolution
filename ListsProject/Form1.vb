Public Class Form1
    Public Property TabControl1 As Object

    Private Sub DateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateToolStripMenuItem.Click
        Label1.Text = DateString
        Timer1.Stop()
    End Sub

    Private Sub TimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeToolStripMenuItem.Click
        Timer1.Start()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = TimeString
    End Sub

    Private Sub DayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DayToolStripMenuItem.Click
        Label1.Text = Weekday(Now)
    End Sub

    Private Sub MonthToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonthToolStripMenuItem.Click
        Label1.Text = Month(Now)
    End Sub

    Private Sub YearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YearToolStripMenuItem.Click
        Label1.Text = Year(Now)
    End Sub

    Private Sub HoursToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HoursToolStripMenuItem.Click
        Label1.Text = Hour(Now)
        Timer1.Stop()
    End Sub

    Private Sub MinutesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinutesToolStripMenuItem.Click
        Label1.Text = Minute(Now)
        Timer1.Stop()
    End Sub

    Private Sub YearToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles YearToolStripMenuItem1.Click
        Label1.Text = Second(Now)
        Timer1.Stop()
    End Sub

    Private Sub FullDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullDateToolStripMenuItem.Click
        Label1.Text = DateString
        Timer1.Stop()
    End Sub

    Private Sub FullTimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullTimeToolStripMenuItem.Click
        Label1.Text = TimeString
    End Sub
End Class
