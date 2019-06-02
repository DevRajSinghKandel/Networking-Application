Imports Windows.Networking
Imports Windows.Networking.Sockets
Imports Windows.UI.Core
Imports Windows.Storage
Imports Windows.Storage.Streams
Imports Windows.Security.Cryptography
' The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page
    Dim filesasize As UInteger
    Public WithEvents safron As New StreamSocketListener
    Public WithEvents rfm As StreamSocket
    Dim asdfan As New Windows.UI.Popups.MessageDialog("")
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add anyf initialization after the InitializeComponent() call.
        happening()

    End Sub
    Public Async Sub happening()
        Await safron.BindServiceNameAsync("1034") 'Service name can be 'https' as well but here we use port number

    End Sub


    Public Async Sub mainsih(x As StreamSocketListener, xi As StreamSocketListenerConnectionReceivedEventArgs
                        ) Handles safron.ConnectionReceived
        'Get the utf8 string settings
        Dim chancertext As String

        Using er As New StreamReader(xi.Socket.InputStream.AsStreamForRead)
            chancertext = Await er.ReadLineAsync


        End Using

        Dim eam = Sub() TERIOSA.Text = chancertext
        Await Dispatcher.RunAsync(CoreDispatcherPriority.High, eam)
    End Sub

    Private Sub Butware_Click(sender As Object, e As RoutedEventArgs) Handles Butware.Click
        'Trying to show resetted
        TERIOSA.Text = "Resetted"
    End Sub


End Class


'A socket tries to send the data..If the connection is received then,a channel for writing occurs,once writing occurs and the server respoonses
'back the connection session completes.the server gets the data.


