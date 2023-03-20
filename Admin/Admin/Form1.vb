Imports System.Data.SqlClient

Public Class Form1

    Dim dataString As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Visual Basic\vs_2010\Admin\Admin\Admin.mdf;Integrated Security=True;User Instance=True"
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ad As SqlDataAdapter
    Dim dt As DataSet

    Private Sub connection()
        con = New SqlConnection(dataString)
        con.Open()
        Try
            If con.State = ConnectionState.Open Then
                'MsgBox("You are Connected")
            End If
        Catch ec As Exception
            MsgBox(ec.Message)
        End Try
    End Sub

    Private Sub createTable()
        cmd = New SqlCommand("create table Admin(Rno int primary key ,Name varchar(30),Div varchar(10),Bdate date)", con)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("create table")
        Catch ec As Exception
            'MsgBox(ec.Message)
        End Try

    End Sub
    Private Sub insertData()
        validation()
        cmd = New SqlCommand("insert into Admin values(@Rno,@Name,@Div,@Bdate)", con)
        Try
            cmd.Parameters.AddWithValue("@Rno", Convert.ToInt32(TextBoxRno.Text))
            cmd.Parameters.AddWithValue("@Name", TextBoxName.Text)
            cmd.Parameters.AddWithValue("@Div", ComboBoxDiv.Text)
            cmd.Parameters.AddWithValue("@Bdate", DateTimePickerBdate.Value.ToShortDateString)
            cmd.ExecuteNonQuery()
            MsgBox("Inserted")
            clearData()
            GetData()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GetData()
        ad = New SqlDataAdapter("Select * from Admin", con)
        dt = New DataSet
        ad.Fill(dt, "Admin")
        Try
            DataGridViewText.DataSource = dt.Tables(0)
        Catch
            MsgBox("Error to Fetch data")
        End Try
    End Sub

    Private Sub deleteData()
        If DataGridViewText.RowCount = 0 Then
            MsgBox("Empty data")
        End If

        If MsgBox("Want to deleted data ?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then Return

        If DataGridViewText.AreAllCellsSelected(0) = True Then
            cmd = New SqlCommand("Delete from Admin", con)
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Deleted All")
                GetData()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        For Each row As DataGridViewRow In DataGridViewText.SelectedRows
            If row.Selected Then
                Try
                    cmd = New SqlCommand("delete from Admin where rno='" & row.DataBoundItem(0).ToString & "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Deleted")
                    GetData()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Next
    End Sub

    Private Sub updateData()
        If MsgBox("Udate data roll number wise !", MsgBoxStyle.OkOnly, "Admin Info") = MsgBoxResult.Ok Then Return

        cmd = New SqlCommand("update Admin set name=@Name,div=@Div,bdate=@Bdate where rno=@Rno", con)
        Try
            cmd.Parameters.AddWithValue("@Rno", Convert.ToInt32(TextBoxRno.Text))
            cmd.Parameters.AddWithValue("@Name", TextBoxName.Text)
            cmd.Parameters.AddWithValue("@Div", ComboBoxDiv.Text)
            cmd.Parameters.AddWithValue("@Bdate", DateTimePickerBdate.Value.ToShortDateString)
            cmd.ExecuteNonQuery()
            MsgBox("Update")
            clearData()
            GetData()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub validation()
        If TextBoxRno.Text = "" And TextBoxName.Text = "" And ComboBoxDiv.Text = "" Then
            MsgBox("All Values Are Empty")
            Return
        End If

        If TextBoxRno.Text = "" Then
            MsgBox("Please Enter Rno")
            Return
        End If

        If TextBoxName.Text = "" Then
            MsgBox("Please Enter Name")
            Return
        End If

        If ComboBoxDiv.Text = "" Then
            MsgBox("Choose Correct Option")
            Return
        End If
    End Sub

    Private Sub clearData()
        TextBoxRno.Clear()
        TextBoxName.Clear()
        ComboBoxDiv.Text = ""
        DateTimePickerBdate.ResetText()
    End Sub

    Private Sub ButtonSave_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSave.Click
        connection()
        createTable()
        insertData()
    End Sub

    Private Sub ButtonRefresh_Click(sender As System.Object, e As System.EventArgs) Handles ButtonRefresh.Click
        connection()
        GetData()
    End Sub

    Private Sub ButtonDelete_Click(sender As System.Object, e As System.EventArgs) Handles ButtonDelete.Click
        connection()
        deleteData()
    End Sub

    Private Sub ButtonClear_Click(sender As System.Object, e As System.EventArgs) Handles ButtonClear.Click
        clearData()
    End Sub

    Private Sub ButtonUpdate_Click(sender As System.Object, e As System.EventArgs) Handles ButtonUpdate.Click
        connection()
        updateData()
    End Sub
End Class
