Imports System.Text
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Base
Imports DevExpress.Xpo

Namespace SecuritySystemExample.Module.BusinessObjects
    <DefaultClassOptions, ImageName("BO_Person")> _
    Public Class Contact
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Private _name As String
        Public Property Name() As String
            Get
                Return _name
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Name", _name, value)
            End Set
        End Property
        Private _email As String
        Public Property Email() As String
            Get
                Return _email
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Email", _email, value)
            End Set
        End Property
    End Class
End Namespace
