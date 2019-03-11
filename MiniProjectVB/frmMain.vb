Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnProtype_Click(sender As Object, e As EventArgs) Handles btnProtype.Click
        frmProtype.Show()
    End Sub

    Private Sub btnPros_Click(sender As Object, e As EventArgs) Handles btnPros.Click
        frmPros.Show()
    End Sub

    Private Sub btnCorp_Click(sender As Object, e As EventArgs) Handles btnCorp.Click
        frmCorp.Show()
    End Sub

    Private Sub btnDep_Click(sender As Object, e As EventArgs) Handles btnDep.Click
        frmDep.Show()
    End Sub

    Private Sub btnEmp_Click(sender As Object, e As EventArgs) Handles btnEmp.Click
        frmEmp.Show()
    End Sub

    Private Sub btnCus_Click(sender As Object, e As EventArgs) Handles btnCus.Click
        frmCus.Show()
    End Sub

    Private Sub btnSell_Click(sender As Object, e As EventArgs) Handles btnSell.Click
        frmSale.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
    End Sub
End Class