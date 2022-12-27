﻿Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text

Public Class Clsfunct
    Private server As String = ""
    Private uid As String = ""
    Private pass As String = ""
    Private db As String
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
        db = sr.ReadLine()
        uid = sr.ReadLine()
        pass = sr.ReadLine()


        server = Decryption(server, secretkey)
        db = Decryption(db, secretkey)
        uid = Decryption(uid, secretkey)
        pass = Decryption(pass, secretkey)

        Dim cons As String = "Data Source =" & server & "; DataBase =" & db & "; User Id =" & uid & "; Password =" & pass & ";"
        'Dim cons As String = "Data Source =(local); DataBase =master; User Id =sa; Password =admin@123;"
        Return cons
    End Function
    Friend Function customer(ByVal condt As String, ByVal dbname As String) As DataSet
        Dim cmd As New SqlCommand
        Dim sql As String = "Select IDCUST,NAMECUST from " & dbname & ".dbo.ARCUS  " & condt & " "
        Dim da As New SqlDataAdapter
        Dim con As New SqlConnection(Readconnectionstring())
        With cmd
            .CommandText = sql
            .CommandType = CommandType.Text
            .Connection = con
        End With
        da.SelectCommand = cmd
        Dim ds As New DataSet
        da.Fill(ds)
        Return ds
    End Function
    Friend Function category(ByVal condt As String, ByVal dbname As String) As DataSet
        Dim cmd As New SqlCommand
        Dim sql As String = "select category ,[DESC]   from" & dbname & ".dbo.ICCATG  " & condt & " "
        Dim da As New SqlDataAdapter
        Dim con As New SqlConnection(Readconnectionstring())
        With cmd
            .CommandText = sql
            .CommandType = CommandType.Text
            .Connection = con
        End With
        da.SelectCommand = cmd
        Dim ds As New DataSet
        da.Fill(ds)
        Return ds
    End Function
    Friend Function Items(ByVal condt As String, ByVal dbname As String) As DataSet
        Dim cmd As New SqlCommand
        Dim sql As String = "select ITEMNO ,[DESC] from  " & dbname & ".dbo.ICITEM  " & condt & " "
        Dim da As New SqlDataAdapter
        Dim con As New SqlConnection(Readconnectionstring())
        With cmd
            .CommandText = sql
            .CommandType = CommandType.Text
            .Connection = con
        End With
        da.SelectCommand = cmd
        Dim ds As New DataSet
        da.Fill(ds)
        Return ds
    End Function

    Friend Function Location(ByVal condt As String, ByVal dbname As String) As DataSet
        Dim cmd As New SqlCommand
        Dim sql As String = "select LOCATION ,[DESC]   from   " & dbname & ".dbo.ICLOC  " & condt & " "
        Dim da As New SqlDataAdapter
        Dim con As New SqlConnection(Readconnectionstring())
        With cmd
            .CommandText = sql
            .CommandType = CommandType.Text
            .Connection = con
        End With
        da.SelectCommand = cmd
        Dim ds As New DataSet
        da.Fill(ds)
        Return ds
    End Function
    Friend Function optfield(ByVal condt As String, ByVal dbname As String) As DataSet
        Dim cmd As New SqlCommand
        Dim sql As String = "select VALUE,VDESC from  " & dbname & ".dbo.csoptfd " & condt & " "
        Dim da As New SqlDataAdapter
        Dim con As New SqlConnection(Readconnectionstring())
        With cmd
            .CommandText = sql
            .CommandType = CommandType.Text
            .Connection = con
        End With
        da.SelectCommand = cmd
        Dim ds As New DataSet
        da.Fill(ds)
        Return ds
    End Function

    Friend Function sagecompany() As DataSet
        Dim cmd As New SqlCommand
        Dim sql As String = "SELECT name FROM sys.databases  where name like '%DAT%' order by name"
        Dim da As New SqlDataAdapter
        Dim con As New SqlConnection(Readconnectionstring())
        With cmd
            .CommandText = sql
            .CommandType = CommandType.Text
            .Connection = con
        End With
        da.SelectCommand = cmd
        Dim ds As New DataSet
        da.Fill(ds)
        Return ds
    End Function
    Friend Function sagecompanydesc(ByVal dbname As String) As DataSet
        Dim cmd As New SqlCommand
        Dim sql As String = "SELECT CONAME From " & dbname & ".dbo.CSCOM  order by orgid "
        Dim da As New SqlDataAdapter
        Dim con As New SqlConnection(Readconnectionstring())
        With cmd
            .CommandText = sql
            .CommandType = CommandType.Text
            .Connection = con
        End With
        da.SelectCommand = cmd
        Dim ds As New DataSet
        da.Fill(ds)
        Return ds
    End Function

    Friend Function EnterdBy(ByVal condt As String, ByVal condt2 As String, ByVal dbname As String) As DataSet
        Dim cmd As New SqlCommand
        Dim sql As String = "select distinct  ENTEREDBY   from " & dbname & ".dbo.OEINVH    " & condt & "  " & _
                            " union all " & _
                            " select distinct ENTEREDBY from " & dbname & ".dbo.oecrdh " & _
                            " where ENTEREDBY not in(select  ENTEREDBY  from " & dbname & ".dbo.OEINVH  )  " & condt2 & "  order by  ENTEREDBY"
        Dim da As New SqlDataAdapter
        Dim con As New SqlConnection(Readconnectionstring())
        With cmd
            .CommandText = sql
            .CommandType = CommandType.Text
            .Connection = con
        End With
        da.SelectCommand = cmd
        Dim ds As New DataSet
        da.Fill(ds)
        Return ds
    End Function

    Friend Function Dailyreport(ByVal dbname As String, ByVal fdate As String, ByVal tdate As String, ByVal floc As String, ByVal tloc As String, ByVal enterby As String) As DataSet
        Dim cmd As New SqlCommand
        Dim sql As String = " Select h.ENTEREDBY,h.INVNUMBER,d.LINENUM,convert(datetime,left(convert(nvarchar,h.invdate,120),10)) as invdate,ITEM,d.[DESC] as Itemname,coalesce(d.ORDQTYORD,0) as qty,h.customer as custno , h.BILNAME as customer,h.REFERENCE as phone,'' as SERIALNUMF,coalesce(d.TBASE1,0) as amount,h.PONUMBER as PONumber,(coalesce(d.TBASE1,0)+coalesce(d.TAMOUNT1,0)) as totdis  " & _
                            " from " & dbname & ".dbo.oeinvh h," & dbname & ".dbo.oeinvd d " & _
                            " where h.INVUNIQ =d.INVUNIQ  and convert(datetime,left(convert(nvarchar,h.invdate ,120),10)) between '" & fdate & "' and '" & tdate & "' and h.ENTEREDBY like '" & enterby & "'  and d.[LOCATION] between '" & floc & "' and '" & tloc & "' " & _
                            " union all " & _
                            " select h.ENTEREDBY,h.CRDNUMBER,d.LINENUM,convert(datetime,left(convert(nvarchar,h.CRDDATE,120),10)) as invdate,ITEM,d.[DESC] as Itemname,coalesce(d.ORDQTYORD,0) as qty,h.customer as custno , h.BILNAME as customer,h.REFERENCE as phone,'' as SERIALNUMF,coalesce(d.TBASE1,0) as amount,h.PONUMBER as PONumber ,(coalesce(d.TBASE1,0)+coalesce(d.TAMOUNT1,0)) as totdis " & _
                            " from " & dbname & ".dbo.OECRDH h," & dbname & ".dbo.oecrdd d " & _
                            " where h.CRDUNIQ = d.CRDUNIQ " & _
                            " and convert(datetime,left(convert(nvarchar,h.CRDDATE ,120),10)) between '" & fdate & "' and '" & tdate & "' and h.ENTEREDBY like '" & enterby & "'  and d.[LOCATION] between '" & floc & "' and '" & tloc & "' " & _
                            "  order by invdate "
        Dim da As New SqlDataAdapter
        Dim con As New SqlConnection(Readconnectionstring())
        With cmd
            .CommandText = sql
            .CommandType = CommandType.Text
            .Connection = con
        End With
        da.SelectCommand = cmd
        Dim ds As New DataSet
        da.Fill(ds)
        Return ds
    End Function
End Class