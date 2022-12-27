Imports AccpacCOMAPI
Public Class DailyJobs

    Public compid As String = ""
    Private acsignon As New AccpacSignonManager.AccpacSignonMgr
    Public mSession As New AccpacCOMAPI.AccpacSession
    Public compname As String
    Public xdbcom As AccpacDBLink
    Private Sub Butentby_Click(sender As Object, e As EventArgs) Handles Butentby.Click
        Butentby.Enabled = False
        Enteredby.Show()
    End Sub

    Private Sub Bfdloc_Click(sender As Object, e As EventArgs) Handles Bfdloc.Click
        Bfdloc.Enabled = False
        fromloc.Show()
    End Sub

    Private Sub Btdloc_Click(sender As Object, e As EventArgs) Handles Btdloc.Click
        Btdloc.Enabled = False
        toloc.Show()
    End Sub

    Private Sub DailySales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mSession.Init("", "XX", "XX0001", "60A")
            acsignon.Signon(mSession)
            compid = mSession.CompanyID
            compname = mSession.CompanyName

            xdbcom = mSession.GetDBLink(tagDBLinkTypeEnum.DBLINK_COMPANY, tagDBLinkFlagsEnum.DBLINK_FLG_READONLY)

            If compid = "" Then
                Close()
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Close()
        End Try
    End Sub

    Private Sub Butprint_Click(sender As Object, e As EventArgs) Handles Butprint.Click
        Try
            Dim fmonthnew As String = 0
            If DateTimePicker1.Value.Month.ToString.Length < 2 Then
                fmonthnew = "0" & DateTimePicker1.Value.Month
            Else
                fmonthnew = DateTimePicker1.Value.Month
            End If
            Dim tmonthnew As String = 0
            If DateTimePicker2.Value.Month.ToString.Length < 2 Then
                tmonthnew = "0" & DateTimePicker2.Value.Month
            Else
                tmonthnew = DateTimePicker2.Value.Month
            End If

            Dim fdaynew As String = 0
            If DateTimePicker1.Value.Day.ToString.Length < 2 Then
                fdaynew = "0" & DateTimePicker1.Value.Day
            Else
                fdaynew = DateTimePicker1.Value.Day
            End If
            Dim tdaynew As String = 0
            If DateTimePicker2.Value.Day.ToString.Length < 2 Then
                tdaynew = "0" & DateTimePicker2.Value.Day
            Else
                tdaynew = DateTimePicker2.Value.Day
            End If

            Dim fdate As String = DateTimePicker1.Value.Year & fmonthnew & fdaynew

            Dim tdate As String = DateTimePicker2.Value.Year & tmonthnew & tdaynew


            If Trim(Txtfrmloc.Text) <= Trim(Txttoloc.Text) Then
                If fdate <= tdate Then
                    crviewer.Show()
                Else
                    MessageBox.Show("From Date  greater than To Date")
                End If
            Else
                MessageBox.Show("From Location  greater than To Location")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Butexit_Click(sender As Object, e As EventArgs) Handles Butexit.Click
        Close()
    End Sub
End Class
