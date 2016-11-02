
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports PrismBindingIssueVB.Models
Imports Prism.Windows.Mvvm
Imports System.Windows.Input
Imports Prism.Windows.Navigation
Imports Prism.Commands



Namespace ViewModels
    Class PersonPageViewModel
        Inherits ViewModelBase

        Private _navigationService As INavigationService
        Private _hos As New House()
        Private _person As New Person()

        Public Property Purson() As Person
            Get
                Return _person
            End Get
            Set
                SetProperty(_person, Value)
            End Set
        End Property

        Private _navHouse As ICommand

        Public Property NavHouse() As ICommand
            Get
                Return _navHouse
            End Get
            Set
                _navHouse = Value
            End Set
        End Property

        Private _htype As String

        Public Property Type() As String
            Get
                Return _htype
            End Get
            Set
                SetProperty(_htype, Value)
            End Set
        End Property

        Private _hage As String

        Public Property Age() As String
            Get
                Return _hage
            End Get
            Set
                SetProperty(_hage, Value)
            End Set
        End Property




        Public Sub New(navigationService As INavigationService)
            _navigationService = navigationService
            NavHouse = New DelegateCommand(AddressOf NavigateToPerson)
        End Sub

        Private Sub NavigateToPerson()
            If _person.ValidateProperties() Then
                _navigationService.Navigate("House", _person)
            End If
        End Sub

        Public Overrides Sub OnNavigatedTo(e As NavigatedToEventArgs, viewModelState As Dictionary(Of String, Object))
            MyBase.OnNavigatedTo(e, viewModelState)

            _hos = DirectCast(e.Parameter, House)

            If _hos IsNot Nothing Then
                Me.Age = "Age passed from House Form:" + _hos.Age
                Me.Type = "Type passed from House Form:" + _hos.Type
            End If
        End Sub


    End Class
End Namespace

