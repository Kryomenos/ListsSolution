<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Timer1 = New Timer(components)
        MenuStrip1 = New MenuStrip()
        ClockToolStripMenuItem = New ToolStripMenuItem()
        DateToolStripMenuItem = New ToolStripMenuItem()
        DayToolStripMenuItem = New ToolStripMenuItem()
        MonthToolStripMenuItem = New ToolStripMenuItem()
        YearToolStripMenuItem = New ToolStripMenuItem()
        FullDateToolStripMenuItem = New ToolStripMenuItem()
        TimeToolStripMenuItem = New ToolStripMenuItem()
        HoursToolStripMenuItem = New ToolStripMenuItem()
        MinutesToolStripMenuItem = New ToolStripMenuItem()
        YearToolStripMenuItem1 = New ToolStripMenuItem()
        FullTimeToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ClockToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(759, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ClockToolStripMenuItem
        ' 
        ClockToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DateToolStripMenuItem, TimeToolStripMenuItem})
        ClockToolStripMenuItem.Name = "ClockToolStripMenuItem"
        ClockToolStripMenuItem.Size = New Size(47, 20)
        ClockToolStripMenuItem.Text = "&clock"
        ' 
        ' DateToolStripMenuItem
        ' 
        DateToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DayToolStripMenuItem, MonthToolStripMenuItem, YearToolStripMenuItem, FullDateToolStripMenuItem})
        DateToolStripMenuItem.Name = "DateToolStripMenuItem"
        DateToolStripMenuItem.Size = New Size(180, 22)
        DateToolStripMenuItem.Text = "&Date"
        ' 
        ' DayToolStripMenuItem
        ' 
        DayToolStripMenuItem.Name = "DayToolStripMenuItem"
        DayToolStripMenuItem.Size = New Size(180, 22)
        DayToolStripMenuItem.Text = "&Day"
        ' 
        ' MonthToolStripMenuItem
        ' 
        MonthToolStripMenuItem.Name = "MonthToolStripMenuItem"
        MonthToolStripMenuItem.Size = New Size(180, 22)
        MonthToolStripMenuItem.Text = "&Month"
        ' 
        ' YearToolStripMenuItem
        ' 
        YearToolStripMenuItem.Name = "YearToolStripMenuItem"
        YearToolStripMenuItem.Size = New Size(180, 22)
        YearToolStripMenuItem.Text = "&Year"
        ' 
        ' FullDateToolStripMenuItem
        ' 
        FullDateToolStripMenuItem.Name = "FullDateToolStripMenuItem"
        FullDateToolStripMenuItem.Size = New Size(180, 22)
        FullDateToolStripMenuItem.Text = "&Full Date"
        ' 
        ' TimeToolStripMenuItem
        ' 
        TimeToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HoursToolStripMenuItem, MinutesToolStripMenuItem, YearToolStripMenuItem1, FullTimeToolStripMenuItem})
        TimeToolStripMenuItem.Name = "TimeToolStripMenuItem"
        TimeToolStripMenuItem.Size = New Size(180, 22)
        TimeToolStripMenuItem.Text = "&Time"
        ' 
        ' HoursToolStripMenuItem
        ' 
        HoursToolStripMenuItem.Name = "HoursToolStripMenuItem"
        HoursToolStripMenuItem.Size = New Size(180, 22)
        HoursToolStripMenuItem.Text = "&Hours"
        ' 
        ' MinutesToolStripMenuItem
        ' 
        MinutesToolStripMenuItem.Name = "MinutesToolStripMenuItem"
        MinutesToolStripMenuItem.Size = New Size(180, 22)
        MinutesToolStripMenuItem.Text = "&Minutes"
        ' 
        ' YearToolStripMenuItem1
        ' 
        YearToolStripMenuItem1.Name = "YearToolStripMenuItem1"
        YearToolStripMenuItem1.Size = New Size(180, 22)
        YearToolStripMenuItem1.Text = "&Seconds"
        ' 
        ' FullTimeToolStripMenuItem
        ' 
        FullTimeToolStripMenuItem.Name = "FullTimeToolStripMenuItem"
        FullTimeToolStripMenuItem.Size = New Size(180, 22)
        FullTimeToolStripMenuItem.Text = "&Full Time"
        ' 
        ' Label1
        ' 
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Bookman Old Style", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(215, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(176, 39)
        Label1.TabIndex = 1
        Label1.Text = "Label1"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(759, 450)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents ClockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonthToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HoursToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinutesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YearToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FullDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FullTimeToolStripMenuItem As ToolStripMenuItem

End Class
