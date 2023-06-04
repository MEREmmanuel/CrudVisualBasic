Imports System.Data.SqlClient
Public Class Form1
    Dim con As New SqlConnection("Data Source=LAPTOP-FRET7KLH;Initial Catalog=CRUD;User ID=sa;Password=Djrosemm87#")
    Private Sub ButtonCrear_Click(sender As Object, e As EventArgs) Handles ButtonCrear.Click
        Dim nombre As String = TextNombre.Text
        Dim carrera As String = ComboBoxCarrera.Text
        Dim control As Integer = TextControl.Text
        Dim nss As Long = TextNSS.Text
        con.Open()
        Dim command As New SqlCommand("Insert Alumno_Setup_Tab values('" & nombre & "','" & carrera & "'," & control & "," & nss & ")", con)
        command.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Successfully Inserted.")
        LoadDataInGrid()
    End Sub

    Private Sub LoadDataInGrid()
        Dim command As New SqlCommand("select * from Alumno_Setup_Tab", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataInGrid()
    End Sub

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        Dim nombre As String = TextNombre.Text
        Dim carrera As String = ComboBoxCarrera.Text
        Dim control As Integer = TextControl.Text
        Dim nss As Long = TextNSS.Text
        con.Open()
        Dim command As New SqlCommand("Update Alumno_Setup_Tab set Carrera = '" & carrera & "', [Numero de control] = " & control & ", NSS = " & nss & " where Nombre = '" & nombre & "'", con)
        command.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Successfully Update.")
        LoadDataInGrid()
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        If MessageBox.Show("Are you sure?", "Delete Document", MessageBoxButtons.YesNo) Then
            Dim nombre As String = TextNombre.Text
            con.Open()
            Dim command As New SqlCommand("Delete Alumno_Setup_Tab where Nombre = '" & nombre & "'", con)
            command.ExecuteNonQuery()
            MessageBox.Show("Succesfully Delete")
            con.Close()
            LoadDataInGrid()
        End If
    End Sub

    Private Sub ButtonLeer_Click(sender As Object, e As EventArgs) Handles ButtonLeer.Click
        Dim nombre As String = TextNombre.Text
        Dim command As New SqlCommand("select * from Alumno_Setup_Tab where Nombre = '" & nombre & "'", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
End Class
