Public Class Form1

    

    Private Sub btncalculate_Click(sender As Object, e As EventArgs) Handles btncalculate.Click
        txttotal.Text = ""
        If txtname.Text = "" Then
            MessageBox.Show("chua nhap ten", "nhac nho", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim tien As Decimal = 0
            If chkclearning.Checked = True Then
                tien += Val(lblclearning.Text)
            End If
            If chkcavityfilling.Checked = True Then
                tien += Val(lblcavityfilling.Text)
            End If
            If chkxray.Checked = True Then
                tien += Val(lblxray.Text)
            End If

            
            txttotal.Text = String.Format("{0:C}", tien)

        End If

    End Sub

    Private Sub chkclearning_CheckedChanged(sender As Object, e As EventArgs) Handles chkclearning.CheckedChanged
        lblclearning.Text = 45
    End Sub

    Private Sub chkcavityfilling_CheckedChanged(sender As Object, e As EventArgs) Handles chkcavityfilling.CheckedChanged
        lblcavityfilling.Text = 40
    End Sub

    Private Sub chkxray_CheckedChanged(sender As Object, e As EventArgs) Handles chkxray.CheckedChanged
        lblxray.Text = 30
    End Sub
End Class
