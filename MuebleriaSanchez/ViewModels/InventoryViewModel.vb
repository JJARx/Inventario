Imports System.Collections.ObjectModel

Public Class InventoryViewModel
    Inherits BaseViewModel
    Private Property _InventoryList() As ObservableCollection(Of InventoryModel)

    Public Property InventoryList() As ObservableCollection(Of InventoryModel)
        Get
            Return _InventoryList

        End Get
        Set(value As ObservableCollection(Of InventoryModel))
            _InventoryList = value
            OnPropertyChanged(NameOf(InventoryList))
        End Set
    End Property

    Private Property _context As MainViewModel

    Public Sub New(context As MainViewModel)
        _context = context
        InventoryList = New ObservableCollection(Of InventoryModel)
        Dim Product = New InventoryModel()
        Product.Id = 1
        Product.ProductName = "Silla"
        Product.Quantity = 40
        Product.Price = 20.34
        Product.EditImageSource = "/Resources/EditIcon.png"

        InventoryList.Add(Product)



    End Sub

End Class
