Imports Clases
Imports DevExpress.XtraEditors
Imports System.Drawing
Imports DevExpress.XtraExport
Imports System.IO
Public Class frmCategoriaCliente
    Dim cManager As New ClassManager
    Dim tableData As New DataTable()
    Public gsStoreProcNameGetData As String
    Public gsCodeName As String = ""
    Public gbCodeNumeric As Boolean = False
    Public gsCodeValue As String = ""
    Public gbEdit As Boolean = False
    Public gbAdd As Boolean = False
    Private Sub frmCategoriaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            CargagridLookUpsFromTables()
            If gbAdd Then
                seteaControlsNewRecord()
            End If
            If gbEdit Then
                CargaControlsFromOneRegister()
            End If

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al cargar los datos..." & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub seteaControlsNewRecord()
        If gbAdd Then
            Me.chkActivo.EditValue = True
            Me.txtCodigo.Text = "0"
            Me.txtDescr.Text = ""
            Me.GridLookUpEditCtrFondos.Text = ""
            Me.gridLookUpEditCtaFondos.Text = ""
            Me.GridLookUpEditCtrCxC.Text = ""
            Me.GridLookUpEditCtaCxC.Text = ""
            Me.GridLookUpEditCtrIVA.Text = ""
            Me.GridLookUpEditCtaIVA.Text = ""
            Me.GridLookUpEditctrAnticipo.Text = ""
            Me.GridLookUpEditctaAnticipo.Text = ""
            Me.GridLookUpEditctrCierreDeb.Text = ""
            Me.GridLookUpEditctaCierreDeb.Text = ""
            Me.GridLookUpEditctrCierreCred.Text = ""
            Me.GridLookUpEditctaCierreCred.Text = ""

        End If
    End Sub

    Sub CargagridLookUp(ByVal g As GridLookUpEdit, sTableName As String, sFieldsName As String, sWhere As String, sOrderBy As String, sDisplayMember As String, sValueMember As String)
        g.Properties.DataSource = cManager.GetDataTable(sTableName, sFieldsName, sWhere, sOrderBy)
        g.Properties.DisplayMember = sDisplayMember
        g.Properties.ValueMember = sValueMember

    End Sub

    Sub CargagridLookUpsFromTables()

        CargagridLookUp(Me.GridLookUpEditCtrFondos, "cntCentroCosto", "IDCentro, Descr, Activo", "", "IDCentro", "Descr", "IDCentro")
        CargagridLookUp(Me.gridLookUpEditCtaFondos, "cntCuenta", "IDCuenta, Descr, Activa", "", "IDCuenta", "Descr", "IDCuenta")

        CargagridLookUp(Me.GridLookUpEditCtrCxC, "cntCentroCosto", "IDCentro, Descr, Activo", "", "IDCentro", "Descr", "IDCentro")
        CargagridLookUp(Me.GridLookUpEditCtaCxC, "cntCuenta", "IDCuenta, Descr, Activa", "", "IDCuenta", "Descr", "IDCuenta")

        CargagridLookUp(Me.GridLookUpEditCtrIVA, "cntCentroCosto", "IDCentro, Descr, Activo", "", "IDCentro", "Descr", "IDCentro")
        CargagridLookUp(Me.GridLookUpEditCtaIVA, "cntCuenta", "IDCuenta, Descr, Activa", "", "IDCuenta", "Descr", "IDCuenta")

        CargagridLookUp(Me.GridLookUpEditctrAnticipo, "cntCentroCosto", "IDCentro, Descr, Activo", "", "IDCentro", "Descr", "IDCentro")
        CargagridLookUp(Me.GridLookUpEditctaAnticipo, "cntCuenta", "IDCuenta, Descr, Activa", "", "IDCuenta", "Descr", "IDCuenta")

        CargagridLookUp(Me.GridLookUpEditctrCierreDeb, "cntCentroCosto", "IDCentro, Descr, Activo", "", "IDCentro", "Descr", "IDCentro")
        CargagridLookUp(Me.GridLookUpEditctaCierreDeb, "cntCuenta", "IDCuenta, Descr, Activa", "", "IDCuenta", "Descr", "IDCuenta")

        CargagridLookUp(Me.GridLookUpEditctrCierreCred, "cntCentroCosto", "IDCentro, Descr, Activo", "", "IDCentro", "Descr", "IDCentro")
        CargagridLookUp(Me.GridLookUpEditctaCierreCred, "cntCuenta", "IDCuenta, Descr, Activa", "", "IDCuenta", "Descr", "IDCuenta")


    End Sub

    Sub CargaControlsFromOneRegister()

        tableData = cManager.ExecSPgetData(gsStoreProcNameGetData, gsCodeValue)
        Me.txtCodigo.EditValue = tableData.Rows(0).Item("IDCategoria").ToString()
        Me.txtCodigo.Enabled = False
        Me.txtDescr.EditValue = tableData.Rows(0).Item("Descr").ToString()
        Me.chkActivo.EditValue = IIf((tableData.Rows(0).Item("Activo").ToString()) = "", False, Convert.ToBoolean(tableData.Rows(0).Item("Activo")))
        Me.GridLookUpEditCtrFondos.EditValue = IsNull(tableData.Rows(0).Item("IDctrFondoxDepos"), DBNull.Value)
        Me.gridLookUpEditCtaFondos.EditValue = IsNull(tableData.Rows(0).Item("IDctaFondoxDepos"), DBNull.Value)
        Me.GridLookUpEditCtrCxC.EditValue = IsNull(tableData.Rows(0).Item("IDCtrCxC"), DBNull.Value)
        Me.GridLookUpEditCtaCxC.EditValue = IsNull(tableData.Rows(0).Item("IDCtaCxC"), DBNull.Value)
        Me.GridLookUpEditCtrIVA.EditValue = IsNull(tableData.Rows(0).Item("IDCtrIVA"), DBNull.Value)
        Me.GridLookUpEditCtaIVA.EditValue = IsNull(tableData.Rows(0).Item("IDCtaIVA"), DBNull.Value)
        Me.GridLookUpEditctrAnticipo.EditValue = IsNull(tableData.Rows(0).Item("IDCtrAnticipo"), DBNull.Value)
        Me.GridLookUpEditctaAnticipo.EditValue = IsNull(tableData.Rows(0).Item("IDCtaAnticipo"), DBNull.Value)
        Me.GridLookUpEditctrCierreDeb.EditValue = IsNull(tableData.Rows(0).Item("IDCtrCierreDeb"), DBNull.Value)
        Me.GridLookUpEditctaCierreDeb.EditValue = IsNull(tableData.Rows(0).Item("IDCtrCierreDeb"), DBNull.Value)
        Me.GridLookUpEditctrCierreCred.EditValue = IsNull(tableData.Rows(0).Item("IDCtrCierreCred"), DBNull.Value)
        Me.GridLookUpEditctaCierreCred.EditValue = IsNull(tableData.Rows(0).Item("IDCtrCierreCred"), DBNull.Value)

    End Sub

    Private Sub BarButtonAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonAdd.ItemClick
        gbAdd = True
        gbEdit = False
        If gbAdd Then
            seteaControlsNewRecord()
        End If

    End Sub

    Private Function DatosValidos() As Boolean
        If Len(txtCodigo.Text.Trim) = 0 Then MsgBox("Dato no Puede quedar en Balnco", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ayuda") : txtCodigo.Focus() : Return False : Exit Function
        If Len(txtDescr.Text.Trim) = 0 Then MsgBox("Dato no Puede quedar en Balnco", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ayuda") : txtDescr.Focus() : Return False : Exit Function
        'If gridlookupTipo.EditValue = Nothing Then MsgBox("Debe seleccionar un Tipo de Cliente", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ayuda") : Me.gridlookupTipo.Focus() : Return False : Exit Function
        Return True
    End Function

    Private Sub BarButtonSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonSave.ItemClick
        Dim storeName As String, sparameterValues As String
        Try
            If DatosValidos() = False Then

                Return
            End If
            storeName = "fafUpdateCategoriaCliente"
            sparameterValues = IIf(gbAdd = True, "'I',", "'U',")
            sparameterValues = sparameterValues & txtCodigo.Text & ",'"
            sparameterValues = sparameterValues & txtDescr.Text & "',"
            sparameterValues = sparameterValues & IIf(Me.chkActivo.Checked = True, 1, 0).ToString() & ","
            sparameterValues = sparameterValues & IIf(Me.GridLookUpEditCtrFondos.EditValue Is DBNull.Value, "null", GridLookUpEditCtrFondos.EditValue.ToString()) & ","
            sparameterValues = sparameterValues & IIf(Me.gridLookUpEditCtaFondos.EditValue Is DBNull.Value, "null", gridLookUpEditCtaFondos.EditValue.ToString()) & ","
            sparameterValues = sparameterValues & IIf(Me.GridLookUpEditCtrCxC.EditValue Is DBNull.Value, "null", GridLookUpEditCtrCxC.EditValue.ToString()) & ","
            sparameterValues = sparameterValues & IIf(Me.GridLookUpEditCtaCxC.EditValue Is DBNull.Value, "null", GridLookUpEditCtaCxC.EditValue.ToString()) & ","
            sparameterValues = sparameterValues & IIf(Me.GridLookUpEditCtrIVA.EditValue Is DBNull.Value, "null", GridLookUpEditCtrIVA.EditValue.ToString()) & ","
            sparameterValues = sparameterValues & IIf(Me.GridLookUpEditCtaIVA.EditValue Is DBNull.Value, "null", GridLookUpEditCtaIVA.EditValue.ToString()) & ","
            sparameterValues = sparameterValues & IIf(Me.GridLookUpEditctrAnticipo.EditValue Is DBNull.Value, "null", GridLookUpEditctrAnticipo.EditValue.ToString()) & ","
            sparameterValues = sparameterValues & IIf(Me.GridLookUpEditctaAnticipo.EditValue Is DBNull.Value, "null", GridLookUpEditctaAnticipo.EditValue.ToString()) & ","
            sparameterValues = sparameterValues & IIf(Me.GridLookUpEditctrCierreDeb.EditValue Is DBNull.Value, "null", GridLookUpEditctrCierreDeb.EditValue.ToString()) & ","
            sparameterValues = sparameterValues & IIf(Me.GridLookUpEditctaCierreDeb.EditValue Is DBNull.Value, "null", GridLookUpEditctaCierreDeb.EditValue.ToString()) & ","
            sparameterValues = sparameterValues & IIf(Me.GridLookUpEditctrCierreCred.EditValue Is DBNull.Value, "null", GridLookUpEditctrCierreCred.EditValue.ToString()) & ","
            sparameterValues = sparameterValues & IIf(Me.GridLookUpEditctaCierreCred.EditValue Is DBNull.Value, "null", GridLookUpEditctaCierreCred.EditValue.ToString())

            cManager.ExecSP(storeName, sparameterValues)
            MessageBox.Show("El registro ha sido guardado exitosamente ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message & " parametros ")
        End Try
    End Sub

    Private Sub BarButtonDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonDelete.ItemClick
        Dim storeName As String, sparameterValues As String
        Try
            If DatosValidos() = False Then

                Return
            End If
            storeName = "fafgetCategoriaCliente"
            sparameterValues = "'D',"
            sparameterValues = sparameterValues & txtCodigo.Text & ",'"
            sparameterValues = sparameterValues & txtDescr.Text & "'"
            cManager.ExecSP(storeName, sparameterValues)
            MessageBox.Show("El registro ha sido eliminado exitosamente ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message & " parametros ")
        End Try
    End Sub
End Class