Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Runtime.InteropServices.WindowsRuntime
Imports Windows.ApplicationModel
Imports Windows.ApplicationModel.Activation
Imports Windows.Foundation
Imports Windows.Foundation.Collections
Imports Windows.UI.Xaml
Imports Windows.UI.Xaml.Controls
Imports Windows.UI.Xaml.Controls.Primitives
Imports Windows.UI.Xaml.Data
Imports Windows.UI.Xaml.Input
Imports Windows.UI.Xaml.Media
Imports Windows.UI.Xaml.Navigation
Imports Prism.Unity.Windows
Imports System.Threading.Tasks


''' <summary>
''' Provides application-specific behavior to supplement the default Application class.
''' </summary>
Partial NotInheritable Class App
        Inherits PrismUnityApplication
        Protected Overrides Function OnLaunchApplicationAsync(args As LaunchActivatedEventArgs) As Task
            NavigationService.Navigate("Person", Nothing)
            Return Task.FromResult(Of Object)(Nothing)
        End Function


    End Class

