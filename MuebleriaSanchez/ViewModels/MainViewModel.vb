Public Class MainViewModel
    Inherits BaseViewModel
    Private _currentPageViewModel As BaseViewModel


    Public Property CurrentPageViewModel As BaseViewModel
        Get
            Return _currentPageViewModel
        End Get
        Set(value As BaseViewModel)
            _currentPageViewModel = value
            OnPropertyChanged(NameOf(CurrentPageViewModel))
        End Set
    End Property
    Public Sub New()
        CurrentPageViewModel = New LoginViewModel(Me)
    End Sub

    Public Sub ChangeView(ByVal ViewName As String)
        Select Case ViewName
            Case NameOf(HomeView)
                CurrentPageViewModel = New HomeViewModel(Me)

            Case NameOf(InventoryView)
                CurrentPageViewModel = New InventoryViewModel(Me)

            Case 3

            Case 4

            Case 5

            Case 6

        End Select
    End Sub
End Class