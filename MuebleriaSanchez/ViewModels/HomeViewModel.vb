Public Class HomeViewModel
    Inherits BaseViewModel

    Private _context As MainViewModel

    Public Property OpenOptionCommand As ICommand
        Get
            Return _OpenOptionCommand
        End Get
        Set(value As ICommand)
            _OpenOptionCommand = value
            OnPropertyChanged(NameOf(OpenOptionCommand))
        End Set
    End Property

    Private Property _OpenOptionCommand As ICommand

    Public Sub New(context As MainViewModel)
        _context = context
        OpenOptionCommand = New DelegateCommand(AddressOf OpenOption, AddressOf canOpenOption)
    End Sub

    Public Sub OpenOption(optionId As Integer)
        Select Case optionId
            Case 1
                _context.ChangeView(NameOf(InventoryView))

            Case 2
                '
            Case 3

            Case 4

            Case 5

            Case 6

        End Select
    End Sub

    Public Function canOpenOption() As Boolean
        Return True
    End Function


End Class
