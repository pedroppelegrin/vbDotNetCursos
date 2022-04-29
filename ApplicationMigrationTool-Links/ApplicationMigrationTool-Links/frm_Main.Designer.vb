<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_Path = New System.Windows.Forms.Button()
        Me.txt_Path = New System.Windows.Forms.TextBox()
        Me.rtb_Text = New System.Windows.Forms.RichTextBox()
        Me.btn_OpenFile = New System.Windows.Forms.Button()
        Me.btn_ConvertToList = New System.Windows.Forms.Button()
        Me.dgv_DataTable = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_DataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Path
        '
        Me.btn_Path.Location = New System.Drawing.Point(746, 12)
        Me.btn_Path.Name = "btn_Path"
        Me.btn_Path.Size = New System.Drawing.Size(42, 29)
        Me.btn_Path.TabIndex = 0
        Me.btn_Path.Text = "..."
        Me.btn_Path.UseVisualStyleBackColor = True
        '
        'txt_Path
        '
        Me.txt_Path.Location = New System.Drawing.Point(12, 12)
        Me.txt_Path.Name = "txt_Path"
        Me.txt_Path.ReadOnly = True
        Me.txt_Path.Size = New System.Drawing.Size(728, 27)
        Me.txt_Path.TabIndex = 1
        '
        'rtb_Text
        '
        Me.rtb_Text.Location = New System.Drawing.Point(12, 80)
        Me.rtb_Text.Name = "rtb_Text"
        Me.rtb_Text.Size = New System.Drawing.Size(776, 358)
        Me.rtb_Text.TabIndex = 2
        Me.rtb_Text.Text = ""
        '
        'btn_OpenFile
        '
        Me.btn_OpenFile.Enabled = False
        Me.btn_OpenFile.Location = New System.Drawing.Point(12, 45)
        Me.btn_OpenFile.Name = "btn_OpenFile"
        Me.btn_OpenFile.Size = New System.Drawing.Size(94, 29)
        Me.btn_OpenFile.TabIndex = 3
        Me.btn_OpenFile.Text = "Open File"
        Me.btn_OpenFile.UseVisualStyleBackColor = True
        '
        'btn_ConvertToList
        '
        Me.btn_ConvertToList.Location = New System.Drawing.Point(112, 45)
        Me.btn_ConvertToList.Name = "btn_ConvertToList"
        Me.btn_ConvertToList.Size = New System.Drawing.Size(94, 29)
        Me.btn_ConvertToList.TabIndex = 4
        Me.btn_ConvertToList.Text = "Convert List"
        Me.btn_ConvertToList.UseVisualStyleBackColor = True
        '
        'dgv_DataTable
        '
        Me.dgv_DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_DataTable.Location = New System.Drawing.Point(12, 444)
        Me.dgv_DataTable.Name = "dgv_DataTable"
        Me.dgv_DataTable.RowHeadersWidth = 51
        Me.dgv_DataTable.RowTemplate.Height = 29
        Me.dgv_DataTable.Size = New System.Drawing.Size(776, 268)
        Me.dgv_DataTable.TabIndex = 5
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 724)
        Me.Controls.Add(Me.dgv_DataTable)
        Me.Controls.Add(Me.btn_ConvertToList)
        Me.Controls.Add(Me.btn_OpenFile)
        Me.Controls.Add(Me.rtb_Text)
        Me.Controls.Add(Me.txt_Path)
        Me.Controls.Add(Me.btn_Path)
        Me.Name = "frm_Main"
        Me.Text = "Form1"
        CType(Me.dgv_DataTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Path As Button
    Friend WithEvents txt_Path As TextBox
    Friend WithEvents rtb_Text As RichTextBox
    Friend WithEvents btn_OpenFile As Button
    Friend WithEvents btn_ConvertToList As Button
    Friend WithEvents dgv_DataTable As DataGridView
End Class
