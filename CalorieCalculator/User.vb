'Author: Suelen Duarte
'Date: 02/16/2020
'Purpose: Manage User class

Option Strict On
Option Explicit On
Public Class User
    Private strName As String
    Private strGender As String
    Private decTotalBodyWeight As Decimal
    Private intHeight As Decimal
    Private decHip As Decimal
    Private decWaist As Decimal
    Private decWrist As Decimal
    Private decForeArm As Decimal
    Public decRmr As Decimal
    Public decRmrOriginal As Decimal
    Public decBfp As Decimal
    Public decActivityLevelRmr As Decimal
    Private strActivityLevel As String
    Private intAge As Decimal
    Private decWeight As Decimal
    Public decRate As Decimal
    Private userId As Decimal

    Public Property Name As String
        Get
            Return strName
        End Get
        Set(value As String)
            strName = value
        End Set
    End Property

    Public Property Gender As String
        Get
            Return strGender
        End Get
        Set(value As String)
            strGender = value
        End Set
    End Property

    Public Property TotalBodyWeight As Decimal
        Get
            Return decTotalBodyWeight
        End Get
        Set(value As Decimal)
            decTotalBodyWeight = value
        End Set
    End Property

    Public Property Height As Decimal
        Get
            Return intHeight
        End Get
        Set(value As Decimal)
            intHeight = value
        End Set
    End Property

    Public Property Hip As Decimal
        Get
            Return decHip
        End Get
        Set(value As Decimal)
            decHip = value
        End Set
    End Property

    Public Property Waist As Decimal
        Get
            Return decWaist
        End Get
        Set(value As Decimal)
            decWaist = value
        End Set
    End Property

    Public Property Wrist As Decimal
        Get
            Return decWrist
        End Get
        Set(value As Decimal)
            decWrist = value
        End Set
    End Property

    Public Property ForeArm As Decimal
        Get
            Return decForeArm
        End Get
        Set(value As Decimal)
            decForeArm = value
        End Set
    End Property

    Public Property Rmr As Decimal
        Get
            Return decRmr
        End Get
        Set(value As Decimal)
            decRmr = value
        End Set
    End Property

    Public Property ActivityLevel As String
        Get
            Return strActivityLevel
        End Get
        Set(value As String)
            strActivityLevel = value
        End Set
    End Property

    Public Property Age As Decimal
        Get
            Return intAge
        End Get
        Set(value As Decimal)
            intAge = value
        End Set
    End Property

    Public Property Weight As Decimal
        Get
            Return decWeight
        End Get
        Set(value As Decimal)
            decWeight = value
        End Set
    End Property

    Public Property BFP As Decimal
        Get
            Return decBfp
        End Get
        Set(value As Decimal)
            decBfp = value
        End Set
    End Property

    Public Property ActivityLevelRmr As Decimal
        Get
            Return decActivityLevelRmr
        End Get
        Set(value As Decimal)
            decActivityLevelRmr = value
        End Set
    End Property

    Public Property RmrOriginal As Decimal
        Get
            Return decRmrOriginal
        End Get
        Set(value As Decimal)
            decRmrOriginal = value
        End Set
    End Property

    Public Property User_Id As Decimal
        Get
            Return userId
        End Get
        Set(value As Decimal)
            userId = value
        End Set
    End Property


    'Calculate Body Fat imperial for womem 
    Public Sub CalculateBodyFatPercentageFemale(ByVal decWeight As Decimal, ByVal decWrist As Decimal, ByVal decWaist As Decimal, ByVal decHip As Decimal, ByVal decForeArm As Decimal, ByRef CalculateBodyFatFemale As Decimal)
        CalculateBodyFatFemale = ((decWeight - (((decWeight * 0.732D) + 8.987D) + (decWrist / 3.14D) - (decWaist * 0.157D) - (decHip * 0.249D) + (decForeArm * 0.434D))) * 100D) / decWeight
    End Sub

    'Calculate Body Fat imperial for men 
    Public Sub CalculateBodyFatPercentageMale(ByVal decWeight As Decimal, ByVal decWaist As Decimal, ByRef CalculateBodyFatMale As Decimal)
        CalculateBodyFatMale = ((decWeight - (((decWeight * 1.082D) + 94.42D) - (decWaist * 4.15D))) * 100D) / decWeight
    End Sub

    'Calculate Body Fat metric for womem 
    Public Sub CalculateBodyFatPercentageFemaleMetric(ByVal decWeight As Decimal, ByVal decWrist As Decimal, ByVal decWaist As Decimal, ByVal decHip As Decimal, ByVal decForeArm As Decimal, ByRef CalculateBodyFatFemale As Decimal)
        CalculateBodyFatFemale = (((decWeight / 0.4535D) - ((((decWeight / 0.4535D) * 0.732D) + 8.987D) + ((decWrist * 0.3937D) / 3.14D) - (decWaist * 0.3937D * 0.157D) - (decHip * 0.3937D * 0.249D) + (decForeArm * 0.3937D * 0.434D))) * 100D) / (decWeight / 0.4535D)
    End Sub

    'Calculate Body Fat metric for men
    Public Sub CalculateBodyFatPercentageMaleMetric(ByVal decWeight As Decimal, ByVal decWaist As Decimal, ByRef CalculateBodyFatMale As Decimal)
        CalculateBodyFatMale = (((decWeight / 0.4535D) - ((((decWeight / 0.4535D) * 1.082D) + 94.42D) - (decWaist * 0.3937D * 4.15D))) * 100D) / (decWeight / 0.4535D)

    End Sub

End Class
