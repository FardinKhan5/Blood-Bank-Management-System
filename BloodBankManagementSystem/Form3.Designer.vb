<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim PPhoneLabel As System.Windows.Forms.Label
        Dim PBloodgroupLabel As System.Windows.Forms.Label
        Dim PGenderLabel As System.Windows.Forms.Label
        Dim PAddressLabel As System.Windows.Forms.Label
        Dim PAgeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Dim Label1 As System.Windows.Forms.Label
        Me.PersonBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.PersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BloodbankDataSet = New BloodBankManagementSystem.bloodbankDataSet()
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
        Me.PersonBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PIdTextBox = New System.Windows.Forms.TextBox()
        Me.PNameTextBox = New System.Windows.Forms.TextBox()
        Me.PPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.PBloodgroupTextBox = New System.Windows.Forms.TextBox()
        Me.PGenderTextBox = New System.Windows.Forms.TextBox()
        Me.PAddressTextBox = New System.Windows.Forms.TextBox()
        Me.PAgeTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PBloodgroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PGenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SearchToolStrip = New System.Windows.Forms.ToolStrip()
        Me.PNameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.PNameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.SearchToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PersonTableAdapter = New BloodBankManagementSystem.bloodbankDataSetTableAdapters.personTableAdapter()
        Me.TableAdapterManager = New BloodBankManagementSystem.bloodbankDataSetTableAdapters.TableAdapterManager()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        PIdLabel = New System.Windows.Forms.Label()
        PNameLabel = New System.Windows.Forms.Label()
        PPhoneLabel = New System.Windows.Forms.Label()
        PBloodgroupLabel = New System.Windows.Forms.Label()
        PGenderLabel = New System.Windows.Forms.Label()
        PAddressLabel = New System.Windows.Forms.Label()
        PAgeLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.PersonBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PersonBindingNavigator.SuspendLayout()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BloodbankDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SearchToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'PIdLabel
        '
        PIdLabel.AutoSize = True
        PIdLabel.BackColor = System.Drawing.Color.Transparent
        PIdLabel.ForeColor = System.Drawing.Color.White
        PIdLabel.Location = New System.Drawing.Point(21, 148)
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
        PNameLabel.Location = New System.Drawing.Point(21, 198)
        PNameLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        PNameLabel.Name = "PNameLabel"
        PNameLabel.Size = New System.Drawing.Size(75, 25)
        PNameLabel.TabIndex = 3
        PNameLabel.Text = "Name:"
        '
        'PPhoneLabel
        '
        PPhoneLabel.AutoSize = True
        PPhoneLabel.BackColor = System.Drawing.Color.Transparent
        PPhoneLabel.ForeColor = System.Drawing.Color.White
        PPhoneLabel.Location = New System.Drawing.Point(21, 248)
        PPhoneLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        PPhoneLabel.Name = "PPhoneLabel"
        PPhoneLabel.Size = New System.Drawing.Size(81, 25)
        PPhoneLabel.TabIndex = 5
        PPhoneLabel.Text = "Phone:"
        '
        'PBloodgroupLabel
        '
        PBloodgroupLabel.AutoSize = True
        PBloodgroupLabel.BackColor = System.Drawing.Color.Transparent
        PBloodgroupLabel.ForeColor = System.Drawing.Color.White
        PBloodgroupLabel.Location = New System.Drawing.Point(21, 298)
        PBloodgroupLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        PBloodgroupLabel.Name = "PBloodgroupLabel"
        PBloodgroupLabel.Size = New System.Drawing.Size(129, 25)
        PBloodgroupLabel.TabIndex = 7
        PBloodgroupLabel.Text = "Bloodgroup:"
        '
        'PGenderLabel
        '
        PGenderLabel.AutoSize = True
        PGenderLabel.BackColor = System.Drawing.Color.Transparent
        PGenderLabel.ForeColor = System.Drawing.Color.White
        PGenderLabel.Location = New System.Drawing.Point(21, 348)
        PGenderLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        PGenderLabel.Name = "PGenderLabel"
        PGenderLabel.Size = New System.Drawing.Size(90, 25)
        PGenderLabel.TabIndex = 9
        PGenderLabel.Text = "Gender:"
        '
        'PAddressLabel
        '
        PAddressLabel.AutoSize = True
        PAddressLabel.BackColor = System.Drawing.Color.Transparent
        PAddressLabel.ForeColor = System.Drawing.Color.White
        PAddressLabel.Location = New System.Drawing.Point(21, 398)
        PAddressLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        PAddressLabel.Name = "PAddressLabel"
        PAddressLabel.Size = New System.Drawing.Size(99, 25)
        PAddressLabel.TabIndex = 11
        PAddressLabel.Text = "Address:"
        '
        'PAgeLabel
        '
        PAgeLabel.AutoSize = True
        PAgeLabel.BackColor = System.Drawing.Color.Transparent
        PAgeLabel.ForeColor = System.Drawing.Color.White
        PAgeLabel.Location = New System.Drawing.Point(21, 448)
        PAgeLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        PAgeLabel.Name = "PAgeLabel"
        PAgeLabel.Size = New System.Drawing.Size(58, 25)
        PAgeLabel.TabIndex = 13
        PAgeLabel.Text = "Age:"
        '
        'PersonBindingNavigator
        '
        Me.PersonBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PersonBindingNavigator.BindingSource = Me.PersonBindingSource
        Me.PersonBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PersonBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PersonBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.PersonBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PersonBindingNavigatorSaveItem})
        Me.PersonBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PersonBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PersonBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PersonBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PersonBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PersonBindingNavigator.Name = "PersonBindingNavigator"
        Me.PersonBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.PersonBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PersonBindingNavigator.Size = New System.Drawing.Size(1594, 31)
        Me.PersonBindingNavigator.TabIndex = 0
        Me.PersonBindingNavigator.Text = "BindingNavigator1"
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
        'PersonBindingSource
        '
        Me.PersonBindingSource.DataMember = "person"
        Me.PersonBindingSource.DataSource = Me.BloodbankDataSet
        '
        'BloodbankDataSet
        '
        Me.BloodbankDataSet.DataSetName = "bloodbankDataSet"
        Me.BloodbankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'PersonBindingNavigatorSaveItem
        '
        Me.PersonBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PersonBindingNavigatorSaveItem.Image = CType(resources.GetObject("PersonBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PersonBindingNavigatorSaveItem.Name = "PersonBindingNavigatorSaveItem"
        Me.PersonBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 28)
        Me.PersonBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PIdTextBox
        '
        Me.PIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "pId", True))
        Me.PIdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PIdTextBox.Location = New System.Drawing.Point(193, 142)
        Me.PIdTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.PIdTextBox.Name = "PIdTextBox"
        Me.PIdTextBox.Size = New System.Drawing.Size(212, 30)
        Me.PIdTextBox.TabIndex = 2
        '
        'PNameTextBox
        '
        Me.PNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "pName", True))
        Me.PNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PNameTextBox.Location = New System.Drawing.Point(193, 192)
        Me.PNameTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.PNameTextBox.Name = "PNameTextBox"
        Me.PNameTextBox.Size = New System.Drawing.Size(212, 30)
        Me.PNameTextBox.TabIndex = 4
        '
        'PPhoneTextBox
        '
        Me.PPhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "pPhone", True))
        Me.PPhoneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PPhoneTextBox.Location = New System.Drawing.Point(193, 242)
        Me.PPhoneTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.PPhoneTextBox.Name = "PPhoneTextBox"
        Me.PPhoneTextBox.Size = New System.Drawing.Size(212, 30)
        Me.PPhoneTextBox.TabIndex = 6
        '
        'PBloodgroupTextBox
        '
        Me.PBloodgroupTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "pBloodgroup", True))
        Me.PBloodgroupTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PBloodgroupTextBox.Location = New System.Drawing.Point(193, 292)
        Me.PBloodgroupTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.PBloodgroupTextBox.Name = "PBloodgroupTextBox"
        Me.PBloodgroupTextBox.Size = New System.Drawing.Size(212, 30)
        Me.PBloodgroupTextBox.TabIndex = 8
        '
        'PGenderTextBox
        '
        Me.PGenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "pGender", True))
        Me.PGenderTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PGenderTextBox.Location = New System.Drawing.Point(193, 342)
        Me.PGenderTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.PGenderTextBox.Name = "PGenderTextBox"
        Me.PGenderTextBox.Size = New System.Drawing.Size(212, 30)
        Me.PGenderTextBox.TabIndex = 10
        '
        'PAddressTextBox
        '
        Me.PAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "pAddress", True))
        Me.PAddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PAddressTextBox.Location = New System.Drawing.Point(193, 392)
        Me.PAddressTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.PAddressTextBox.Name = "PAddressTextBox"
        Me.PAddressTextBox.Size = New System.Drawing.Size(212, 30)
        Me.PAddressTextBox.TabIndex = 12
        '
        'PAgeTextBox
        '
        Me.PAgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "pAge", True))
        Me.PAgeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PAgeTextBox.Location = New System.Drawing.Point(193, 442)
        Me.PAgeTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.PAgeTextBox.Name = "PAgeTextBox"
        Me.PAgeTextBox.Size = New System.Drawing.Size(212, 30)
        Me.PAgeTextBox.TabIndex = 14
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PIdDataGridViewTextBoxColumn, Me.PNameDataGridViewTextBoxColumn, Me.PPhoneDataGridViewTextBoxColumn, Me.PBloodgroupDataGridViewTextBoxColumn, Me.PGenderDataGridViewTextBoxColumn, Me.PAddressDataGridViewTextBoxColumn, Me.PAgeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PersonBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(466, 102)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1112, 547)
        Me.DataGridView1.TabIndex = 15
        '
        'PIdDataGridViewTextBoxColumn
        '
        Me.PIdDataGridViewTextBoxColumn.DataPropertyName = "pId"
        Me.PIdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.PIdDataGridViewTextBoxColumn.Name = "PIdDataGridViewTextBoxColumn"
        '
        'PNameDataGridViewTextBoxColumn
        '
        Me.PNameDataGridViewTextBoxColumn.DataPropertyName = "pName"
        Me.PNameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.PNameDataGridViewTextBoxColumn.Name = "PNameDataGridViewTextBoxColumn"
        '
        'PPhoneDataGridViewTextBoxColumn
        '
        Me.PPhoneDataGridViewTextBoxColumn.DataPropertyName = "pPhone"
        Me.PPhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PPhoneDataGridViewTextBoxColumn.Name = "PPhoneDataGridViewTextBoxColumn"
        '
        'PBloodgroupDataGridViewTextBoxColumn
        '
        Me.PBloodgroupDataGridViewTextBoxColumn.DataPropertyName = "pBloodgroup"
        Me.PBloodgroupDataGridViewTextBoxColumn.HeaderText = "Bloodgroup"
        Me.PBloodgroupDataGridViewTextBoxColumn.Name = "PBloodgroupDataGridViewTextBoxColumn"
        '
        'PGenderDataGridViewTextBoxColumn
        '
        Me.PGenderDataGridViewTextBoxColumn.DataPropertyName = "pGender"
        Me.PGenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.PGenderDataGridViewTextBoxColumn.Name = "PGenderDataGridViewTextBoxColumn"
        '
        'PAddressDataGridViewTextBoxColumn
        '
        Me.PAddressDataGridViewTextBoxColumn.DataPropertyName = "pAddress"
        Me.PAddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.PAddressDataGridViewTextBoxColumn.Name = "PAddressDataGridViewTextBoxColumn"
        '
        'PAgeDataGridViewTextBoxColumn
        '
        Me.PAgeDataGridViewTextBoxColumn.DataPropertyName = "pAge"
        Me.PAgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.PAgeDataGridViewTextBoxColumn.Name = "PAgeDataGridViewTextBoxColumn"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(162, 567)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 44)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'SearchToolStrip
        '
        Me.SearchToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SearchToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PNameToolStripLabel, Me.PNameToolStripTextBox, Me.SearchToolStripButton})
        Me.SearchToolStrip.Location = New System.Drawing.Point(0, 31)
        Me.SearchToolStrip.Name = "SearchToolStrip"
        Me.SearchToolStrip.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.SearchToolStrip.Size = New System.Drawing.Size(1594, 32)
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
        'PersonTableAdapter
        '
        Me.PersonTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.donationTableAdapter = Nothing
        Me.TableAdapterManager.personTableAdapter = Me.PersonTableAdapter
        Me.TableAdapterManager.receiveTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BloodBankManagementSystem.bloodbankDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTableAdapter = Nothing
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(8, 567)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 44)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Add New"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(317, 567)
        Me.Button3.Margin = New System.Windows.Forms.Padding(6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(141, 44)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.White
        Label1.Location = New System.Drawing.Point(20, 85)
        Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(227, 32)
        Label1.TabIndex = 20
        Label1.Text = "Member Details"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BloodBankManagementSystem.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1594, 672)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.SearchToolStrip)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(PIdLabel)
        Me.Controls.Add(Me.PIdTextBox)
        Me.Controls.Add(PNameLabel)
        Me.Controls.Add(Me.PNameTextBox)
        Me.Controls.Add(PPhoneLabel)
        Me.Controls.Add(Me.PPhoneTextBox)
        Me.Controls.Add(PBloodgroupLabel)
        Me.Controls.Add(Me.PBloodgroupTextBox)
        Me.Controls.Add(PGenderLabel)
        Me.Controls.Add(Me.PGenderTextBox)
        Me.Controls.Add(PAddressLabel)
        Me.Controls.Add(Me.PAddressTextBox)
        Me.Controls.Add(PAgeLabel)
        Me.Controls.Add(Me.PAgeTextBox)
        Me.Controls.Add(Me.PersonBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Members"
        CType(Me.PersonBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PersonBindingNavigator.ResumeLayout(False)
        Me.PersonBindingNavigator.PerformLayout()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BloodbankDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SearchToolStrip.ResumeLayout(False)
        Me.SearchToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BloodbankDataSet As BloodBankManagementSystem.bloodbankDataSet
    Friend WithEvents PersonBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PersonTableAdapter As BloodBankManagementSystem.bloodbankDataSetTableAdapters.personTableAdapter
    Friend WithEvents TableAdapterManager As BloodBankManagementSystem.bloodbankDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PersonBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PersonBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PPhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PBloodgroupTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PGenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PAgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SearchToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents PNameToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PNameToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SearchToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PPhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PBloodgroupDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PGenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PAgeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
