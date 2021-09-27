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
        CurrentPageViewModel = New HomeViewModel(Me)
    End Sub

End Class