'--------------------------------------------------------------------------
' Author : Nguyen Khanh Tung
' Company : Thiên An ESS
' Created Date : 04/05/2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class Users
#Region "Constructor"
#End Region

#Region "Var"
        Private mUserID As Integer = 0
        Private mUserName As String = ""
        Private mPassWord As String = ""
        Private mFullName As String = ""
        Private mUserGroup As Integer = 0
        Private mID_phong As Integer = 0
        Private mID_khoa As Integer = 0
        Private mID_Bomon As Integer = 0
        Private mID_dv As String = "P1"
        Private mdsID_lop As String = "0"
        Private mdsID_dt As String = "0"
        Private mPhong_ban As String = ""
        Private mActive As Integer = 0
        Private mMay_tram As String = ""
        Private mUserNameLDAP As String = ""
        Private madsPathLDAP As String = ""
        Private mQuyen As New UsersQuyen
        Private mHeAccess As New UsersHeAcess
        Private mLopAccess As New UsersLopAccess
        Private mVaiTro As New VaiTro
        Private mDien_Thoai As String = ""
        Private mEmail As String = ""
#End Region

#Region "Function"
        
#End Region

#Region "Property"
        Public Property UserID() As Integer
            Get
                Return mUserID
            End Get
            Set(ByVal Value As Integer)
                mUserID = Value
            End Set
        End Property
        Public Property UserName() As String
            Get
                Return mUserName
            End Get
            Set(ByVal Value As String)
                mUserName = Value
            End Set
        End Property
        Public Property PassWord() As String
            Get
                Return mPassWord
            End Get
            Set(ByVal Value As String)
                mPassWord = Value
            End Set
        End Property
        Public Property FullName() As String
            Get
                Return mFullName
            End Get
            Set(ByVal Value As String)
                mFullName = Value
            End Set
        End Property
        Public Property UserGroup() As Integer
            Get
                Return mUserGroup
            End Get
            Set(ByVal Value As Integer)
                mUserGroup = Value
            End Set
        End Property
        Public Property ID_phong() As Integer
            Get
                Return mID_phong
            End Get
            Set(ByVal Value As Integer)
                mID_phong = Value
            End Set
        End Property
        Public Property Phong_ban() As String
            Get
                Return mPhong_ban
            End Get
            Set(ByVal Value As String)
                mPhong_ban = Value
            End Set
        End Property
        Public Property ID_khoa() As Integer
            Get
                Return mID_khoa
            End Get
            Set(ByVal Value As Integer)
                mID_khoa = Value
            End Set
        End Property
        Public Property ID_Bomon() As Integer
            Get
                Return mID_Bomon
            End Get
            Set(ByVal Value As Integer)
                mID_Bomon = Value
            End Set
        End Property
        Public Property ID_dv() As String
            Get                
                Return mID_dv
            End Get
            Set(ByVal Value As String)
                mID_dv = Value
            End Set
        End Property
        Public Property dsID_lop() As String
            Get
                Return mdsID_lop
            End Get
            Set(ByVal Value As String)
                mdsID_lop = Value
            End Set
        End Property
        Public Property dsID_dt() As String
            Get
                Return mdsID_dt
            End Get
            Set(ByVal Value As String)
                mdsID_dt = Value
            End Set
        End Property
        Public Property Active() As Integer
            Get
                Return mActive
            End Get
            Set(ByVal Value As Integer)
                mActive = Value
            End Set
        End Property
        Public Property May_tram() As String
            Get
                Return mMay_tram
            End Get
            Set(ByVal Value As String)
                mMay_tram = Value
            End Set
        End Property
        Public Property UserNameLDAP() As String
            Get
                Return mUserNameLDAP
            End Get
            Set(ByVal Value As String)
                mUserNameLDAP = Value
            End Set
        End Property
        Public Property adsPathLDAP() As String
            Get
                Return madsPathLDAP
            End Get
            Set(ByVal Value As String)
                madsPathLDAP = Value
            End Set
        End Property
        Public Property Quyen() As UsersQuyen
            Get
                Return mQuyen
            End Get
            Set(ByVal Value As UsersQuyen)
                mQuyen = Value
            End Set
        End Property
        Public Property HeAccess() As UsersHeAcess
            Get
                Return mHeAccess
            End Get
            Set(ByVal Value As UsersHeAcess)
                mHeAccess = Value
            End Set
        End Property
        Public Property LopAaccess() As UsersLopAccess
            Get
                Return mLopAccess
            End Get
            Set(ByVal Value As UsersLopAccess)
                mLopAccess = Value
            End Set
        End Property
        Public Property VaiTro() As VaiTro
            Get
                Return mVaiTro
            End Get
            Set(ByVal Value As VaiTro)
                mVaiTro = Value
            End Set
        End Property

        Public Property Dien_thoai() As String
            Get
                Return mDien_thoai
            End Get
            Set(ByVal Value As String)
                mDien_thoai = Value
            End Set
        End Property
        Public Property Email() As String
            Get
                Return mEmail
            End Get
            Set(ByVal Value As String)
                mEmail = Value
            End Set
        End Property
#End Region
    End Class
End Namespace
