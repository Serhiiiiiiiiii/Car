﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Рейси_табл
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.РейсиDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.РейсиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Автотранспортне_підприємствоDataSet = New Автотранспортне_підприємство.Автотранспортне_підприємствоDataSet()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.РейсиTableAdapter = New Автотранспортне_підприємство.Автотранспортне_підприємствоDataSetTableAdapters.РейсиTableAdapter()
        CType(Me.РейсиDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РейсиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Автотранспортне_підприємствоDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Pink
        Me.Button6.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(16, 39)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(74, 37)
        Me.Button6.TabIndex = 50
        Me.Button6.Text = "Звіт"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'РейсиDataGridView
        '
        Me.РейсиDataGridView.AutoGenerateColumns = False
        Me.РейсиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.РейсиDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.РейсиDataGridView.DataSource = Me.РейсиBindingSource
        Me.РейсиDataGridView.Location = New System.Drawing.Point(16, 109)
        Me.РейсиDataGridView.Name = "РейсиDataGridView"
        Me.РейсиDataGridView.Size = New System.Drawing.Size(437, 369)
        Me.РейсиDataGridView.TabIndex = 49
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Customer"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Customer"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Where_zvidku"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Where_zvidku"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Where_kydu"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Where_kydu"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Date_of_departure"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Date_of_departure"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Date_of_arrival"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Date_of_arrival"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Payment_mark"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Payment_mark"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Return_mark"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Return_mark"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'РейсиBindingSource
        '
        Me.РейсиBindingSource.DataMember = "Рейси"
        Me.РейсиBindingSource.DataSource = Me.Автотранспортне_підприємствоDataSet
        '
        'Автотранспортне_підприємствоDataSet
        '
        Me.Автотранспортне_підприємствоDataSet.DataSetName = "Автотранспортне_підприємствоDataSet"
        Me.Автотранспортне_підприємствоDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Pink
        Me.Button5.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(624, 532)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(148, 66)
        Me.Button5.TabIndex = 48
        Me.Button5.Text = "Закрити"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Pink
        Me.Button4.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(472, 533)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(148, 66)
        Me.Button4.TabIndex = 47
        Me.Button4.Text = "Знайти"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Pink
        Me.Button3.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(624, 460)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(148, 66)
        Me.Button3.TabIndex = 46
        Me.Button3.Text = "Показати все"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Pink
        Me.Button2.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(472, 460)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 66)
        Me.Button2.TabIndex = 45
        Me.Button2.Text = "Фільтрувати"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Pink
        Me.Label4.Font = New System.Drawing.Font("Harlow Solid Italic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 553)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 30)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Критерій:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Pink
        Me.Label3.Font = New System.Drawing.Font("Harlow Solid Italic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 496)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 30)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "ПІБ:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Pink
        Me.Label1.Font = New System.Drawing.Font("Harlow Solid Italic", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(650, 62)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Таблиця ""Рейси"" (Табличний вигляд)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Harlow Solid Italic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(470, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 337)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Сортування"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Pink
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(19, 283)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(265, 43)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Сортування"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(42, 260)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(216, 23)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Сортування за спаданням"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(42, 238)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(216, 23)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Сортування за зростанням"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Items.AddRange(New Object() {"Замовник", "Звідки", "Куди", "Дата відправлення", "Дата прибуття", "Ціна", "Оплата", "Повернення"})
        Me.ListBox1.Location = New System.Drawing.Point(6, 48)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(278, 164)
        Me.ListBox1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Поле для сортування"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.Location = New System.Drawing.Point(133, 553)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(331, 29)
        Me.TextBox1.TabIndex = 40
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.РейсиBindingSource
        Me.ComboBox1.DisplayMember = "Customer"
        Me.ComboBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(133, 496)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(331, 30)
        Me.ComboBox1.TabIndex = 39
        '
        'РейсиTableAdapter
        '
        Me.РейсиTableAdapter.ClearBeforeFill = True
        '
        'Рейси_табл
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(784, 610)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.РейсиDataGridView)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Рейси_табл"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Таблиця ""Рейси"" (Табличний вигляд)"
        CType(Me.РейсиDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РейсиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Автотранспортне_підприємствоDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button6 As Button
    Friend WithEvents РейсиDataGridView As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Автотранспортне_підприємствоDataSet As Автотранспортне_підприємствоDataSet
    Friend WithEvents РейсиBindingSource As BindingSource
    Friend WithEvents РейсиTableAdapter As Автотранспортне_підприємствоDataSetTableAdapters.РейсиTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
