<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.components = New System.ComponentModel.Container()
        Dim PIdLabel As System.Windows.Forms.Label
        Dim PNameLabel As System.Windows.Forms.Label
        Dim RDateLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim RBloodgroupLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Dim Label23 As System.Windows.Forms.Label
        Me.BloodbankDataSet = New BloodBankManagementSystem.bloodbankDataSet()
        Me.ReceiveBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceiveTableAdapter = New BloodBankManagementSystem.bloodbankDataSetTableAdapters.receiveTableAdapter()
        Me.TableAdapterManager = New BloodBankManagementSystem.bloodbankDataSetTableAdapters.TableAdapterManager()
        Me.ReceiveBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReceiveBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PIdTextBox = New System.Windows.Forms.TextBox()
        Me.PNameTextBox = New System.Windows.Forms.TextBox()
        Me.RDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.RBloodgroupTextBox = New System.Windows.Forms.TextBox()
        Me.receivers = New System.Windows.Forms.DataGridView()
        Me.PIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RBloodgroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SearchToolStrip = New System.Windows.Forms.ToolStrip()
        Me.PNameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.PNameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.SearchToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        PIdLabel = New System.Windows.Forms.Label()
        PNameLabel = New System.Windows.Forms.Label()
        RDateLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        RBloodgroupLabel = New System.Windows.Forms.Label()
        Label23 = New System.Windows.Forms.Label()
        CType(Me.BloodbankDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiveBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiveBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReceiveBindingNavigator.SuspendLayout()
        CType(Me.receivers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SearchToolStrip.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PIdLabel
        '
        PIdLabel.AutoSize = True
        PIdLabel.BackColor = System.Drawing.Color.Transparent
        PIdLabel.ForeColor = System.Drawing.Color.White
        PIdLabel.Location = New System.Drawing.Point(70, 236)
        PIdLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        PIdLabel.Name = "PIdLabel"
        PIdLabel.Size = New System.Drawing.Size(37, 25)
        PIdLabel.TabIndex = 1
        PIdLabel.Text = "Id:"
        '
        'PNameLabel
        '
        PNameLabel.AutoSize = True
        PNameLabel.BackColor = System.Drawing.Color.Transparent
        PNameLabel.ForeColor = System.Drawing.Color.White
        PNameLabel.Location = New System.Drawing.Point(70, 286)
        PNameLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        PNameLabel.Name = "PNameLabel"
        PNameLabel.Size = New System.Drawing.Size(75, 25)
        PNameLabel.TabIndex = 3
        PNameLabel.Text = "Name:"
        '
        'RDateLabel
        '
        RDateLabel.AutoSize = True
        RDateLabel.BackColor = System.Drawing.Color.Transparent
        RDateLabel.ForeColor = System.Drawing.Color.White
        RDateLabel.Location = New System.Drawing.Point(70, 339)
        RDateLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        RDateLabel.Name = "RDateLabel"
        RDateLabel.Size = New System.Drawing.Size(64, 25)
        RDateLabel.TabIndex = 5
        RDateLabel.Text = "Date:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.BackColor = System.Drawing.Color.Transparent
        QuantityLabel.ForeColor = System.Drawing.Color.White
        QuantityLabel.Location = New System.Drawing.Point(70, 386)
        QuantityLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(95, 25)
        QuantityLabel.TabIndex = 7
        QuantityLabel.Text = "quantity:"
        '
        'RBloodgroupLabel
        '
        RBloodgroupLabel.AutoSize = True
        RBloodgroupLabel.BackColor = System.Drawing.Color.Transparent
        RBloodgroupLabel.ForeColor = System.Drawing.Color.White
        RBloodgroupLabel.Location = New System.Drawing.Point(70, 436)
        RBloodgroupLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        RBloodgroupLabel.Name = "RBloodgroupLabel"
        RBloodgroupLabel.Size = New System.Drawing.Size(129, 25)
        RBloodgroupLabel.TabIndex = 9
        RBloodgroupLabel.Text = "Bloodgroup:"
        '
        'BloodbankDataSet
        '
        Me.BloodbankDataSet.DataSetName = "bloodbankDataSet"
        Me.BloodbankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReceiveBindingSource
        '
        Me.ReceiveBindingSource.DataMember = "receive"
        Me.ReceiveBindingSource.DataSource = Me.BloodbankDataSet
        '
        'ReceiveTableAdapter
        '
        Me.ReceiveTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.donationTableAdapter = Nothing
        Me.TableAdapterManager.personTableAdapter = Nothing
        Me.TableAdapterManager.receiveTableAdapter = Me.ReceiveTableAdapter
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BloodBankManagementSystem.bloodbankDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTableAdapter = Nothing
        '
        'ReceiveBindingNavigator
        '
        Me.ReceiveBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ReceiveBindingNavigator.BindingSource = Me.ReceiveBindingSource
        Me.ReceiveBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ReceiveBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ReceiveBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ReceiveBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ReceiveBindingNavigatorSaveItem})
        Me.ReceiveBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ReceiveBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ReceiveBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ReceiveBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ReceiveBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ReceiveBindingNavigator.Name = "ReceiveBindingNavigator"
        Me.ReceiveBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ReceiveBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ReceiveBindingNavigator.Size = New System.Drawing.Size(1669, 31)
        Me.ReceiveBindingNavigator.TabIndex = 0
        Me.ReceiveBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(56, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(103, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'ReceiveBindingNavigatorSaveItem
        '
        Me.ReceiveBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ReceiveBindingNavigatorSaveItem.Image = CType(resources.GetObject("ReceiveBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ReceiveBindingNavigatorSaveItem.Name = "ReceiveBindingNavigatorSaveItem"
        Me.ReceiveBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 28)
        Me.ReceiveBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PIdTextBox
        '
        Me.PIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceiveBindingSource, "pId", True))
        Me.PIdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PIdTextBox.Location = New System.Drawing.Point(234, 231)
        Me.PIdTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.PIdTextBox.Name = "PIdTextBox"
        Me.PIdTextBox.Size = New System.Drawing.Size(428, 30)
        Me.PIdTextBox.TabIndex = 2
        '
        'PNameTextBox
        '
        Me.PNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceiveBindingSource, "pName", True))
        Me.PNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PNameTextBox.Location = New System.Drawing.Point(234, 281)
        Me.PNameTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.PNameTextBox.Name = "PNameTextBox"
        Me.PNameTextBox.Size = New System.Drawing.Size(428, 30)
        Me.PNameTextBox.TabIndex = 4
        '
        'RDateDateTimePicker
        '
        Me.RDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ReceiveBindingSource, "rDate", True))
        Me.RDateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDateDateTimePicker.Location = New System.Drawing.Point(234, 331)
        Me.RDateDateTimePicker.Margin = New System.Windows.Forms.Padding(6)
        Me.RDateDateTimePicker.Name = "RDateDateTimePicker"
        Me.RDateDateTimePicker.Size = New System.Drawing.Size(428, 30)
        Me.RDateDateTimePicker.TabIndex = 6
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceiveBindingSource, "quantity", True))
        Me.QuantityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTextBox.Location = New System.Drawing.Point(234, 381)
        Me.QuantityTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(428, 30)
        Me.QuantityTextBox.TabIndex = 8
        '
        'RBloodgroupTextBox
        '
        Me.RBloodgroupTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceiveBindingSource, "rBloodgroup", True))
        Me.RBloodgroupTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBloodgroupTextBox.Location = New System.Drawing.Point(234, 431)
        Me.RBloodgroupTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.RBloodgroupTextBox.Name = "RBloodgroupTextBox"
        Me.RBloodgroupTextBox.Size = New System.Drawing.Size(428, 30)
        Me.RBloodgroupTextBox.TabIndex = 10
        '
        'receivers
        '
        Me.receivers.AutoGenerateColumns = False
        Me.receivers.BackgroundColor = System.Drawing.Color.White
        Me.receivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.receivers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PIdDataGridViewTextBoxColumn, Me.PNameDataGridViewTextBoxColumn, Me.RDateDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.RBloodgroupDataGridViewTextBoxColumn})
        Me.receivers.DataSource = Me.ReceiveBindingSource
        Me.receivers.Location = New System.Drawing.Point(728, 102)
        Me.receivers.Margin = New System.Windows.Forms.Padding(6)
        Me.receivers.Name = "receivers"
        Me.receivers.Size = New System.Drawing.Size(915, 484)
        Me.receivers.TabIndex = 11
        '
        'PIdDataGridViewTextBoxColumn
        '
        Me.PIdDataGridViewTextBoxColumn.DataPropertyName = "pId"
        Me.PIdDataGridViewTextBoxColumn.FillWeight = 57.33944!
        Me.PIdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.PIdDataGridViewTextBoxColumn.Name = "PIdDataGridViewTextBoxColumn"
        '
        'PNameDataGridViewTextBoxColumn
        '
        Me.PNameDataGridViewTextBoxColumn.DataPropertyName = "pName"
        Me.PNameDataGridViewTextBoxColumn.FillWeight = 81.25912!
        Me.PNameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.PNameDataGridViewTextBoxColumn.Name = "PNameDataGridViewTextBoxColumn"
        Me.PNameDataGridViewTextBoxColumn.Width = 142
        '
        'RDateDataGridViewTextBoxColumn
        '
        Me.RDateDataGridViewTextBoxColumn.DataPropertyName = "rDate"
        Me.RDateDataGridViewTextBoxColumn.FillWeight = 102.4357!
        Me.RDateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.RDateDataGridViewTextBoxColumn.Name = "RDateDataGridViewTextBoxColumn"
        Me.RDateDataGridViewTextBoxColumn.Width = 178
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.FillWeight = 121.1838!
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.Width = 212
        '
        'RBloodgroupDataGridViewTextBoxColumn
        '
        Me.RBloodgroupDataGridViewTextBoxColumn.DataPropertyName = "rBloodgroup"
        Me.RBloodgroupDataGridViewTextBoxColumn.FillWeight = 137.7819!
        Me.RBloodgroupDataGridViewTextBoxColumn.HeaderText = "Bloodgroup"
        Me.RBloodgroupDataGridViewTextBoxColumn.Name = "RBloodgroupDataGridViewTextBoxColumn"
        Me.RBloodgroupDataGridViewTextBoxColumn.Width = 240
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(280, 494)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(206, 44)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(486, 494)
        Me.Button4.Margin = New System.Windows.Forms.Padding(6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(206, 44)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'SearchToolStrip
        '
        Me.SearchToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SearchToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PNameToolStripLabel, Me.PNameToolStripTextBox, Me.SearchToolStripButton})
        Me.SearchToolStrip.Location = New System.Drawing.Point(0, 31)
        Me.SearchToolStrip.Name = "SearchToolStrip"
        Me.SearchToolStrip.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.SearchToolStrip.Size = New System.Drawing.Size(1669, 32)
        Me.SearchToolStrip.TabIndex = 17
        Me.SearchToolStrip.Text = "SearchToolStrip"
        '
        'PNameToolStripLabel
        '
        Me.PNameToolStripLabel.Name = "PNameToolStripLabel"
        Me.PNameToolStripLabel.Size = New System.Drawing.Size(66, 29)
        Me.PNameToolStripLabel.Text = "Name:"
        '
        'PNameToolStripTextBox
        '
        Me.PNameToolStripTextBox.Name = "PNameToolStripTextBox"
        Me.PNameToolStripTextBox.Size = New System.Drawing.Size(212, 32)
        '
        'SearchToolStripButton
        '
        Me.SearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SearchToolStripButton.Name = "SearchToolStripButton"
        Me.SearchToolStripButton.Size = New System.Drawing.Size(73, 29)
        Me.SearchToolStripButton.Text = "Search"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(73, 494)
        Me.Button3.Margin = New System.Windows.Forms.Padding(6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(206, 44)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Add New"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Label23.AutoSize = True
        Label23.BackColor = System.Drawing.Color.Transparent
        Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label23.ForeColor = System.Drawing.Color.White
        Label23.Location = New System.Drawing.Point(274, 121)
        Label23.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Label23.Name = "Label23"
        Label23.Size = New System.Drawing.Size(238, 32)
        Label23.TabIndex = 24
        Label23.Text = "Receiver Details"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.BloodBankManagementSystem.My.Resources.Resources.blood_receiver
        Me.PictureBox4.Location = New System.Drawing.Point(73, 86)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(162, 134)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 25
        Me.PictureBox4.TabStop = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BloodBankManagementSystem.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1669, 609)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Label23)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.SearchToolStrip)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.receivers)
        Me.Controls.Add(PIdLabel)
        Me.Controls.Add(Me.PIdTextBox)
        Me.Controls.Add(PNameLabel)
        Me.Controls.Add(Me.PNameTextBox)
        Me.Controls.Add(RDateLabel)
        Me.Controls.Add(Me.RDateDateTimePicker)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(RBloodgroupLabel)
        Me.Controls.Add(Me.RBloodgroupTextBox)
        Me.Controls.Add(Me.ReceiveBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receivers"
        CType(Me.BloodbankDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiveBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiveBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReceiveBindingNavigator.ResumeLayout(False)
        Me.ReceiveBindingNavigator.PerformLayout()
        CType(Me.receivers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SearchToolStrip.ResumeLayout(False)
        Me.SearchToolStrip.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BloodbankDataSet As BloodBankManagementSystem.bloodbankDataSet
    Friend WithEvents ReceiveBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReceiveTableAdapter As BloodBankManagementSystem.bloodbankDataSetTableAdapters.receiveTableAdapter
    Friend WithEvents TableAdapterManager As BloodBankManagementSystem.bloodbankDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ReceiveBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ReceiveBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RBloodgroupTextBox As System.Windows.Forms.TextBox
    Friend WithEvents receivers As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents SearchToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents PNameToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PNameToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SearchToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RBloodgroupDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
End Class
