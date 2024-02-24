<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        dolarAlisText = New Label()
        dolarSatisText = New Label()
        euroAlisText = New Label()
        euroSatisText = New Label()
        btndolarAlis = New Button()
        btndolarSatis = New Button()
        btneuroAlis = New Button()
        btneuroSatis = New Button()
        GroupBox1 = New GroupBox()
        txtKalan = New TextBox()
        txtTutar = New TextBox()
        txtMiktar = New TextBox()
        txtKur = New TextBox()
        btnBozdurma = New Button()
        btnHesap = New Button()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        dinarAlisText = New Label()
        dinarSatisText = New Label()
        Label11 = New Label()
        Label12 = New Label()
        btndinarAlis = New Button()
        btndinarSatis = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(12, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 25)
        Label1.TabIndex = 0
        Label1.Text = "Dolar Alış"
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(12, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 25)
        Label2.TabIndex = 0
        Label2.Text = "Dolar Satış"
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(12, 155)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 25)
        Label3.TabIndex = 0
        Label3.Text = "Euro Alış"
        ' 
        ' Label4
        ' 
        Label4.Location = New Point(12, 209)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 25)
        Label4.TabIndex = 0
        Label4.Text = "Euro Satış"
        ' 
        ' dolarAlisText
        ' 
        dolarAlisText.Location = New Point(106, 55)
        dolarAlisText.Name = "dolarAlisText"
        dolarAlisText.Size = New Size(88, 25)
        dolarAlisText.TabIndex = 0
        ' 
        ' dolarSatisText
        ' 
        dolarSatisText.Location = New Point(106, 109)
        dolarSatisText.Name = "dolarSatisText"
        dolarSatisText.Size = New Size(88, 25)
        dolarSatisText.TabIndex = 0
        ' 
        ' euroAlisText
        ' 
        euroAlisText.Location = New Point(106, 155)
        euroAlisText.Name = "euroAlisText"
        euroAlisText.Size = New Size(88, 25)
        euroAlisText.TabIndex = 0
        ' 
        ' euroSatisText
        ' 
        euroSatisText.Location = New Point(106, 209)
        euroSatisText.Name = "euroSatisText"
        euroSatisText.Size = New Size(88, 25)
        euroSatisText.TabIndex = 0
        ' 
        ' btndolarAlis
        ' 
        btndolarAlis.Location = New Point(262, 55)
        btndolarAlis.Name = "btndolarAlis"
        btndolarAlis.Size = New Size(50, 23)
        btndolarAlis.TabIndex = 1
        btndolarAlis.Text = "..."
        btndolarAlis.UseVisualStyleBackColor = True
        ' 
        ' btndolarSatis
        ' 
        btndolarSatis.Location = New Point(262, 109)
        btndolarSatis.Name = "btndolarSatis"
        btndolarSatis.Size = New Size(50, 23)
        btndolarSatis.TabIndex = 1
        btndolarSatis.Text = "..."
        btndolarSatis.UseVisualStyleBackColor = True
        ' 
        ' btneuroAlis
        ' 
        btneuroAlis.Location = New Point(262, 155)
        btneuroAlis.Name = "btneuroAlis"
        btneuroAlis.Size = New Size(50, 23)
        btneuroAlis.TabIndex = 1
        btneuroAlis.Text = "..."
        btneuroAlis.UseVisualStyleBackColor = True
        ' 
        ' btneuroSatis
        ' 
        btneuroSatis.Location = New Point(262, 209)
        btneuroSatis.Name = "btneuroSatis"
        btneuroSatis.Size = New Size(50, 23)
        btneuroSatis.TabIndex = 1
        btneuroSatis.Text = "..."
        btneuroSatis.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtKalan)
        GroupBox1.Controls.Add(txtTutar)
        GroupBox1.Controls.Add(txtMiktar)
        GroupBox1.Controls.Add(txtKur)
        GroupBox1.Controls.Add(btnBozdurma)
        GroupBox1.Controls.Add(btnHesap)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Location = New Point(399, 55)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(311, 290)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Döviz İşlemler"
        ' 
        ' txtKalan
        ' 
        txtKalan.Location = New Point(98, 194)
        txtKalan.Name = "txtKalan"
        txtKalan.Size = New Size(100, 23)
        txtKalan.TabIndex = 1
        ' 
        ' txtTutar
        ' 
        txtTutar.Location = New Point(98, 140)
        txtTutar.Name = "txtTutar"
        txtTutar.Size = New Size(100, 23)
        txtTutar.TabIndex = 1
        ' 
        ' txtMiktar
        ' 
        txtMiktar.Location = New Point(98, 94)
        txtMiktar.Name = "txtMiktar"
        txtMiktar.Size = New Size(100, 23)
        txtMiktar.TabIndex = 1
        ' 
        ' txtKur
        ' 
        txtKur.Location = New Point(98, 40)
        txtKur.Name = "txtKur"
        txtKur.Size = New Size(100, 23)
        txtKur.TabIndex = 1
        ' 
        ' btnBozdurma
        ' 
        btnBozdurma.Location = New Point(179, 239)
        btnBozdurma.Name = "btnBozdurma"
        btnBozdurma.Size = New Size(126, 33)
        btnBozdurma.TabIndex = 1
        btnBozdurma.Text = "Bozdurma"
        btnBozdurma.UseVisualStyleBackColor = True
        ' 
        ' btnHesap
        ' 
        btnHesap.Location = New Point(6, 239)
        btnHesap.Name = "btnHesap"
        btnHesap.Size = New Size(126, 33)
        btnHesap.TabIndex = 1
        btnHesap.Text = "Hesapla"
        btnHesap.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.ImageAlign = ContentAlignment.MiddleRight
        Label5.Location = New Point(6, 43)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 25)
        Label5.TabIndex = 0
        Label5.Text = "Kur:"
        Label5.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label6
        ' 
        Label6.ImageAlign = ContentAlignment.MiddleRight
        Label6.Location = New Point(6, 97)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 25)
        Label6.TabIndex = 0
        Label6.Text = "Miktar"
        Label6.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label7
        ' 
        Label7.ImageAlign = ContentAlignment.MiddleRight
        Label7.Location = New Point(6, 143)
        Label7.Name = "Label7"
        Label7.Size = New Size(57, 25)
        Label7.TabIndex = 0
        Label7.Text = "Tutar"
        Label7.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label8
        ' 
        Label8.ImageAlign = ContentAlignment.MiddleRight
        Label8.Location = New Point(6, 197)
        Label8.Name = "Label8"
        Label8.Size = New Size(57, 25)
        Label8.TabIndex = 0
        Label8.Text = "Kalan"
        Label8.TextAlign = ContentAlignment.TopRight
        ' 
        ' dinarAlisText
        ' 
        dinarAlisText.Location = New Point(106, 259)
        dinarAlisText.Name = "dinarAlisText"
        dinarAlisText.Size = New Size(88, 25)
        dinarAlisText.TabIndex = 0
        ' 
        ' dinarSatisText
        ' 
        dinarSatisText.Location = New Point(106, 313)
        dinarSatisText.Name = "dinarSatisText"
        dinarSatisText.Size = New Size(88, 25)
        dinarSatisText.TabIndex = 0
        ' 
        ' Label11
        ' 
        Label11.Location = New Point(12, 259)
        Label11.Name = "Label11"
        Label11.Size = New Size(88, 25)
        Label11.TabIndex = 0
        Label11.Text = "Dinar Alış"
        ' 
        ' Label12
        ' 
        Label12.Location = New Point(12, 313)
        Label12.Name = "Label12"
        Label12.Size = New Size(88, 25)
        Label12.TabIndex = 0
        Label12.Text = "Dinar Satış"
        ' 
        ' btndinarAlis
        ' 
        btndinarAlis.Location = New Point(262, 259)
        btndinarAlis.Name = "btndinarAlis"
        btndinarAlis.Size = New Size(50, 23)
        btndinarAlis.TabIndex = 1
        btndinarAlis.Text = "..."
        btndinarAlis.UseVisualStyleBackColor = True
        ' 
        ' btndinarSatis
        ' 
        btndinarSatis.Location = New Point(262, 313)
        btndinarSatis.Name = "btndinarSatis"
        btndinarSatis.Size = New Size(50, 23)
        btndinarSatis.TabIndex = 1
        btndinarSatis.Text = "..."
        btndinarSatis.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Controls.Add(btndinarSatis)
        Controls.Add(btneuroSatis)
        Controls.Add(btndinarAlis)
        Controls.Add(btneuroAlis)
        Controls.Add(btndolarSatis)
        Controls.Add(btndolarAlis)
        Controls.Add(Label12)
        Controls.Add(Label4)
        Controls.Add(Label11)
        Controls.Add(Label3)
        Controls.Add(dinarSatisText)
        Controls.Add(Label2)
        Controls.Add(euroSatisText)
        Controls.Add(dinarAlisText)
        Controls.Add(dolarSatisText)
        Controls.Add(euroAlisText)
        Controls.Add(dolarAlisText)
        Controls.Add(Label1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Döviz Hesaplama"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dolarAlisText As Label
    Friend WithEvents dolarSatisText As Label
    Friend WithEvents euroAlisText As Label
    Friend WithEvents euroSatisText As Label
    Friend WithEvents btndolarAlis As Button
    Friend WithEvents btndolarSatis As Button
    Friend WithEvents btneuroAlis As Button
    Friend WithEvents btneuroSatis As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtKalan As TextBox
    Friend WithEvents txtTutar As TextBox
    Friend WithEvents txtMiktar As TextBox
    Friend WithEvents txtKur As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnBozdurma As Button
    Friend WithEvents btnHesap As Button
    Friend WithEvents dinarAlisText As Label
    Friend WithEvents dinarSatisText As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btndinarAlis As Button
    Friend WithEvents btndinarSatis As Button

End Class
