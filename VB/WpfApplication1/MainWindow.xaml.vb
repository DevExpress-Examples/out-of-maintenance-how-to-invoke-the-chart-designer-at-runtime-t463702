Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Charts.Designer

Namespace WpfApplication1

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim designer As ChartDesigner = New ChartDesigner(Me.chart)
            designer.Show(Me)
        End Sub
    End Class
End Namespace
