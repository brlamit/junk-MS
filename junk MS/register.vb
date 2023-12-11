Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class register
    Private register_picturebox As Object

    Private Sub GunaLabel2_Click(sender As Object, e As EventArgs) Handles GunaLabel2.Click

    End Sub

    Private Sub GunaLabel3_Click(sender As Object, e As EventArgs) Handles GunaLabel3.Click

    End Sub

    Private Sub Btn_back_Click(sender As Object, e As EventArgs) Handles Btn_back.Click
        Me.Dispose()
    End Sub

    Private Sub checkbox_showpassword_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_showpassword.CheckedChanged
        If checkbox_showpassword.Checked = True Then
            txt_password.UseSystemPasswordChar = False
        Else
            txt_password.UseSystemPasswordChar = True
        End If
    End Sub


    Private Sub Btn_browse_Click(sender As Object, e As EventArgs) Handles Btn_browse.Click
        Dim pop As OpenFileDialog = New OpenFileDialog
        If pop.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            register_picturebox.image = Image.FromFile(pop.FileName)
        End If
    End Sub
    Dim connection As New SqlConnection("Server=AMIT\SQLEXPRESS; Database=Project_JMS; Integrated Security=true")
    Private Sub Btn_register_Click(sender As Object, e As EventArgs) Handles Btn_register.Click
        If txt_name.Text <> "" AndAlso txt_address.Text <> "" AndAlso
     txt_username.Text <> "" AndAlso dob_picker.Text <> "" AndAlso
     txt_contact.Text <> "" AndAlso txt_password.Text <> "" Then

            ' Check if passwords match
            If txt_password.Text = txt_password.Text Then
                Try
                    connection.Open()

                    ' Check if the username already exists
                    Dim checkQuery As String = "SELECT COUNT(*) FROM register WHERE Username = @Username"
                    Using checkCommand As New SqlCommand(checkQuery, connection)
                        checkCommand.Parameters.AddWithValue("@Username", txt_username.Text)
                        Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                        If count > 0 Then
                            MessageBox.Show("Username already taken. Please choose a different username.")
                            Return ' Exit the method if the username is not unique
                        End If
                    End Using

                    ' Insert data into the database
                    Dim insertQuery As String = "INSERT INTO register (name, address, username,dob,contact, password) VALUES (@name, @address, 
                        @username,@dob,@contact, @password)"
                    Using command As New SqlCommand(insertQuery, connection)
                        command.Parameters.AddWithValue("@name", txt_name.Text)
                        command.Parameters.AddWithValue("@address", txt_address.Text)
                        command.Parameters.AddWithValue("@Username", txt_username.Text)
                        command.Parameters.AddWithValue("@dob", CDate(dob_picker.Value))
                        command.Parameters.AddWithValue("@contact", txt_contact.Text)
                        command.Parameters.AddWithValue("@password", txt_password.Text)
                        command.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Registration successful.")
                    txt_name.Clear()
                    txt_address.Clear()
                    txt_username.Clear()
                    txt_contact.Clear()
                    txt_password.Clear()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            Else
                MessageBox.Show("Passwords do not match.")
            End If
        Else
            MessageBox.Show("Please fill in all required fields.")
        End If
    End Sub
End Class