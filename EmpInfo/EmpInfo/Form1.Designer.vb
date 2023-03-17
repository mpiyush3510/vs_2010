<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DbEmployee = New System.Windows.Forms.GroupBox()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonShow = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ComboBoxDeptName = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxDesignation = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxDeptNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxSalary = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxEmpname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxEmpno = New System.Windows.Forms.TextBox()
        Me.DataGridViewReader = New System.Windows.Forms.DataGridView()
        Me.delEmp = New System.Windows.Forms.CheckBox()
        Me.delDept = New System.Windows.Forms.CheckBox()
        Me.DbEmployee.SuspendLayout()
        CType(Me.DataGridViewReader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DbEmployee
        '
        Me.DbEmployee.BackColor = System.Drawing.Color.Transparent
        Me.DbEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DbEmployee.Controls.Add(Me.delDept)
        Me.DbEmployee.Controls.Add(Me.delEmp)
        Me.DbEmployee.Controls.Add(Me.ButtonSearch)
        Me.DbEmployee.Controls.Add(Me.TextBoxSearch)
        Me.DbEmployee.Controls.Add(Me.ButtonRefresh)
        Me.DbEmployee.Controls.Add(Me.ButtonReset)
        Me.DbEmployee.Controls.Add(Me.ButtonDelete)
        Me.DbEmployee.Controls.Add(Me.ButtonShow)
        Me.DbEmployee.Controls.Add(Me.ButtonUpdate)
        Me.DbEmployee.Controls.Add(Me.ComboBoxDeptName)
        Me.DbEmployee.Controls.Add(Me.Label6)
        Me.DbEmployee.Controls.Add(Me.Label7)
        Me.DbEmployee.Controls.Add(Me.TextBoxDesignation)
        Me.DbEmployee.Controls.Add(Me.Label4)
        Me.DbEmployee.Controls.Add(Me.TextBoxDeptNo)
        Me.DbEmployee.Controls.Add(Me.Label5)
        Me.DbEmployee.Controls.Add(Me.TextBoxSalary)
        Me.DbEmployee.Controls.Add(Me.Label3)
        Me.DbEmployee.Controls.Add(Me.TextBoxEmpname)
        Me.DbEmployee.Controls.Add(Me.Label2)
        Me.DbEmployee.Controls.Add(Me.Label1)
        Me.DbEmployee.Controls.Add(Me.TextBoxEmpno)
        Me.DbEmployee.Location = New System.Drawing.Point(35, 29)
        Me.DbEmployee.Name = "DbEmployee"
        Me.DbEmployee.Size = New System.Drawing.Size(1255, 605)
        Me.DbEmployee.TabIndex = 0
        Me.DbEmployee.TabStop = False
        Me.DbEmployee.Text = "Db_Employee"
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Location = New System.Drawing.Point(998, 445)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(121, 40)
        Me.ButtonSearch.TabIndex = 21
        Me.ButtonSearch.Text = "Search"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(356, 475)
        Me.TextBoxSearch.Multiline = True
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(622, 45)
        Me.TextBoxSearch.TabIndex = 20
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(722, 546)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(121, 40)
        Me.ButtonRefresh.TabIndex = 19
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ButtonReset
        '
        Me.ButtonReset.Location = New System.Drawing.Point(504, 546)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(121, 40)
        Me.ButtonReset.TabIndex = 18
        Me.ButtonReset.Text = "Reset"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(998, 503)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(121, 40)
        Me.ButtonDelete.TabIndex = 17
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonShow
        '
        Me.ButtonShow.Location = New System.Drawing.Point(210, 445)
        Me.ButtonShow.Name = "ButtonShow"
        Me.ButtonShow.Size = New System.Drawing.Size(121, 40)
        Me.ButtonShow.TabIndex = 16
        Me.ButtonShow.Text = "Display"
        Me.ButtonShow.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(210, 503)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(121, 40)
        Me.ButtonUpdate.TabIndex = 15
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ComboBoxDeptName
        '
        Me.ComboBoxDeptName.FormattingEnabled = True
        Me.ComboBoxDeptName.Items.AddRange(New Object() {"-- Choose Dept --", "Computer", "IT", "Science", "Communication", "Sales"})
        Me.ComboBoxDeptName.Location = New System.Drawing.Point(889, 292)
        Me.ComboBoxDeptName.Name = "ComboBoxDeptName"
        Me.ComboBoxDeptName.Size = New System.Drawing.Size(209, 33)
        Me.ComboBoxDeptName.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(735, 295)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "DeptName"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(233, 295)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 25)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Designation"
        '
        'TextBoxDesignation
        '
        Me.TextBoxDesignation.Location = New System.Drawing.Point(406, 295)
        Me.TextBoxDesignation.Name = "TextBoxDesignation"
        Me.TextBoxDesignation.Size = New System.Drawing.Size(201, 31)
        Me.TextBoxDesignation.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(735, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "DeptNo"
        '
        'TextBoxDeptNo
        '
        Me.TextBoxDeptNo.Location = New System.Drawing.Point(889, 221)
        Me.TextBoxDeptNo.Name = "TextBoxDeptNo"
        Me.TextBoxDeptNo.Size = New System.Drawing.Size(209, 31)
        Me.TextBoxDeptNo.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(233, 352)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Salary"
        '
        'TextBoxSalary
        '
        Me.TextBoxSalary.Location = New System.Drawing.Point(406, 352)
        Me.TextBoxSalary.Name = "TextBoxSalary"
        Me.TextBoxSalary.Size = New System.Drawing.Size(201, 31)
        Me.TextBoxSalary.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(233, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "EmpName"
        '
        'TextBoxEmpname
        '
        Me.TextBoxEmpname.Location = New System.Drawing.Point(406, 224)
        Me.TextBoxEmpname.Name = "TextBoxEmpname"
        Me.TextBoxEmpname.Size = New System.Drawing.Size(201, 31)
        Me.TextBoxEmpname.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(233, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "EmpNo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Wheat
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(504, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(339, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employee Info"
        '
        'TextBoxEmpno
        '
        Me.TextBoxEmpno.Location = New System.Drawing.Point(406, 161)
        Me.TextBoxEmpno.Name = "TextBoxEmpno"
        Me.TextBoxEmpno.Size = New System.Drawing.Size(201, 31)
        Me.TextBoxEmpno.TabIndex = 0
        '
        'DataGridViewReader
        '
        Me.DataGridViewReader.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridViewReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewReader.Location = New System.Drawing.Point(35, 649)
        Me.DataGridViewReader.Name = "DataGridViewReader"
        Me.DataGridViewReader.RowTemplate.Height = 33
        Me.DataGridViewReader.Size = New System.Drawing.Size(1255, 331)
        Me.DataGridViewReader.TabIndex = 1
        '
        'delEmp
        '
        Me.delEmp.AutoSize = True
        Me.delEmp.Location = New System.Drawing.Point(1010, 61)
        Me.delEmp.Name = "delEmp"
        Me.delEmp.Size = New System.Drawing.Size(155, 29)
        Me.delEmp.TabIndex = 22
        Me.delEmp.Text = "Delete Emp"
        Me.delEmp.UseVisualStyleBackColor = True
        '
        'delDept
        '
        Me.delDept.AutoSize = True
        Me.delDept.Location = New System.Drawing.Point(1010, 109)
        Me.delDept.Name = "delDept"
        Me.delDept.Size = New System.Drawing.Size(157, 29)
        Me.delDept.TabIndex = 23
        Me.delDept.Text = "Delete Dept"
        Me.delDept.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1331, 1025)
        Me.Controls.Add(Me.DataGridViewReader)
        Me.Controls.Add(Me.DbEmployee)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.DbEmployee.ResumeLayout(False)
        Me.DbEmployee.PerformLayout()
        CType(Me.DataGridViewReader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DbEmployee As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewReader As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxEmpno As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSearch As System.Windows.Forms.TextBox
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents ButtonReset As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonShow As System.Windows.Forms.Button
    Friend WithEvents ButtonUpdate As System.Windows.Forms.Button
    Friend WithEvents ComboBoxDeptName As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDesignation As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDeptNo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSalary As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxEmpname As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSearch As System.Windows.Forms.Button
    Friend WithEvents delDept As System.Windows.Forms.CheckBox
    Friend WithEvents delEmp As System.Windows.Forms.CheckBox

End Class
