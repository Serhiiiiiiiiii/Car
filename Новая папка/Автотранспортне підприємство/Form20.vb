﻿Public Class Посади_звіт

    Private Sub Form20_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Автотранспортне_підприємствоDataSet.Посади". При необходимости она может быть перемещена или удалена.
        Me.ПосадиTableAdapter.Fill(Me.Автотранспортне_підприємствоDataSet.Посади)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Посади_табл.Show()
        Me.Hide()
    End Sub
End Class