Imports System.Data.SqlClient

Public Class Graphics
    'Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    'End Sub

    Private Sub Graphics_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim baglanti As New SqlConnection("Data Source=DESKTOP-TEBLO4M\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True;")

        baglanti.Open()

        Dim graphcommand1 = New SqlCommand("select city,count(city) from EmployeeTable group by city", baglanti)
        Dim drg1 As SqlDataReader = graphcommand1.ExecuteReader()
        While drg1.Read()
            Chart1.Series("Cities").Points.AddXY(drg1(0), drg1(1))
        End While
        drg1.Close()


        Dim graphcommand2 = New SqlCommand("select JobTitle, avg(salary)  from EmployeeTable where JobTitle is not null and salary is not null group by JobTitle ", baglanti)
        Dim drg2 As SqlDataReader = graphcommand2.ExecuteReader()
        While drg2.Read()
            Chart2.Series("Job-Salary").Points.AddXY(drg2(0), drg2(1))
        End While
        drg2.Close()



        baglanti.Close()




    End Sub

End Class