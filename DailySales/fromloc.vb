Imports AccpacCOMAPI
Public Class fromloc
    Private i As Integer
    Private j As Integer
    Private Sub fromloc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'os.Init("", "XX", "XX0001", "60A")
            'os.OpenWin("", "", "", DailyJobs.compid, System.DateTime.Now, 0)
            ''os.Open("ADMIN", "ADMIN", DailyJobs.compid, System.DateTime.Now, 0)
            'dblink = os.OpenDBLink(DBLinkType.Company, DBLinkFlags.ReadOnly)


            Dim arv As AccpacView
            arv = DailyJobs.xdbcom.OpenView2("IC0370")
            Dim ICLOCds As DataSet = New DataSet("IC")
            Dim cust As DataTable = ICLOCds.Tables.Add("ICLOC")
            Dim name As DataColumn = cust.Columns.Add("LOCATION", Type.GetType("System.String"))
            Dim id As DataColumn = cust.Columns.Add("DESC", Type.GetType("System.String"))
            Dim row As DataRow
            row = cust.NewRow()
            Do While arv.FilterFetch(False)
                Dim cid As String = arv.Fields.FieldByName("LOCATION").Value.ToString()
                Dim cn As String = arv.Fields.FieldByName("DESC").Value.ToString()
                row("LOCATION") = cid
                row("DESC") = cn
                ICLOCds.Tables(0).Rows.Add(row)
                row = cust.NewRow()
            Loop
            Dim icl As New DataGridViewTextBoxColumn
            icl.DataPropertyName = "LOCATION"
            icl.Name = "clidc"
            icl.HeaderText = "Location"
            icl.Width = 150
            DGfcus.Columns.Add(icl)
            Dim ncl As New DataGridViewTextBoxColumn
            ncl.DataPropertyName = "DESC"
            ncl.Name = "colnc"
            ncl.HeaderText = "Description"
            ncl.Width = 190
            DGfcus.Columns.Add(ncl)
            DGfcus.DataSource = ICLOCds.Tables(0)
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
            Dim ICLOCds As DataSet = New DataSet("IC")

            Dim cust As DataTable = ICLOCds.Tables.Add("ICLOC")
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
                ICLOCds.Tables(0).Rows.Add(row)
                row = cust.NewRow()
            Loop
            Dim dt As DataTable = ICLOCds.Tables(0)

            i = DGfcus.CurrentCell.RowIndex
            j = DGfcus.CurrentCell.ColumnIndex
            DailyJobs.txtfrmloc.Text = dt.Rows(i)(0)
            DailyJobs.bfdloc.Enabled = True
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Butcan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butcan.Click
        Close()
        DailyJobs.bfdloc.Enabled = True
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


        Dim ICLOCds As DataSet = New DataSet("IC")

        Dim cust As DataTable = ICLOCds.Tables.Add("ICLOC")
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
            ICLOCds.Tables(0).Rows.Add(row)
            row = cust.NewRow()

        Loop


        DGfcus.DataSource = ICLOCds.Tables(0)


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
            Dim ICLOCds As DataSet = New DataSet("IC")

            Dim cust As DataTable = ICLOCds.Tables.Add("ICLOC")
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
                ICLOCds.Tables(0).Rows.Add(row)
                row = cust.NewRow()
            Loop
            DGfcus.DataSource = ICLOCds.Tables(0)

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
            Dim ICLOCds As DataSet = New DataSet("IC")

            Dim cust As DataTable = ICLOCds.Tables.Add("ICLOC")
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
                ICLOCds.Tables(0).Rows.Add(row)
                row = cust.NewRow()
            Loop
            DGfcus.DataSource = ICLOCds.Tables(0)

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
            Dim ICLOCds As DataSet = New DataSet("IC")

            Dim cust As DataTable = ICLOCds.Tables.Add("ICLOC")
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
                ICLOCds.Tables(0).Rows.Add(row)
                row = cust.NewRow()
            Loop
            DGfcus.DataSource = ICLOCds.Tables(0)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DGfcus_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGfcus.CellContentClick
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
            Dim ICLOCds As DataSet = New DataSet("IC")

            Dim cust As DataTable = ICLOCds.Tables.Add("ICLOC")
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
                ICLOCds.Tables(0).Rows.Add(row)
                row = cust.NewRow()
            Loop
            Dim dt As DataTable = ICLOCds.Tables(0)

            i = DGfcus.CurrentCell.RowIndex
            j = DGfcus.CurrentCell.ColumnIndex
            DailyJobs.txtfrmloc.Text = dt.Rows(i)(0)
            DailyJobs.bfdloc.Enabled = True
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Fromcust_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        DailyJobs.bfdloc.Enabled = True
    End Sub
End Class