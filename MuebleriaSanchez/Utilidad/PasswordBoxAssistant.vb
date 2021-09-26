Public Class PasswordBoxAssistant
    Public ReadOnly BoundPassword As DependencyProperty =
    DependencyProperty.RegisterAttached("BoundPassword", GetType(String), GetType(PasswordBoxAssistant), New FrameworkPropertyMetadata(String.Empty, AddressOf OnBoundPasswordChanged))

    Public ReadOnly BindPassword As DependencyProperty =
    DependencyProperty.RegisterAttached("BindPassword", GetType(Boolean), GetType(PasswordBoxAssistant), New PropertyMetadata(False, AddressOf OnBindPasswordChanged))

    Public ReadOnly UpdatingPassword As DependencyProperty =
    DependencyProperty.RegisterAttached("UpdatingPassword", GetType(Boolean), GetType(PasswordBoxAssistant))

    Private Sub OnBoundPasswordChanged(ByVal d As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
        Dim box As PasswordBox = TryCast(d, PasswordBox)

        If box Is Nothing Or Not GetBindPassword(box) Then
            Return
        End If

        RemoveHandler box.PasswordChanged, AddressOf HandlePasswordChanged

        Dim newPassword As String = TryCast(e.NewValue, String)

        If Not GetUpdatingPassword(box) Then
            box.Password = newPassword
        End If

        AddHandler box.PasswordChanged, AddressOf HandlePasswordChanged
    End Sub

    Private Sub OnBindPasswordChanged(ByVal dp As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
        Dim box As PasswordBox = TryCast(dp, PasswordBox)
        If box Is Nothing Then
            Return
        End If

        Dim wasBound As Boolean = e.OldValue
        Dim needToBind As Boolean = e.NewValue

        If wasBound Then
            RemoveHandler box.PasswordChanged, AddressOf HandlePasswordChanged
        End If

        If needToBind Then
            AddHandler box.PasswordChanged, AddressOf HandlePasswordChanged
        End If
    End Sub

    Private Sub HandlePasswordChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim box As PasswordBox = TryCast(sender, PasswordBox)
        SetUpdatingPassword(box, True)
        SetBoundPassword(box, box.Password)
        SetUpdatingPassword(box, False)
    End Sub

    Public Sub SetBindPassword(ByVal dp As DependencyObject, ByVal valor As Boolean)
        dp.SetValue(BindPassword, valor)
    End Sub

    Public Function GetBindPassword(ByVal dp As DependencyObject) As String
        Return dp.GetValue(BindPassword)
    End Function


    Public Function GetBoundPassword(ByVal dp As DependencyObject) As String
        Return dp.GetValue(BoundPassword)
    End Function

    Public Sub SetBoundPassword(ByVal dp As DependencyObject, ByVal valor As String)
        dp.SetValue(BoundPassword, valor)
    End Sub

    Public Function GetUpdatingPassword(ByVal dp As DependencyObject) As Boolean
        Return dp.GetValue(UpdatingPassword)
    End Function

    Public Sub SetUpdatingPassword(ByVal dp As DependencyObject, ByVal valor As Boolean)
        dp.SetValue(UpdatingPassword, valor)
    End Sub
End Class