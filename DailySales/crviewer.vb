Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows.Forms
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography

Public Class crviewer
    Private rdoc As New ReportDocument
    Private conrpt As New ConnectionInfo()
    Private server As String = ""
    Private uid As String = ""
    Private pass As String = ""
    Private odbc As String = ""

    Friend Function createdes(ByVal key As String) As TripleDES
        Dim md5 As MD5 = New MD5CryptoServiceProvider()
        Dim des As TripleDES = New TripleDESCryptoServiceProvider()
        des.Key = md5.ComputeHash(Encoding.Unicode.GetBytes(key))
        des.IV = New Byte(des.BlockSize \ 8 - 1) {}
        Return des
    End Function
    Friend Function Decryption(ByVal cyphertext As String, ByVal key As String) As String
        Dim b As Byte() = Convert.FromBase64String(cyphertext)
        Dim des As TripleDES = createdes(key)
        Dim ct As ICryptoTransform = des.CreateDecryptor()
        Dim output As Byte() = ct.TransformFinalBlock(b, 0, b.Length)
        Return Encoding.Unicode.GetString(output)
    End Function
    Friend Function Readconnectionstring() As String

        Dim secretkey As String = "Fhghqwjehqwlegtoit123mnk12%&4#"
        Dim path As String = ("txtcon\bcicon.txt")
        Dim sr As New StreamReader(path)

        server = sr.ReadLine()
        Dim db As String = sr.ReadLine()
        uid = sr.ReadLine()
        pass = sr.ReadLine()
        odbc = sr.ReadLine()

        server = Decryption(server, secretkey)
        uid = Decryption(uid, secretkey)
        pass = Decryption(pass, secretkey)
        odbc = Decryption(odbc, secretkey)
        Dim cons As String = "" ' = "Data Source =" & server & "; DataBase =" & Agescreen.compid & "; User Id =" & uid & "; Password =" & pass & ";"

        Return cons
    End Function
    Private Sub crviewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try



            Dim cwvr As New CrystalReportViewer
            cwvr.Dock = DockStyle.Fill
            cwvr.BorderStyle = BorderStyle.None
            Me.Controls.Add(cwvr)
            Dim ds As New DataSet
            Dim c As New Clsfunct
            Dim enterby As String
            Dim fmonthnew As String = 0
            If DailyJobs.DateTimePicker1.Value.Month.ToString.Length < 2 Then
                fmonthnew = "0" & DailyJobs.DateTimePicker1.Value.Month
            Else
                fmonthnew = DailyJobs.DateTimePicker1.Value.Month
            End If
            Dim tmonthnew As String = 0
            If DailyJobs.DateTimePicker2.Value.Month.ToString.Length < 2 Then
                tmonthnew = "0" & DailyJobs.DateTimePicker2.Value.Month
            Else
                tmonthnew = DailyJobs.DateTimePicker2.Value.Month
            End If

            Dim fdaynew As String = 0
            If DailyJobs.DateTimePicker1.Value.Day.ToString.Length < 2 Then
                fdaynew = "0" & DailyJobs.DateTimePicker1.Value.Day
            Else
                fdaynew = DailyJobs.DateTimePicker1.Value.Day
            End If
            Dim tdaynew As String = 0
            If DailyJobs.DateTimePicker2.Value.Day.ToString.Length < 2 Then
                tdaynew = "0" & DailyJobs.DateTimePicker2.Value.Day
            Else
                tdaynew = DailyJobs.DateTimePicker2.Value.Day
            End If

            Dim fdate As String = DailyJobs.DateTimePicker1.Value.Year & "-" & fmonthnew & "-" & fdaynew

            Dim tdate As String = DailyJobs.DateTimePicker2.Value.Year & "-" & tmonthnew & "-" & tdaynew

            If DailyJobs.txtenteredby.Text = Nothing Then
                enterby = "%%"
            Else
                enterby = DailyJobs.txtenteredby.Text
            End If
            ds = c.Dailyreport(DailyJobs.compid, fdate, tdate, DailyJobs.Txtfrmloc.Text, DailyJobs.Txttoloc.Text, enterby)
            'ds.WriteXmlSchema("xml\xdaily.xsd")

            rdoc.Load("reports\DailyJobs.rpt")



            rdoc.SetDataSource(ds)






            'rdoc.SetParameterValue("FromDate", fdate)
            'rdoc.SetParameterValue("ToDate", tdate)
            'rdoc.SetParameterValue("FromLoc", WarehouseNetSales.Txtfrmloc.Text)
            'rdoc.SetParameterValue("ToLoc", WarehouseNetSales.Txttoloc.Text)
            'rdoc.SetParameterValue("FromSector", WarehouseNetSales.Txtfrmsec.Text)
            'rdoc.SetParameterValue("ToSector", WarehouseNetSales.txttosec.Text)
            'rdoc.SetParameterValue("FromCustomer", WarehouseNetSales.txtfrmcus.Text)
            'rdoc.SetParameterValue("ToCustomer", WarehouseNetSales.Txttocus.Text)
            rdoc.SetParameterValue("DB", DailyJobs.compid)
            rdoc.SetParameterValue("Coname", DailyJobs.compname)


            cwvr.ReportSource = rdoc

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If rdoc Is Nothing Then
                rdoc.Close()
                rdoc.Dispose()
            End If
        End Try

    End Sub
End Class