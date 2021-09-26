Class Application

    ' Application-level events, such as Startup, Exit, and DispatcherUnhandledException
    ' can be handled in this file.
    Protected Overrides Sub OnStartup(e As StartupEventArgs)
        MyBase.OnStartup(e)
        Me.MainWindow = New MainWindow()
        Me.MainWindow.DataContext = New MainViewModel()
        Me.MainWindow.Show()
    End Sub
End Class
