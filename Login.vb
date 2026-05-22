
Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Public Class Login

    Dim baglanti As New SqlConnection("Data Source=DESKTOP-TEBLO4M\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True;")
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        baglanti.Open()


        Dim command As New SqlCommand("select * from admin where Username=@p1 and Password=@p2", baglanti)
        command.Parameters.AddWithValue("@p1", TextBox1.Text)
        command.Parameters.AddWithValue("@p2", TextBox2.Text)
        Dim dr As SqlDataReader = command.ExecuteReader()
        If (dr.Read()) Then

            Dim frm As New Form1
            frm.Show()
            Me.Hide()
        Else

            MessageBox.Show("Incorrect username or password")

        End If
        baglanti.Close()
    End Sub
End Class