﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtPalabra = New System.Windows.Forms.TextBox()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnIguala = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtPalabra
        '
        Me.TxtPalabra.Location = New System.Drawing.Point(83, 25)
        Me.TxtPalabra.Name = "TxtPalabra"
        Me.TxtPalabra.Size = New System.Drawing.Size(100, 20)
        Me.TxtPalabra.TabIndex = 0
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(150, 226)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(100, 20)
        Me.txtResultado.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(12, 51)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(75, 23)
        Me.Btn1.TabIndex = 4
        Me.Btn1.Text = "Invierte"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(175, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Busca Letra"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnIguala
        '
        Me.btnIguala.Location = New System.Drawing.Point(12, 81)
        Me.btnIguala.Name = "btnIguala"
        Me.btnIguala.Size = New System.Drawing.Size(75, 23)
        Me.btnIguala.TabIndex = 6
        Me.btnIguala.Text = "Iguala"
        Me.btnIguala.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 258)
        Me.Controls.Add(Me.btnIguala)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.TxtPalabra)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtPalabra As TextBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn1 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnIguala As Button
End Class
