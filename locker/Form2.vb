Imports System.Security.AccessControl
Imports System.IO

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtSearchitem_TextChanged(sender As Object, e As EventArgs) Handles txtSearchitem.TextChanged

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        With FolderBrowserDialog1


            If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                txtSearchitem.Text = .SelectedPath

            End If

        End With

    End Sub

    Private Sub btnLock_Click(sender As Object, e As EventArgs) Handles btnLock.Click
        If txtSearchitem.Text <> "" Then

            Dim FS As FileSystemSecurity = File.GetAccessControl(txtSearchitem.Text)
            FS.AddAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
            File.SetAccessControl(txtSearchitem.Text, FS)

            MsgBox("Folder is locked", vbInformation, "Lock")




        Else


            MsgBox("Please browse the folder to lock.", vbInformation, "Lock")

        End If
    End Sub

    Private Sub btnUnlock_Click(sender As Object, e As EventArgs) Handles btnUnlock.Click
        If txtSearchitem.Text <> "" Then

            Dim FS As FileSystemSecurity = File.GetAccessControl(txtSearchitem.Text)
            FS.RemoveAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
            File.SetAccessControl(txtSearchitem.Text, FS)

            MsgBox("Folder is unlocked", vbInformation, "Unlock")

            txtSearchitem.Text = ""


        Else

            MsgBox("Please browse the folder to unlock.", vbInformation, "Unlock")

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim choice As Integer

        choice = MsgBox("Are you sure you want to Logout ?", vbYesNo, "Logout")

        If choice = vbYes Then

            End

        End If

    End Sub

    Private Sub FolderBrowserDialog1_HelpRequest(sender As Object, e As EventArgs) Handles FolderBrowserDialog1.HelpRequest

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form As New Form
        My.Forms.Form2.Hide()
        My.Forms.Form3.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form As New Form
        My.Forms.Form2.Hide()
        My.Forms.AboutBox1.Show()
    End Sub
End Class