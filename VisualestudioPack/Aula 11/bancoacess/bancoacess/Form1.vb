Public Class Form1

    Private Sub UsuarioBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuarioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bd1DataSet)
        'Valida os Campos

       
        Me.Bd1DataSet.AcceptChanges()
        'Me.TableAdapterManager.UpdateAll(Me.Bd1DataSet) *** Descarta do Padrão
        'Atualiza os Campos
        Me.UsuarioTableAdapter.Update_Usuario(NomeTextBox.Text, SexoTextBox.Text,
        CInt(CodigoTextBox.Text))
        'Recarrega Grid
        Me.UsuarioTableAdapter.Fill(Me.Bd1DataSet.usuario)
    End Sub
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Adiciona uma nova linha nos campos para Inclusão dos Dados
        Me.UsuarioBindingSource.AddNew()
        'Desabilita o Botão Alterar
        Button2.Enabled = False
        'Desabilita o Botão Excluir
        Button3.Enabled = False
        'Habilita o Botão Salvar
        Button4.Enabled = True
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'Valida os Campos
        Me.Validate()
        'Finaliza Edição
        Me.UsuarioBindingSource.EndEdit()
        ' Força Aceitação
        Me.Bd1DataSet.AcceptChanges()
        'Me.TableAdapterManager.UpdateAll(Me.Bd1DataSet) *** Descarta do Padrão
        'Atualiza os Campos
        Me.UsuarioTableAdapter.Update_Usuario(NomeTextBox.Text, SexoTextBox.Text,
        CInt(CodigoTextBox.Text))
        'Recarrega Grid
        Me.UsuarioTableAdapter.Fill(Me.Bd1DataSet.usuario)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        'Exclui os Campos
        Me.UsuarioTableAdapter.Delete_Usuario(CodigoTextBox.Text)
        ' Força Aceitação
        Me.Bd1DataSet.AcceptChanges()
        'Recarrega Grid
        Me.UsuarioTableAdapter.Fill(Me.Bd1DataSet.usuario)
        'Habilita o Botão Alterar
        Button2.Enabled = True
        'Habilita o Botão Excluir
        Button3.Enabled = True
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        'Valida os Campos
        Me.Validate()
        'Finaliza Edição
        Me.UsuarioBindingSource.EndEdit()
        ' Força Aceitação
        Me.Bd1DataSet.AcceptChanges()
        'Insere os Campos
        Me.UsuarioTableAdapter.Insert_Usuario(NomeTextBox.Text, SexoTextBox.Text)
        'Recarrega Grid
        Me.UsuarioTableAdapter.Fill(Me.Bd1DataSet.usuario)
        'Habilita o Botão Alterar
        Button2.Enabled = True
        'Habilita o Botão Excluir
        Button3.Enabled = True
        'Desabilita o Botão Salvar
        Button4.Enabled = False
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        'Cacela a Edição
        Me.UsuarioBindingSource.CancelEdit()
        'Recarrega Grid
        Me.UsuarioTableAdapter.Fill(Me.Bd1DataSet.usuario)
        'Habilita o Botão Alterar
        Button2.Enabled = True
        'Habilita o Botão Excluir
        Button3.Enabled = True
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Carrega os Dados na tabela:'Bd1DataSet.Usuario'
        Me.UsuarioTableAdapter.Fill(Me.Bd1DataSet.usuario)
        'Desabilita o Botão Salvar
        Button4.Enabled = False
    End Sub
End Class
   