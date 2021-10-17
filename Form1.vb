Imports System
Imports System.Windows.Forms


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim DataProvider = New DataOperations("10.26.18.90", "YSKPJT")

        Dim bsTasks As BindingSource = New BindingSource()

        bsTasks.DataSource = DataProvider.GetActivePjtList()
        If DataProvider.IsSuccessFul Then
            DataGridView1.DataSource = bsTasks
        Else
            MessageBox.Show($"{DataProvider.LastExceptionMessage}")
        End If

    End Sub


End Class
