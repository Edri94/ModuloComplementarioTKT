Public Class frmBitacoraPermisos
    Private objDataSourse As New Datasource
    Private rptRep As ReportDocument
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(rptDoc As ReportDocument)
        Me.New()
        rptRep = rptDoc
    End Sub
    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        If MsgBox("¿Desea salir?", vbYesNo + vbQuestion, "Salir de Bitácora Administrador") <> vbYes Then Exit Sub
        Me.Close()
    End Sub
    Private Sub frmBitacoraPermisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsuario.Text = ""
        LlenaListaUsuarios()
        cmbUsuarios.SelectedIndex = 0
    End Sub
    '-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
    ' Llena la lista de Usuarios disponibles por Base de Datos
    '-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
    Public Sub LlenaListaUsuarios()
        Dim ls_sql As String
        Dim dtListaUsuario As DataTable

        cmbUsuarios.Items.Clear()
        ls_sql = "select 0 As usuario,'-- Todos los usuarios --' As login union "
        ls_sql = ls_sql & "select usuario, login from " & "CATALOGOS" & ".dbo." & "USUARIO"
        'Requerimiento 27 permitir reactivación de Anulados y Bloqueados.
        If StrComp(Me.Name, "frmMantUsuario", vbTextCompare) <> 0 Then
            ls_sql = ls_sql & " where password Not In ('ANULADO','BLOQUEAR') "
        End If
        ls_sql = ls_sql & " order by login"
        dtListaUsuario = objDataSourse.RealizaConsulta(ls_sql)
        cmbUsuarios.Visible = True
        cmbUsuarios.DisplayMember = "login"
        cmbUsuarios.ValueMember = "usuario"
        cmbUsuarios.DataSource = dtListaUsuario
    End Sub

    Private Sub cmdImprime_Click(sender As Object, e As EventArgs) Handles cmdImprime.Click
        Dim objModPermisos As modPermisos = New modPermisos()
        If dtpFechaInicio.Value > dtpFechaFin.Value Then
            MsgBox("La fecha final debe ser mayor o igual a la fecha incial.", vbInformation, "Fecha Invalida")
            dtpFechaFin.Focus()
            Exit Sub
        End If
        objModPermisos.ImprimeBitacora(cmbUsuarios.SelectedValue, dtpFechaInicio.Value, dtpFechaFin.Value, "Mesa y Middle Agencias", rptRep)
    End Sub

    Private Sub cmbUsuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUsuarios.SelectedIndexChanged
        If cmbUsuarios.SelectedIndex = 0 Then
            lblUsuario.Text = "Todos los usuarios..."
        Else
            lblUsuario.Text = "Busqueda para: " & cmbUsuarios.Text
        End If
    End Sub
End Class