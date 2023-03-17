Imports System.Data.SqlClient

Public Class Form1

    Dim myConnection As SqlConnection
    Dim myCommands As SqlCommand
    Dim myAdapter As SqlDataAdapter
    Dim myDataset As DataSet
    Dim myDatatable As DataTable

    Private Sub Connection()
        myConnection = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Visual Basic\vs_2010\EmpInfo\EmpInfo\Database1.mdf;Integrated Security=True;User Instance=True")
        myConnection.Open()
        Try
            If myConnection.State = ConnectionState.Open Then
                'MsgBox("Connected")
            End If
        Catch
            MsgBox("Error Can't Connected")
        End Try
    End Sub

    Private Sub CreateTable()

        myCommands = New SqlCommand("CREATE TABLE dept(DEPTNO INT PRIMARY KEY,DEPTNAME VARCHAR(20))", myConnection)
        Try
            myCommands.ExecuteNonQuery()
            'MsgBox("Tables emp created !")
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        myCommands = New SqlCommand("CREATE TABLE emp(EMPNO INT PRIMARY KEY,EMPNAME VARCHAR(20),DESIGNATION VARCHAR(10),SALARY INT,DEPTNO INT FOREIGN KEY REFERENCES DEPT(DEPTNO))", myConnection)
        Try
            myCommands.ExecuteNonQuery()
            'MsgBox("Tables dept cretaed !")
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub InsertData()
        Try
            myCommands = New SqlCommand("Insert into dept values(@deptno,@deptname)", Connection:=myConnection)
            Try
                myCommands.Parameters.AddWithValue("@deptno", Convert.ToInt32(TextBoxDeptNo.Text))
                myCommands.Parameters.AddWithValue("@deptname", ComboBoxDeptName.Text)
                myCommands.ExecuteNonQuery()
                ' MsgBox("Data Inserted in Dept")
            Catch ex As Exception
                'MsgBox("Data Not Inserted")
            End Try
            Try
                myCommands = New SqlCommand("Insert into emp values(@empno,@empname,@designation,@salary,@deptno)", Connection:=myConnection)
                Try
                    myCommands.Parameters.AddWithValue("@empno", Convert.ToInt32(TextBoxEmpno.Text))
                    myCommands.Parameters.AddWithValue("@empname", TextBoxEmpname.Text)
                    myCommands.Parameters.AddWithValue("@designation", TextBoxDesignation.Text)
                    myCommands.Parameters.AddWithValue("@salary", Convert.ToInt32(TextBoxSalary.Text))
                    myCommands.Parameters.AddWithValue("@deptno", Convert.ToInt32(TextBoxDeptNo.Text))
                    myCommands.ExecuteNonQuery()
                    'MsgBox("Data Inserted in Emp")
                Catch ex As Exception
                    'MsgBox("Data Not Inserted")
                End Try
            Catch aa As Exception
                MsgBox(aa.Message)
            End Try
        Catch df As Exception
            MsgBox(df.Message)
        End Try


    End Sub

    Private Sub ValidationCheck()
        If TextBoxEmpno.Text = "" And TextBoxEmpname.Text = "" And TextBoxDesignation.Text = "" And TextBoxSalary.Text = "" And TextBoxDeptNo.Text = "" And ComboBoxDeptName.Text = "" Then
            MsgBox("All values empty !")
            Return
        End If

        If TextBoxEmpno.Text = "" Then
            MsgBox("Please Insert empNo")
            Return
        End If

        If TextBoxEmpname.Text = "" Then
            MsgBox("Please Insert empName")
            Return
        End If

        If TextBoxDesignation.Text = "" Then
            MsgBox("Please Insert Designation")
            Return
        End If

        If TextBoxSalary.Text = "" Then
            MsgBox("Please Insert Salary")
            Return
        End If

        If TextBoxDeptNo.Text = "" Then
            MsgBox("Please Insert deptNo")
            Return
        End If

        If ComboBoxDeptName.Text = "-- Choose Dept --" Or ComboBoxDeptName.Text = "" Then
            MsgBox("Please Insert deptName")
            Return
        End If

    End Sub

    Private Sub ShowData()
        'Try
        '    myAdapter = New SqlDataAdapter("select * from dept", myConnection)
        '    myDataset = New DataSet()
        '    myAdapter.Fill(myDataset, "dept")
        '    DataGridViewReader.DataSource = myDataset.Tables(0).DefaultView
        'Catch
        '    MsgBox("error")
        'End Try

        'Try
        '    myAdapter = New SqlDataAdapter("select * from emp", myConnection)
        '    myDataset = New DataSet()
        '    myAdapter.Fill(myDataset, "emp")
        '    DataGridViewReader.DataSource = myDataset.Tables(0).DefaultView
        'Catch
        '    MsgBox("error1")
        'End Try

        Try
            myCommands = New SqlCommand("select d.DeptNo,EmpNo,EmpName,Designation,DeptName,Salary from emp , dept d where emp.deptno=d.deptno ", myConnection)
            myCommands.ExecuteNonQuery()
            myDatatable = New DataTable()
            myAdapter = New SqlDataAdapter(myCommands)
            myAdapter.Fill(myDatatable)
            DataGridViewReader.DataSource = myDatatable
        Catch
            MsgBox("error3")
        End Try

    End Sub

    Private Sub DeleteData()
        Try
            If DataGridViewReader.RowCount = 0 Then
                MsgBox("Empty Data")
                Return
            End If

            If MsgBox("Want to deleted data ?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Information") = MsgBoxResult.Cancel Then Return

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            If DataGridViewReader.AreAllCellsSelected(0) = True Then
                Try

                    Try
                        myCommands = New SqlCommand("delete from emp", myConnection)
                        myCommands.ExecuteNonQuery()
                    Catch es As Exception
                        'MsgBox(es.Message)
                    End Try

                    Try
                        myCommands = New SqlCommand("delete from dept", myConnection)
                        myCommands.ExecuteNonQuery()
                    Catch es As Exception
                        'MsgBox(es.Message)
                    End Try

                    MsgBox("Deleted")
                    ShowData()
                Catch ak As Exception
                    MsgBox(ak.Message)
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            For Each row As DataGridViewRow In DataGridViewReader.SelectedRows
                If row.Selected Then
                    Try
                        Try
                            myCommands = New SqlCommand("Delete from emp where deptno='" & row.DataBoundItem(0).ToString & "'", myConnection)
                            myCommands.ExecuteNonQuery()
                        Catch ex As Exception
                            'MsgBox(ex.Message)
                        End Try

                        Try
                            myCommands = New SqlCommand("delete from dept where deptno='" & row.DataBoundItem(0).ToString & "'", myConnection)
                            myCommands.ExecuteNonQuery()
                        Catch ex As Exception
                            'MsgBox(ex.Message)
                        End Try
                        MsgBox("Deleted")
                        ShowData()
                    Catch chk As Exception
                        MsgBox(chk.Message)
                    End Try
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub ButtonShow_Click(sender As System.Object, e As System.EventArgs) Handles ButtonShow.Click
        ValidationCheck()
        Connection()
        CreateTable()
        InsertData()
        ShowData()
    End Sub

    Private Sub ButtonRefresh_Click(sender As System.Object, e As System.EventArgs) Handles ButtonRefresh.Click
        Connection()
        ShowData()
    End Sub

    Private Sub ButtonDelete_Click(sender As System.Object, e As System.EventArgs) Handles ButtonDelete.Click
        Connection()
        DeleteData()
    End Sub

    Private Sub ButtonReset_Click(sender As System.Object, e As System.EventArgs) Handles ButtonReset.Click
        TextBoxEmpno.Clear()
        TextBoxEmpname.Clear()
        TextBoxSalary.Clear()
        TextBoxDesignation.Clear()
        ComboBoxDeptName.SelectedText = "-- Choose Dept --"
        TextBoxDeptNo.Clear()
    End Sub

    Private Sub UpdateData()
        If MsgBox(" Action Under Development !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Update Info") = MsgBoxResult.Ok Then Return
        ShowData()
        Try
            Try
                myCommands = New SqlCommand("Update emp set empno=@empno, empname=@empname, designation=@designation, salary=@salary where deptno=@deptno", myConnection)
                myCommands.Parameters.AddWithValue("@empno", Convert.ToInt32(TextBoxEmpno.Text))
                myCommands.Parameters.AddWithValue("@empname", TextBoxEmpname.Text)
                myCommands.Parameters.AddWithValue("@designation", TextBoxDesignation.Text)
                myCommands.Parameters.AddWithValue("@salary", Convert.ToInt32(TextBoxSalary.Text))
                myCommands.Parameters.AddWithValue("@deptno", Convert.ToInt32(TextBoxDeptNo.Text))
                myCommands.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Try
                myCommands = New SqlCommand("Update dept set deptname=@deptname where deptno=@deptno", myConnection)
                myCommands.Parameters.AddWithValue("@deptno", Convert.ToInt32(TextBoxDeptNo.Text))
                myCommands.Parameters.AddWithValue("@deptname", ComboBoxDeptName.Text)
                myCommands.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MsgBox("Update successfully !", MsgBoxStyle.Information, "Information")
            ShowData()
        Catch df As Exception
            MsgBox(df.Message)
        End Try
    End Sub

    Private Sub ButtonUpdate_Click(sender As System.Object, e As System.EventArgs) Handles ButtonUpdate.Click
        ButtonUpdate.Enabled = False
        Connection()
        UpdateData()
    End Sub

    Private Sub delEmp_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles delEmp.CheckedChanged
            Connection()
            myCommands = New SqlCommand("drop table emp", myConnection)
            Try
                myCommands.ExecuteNonQuery()
                MsgBox("Emp deleted !", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Admin")
            Catch amd As Exception
                MsgBox("Data not found ! ")
            End Try
    End Sub

    Private Sub delDept_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles delDept.CheckedChanged
        If delEmp.CheckState = CheckState.Checked Then
            Connection()
            myCommands = New SqlCommand("drop table dept", myConnection)
            Try
                myCommands.ExecuteNonQuery()
                MsgBox("dept deleted !", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Admin")
            Catch amd As Exception
                MsgBox("Data not found ! ")
            End Try
        ElseIf (delEmp.CheckState = CheckState.Unchecked) Then
            MsgBox("First Deleted emp..", MsgBoxStyle.Information, "Admin")
        End If
        
    End Sub

    Private Sub ButtonSearch_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSearch.Click
        MsgBox(" Action Under development", MsgBoxStyle.Information, "Admin")
        TextBoxSearch.Enabled = False
        ButtonSearch.Enabled = False

    End Sub
End Class
