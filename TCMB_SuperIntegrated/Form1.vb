Public Class Form1

    Private Sub cmdTheButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTheButton.Click
        MessageBox.Show("This is THE button !", "The button")
    End Sub

    Private Sub BtnBusiness_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBusiness.Click
        Throw New Exception("This button has not been tested properly")
    End Sub
End Class
