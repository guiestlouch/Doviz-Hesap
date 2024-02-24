Imports System.Net
Imports System.Xml
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim bugun As String = "https://www.tcmb.gov.tr/kurlar/today.xml"
        Dim xmlOku As New XmlDocument()
        xmlOku.Load(bugun)

        Dim dolarAlis As String = xmlOku.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/BanknoteSelling").InnerXml
        dolarAlisText.Text = dolarAlis

        Dim dolarSatis As String = xmlOku.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/BanknoteBuying").InnerXml
        dolarSatisText.Text = dolarSatis

        Dim euroAlis As String = xmlOku.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/BanknoteSelling").InnerXml
        euroAlisText.Text = euroAlis

        Dim euroSatis As String = xmlOku.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/BanknoteBuying").InnerXml
        euroSatisText.Text = euroSatis

        Dim dinarAlis As String = xmlOku.SelectSingleNode("Tarih_Date/Currency [@Kod='KWD']/BanknoteSelling").InnerXml
        dinarAlisText.Text = dinarAlis

        Dim dinarSatis As String = xmlOku.SelectSingleNode("Tarih_Date/Currency [@Kod='KWD']/BanknoteBuying").InnerXml
        dinarSatisText.Text = dinarSatis

    End Sub

    Private Sub btndolarAlis_Click(sender As Object, e As EventArgs) Handles btndolarAlis.Click
        txtKur.Text = dolarAlisText.Text
    End Sub

    Private Sub btndolarSatis_Click(sender As Object, e As EventArgs) Handles btndolarSatis.Click
        txtKur.Text = dolarSatisText.Text
    End Sub

    Private Sub btneuroAlis_Click(sender As Object, e As EventArgs) Handles btneuroAlis.Click, btneuroAlis.Click
        txtKur.Text = euroAlisText.Text
    End Sub

    Private Sub btneuroSatis_Click(sender As Object, e As EventArgs) Handles btneuroSatis.Click, btneuroSatis.Click
        txtKur.Text = euroSatisText.Text
    End Sub

    Private Sub btndinarAlis_Click(sender As Object, e As EventArgs) Handles btndinarAlis.Click, btndinarAlis.Click
        txtKur.Text = dinarAlisText.Text
    End Sub

    Private Sub btndinarSatis_Click(sender As Object, e As EventArgs) Handles btndinarSatis.Click, btndinarSatis.Click
        txtKur.Text = dinarSatisText.Text
    End Sub

    Dim kur As Double, miktar As Double, tutar As Double

    Private Sub txtKur_TextChanged(sender As Object, e As EventArgs) Handles txtKur.TextChanged
        txtKur.Text = txtKur.Text.Replace(".", ",")
    End Sub

    Private Sub btnHesap_Click(sender As Object, e As EventArgs) Handles btnHesap.Click
        kur = Convert.ToDouble(txtKur.Text)
        miktar = Convert.ToDouble(txtMiktar.Text)
        tutar = miktar * kur
        txtTutar.Text = tutar.ToString()
    End Sub

    Private Sub btnBozdurma_Click(sender As Object, e As EventArgs) Handles btnBozdurma.Click
        kur = Convert.ToDouble(txtKur.Text)
        Dim miktar As Integer = Convert.ToInt32(txtMiktar.Text)
        Dim tutar As Integer = Convert.ToInt32(miktar / kur)
        txtTutar.Text = tutar.ToString()
        Dim kalan As Double
        kalan = miktar Mod kur
        txtKalan.Text = kalan.ToString()

    End Sub
End Class