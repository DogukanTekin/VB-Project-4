Public Class Form1
    Dim ogrenci() As String = {"Doğukan", "Yunus", "Anıl", "Emre", "Kubilay"}
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ad() As String = {"Doğukan", "Yunus", "Anıl", "Emre", "Kubilay"}
        TextBox1.Text = ad(2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ad() As String = {"Doğukan", "Yunus", "Anıl", "Emre", "Kubilay"}
        Dim numara As Integer = CInt(InputBox("Kaçıncı Elemanı Görmek İstiyorsunuz")) - 1
        TextBox1.Text = ad(numara)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num() As Integer = {0, 1, 2, 3}
        For i = 0 To 3
            ListBox1.Items.Add(num(i).ToString())
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To 4
            ListBox2.Items.Add(ogrenci(i).ToString())
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim hangi As Integer = CInt(InputBox("Kaçıncı Öğrenciyi Görmek İstiyorsunuz")) - 1
        TextBox2.Text = ogrenci(hangi)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim ogrenciler(3) As String
        ogrenciler(0) = "Doğukan"
        ogrenciler(1) = "Yunus"
        ogrenciler(2) = "Anıl"
        ogrenciler(3) = "Emre"
        Dim toplam_not As Integer
        For i = 0 To 3
            Dim nott As Integer = CInt(InputBox(ogrenciler(i).ToString + " Adlı Öğrencinin Notunu Giriniz"))
            toplam_not += nott
        Next
        MsgBox((toplam_not / ogrenciler.Length).ToString())
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim uzunluk As Integer = CInt(InputBox("Kaç Elemanlı Dizi İstiyorsunuz")) - 1
        Dim dizi(uzunluk) As String
        For i = 0 To uzunluk
            Dim eleman As String = InputBox((i + 1).ToString() + ". Elemanın Adını Giriniz")
            dizi(i) = eleman
        Next
        Dim hangi As Integer = CInt(InputBox("Kaçıncı Elemanı Görmek İstiyorsunuz")) - 1
        MsgBox(dizi(hangi))
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ListBox3.Items.Clear()
        Dim ad_il(,) As String = {{"Doğukan", "Anıl", "Yunus"}, {"Ordu", "Ünye", "İzmir"}}
        Dim rnd As New Random
        For i = 0 To (ad_il.Length / 3)
            ad_il(1, i) = ad_il(1, rnd.Next(0, 3))
            ListBox3.Items.Add(ad_il(0, i) + " - " + ad_il(1, i))
        Next
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ListBox4.Items.Clear()
        Dim kac_ogrenci As Integer = CInt(InputBox("Kaç Öğrenci Girişi Yapacaksınız")) - 1
        Dim notlar(kac_ogrenci, kac_ogrenci) As String
        For i = 0 To kac_ogrenci
            notlar(0, i) = InputBox((i + 1).ToString() + ". Öğrencinin Adını Giriniz")
            Dim vize, final As Integer
            Dim ort As Double
            vize = CInt(InputBox((i + 1).ToString() + ". Öğrencinin Vize Notunu Giriniz"))
            final = CInt(InputBox((i + 1).ToString() + ". Öğrencinin Final Notunu Giriniz"))
            ort = (vize + final) / 2
            notlar(1, i) = ort.ToString()
            ListBox4.Items.Add(notlar(0, i) + " - " + notlar(1, i))
        Next
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ListBox5.Items.Clear()
        Dim kactan As String = InputBox("Kaçtan Başlasın")
        Dim yazi As String
        For i = CInt(kactan) To 1 Step -1
            yazi += i.ToString()
        Next
        For i = yazi.Length To 1 Step -1
            ListBox5.Items.Add(yazi.Substring(yazi.Length - i, i))
        Next
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ListBox6.Items.Clear()
        Dim yazi, ters As String
        yazi = "MAC"
        ters = StrReverse(yazi.Substring(0, 2))
        For i = 0 To yazi.Length - 1
            ListBox6.Items.Add(Space(i) + yazi.Substring(i, yazi.Length - i) + ters.Substring(0, ters.Length - i))
        Next
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ListBox7.Items.Clear()
        Dim sayi As String = InputBox("Ardışık Sayı Giriniz")
        Dim ters As String = StrReverse(sayi.Substring(1, sayi.Length - 1))
        For i = 0 To sayi.Length - 1
            ListBox7.Items.Add(Space(i) + ters.Substring(i, ters.Length - i) + sayi.Substring(0, sayi.Length - i))
        Next
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        ListBox8.Items.Clear()
        Dim sayi As Integer = CInt(InputBox("Kaçtan Başlasın"))
        For i = 0 To sayi - 1
            ListBox8.Items.Add((i + 1).ToString() + ". Sayı : " + (sayi + i).ToString())
        Next
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim sayi As Integer = CInt(InputBox("Faktöriyelini Bulmak İstediğiniz Sayıyı Giriniz"))
        Dim carpim As Integer = 1
        For i = 1 To sayi
            carpim *= i
        Next
        MsgBox(sayi.ToString() + " Sayısının Faktöriyeli : " + carpim.ToString())
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim rnd As New Random
        Dim i As Integer
        Dim sayilar(5) As String
        Do While (i <= 5)
            Dim sayi As Integer = rnd.Next(1, 49)
            If sayilar.Contains(sayi.ToString()) Then
            Else
                sayilar(i) = sayi.ToString()
                i += 1
            End If
        Loop
        TextBox3.Text = sayilar(0)
        TextBox4.Text = sayilar(1)
        TextBox5.Text = sayilar(2)
        TextBox6.Text = sayilar(3)
        TextBox7.Text = sayilar(4)
        TextBox8.Text = sayilar(5)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        ListBox9.Items.Clear()
        Dim yazarlar(,) As String = {{"Anıl", "Emre", "Doğukan", "Yunus"}, {"A", "B", "C", "D"}}
        Dim sayilar(3), yeniyazarlar(3) As String
        Dim i, sayi As Integer
        Dim rnd As New Random
        Do While (i < (yazarlar.Length / 2))
            sayi = rnd.Next(0, yazarlar.Length / 2)
            If sayilar.Contains(sayi.ToString()) Then
            Else
                sayilar(i) = sayi.ToString()
                i += 1
            End If
        Loop
        For i = 0 To (yazarlar.Length / 2) - 1
            yeniyazarlar(i) = yazarlar(1, CInt(sayilar(i)))
        Next
        For i = 0 To yeniyazarlar.Length - 1
            yazarlar(1, i) = yeniyazarlar(i)
            ListBox9.Items.Add(yazarlar(0, i) + " - " + yazarlar(1, i))
        Next
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If String.Compare(TextBox9.Text, TextBox10.Text) = 0 Then
            MsgBox("Girilen Kelimeler Aynı")
        Else
            MsgBox("Girilen Kelimeler Farklı")
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If TextBox9.Text.Equals(TextBox10.Text) Then
            MsgBox("Girilen Kelimeler Aynı")
        Else
            MsgBox("Girilen Kelimeler Farklı")
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If TextBox11.Text.StartsWith(TextBox12.Text) Then
            MsgBox("Başlangıçta Aranan Harfler Var")
        Else
            MsgBox("Başlangıçta Aranan Harfler Yok")
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If TextBox11.Text.EndsWith(TextBox12.Text) Then
            MsgBox("Sonda Aranan Harfler Var")
        Else
            MsgBox("Sonda Aranan Harfler Yok")
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        MsgBox(TextBox13.Text.Substring(CInt(TextBox14.Text), CInt(TextBox15.Text)))
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Dim mevsimler As String = "Kış, İlkbahar, Yaz, Sonbahar"
        Dim kelimeler() As String
        kelimeler = mevsimler.Split(",")
        For i = 0 To 3
            MsgBox(kelimeler(i))
        Next
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        ListBox10.Items.Clear()
        Dim ad As String = "Dokuz;Eylül;Üniversitesi;İzmir;Meslek;Yüksekokulu;Bilgisayar;Programcılığı;Bölümü"
        Dim kelimeler() As String
        kelimeler = ad.Split(";")
        For i = 0 To kelimeler.Length - 1
            ListBox10.Items.Add(kelimeler(i))
        Next
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        ListBox11.Items.Clear()
        Dim kac_satir As Integer = CInt(InputBox("Kaç Satır İstiyorsunuz ?"))
        Dim yazi As String = "x"
        For i = 0 To kac_satir - 1
            ListBox11.Items.Add(Space(kac_satir - i) + yazi)
            yazi += "xx"
        Next
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        ListBox12.Items.Clear()
        Dim cumle As String = "ismail;düşmez.1959+izmir 123"
        Dim i As Integer
        Dim kelimeler() As String
        kelimeler = cumle.Split(CChar(";"), CChar("."), CChar("+"), CChar(" "))
        For i = 0 To kelimeler.Length - 1
            ListBox12.Items.Add(kelimeler(i))
        Next
    End Sub
End Class
