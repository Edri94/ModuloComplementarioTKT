Imports System
Imports System.IO

Public Class frmRepOpesDiarias

    Dim iRegistrosD As Integer = 0
    Dim iRegistrosR As Integer = 0
    Dim iRegistrosT As Integer = 0
    Dim l As New Libreria



    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click

        Cursor = System.Windows.Forms.Cursors.WaitCursor
        If ValidaDatos() Then
            If Not LlenaGridOpesDiarias() Then
                cmdExportar.Enabled = False
            Else
                'activa boton de imprimir
                cmdExportar.Enabled = True
            End If
        End If
        Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Function ValidaDatos() As Boolean

        ValidaDatos = False

        If Trim(mtxtFechaIni.Text) = "" Then
            MsgBox("Es necesario indicar una fecha de captura inicial.", MsgBoxStyle.Information, "Fecha Faltante")
            mtxtFechaIni.Select()
            Exit Function
        End If
        If Trim(mtxtFechaFin.Text) = "" Then
            MsgBox("Es necesario indicar una fecha de captura final.", MsgBoxStyle.Information, "Fecha Faltante")
            mtxtFechaFin.Select()
            Exit Function
        End If

        If Convert.ToDateTime(mtxtFechaIni.Text) > Convert.ToDateTime(mtxtFechaFin.Text) Then
            MsgBox("La fecha final del periodo debe ser mayor o igual a la fecha inicial.", MsgBoxStyle.Information, "Fecha Invalida")
            mtxtFechaFin.Select()
            Exit Function
        End If

        ValidaDatos = True

    End Function

    Function LlenaGridOpesDiarias() As Boolean
        Dim gs_sql As String
        Dim d As New Datasource
        Dim dt As New DataTable

        LlenaGridOpesDiarias = False

        If buscaOpesDiarias() Then


            'arma el query para presentar en el grid
            gs_sql = " Select AGENCIA.prefijo_agencia ,PRODUCTO_CONTRATADO.cuenta_cliente,TIPO_CUENTA_EJE.sufijo_kapiti, " &
                        "OPERACION.operacion , OPERACION.monto_operacion, OPERACION.fecha_captura, OPERACION.fecha_operacion, " &
                        "OPERACION_DEFINIDA.descripcion_operacion_definida, DEPOSITO_PME.referencia, DEPOSITO_PME.sucursal As sucope, " &
                        "DEPOSITO_PME.nombre_sucursal,TIPO_DOCUMENTO.descripcion_documento, DOCGOS.documento as DocAICED " &
                        "FROM(((((((Ticket.dbo.PRODUCTO_CONTRATADO   PRODUCTO_CONTRATADO  INNER JOIN  TICKET.dbo.OPERACION   OPERACION  ON   " &
                        "PRODUCTO_CONTRATADO.producto_contratado = OPERACION.producto_contratado ) INNER JOIN  TICKET.dbo.CUENTA_EJE   CUENTA_EJE  On  " &
                        "PRODUCTO_CONTRATADO.producto_contratado = CUENTA_EJE.producto_contratado ) INNER JOIN  CATALOGOS.dbo.AGENCIA   AGENCIA  On   " &
                        "PRODUCTO_CONTRATADO.agencia = AGENCIA.agencia ) INNER JOIN  TICKET.dbo.TIPO_CUENTA_EJE   TIPO_CUENTA_EJE  On  " &
                        "CUENTA_EJE.tipo_cuenta_eje = TIPO_CUENTA_EJE.tipo_cuenta_eje ) INNER JOIN  TICKET.dbo.DEPOSITO_PME   DEPOSITO_PME  On   " &
                        "OPERACION.operacion = DEPOSITO_PME.operacion ) INNER JOIN  TICKET.dbo.DEPOSITO   DEPOSITO  On  " &
                        "( OPERACION.operacion = DEPOSITO.operacion ) And ( DEPOSITO_PME.operacion = DEPOSITO.operacion )) INNER JOIN  TICKET.dbo.OPERACION_DEFINIDA   OPERACION_DEFINIDA  ON  " &
                        "( OPERACION.operacion_definida = OPERACION_DEFINIDA.operacion_definida ) And ( AGENCIA.agencia = OPERACION_DEFINIDA.agencia )) LEFT OUTER JOIN  TICKET.dbo.TIPO_DOCUMENTO   TIPO_DOCUMENTO  ON   " &
                        "DEPOSITO.tipo_documento = TIPO_DOCUMENTO.tipo_documento  "
            'Colocaremos el join para el documento de AICED
            gs_sql = gs_sql + "LEFT OUTER JOIN GOS.dbo.DOCUMENTO DOCGOS ON OPERACION.operacion = DOCGOS.ticket " &
                        "WHERE OPERACION.fecha_captura >= '" + l.InvierteFecha(mtxtFechaIni.Text) & " 00:00AM'" &
                        " and OPERACION.fecha_captura <= '" + l.InvierteFecha(mtxtFechaFin.Text) & " 23:59PM' " &
                        "union  " &
                        "Select AGENCIA.prefijo_agencia,PRODUCTO_CONTRATADO.cuenta_cliente ,  TIPO_CUENTA_EJE.sufijo_kapiti , " &
                        "OPERACION.operacion , OPERACION.monto_operacion, OPERACION.fecha_captura, OPERACION.fecha_operacion, " &
                        "OPERACION_DEFINIDA.descripcion_operacion_definida, RETIRO_PME.referencia, RETIRO_PME.sucursal  As sucope, " &
                        "RETIRO_PME.nombre_sucursal,TIPO_DOCUMENTO.descripcion_documento, DOCGOS.documento as DocAICED  " &
                        "FROM((((((CATALOGOS.dbo.AGENCIA   AGENCIA  INNER JOIN  TICKET.dbo.PRODUCTO_CONTRATADO   PRODUCTO_CONTRATADO  ON  " &
                        "AGENCIA.agencia = PRODUCTO_CONTRATADO.agencia ) INNER JOIN  TICKET.dbo.OPERACION   OPERACION  On  " &
                        "PRODUCTO_CONTRATADO.producto_contratado = OPERACION.producto_contratado ) INNER JOIN  TICKET.dbo.CUENTA_EJE   CUENTA_EJE  On  " &
                        "PRODUCTO_CONTRATADO.producto_contratado = CUENTA_EJE.producto_contratado ) INNER JOIN  TICKET.dbo.TIPO_CUENTA_EJE   TIPO_CUENTA_EJE  On  " &
                        "CUENTA_EJE.tipo_cuenta_eje = TIPO_CUENTA_EJE.tipo_cuenta_eje ) INNER JOIN  TICKET.dbo.RETIRO_PME   RETIRO_PME  On  " &
                        "OPERACION.operacion = RETIRO_PME.operacion ) INNER JOIN  TICKET.dbo.OPERACION_DEFINIDA   OPERACION_DEFINIDA  On  " &
                        "OPERACION.operacion_definida = OPERACION_DEFINIDA.operacion_definida ) LEFT OUTER JOIN  TICKET.dbo.TIPO_DOCUMENTO   TIPO_DOCUMENTO  On  " &
                        "RETIRO_PME.tipo_documento = TIPO_DOCUMENTO.tipo_documento "
            'Colocaremos el join para el documento de AICED
            gs_sql = gs_sql + "LEFT OUTER JOIN GOS.dbo.DOCUMENTO DOCGOS ON OPERACION.operacion = DOCGOS.ticket " &
                        "WHERE OPERACION.fecha_captura >= '" + l.InvierteFecha(mtxtFechaIni.Text) & " 00:00AM'" &
                        " and OPERACION.fecha_captura <= '" + l.InvierteFecha(mtxtFechaFin.Text) & " 23:59PM' " &
                        " ORDER BY sucope"

            'MsgBox(gs_sql)

            dt = d.RealizaConsulta(gs_sql)
            If dt.Rows.Count > 0 Then

                dgvOpesDiarias.DataSource = dt

                dgvOpesDiarias.Columns(0).HeaderText = "Agencia"
                dgvOpesDiarias.Columns(1).HeaderText = "Cuenta"
                dgvOpesDiarias.Columns(2).HeaderText = "Sufijo"
                dgvOpesDiarias.Columns(3).HeaderText = "Ticket"
                dgvOpesDiarias.Columns(4).HeaderText = "Monto"
                dgvOpesDiarias.Columns(5).HeaderText = "Fecha Captura"
                dgvOpesDiarias.Columns(6).HeaderText = "Fecha Operación"
                dgvOpesDiarias.Columns(7).HeaderText = "Descripción"
                dgvOpesDiarias.Columns(8).HeaderText = "Ficha CED"
                dgvOpesDiarias.Columns(9).HeaderText = "C. Costos"
                dgvOpesDiarias.Columns(10).HeaderText = "Sucursal"
                dgvOpesDiarias.Columns(11).HeaderText = "Documento"
                dgvOpesDiarias.Columns(12).HeaderText = "Núm. de Docto. AICED"


                dgvOpesDiarias.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvOpesDiarias.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvOpesDiarias.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvOpesDiarias.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvOpesDiarias.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvOpesDiarias.Columns(4).DefaultCellStyle.Format = "c"
                dgvOpesDiarias.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvOpesDiarias.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvOpesDiarias.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvOpesDiarias.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvOpesDiarias.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvOpesDiarias.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvOpesDiarias.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvOpesDiarias.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                cmdExportar.Enabled = True

            Else
                'dgvOpesDiarias.DataSource = dt
                'lblStatus.Text = "Sin solicitudes en la lista..."
                'cmdImprimir.Enabled = True
                cmdExportar.Enabled = False

            End If


        Else
            LlenaGridOpesDiarias = False
        End If



        LlenaGridOpesDiarias = True
    End Function


    Function buscaOpesDiarias() As Boolean
        Dim gs_sql As String
        Dim d As New Datasource
        Dim dctas = New Datasource
        iRegistrosD = 0
        iRegistrosR = 0
        iRegistrosT = 0

        buscaOpesDiarias = False

        'busca depositos
        gs_sql = "Select  count(*) " &
                 "FROM(((((((Ticket.dbo.PRODUCTO_CONTRATADO   PRODUCTO_CONTRATADO  INNER JOIN  TICKET.dbo.OPERACION   OPERACION  On   " &
                 "PRODUCTO_CONTRATADO.producto_contratado = OPERACION.producto_contratado ) INNER JOIN  TICKET.dbo.CUENTA_EJE   CUENTA_EJE  On  " &
                 "PRODUCTO_CONTRATADO.producto_contratado = CUENTA_EJE.producto_contratado ) INNER JOIN  CATALOGOS.dbo.AGENCIA   AGENCIA  On   " &
                 "PRODUCTO_CONTRATADO.agencia = AGENCIA.agencia ) INNER JOIN  TICKET.dbo.TIPO_CUENTA_EJE   TIPO_CUENTA_EJE  On   " &
                 "CUENTA_EJE.tipo_cuenta_eje = TIPO_CUENTA_EJE.tipo_cuenta_eje ) INNER JOIN  TICKET.dbo.DEPOSITO_PME   DEPOSITO_PME  On  " &
                 "OPERACION.operacion = DEPOSITO_PME.operacion ) INNER JOIN  TICKET.dbo.DEPOSITO   DEPOSITO  On  " &
                 "( OPERACION.operacion = DEPOSITO.operacion ) And ( DEPOSITO_PME.operacion = DEPOSITO.operacion )) INNER JOIN  TICKET.dbo.OPERACION_DEFINIDA   OPERACION_DEFINIDA  On  " &
                 "( OPERACION.operacion_definida = OPERACION_DEFINIDA.operacion_definida ) And ( AGENCIA.agencia = OPERACION_DEFINIDA.agencia )) LEFT OUTER JOIN  TICKET.dbo.TIPO_DOCUMENTO   TIPO_DOCUMENTO  On   " &
                 "DEPOSITO.tipo_documento = TIPO_DOCUMENTO.tipo_documento " &
                 "WHERE OPERACION.fecha_captura >= '" + l.InvierteFecha(mtxtFechaIni.Text) & " 00:00AM'" &
                 " and OPERACION.fecha_captura <= '" + l.InvierteFecha(mtxtFechaFin.Text) & " 23:59PM'"


        'MsgBox(gs_sql)
        iRegistrosD = d.HayRegistros(gs_sql)

        'MsgBox("cuantos " + iRegistrosD.ToString())

        'busca retiros
        gs_sql = "Select count(*) " &
                "FROM((((((CATALOGOS.dbo.AGENCIA AGENCIA INNER JOIN TICKET.dbo.PRODUCTO_CONTRATADO PRODUCTO_CONTRATADO ON  " &
                "AGENCIA.agencia=PRODUCTO_CONTRATADO.agencia) INNER JOIN TICKET.dbo.OPERACION OPERACION ON  " &
                "PRODUCTO_CONTRATADO.producto_contratado = OPERACION.producto_contratado) INNER JOIN TICKET.dbo.cUENTA_EJE cUENTA_EJE On  " &
                "PRODUCTO_CONTRATADO.producto_contratado=CUENTA_EJE.producto_contratado) INNER JOIN TICKET.dbo.TIPO_CUENTA_EJE TIPO_CUENTA_EJE ON  " &
                "CUENTA_EJE.tipo_cuenta_eje=TIPO_CUENTA_EJE.tipo_cuenta_eje) INNER JOIN TICKET.dbo.RETIRO_PME RETIRO_PME ON  " &
                "OPERACION.operacion=RETIRO_PME.operacion) INNER JOIN TICKET.dbo.OPERACION_DEFINIDA OPERACION_DEFINIDA ON  " &
                "OPERACION.operacion_definida=OPERACION_DEFINIDA.operacion_definida) LEFT OUTER JOIN TICKET.dbo.TIPO_DOCUMENTO TIPO_DOCUMENTO ON  " &
                "RETIRO_PME.tipo_documento=TIPO_DOCUMENTO.tipo_documento " &
                "WHERE OPERACION.fecha_captura >= '" + l.InvierteFecha(mtxtFechaIni.Text) & " 00:00AM'" &
                " and OPERACION.fecha_captura <= '" + l.InvierteFecha(mtxtFechaFin.Text) & " 23:59PM'"

        iRegistrosR = d.HayRegistros(gs_sql)
        'suma depositos y retiros.
        iRegistrosT = iRegistrosD + iRegistrosR
        If (iRegistrosT) > 0 Then

            buscaOpesDiarias = True
            lblTotal.Text = "Total de registros " + iRegistrosT.ToString()
        Else
            MsgBox("No existen operaciones con los parametros indicados", MsgBoxStyle.Information, "Sin Operaciones Relevantes")
        End If


    End Function

    Private Sub monthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs)
        'Show the start And end dates in the text box.
        'txtRangoFechas.Text = "Date Changed: Start =  " +
        mtxtFechaIni.Text = e.Start.ToShortDateString()
        mtxtFechaFin.Text = e.End.ToShortDateString()
    End Sub

    Private Sub frmRepOpesDiarias_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToParent()
        'MonthCalendar1.SelectionRange = New SelectionRange(DateTime.Today, DateTime.Today)
        'dgvChequeras.ReadOnly = False
        'dgvChequeras.ScrollBars.Both
    End Sub




    'Creamos función para la exportación del Reporte a CSV
    Public Function GetMyCSVFile(ByVal Datagrid As DataGridView)
        ' botón para recorrer el datagridView y guardarlo en el archivo

        Const DELIMITADOR As String = ”,”
        Dim ThisMoment As Date

        ' Ruta del fichero de texto agregando la fecha y la hora para la distintas exportaciones que se hagan a lo largo del día
        Dim fechaHora As String = DateTime.Now.ToString("dd-MM-yyyy H-mm-ss")
        Dim fileName As String = String.Format(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + “\ReporteConciliacionAICED-{0}.csv", fechaHora)

        Dim ARCHIVO_CSV As String = fileName

        Try
            'Nuevo objeto StreamWriter, para acceder al fichero y poder guardar las líneas
            Using archivo As StreamWriter = New StreamWriter(ARCHIVO_CSV)

                ' variable para almacenar la línea actual del dataview
                Dim linea As String = String.Empty

                With Datagrid
                    'Ingresamos los encabezados para el archivo
                    archivo.WriteLine("Agencia,Cuenta,Sufijo,Ticket,Monto,Fecha Captura,Fecha Operacion,Descripcion,FichaCED,CCostos,Sucursal,Documento,Num. de Docto. AICED")
                    ' Recorrer las filas del dataGridView
                    For fila As Integer = 0 To .RowCount - 1
                        ' vaciar la línea
                        linea = String.Empty

                        ' Recorrer la cantidad de columnas que contiene el dataGridView
                        For col As Integer = 0 To .Columns.Count - 1
                            ' Almacenar el valor de toda la fila , y cada campo separado por el delimitador
                            linea = linea & .Item(col, fila).Value.ToString & DELIMITADOR
                        Next

                        ' Escribir una línea con el método WriteLine
                        With archivo
                            ' eliminar el último caracter “;” de la cadena
                            linea = linea.Remove(linea.Length - 1).ToString
                            ' escribir la fila
                            .WriteLine(linea.ToString)
                        End With
                    Next
                End With
            End Using

            ' Abrir con Process.Start el archivo de texto
            Process.Start(ARCHIVO_CSV)
            'error
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
        Return True
    End Function

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdExportar_Click(sender As Object, e As EventArgs) Handles cmdExportar.Click
        GetMyCSVFile(dgvOpesDiarias)
    End Sub

    Private Sub mtxtFechaIni_KeyDown(sender As Object, e As KeyEventArgs) Handles mtxtFechaIni.KeyDown
        dgvOpesDiarias.DataSource = Nothing
        mtxtFechaFin.Text = ""
        cmdExportar.Enabled = False
        lblTotal.Text = ""
    End Sub
End Class