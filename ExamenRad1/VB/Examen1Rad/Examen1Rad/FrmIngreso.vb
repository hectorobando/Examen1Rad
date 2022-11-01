Imports System.Data.SqlClient
Public Class FrmIngreso
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        txtusuario.Clear()
        txtcontra.Clear()
        txtusuario.Focus()
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim con As New SqlClient.SqlConnection(My.Settings.ExamenRad)
        con.Open()
        Dim reader As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("select * from Usuarios where idusuario = '" & txtusuario.Text & "' and contrasena =  '" & txtcontra.Text & "' ", con)
        reader = cmd.ExecuteReader

        If reader.Read() Then
            If reader.Item("activo") = True Then
                DatosUsuario.idusuario = reader.Item("idusuario")
                DatosUsuario.contrasena = reader.Item("contrasena")
                DatosUsuario.nombrecompleto = reader.Item("NombreCompleto")
                DatosUsuario.nivelacceso = reader.Item("nivelacceso")
                DatosUsuario.fecharegistro = reader.Item("fecharegistro")
                DatosUsuario.activo = reader.Item("activo")

                Me.Dispose()
                FrmSucursales.ShowDialog()
            Else
                MessageBox.Show("Usuario inactivo")
            End If
        Else
            MessageBox.Show("Usuario o contraseña incorrectos")
        End If
    End Sub
End Class
