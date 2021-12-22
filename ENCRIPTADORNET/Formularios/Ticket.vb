Imports System.Globalization
Imports System.Threading

Public Class funcionalidades

    Private Sub funcionalidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim l As New Libreria
        Me.WindowState = FormWindowState.Maximized
        Me.tsslUserConectado.Text = "Usuario: " & nameUser
        Me.tsslServerName.Text = "Servidor: " & l.Decrypt(l.SERVER)
        Me.tsslDatabase.Text = "BD: " & l.Decrypt(l.DB)
        Me.tsslFecha.Text = Date.Now().Date.ToString("yyyy-MMMM-dd")

        Call Prende()

        'Carga el arreglo de permisos y autorizaciones
        l.CargaPermisos()

        If usuario = 1 Or l.Permiso("PADMINISTRADOR") Then
            AdministradorToolStripMenuItem.Enabled = True
        Else
            AdministradorToolStripMenuItem.Enabled = False
        End If

        Relogin = False
    End Sub

    Private Sub AperturaDeCuentaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AperturaDeCuentaToolStripMenuItem1.Click
        Dim fAperturaCuenta As New AperturaCuenta
        Dim l As New Libreria
        If l.Permiso("PAPERTURA") Then
            'MsgBox("encontro permiso")
            fAperturaCuenta.ShowDialog()
        Else
            MsgBox("Sin permisos para este modulo")
        End If
        'fAperturaCuenta.ShowDialog()

    End Sub
    Private Sub MT103ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        'Dim fCapturaOpe As New CapturaOpe
        'fCapturaOpe.ShowDialog()
    End Sub

    Private Sub ComplementoDeAperturaDeCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComplementoDeAperturaDeCuentaToolStripMenuItem.Click
        Dim fCompAperturaCuenta As New CompApertura
        Dim l As New Libreria
        If l.Permiso("PAPERTURA") Then
            'MsgBox("encontro permiso")
            fCompAperturaCuenta.ShowDialog()
        Else
            MsgBox("Sin permisos para este modulo")
        End If
        'fCompAperturaCuenta.ShowDialog()
    End Sub

    Private Sub ValidarAperturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValidarAperturaToolStripMenuItem.Click
        Dim fValidaApertura As New ValidaApertura
        Dim l As New Libreria
        If l.Permiso("PVAPERTURA") Or l.Permiso("PRAPERTURA") Then
            'MsgBox("encontro permiso")
            fValidaApertura.ShowDialog()
        Else
            MsgBox("Sin permisos para este modulo")
        End If
        'fValidaApertura.ShowDialog()
    End Sub
    Private Sub funcionalidades_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    'Private Sub MT103ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles MT103ToolStripMenuItem3.Click
    '    RepTipoMT103 = 0
    '    'Dim RMT103 As New RepMt103Ticket
    '    Dim frmMT103OrdPago As New frmMT103OrdPago
    '    frmMT103OrdPago.ShowDialog()
    '    'RMT103.Size = New System.Drawing.Size(1200, 200)
    '    'RMT103.ShowDialog()
    'End Sub

    'Private Sub MT103CASHWINDOWSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MT103CASHWINDOWSToolStripMenuItem.Click
    '    RepTipoMT103 = 3
    '    Dim RMT103 As New RepMt103Ticket
    '    RMT103.Size = New System.Drawing.Size(1280, 200)
    '    RMT103.ShowDialog()
    'End Sub

    'Private Sub MT103PorUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MT103PorUsuarioToolStripMenuItem.Click
    '    RepTipoMT103 = 2
    '    Dim RMT103 As New RepMt103Ticket
    '    RMT103.Size = New System.Drawing.Size(1280, 200)
    '    RMT103.ShowDialog()
    'End Sub

    'Private Sub MT103CASHWINDOWSToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MT103CASHWINDOWSToolStripMenuItem1.Click
    '    RepTipoMT103 = 1
    '    Dim RMT103 As New RepMt103Ticket
    '    RMT103.Size = New System.Drawing.Size(1280, 200)
    '    RMT103.ShowDialog()
    'End Sub

    Private Sub BloqDesBloqToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BloqDesBloqToolStripMenuItem.Click
        Dim BloqueoDesbloqueoAlertamiento As New Bloqueo_DesbloqueoCtas
        Dim l As New Libreria
        If l.Permiso("PBLOQUEA") Then
            BloqueoDesbloqueoAlertamiento.ShowDialog()
        Else
            MsgBox("Sin permisos para este modulo")
        End If
    End Sub

    Private Sub AlertamientoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CancelacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelacionToolStripMenuItem.Click
        Dim CancelacionCtas As New CancelacionCtas
        Dim l As New Libreria
        If l.Permiso("PCANCELREACCTA") Then
            'MsgBox("encontro permiso")
            CancelacionCtas.ShowDialog()
        Else
            MsgBox("Sin permisos para este modulo")
        End If
    End Sub

    Private Sub ConsultaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem1.Click
        Dim ConsultaCTA As New ConsultaCTA
        ConsultaCTA.ShowDialog()
    End Sub

    Private Sub RptCtasNuevasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Dim frmRepAperturas As New frmRepAperturas
        'frmRepAperturas.ShowDialog()
    End Sub

    'Private Sub AperturasPorRangoDeFechaToolStripMenuItem_Click(sender As Object, e As EventArgs) 
    '    Dim frmAperturasxfecha As New frmAperturasXFecha
    '    frmAperturasxfecha.ShowDialog()
    'End Sub

    'Private Sub ConsolidadoDeAperturasValidadasConDetalleToolStripMenuItem_Click(sender As Object, e As EventArgs) 
    '    Dim frmAperturasDetalle As New frmAperturasDetalle
    '    frmAperturasDetalle.ShowDialog()
    'End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim Acercade As New Acercade
        Acercade.ShowDialog()
    End Sub

    Private Sub CuentasConDineroALaVistaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentasConDineroALaVistaToolStripMenuItem.Click
        Dim frmRepCtasDineroVista As New frmRepCtasDineroVista
        frmRepCtasDineroVista.ShowDialog()
    End Sub

    Private Sub OperacionesRelevantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperacionesRelevantesToolStripMenuItem.Click
        Dim frmRepOperRelev As New frmRepOperRelev
        frmRepOperRelev.ShowDialog()
    End Sub

    Private Sub TDDPosteoRechazadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TDDPosteoRechazadoToolStripMenuItem.Click
        Dim frmTDDPosteoRechazos As New frmTDDPosteoRechazos
        frmTDDPosteoRechazos.ShowDialog()
    End Sub

    Private Sub OperacionesPorUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperacionesPorUsuarioToolStripMenuItem.Click
        Dim frmRepOperUsuario As New frmRepOperUsuario
        frmRepOperUsuario.ShowDialog()
    End Sub

    Private Sub OperacionesNoValidadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperacionesNoValidadasToolStripMenuItem.Click
        Dim frmRepOperNOValidadas As New frmRepOperNOValidadas
        frmRepOperNOValidadas.ShowDialog()
    End Sub

    Private Sub AplicaciónContableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AplicaciónContableToolStripMenuItem.Click
        Dim frmRepAplicaContable As New frmRepAplicaContable
        frmRepAplicaContable.ShowDialog()
    End Sub

    Private Sub ReporteCtaCEDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteCtaCEDToolStripMenuItem.Click
        Dim frmRepAperturas As New frmRepAperturas
        frmRepAperturas.ShowDialog()
    End Sub

    Private Sub OrdenesDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenesDePagoToolStripMenuItem.Click
        Dim frmMT103OrdPago As New frmMT103OrdPago
        frmMT103OrdPago.ShowDialog()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Dim d As New Datasource
        Dim fTicketLogin As New funcionalidades
        Dim Login As New Login

        Relogin = True
        'Me.Hide()
        'De-registra al usuario de la base de datos
        'Call LogOff
        'Apagamos los puntos de menú que requieren permiso
        Call Apaga()

        'MUESTRA LA FORMA DE LOGIN
        Login.ShowDialog()

        If Relogin = False Then
            funcionalidades_Load(sender, e)
        End If
        'If d.LogOn Then
        'fTicketLogin.Show()
        'End If

    End Sub

    Private Sub Apaga()
        Me.AperturaDeCuentaToolStripMenuItem.Visible = False
        Me.OperacionesToolStripMenuItem.Visible = False
        Me.ReportesToolStripMenuItem.Visible = False
        Me.ChequerasToolStripMenuItem.Visible = False
        Me.MiscelaneaToolStripMenuItem1.Visible = False
    End Sub

    Private Sub Prende()
        Me.AperturaDeCuentaToolStripMenuItem.Visible = True
        Me.OperacionesToolStripMenuItem.Visible = True
        Me.ReportesToolStripMenuItem.Visible = True
        Me.ChequerasToolStripMenuItem.Visible = True
        Me.MiscelaneaToolStripMenuItem1.Visible = True
    End Sub

    Private Sub CuentasActivasOBloqueadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentasActivasOBloqueadasToolStripMenuItem.Click
        Dim frmCtasBloqAct As New frmCtasBloqAct
        frmCtasBloqAct.ShowDialog()
    End Sub

    Private Sub FuncionariosConOSinCuentaCEDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionariosConOSinCuentaCEDToolStripMenuItem.Click
        Dim frmFuncConSinCtaCED As New frmFuncConSinCtaCED
        frmFuncConSinCtaCED.ShowDialog()
    End Sub

    Private Sub ReporteMantenimientoDeCuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteMantenimientoDeCuentasToolStripMenuItem.Click
        Dim frmManntoCuentas As New frmManntoCuentas
        frmManntoCuentas.ShowDialog()
    End Sub

    Private Sub MantenimientoHorariosOperaciónCashToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoHorariosOperaciónCashToolStripMenuItem.Click
        Dim frmManttoParHor As New frmManttoParHor
        Dim l As New Libreria
        If l.Permiso("PMANTHORARIO") Then
            frmManttoParHor.MsTabla = "PARAMETROS_HORARIOS"
            frmManttoParHor.Text = "Mantenimiento de Horarios de Operación Cash"
            'MsgBox("encontro permiso")
            frmManttoParHor.ShowDialog()
        Else
            MsgBox("Sin permisos para este modulo")
        End If

    End Sub

    Private Sub MantenimientoHorariosOperaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoHorariosOperaciónToolStripMenuItem.Click
        Dim frmManttoParHor As New frmManttoParHor
        Dim l As New Libreria
        If l.Permiso("PMANTHORARIO") Then
            frmManttoParHor.MsTabla = "PARAMETROS_HORARIOS"
            frmManttoParHor.Text = "Mantenimiento de Horarios de Operación"
            'MsgBox("encontro permiso")
            frmManttoParHor.ShowDialog()
        Else
            MsgBox("Sin permisos para este modulo")
        End If

    End Sub

    Private Sub SaldosCuentasCEDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaldosCuentasCEDToolStripMenuItem.Click
        Dim frmCuentasSaldosSobregiros As New frmCuentasSaldosSobregiros
        frmCuentasSaldosSobregiros.ShowDialog()
    End Sub

    'Private Sub ConsultaPorClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaPorClienteToolStripMenuItem.Click
    '    Dim frmCuentasSaldosSobregiros As New frmCuentasSaldosSobregiros
    '    frmCuentasSaldosSobregiros.ShowDialog()
    'End Sub

    Private Sub ChequeraNormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChequeraNormalToolStripMenuItem.Click
        Dim frmSolicitudChequeraNormal As New frmSolicitudChequeraNormal
        frmSolicitudChequeraNormal.ShowDialog()
    End Sub

    Private Sub ChequeraEspecialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChequeraEspecialToolStripMenuItem.Click
        Dim frmSolicitudChequeraEspecial As New frmSolicitudChequeraEspecial
        frmSolicitudChequeraEspecial.ShowDialog()
    End Sub

    Private Sub PendientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PendientesToolStripMenuItem.Click
        Dim frmConsulCHQApertura As New frmConsulCHQApertura
        frmConsulCHQApertura.ShowDialog()
    End Sub

    Private Sub PorCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorCuentaToolStripMenuItem.Click
        Dim frmConsChqCta As New frmConsChqCta
        frmConsChqCta.Tipo(1)
    End Sub

    Private Sub PorRangoDeFechasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorRangoDeFechasToolStripMenuItem.Click
        Dim frmConsChqCta As New frmConsChqCta
        frmConsChqCta.Tipo(3)
    End Sub

    Private Sub CancelaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelaciónToolStripMenuItem.Click
        Dim frmCancelarCHQ As New frmCancelarCHQ
        frmCancelarCHQ.ShowDialog()
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        Dim frmConsCte As New frmConsCte
        frmConsCte.ShowDialog()
    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click

    End Sub

    Private Sub DocumentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentoToolStripMenuItem.Click
        Dim frmConsulta As New frmConsulta
        frmConsulta.Fuente(0, "")
    End Sub

    Private Sub DocumentosDeSucursalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentosDeSucursalToolStripMenuItem.Click
        Dim frmCaptura As New frmCaptura
        frmCaptura.ShowDialog()
        ' If VerificarHrValida(1) = True Then frmCaptura.Show
    End Sub

    Private Sub TraspasosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frmCapturaTraspaso As New frmCapturaTraspaso
        frmCapturaTraspaso.ShowDialog()
        ' If VerificarHrValida(3) = True Then frmCapturaTrasp.Show
    End Sub

    Private Sub TicketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TicketToolStripMenuItem.Click
        Dim frmConsulta As New frmConsulta
        frmConsulta.Fuente(1, "")
    End Sub

    Private Sub ReporteDeOperacionesDiariasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeOperacionesDiariasToolStripMenuItem.Click
        Dim frmRepOpesDiarias As New frmRepOpesDiarias
        frmRepOpesDiarias.ShowDialog()
    End Sub
    Private Sub BloqueoDesloqueoTDsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BloqueoDesloqueoTDsToolStripMenuItem.Click
        ConfReg()
        Dim frmBloqueoTD As New frmBloqueoTD
        frmBloqueoTD.ShowDialog()
    End Sub

    Private Sub CancelacionTDsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelacionTDsToolStripMenuItem.Click
        Dim frmCancelaTD As New frmCancelaTD
        frmCancelaTD.ShowDialog()
    End Sub
    Private Sub GeneraciónArchivoInterfaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneraciónArchivoInterfaseToolStripMenuItem.Click
        ConfReg()
        Dim GeneraPrinterChq As New frmGeneraPrinterChq
        GeneraPrinterChq.StartPosition = FormStartPosition.CenterScreen
        GeneraPrinterChq.ShowDialog()
    End Sub

    Private Sub ReimpresionMT198ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReimpresionMT198ToolStripMenuItem.Click
        ConfReg()
        Dim ReimpRepMT198 As New frmReimpRepMT198
        ReimpRepMT198.StartPosition = FormStartPosition.CenterScreen
        ReimpRepMT198.ShowDialog()
    End Sub

    Private Sub SalvoBuenFinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalvoBuenFinToolStripMenuItem.Click
        ConfReg()
        Dim frmSalBuFin As New frmOperacReport
        frmSalBuFin.StartPosition = FormStartPosition.CenterScreen
        frmSalBuFin.Reporte(5)
        'frmSalBuFin.ShowDialog()
    End Sub

    Private Sub TitularesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TitularesToolStripMenuItem.Click
        ConfReg()
        Dim OFAC As New frmRepOFAC
        OFAC.StartPosition = FormStartPosition.CenterScreen
        OFAC.Reporte(0)
    End Sub

    Private Sub CotitularesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CotitularesToolStripMenuItem.Click
        ConfReg()
        Dim OFAC As New frmRepOFAC
        OFAC.StartPosition = FormStartPosition.CenterScreen
        OFAC.Reporte(2)
    End Sub

    Private Sub BeneficiariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeneficiariosToolStripMenuItem.Click
        ConfReg()
        Dim OFAC As New frmRepOFAC
        OFAC.StartPosition = FormStartPosition.CenterScreen
        OFAC.Reporte(1)
    End Sub

    Private Sub AutorizadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutorizadosToolStripMenuItem.Click
        ConfReg()
        Dim OFAC As New frmRepOFAC
        OFAC.StartPosition = FormStartPosition.CenterScreen
        OFAC.Reporte(3)
    End Sub

    Private Sub TitularesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TitularesToolStripMenuItem1.Click
        ConfReg()
        Dim OFAC As New frmRepOFAC
        OFAC.StartPosition = FormStartPosition.CenterScreen
        OFAC.Reporte(4)
    End Sub

    Private Sub ApoderadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApoderadosToolStripMenuItem.Click
        ConfReg()
        Dim OFAC As New frmRepOFAC
        OFAC.StartPosition = FormStartPosition.CenterScreen
        OFAC.Reporte(5)
    End Sub

    Private Sub AutorizadosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AutorizadosToolStripMenuItem1.Click
        ConfReg()
        Dim OFAC As New frmRepOFAC
        OFAC.StartPosition = FormStartPosition.CenterScreen
        OFAC.Reporte(6)
    End Sub

    Private Sub TitularesToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles TitularesToolStripMenuItem2.Click
        ConfReg()
        Dim OFAC As New frmRepOFAC
        OFAC.StartPosition = FormStartPosition.CenterScreen
        OFAC.Reporte(7)
    End Sub

    Private Sub CotitularesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CotitularesToolStripMenuItem1.Click
        ConfReg()
        Dim OFAC As New frmRepOFAC
        OFAC.StartPosition = FormStartPosition.CenterScreen
        OFAC.Reporte(9)
    End Sub

    Private Sub BeneficiariosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BeneficiariosToolStripMenuItem1.Click
        ConfReg()
        Dim OFAC As New frmRepOFAC
        OFAC.StartPosition = FormStartPosition.CenterScreen
        OFAC.Reporte(8)
    End Sub

    Private Sub AutorizadosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AutorizadosToolStripMenuItem2.Click
        ConfReg()
        Dim OFAC As New frmRepOFAC
        OFAC.StartPosition = FormStartPosition.CenterScreen
        OFAC.Reporte(10)
    End Sub

    Private Sub TitularesToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles TitularesToolStripMenuItem3.Click
        ConfReg()
        Dim OFAC As New frmRepOFAC
        OFAC.StartPosition = FormStartPosition.CenterScreen
        OFAC.Reporte(11)
    End Sub

    Private Sub ApoderadosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ApoderadosToolStripMenuItem1.Click
        ConfReg()
        Dim OFAC As New frmRepOFAC
        OFAC.StartPosition = FormStartPosition.CenterScreen
        OFAC.Reporte(12)
    End Sub

    Private Sub AutorizadosToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles AutorizadosToolStripMenuItem3.Click
        ConfReg()
        Dim OFAC As New frmRepOFAC
        OFAC.StartPosition = FormStartPosition.CenterScreen
        OFAC.Reporte(13)
    End Sub

    Private Sub IntegradasEnSaldosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntegradasEnSaldosToolStripMenuItem.Click
        ConfReg()
        Dim IntegradasSaldos As New frmRepAgencias
        IntegradasSaldos.StartPosition = FormStartPosition.CenterScreen
        IntegradasSaldos.ReporteAgencias(10)
    End Sub

    Private Sub ComprasDeTimeDepositToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasDeTimeDepositToolStripMenuItem.Click
        ConfReg()
        GsRepTDOver = "Normal"
        Dim IntegradasSaldos As New frmOperacReport
        IntegradasSaldos.StartPosition = FormStartPosition.CenterScreen
        IntegradasSaldos.Reporte(7)
    End Sub
    Private Sub VencimientoDeTDsPorDíaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VencimientoDeTDsPorDíaToolStripMenuItem.Click
        ConfReg()
        Dim VenTdsDia As New frmVencimientosTD
        VenTdsDia.StartPosition = FormStartPosition.CenterScreen
        VenTdsDia.Show()
    End Sub
    Private Sub ReenvioDeTicketsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReenvioDeTicketsToolStripMenuItem.Click
        Dim objLibreria As New Libreria
        Dim ReenvioTicket As New frmReenvioTicket
        If objLibreria.Permiso("PREENVIO") Then
            ConfReg()
            ReenvioTicket.StartPosition = FormStartPosition.CenterScreen
            ReenvioTicket.Show()
        Else
            MsgBox("Sin permisos para este modulo")
        End If
    End Sub
    Private Sub MantenimientoDeCuentaCEDToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles MantenimientoDeCuentaCEDToolStripMenuItem1.Click
        Dim frmManntoCuenta As New frmManntoCuenta
        Dim l As New Libreria
        If l.Permiso("PMANTCUENTAS") Then
            'MsgBox("encontro permiso")
            frmManntoCuenta.ShowDialog()
        Else
            MsgBox("Sin permisos para este modulo")
        End If
    End Sub
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        ConfReg()
        Dim frmSalBuFin As New frmOperacReport
        frmSalBuFin.StartPosition = FormStartPosition.CenterScreen
        frmSalBuFin.Reporte(6)
    End Sub
    Private Sub BloqueosTDs_Click(sender As Object, e As EventArgs) Handles BloqueosTDs.Click
        ConfReg()
        Dim frmBloqueoTDs As New frmReporte_BloqueoTD
        frmBloqueoTDs.StartPosition = FormStartPosition.CenterScreen
        frmBloqueoTDs.Show()
    End Sub
    Private Sub DetalleDepositosSucursal_Click(sender As Object, e As EventArgs) Handles DetalleDepositosSucursal.Click
        ConfReg()
        Dim IntegradasSaldos As New frmRepAgencias
        IntegradasSaldos.StartPosition = FormStartPosition.CenterScreen
        IntegradasSaldos.ReporteAgencias(8)
    End Sub

    Private Sub DetalleRetirosSucursal_Click(sender As Object, e As EventArgs) Handles DetalleRetirosSucursal.Click
        ConfReg()
        Dim IntegradasSaldos As New frmRepAgencias
        IntegradasSaldos.StartPosition = FormStartPosition.CenterScreen
        IntegradasSaldos.ReporteAgencias(20)
    End Sub
    Private Sub PermisosPorUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermisosPorUsuario.Click
        Dim l As New Libreria
        Dim rptDoc As New ReportDocument
        Dim lsReporte As String = ""
        Dim lsRutaFolder As String = ""
        Dim lsAmbiente As String = ""
        Dim objLibreria As New Libreria
        Dim objModPermisos As modPermisos = New modPermisos()
        ConfReg()
        If l.Permiso("PADMINISTRADOR") Then
            lsRutaFolder = My.Application.Info.DirectoryPath & "\" & objLibreria.sFolderRPT & "\"
            lsReporte = lsRutaFolder & "PermisosUsuario" & lsAmbiente & ".rpt"
            rptDoc.Load(lsReporte, CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            objModPermisos.ImprimePermisos("Ticket Complementario", rptDoc)
        Else
            MsgBox("Sin permisos para este modulo")
        End If
    End Sub
    Private Sub BitacoraAdministrador_Click(sender As Object, e As EventArgs) Handles BitacoraAdministrador.Click
        Dim l As New Libreria
        Dim rptDoc As New ReportDocument
        Dim lsReporte As String = ""
        Dim lsRutaFolder As String = ""
        Dim lsAmbiente As String = ""
        Dim objLibreria As New Libreria
        ConfReg()
        If l.Permiso("PADMINISTRADOR") Then
            lsRutaFolder = My.Application.Info.DirectoryPath & "\" & objLibreria.sFolderRPT & "\"
            lsReporte = lsRutaFolder & "PermisosBitacora" & lsAmbiente & ".rpt"
            rptDoc.Load(lsReporte, CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            Dim BitacoraPermisos As New frmBitacoraPermisos(rptDoc)
            BitacoraPermisos.StartPosition = FormStartPosition.CenterScreen
            BitacoraPermisos.Show()
        Else
            MsgBox("Sin permisos para este modulo")
        End If
    End Sub
    Private Sub ReporteXUsuarioGestores_Click(sender As Object, e As EventArgs) Handles ReporteXUsuarioGestores.Click
        Dim objModPermisos As modPermisos = New modPermisos()
        Dim rptDoc As New ReportDocument
        Dim lsReporte As String = ""
        Dim lsRutaFolder As String = ""
        Dim lsAmbiente As String = ""
        Dim objLibreria As New Libreria
        ConfReg()
        lsRutaFolder = My.Application.Info.DirectoryPath & "\" & objLibreria.sFolderRPT & "\"
        lsReporte = lsRutaFolder & "Funcs_PermisosUsr" & lsAmbiente & ".rpt"
        rptDoc.Load(lsReporte, CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
        objModPermisos.GesImprimePermisos("Administración de Gestores", rptDoc)
    End Sub
    Private Sub AsignarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignarToolStripMenuItem.Click
        Dim l As New Libreria
        ConfReg()
        If usuario = 1 Or l.Permiso("PADMINISTRADOR") Then
            Dim FormAsigna As New frmPerfilAsigna
            FormAsigna.StartPosition = FormStartPosition.CenterScreen
            FormAsigna.Show()
        Else
            MsgBox("Sin permisos para este modulo")
        End If
    End Sub
    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Dim l As New Libreria
        ConfReg()
        If usuario = 1 Or l.Permiso("PADMINISTRADOR") Then
            Dim FormEdita As New frmPerfilEdita
            FormEdita.StartPosition = FormStartPosition.CenterScreen
            FormEdita.Show()
        Else
            MsgBox("Sin permisos para este modulo")
        End If
    End Sub
    Private Sub CambiarContraseñaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarContraseñaToolStripMenuItem.Click
        Dim VistaMantPasswd As New MantPasswd
        ConfReg()
        VistaMantPasswd.StartPosition = FormStartPosition.CenterScreen
        VistaMantPasswd.Show()
    End Sub
    Private Sub MantenimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoToolStripMenuItem.Click
        Dim VistaMantenimientoUsuario As New frmMantUsr
        ConfReg()
        VistaMantenimientoUsuario.StartPosition = FormStartPosition.CenterScreen
        VistaMantenimientoUsuario.Show()
    End Sub
    Private Sub ConfReg()
        Dim objLibreria As New Libreria
        Dim objDatasource As New Datasource
        Dim dtRespConsulta As DataTable
        Dim drRegistro As DataRow
        Dim culture As String = ""
        dtRespConsulta = objDatasource.RealizaConsulta("select convert(Char(10), fecha_sistema, 101) from PARAMETROS")
        drRegistro = dtRespConsulta.Rows(0)
        gs_FechaHoy = drRegistro.Item(0).ToString
        If Thread.CurrentThread.CurrentCulture.Name = "en-US" Then
            culture = "en-US"
        ElseIf Thread.CurrentThread.CurrentCulture.Name = "es-MX" Then
            culture = "en-US"
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(culture)
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(culture)
            gs_FechaHoy = (CDate(gs_FechaHoy).Day).ToString.PadLeft(2, "0") & "-" & (CDate(gs_FechaHoy).Month).ToString.PadLeft(2, "0") & "-" & CDate(gs_FechaHoy).Year
            culture = "es-MX"
        End If
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(culture)
        Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(culture)
        dtRespConsulta = objDatasource.RealizaConsulta("SELECT convert(char(5),getdate(),14)")
        drRegistro = dtRespConsulta.Rows(0)
        gs_HoraSistema = drRegistro.Item(0).ToString
    End Sub
End Class