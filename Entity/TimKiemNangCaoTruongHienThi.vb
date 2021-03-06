'---------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : Tuesday, May 27, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class TimKiemNangCaoTruongHienThi
#Region "Constructor"
#End Region

#Region "Var"
        Private mFieldID As String = ""
        Private mFieldGroup As Integer = 0
        Private mColStatistic As Boolean = 0
        Private mFieldName As String = ""
        Private mFieldStatistic As Boolean = 0
        Private mFieldGroupby As Boolean = 0
        Private mFieldSize As Double = 0
        Private mFieldType As Integer = 0
        Private mDTable As String = ""
        Private mLTable As String = ""
        Private mMTable As String = ""
        Private mM1Table As String = ""
        Private mRTable As String = ""
        Private mLField As String = ""
        Private mMField As String = ""
        Private mM1Field As String = ""
        Private mM2Field As String = ""
        Private mM3Field As String = ""
        Private mRField As String = ""
        Private mSTT As Integer = 0
        Private mAlign As Integer = 0
        Private mFieldShow As New ArrayList
#End Region
        Public Sub New()

        End Sub
        Public Sub Add(ByVal Field As TimKiemNangCaoTruongHienThi)
            mFieldShow.Add(Field)
        End Sub
        Public Sub Remove(ByVal idx_sk As Integer)
            mFieldShow.RemoveAt(idx_sk)
        End Sub
        Public ReadOnly Property Count() As Integer
            Get
                Return mFieldShow.Count
            End Get
        End Property
        Public Property FieldShow(ByVal idx As Integer) As TimKiemNangCaoTruongHienThi
            Get
                Return CType(mFieldShow(idx), TimKiemNangCaoTruongHienThi)
            End Get
            Set(ByVal Value As TimKiemNangCaoTruongHienThi)
                mFieldShow(idx) = Value
            End Set
        End Property
#Region "Property"

        Public Property FieldID() As String
            Get
                Return mFieldID
            End Get
            Set(ByVal Value As String)
                mFieldID = Value
            End Set
        End Property
        Public Property FieldGroup() As Integer
            Get
                Return mFieldGroup
            End Get
            Set(ByVal Value As Integer)
                mFieldGroup = Value
            End Set
        End Property
        Public Property ColStatistic() As Boolean
            Get
                Return mColStatistic
            End Get
            Set(ByVal Value As Boolean)
                mColStatistic = Value
            End Set
        End Property
        Public Property FieldName() As String
            Get
                Return mFieldName
            End Get
            Set(ByVal Value As String)
                mFieldName = Value
            End Set
        End Property
        Public Property FieldStatistic() As Boolean
            Get
                Return mFieldStatistic
            End Get
            Set(ByVal Value As Boolean)
                mFieldStatistic = Value
            End Set
        End Property
        Public Property FieldGroupby() As Boolean
            Get
                Return mFieldGroupby
            End Get
            Set(ByVal Value As Boolean)
                mFieldGroupby = Value
            End Set
        End Property
        Public Property FieldSize() As Double
            Get
                Return mFieldSize
            End Get
            Set(ByVal Value As Double)
                mFieldSize = Value
            End Set
        End Property
        Public Property FieldType() As Integer
            Get
                Return mFieldType
            End Get
            Set(ByVal Value As Integer)
                mFieldType = Value
            End Set
        End Property
        Public Property DTable() As String
            Get
                Return mDTable
            End Get
            Set(ByVal Value As String)
                mDTable = Value
            End Set
        End Property
        Public Property LTable() As String
            Get
                Return mLTable
            End Get
            Set(ByVal Value As String)
                mLTable = Value
            End Set
        End Property
        Public Property MTable() As String
            Get
                Return mMTable
            End Get
            Set(ByVal Value As String)
                mMTable = Value
            End Set
        End Property
        Public Property M1Table() As String
            Get
                Return mM1Table
            End Get
            Set(ByVal Value As String)
                mM1Table = Value
            End Set
        End Property
        Public Property RTable() As String
            Get
                Return mRTable
            End Get
            Set(ByVal Value As String)
                mRTable = Value
            End Set
        End Property
        Public Property LField() As String
            Get
                Return mLField
            End Get
            Set(ByVal Value As String)
                mLField = Value
            End Set
        End Property
        Public Property MField() As String
            Get
                Return mMField
            End Get
            Set(ByVal Value As String)
                mMField = Value
            End Set
        End Property
        Public Property M1Field() As String
            Get
                Return mM1Field
            End Get
            Set(ByVal Value As String)
                mM1Field = Value
            End Set
        End Property
        Public Property M2Field() As String
            Get
                Return mM2Field
            End Get
            Set(ByVal Value As String)
                mM2Field = Value
            End Set
        End Property
        Public Property M3Field() As String
            Get
                Return mM3Field
            End Get
            Set(ByVal Value As String)
                mM3Field = Value
            End Set
        End Property
        Public Property RField() As String
            Get
                Return mRField
            End Get
            Set(ByVal Value As String)
                mRField = Value
            End Set
        End Property
        Public Property STT() As Integer
            Get
                Return mSTT
            End Get
            Set(ByVal Value As Integer)
                mSTT = Value
            End Set
        End Property
        Public Property Align() As Integer
            Get
                Return mAlign
            End Get
            Set(ByVal Value As Integer)
                mAlign = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
