Imports System.IO

Public Class Form1
    Private Sub btnCriarPasta_Click(sender As Object, e As EventArgs) Handles btnCriarPasta.Click

        Dim nomePasta As String = txtNomePasta.Text
        Dim caminhoDownloadUser = $"C:\Users\{Environment.UserName}\Downloads"
        Dim caminhoCriacaoPasta = caminhoDownloadUser + "\" + nomePasta

        AjustaCaminhoPasta(caminhoCriacaoPasta, caminhoDownloadUser, nomePasta)
        CriarDirEmDownloads(caminhoCriacaoPasta)
        MsgBox($"Pasta criada em {caminhoDownloadUser}")

    End Sub

    Private Sub CriarDirEmDownloads(caminhoCriacaoPasta As String)
        Directory.CreateDirectory(caminhoCriacaoPasta)
    End Sub

    Private Sub AjustaCaminhoPasta(ByRef caminhoCriacaoPasta, ByRef caminhoDownloadUser, ByRef nomePasta)

        Dim i As Integer = 1
        While True

            If Directory.Exists(caminhoCriacaoPasta) Then
                caminhoCriacaoPasta = $"{caminhoDownloadUser}\{nomePasta}({i})"
            Else
                Exit While
            End If

            i += 1

        End While

    End Sub


End Class
