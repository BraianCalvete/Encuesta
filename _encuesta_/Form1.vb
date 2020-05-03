Imports MySql.Data.MySqlClient

'Braian Calvete 3BF
Public Class Form1

    Private Sub BEnviar_Click(sender As Object, e As EventArgs) Handles BEnviar.Click

        Dim conexion As MySqlConnection
        conexion = New MySqlConnection

        Dim cmd As New MySqlCommand
        Dim ds As DataSet = New DataSet
        Dim adapter As MySqlDataAdapter = New MySqlDataAdapter

        conexion.ConnectionString = "server=localhost; database=encuesta;Uid=root;Pwd=;"


        Try
            conexion.Open()
            cmd.Connection = conexion

            cmd.CommandText = "INSERT INTO encuesta_series(nombre, apellido, Serie_favorita) VALUES (@nombre, @apellido, @serie_favorita)"
            cmd.Prepare()

            cmd.Parameters.AddWithValue("@nombre", Nombre.Text)
            cmd.Parameters.AddWithValue("@apellido", Apellido.Text)
            cmd.Parameters.AddWithValue("@serie_favorita", Serie_favorita.Text)
            cmd.ExecuteNonQuery()

            MsgBox("Felicitaciones tu encuesta ha sido guardada")

            cmd.CommandText = "SELECT * FROM encuesta_series ORDER BY nombre ASC"
            adapter.SelectCommand = cmd
            adapter.Fill(ds, "Tabla")
            TEncuesta.DataSource = ds
            TEncuesta.DataMember = "Tabla"

            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BBorrar_Click(sender As Object, e As EventArgs) Handles BBorrar.Click
        Nombre.Clear()
        Apellido.Clear()
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Me.Close()
    End Sub
End Class
