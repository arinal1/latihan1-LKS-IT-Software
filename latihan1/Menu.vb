Public Class Menu
    Dim drag As Boolean = False
    Dim mouseX As Integer
    Dim mouseY As Integer
    Sub ulangForm()
        PanelKontenAdmin.Visible = False
        PanelKontenKaryawan.Visible = False
        PanelKontenKasir.Visible = False
        PanelKontenMenu.Visible = False
        PanelKontenRoti.Visible = False
    End Sub

    Private Sub LblNamaMenu_Click(sender As Object, e As EventArgs) Handles LblNamaMenu.Click
        ulangForm()
        PanelKontenMenu.Visible = True
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnDaftarRoti_Click(sender As Object, e As EventArgs) Handles btnDaftarRoti.Click
        ulangForm()
        PanelKontenRoti.Visible = True
    End Sub

    Private Sub btnDaftarKaryawan_Click(sender As Object, e As EventArgs) Handles btnDaftarKaryawan.Click
        ulangForm()
        PanelKontenKaryawan.Visible = True
    End Sub

    Private Sub btnKasir_Click(sender As Object, e As EventArgs) Handles btnKasir.Click
        ulangForm()
        PanelKontenKasir.Visible = True
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        ulangForm()
        PanelKontenAdmin.Visible = True
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles Me.Load
        LblNamaMenu_Click(sender, e)
    End Sub

    Private Sub btnBack2_Click(sender As Object, e As EventArgs) Handles btnBack2.Click
        LblNamaMenu_Click(sender, e)
    End Sub

    Private Sub btnBack3_Click(sender As Object, e As EventArgs) Handles btnBack3.Click
        LblNamaMenu_Click(sender, e)
    End Sub

    Private Sub btnBack4_Click(sender As Object, e As EventArgs) Handles btnBack4.Click
        LblNamaMenu_Click(sender, e)
    End Sub

    Private Sub btnBack1_Click(sender As Object, e As EventArgs) Handles btnBack1.Click
        LblNamaMenu_Click(sender, e)
    End Sub

    Private Sub PanelWindowBar_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelWindowBar.MouseUp
        drag = False
    End Sub

    Private Sub PanelWindowBar_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelWindowBar.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mouseX
            Me.Top = Cursor.Position.Y - mouseY
        End If
    End Sub

    Private Sub PanelWindowBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelWindowBar.MouseDown
        drag = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub
End Class
