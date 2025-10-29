namespace Menu_Interativo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Inserir_Aluno = new Button();
            Listar_Alunos = new Button();
            listar_Alunos_list = new ListBox();
            Buscar_Aluno = new Button();
            Buscar_Aluno_Texte = new TextBox();
            Excluir_Aluno = new Button();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            label1 = new Label();
            Idade = new Label();
            Alterar_Idade = new Button();
            SuspendLayout();
            // 
            // Inserir_Aluno
            // 
            Inserir_Aluno.Location = new Point(12, 112);
            Inserir_Aluno.Name = "Inserir_Aluno";
            Inserir_Aluno.Size = new Size(75, 23);
            Inserir_Aluno.TabIndex = 0;
            Inserir_Aluno.Text = "Inserir";
            Inserir_Aluno.UseVisualStyleBackColor = true;
            Inserir_Aluno.Click += Inserir_Aluno_Click;
            // 
            // Listar_Alunos
            // 
            Listar_Alunos.Location = new Point(12, 283);
            Listar_Alunos.Name = "Listar_Alunos";
            Listar_Alunos.Size = new Size(75, 23);
            Listar_Alunos.TabIndex = 1;
            Listar_Alunos.Text = "Listar";
            Listar_Alunos.UseVisualStyleBackColor = true;
            Listar_Alunos.Click += Listar_Alunos_Click;
            // 
            // listar_Alunos_list
            // 
            listar_Alunos_list.FormattingEnabled = true;
            listar_Alunos_list.ItemHeight = 15;
            listar_Alunos_list.Location = new Point(360, 26);
            listar_Alunos_list.Name = "listar_Alunos_list";
            listar_Alunos_list.Size = new Size(369, 409);
            listar_Alunos_list.TabIndex = 3;
            listar_Alunos_list.SelectedIndexChanged += listar_Alunos_list_SelectedIndexChanged;
            // 
            // Buscar_Aluno
            // 
            Buscar_Aluno.Location = new Point(12, 209);
            Buscar_Aluno.Name = "Buscar_Aluno";
            Buscar_Aluno.Size = new Size(75, 23);
            Buscar_Aluno.TabIndex = 4;
            Buscar_Aluno.Text = "Buscar";
            Buscar_Aluno.UseVisualStyleBackColor = true;
            Buscar_Aluno.Click += Buscar_Aluno_Click;
            // 
            // Buscar_Aluno_Texte
            // 
            Buscar_Aluno_Texte.Location = new Point(12, 170);
            Buscar_Aluno_Texte.Name = "Buscar_Aluno_Texte";
            Buscar_Aluno_Texte.Size = new Size(165, 23);
            Buscar_Aluno_Texte.TabIndex = 5;
            Buscar_Aluno_Texte.TextChanged += Buscar_Aluno_Texte_TextChanged;
            // 
            // Excluir_Aluno
            // 
            Excluir_Aluno.Location = new Point(12, 352);
            Excluir_Aluno.Name = "Excluir_Aluno";
            Excluir_Aluno.Size = new Size(75, 23);
            Excluir_Aluno.TabIndex = 6;
            Excluir_Aluno.Text = "Excluir";
            Excluir_Aluno.UseVisualStyleBackColor = true;
            Excluir_Aluno.Click += Excluir_Aluno_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 66);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 7;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(139, 66);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(100, 23);
            txtIdade.TabIndex = 8;
            txtIdade.TextChanged += txtIdade_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 9;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // Idade
            // 
            Idade.AutoSize = true;
            Idade.Location = new Point(139, 48);
            Idade.Name = "Idade";
            Idade.Size = new Size(36, 15);
            Idade.TabIndex = 10;
            Idade.Text = "Idade";
            // 
            // Alterar_Idade
            // 
            Alterar_Idade.Location = new Point(139, 112);
            Alterar_Idade.Name = "Alterar_Idade";
            Alterar_Idade.Size = new Size(75, 23);
            Alterar_Idade.TabIndex = 11;
            Alterar_Idade.Text = "Alterar";
            Alterar_Idade.UseVisualStyleBackColor = true;
            Alterar_Idade.Click += Alterar_Idade_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Alterar_Idade);
            Controls.Add(Idade);
            Controls.Add(label1);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(Excluir_Aluno);
            Controls.Add(Buscar_Aluno_Texte);
            Controls.Add(Buscar_Aluno);
            Controls.Add(listar_Alunos_list);
            Controls.Add(Listar_Alunos);
            Controls.Add(Inserir_Aluno);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Inserir_Aluno;
        private Button Listar_Alunos;
        private ListBox listar_Alunos_list;
        private Button Buscar_Aluno;
        private TextBox Buscar_Aluno_Texte;
        private Button Excluir_Aluno;
        private TextBox txtNome;
        private TextBox txtIdade;
        private Label label1;
        private Label Idade;
        private Button Alterar_Idade;
    }
}
