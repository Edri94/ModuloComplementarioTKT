﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMT103OrdPago
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RbTodas = New System.Windows.Forms.RadioButton()
        Me.RbNoEnv = New System.Windows.Forms.RadioButton()
        Me.RbEnv = New System.Windows.Forms.RadioButton()
        Me.cmdImprimir = New System.Windows.Forms.Button()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFechaFin = New System.Windows.Forms.TextBox()
        Me.txtFechaIni = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblOperCanceladas = New System.Windows.Forms.Label()
        Me.lblPendDetenidosSwift = New System.Windows.Forms.Label()
        Me.lblAplicYEnv_EQ = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOperCanceladas = New System.Windows.Forms.TextBox()
        Me.txtPendDetenidosSwift = New System.Windows.Forms.TextBox()
        Me.txtAplicYEnv_EQ = New System.Windows.Forms.TextBox()
        Me.txtEnvEqPendxConfirmar = New System.Windows.Forms.TextBox()
        Me.txtPendientesxAplicar = New System.Windows.Forms.TextBox()
        Me.txtPendxConfirmar = New System.Windows.Forms.TextBox()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.cmdImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdConsultar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtFechaFin)
        Me.GroupBox1.Controls.Add(Me.txtFechaIni)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 96)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parametros de Consulta"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RbTodas)
        Me.GroupBox3.Controls.Add(Me.RbNoEnv)
        Me.GroupBox3.Controls.Add(Me.RbEnv)
        Me.GroupBox3.Location = New System.Drawing.Point(-56, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(109, 113)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ordenes de Pago:"
        Me.GroupBox3.Visible = False
        '
        'RbTodas
        '
        Me.RbTodas.AutoSize = True
        Me.RbTodas.Location = New System.Drawing.Point(17, 77)
        Me.RbTodas.Name = "RbTodas"
        Me.RbTodas.Size = New System.Drawing.Size(55, 17)
        Me.RbTodas.TabIndex = 5
        Me.RbTodas.TabStop = True
        Me.RbTodas.Text = "Todas"
        Me.RbTodas.UseVisualStyleBackColor = True
        Me.RbTodas.Visible = False
        '
        'RbNoEnv
        '
        Me.RbNoEnv.AutoSize = True
        Me.RbNoEnv.Location = New System.Drawing.Point(18, 54)
        Me.RbNoEnv.Name = "RbNoEnv"
        Me.RbNoEnv.Size = New System.Drawing.Size(85, 17)
        Me.RbNoEnv.TabIndex = 4
        Me.RbNoEnv.TabStop = True
        Me.RbNoEnv.Text = "No enviadas"
        Me.RbNoEnv.UseVisualStyleBackColor = True
        Me.RbNoEnv.Visible = False
        '
        'RbEnv
        '
        Me.RbEnv.AutoSize = True
        Me.RbEnv.Location = New System.Drawing.Point(17, 22)
        Me.RbEnv.Name = "RbEnv"
        Me.RbEnv.Size = New System.Drawing.Size(69, 17)
        Me.RbEnv.TabIndex = 3
        Me.RbEnv.TabStop = True
        Me.RbEnv.Text = "Enviadas"
        Me.RbEnv.UseVisualStyleBackColor = True
        Me.RbEnv.Visible = False
        '
        'cmdImprimir
        '
        Me.cmdImprimir.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cmdImprimir.Location = New System.Drawing.Point(651, 41)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(100, 35)
        Me.cmdImprimir.TabIndex = 12
        Me.cmdImprimir.Text = "Imprimir"
        Me.cmdImprimir.UseVisualStyleBackColor = False
        '
        'cmdConsultar
        '
        Me.cmdConsultar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cmdConsultar.Location = New System.Drawing.Point(522, 41)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(100, 35)
        Me.cmdConsultar.TabIndex = 13
        Me.cmdConsultar.Text = "Consultar"
        Me.cmdConsultar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(354, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Fecha Fin:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(221, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Fecha Inicio:"
        '
        'txtFechaFin
        '
        Me.txtFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaFin.Location = New System.Drawing.Point(355, 50)
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Size = New System.Drawing.Size(100, 22)
        Me.txtFechaFin.TabIndex = 9
        Me.txtFechaFin.Text = "0000-00-00"
        Me.txtFechaFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFechaIni
        '
        Me.txtFechaIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaIni.Location = New System.Drawing.Point(221, 50)
        Me.txtFechaIni.Name = "txtFechaIni"
        Me.txtFechaIni.Size = New System.Drawing.Size(100, 22)
        Me.txtFechaIni.TabIndex = 8
        Me.txtFechaIni.Text = "0000-00-00"
        Me.txtFechaIni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Agencia HOUSTON"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblOperCanceladas)
        Me.GroupBox2.Controls.Add(Me.lblPendDetenidosSwift)
        Me.GroupBox2.Controls.Add(Me.lblAplicYEnv_EQ)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtOperCanceladas)
        Me.GroupBox2.Controls.Add(Me.txtPendDetenidosSwift)
        Me.GroupBox2.Controls.Add(Me.txtAplicYEnv_EQ)
        Me.GroupBox2.Controls.Add(Me.txtEnvEqPendxConfirmar)
        Me.GroupBox2.Controls.Add(Me.txtPendientesxAplicar)
        Me.GroupBox2.Controls.Add(Me.txtPendxConfirmar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(776, 135)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resumen Resultado de Consulta"
        '
        'lblOperCanceladas
        '
        Me.lblOperCanceladas.AutoSize = True
        Me.lblOperCanceladas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperCanceladas.Location = New System.Drawing.Point(443, 105)
        Me.lblOperCanceladas.Name = "lblOperCanceladas"
        Me.lblOperCanceladas.Size = New System.Drawing.Size(162, 16)
        Me.lblOperCanceladas.TabIndex = 20
        Me.lblOperCanceladas.Text = "Operaciones Canceladas"
        '
        'lblPendDetenidosSwift
        '
        Me.lblPendDetenidosSwift.AutoSize = True
        Me.lblPendDetenidosSwift.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendDetenidosSwift.Location = New System.Drawing.Point(443, 66)
        Me.lblPendDetenidosSwift.Name = "lblPendDetenidosSwift"
        Me.lblPendDetenidosSwift.Size = New System.Drawing.Size(189, 16)
        Me.lblPendDetenidosSwift.TabIndex = 19
        Me.lblPendDetenidosSwift.Text = "Pendientes Detenidos en Swift"
        '
        'lblAplicYEnv_EQ
        '
        Me.lblAplicYEnv_EQ.AutoSize = True
        Me.lblAplicYEnv_EQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAplicYEnv_EQ.Location = New System.Drawing.Point(443, 29)
        Me.lblAplicYEnv_EQ.Name = "lblAplicYEnv_EQ"
        Me.lblAplicYEnv_EQ.Size = New System.Drawing.Size(206, 16)
        Me.lblAplicYEnv_EQ.TabIndex = 18
        Me.lblAplicYEnv_EQ.Text = "Aplicados y Enviados a Equation"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(42, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(239, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Enviadas Equation Pend por Confirmar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(42, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Pendientes por Aplicar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Pendientes por Confirmar"
        '
        'txtOperCanceladas
        '
        Me.txtOperCanceladas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOperCanceladas.Location = New System.Drawing.Point(651, 101)
        Me.txtOperCanceladas.Name = "txtOperCanceladas"
        Me.txtOperCanceladas.Size = New System.Drawing.Size(100, 22)
        Me.txtOperCanceladas.TabIndex = 14
        Me.txtOperCanceladas.Text = "0"
        Me.txtOperCanceladas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPendDetenidosSwift
        '
        Me.txtPendDetenidosSwift.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPendDetenidosSwift.Location = New System.Drawing.Point(651, 62)
        Me.txtPendDetenidosSwift.Name = "txtPendDetenidosSwift"
        Me.txtPendDetenidosSwift.Size = New System.Drawing.Size(100, 22)
        Me.txtPendDetenidosSwift.TabIndex = 13
        Me.txtPendDetenidosSwift.Text = "0"
        Me.txtPendDetenidosSwift.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAplicYEnv_EQ
        '
        Me.txtAplicYEnv_EQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAplicYEnv_EQ.Location = New System.Drawing.Point(651, 25)
        Me.txtAplicYEnv_EQ.Name = "txtAplicYEnv_EQ"
        Me.txtAplicYEnv_EQ.Size = New System.Drawing.Size(100, 22)
        Me.txtAplicYEnv_EQ.TabIndex = 12
        Me.txtAplicYEnv_EQ.Text = "0"
        Me.txtAplicYEnv_EQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEnvEqPendxConfirmar
        '
        Me.txtEnvEqPendxConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnvEqPendxConfirmar.Location = New System.Drawing.Point(284, 101)
        Me.txtEnvEqPendxConfirmar.Name = "txtEnvEqPendxConfirmar"
        Me.txtEnvEqPendxConfirmar.Size = New System.Drawing.Size(100, 22)
        Me.txtEnvEqPendxConfirmar.TabIndex = 11
        Me.txtEnvEqPendxConfirmar.Text = "0"
        Me.txtEnvEqPendxConfirmar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPendientesxAplicar
        '
        Me.txtPendientesxAplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPendientesxAplicar.Location = New System.Drawing.Point(284, 62)
        Me.txtPendientesxAplicar.Name = "txtPendientesxAplicar"
        Me.txtPendientesxAplicar.Size = New System.Drawing.Size(100, 22)
        Me.txtPendientesxAplicar.TabIndex = 10
        Me.txtPendientesxAplicar.Text = "0"
        Me.txtPendientesxAplicar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPendxConfirmar
        '
        Me.txtPendxConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPendxConfirmar.Location = New System.Drawing.Point(284, 25)
        Me.txtPendxConfirmar.Name = "txtPendxConfirmar"
        Me.txtPendxConfirmar.Size = New System.Drawing.Size(100, 22)
        Me.txtPendxConfirmar.TabIndex = 9
        Me.txtPendxConfirmar.Text = "0"
        Me.txtPendxConfirmar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cmdSalir.Location = New System.Drawing.Point(663, 260)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(100, 35)
        Me.cmdSalir.TabIndex = 3
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = False
        '
        'frmMT103OrdPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 311)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMT103OrdPago"
        Me.Text = "Ordenes de Pago"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFechaFin As TextBox
    Friend WithEvents txtFechaIni As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdImprimir As Button
    Friend WithEvents cmdConsultar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RbTodas As RadioButton
    Friend WithEvents RbNoEnv As RadioButton
    Friend WithEvents RbEnv As RadioButton
    Friend WithEvents txtOperCanceladas As TextBox
    Friend WithEvents txtPendDetenidosSwift As TextBox
    Friend WithEvents txtAplicYEnv_EQ As TextBox
    Friend WithEvents txtEnvEqPendxConfirmar As TextBox
    Friend WithEvents txtPendientesxAplicar As TextBox
    Friend WithEvents txtPendxConfirmar As TextBox
    Friend WithEvents cmdSalir As Button
    Friend WithEvents lblOperCanceladas As Label
    Friend WithEvents lblPendDetenidosSwift As Label
    Friend WithEvents lblAplicYEnv_EQ As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
