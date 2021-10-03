Public Class LoginViewModel
    Inherits BaseViewModel
    Private _context As MainViewModel
    Public Sub New(context As MainViewModel)
        _context = context
        LogInCommand = New DelegateCommand(AddressOf LogIn, AddressOf CanLogIn)

    End Sub

    Private _UserName As String

    Public Property UserName()
        Get
            Return _UserName

        End Get
        Set(value)
            _UserName = value
            OnPropertyChanged(NameOf(UserName))

        End Set
    End Property
    Private _LogInCommand As ICommand

    Public Property LogInCommand() As ICommand
        Get
            Return _LogInCommand

        End Get
        Set(ByVal value As ICommand)
            _LogInCommand = value
            OnPropertyChanged(NameOf(LogInCommand))

        End Set
    End Property

    Public Sub LogIn(passwordBox As PasswordBox)
        'Accion de LogIn
        Dim pass = passwordBox.Password
        _context.ChangeView(NameOf(HomeView))


    End Sub

    Public Function CanLogIn() As Boolean
        Return True

    End Function




End Class
