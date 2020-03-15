'Author: Suelen Duarte
'Date: 02/05/2020
'Purpose: This program calculates the Resting Metabolic Rate taking in -
'consideration their age, gender, and activity level.

Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmCalorieCalculator

    'Module level Object for class User
    Dim lstUser As New BindingList(Of User)

    'Instantiate a new User
    Dim objUser As New User()

    'Calculate RMR metric for men 
    Private Sub CalculateMaleRestRateMetric(ByVal decOriginalAge As Decimal, ByVal decOriginalWeight As Decimal, ByVal decOriginalHeight As Decimal, ByRef CalculateMaleRestRate As Decimal)
        CalculateMaleRestRate = (88.4D + (13.4D * decOriginalWeight) + (4.8D * decOriginalHeight) - (5.68D * decOriginalAge))
    End Sub

    'Calculate RMR metric for women 
    Private Sub CalculateFemaleRestRateMetric(ByVal decOriginalAge As Decimal, ByVal decOriginalWeight As Decimal, ByVal decOriginalHeight As Decimal, ByRef CalculateFemaleRestRate As Decimal)
        CalculateFemaleRestRate = (447.6D + (9.25D * decOriginalWeight) + (3.1D * decOriginalHeight) - (4.33D * decOriginalAge))
    End Sub

    'Calculate RMR imperial for men 
    Private Sub CalculateMaleRestRateImperial(ByVal decOriginalAge As Decimal, ByVal decOriginalWeight As Decimal, ByVal decOriginalHeight As Decimal, ByRef CalculateMaleRestRate As Decimal)
        CalculateMaleRestRate = (66D + (6.23D * decOriginalWeight) + (12.7D * (decOriginalHeight)) - (6.8D * decOriginalAge))
    End Sub

    'Calculate RMR imperial for women 
    Private Sub CalculateFemaleRestRateImperial(ByVal decOriginalAge As Decimal, ByVal decOriginalWeight As Decimal, ByVal decOriginalHeight As Decimal, ByRef CalculateFemaleRestRate As Decimal)
        CalculateFemaleRestRate = (655D + (4.35D * decOriginalWeight) + (4.7D * (decOriginalHeight)) - (4.7D * decOriginalAge))
    End Sub

    Private Sub frmCalorieCalculator_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Populate the gender box
        cboGender.Items.Add("female")
        cboGender.Items.Add("male")

        'Select the first gender
        cboGender.SelectedIndex = 0

        'Populate the activity level box
        cboLevelActivity.Items.Add("Sitting or Lying all day")
        cboLevelActivity.Items.Add("Seated work, no exercise")
        cboLevelActivity.Items.Add("Seated work, light exercise")
        cboLevelActivity.Items.Add("Moderately physical work, no exercise")
        cboLevelActivity.Items.Add("Moderately physical work, light exercise")
        cboLevelActivity.Items.Add("Moderately physical work, heavy exercise")
        cboLevelActivity.Items.Add("Heavy work or Heavy Exercise")

        'Select the first activity level
        cboLevelActivity.SelectedIndex = 0

        'Calculate the final RMR value based on activity level
        Dim strLevelActivity As String = cboLevelActivity.SelectedItem.ToString
        Select Case strLevelActivity.ToString
            Case "Sitting or Lying all day"
                objUser.decRmr *= 1.2D

            Case "Seated work, no exercise"
                objUser.decRmr *= 1.3D

            Case "Seated work, light exercise"
                objUser.decRmr *= 1.4D

            Case "Moderately physical work, no exercise"
                objUser.decRmr *= 1.5D

            Case "Moderately physical work, light exercise"
                objUser.decRmr *= 1.6D

            Case "Moderately physical work, heavy exercise"
                objUser.decRmr *= 1.7D

            Case "Heavy work or Heavy Exercise"
                objUser.decRmr *= 1.8D

        End Select

        'Populate List box of User
        lbxUser.DataSource = lstUser
        lbxUser.DisplayMember = "Name"

        Reload_Users()

    End Sub

    Private Sub Reload_Users()
        'Clear ListBox
        lstUser.Clear()

        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create a command object
        Dim cmdSelect As New SqlCommand("Select * from Table_User;", dbConnection)

        'Execute command into a database
        Dim rdrUser As SqlDataReader = cmdSelect.ExecuteReader

        If rdrUser.HasRows Then
            While rdrUser.Read
                Dim objStoredUser As New User()
                objStoredUser.User_Id = CDec(rdrUser.Item("User_Id"))
                objStoredUser.Name = rdrUser.Item("Name").ToString
                objStoredUser.Gender = rdrUser.Item("Gender").ToString
                objStoredUser.Height = CDec(rdrUser.Item("Height"))
                objStoredUser.Weight = CDec(rdrUser.Item("Weight"))
                objStoredUser.Hip = CDec(rdrUser.Item("Hip"))
                objStoredUser.Waist = CDec(rdrUser.Item("Waist"))
                objStoredUser.Wrist = CDec(rdrUser.Item("Wrist"))
                objStoredUser.ForeArm = CDec(rdrUser.Item("ForeArm"))
                objStoredUser.ActivityLevel = rdrUser.Item("ActivityLevel").ToString
                objStoredUser.Age = CDec(rdrUser.Item("Age"))
                objStoredUser.ActivityLevelRmr = CDec(rdrUser.Item("ActivityLevelRmr"))
                objStoredUser.Rmr = CDec(rdrUser.Item("Rmr"))
                objStoredUser.BFP = CDec(rdrUser.Item("BFP"))
                objStoredUser.RmrOriginal = CDec(rdrUser.Item("RmrOriginal"))

                lstUser.Add(objStoredUser)

            End While
        End If

        'Select the first user when loads the application
        SelectedUserRecord()

        dbConnection.Close()
        dbConnection.Dispose()
    End Sub

    Private Sub Calculate()
        'Declare variables
        Dim blnInputCheckedAge As Boolean
        Dim blnInputCheckedWeight As Boolean
        Dim blnInputCheckedHeight As Boolean
        Dim blnInputCheckedWaist As Boolean
        Dim blnInputCheckedWrist As Boolean
        Dim blnInputCheckedHip As Boolean
        Dim blnInputCheckedForearm As Boolean
        Dim decActivityLevelRmr As Decimal = 0.0D
        Dim decRmr As Decimal
        Dim intAge As Decimal
        Dim intWeight As Decimal
        Dim intHeight As Decimal
        Dim decWaist As Decimal
        Dim decHip As Decimal
        Dim decWrist As Decimal
        Dim decForearm As Decimal
        Dim decUserId As Decimal

        'Display message for empty fields
        If txtHip.Text = "" Or txtForearm.Text = "" Or txtWrist.Text = "" Or txtWaist.Text = "" Or txtHeight.Text = "" Or txtName.Text = "" Or txtAge.Text = "" Or txtWeight.Text = "" Then
            lblValEmpty.BackColor = Color.White
            lblValEmpty.Text = "Please, fill out all required fields!"

        Else
            lblValEmpty.BackColor = Color.Snow
            lblValEmpty.Text = ""

            'Assign Variables
            blnInputCheckedAge = Decimal.TryParse(txtAge.Text, intAge)
            blnInputCheckedWeight = Decimal.TryParse(txtWeight.Text, intWeight)
            blnInputCheckedWaist = Decimal.TryParse(txtWaist.Text, decWaist)
            blnInputCheckedWrist = Decimal.TryParse(txtWrist.Text, decWrist)
            blnInputCheckedHip = Decimal.TryParse(txtHip.Text, decHip)
            blnInputCheckedForearm = Decimal.TryParse(txtForearm.Text, decForearm)
            blnInputCheckedHeight = Decimal.TryParse(txtHeight.Text, intHeight)

            If blnInputCheckedWrist = False And txtWrist.Text IsNot "" Or blnInputCheckedWaist = False And txtWaist.Text IsNot "" Or blnInputCheckedForearm = False And txtForearm.Text IsNot "" Or blnInputCheckedHip = False And txtHip.Text IsNot "" Or blnInputCheckedHeight = False And txtHeight.Text IsNot "" Or blnInputCheckedAge = False And txtAge.Text IsNot "" Or blnInputCheckedWeight = False And txtWeight.Text IsNot "" Then
                lblError.Text = "Please, enter a valid number."

            Else

                'Assign Variables
                objUser.User_Id = decUserId
                objUser.Name = txtName.Text
                objUser.Height = intHeight
                objUser.Weight = intWeight
                objUser.Age = intAge
                objUser.Rmr = decRmr
                objUser.ActivityLevelRmr = decActivityLevelRmr
                objUser.Waist = decWaist
                objUser.Hip = decHip
                objUser.Wrist = decWrist
                objUser.ForeArm = decForearm
                objUser.Gender = cboGender.Text
                objUser.ActivityLevel = cboLevelActivity.Text
                lblName.Text = objUser.Name
                lblHeight.Text = CType(objUser.Height, String)
                lblWeight.Text = CType(objUser.Weight, String)
                lblAgeUser.Text = CType(objUser.Age, String)
                lblGenderUser.Text = cboGender.Text
                lblActivity.Text = cboLevelActivity.Text

                'Calculate RMR based on gender And kind of measurement
                If blnInputCheckedAge And blnInputCheckedWeight And blnInputCheckedHeight Then
                    Dim strGender As String = cboGender.SelectedItem.ToString

                    Select Case strGender.ToString

                        Case "male"
                            If (radMetric.Checked) Then
                                Call CalculateMaleRestRateMetric(intAge, intWeight, intHeight, objUser.decRmr)
                                lblBmr.Text = objUser.decRmr.ToString

                                objUser.decRmrOriginal = objUser.decRmr
                                Call objUser.CalculateBodyFatPercentageMaleMetric(intWeight, decWaist, objUser.decBfp)

                                lblBodyFat.Text = objUser.decBfp.ToString
                            ElseIf (radImperial.Checked) Then
                                Call CalculateMaleRestRateImperial(intAge, intWeight, intHeight, objUser.decRmr)
                                lblBmr.Text = objUser.decRmr.ToString
                                objUser.decRmrOriginal = objUser.decRmr
                                Call objUser.CalculateBodyFatPercentageMale(intWeight, decWaist, objUser.decBfp)

                                lblBodyFat.Text = objUser.decBfp.ToString
                            End If

                        Case "female"
                            If (radMetric.Checked) Then
                                Call CalculateFemaleRestRateMetric(intAge, intWeight, intHeight, objUser.decRmr)
                                lblBmr.Text = objUser.decRmr.ToString
                                objUser.decRmrOriginal = objUser.decRmr
                                Call objUser.CalculateBodyFatPercentageFemaleMetric(intWeight, decWrist, decWaist, decHip, decForearm, objUser.decBfp)

                                lblBodyFat.Text = objUser.decBfp.ToString
                            ElseIf (radImperial.Checked) Then
                                Call CalculateFemaleRestRateImperial(intAge, intWeight, intHeight, objUser.decRmr)
                                lblBmr.Text = objUser.decRmr.ToString
                                objUser.decRmrOriginal = objUser.decRmr
                                Call objUser.CalculateBodyFatPercentageFemale(intWeight, decWrist, decWaist, decHip, decForearm, objUser.decBfp)

                                lblBodyFat.Text = objUser.decBfp.ToString
                            End If

                    End Select

                    'Calculate the final RMR value based on activity level
                    Dim strLevelActivity As String = cboLevelActivity.SelectedItem.ToString
                    Select Case strLevelActivity.ToString
                        Case "Sitting or Lying all day"
                            objUser.decRmr *= 1.2D

                        Case "Seated work, no exercise"
                            objUser.decRmr *= 1.3D

                        Case "Seated work, light exercise"
                            objUser.decRmr *= 1.4D

                        Case "Moderately physical work, no exercise"
                            objUser.decRmr *= 1.5D

                        Case "Moderately physical work, light exercise"
                            objUser.decRmr *= 1.6D

                        Case "Moderately physical work, heavy exercise"
                            objUser.decRmr *= 1.7D

                        Case "Heavy work or Heavy Exercise"
                            objUser.decRmr *= 1.8D

                    End Select
                    objUser.decActivityLevelRmr += objUser.decRmr

                    'Display total RMR
                    lblActivityMr.Text = objUser.decActivityLevelRmr.ToString()

                    'Clear message for empty fields
                    'When user fills out all fields
                    lblValEmpty.BackColor = Color.Snow
                    lblValEmpty.Text = ""

                    'Clear message for error fields
                    lblError.BackColor = Color.Snow
                    lblError.Text = ""

                End If
            End If
        End If

    End Sub

    'Calculate and add new user to database
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Add user object to list of Users'
        lstUser.Add(objUser)

        Calculate()

        InsertUser()

    End Sub


    Private Function OpenDBConnection() As SqlConnection
        'Create a connection string
        'This give the full path into the bin/debug folder
        Dim strPath As String = Application.StartupPath
        Dim intPathLength As Integer = strPath.Length
        'This strips off the bin/debug folder to point into your project folder.
        strPath = strPath.Substring(0, intPathLength - 9)

        'Create a connection string
        Dim strConnection As String = "Server=(LocalDB)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=" + strPath + "MyOrganization.mdf"
        Dim dbConnection As New SqlConnection(strConnection)

        Try
            'Open Database
            dbConnection.Open()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        Return dbConnection
    End Function

    Public Sub InsertUser()
        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create SQL String
        Dim strSql = "Insert into Table_User (Name,Gender,Height,Weight,Hip,Waist,Wrist,ForeArm,ActivityLevel,Age,BFP,ActivityLevelRmr,RmrOriginal,Rmr) values (@Name,@Gender,@Height,@Weight,@Hip,@Waist,@Wrist,@ForeArm,@ActivityLevel,@Age,@BFP,@ActivityLevelRmr,@RmrOriginal,@Rmr)"

        'Create command
        Dim cmdInsert As New SqlCommand(strSql, dbConnection)

        'Populate parameters of the insert
        cmdInsert.Parameters.AddWithValue("Name", lstUser.Last.Name)
        cmdInsert.Parameters.AddWithValue("Gender", lstUser.Last.Gender)
        cmdInsert.Parameters.AddWithValue("Height", lstUser.Last.Height)
        cmdInsert.Parameters.AddWithValue("Weight", lstUser.Last.Weight)
        cmdInsert.Parameters.AddWithValue("Hip", lstUser.Last.Hip)
        cmdInsert.Parameters.AddWithValue("Waist", lstUser.Last.Waist)
        cmdInsert.Parameters.AddWithValue("Wrist", lstUser.Last.Wrist)
        cmdInsert.Parameters.AddWithValue("ForeArm", lstUser.Last.ForeArm)
        cmdInsert.Parameters.AddWithValue("ActivityLevel", lstUser.Last.ActivityLevel)
        cmdInsert.Parameters.AddWithValue("Age", lstUser.Last.Age)
        cmdInsert.Parameters.AddWithValue("BFP", lblBodyFat.Text)
        cmdInsert.Parameters.AddWithValue("ActivityLevelRmr", lblActivityMr.Text)
        cmdInsert.Parameters.AddWithValue("RmrOriginal", objUser.decRmrOriginal)
        cmdInsert.Parameters.AddWithValue("Rmr", lblBmr.Text)

        Try
            Dim intRowsAffected = cmdInsert.ExecuteNonQuery()
            If intRowsAffected = 1 Then
                MessageBox.Show(lstUser.Last.Name & " was inserted")

            Else
                MessageBox.Show("The insert failed.")
            End If
        Catch ex As Exception
            MessageBox.Show("Please insert all fields!")

        End Try

        Reload_Users()

        'This selects and highlights the last item in the list box
        [lbxUser].SetSelected([lbxUser].Items.Count - 1, True)
    End Sub

    Public Sub UpdateUser()
        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create SQL String
        Dim strSql = "Update Table_User set Name='" & txtName.Text & "',Gender='" & cboGender.Text & "',Height='" & txtHeight.Text & "',Weight='" & txtWeight.Text & "',Hip='" & txtHip.Text & "',Waist='" & txtWaist.Text & "',Wrist='" & txtWrist.Text & "',ForeArm='" & txtForearm.Text & "',ActivityLevel='" &
        cboLevelActivity.Text & "',Age='" & txtAge.Text & "',BFP='" & lblBodyFat.Text & "',ActivityLevelRmr='" & lblActivityMr.Text & "',RmrOriginal='" & objUser.decRmrOriginal & "',Rmr='" & lblBmr.Text & "' WHERE User_Id = '" & txtId.Text & "'"

        MessageBox.Show(strSql)
        'Create command
        Dim cmdUpdate As New SqlCommand(strSql, dbConnection)

        'Populate parameters of the insert
        cmdUpdate.Parameters.AddWithValue("Name", lstUser.Last.Name)
        cmdUpdate.Parameters.AddWithValue("Gender", lstUser.Last.Gender)
        cmdUpdate.Parameters.AddWithValue("Height", lstUser.Last.Height)
        cmdUpdate.Parameters.AddWithValue("Weight", lstUser.Last.Weight)
        cmdUpdate.Parameters.AddWithValue("Hip", lstUser.Last.Hip)
        cmdUpdate.Parameters.AddWithValue("Waist", lstUser.Last.Waist)
        cmdUpdate.Parameters.AddWithValue("Wrist", lstUser.Last.Wrist)
        cmdUpdate.Parameters.AddWithValue("ForeArm", lstUser.Last.ForeArm)
        cmdUpdate.Parameters.AddWithValue("ActivityLevel", lstUser.Last.ActivityLevel)
        cmdUpdate.Parameters.AddWithValue("Age", lstUser.Last.Age)
        cmdUpdate.Parameters.AddWithValue("BFP", lblBodyFat.Text)
        cmdUpdate.Parameters.AddWithValue("ActivityLevelRmr", lblActivityMr.Text)
        cmdUpdate.Parameters.AddWithValue("RmrOriginal", objUser.decRmrOriginal)
        cmdUpdate.Parameters.AddWithValue("Rmr", lblBmr.Text)

        Try
            Dim intRowsAffected = cmdUpdate.ExecuteNonQuery()
            If intRowsAffected = 1 Then
                MessageBox.Show(lstUser.Last.User_Id & " was updated")
            Else
                MessageBox.Show("The Update failed.")
            End If
        Catch ex As Exception
            MessageBox.Show("Database Update failed" & ex.Message)

        End Try

        Reload_Users()

    End Sub

    Public Sub DeleteUser()
        'Open database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create SQL String
        Dim strSql = "Delete from Table_User Where User_Id = '" & txtId.Text & "'"
        MessageBox.Show(strSql)
        'Create command
        Dim cmdDelete As New SqlCommand(strSql, dbConnection)

        Try
            Dim intRowsAffected = cmdDelete.ExecuteNonQuery()
            If intRowsAffected = 1 Then
                MessageBox.Show("Record was Deleted")
            Else
                MessageBox.Show("The Delete failed.")
            End If
        Catch ex As Exception
            MessageBox.Show("Database Delete failed" & ex.Message)

        End Try

        Reload_Users()

    End Sub

    'Clear fields from General Information or set to default value
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtAge.Text = ""
        txtHeight.Text = ""
        txtWeight.Text = ""
        txtWaist.Text = ""
        txtHip.Text = ""
        txtWrist.Text = ""
        txtName.Text = ""
        txtForearm.Text = ""
        cboLevelActivity.SelectedIndex = 0
        cboGender.SelectedIndex = 0
    End Sub

    'Update metric measurements when metric radio is checked
    Private Sub lblMetric_CheckedChanged(sender As Object, e As EventArgs) Handles radMetric.CheckedChanged
        lblHeightRight.Text = "cm"
        lblWeightRight.Text = "kgs"
        lblWaistRight.Text = "cm"
        lblWristRight.Text = "cm"
        lblHipRight.Text = "cm"
        lblForearmRight.Text = "cm"

    End Sub

    'Update imperial measurements when imperial radio is checked
    Private Sub lblImperial_CheckedChanged(sender As Object, e As EventArgs) Handles radImperial.CheckedChanged
        lblHeightRight.Text = "in"
        lblWeightRight.Text = "lbs"
        lblWaistRight.Text = "in"
        lblWristRight.Text = "in"
        lblHipRight.Text = "in"
        lblForearmRight.Text = "in"

    End Sub

    'Load user records and update on the label fields
    Private Sub SelectedUserRecord()

        If lbxUser.SelectedIndex >= 0 Then
            Dim objSelectedUser As User = CType(lbxUser.SelectedItem, User)
            txtId.Text = objSelectedUser.User_Id.ToString

            txtName.Text = objSelectedUser.Name
            lblName.Text = objSelectedUser.Name

            txtHeight.Text = CType(objSelectedUser.Height, String)
            lblHeight.Text = CType(objSelectedUser.Height, String)

            txtWeight.Text = CType(objSelectedUser.Weight, String)
            lblWeight.Text = CType(objSelectedUser.Weight, String)

            cboGender.Text = objSelectedUser.Gender
            lblGenderUser.Text = objSelectedUser.Gender

            txtAge.Text = CType(objSelectedUser.Age, String)
            lblAgeUser.Text = CType(objSelectedUser.Age, String)

            cboLevelActivity.Text = objSelectedUser.ActivityLevel
            lblActivity.Text = objSelectedUser.ActivityLevel

            txtWaist.Text = CType(objSelectedUser.Waist, String)
            txtWrist.Text = CType(objSelectedUser.Wrist, String)

            txtHip.Text = CType(objSelectedUser.Hip, String)
            txtForearm.Text = CType(objSelectedUser.ForeArm, String)

            lblBmr.Text = CType(objSelectedUser.Rmr, String)
            lblActivityMr.Text = CType(objSelectedUser.ActivityLevelRmr, String)
            lblBodyFat.Text = CType(objSelectedUser.BFP, String)


        End If
    End Sub


    Private Sub lbxUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxUser.SelectedIndexChanged
        SelectedUserRecord()

    End Sub

    'Delete User
    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        DeleteUser()
    End Sub

    'Update User
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Calculate()
        UpdateUser()
    End Sub
End Class
