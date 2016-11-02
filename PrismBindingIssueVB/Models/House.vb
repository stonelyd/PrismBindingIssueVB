
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports Prism.Mvvm



Namespace Models
    Class House
        Inherits BindableBase

        Private _age As String
        Private _type As String

        Public Property Age() As String
            Get
                Return _age
            End Get
            Set
                SetProperty(_age, Value)
            End Set
        End Property

        Public Property Type() As String
            Get
                Return _type
            End Get
            Set
                SetProperty(_type, Value)
            End Set
        End Property


    End Class
End Namespace
