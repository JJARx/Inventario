
Public Class DelegateCommand
    Implements ICommand

    Private m_canExecute As Func(Of Object, Boolean)
    Private m_executeAction As Action(Of Object)
    Private m_canExecuteCache As Boolean

    Public Event CanExecuteChanged(ByVal sender As Object, ByVal e As System.EventArgs) Implements ICommand.CanExecuteChanged

    Public Sub New(ByVal executeAction As Action(Of Object), ByVal canExecute As Func(Of Object, Boolean))
        Me.m_executeAction = executeAction
        Me.m_canExecute = canExecute
    End Sub

    Public Function CanExecute(ByVal parameter As Object) As Boolean Implements ICommand.CanExecute
        Dim temp As Boolean = m_canExecute(parameter)
        If m_canExecuteCache <> temp Then
            m_canExecuteCache = temp
            RaiseEvent CanExecuteChanged(Me, New EventArgs())
        End If
        Return m_canExecuteCache
    End Function

    Public Sub Execute(ByVal parameter As Object) Implements ICommand.Execute
        m_executeAction(parameter)
    End Sub
End Class
