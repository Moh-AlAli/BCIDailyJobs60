﻿Public Class Enteredby
    Private i As Integer
    Private j As Integer
    Private Sub Enteredby_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
           
            Dim c As New Clsfunct
            Dim dsuser As New DataSet

            dsuser = c.EnterdBy("", "", DailyJobs.compid)


            Dim icl As New DataGridViewTextBoxColumn
            icl.DataPropertyName = "ENTEREDBY"
            icl.Name = "clidc"
            icl.HeaderText = "Entered By"
            icl.Width = 150
            DGfcus.Columns.Add(icl)
            DGfcus.DataSource = dsuser.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButSel.Click
        Try


            'Dim arv As AccpacView
            'arv = DailySales.xdbcom.OpenView2("IC0370")
            Dim searfil As String = ""
            Dim searfil2 As String = ""
            searfil = "  Where Enteredby like N'%" & Txtenter.Text & "%' "
            searfil2 = "  And Enteredby like N'%" & Txtenter.Text & "%' "


            'arv.Browse(searfil, True)
            'Dim ICLOCds As DataSet = New DataSet("IC")

            'Dim cust As DataTable = ICLOCds.Tables.Add("ICLOC")
            'Dim id As DataColumn = cust.Columns.Add("LOCATION", Type.GetType("System.String"))
            'Dim name As DataColumn = cust.Columns.Add("DESC", Type.GetType("System.String"))
            'cust.PrimaryKey = New DataColumn() {id}
            'Dim row As DataRow
            'row = cust.NewRow()
            'Do While arv.FilterFetch(False)
            '    Dim cid As String = arv.Fields.FieldByName("LOCATION").Value.ToString()
            '    Dim cn As String = arv.Fields.FieldByName("DESC").Value.ToString()
            '    row("LOCATION") = cid
            '    row("DESC") = cn
            '    ICLOCds.Tables(0).Rows.Add(row)
            '    row = cust.NewRow()
            'Loop
            Dim c As New Clsfunct
            Dim ICLOCds As New DataSet

            ICLOCds = c.EnterdBy(searfil, searfil2, DailyJobs.compid)
            Dim dt As DataTable = ICLOCds.Tables(0)

            i = DGfcus.CurrentCell.RowIndex
            j = DGfcus.CurrentCell.ColumnIndex
            DailyJobs.txtenteredby.Text = dt.Rows(i)(0)
            DailyJobs.Butentby.Enabled = True
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Butcan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butcan.Click
        DailyJobs.Butentby.Enabled = True
        Close()
    End Sub

    Private Sub Txtcusno_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtenter.MouseLeave

        'Dim arv As AccpacView
        'arv = DailySales.xdbcom.OpenView2("IC0370")
        Dim searfil As String = ""
        Dim searfil2 As String = ""
        searfil = "  Where Enteredby like N'%" & Txtenter.Text & "%' "
        searfil2 = "  And Enteredby like N'%" & Txtenter.Text & "%' "


        'arv.Browse(searfil, True)
        'Dim ICLOCds As DataSet = New DataSet("IC")

        'Dim cust As DataTable = ICLOCds.Tables.Add("ICLOC")
        'Dim id As DataColumn = cust.Columns.Add("LOCATION", Type.GetType("System.String"))
        'Dim name As DataColumn = cust.Columns.Add("DESC", Type.GetType("System.String"))
        'cust.PrimaryKey = New DataColumn() {id}
        'Dim row As DataRow
        'row = cust.NewRow()
        'Do While arv.FilterFetch(False)
        '    Dim cid As String = arv.Fields.FieldByName("LOCATION").Value.ToString()
        '    Dim cn As String = arv.Fields.FieldByName("DESC").Value.ToString()
        '    row("LOCATION") = cid
        '    row("DESC") = cn
        '    ICLOCds.Tables(0).Rows.Add(row)
        '    row = cust.NewRow()
        'Loop
        Dim c As New Clsfunct
        Dim ICLOCds As New DataSet

        ICLOCds = c.EnterdBy(searfil, searfil2, DailyJobs.compid)
        DGfcus.DataSource = ICLOCds.Tables(0)


    End Sub



    Private Sub Txtcusno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtenter.TextChanged
        Try
            'Dim arv As AccpacView
            'arv = DailySales.xdbcom.OpenView2("IC0370")
            Dim searfil As String = ""
            Dim searfil2 As String = ""
            searfil = "  Where Enteredby like N'%" & Txtenter.Text & "%' "
            searfil2 = "  And Enteredby like N'%" & Txtenter.Text & "%' "


            'arv.Browse(searfil, True)
            'Dim ICLOCds As DataSet = New DataSet("IC")

            'Dim cust As DataTable = ICLOCds.Tables.Add("ICLOC")
            'Dim id As DataColumn = cust.Columns.Add("LOCATION", Type.GetType("System.String"))
            'Dim name As DataColumn = cust.Columns.Add("DESC", Type.GetType("System.String"))
            'cust.PrimaryKey = New DataColumn() {id}
            'Dim row As DataRow
            'row = cust.NewRow()
            'Do While arv.FilterFetch(False)
            '    Dim cid As String = arv.Fields.FieldByName("LOCATION").Value.ToString()
            '    Dim cn As String = arv.Fields.FieldByName("DESC").Value.ToString()
            '    row("LOCATION") = cid
            '    row("DESC") = cn
            '    ICLOCds.Tables(0).Rows.Add(row)
            '    row = cust.NewRow()
            'Loop
            Dim c As New Clsfunct
            Dim ICLOCds As New DataSet

            ICLOCds = c.EnterdBy(searfil, searfil2, DailyJobs.compid)
            DGfcus.DataSource = ICLOCds.Tables(0)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub DGfcus_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGfcus.CellContentClick
        Try
            'Dim arv As AccpacView
            'arv = DailySales.xdbcom.OpenView2("IC0370")
            Dim searfil As String = ""
            Dim searfil2 As String = ""
            searfil = "  Where Enteredby like N'%" & Txtenter.Text & "%' "
            searfil2 = "  And Enteredby like N'%" & Txtenter.Text & "%' "

            'arv.Browse(searfil, True)
            'Dim ICLOCds As DataSet = New DataSet("IC")

            'Dim cust As DataTable = ICLOCds.Tables.Add("ICLOC")
            'Dim id As DataColumn = cust.Columns.Add("LOCATION", Type.GetType("System.String"))
            'Dim name As DataColumn = cust.Columns.Add("DESC", Type.GetType("System.String"))
            'cust.PrimaryKey = New DataColumn() {id}
            'Dim row As DataRow
            'row = cust.NewRow()
            'Do While arv.FilterFetch(False)
            '    Dim cid As String = arv.Fields.FieldByName("LOCATION").Value.ToString()
            '    Dim cn As String = arv.Fields.FieldByName("DESC").Value.ToString()
            '    row("LOCATION") = cid
            '    row("DESC") = cn
            '    ICLOCds.Tables(0).Rows.Add(row)
            '    row = cust.NewRow()
            'Loop
            Dim c As New Clsfunct
            Dim ICLOCds As New DataSet

            ICLOCds = c.EnterdBy(searfil, searfil2, DailyJobs.compid)

            Dim dt As DataTable = ICLOCds.Tables(0)

            i = DGfcus.CurrentCell.RowIndex
            j = DGfcus.CurrentCell.ColumnIndex
            DailyJobs.txtenteredby.Text = dt.Rows(i)(0)
            DailyJobs.Butentby.Enabled = True
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Fromcust_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        DailyJobs.Butentby.Enabled = True
    End Sub
End Class