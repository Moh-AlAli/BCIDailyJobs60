Imports AccpacCOMAPI
Public Class toloc
    Private i As Integer
    Private j As Integer
    Private Sub toloc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim arv As AccpacView
            arv = DailyJobs.xdbcom.OpenView2("IC0370")
            Dim LOCATIONds As DataSet = New DataSet("IC")
            Dim cust As DataTable = LOCATIONds.Tables.Add("ICLOC")
            Dim name As DataColumn = cust.Columns.Add("LOCATION", Type.GetType("System.String"))
            Dim id As DataColumn = cust.Columns.Add("DESC", Type.GetType("System.String"))
            Dim row As DataRow
            row = cust.NewRow()
            Do While arv.FilterFetch(False)
                Dim cid As String = arv.Fields.FieldByName("LOCATION").Value.ToString()
                Dim cn As String = arv.Fields.FieldByName("DESC").Value.ToString()
                row("LOCATION") = cid
                row("DESC") = cn
                LOCATIONds.Tables(0).Rows.Add(row)
                row = cust.NewRow()
            Loop
            Dim icl As New DataGridViewTextBoxColumn
            icl.DataPropertyName = "LOCATION"
            icl.Name = "clidc"
            icl.HeaderText = "Location"
            icl.Width = 150
            DGtloc.Columns.Add(icl)
            Dim ncl As New DataGridViewTextBoxColumn
            ncl.DataPropertyName = "DESC"
            ncl.Name = "colnc"
            ncl.HeaderText = "Description"
            ncl.Width = 190
            DGtloc.Columns.Add(ncl)

            DGtloc.DataSource = LOCATIONds.Tables(0)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ButSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButSel.Click
        Try


            Dim arv As AccpacView
            arv = DailyJobs.xdbcom.OpenView2("IC0370")
            Dim searfil As String = ""

            If Txtloc.Text <> Nothing And Txtname.Text <> Nothing Then
                searfil = "DESC Like ""%" + Txtname.Text + "%"" and LOCATION like ""%" + Txtloc.Text + "%"" "
            ElseIf Txtname.Text <> Nothing And Txtloc.Text = Nothing Then
                searfil = "DESC like ""%" + Txtname.Text + "%"" "
            ElseIf Txtloc.Text <> Nothing And Txtname.Text = Nothing Then
                searfil = "LOCATION like ""%" + Txtloc.Text + "%"" "
            End If

            arv.Browse(searfil, True)
            Dim LOCATIONds As DataSet = New DataSet("IC")

            Dim cust As DataTable = LOCATIONds.Tables.Add("ICLOC")
            Dim id As DataColumn = cust.Columns.Add("LOCATION", Type.GetType("System.String"))
            Dim name As DataColumn = cust.Columns.Add("DESC", Type.GetType("System.String"))
            cust.PrimaryKey = New DataColumn() {id}
            Dim row As DataRow
            row = cust.NewRow()
            Do While arv.FilterFetch(False)
                Dim cid As String = arv.Fields.FieldByName("LOCATION").Value.ToString()
                Dim cn As String = arv.Fields.FieldByName("DESC").Value.ToString()
                row("LOCATION") = cid
                row("DESC") = cn
                LOCATIONds.Tables(0).Rows.Add(row)
                row = cust.NewRow()
            Loop
            Dim dt As DataTable = LOCATIONds.Tables(0)

            i = DGtloc.CurrentCell.RowIndex
            j = DGtloc.CurrentCell.ColumnIndex
            DailyJobs.Txttoloc.Text = dt.Rows(i)(0)
            DailyJobs.btdloc.Enabled = True
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Butcan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butcan.Click
        Close()
        DailyJobs.btdloc.Enabled = True
    End Sub

    Private Sub Txtcusno_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtloc.MouseLeave



        Dim arv As AccpacView
        arv = DailyJobs.xdbcom.OpenView2("IC0370")
        Dim searfil As String = ""

        If Txtloc.Text <> Nothing And Txtname.Text <> Nothing Then
            searfil = "DESC Like ""%" + Txtname.Text + "%"" and LOCATION like ""%" + Txtloc.Text + "%"" "
        ElseIf Txtname.Text <> Nothing And Txtloc.Text = Nothing Then
            searfil = "DESC like ""%" + Txtname.Text + "%"" "
        ElseIf Txtloc.Text <> Nothing And Txtname.Text = Nothing Then
            searfil = "LOCATION like ""%" + Txtloc.Text + "%"" "
        End If
        arv.Browse(searfil, True)


        Dim LOCATIONds As DataSet = New DataSet("IC")

        Dim cust As DataTable = LOCATIONds.Tables.Add("ICLOC")
        Dim id As DataColumn = cust.Columns.Add("LOCATION", Type.GetType("System.String"))
        Dim name As DataColumn = cust.Columns.Add("DESC", Type.GetType("System.String"))
        cust.PrimaryKey = New DataColumn() {id}
        Dim row As DataRow
        row = cust.NewRow()

        Do While arv.FilterFetch(False)

            Dim cid As String = arv.Fields.FieldByName("LOCATION").Value.ToString()
            Dim cn As String = arv.Fields.FieldByName("DESC").Value.ToString()
            row("LOCATION") = cid
            row("DESC") = cn
            LOCATIONds.Tables(0).Rows.Add(row)
            row = cust.NewRow()
        Loop

        DGtloc.DataSource = LOCATIONds.Tables(0)


    End Sub

    Private Sub Txtname_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtname.MouseLeave

        Try



            Dim arv As AccpacView
            arv = DailyJobs.xdbcom.OpenView2("IC0370")
            Dim searfil As String = ""

            If Txtloc.Text <> Nothing And Txtname.Text <> Nothing Then
                searfil = "DESC Like ""%" + Txtname.Text + "%"" and LOCATION like ""%" + Txtloc.Text + "%"" "
            ElseIf Txtname.Text <> Nothing And Txtloc.Text = Nothing Then
                searfil = "DESC like ""%" + Txtname.Text + "%"" "
            ElseIf Txtloc.Text <> Nothing And Txtname.Text = Nothing Then
                searfil = "LOCATION like ""%" + Txtloc.Text + "%"" "
            End If

            arv.Browse(searfil, True)
            Dim LOCATIONds As DataSet = New DataSet("IC")

            Dim cust As DataTable = LOCATIONds.Tables.Add("ICLOC")
            Dim id As DataColumn = cust.Columns.Add("LOCATION", Type.GetType("System.String"))
            Dim name As DataColumn = cust.Columns.Add("DESC", Type.GetType("System.String"))
            cust.PrimaryKey = New DataColumn() {id}
            Dim row As DataRow
            row = cust.NewRow()
            Do While arv.FilterFetch(False)
                Dim cid As String = arv.Fields.FieldByName("LOCATION").Value.ToString()
                Dim cn As String = arv.Fields.FieldByName("DESC").Value.ToString()
                row("LOCATION") = cid
                row("DESC") = cn
                LOCATIONds.Tables(0).Rows.Add(row)
                row = cust.NewRow()
            Loop
            DGtloc.DataSource = LOCATIONds.Tables(0)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Txtcusno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtloc.TextChanged
        Try



            Dim arv As AccpacView
            arv = DailyJobs.xdbcom.OpenView2("IC0370")
            Dim searfil As String = ""

            If Txtloc.Text <> Nothing And Txtname.Text <> Nothing Then
                searfil = "DESC Like ""%" + Txtname.Text + "%"" and LOCATION like ""%" + Txtloc.Text + "%"" "
            ElseIf Txtname.Text <> Nothing And Txtloc.Text = Nothing Then
                searfil = "DESC like ""%" + Txtname.Text + "%"" "
            ElseIf Txtloc.Text <> Nothing And Txtname.Text = Nothing Then
                searfil = "LOCATION like ""%" + Txtloc.Text + "%"" "
            End If

            arv.Browse(searfil, True)
            Dim LOCATIONds As DataSet = New DataSet("IC")

            Dim cust As DataTable = LOCATIONds.Tables.Add("ICLOC")
            Dim id As DataColumn = cust.Columns.Add("LOCATION", Type.GetType("System.String"))
            Dim name As DataColumn = cust.Columns.Add("DESC", Type.GetType("System.String"))
            cust.PrimaryKey = New DataColumn() {id}
            Dim row As DataRow
            row = cust.NewRow()
            Do While arv.FilterFetch(False)
                Dim cid As String = arv.Fields.FieldByName("LOCATION").Value.ToString()
                Dim cn As String = arv.Fields.FieldByName("DESC").Value.ToString()
                row("LOCATION") = cid
                row("DESC") = cn
                LOCATIONds.Tables(0).Rows.Add(row)
                row = cust.NewRow()
            Loop
            DGtloc.DataSource = LOCATIONds.Tables(0)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtname.TextChanged
        Try



            Dim arv As AccpacView
            arv = DailyJobs.xdbcom.OpenView2("IC0370")
            Dim searfil As String = ""


            If Txtloc.Text <> Nothing And Txtname.Text <> Nothing Then
                searfil = "DESC Like ""%" + Txtname.Text + "%"" and LOCATION like ""%" + Txtloc.Text + "%"" "
            ElseIf Txtname.Text <> Nothing And Txtloc.Text = Nothing Then
                searfil = "DESC like ""%" + Txtname.Text + "%"" "
            ElseIf Txtloc.Text <> Nothing And Txtname.Text = Nothing Then
                searfil = "LOCATION like ""%" + Txtloc.Text + "%"" "
            End If
            arv.Browse(searfil, True)
            Dim LOCATIONds As DataSet = New DataSet("IC")

            Dim cust As DataTable = LOCATIONds.Tables.Add("ICLOC")
            Dim id As DataColumn = cust.Columns.Add("LOCATION", Type.GetType("System.String"))
            Dim name As DataColumn = cust.Columns.Add("DESC", Type.GetType("System.String"))
            cust.PrimaryKey = New DataColumn() {id}
            Dim row As DataRow
            row = cust.NewRow()
            Do While arv.FilterFetch(False)
                Dim cid As String = arv.Fields.FieldByName("LOCATION").Value.ToString()
                Dim cn As String = arv.Fields.FieldByName("DESC").Value.ToString()
                row("LOCATION") = cid
                row("DESC") = cn
                LOCATIONds.Tables(0).Rows.Add(row)
                row = cust.NewRow()
            Loop
            DGtloc.DataSource = LOCATIONds.Tables(0)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DGtloc_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGtloc.CellContentClick
        Try

            Dim arv As AccpacView
            arv = DailyJobs.xdbcom.OpenView2("IC0370")
            Dim searfil As String = ""


            If Txtloc.Text <> Nothing And Txtname.Text <> Nothing Then
                searfil = "DESC Like ""%" + Txtname.Text + "%"" and LOCATION like ""%" + Txtloc.Text + "%"" "
            ElseIf Txtname.Text <> Nothing And Txtloc.Text = Nothing Then
                searfil = "DESC like ""%" + Txtname.Text + "%"" "
            ElseIf Txtloc.Text <> Nothing And Txtname.Text = Nothing Then
                searfil = "LOCATION like ""%" + Txtloc.Text + "%"" "
            End If
            arv.Browse(searfil, True)
            Dim LOCATIONds As DataSet = New DataSet("IC")

            Dim cust As DataTable = LOCATIONds.Tables.Add("ICLOC")
            Dim id As DataColumn = cust.Columns.Add("LOCATION", Type.GetType("System.String"))
            Dim name As DataColumn = cust.Columns.Add("DESC", Type.GetType("System.String"))
            cust.PrimaryKey = New DataColumn() {id}
            Dim row As DataRow
            row = cust.NewRow()
            Do While arv.FilterFetch(False)
                Dim cid As String = arv.Fields.FieldByName("LOCATION").Value.ToString()
                Dim cn As String = arv.Fields.FieldByName("DESC").Value.ToString()
                row("LOCATION") = cid
                row("DESC") = cn
                LOCATIONds.Tables(0).Rows.Add(row)
                row = cust.NewRow()
            Loop
            Dim dt As DataTable = LOCATIONds.Tables(0)

            i = DGtloc.CurrentCell.RowIndex
            j = DGtloc.CurrentCell.ColumnIndex
            DailyJobs.Txttoloc.Text = dt.Rows(i)(0)
            DailyJobs.btdloc.Enabled = True
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tocust_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        DailyJobs.btdloc.Enabled = True
    End Sub
End Class