<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.InputText = New System.Windows.Forms.TextBox()
        Me.Search = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.search_file_path1 = New System.Windows.Forms.TextBox()
        Me.search_file_path2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SearchDirDialog1 = New System.Windows.Forms.Button()
        Me.SearchDirDialog2 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveResults = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'InputText
        '
        Me.InputText.Location = New System.Drawing.Point(81, 12)
        Me.InputText.Name = "InputText"
        Me.InputText.Size = New System.Drawing.Size(100, 19)
        Me.InputText.TabIndex = 0
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(211, 64)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(75, 23)
        Me.Search.TabIndex = 1
        Me.Search.Text = "検索"
        Me.Search.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(468, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "DB更新"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(12, 93)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(600, 340)
        Me.ListBox1.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(81, 66)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(124, 20)
        Me.ComboBox1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "入力ファイル"
        '
        'search_file_path1
        '
        Me.search_file_path1.Location = New System.Drawing.Point(362, 12)
        Me.search_file_path1.Name = "search_file_path1"
        Me.search_file_path1.Size = New System.Drawing.Size(100, 19)
        Me.search_file_path1.TabIndex = 7
        '
        'search_file_path2
        '
        Me.search_file_path2.Location = New System.Drawing.Point(362, 37)
        Me.search_file_path2.Name = "search_file_path2"
        Me.search_file_path2.Size = New System.Drawing.Size(100, 19)
        Me.search_file_path2.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(268, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 12)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "検索ファイルパス1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(268, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 12)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "検索ファイルパス2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "検索方法"
        '
        'SearchDirDialog1
        '
        Me.SearchDirDialog1.Location = New System.Drawing.Point(468, 10)
        Me.SearchDirDialog1.Name = "SearchDirDialog1"
        Me.SearchDirDialog1.Size = New System.Drawing.Size(75, 23)
        Me.SearchDirDialog1.TabIndex = 12
        Me.SearchDirDialog1.Text = "ファイル選択"
        Me.SearchDirDialog1.UseVisualStyleBackColor = True
        '
        'SearchDirDialog2
        '
        Me.SearchDirDialog2.Location = New System.Drawing.Point(468, 35)
        Me.SearchDirDialog2.Name = "SearchDirDialog2"
        Me.SearchDirDialog2.Size = New System.Drawing.Size(75, 23)
        Me.SearchDirDialog2.TabIndex = 13
        Me.SearchDirDialog2.Text = "ファイル選択"
        Me.SearchDirDialog2.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SaveResults
        '
        Me.SaveResults.Location = New System.Drawing.Point(292, 64)
        Me.SaveResults.Name = "SaveResults"
        Me.SaveResults.Size = New System.Drawing.Size(75, 23)
        Me.SaveResults.TabIndex = 14
        Me.SaveResults.Text = "結果保存"
        Me.SaveResults.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 442)
        Me.Controls.Add(Me.SaveResults)
        Me.Controls.Add(Me.SearchDirDialog2)
        Me.Controls.Add(Me.SearchDirDialog1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.search_file_path2)
        Me.Controls.Add(Me.search_file_path1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.InputText)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InputText As System.Windows.Forms.TextBox
    Friend WithEvents Search As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents search_file_path1 As System.Windows.Forms.TextBox
    Friend WithEvents search_file_path2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SearchDirDialog1 As System.Windows.Forms.Button
    Friend WithEvents SearchDirDialog2 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveResults As System.Windows.Forms.Button
End Class
