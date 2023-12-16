<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim DDateLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim PBloodgroupLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Dim Label1 As System.Windows.Forms.Label
        Me.BloodbankDataSet = New BloodBankManagementSystem.bloodbankDataSet()
        Me.DonationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DonationTableAdapter = New BloodBankManagementSystem.bloodbankDataSetTableAdapters.donationTableAdapter()
        Me.TableAdapterManager = New BloodBankManagementSystem.bloodbankDataSetTableAdapters.TableAdapterManager()
        Me.DonationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DonationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PIdTextBox = New System.Windows.Forms.TextBox()
        Me.PNameTextBox = New System.Windows.Forms.TextBox()
        Me.DDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.PBloodgroupTextBox = New System.Windows.Forms.TextBox()
        Me.donations = New System.Windows.Forms.DataGridView()
        Me.PIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PBloodgroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SearchToolStrip = New System.Windows.Forms.ToolStrip()
        Me.PNameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.PNameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.SearchToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        PIdLabel = New System.Windows.Forms.Label()
        PNameLabel = New System.Windows.Forms.Label()
        DDateLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        PBloodgroupLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.BloodbankDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DonationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DonationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DonationBindingNavigator.SuspendLayout()
        CType(Me.donations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SearchToolStrip.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PIdLabel
        '
        PIdLabel.AutoSize = True
        PIdLabel.BackColor = System.Drawing.Color.Transparent
        PIdLabel.ForeColor = System.Drawing.Color.White
        PIdLabel.Location = New System.Drawing.Point(60, 298)
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
        PNameLabel.Location = New System.Drawing.Point(60, 348)
        PNameLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        PNameLabel.Name = "PNameLabel"
        PNameLabel.Size = New System.Drawing.Size(75, 25)
        PNameLabel.TabIndex = 3
        PNameLabel.Text = "Name:"
        '
        'DDateLabel
        '
        DDateLabel.AutoSize = True
        DDateLabel.BackColor = System.Drawing.Color.Transparent
        DDateLabel.ForeColor = System.Drawing.Color.White
        DDateLabel.Location = New System.Drawing.Point(60, 400)
        DDateLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        DDateLabel.Name = "DDateLabel"
        DDateLabel.Size = New System.Drawing.Size(64, 25)
        DDateLabel.TabIndex = 5
        DDateLabel.Text = "Date:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.BackColor = System.Drawing.Color.Transparent
        QuantityLabel.ForeColor = System.Drawing.Color.White
        QuantityLabel.Location = New System.Drawing.Point(60, 448)
        QuantityLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(95, 25)
        QuantityLabel.TabIndex = 7
        QuantityLabel.Text = "quantity:"
        '
        'PBloodgroupLabel
        '
        PBloodgroupLabel.AutoSize = True
        PBloodgroupLabel.BackColor = System.Drawing.Color.Transparent
        PBloodgroupLabel.ForeColor = System.Drawing.Color.White
        PBloodgroupLabel.Location = New System.Drawing.Point(60, 498)
        PBloodgroupLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        PBloodgroupLabel.Name = "PBloodgroupLabel"
        PBloodgroupLabel.Size = New System.Drawing.Size(129, 25)
        PBloodgroupLabel.TabIndex = 9
        PBloodgroupLabel.Text = "Bloodgroup:"
        '
        'BloodbankDataSet
        '
        Me.BloodbankDataSet.DataSetName = "bloodbankDataSet"
        Me.BloodbankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DonationBindingSource
        '
        Me.DonationBindingSource.DataMember = "donation"
        Me.DonationBindingSource.DataSource = Me.BloodbankDataSet
        '
        'DonationTableAdapter
        '
        Me.DonationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.donationTableAdapter = Me.DonationTableAdapter
        Me.TableAdapterManager.personTableAdapter = Nothing
        Me.TableAdapterManager.receiveTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BloodBankManagementSystem.bloodbankDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTableAdapter = Nothing
        '
        'DonationBindingNavigator
        '
        Me.DonationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DonationBindingNavigator.BindingSource = Me.DonationBindingSource
        Me.DonationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DonationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DonationBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.DonationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DonationBindingNavigatorSaveItem})
        Me.DonationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DonationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DonationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DonationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DonationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DonationBindingNavigator.Name = "DonationBindingNavigator"
        Me.DonationBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.DonationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DonationBindingNavigator.Size = New System.Drawing.Size(1669, 31)
        Me.DonationBindingNavigator.TabIndex = 0
        Me.DonationBindingNavigator.Text = "BindingNavigator1"
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
        'DonationBindingNavigatorSaveItem
        '
        Me.DonationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DonationBindingNavigatorSaveItem.Image = CType(resources.GetObject("DonationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DonationBindingNavigatorSaveItem.Name = "DonationBindingNavigatorSaveItem"
        Me.DonationBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 28)
        Me.DonationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PIdTextBox
        '
        Me.PIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DonationBindingSource, "pId", True))
        Me.PIdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PIdTextBox.Location = New System.Drawing.Point(232, 292)
        Me.PIdTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.PIdTextBox.Name = "PIdTextBox"
        Me.PIdTextBox.Size = New System.Drawing.Size(428, 30)
        Me.PIdTextBox.TabIndex = 2
        '
        'PNameTextBox
        '
        Me.PNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DonationBindingSource, "pName", True))
        Me.PNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PNameTextBox.Location = New System.Drawing.Point(232, 342)
        Me.PNameTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.PNameTextBox.Name = "PNameTextBox"
        Me.PNameTextBox.Size = New System.Drawing.Size(428, 30)
        Me.PNameTextBox.TabIndex = 4
        '
        'DDateDateTimePicker
        '
        Me.DDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DonationBindingSource, "dDate", True))
        Me.DDateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DDateDateTimePicker.Location = New System.Drawing.Point(232, 392)
        Me.DDateDateTimePicker.Margin = New System.Windows.Forms.Padding(6)
        Me.DDateDateTimePicker.Name = "DDateDateTimePicker"
        Me.DDateDateTimePicker.Size = New System.Drawing.Size(428, 30)
        Me.DDateDateTimePicker.TabIndex = 6
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DonationBindingSource, "quantity", True))
        Me.QuantityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTextBox.Location = New System.Drawing.Point(232, 442)
        Me.QuantityTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(428, 30)
        Me.QuantityTextBox.TabIndex = 8
        '
        'PBloodgroupTextBox
        '
        Me.PBloodgroupTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DonationBindingSource, "pBloodgroup", True))
        Me.PBloodgroupTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PBloodgroupTextBox.Location = New System.Drawing.Point(232, 492)
        Me.PBloodgroupTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.PBloodgroupTextBox.Name = "PBloodgroupTextBox"
        Me.PBloodgroupTextBox.Size = New System.Drawing.Size(428, 30)
        Me.PBloodgroupTextBox.TabIndex = 10
        '
        'donations
        '
        Me.donations.AutoGenerateColumns = False
        Me.donations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.donations.BackgroundColor = System.Drawing.Color.White
        Me.donations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.donations.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PIdDataGridViewTextBoxColumn, Me.PNameDataGridViewTextBoxColumn, Me.DDateDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.PBloodgroupDataGridViewTextBoxColumn})
        Me.donations.DataSource = Me.DonationBindingSource
        Me.donations.Location = New System.Drawing.Point(702, 102)
        Me.donations.Margin = New System.Windows.Forms.Padding(6)
        Me.donations.Name = "donations"
        Me.donations.Size = New System.Drawing.Size(941, 592)
        Me.donations.TabIndex = 11
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
        'DDateDataGridViewTextBoxColumn
        '
        Me.DDateDataGridViewTextBoxColumn.DataPropertyName = "dDate"
        Me.DDateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DDateDataGridViewTextBoxColumn.Name = "DDateDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'PBloodgroupDataGridViewTextBoxColumn
        '
        Me.PBloodgroupDataGridViewTextBoxColumn.DataPropertyName = "pBloodgroup"
        Me.PBloodgroupDataGridViewTextBoxColumn.HeaderText = "Bloodgroup"
        Me.PBloodgroupDataGridViewTextBoxColumn.Name = "PBloodgroupDataGridViewTextBoxColumn"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(349, 586)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 44)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(528, 586)
        Me.Button4.Margin = New System.Windows.Forms.Padding(6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(141, 44)
        Me.Button4.TabIndex = 15
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
        Me.SearchToolStrip.TabIndex = 16
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
        Me.Button3.Location = New System.Drawing.Point(169, 586)
        Me.Button3.Margin = New System.Windows.Forms.Padding(6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(141, 44)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Add New"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.White
        Label1.Location = New System.Drawing.Point(267, 164)
        Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(200, 32)
        Label1.TabIndex = 21
        Label1.Text = "Donor Details"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.BloodBankManagementSystem.My.Resources.Resources.blood_donation
        Me.PictureBox2.Location = New System.Drawing.Point(65, 102)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(162, 134)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.BloodBankManagementSystem.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1669, 717)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.SearchToolStrip)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.donations)
        Me.Controls.Add(PIdLabel)
        Me.Controls.Add(Me.PIdTextBox)
        Me.Controls.Add(PNameLabel)
        Me.Controls.Add(Me.PNameTextBox)
        Me.Controls.Add(DDateLabel)
        Me.Controls.Add(Me.DDateDateTimePicker)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(PBloodgroupLabel)
        Me.Controls.Add(Me.PBloodgroupTextBox)
        Me.Controls.Add(Me.DonationBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Donations"
        CType(Me.BloodbankDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DonationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DonationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DonationBindingNavigator.ResumeLayout(False)
        Me.DonationBindingNavigator.PerformLayout()
        CType(Me.donations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SearchToolStrip.ResumeLayout(False)
        Me.SearchToolStrip.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BloodbankDataSet As BloodBankManagementSystem.bloodbankDataSet
    Friend WithEvents DonationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DonationTableAdapter As BloodBankManagementSystem.bloodbankDataSetTableAdapters.donationTableAdapter
    Friend WithEvents TableAdapterManager As BloodBankManagementSystem.bloodbankDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DonationBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents DonationBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PBloodgroupTextBox As System.Windows.Forms.TextBox
    Friend WithEvents donations As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents SearchToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents PNameToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PNameToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SearchToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PBloodgroupDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
