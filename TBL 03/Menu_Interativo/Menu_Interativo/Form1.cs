using System;
using System.Windows.Forms;
using Npgsql;

namespace Menu_Interativo
{
    public partial class Form1 : Form
    {
        // 🔹 String de conexão com o PostgreSQL
        private string connectionString =
            "Host=localhost;Port=5432;Username=postgres;Password=PostgreSQL123;Database=Menu_Interativo_BD";

        public Form1()
        {
            InitializeComponent();
        }

        // ========================================================
        // BOTÃO: INSERIR ALUNO
        // ========================================================
        private void Inserir_Aluno_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string idadeTexto = txtIdade.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(idadeTexto))
            {
                MessageBox.Show("Preencha o nome e a idade do aluno!");
                return;
            }

            if (!int.TryParse(idadeTexto, out int idade))
            {
                MessageBox.Show("A idade deve ser um número inteiro!");
                return;
            }

            string sql = "INSERT INTO alunos (nome, idade) VALUES (@nome, @idade)";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("nome", nome);
                        cmd.Parameters.AddWithValue("idade", idade);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("✅ Aluno inserido com sucesso!");
                    txtNome.Clear();
                    txtIdade.Clear();
                    ListarAlunos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir aluno: " + ex.Message);
                }
            }
        }

        // ========================================================
        // BOTÃO: LISTAR ALUNOS
        // ========================================================
        private void Listar_Alunos_Click(object sender, EventArgs e)
        {
            ListarAlunos();
        }

        private void ListarAlunos()
        {
            string sql = "SELECT id, nome, idade FROM alunos ORDER BY id";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        listar_Alunos_list.Items.Clear();

                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string nome = reader.GetString(1);
                            int idade = reader.GetInt32(2);

                            listar_Alunos_list.Items.Add($"ID: {id} | Nome: {nome} | Idade: {idade}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao listar alunos: " + ex.Message);
                }
            }
        }

        // ========================================================
        // BOTÃO: BUSCAR ALUNO
        // ========================================================
        private void Buscar_Aluno_Click(object sender, EventArgs e)
        {
            string termo = Buscar_Aluno_Texte.Text.Trim();

            if (string.IsNullOrWhiteSpace(termo))
            {
                MessageBox.Show("Digite um nome para buscar!");
                return;
            }

            string sql = "SELECT id, nome, idade FROM alunos WHERE nome ILIKE @nome";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("nome", "%" + termo + "%");

                        using (var reader = cmd.ExecuteReader())
                        {
                            listar_Alunos_list.Items.Clear();

                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string nome = reader.GetString(1);
                                int idade = reader.GetInt32(2);

                                listar_Alunos_list.Items.Add($"ID: {id} | Nome: {nome} | Idade: {idade}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar aluno: " + ex.Message);
                }
            }
        }

        // ========================================================
        // BOTÃO: EXCLUIR ALUNO
        // ========================================================
        private void Excluir_Aluno_Click(object sender, EventArgs e)
        {
            if (listar_Alunos_list.SelectedItem == null)
            {
                MessageBox.Show("Selecione um aluno na lista para excluir.");
                return;
            }

            string item = listar_Alunos_list.SelectedItem.ToString();
            string idTexto = item.Split('|')[0].Replace("ID:", "").Trim();

            if (!int.TryParse(idTexto, out int id))
            {
                MessageBox.Show("Erro ao identificar o aluno selecionado.");
                return;
            }

            string sql = "DELETE FROM alunos WHERE id = @id";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("id", id);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("🗑️ Aluno excluído com sucesso!");
                    ListarAlunos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir aluno: " + ex.Message);
                }
            }
        }

        // ========================================================
        // CAMPOS DE TEXTO (opcional — podem ficar vazios)
        // ========================================================
        private void Buscar_Aluno_Texte_TextChanged(object sender, EventArgs e) { }
        private void Inserir_Texte_TextChanged(object sender, EventArgs e) { }
        private void listar_Alunos_list_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtNome_TextChanged(object sender, EventArgs e) { }
        private void txtIdade_TextChanged(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Alterar_Idade_Click(object sender, EventArgs e)
        {
            if (listar_Alunos_list.SelectedItem == null)
            {
                MessageBox.Show("Selecione um aluno na lista para alterar a idade.");
                return;
            }
            string item = listar_Alunos_list.SelectedItem.ToString();
            string idTexto = item.Split('|')[0].Replace("ID:", "").Trim();
            if (!int.TryParse(idTexto, out int id))
            {
                MessageBox.Show("Erro ao identificar o aluno selecionado.");
                return;
            }
            string novaIdadeTexto = txtIdade.Text.Trim();
            if (!int.TryParse(novaIdadeTexto, out int novaIdade))
            {
                MessageBox.Show("A nova idade deve ser um número inteiro!");
                return;
            }
            string sql = "UPDATE alunos SET idade = @idade WHERE id = @id";
            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("idade", novaIdade);
                        cmd.Parameters.AddWithValue("id", id);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("✅ Idade do aluno alterada com sucesso!");
                    txtIdade.Clear();
                    ListarAlunos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao alterar idade do aluno: " + ex.Message);
                }
            }

        }
    }
}
