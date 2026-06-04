Public Class FormBase
    Inherits Form
    Private sidebarExpanded As Boolean = False


    Private Sub FormBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sidebar.Width = 60
        AddHandler sidebar.ToggleSideBar, AddressOf ToggleSidebar
        sidebar.BringToFront()
    End Sub

    Protected Sub ToggleSidebar()

        TimerSidebar.Start()
    End Sub

    Private Sub TimerSidebar_tick(sender As Object, e As EventArgs) Handles TimerSidebar.Tick
        If sidebarExpanded Then

            sidebar.Width -= 20

            If sidebar.Width <= 60 Then

                sidebar.Width = 60

                sidebarExpanded = False

                TimerSidebar.Stop()

            End If

        Else

            sidebar.Width += 20

            If sidebar.Width >= 250 Then

                sidebar.Width = 250

                sidebarExpanded = True

                TimerSidebar.Stop()

            End If

        End If
    End Sub
End Class