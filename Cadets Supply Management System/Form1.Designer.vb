<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        outputLBX = New ListBox()
        outputDGV = New DataGridView()
        homeTC = New TabControl()
        homeTP = New TabPage()
        addCadetTB = New TabPage()
        searchTC = New TabPage()
        editCadetTP = New TabPage()
        CType(outputDGV, ComponentModel.ISupportInitialize).BeginInit()
        homeTC.SuspendLayout()
        SuspendLayout()
        ' 
        ' outputLBX
        ' 
        outputLBX.FormattingEnabled = True
        outputLBX.ItemHeight = 15
        outputLBX.Location = New Point(620, 401)
        outputLBX.Name = "outputLBX"
        outputLBX.Size = New Size(168, 169)
        outputLBX.TabIndex = 0
        ' 
        ' outputDGV
        ' 
        outputDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        outputDGV.Location = New Point(12, 401)
        outputDGV.Name = "outputDGV"
        outputDGV.Size = New Size(592, 111)
        outputDGV.TabIndex = 1
        ' 
        ' homeTC
        ' 
        homeTC.Controls.Add(homeTP)
        homeTC.Controls.Add(searchTC)
        homeTC.Controls.Add(addCadetTB)
        homeTC.Controls.Add(editCadetTP)
        homeTC.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        homeTC.Location = New Point(12, 12)
        homeTC.Name = "homeTC"
        homeTC.SelectedIndex = 0
        homeTC.Size = New Size(776, 383)
        homeTC.TabIndex = 2
        ' 
        ' homeTP
        ' 
        homeTP.Location = New Point(4, 30)
        homeTP.Name = "homeTP"
        homeTP.Padding = New Padding(3)
        homeTP.RightToLeft = RightToLeft.No
        homeTP.Size = New Size(768, 349)
        homeTP.TabIndex = 0
        homeTP.Text = "Home"
        homeTP.UseVisualStyleBackColor = True
        ' 
        ' addCadetTB
        ' 
        addCadetTB.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        addCadetTB.Location = New Point(4, 30)
        addCadetTB.Name = "addCadetTB"
        addCadetTB.Padding = New Padding(3)
        addCadetTB.Size = New Size(768, 349)
        addCadetTB.TabIndex = 1
        addCadetTB.Text = "Add Cadet"
        addCadetTB.UseVisualStyleBackColor = True
        ' 
        ' searchTC
        ' 
        searchTC.Location = New Point(4, 30)
        searchTC.Name = "searchTC"
        searchTC.Padding = New Padding(3)
        searchTC.Size = New Size(768, 349)
        searchTC.TabIndex = 2
        searchTC.Text = "Search"
        searchTC.UseVisualStyleBackColor = True
        ' 
        ' editCadetTP
        ' 
        editCadetTP.Location = New Point(4, 30)
        editCadetTP.Name = "editCadetTP"
        editCadetTP.Size = New Size(768, 349)
        editCadetTP.TabIndex = 3
        editCadetTP.Text = "Edit Cadet"
        editCadetTP.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 576)
        Controls.Add(outputDGV)
        Controls.Add(homeTC)
        Controls.Add(outputLBX)
        Name = "Form1"
        Text = "Form1"
        CType(outputDGV, ComponentModel.ISupportInitialize).EndInit()
        homeTC.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents outputLBX As ListBox
    Friend WithEvents outputDGV As DataGridView
    Friend WithEvents homeTC As TabControl
    Friend WithEvents homeTP As TabPage
    Friend WithEvents addCadetTB As TabPage
    Friend WithEvents searchTC As TabPage
    Friend WithEvents editCadetTP As TabPage

End Class
