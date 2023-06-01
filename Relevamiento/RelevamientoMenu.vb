
Public Class RelevamientoMenu
    Private m_ChildFormNumber As Integer
    Private Sub RelevamientoMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
    End Sub

    Private Sub RelevamientoCACsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelevamientoCACsToolStripMenuItem.Click
        Dim frmCACs As New RelevamientoCAC With {
            .MdiParent = Me
        }
        frmCACs.Show()
    End Sub

    Private Sub RelevamientoEdificiosCorporativosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelevamientoEdificiosCorporativosToolStripMenuItem.Click
        Dim frmEdificios As New RelevamientoEdificios With {
            .MdiParent = Me
        }
        frmEdificios.Show()
    End Sub

    Private Sub ConsolaDHCPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsolaDHCPToolStripMenuItem.Click
        Process.Start("mmc", "dhcpmgmt.msc")
    End Sub

    Private Sub ConsolaADToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsolaADToolStripMenuItem.Click
        Process.Start("mmc", "dsa.msc")
    End Sub

    Private Sub ConsultaGarantíaDellToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaGarantíaDellToolStripMenuItem.Click
        Dim frmDell As New DellWarranty With {
            .MdiParent = Me
        }
        frmDell.Show()
    End Sub

    Private Sub ConsultaCIAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaCIAToolStripMenuItem.Click
        Dim frmCIA As New CIA_query With {
            .MdiParent = Me
        }
        frmCIA.Show()
    End Sub
End Class