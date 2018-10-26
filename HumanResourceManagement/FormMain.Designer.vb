<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    'Inherits System.Windows.Forms.Form
    Inherits DevComponents.DotNetBar.OfficeForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ClockStyleData1 As DevComponents.DotNetBar.Controls.ClockStyleData = New DevComponents.DotNetBar.Controls.ClockStyleData()
        Dim ColorData1 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Dim ColorData2 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Dim ColorData3 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Dim ClockHandStyleData1 As DevComponents.DotNetBar.Controls.ClockHandStyleData = New DevComponents.DotNetBar.Controls.ClockHandStyleData()
        Dim ColorData4 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Dim ColorData5 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Dim ClockHandStyleData2 As DevComponents.DotNetBar.Controls.ClockHandStyleData = New DevComponents.DotNetBar.Controls.ClockHandStyleData()
        Dim ColorData6 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Dim ClockHandStyleData3 As DevComponents.DotNetBar.Controls.ClockHandStyleData = New DevComponents.DotNetBar.Controls.ClockHandStyleData()
        Dim ColorData7 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Dim ColorData8 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Me.RadialMenu1 = New DevComponents.DotNetBar.RadialMenu()
        Me.RadialMenuItem1 = New DevComponents.DotNetBar.RadialMenuItem()
        Me.RadialMenuItem2 = New DevComponents.DotNetBar.RadialMenuItem()
        Me.RadialMenuItem3 = New DevComponents.DotNetBar.RadialMenuItem()
        Me.RadialMenuItem4 = New DevComponents.DotNetBar.RadialMenuItem()
        Me.RadialMenuItem5 = New DevComponents.DotNetBar.RadialMenuItem()
        Me.RadialMenuItem6 = New DevComponents.DotNetBar.RadialMenuItem()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.clockControl3 = New DevComponents.DotNetBar.Controls.AnalogClockControl()
        Me.SuspendLayout()
        '
        'RadialMenu1
        '
        Me.RadialMenu1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.RadialMenuItem1, Me.RadialMenuItem2, Me.RadialMenuItem3, Me.RadialMenuItem4, Me.RadialMenuItem5, Me.RadialMenuItem6})
        Me.RadialMenu1.Location = New System.Drawing.Point(114, 343)
        Me.RadialMenu1.Name = "RadialMenu1"
        Me.RadialMenu1.Size = New System.Drawing.Size(28, 28)
        Me.RadialMenu1.Symbol = ""
        Me.RadialMenu1.TabIndex = 0
        Me.RadialMenu1.Text = "RadialMenu1"
        '
        'RadialMenuItem1
        '
        Me.RadialMenuItem1.Name = "RadialMenuItem1"
        Me.RadialMenuItem1.Text = "LOGIN/LOGOUT"
        '
        'RadialMenuItem2
        '
        Me.RadialMenuItem2.Name = "RadialMenuItem2"
        Me.RadialMenuItem2.Text = "SEARCH"
        '
        'RadialMenuItem3
        '
        Me.RadialMenuItem3.Name = "RadialMenuItem3"
        Me.RadialMenuItem3.Text = "PSD"
        '
        'RadialMenuItem4
        '
        Me.RadialMenuItem4.Name = "RadialMenuItem4"
        Me.RadialMenuItem4.Text = "USER"
        '
        'RadialMenuItem5
        '
        Me.RadialMenuItem5.Name = "RadialMenuItem5"
        Me.RadialMenuItem5.Text = "ADMIN"
        '
        'RadialMenuItem6
        '
        Me.RadialMenuItem6.Name = "RadialMenuItem6"
        Me.RadialMenuItem6.Text = "EXIT"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer)))
        '
        'clockControl3
        '
        Me.clockControl3.AutomaticMode = True
        Me.clockControl3.BackColor = System.Drawing.Color.Transparent
        Me.clockControl3.ClockStyle = DevComponents.DotNetBar.Controls.eClockStyles.Custom
        ColorData1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData1.BrushAngle = 90.0!
        ColorData1.BrushSBSScale = 1.0!
        ColorData1.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear
        ColorData1.Color1 = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        ColorData1.Color2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ClockStyleData1.BezelColor = ColorData1
        ColorData2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData2.BorderWidth = 0.01!
        ColorData2.BrushSBSScale = 1.0!
        ColorData2.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ColorData2.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ClockStyleData1.CapColor = ColorData2
        ClockStyleData1.CapSize = 0.1!
        ColorData3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData3.BrushAngle = 90.0!
        ColorData3.BrushSBSScale = 1.0!
        ColorData3.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear
        ColorData3.Color1 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        ColorData3.Color2 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        ClockStyleData1.FaceColor = ColorData3
        ClockStyleData1.GlassAngle = 0
        ColorData4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData4.BorderWidth = 0.01!
        ColorData4.BrushAngle = 90.0!
        ColorData4.BrushSBSScale = 1.0!
        ColorData4.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear
        ColorData4.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData4.Color2 = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        ClockHandStyleData1.HandColor = ColorData4
        ClockHandStyleData1.HandStyle = DevComponents.DotNetBar.Controls.eHandStyles.Style3
        ClockHandStyleData1.Length = 0.45!
        ClockHandStyleData1.Width = 0.175!
        ClockStyleData1.HourHandStyle = ClockHandStyleData1
        ColorData5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData5.BorderWidth = 0.01!
        ColorData5.BrushSBSScale = 1.0!
        ColorData5.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData5.Color2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ClockStyleData1.LargeTickColor = ColorData5
        ClockStyleData1.LargeTickWidth = 0.01!
        ColorData6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData6.BorderWidth = 0.01!
        ColorData6.BrushAngle = 90.0!
        ColorData6.BrushSBSScale = 1.0!
        ColorData6.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear
        ColorData6.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData6.Color2 = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        ClockHandStyleData2.HandColor = ColorData6
        ClockHandStyleData2.HandStyle = DevComponents.DotNetBar.Controls.eHandStyles.Style3
        ClockHandStyleData2.Length = 0.75!
        ClockHandStyleData2.Width = 0.175!
        ClockStyleData1.MinuteHandStyle = ClockHandStyleData2
        ClockStyleData1.NumberColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ClockStyleData1.NumberFont = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        ClockHandStyleData3.DrawOverCap = True
        ColorData7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData7.BorderWidth = 0.01!
        ColorData7.BrushSBSScale = 1.0!
        ColorData7.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData7.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ClockHandStyleData3.HandColor = ColorData7
        ClockHandStyleData3.HandStyle = DevComponents.DotNetBar.Controls.eHandStyles.Style4
        ClockHandStyleData3.Length = 0.9!
        ClockHandStyleData3.Width = 0.01!
        ClockStyleData1.SecondHandStyle = ClockHandStyleData3
        ColorData8.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData8.BorderWidth = 0.01!
        ColorData8.BrushSBSScale = 1.0!
        ColorData8.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData8.Color2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ClockStyleData1.SmallTickColor = ColorData8
        ClockStyleData1.SmallTickLength = 0.01!
        ClockStyleData1.SmallTickWidth = 0.01!
        ClockStyleData1.Style = DevComponents.DotNetBar.Controls.eClockStyles.Custom
        Me.clockControl3.ClockStyleData = ClockStyleData1
        Me.clockControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.clockControl3.IndicatorStyle = DevComponents.DotNetBar.Controls.eClockIndicatorStyles.Numbers
        Me.clockControl3.Location = New System.Drawing.Point(0, 0)
        Me.clockControl3.Name = "clockControl3"
        Me.clockControl3.Size = New System.Drawing.Size(265, 265)
        Me.clockControl3.TabIndex = 6
        Me.clockControl3.Text = "clockControl3"
        Me.clockControl3.Value = New Date(2011, 3, 22, 10, 36, 29, 417)
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(265, 468)
        Me.Controls.Add(Me.clockControl3)
        Me.Controls.Add(Me.RadialMenu1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HRMS - CEIT"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadialMenu1 As DevComponents.DotNetBar.RadialMenu
    Friend WithEvents RadialMenuItem1 As DevComponents.DotNetBar.RadialMenuItem
    Friend WithEvents RadialMenuItem2 As DevComponents.DotNetBar.RadialMenuItem
    Friend WithEvents RadialMenuItem3 As DevComponents.DotNetBar.RadialMenuItem
    Friend WithEvents RadialMenuItem4 As DevComponents.DotNetBar.RadialMenuItem
    Friend WithEvents RadialMenuItem5 As DevComponents.DotNetBar.RadialMenuItem
    Friend WithEvents RadialMenuItem6 As DevComponents.DotNetBar.RadialMenuItem
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Private WithEvents clockControl3 As DevComponents.DotNetBar.Controls.AnalogClockControl

End Class
