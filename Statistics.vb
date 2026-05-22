
Imports System.Data.SqlClient
Public Class Statistics
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Dim baglanti As New SqlConnection("Data Source=DESKTOP-TEBLO4M\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True;")
    Private Sub Statistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        baglanti.Open()

        Dim Command1 = New SqlCommand("select count(*) from EmployeeTable", baglanti)

        Dim dr1 As SqlDataReader = Command1.ExecuteReader()
        While dr1.Read()
            Label2.Text = dr1(0).ToString()
        End While
        dr1.Close()


        Dim Command2 = New SqlCommand("select COUNT (*)  from EmployeeTable where MaritalStatus = 1", baglanti)

        Dim dr2 As SqlDataReader = Command2.ExecuteReader()
        While dr2.Read()
            Label3.Text = dr2(0).ToString()
        End While
        dr2.Close()


        Dim Command3 = New SqlCommand("select count(*) from EmployeeTable where MaritalStatus=0", baglanti)
        Dim dr3 As SqlDataReader = Command3.ExecuteReader()
        While dr3.Read()
            Label6.Text = dr3(0).ToString
        End While
        dr3.Close()


        Dim Command4 = New SqlCommand("select distinct count(city) from EmployeeTable", baglanti)
        Dim dr4 As SqlDataReader = Command4.ExecuteReader()
        While dr4.Read()
            Label8.Text = dr4(0).ToString()
        End While
        dr4.Close()

        Dim Command5 = New SqlCommand("select Sum(Salary) from EmployeeTable", baglanti)
        Dim dr5 As SqlDataReader = Command5.ExecuteReader()
        While dr5.Read()
            Label12.Text = dr5(0)
        End While
        dr5.Close()

        Dim Command6 = New SqlCommand("select avg(Salary) from EmployeeTable", baglanti)
        Dim dr6 As SqlDataReader = Command6.ExecuteReader()
        While dr6.Read()
            Label11.Text = dr6(0)
        End While






        baglanti.Close()



    End Sub
End Class