﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.Setpoint = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PumpOn = New System.Windows.Forms.CheckBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Hysteresis = New System.Windows.Forms.TrackBar()
        Me.q = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HystLab = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PumpSpeed = New System.Windows.Forms.TrackBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OutflowRate = New System.Windows.Forms.TrackBar()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hysteresis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PumpSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutflowRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Setpoint
        '
        Me.Setpoint.Location = New System.Drawing.Point(110, 44)
        Me.Setpoint.Name = "Setpoint"
        Me.Setpoint.Size = New System.Drawing.Size(39, 20)
        Me.Setpoint.TabIndex = 1
        Me.Setpoint.Text = "50"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(152, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Setpoint"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(110, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(155, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Process Variable"
        '
        'PumpOn
        '
        Me.PumpOn.AutoSize = True
        Me.PumpOn.Location = New System.Drawing.Point(295, 156)
        Me.PumpOn.Name = "PumpOn"
        Me.PumpOn.Size = New System.Drawing.Size(70, 17)
        Me.PumpOn.TabIndex = 5
        Me.PumpOn.Text = "Pump On"
        Me.PumpOn.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(555, 71)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar1.Size = New System.Drawing.Size(45, 145)
        Me.TrackBar1.TabIndex = 6
        Me.TrackBar1.Value = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(539, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tank Level"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(311, 247)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 32)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Increase"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Hysteresis
        '
        Me.Hysteresis.Location = New System.Drawing.Point(108, 147)
        Me.Hysteresis.Maximum = 20
        Me.Hysteresis.Name = "Hysteresis"
        Me.Hysteresis.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.Hysteresis.Size = New System.Drawing.Size(45, 177)
        Me.Hysteresis.TabIndex = 9
        '
        'q
        '
        Me.q.AutoSize = True
        Me.q.Location = New System.Drawing.Point(98, 131)
        Me.q.Name = "q"
        Me.q.Size = New System.Drawing.Size(55, 13)
        Me.q.TabIndex = 10
        Me.q.Text = "Hysteresis"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'HystLab
        '
        Me.HystLab.AutoSize = True
        Me.HystLab.Location = New System.Drawing.Point(140, 203)
        Me.HystLab.Name = "HystLab"
        Me.HystLab.Size = New System.Drawing.Size(13, 13)
        Me.HystLab.TabIndex = 11
        Me.HystLab.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(616, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Pump Speed"
        '
        'PumpSpeed
        '
        Me.PumpSpeed.Location = New System.Drawing.Point(632, 71)
        Me.PumpSpeed.Maximum = 6
        Me.PumpSpeed.Minimum = 1
        Me.PumpSpeed.Name = "PumpSpeed"
        Me.PumpSpeed.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.PumpSpeed.Size = New System.Drawing.Size(45, 145)
        Me.PumpSpeed.TabIndex = 12
        Me.PumpSpeed.Value = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(694, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Tank Outflow Rate"
        '
        'OutflowRate
        '
        Me.OutflowRate.Location = New System.Drawing.Point(710, 71)
        Me.OutflowRate.Maximum = 5
        Me.OutflowRate.Minimum = 1
        Me.OutflowRate.Name = "OutflowRate"
        Me.OutflowRate.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.OutflowRate.Size = New System.Drawing.Size(45, 145)
        Me.OutflowRate.TabIndex = 14
        Me.OutflowRate.Value = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.OutflowRate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PumpSpeed)
        Me.Controls.Add(Me.HystLab)
        Me.Controls.Add(Me.q)
        Me.Controls.Add(Me.Hysteresis)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.PumpOn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Setpoint)
        Me.Name = "Form1"
        Me.Text = "Process Simulator"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hysteresis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PumpSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutflowRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Setpoint As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PumpOn As CheckBox
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Hysteresis As TrackBar
    Friend WithEvents q As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents HystLab As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PumpSpeed As TrackBar
    Friend WithEvents Label6 As Label
    Friend WithEvents OutflowRate As TrackBar
End Class
