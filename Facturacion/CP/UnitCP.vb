Imports System.Data.Sql
Imports System.IO
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports Clases

Public Module Unitbk
    Public gsSucursal As String = "1"
    Public gsUsuario As String = "azepeda"
    Public gsNombreEmpresa As String = "CEDETSA"

    Public gParametrosCPP As TParametrosCPP

    Dim cManager As New ClassManager
    Dim tableData As New DataTable()

    Public Const CrptMovimientos As Integer = 1
    Public Const CrptDesglosePagos As Integer = 2
    Public Const CrptDocumentosPorPagar As Integer = 3
    Public Const CrptAnalisisVencimiento As Integer = 4
    Public Const CrptAnalisisVencimientoSucursal As Integer = 5


    Structure TParametrosCPP
        Public DocAprobadosDefault As Boolean
        Public CambiarPlazo As Boolean
        Public TipoAsientoDebito As String
        Public TipoAsientoCredito As String
        Public IntegracionContable As Boolean
        Public EditaConsecutivos As Boolean
    End Structure


    Sub CargagridSearchLookUp(ByVal g As SearchLookUpEdit, sTableName As String, sFieldsName As String, sWhere As String, sOrderBy As String, sDisplayMember As String, sValueMember As String)
        Dim count = sFieldsName.Split(",").Length - 1
        g.Properties.DataSource = Nothing
        g.Properties.DataSource = cManager.GetDataTable(sTableName, sFieldsName, sWhere, sOrderBy)
        g.Properties.DisplayMember = sDisplayMember
        g.Properties.ValueMember = sValueMember
        g.Properties.PopupFormSize = New Size(500, 250)
        g.ForceInitialize()
        g.Properties.PopulateViewColumns()
        g.Properties.View.OptionsView.ColumnAutoWidth = False
        g.Properties.View.Columns(0).Width = 80
        If count = 1 Then
            g.Properties.View.Columns(1).Width = 370
        End If
        If count = 2 Then
            g.Properties.View.Columns(1).Width = 280
            g.Properties.View.Columns(2).Width = 80
        End If
        If count = 3 Then
            g.Properties.View.Columns(1).Width = 280
            g.Properties.View.Columns(2).Width = 80
            g.Properties.View.Columns(3).Width = 80
        End If
        g.Properties.NullText = ""
    End Sub
    Public Function DatoCorrecto(sValor As String, bIsNumeric As Boolean) As String
        Dim sResult As String
        sResult = "OK"
        Try
            If bIsNumeric = False And String.IsNullOrWhiteSpace(sValor) Then
                sResult = "Debe existir un valor válido, no se aceptan vacios"
            End If
            If bIsNumeric Then
                If Not IsNumeric(sValor) Then
                    sResult = "Existe un valor que debe ser numérico, revise por favor "
                    Return sResult
                End If
                If Val(sValor) < 0 Then
                    sResult = "El Valor debe ser Mayor o igual que Cero"
                    Return sResult
                End If
            End If
        Catch ex As Exception
            sResult = "Hubo un error al Validar el Dato " & ex.Message
            Return sResult
        End Try
        Return sResult

    End Function

    Public Function UnicodeBytesToString(
        ByVal bytes() As Byte) As String
        Return System.Text.Encoding.Unicode.GetString(bytes)
    End Function

    Public Sub SaveImage(sTableName As String, MyImage As Image, Id As Integer)

        Dim ImageBytes(0) As Byte
        Using mStream As New MemoryStream()
            MyImage.Save(mStream, MyImage.RawFormat)
            ImageBytes = mStream.ToArray()
        End Using

        Dim adoConnect = New SqlClient.SqlConnection("Server=. ; database = Ced ; integrated security = true")
        Dim adoCommand = New SqlClient.SqlCommand("UPDATE " & sTableName & " SET [Foto]=@MyNewImage WHERE [IDCliente]=@id", adoConnect)

        With adoCommand.Parameters.Add("@MyNewImage", SqlDbType.Image)
            .Value = ImageBytes
            .Size = ImageBytes.Length
        End With
        With adoCommand.Parameters.Add("@id", SqlDbType.BigInt)
            .Value = Id
        End With

        adoConnect.Open()
        adoCommand.ExecuteNonQuery()
        adoConnect.Close()

    End Sub

    Public Function getWordsBeforeOneWord(SearchString As String, my_string As String) As String
        Dim StartP As Integer = 1
        ' to account for the space
        Dim EndP As Integer = InStr(StartP, my_string, " ")
        Return Mid(my_string, StartP, EndP - StartP)

    End Function

    Public Function Solo_Letras(ByVal Teclas As Integer) As Integer
        Dim Resultado As Integer
        Select Case Teclas
            Case 65 To 90, 97 To 122, 165, 13, 8, 32, 44
                Resultado = Teclas
            Case Else
                Resultado = 0
                'Case Else
                '    MessageBox.Show("Solo Letras son Admitidas", "Ayuda", MessageBoxButton.Ok, MessageBoxIcon.Information)
        End Select
        Return Resultado
    End Function

    Public Function Solo_AN(ByVal Teclas As Integer) As Integer
        Dim Resultado As Integer
        Select Case Teclas
            Case 65, 97, 78, 110
                Resultado = Teclas
            Case Else
                Resultado = 0
                'Case Else
                '    MessageBox.Show("Solo Letras son Admitidas", "Ayuda", MessageBoxButton.Ok, MessageBoxIcon.Information)
        End Select
        Return Resultado
    End Function

    Public Function Solo_Numeros(ByVal Teclas As Integer) As Integer
        Dim Resultado As Integer
        Select Case Teclas
            Case 48 To 57, 13, 8, 46
                Resultado = Teclas
            Case Else
                Resultado = 0
                'Case Else
                '    MessageBox.Show("Solo Letras son Admitidas", "Ayuda", MessageBoxButton.Ok, MessageBoxIcon.Information)
        End Select
        Return Resultado
    End Function

    Public Function IsAlphaNumeric(ByVal strInputText As String) As Boolean
        Dim IsAlpha As Boolean = False
        If System.Text.RegularExpressions.Regex.IsMatch(strInputText, "^[a-zA-Z0-9]+$") _
            Or CharAllowed(strInputText) Then
            IsAlpha = True
        Else
            IsAlpha = False
        End If
        Return IsAlpha
    End Function

    Private Function CharAllowed(sChar As String) As Boolean
        Dim wordCharsAllowed() As Char = "-/$%#<>{}".ToCharArray()

        Dim lbOk As Boolean = False

        Dim i As Integer = 0
        While i < wordCharsAllowed.Length And Not lbOk

            If sChar = wordCharsAllowed(i) Then
                lbOk = True
            Else
                lbOk = False
            End If
            i = i + 1
        End While

        Return lbOk
    End Function
    Public Function getTipoCambio() As String
        Dim sTipoCambio = ""
        Try

            Dim t As DataTable
            t = cManager.GetDataTable("cntParametros", "TipoCambio", "ID >0", "ID")
            If t.Rows.Count > 0 Then
                sTipoCambio = t.Rows(0).Item("TipoCambio")
            Else
                sTipoCambio = ""
            End If
            Return sTipoCambio
        Catch ex As Exception
            sTipoCambio = ""
            Return sTipoCambio
        End Try
    End Function


    Public Function CargaParametrosCPP() As Boolean
        Dim lbok As Boolean = False
        Try
            Dim tableParametros As New DataTable()
            Dim iIDParametros As Integer
            Dim t As DataTable
            t = cManager.GetDataTable("cppParametros", "IDParametro", "IDParametro >0", "IDParametro")
            If t.Rows.Count > 0 Then
                iIDParametros = t.Rows(0).Item(0)
            Else
                lbok = False
            End If
            tableParametros = cManager.ExecSPgetData("cppgetParametros", iIDParametros.ToString)
            If tableParametros.Rows.Count > 0 Then


                gParametrosCPP.DocAprobadosDefault = Convert.ToBoolean(tableParametros.Rows(0).Item("DocAprobadosDefault"))
                gParametrosCPP.CambiarPlazo = Convert.ToBoolean(tableParametros.Rows(0).Item("CambiarPlazo"))
                gParametrosCPP.TipoAsientoDebito = (tableParametros.Rows(0).Item("TipoAsientoDebito")).ToString()
                gParametrosCPP.TipoAsientoCredito = (tableParametros.Rows(0).Item("TipoAsientoCredito")).ToString()
                gParametrosCPP.IntegracionContable = Convert.ToBoolean(tableParametros.Rows(0).Item("IntegracionContable"))


                lbok = True
            End If
        Catch ex As Exception
            lbok = False
        End Try
        Return lbok
    End Function

    Public Function UsuarioTieneAcceso(sUsuario As String, sAccionPRG As String) As Boolean
        Dim lbok As Boolean = False
        Try
            Dim sParameters As String
            Dim td As DataTable
            sParameters = "'" & sUsuario & "', '" & sAccionPRG & "'"
            td = cManager.ExecFunction("secUsuarioTieneAcceso", sParameters)
            If CBool(td.Rows(0)(0)) = False Then
                lbok = False
            Else
                lbok = True

            End If

        Catch ex As Exception
            lbok = False
        End Try
        Return lbok

    End Function

    Public Function EsMonedaLocal(piMoneda As Integer) As Boolean
        Dim lbok As Boolean = False
        Try

            Dim t As DataTable
            t = cManager.GetDataTable("globalMoneda", "Nacional", "IDMoneda = " & piMoneda.ToString(), "IDMoneda")
            If t.Rows.Count > 0 Then
                If CBool(t.Rows(0).Item("Nacional")) Then
                    lbok = True
                Else
                    lbok = False
                End If
            Else
                lbok = False
            End If
        Catch ex As Exception
            lbok = False
        End Try
        Return lbok

    End Function
    Public Function IsMaskOK(ByVal smask As String, ByVal sConsecutivo As String) As Boolean
        Dim lbOk As Boolean = True
        If IsNothing(smask) Then
            lbOk = False
            Return lbOk
        End If
        Dim wordChars() As Char = sConsecutivo.ToCharArray()
        Dim maskChars() As Char = smask.ToCharArray()


        If wordChars.Length <> maskChars.Length Then
            MessageBox.Show("La longitud de la Máscara: " & smask & " no es igual a la longitud del valor del Consecutivo ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lbOk = False
            Return lbOk
        End If
        Dim i As Integer = 0
        While i < wordChars.Length AndAlso i < maskChars.Length AndAlso lbOk

            If maskChars(i) = "A" And Not IsAlphaNumeric(wordChars(i)) Then
                MessageBox.Show("Error en el valor Alfanumérico permitido  ... " & sConsecutivo & " posición " & (i + 1).ToString() & " valor " & wordChars(i) & " Debe ser Alfanumérico permitido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lbOk = False
            End If

            If maskChars(i) = "N" And Not IsNumeric(wordChars(i)) Then
                MessageBox.Show("Error en el valor Numérico  ... " & sConsecutivo & " posición " & (i + 1).ToString() & " valor " & wordChars(i) & " Debe ser Numérico solamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lbOk = False
            End If
            i = i + 1
        End While

        Return lbOk
    End Function


    Public Function CountBetweenConsecutivos(ByVal smask As String, ByVal sConsecutivo1 As String, ByVal sConsecutivo2 As String) As Int32
        Dim iCount As Int32 = 0
        Dim lbOk As Boolean
        If IsNothing(sConsecutivo1) Or IsNothing(sConsecutivo2) Then
            iCount = 0
            Return iCount
        End If
        Dim maskChars() As Char = smask.ToCharArray()
        Dim wordChars1() As Char = sConsecutivo1.ToCharArray()
        Dim wordChars2() As Char = sConsecutivo2.ToCharArray()


        If wordChars1.Length <> wordChars2.Length Then
            MessageBox.Show("La longitud de los consecutivos deben ser iguales  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            iCount = 0
            Return iCount
        End If
        Dim i As Integer = wordChars1.Length
        Dim sNumero1 As String = ""
        lbOk = False
        While i <= wordChars1.Length AndAlso Not lbOk

            If maskChars(i - 1) = "A" Then
                lbOk = True
            Else
                sNumero1 = wordChars1(i - 1).ToString() & sNumero1
            End If

            i = i - 1
        End While
        i = wordChars2.Length
        Dim sNumero2 As String = ""
        lbOk = False
        While i <= wordChars2.Length AndAlso Not lbOk

            If maskChars(i - 1) = "A" Then
                lbOk = True
            Else
                sNumero2 = wordChars2(i - 1).ToString() & sNumero2
            End If

            i = i - 1
        End While
        iCount = Val(sNumero2) - Val(sNumero1)
        Return iCount
    End Function


    Public Function getTipoCambio(dFecha As Date, sIDTipoCambio As String) As Decimal
        Try
            '  Dim cManager As New Clases.ClassManagerCDate(Me.DateEditFecha.EditValue).ToString("yyyyMMdd")
            Dim t As DataTable
            Dim sParameter As String
            sParameter = "'" & dFecha.ToString("yyyyMMdd") & "','" & sIDTipoCambio & "'"
            t = cManager.ExecFunction("globalGetLastTipoCambio", sParameter)
            Return t.Rows(0).Item(0)
        Catch ex As Exception
            Return 0
            MessageBox.Show("Error al Obtener el Tipo de Cambio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Function

    Public Sub FormatControlNumber(myText As DevExpress.XtraEditors.TextEdit)
        myText.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        myText.Properties.DisplayFormat.FormatString = "n2"
        myText.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        myText.Properties.EditFormat.FormatString = "n2"
        myText.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    End Sub

    Public Function DiferenciaDecimal(pPrimerNumero As Decimal, pSegundoNumero As Decimal) As Boolean
        Dim lbok As Boolean = False
        Dim ValorDecimal1 As Decimal = pPrimerNumero
        Dim ValorEntero1 As Integer = CInt(ValorDecimal1)
        Dim ValorDecimal2 As Decimal = pSegundoNumero
        Dim ValorEntero2 As Integer = CInt(ValorDecimal2)
        If ValorEntero1 = ValorEntero2 And ValorDecimal2 <> ValorDecimal1 Then
            lbok = True
        End If
        DiferenciaDecimal = lbok
    End Function

    Public Function Redondear(dNumero As Decimal, iDecimales As Integer) As Double
        Dim lMultiplicador As Long
        Dim dRetorno As Decimal

        If iDecimales > 9 Then iDecimales = 9
        lMultiplicador = 10 ^ iDecimales
        dRetorno = CDbl(CLng(dNumero * lMultiplicador)) / lMultiplicador

        Redondear = dRetorno
    End Function

    Public Function IsNull(ByVal controleValue As Object, ByVal returnValue As Object) As Object
        If controleValue Is Nothing Or IsDBNull(controleValue) Then
            Return returnValue
        Else
            Return controleValue
        End If
    End Function

End Module

