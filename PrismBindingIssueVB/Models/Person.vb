
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports Prism.Windows.Validation
Imports System.ComponentModel.DataAnnotations


Namespace Models
    Class Person
        Inherits ValidatableBindableBase
        Private _name As String
        Private _age As String

        <Required(ErrorMessage:="Value Required")>
        Public Property Name() As String
            Get
                Return _name
            End Get
            Set
                SetProperty(_name, Value)
            End Set
        End Property

        Public Property Age() As String
            Get
                Return _age
            End Get
            Set
                SetProperty(_age, Value)
            End Set
        End Property

    End Class
End Namespace
