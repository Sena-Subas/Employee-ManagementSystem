Imports System.Data.SqlClient


Public Class Form1



    Sub Clean()

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        TextBox4.Text = ""
        MaskedTextBox1.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False

    End Sub

    Dim baglanti As New SqlConnection("Data Source=DESKTOP-TEBLO4M\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True;")




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.EmployeeTableTableAdapter.Fill(Me.EmployeeDBDataSet.EmployeeTable)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        baglanti.Open()

        Dim prompt As New SqlCommand("Insert INTO EmployeeTable (FirstName,LastName,City,Salary,MaritalStatus,JobTitle ) VALUES (@FirstName,@LastName,@City,@Salary,@MaritalStatus,@JobTitle)", baglanti)
        prompt.Parameters.AddWithValue("@FirstName", TextBox2.Text)
        prompt.Parameters.AddWithValue("@LastName", TextBox3.Text)
        prompt.Parameters.AddWithValue("@City", ComboBox1.Text)
        prompt.Parameters.AddWithValue("@JobTitle", TextBox4.Text)

        ' prompt.Parameters.AddWithValue("@Salary", Convert.ToDecimal(MaskedTextBox1.Text))

        If MaskedTextBox1.Text = "" Then
            prompt.Parameters.AddWithValue("@Salary", DBNull.Value)

        Else
            prompt.Parameters.AddWithValue("@Salary", Convert.ToDecimal(MaskedTextBox1.Text))
        End If




        Dim MaritalStatus As Boolean
        If RadioButton1.Checked Then
            MaritalStatus = False
        Else
            MaritalStatus = True
        End If
        prompt.Parameters.AddWithValue("@MaritalStatus", MaritalStatus)


        prompt.ExecuteNonQuery()
        baglanti.Close()
        MessageBox.Show("Employee Added Successfully")


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Clean()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim selected As Integer = DataGridView1.SelectedCells(0).RowIndex

        TextBox1.Text = DataGridView1.Rows(selected).Cells(0).Value.ToString()
        TextBox2.Text = DataGridView1.Rows(selected).Cells(1).Value.ToString()
        TextBox3.Text = DataGridView1.Rows(selected).Cells(2).Value.ToString()
        ComboBox1.Text = DataGridView1.Rows(selected).Cells(3).Value.ToString()
        MaskedTextBox1.Text = DataGridView1.Rows(selected).Cells(4).Value.ToString()
        TextBox4.Text = DataGridView1.Rows(selected).Cells(6).Value.ToString()


        Dim status As Boolean = DataGridView1.Rows(selected).Cells(5).Value

        If status = True Then

            RadioButton2.Checked = True
        Else

            RadioButton1.Checked = True

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        baglanti.Open()

        Dim deletePrompt As New SqlCommand("Delete from EmployeeTable where EmployeeID=@k1", baglanti)

        deletePrompt.Parameters.AddWithValue("@k1", TextBox1.Text)
        deletePrompt.ExecuteNonQuery()
        MessageBox.Show("Employee Deleted Successfully")

        baglanti.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        baglanti.Open()

        Dim updatePrompt As New SqlCommand("Update EmployeeTable set FirstName=@a1,LastName=@a2,City=@a3,Salary=@a4,MaritalStatus=@a5,JobTitle=@a6 where EmployeeID=@a7 ", baglanti)
        updatePrompt.Parameters.AddWithValue("@a1", TextBox2.Text) 'FirstName
        updatePrompt.Parameters.AddWithValue("@a2", TextBox3.Text) 'LastName 
        updatePrompt.Parameters.AddWithValue("@a3", ComboBox1.Text) 'City
        updatePrompt.Parameters.AddWithValue("@a4", MaskedTextBox1.Text) 'Salary

        Dim MaritalStatus As Boolean
        If RadioButton1.Checked Then
            MaritalStatus = False
        Else
            MaritalStatus = True
        End If

        updatePrompt.Parameters.AddWithValue("@a5", MaritalStatus) 'MaritalStatus
        updatePrompt.Parameters.AddWithValue("@a6", TextBox4.Text) 'JobTitle
        updatePrompt.Parameters.AddWithValue("@a7", TextBox1.Text) 'EmployeeID
        updatePrompt.ExecuteNonQuery()
        baglanti.Close()
        MessageBox.Show("Employee Updated Successfully")

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim fr As Statistics = New Statistics()
        fr.Show()



    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim frg = New Graphics()
        frg.Show()
    End Sub
End Class






