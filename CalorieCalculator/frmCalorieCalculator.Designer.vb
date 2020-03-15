<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCalorieCalculator
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
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblActivityLevel = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.cboLevelActivity = New System.Windows.Forms.ComboBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblValEmpty = New System.Windows.Forms.Label()
        Me.lblWeightL = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.lblHeightL = New System.Windows.Forms.Label()
        Me.radImperial = New System.Windows.Forms.RadioButton()
        Me.radMetric = New System.Windows.Forms.RadioButton()
        Me.lblFeet = New System.Windows.Forms.Label()
        Me.lblHeightRight = New System.Windows.Forms.Label()
        Me.lblWeightRight = New System.Windows.Forms.Label()
        Me.gbxMeasuments = New System.Windows.Forms.GroupBox()
        Me.lblWaistRight = New System.Windows.Forms.Label()
        Me.txtWaist = New System.Windows.Forms.TextBox()
        Me.lblWaist = New System.Windows.Forms.Label()
        Me.gbxFullestPoint = New System.Windows.Forms.GroupBox()
        Me.lblForearmRight = New System.Windows.Forms.Label()
        Me.lblHipRight = New System.Windows.Forms.Label()
        Me.lblWristRight = New System.Windows.Forms.Label()
        Me.txtForearm = New System.Windows.Forms.TextBox()
        Me.lblForearm = New System.Windows.Forms.Label()
        Me.txtHip = New System.Windows.Forms.TextBox()
        Me.lblHip = New System.Windows.Forms.Label()
        Me.txtWrist = New System.Windows.Forms.TextBox()
        Me.lblWrist = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lbxCurrentUser = New System.Windows.Forms.GroupBox()
        Me.txtId = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblBodyFatLeft = New System.Windows.Forms.Label()
        Me.lblActivityLeft = New System.Windows.Forms.Label()
        Me.lblActivityMrLeft = New System.Windows.Forms.Label()
        Me.lblBmrLeft = New System.Windows.Forms.Label()
        Me.lblGenderLeft = New System.Windows.Forms.Label()
        Me.lblAgeLeft = New System.Windows.Forms.Label()
        Me.lblWeightLeft = New System.Windows.Forms.Label()
        Me.lblHeightLeft = New System.Windows.Forms.Label()
        Me.lblNameLeft = New System.Windows.Forms.Label()
        Me.lblBodyFat = New System.Windows.Forms.Label()
        Me.lblActivity = New System.Windows.Forms.Label()
        Me.lblActivityMr = New System.Windows.Forms.Label()
        Me.lblBmr = New System.Windows.Forms.Label()
        Me.lblAgeUser = New System.Windows.Forms.Label()
        Me.lblGenderUser = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lbxUser = New System.Windows.Forms.ListBox()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.lblNameL = New System.Windows.Forms.Label()
        Me.lbxGeneralInformation = New System.Windows.Forms.GroupBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.gbxMeasuments.SuspendLayout()
        Me.gbxFullestPoint.SuspendLayout()
        Me.lbxCurrentUser.SuspendLayout()
        Me.lbxGeneralInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(38, 65)
        Me.lblAge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(83, 20)
        Me.lblAge.TabIndex = 0
        Me.lblAge.Text = "Enter age:"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(38, 205)
        Me.lblGender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(63, 20)
        Me.lblGender.TabIndex = 3
        Me.lblGender.Text = "Gender"
        '
        'lblActivityLevel
        '
        Me.lblActivityLevel.AutoSize = True
        Me.lblActivityLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivityLevel.Location = New System.Drawing.Point(33, 241)
        Me.lblActivityLevel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblActivityLevel.Name = "lblActivityLevel"
        Me.lblActivityLevel.Size = New System.Drawing.Size(99, 20)
        Me.lblActivityLevel.TabIndex = 4
        Me.lblActivityLevel.Text = "Activity Level"
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(165, 62)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAge.Multiline = True
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(200, 25)
        Me.txtAge.TabIndex = 1
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Location = New System.Drawing.Point(165, 203)
        Me.cboGender.Margin = New System.Windows.Forms.Padding(4)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(309, 26)
        Me.cboGender.TabIndex = 8
        '
        'cboLevelActivity
        '
        Me.cboLevelActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLevelActivity.FormattingEnabled = True
        Me.cboLevelActivity.Location = New System.Drawing.Point(165, 239)
        Me.cboLevelActivity.Margin = New System.Windows.Forms.Padding(4)
        Me.cboLevelActivity.Name = "cboLevelActivity"
        Me.cboLevelActivity.Size = New System.Drawing.Size(309, 26)
        Me.cboLevelActivity.TabIndex = 9
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCalculate.Location = New System.Drawing.Point(18, 598)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(165, 50)
        Me.btnCalculate.TabIndex = 13
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReset.Location = New System.Drawing.Point(213, 598)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(168, 50)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'lblValEmpty
        '
        Me.lblValEmpty.BackColor = System.Drawing.Color.Snow
        Me.lblValEmpty.ForeColor = System.Drawing.Color.Red
        Me.lblValEmpty.Location = New System.Drawing.Point(13, 11)
        Me.lblValEmpty.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValEmpty.Name = "lblValEmpty"
        Me.lblValEmpty.Size = New System.Drawing.Size(303, 21)
        Me.lblValEmpty.TabIndex = 15
        '
        'lblWeightL
        '
        Me.lblWeightL.AutoSize = True
        Me.lblWeightL.Location = New System.Drawing.Point(39, 170)
        Me.lblWeightL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWeightL.Name = "lblWeightL"
        Me.lblWeightL.Size = New System.Drawing.Size(93, 18)
        Me.lblWeightL.TabIndex = 30
        Me.lblWeightL.Text = "Enter Weight"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(165, 167)
        Me.txtWeight.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWeight.Multiline = True
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(200, 25)
        Me.txtWeight.TabIndex = 31
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(165, 131)
        Me.txtHeight.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHeight.Multiline = True
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(200, 25)
        Me.txtHeight.TabIndex = 29
        '
        'lblHeightL
        '
        Me.lblHeightL.AutoSize = True
        Me.lblHeightL.Location = New System.Drawing.Point(39, 134)
        Me.lblHeightL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeightL.Name = "lblHeightL"
        Me.lblHeightL.Size = New System.Drawing.Size(89, 18)
        Me.lblHeightL.TabIndex = 28
        Me.lblHeightL.Text = "Enter Height"
        '
        'radImperial
        '
        Me.radImperial.AutoSize = True
        Me.radImperial.Location = New System.Drawing.Point(165, 98)
        Me.radImperial.Margin = New System.Windows.Forms.Padding(4)
        Me.radImperial.Name = "radImperial"
        Me.radImperial.Size = New System.Drawing.Size(77, 22)
        Me.radImperial.TabIndex = 27
        Me.radImperial.Text = "Imperial"
        Me.radImperial.UseVisualStyleBackColor = True
        '
        'radMetric
        '
        Me.radMetric.AutoSize = True
        Me.radMetric.Checked = True
        Me.radMetric.Location = New System.Drawing.Point(42, 98)
        Me.radMetric.Margin = New System.Windows.Forms.Padding(4)
        Me.radMetric.Name = "radMetric"
        Me.radMetric.Size = New System.Drawing.Size(67, 22)
        Me.radMetric.TabIndex = 26
        Me.radMetric.TabStop = True
        Me.radMetric.Text = "Metric"
        Me.radMetric.UseVisualStyleBackColor = True
        '
        'lblFeet
        '
        Me.lblFeet.AutoSize = True
        Me.lblFeet.Location = New System.Drawing.Point(285, 220)
        Me.lblFeet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFeet.Name = "lblFeet"
        Me.lblFeet.Size = New System.Drawing.Size(0, 18)
        Me.lblFeet.TabIndex = 34
        '
        'lblHeightRight
        '
        Me.lblHeightRight.AutoSize = True
        Me.lblHeightRight.Location = New System.Drawing.Point(373, 134)
        Me.lblHeightRight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeightRight.Name = "lblHeightRight"
        Me.lblHeightRight.Size = New System.Drawing.Size(0, 18)
        Me.lblHeightRight.TabIndex = 35
        '
        'lblWeightRight
        '
        Me.lblWeightRight.AutoSize = True
        Me.lblWeightRight.Location = New System.Drawing.Point(373, 167)
        Me.lblWeightRight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWeightRight.Name = "lblWeightRight"
        Me.lblWeightRight.Size = New System.Drawing.Size(0, 18)
        Me.lblWeightRight.TabIndex = 36
        '
        'gbxMeasuments
        '
        Me.gbxMeasuments.Controls.Add(Me.lblWaistRight)
        Me.gbxMeasuments.Controls.Add(Me.txtWaist)
        Me.gbxMeasuments.Controls.Add(Me.lblWaist)
        Me.gbxMeasuments.Controls.Add(Me.gbxFullestPoint)
        Me.gbxMeasuments.Location = New System.Drawing.Point(8, 384)
        Me.gbxMeasuments.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxMeasuments.Name = "gbxMeasuments"
        Me.gbxMeasuments.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxMeasuments.Size = New System.Drawing.Size(442, 206)
        Me.gbxMeasuments.TabIndex = 37
        Me.gbxMeasuments.TabStop = False
        Me.gbxMeasuments.Text = "Body Fat Measuments"
        '
        'lblWaistRight
        '
        Me.lblWaistRight.AutoSize = True
        Me.lblWaistRight.Location = New System.Drawing.Point(325, 28)
        Me.lblWaistRight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWaistRight.Name = "lblWaistRight"
        Me.lblWaistRight.Size = New System.Drawing.Size(0, 18)
        Me.lblWaistRight.TabIndex = 37
        '
        'txtWaist
        '
        Me.txtWaist.Location = New System.Drawing.Point(114, 25)
        Me.txtWaist.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWaist.Multiline = True
        Me.txtWaist.Name = "txtWaist"
        Me.txtWaist.Size = New System.Drawing.Size(200, 25)
        Me.txtWaist.TabIndex = 32
        '
        'lblWaist
        '
        Me.lblWaist.AutoSize = True
        Me.lblWaist.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaist.Location = New System.Drawing.Point(18, 22)
        Me.lblWaist.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWaist.Name = "lblWaist"
        Me.lblWaist.Size = New System.Drawing.Size(49, 20)
        Me.lblWaist.TabIndex = 4
        Me.lblWaist.Text = "Waist"
        '
        'gbxFullestPoint
        '
        Me.gbxFullestPoint.Controls.Add(Me.lblForearmRight)
        Me.gbxFullestPoint.Controls.Add(Me.lblHipRight)
        Me.gbxFullestPoint.Controls.Add(Me.lblWristRight)
        Me.gbxFullestPoint.Controls.Add(Me.txtForearm)
        Me.gbxFullestPoint.Controls.Add(Me.lblForearm)
        Me.gbxFullestPoint.Controls.Add(Me.txtHip)
        Me.gbxFullestPoint.Controls.Add(Me.lblHip)
        Me.gbxFullestPoint.Controls.Add(Me.txtWrist)
        Me.gbxFullestPoint.Controls.Add(Me.lblWrist)
        Me.gbxFullestPoint.Location = New System.Drawing.Point(10, 53)
        Me.gbxFullestPoint.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxFullestPoint.Name = "gbxFullestPoint"
        Me.gbxFullestPoint.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxFullestPoint.Size = New System.Drawing.Size(387, 138)
        Me.gbxFullestPoint.TabIndex = 0
        Me.gbxFullestPoint.TabStop = False
        Me.gbxFullestPoint.Text = "At Fullest Point"
        '
        'lblForearmRight
        '
        Me.lblForearmRight.AutoSize = True
        Me.lblForearmRight.Location = New System.Drawing.Point(315, 112)
        Me.lblForearmRight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblForearmRight.Name = "lblForearmRight"
        Me.lblForearmRight.Size = New System.Drawing.Size(0, 18)
        Me.lblForearmRight.TabIndex = 40
        '
        'lblHipRight
        '
        Me.lblHipRight.AutoSize = True
        Me.lblHipRight.Location = New System.Drawing.Point(315, 65)
        Me.lblHipRight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHipRight.Name = "lblHipRight"
        Me.lblHipRight.Size = New System.Drawing.Size(0, 18)
        Me.lblHipRight.TabIndex = 39
        '
        'lblWristRight
        '
        Me.lblWristRight.AutoSize = True
        Me.lblWristRight.Location = New System.Drawing.Point(315, 24)
        Me.lblWristRight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWristRight.Name = "lblWristRight"
        Me.lblWristRight.Size = New System.Drawing.Size(0, 18)
        Me.lblWristRight.TabIndex = 38
        '
        'txtForearm
        '
        Me.txtForearm.Location = New System.Drawing.Point(104, 106)
        Me.txtForearm.Margin = New System.Windows.Forms.Padding(4)
        Me.txtForearm.Multiline = True
        Me.txtForearm.Name = "txtForearm"
        Me.txtForearm.Size = New System.Drawing.Size(200, 25)
        Me.txtForearm.TabIndex = 37
        '
        'lblForearm
        '
        Me.lblForearm.AutoSize = True
        Me.lblForearm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForearm.Location = New System.Drawing.Point(14, 111)
        Me.lblForearm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblForearm.Name = "lblForearm"
        Me.lblForearm.Size = New System.Drawing.Size(69, 20)
        Me.lblForearm.TabIndex = 36
        Me.lblForearm.Text = "Forearm"
        '
        'txtHip
        '
        Me.txtHip.Location = New System.Drawing.Point(104, 63)
        Me.txtHip.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHip.Multiline = True
        Me.txtHip.Name = "txtHip"
        Me.txtHip.Size = New System.Drawing.Size(200, 25)
        Me.txtHip.TabIndex = 35
        '
        'lblHip
        '
        Me.lblHip.AutoSize = True
        Me.lblHip.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHip.Location = New System.Drawing.Point(14, 65)
        Me.lblHip.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHip.Name = "lblHip"
        Me.lblHip.Size = New System.Drawing.Size(33, 20)
        Me.lblHip.TabIndex = 34
        Me.lblHip.Text = "Hip"
        '
        'txtWrist
        '
        Me.txtWrist.Location = New System.Drawing.Point(104, 21)
        Me.txtWrist.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWrist.Multiline = True
        Me.txtWrist.Name = "txtWrist"
        Me.txtWrist.Size = New System.Drawing.Size(200, 25)
        Me.txtWrist.TabIndex = 33
        '
        'lblWrist
        '
        Me.lblWrist.AutoSize = True
        Me.lblWrist.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWrist.Location = New System.Drawing.Point(8, 22)
        Me.lblWrist.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWrist.Name = "lblWrist"
        Me.lblWrist.Size = New System.Drawing.Size(45, 20)
        Me.lblWrist.TabIndex = 5
        Me.lblWrist.Text = "Wrist"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(165, 25)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 25)
        Me.txtName.TabIndex = 38
        '
        'lbxCurrentUser
        '
        Me.lbxCurrentUser.Controls.Add(Me.txtId)
        Me.lbxCurrentUser.Controls.Add(Me.lblId)
        Me.lbxCurrentUser.Controls.Add(Me.lblBodyFatLeft)
        Me.lbxCurrentUser.Controls.Add(Me.lblActivityLeft)
        Me.lbxCurrentUser.Controls.Add(Me.lblActivityMrLeft)
        Me.lbxCurrentUser.Controls.Add(Me.lblBmrLeft)
        Me.lbxCurrentUser.Controls.Add(Me.lblGenderLeft)
        Me.lbxCurrentUser.Controls.Add(Me.lblAgeLeft)
        Me.lbxCurrentUser.Controls.Add(Me.lblWeightLeft)
        Me.lbxCurrentUser.Controls.Add(Me.lblHeightLeft)
        Me.lbxCurrentUser.Controls.Add(Me.lblNameLeft)
        Me.lbxCurrentUser.Controls.Add(Me.lblBodyFat)
        Me.lbxCurrentUser.Controls.Add(Me.lblActivity)
        Me.lbxCurrentUser.Controls.Add(Me.lblActivityMr)
        Me.lbxCurrentUser.Controls.Add(Me.lblBmr)
        Me.lbxCurrentUser.Controls.Add(Me.lblAgeUser)
        Me.lbxCurrentUser.Controls.Add(Me.lblGenderUser)
        Me.lbxCurrentUser.Controls.Add(Me.lblWeight)
        Me.lbxCurrentUser.Controls.Add(Me.lblHeight)
        Me.lbxCurrentUser.Controls.Add(Me.lblName)
        Me.lbxCurrentUser.Location = New System.Drawing.Point(517, 66)
        Me.lbxCurrentUser.Margin = New System.Windows.Forms.Padding(4)
        Me.lbxCurrentUser.Name = "lbxCurrentUser"
        Me.lbxCurrentUser.Padding = New System.Windows.Forms.Padding(4)
        Me.lbxCurrentUser.Size = New System.Drawing.Size(378, 313)
        Me.lbxCurrentUser.TabIndex = 39
        Me.lbxCurrentUser.TabStop = False
        Me.lbxCurrentUser.Text = "Current User Report"
        '
        'txtId
        '
        Me.txtId.AutoSize = True
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(317, 35)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(15, 20)
        Me.txtId.TabIndex = 52
        Me.txtId.Text = "*"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(282, 35)
        Me.lblId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(27, 20)
        Me.lblId.TabIndex = 45
        Me.lblId.Text = "Id:"
        '
        'lblBodyFatLeft
        '
        Me.lblBodyFatLeft.AutoSize = True
        Me.lblBodyFatLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBodyFatLeft.Location = New System.Drawing.Point(12, 277)
        Me.lblBodyFatLeft.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBodyFatLeft.Name = "lblBodyFatLeft"
        Me.lblBodyFatLeft.Size = New System.Drawing.Size(88, 18)
        Me.lblBodyFatLeft.TabIndex = 51
        Me.lblBodyFatLeft.Text = "Body Fat %:"
        '
        'lblActivityLeft
        '
        Me.lblActivityLeft.AutoSize = True
        Me.lblActivityLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivityLeft.Location = New System.Drawing.Point(9, 248)
        Me.lblActivityLeft.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblActivityLeft.Name = "lblActivityLeft"
        Me.lblActivityLeft.Size = New System.Drawing.Size(57, 18)
        Me.lblActivityLeft.TabIndex = 50
        Me.lblActivityLeft.Text = "Activity:"
        '
        'lblActivityMrLeft
        '
        Me.lblActivityMrLeft.AutoSize = True
        Me.lblActivityMrLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivityMrLeft.Location = New System.Drawing.Point(9, 218)
        Me.lblActivityMrLeft.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblActivityMrLeft.Name = "lblActivityMrLeft"
        Me.lblActivityMrLeft.Size = New System.Drawing.Size(85, 18)
        Me.lblActivityMrLeft.TabIndex = 49
        Me.lblActivityMrLeft.Text = "Activity MR:"
        '
        'lblBmrLeft
        '
        Me.lblBmrLeft.AutoSize = True
        Me.lblBmrLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBmrLeft.Location = New System.Drawing.Point(8, 186)
        Me.lblBmrLeft.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBmrLeft.Name = "lblBmrLeft"
        Me.lblBmrLeft.Size = New System.Drawing.Size(46, 18)
        Me.lblBmrLeft.TabIndex = 48
        Me.lblBmrLeft.Text = "BMR:"
        '
        'lblGenderLeft
        '
        Me.lblGenderLeft.AutoSize = True
        Me.lblGenderLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenderLeft.Location = New System.Drawing.Point(8, 157)
        Me.lblGenderLeft.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGenderLeft.Name = "lblGenderLeft"
        Me.lblGenderLeft.Size = New System.Drawing.Size(61, 18)
        Me.lblGenderLeft.TabIndex = 47
        Me.lblGenderLeft.Text = "Gender:"
        '
        'lblAgeLeft
        '
        Me.lblAgeLeft.AutoSize = True
        Me.lblAgeLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgeLeft.Location = New System.Drawing.Point(12, 123)
        Me.lblAgeLeft.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAgeLeft.Name = "lblAgeLeft"
        Me.lblAgeLeft.Size = New System.Drawing.Size(37, 18)
        Me.lblAgeLeft.TabIndex = 46
        Me.lblAgeLeft.Text = "Age:"
        '
        'lblWeightLeft
        '
        Me.lblWeightLeft.AutoSize = True
        Me.lblWeightLeft.Location = New System.Drawing.Point(9, 94)
        Me.lblWeightLeft.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWeightLeft.Name = "lblWeightLeft"
        Me.lblWeightLeft.Size = New System.Drawing.Size(58, 18)
        Me.lblWeightLeft.TabIndex = 45
        Me.lblWeightLeft.Text = "Weight:"
        '
        'lblHeightLeft
        '
        Me.lblHeightLeft.AutoSize = True
        Me.lblHeightLeft.Location = New System.Drawing.Point(9, 61)
        Me.lblHeightLeft.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeightLeft.Name = "lblHeightLeft"
        Me.lblHeightLeft.Size = New System.Drawing.Size(54, 18)
        Me.lblHeightLeft.TabIndex = 44
        Me.lblHeightLeft.Text = "Height:"
        '
        'lblNameLeft
        '
        Me.lblNameLeft.AutoSize = True
        Me.lblNameLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameLeft.Location = New System.Drawing.Point(8, 35)
        Me.lblNameLeft.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNameLeft.Name = "lblNameLeft"
        Me.lblNameLeft.Size = New System.Drawing.Size(55, 20)
        Me.lblNameLeft.TabIndex = 43
        Me.lblNameLeft.Text = "Name:"
        '
        'lblBodyFat
        '
        Me.lblBodyFat.AutoSize = True
        Me.lblBodyFat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBodyFat.Location = New System.Drawing.Point(102, 277)
        Me.lblBodyFat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBodyFat.Name = "lblBodyFat"
        Me.lblBodyFat.Size = New System.Drawing.Size(15, 20)
        Me.lblBodyFat.TabIndex = 9
        Me.lblBodyFat.Text = "*"
        '
        'lblActivity
        '
        Me.lblActivity.AutoSize = True
        Me.lblActivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivity.Location = New System.Drawing.Point(74, 248)
        Me.lblActivity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblActivity.Name = "lblActivity"
        Me.lblActivity.Size = New System.Drawing.Size(15, 20)
        Me.lblActivity.TabIndex = 8
        Me.lblActivity.Text = "*"
        '
        'lblActivityMr
        '
        Me.lblActivityMr.AutoSize = True
        Me.lblActivityMr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivityMr.Location = New System.Drawing.Point(102, 216)
        Me.lblActivityMr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblActivityMr.Name = "lblActivityMr"
        Me.lblActivityMr.Size = New System.Drawing.Size(15, 20)
        Me.lblActivityMr.TabIndex = 7
        Me.lblActivityMr.Text = "*"
        '
        'lblBmr
        '
        Me.lblBmr.AutoSize = True
        Me.lblBmr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBmr.Location = New System.Drawing.Point(71, 185)
        Me.lblBmr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBmr.Name = "lblBmr"
        Me.lblBmr.Size = New System.Drawing.Size(15, 20)
        Me.lblBmr.TabIndex = 6
        Me.lblBmr.Text = "*"
        '
        'lblAgeUser
        '
        Me.lblAgeUser.AutoSize = True
        Me.lblAgeUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgeUser.Location = New System.Drawing.Point(71, 123)
        Me.lblAgeUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAgeUser.Name = "lblAgeUser"
        Me.lblAgeUser.Size = New System.Drawing.Size(15, 20)
        Me.lblAgeUser.TabIndex = 5
        Me.lblAgeUser.Text = "*"
        '
        'lblGenderUser
        '
        Me.lblGenderUser.AutoSize = True
        Me.lblGenderUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenderUser.Location = New System.Drawing.Point(71, 157)
        Me.lblGenderUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGenderUser.Name = "lblGenderUser"
        Me.lblGenderUser.Size = New System.Drawing.Size(15, 20)
        Me.lblGenderUser.TabIndex = 4
        Me.lblGenderUser.Text = "*"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(71, 92)
        Me.lblWeight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(15, 20)
        Me.lblWeight.TabIndex = 3
        Me.lblWeight.Text = "*"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.Location = New System.Drawing.Point(71, 61)
        Me.lblHeight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(15, 20)
        Me.lblHeight.TabIndex = 2
        Me.lblHeight.Text = "*"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(71, 35)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(15, 20)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "*"
        '
        'lbxUser
        '
        Me.lbxUser.FormattingEnabled = True
        Me.lbxUser.ItemHeight = 18
        Me.lbxUser.Location = New System.Drawing.Point(517, 387)
        Me.lbxUser.Margin = New System.Windows.Forms.Padding(4)
        Me.lbxUser.Name = "lbxUser"
        Me.lbxUser.Size = New System.Drawing.Size(378, 184)
        Me.lbxUser.TabIndex = 40
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteUser.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDeleteUser.Location = New System.Drawing.Point(714, 598)
        Me.btnDeleteUser.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(168, 50)
        Me.btnDeleteUser.TabIndex = 41
        Me.btnDeleteUser.Text = "Delete User"
        Me.btnDeleteUser.UseVisualStyleBackColor = False
        '
        'lblNameL
        '
        Me.lblNameL.AutoSize = True
        Me.lblNameL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameL.Location = New System.Drawing.Point(38, 30)
        Me.lblNameL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNameL.Name = "lblNameL"
        Me.lblNameL.Size = New System.Drawing.Size(98, 20)
        Me.lblNameL.TabIndex = 42
        Me.lblNameL.Text = "Enter Name:"
        '
        'lbxGeneralInformation
        '
        Me.lbxGeneralInformation.Controls.Add(Me.txtName)
        Me.lbxGeneralInformation.Controls.Add(Me.lblNameL)
        Me.lbxGeneralInformation.Controls.Add(Me.lblAge)
        Me.lbxGeneralInformation.Controls.Add(Me.lblGender)
        Me.lbxGeneralInformation.Controls.Add(Me.lblActivityLevel)
        Me.lbxGeneralInformation.Controls.Add(Me.lblWeightRight)
        Me.lbxGeneralInformation.Controls.Add(Me.txtAge)
        Me.lbxGeneralInformation.Controls.Add(Me.lblHeightRight)
        Me.lbxGeneralInformation.Controls.Add(Me.cboGender)
        Me.lbxGeneralInformation.Controls.Add(Me.cboLevelActivity)
        Me.lbxGeneralInformation.Controls.Add(Me.radMetric)
        Me.lbxGeneralInformation.Controls.Add(Me.radImperial)
        Me.lbxGeneralInformation.Controls.Add(Me.lblHeightL)
        Me.lbxGeneralInformation.Controls.Add(Me.lblWeightL)
        Me.lbxGeneralInformation.Controls.Add(Me.txtHeight)
        Me.lbxGeneralInformation.Controls.Add(Me.txtWeight)
        Me.lbxGeneralInformation.Location = New System.Drawing.Point(8, 82)
        Me.lbxGeneralInformation.Margin = New System.Windows.Forms.Padding(4)
        Me.lbxGeneralInformation.Name = "lbxGeneralInformation"
        Me.lbxGeneralInformation.Padding = New System.Windows.Forms.Padding(4)
        Me.lbxGeneralInformation.Size = New System.Drawing.Size(482, 276)
        Me.lbxGeneralInformation.TabIndex = 43
        Me.lbxGeneralInformation.TabStop = False
        Me.lbxGeneralInformation.Text = "General Information"
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(14, 32)
        Me.lblError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 20)
        Me.lblError.TabIndex = 43
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEdit.Location = New System.Drawing.Point(528, 598)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(168, 50)
        Me.btnEdit.TabIndex = 44
        Me.btnEdit.Text = "Edit User"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'frmCalorieCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(934, 661)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lbxGeneralInformation)
        Me.Controls.Add(Me.btnDeleteUser)
        Me.Controls.Add(Me.lbxUser)
        Me.Controls.Add(Me.lbxCurrentUser)
        Me.Controls.Add(Me.gbxMeasuments)
        Me.Controls.Add(Me.lblValEmpty)
        Me.Controls.Add(Me.lblFeet)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCalorieCalculator"
        Me.Text = "Calorie Calculator"
        Me.gbxMeasuments.ResumeLayout(False)
        Me.gbxMeasuments.PerformLayout()
        Me.gbxFullestPoint.ResumeLayout(False)
        Me.gbxFullestPoint.PerformLayout()
        Me.lbxCurrentUser.ResumeLayout(False)
        Me.lbxCurrentUser.PerformLayout()
        Me.lbxGeneralInformation.ResumeLayout(False)
        Me.lbxGeneralInformation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAge As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblActivityLevel As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents cboLevelActivity As ComboBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblValEmpty As Label
    Friend WithEvents lblWeightL As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents lblHeightL As Label
    Friend WithEvents radImperial As RadioButton
    Friend WithEvents radMetric As RadioButton
    Friend WithEvents lblFeet As Label
    Friend WithEvents lblHeightRight As Label
    Friend WithEvents lblWeightRight As Label
    Friend WithEvents gbxMeasuments As GroupBox
    Friend WithEvents txtWaist As TextBox
    Friend WithEvents lblWaist As Label
    Friend WithEvents gbxFullestPoint As GroupBox
    Friend WithEvents txtForearm As TextBox
    Friend WithEvents lblForearm As Label
    Friend WithEvents txtHip As TextBox
    Friend WithEvents lblHip As Label
    Friend WithEvents txtWrist As TextBox
    Friend WithEvents lblWrist As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lbxCurrentUser As GroupBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblBodyFat As Label
    Friend WithEvents lblActivity As Label
    Friend WithEvents lblActivityMr As Label
    Friend WithEvents lblBmr As Label
    Friend WithEvents lblAgeUser As Label
    Friend WithEvents lblGenderUser As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents lbxUser As ListBox
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents lblNameL As Label
    Friend WithEvents lbxGeneralInformation As GroupBox
    Friend WithEvents lblWaistRight As Label
    Friend WithEvents lblForearmRight As Label
    Friend WithEvents lblHipRight As Label
    Friend WithEvents lblWristRight As Label
    Friend WithEvents lblBodyFatLeft As Label
    Friend WithEvents lblActivityLeft As Label
    Friend WithEvents lblActivityMrLeft As Label
    Friend WithEvents lblBmrLeft As Label
    Friend WithEvents lblGenderLeft As Label
    Friend WithEvents lblAgeLeft As Label
    Friend WithEvents lblWeightLeft As Label
    Friend WithEvents lblHeightLeft As Label
    Friend WithEvents lblNameLeft As Label
    Friend WithEvents lblError As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents txtId As Label
    Friend WithEvents lblId As Label
End Class
