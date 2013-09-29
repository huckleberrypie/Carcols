Public Class Form1
    'This work is licensed under a Creative Commons Attribution-NonCommercial-ShareAlike 3.0 Unported License.
#Region "Declarations"

    Private clRed As Integer
    Private clGreen As Integer
    Private clBlue As Integer

#End Region

    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click
        End 'ends the app, obviously
    End Sub

    Private Sub ScrRed_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles ScrRed.Scroll
        clRed = ScrRed.Value
        PictureBox1.BackColor = Color.FromArgb(ScrRed.Value, ScrGreen.Value, ScrBlue.Value)
        TxtCarcols.Text = clRed & "," & clGreen & "," & clBlue & "    # 0 " & "ColourID HueName"
    End Sub
    Private Sub ScrGreen_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles ScrGreen.Scroll
        clGreen = ScrGreen.Value
        PictureBox1.BackColor = Color.FromArgb(ScrRed.Value, ScrGreen.Value, ScrBlue.Value)
        TxtCarcols.Text = clRed & "," & clGreen & "," & clBlue & "    # 0 " & "ColourID HueName"
    End Sub

    Private Sub ScrBlue_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles ScrBlue.Scroll
        clBlue = ScrBlue.Value
        PictureBox1.BackColor = Color.FromArgb(ScrRed.Value, ScrGreen.Value, ScrBlue.Value)
        TxtCarcols.Text = clRed & "," & clGreen & "," & clBlue & "    # 0 " & "ColourID HueName"
    End Sub

    Private Sub TxtCarcols_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCarcols.TextChanged

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TxtCarcols.Text = clRed & "," & clGreen & "," & clBlue & "    # 0 " & "ColourID HueName"
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        Dim aboutText As String = "Carcols Tool .NET v0.1 by Huckleberry Pie." 'Why can't I just put the damn text rather than do some fucking song-and-dance number?
        Dim caption As String = "About..." 'Lovingly stolen from some MSDN example
        MessageBox.Show(aboutText, caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
