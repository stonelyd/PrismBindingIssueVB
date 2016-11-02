
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports Prism.Mvvm
Imports Prism.Windows.Mvvm
Imports PrismBindingIssueVB.Models
Imports System.Windows.Input
Imports Prism.Windows.Navigation
Imports Prism.Commands


Namespace ViewModels
    Class HousePageViewModel
        Inherits ViewModelBase

        Private _navigationService As INavigationService
        Private _h As New House()
        Private _per As New Person()

        Public Property Howse() As House
            Get
                Return _h
            End Get
            Set
                SetProperty(_h, Value)
            End Set
        End Property

        Private _navperson As ICommand

        Public Property NavPerson() As ICommand
            Get
                Return _navperson
            End Get
            Set
                _navperson = Value
            End Set
        End Property

        Private _dName As String

        Public Property Name() As String
            Get
                Return _dName
            End Get
            Set
                SetProperty(_dName, Value)
            End Set
        End Property

        Private _dage As String

        Public Property Age() As String
            Get
                Return _dage
            End Get
            Set
                SetProperty(_dage, Value)
            End Set
        End Property



        Public Sub New(navigationService As INavigationService)
            _navigationService = navigationService
            NavPerson = New DelegateCommand(AddressOf NavigateToPerson)
        End Sub

        Private Sub NavigateToPerson()
            _navigationService.Navigate("Person", _h)
        End Sub

        Public Overrides Sub OnNavigatedTo(e As NavigatedToEventArgs, viewModelState As Dictionary(Of String, Object))
            MyBase.OnNavigatedTo(e, viewModelState)

            _per = DirectCast(e.Parameter, Person)

            Me.Age = "Age passed from Person Form:" + _per.Age
            Me.Name = "Name passed from Person Form:" + _per.Name

        End Sub

    End Class
End Namespace


