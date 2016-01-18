using System;
using System.IO;
using System.Windows.Forms;

namespace ManipulandoArquivosTexto
{
    partial class Form1
    {
        private string strPathFile = @"C:\Users\MDS\Documents\Visual Studio 2015\Projects\EST2\ManipulandoArquivosTexto\ArquivosArmazenados\teste.txt";
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnConcatenar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(74, 35);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(114, 23);
            this.btnCriar.TabIndex = 0;
            this.btnCriar.Text = "Criar Arquivo";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(74, 64);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(114, 23);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Abrir Arquivo";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnConcatenar
            // 
            this.btnConcatenar.Location = new System.Drawing.Point(74, 93);
            this.btnConcatenar.Name = "btnConcatenar";
            this.btnConcatenar.Size = new System.Drawing.Size(114, 23);
            this.btnConcatenar.TabIndex = 2;
            this.btnConcatenar.Text = "Concatenar Arquivo";
            this.btnConcatenar.UseVisualStyleBackColor = true;
            this.btnConcatenar.Click += new System.EventHandler(this.btnConcatenar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(74, 121);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(114, 23);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar Arquivo";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(74, 150);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(114, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir Arquivo";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnConcatenar);
            this.Controls.Add(this.btnCriar);
            this.Name = "Form1";
            this.Text = "TesteArquivo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnConcatenar;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;

        private void Criar()

        {
            try
            {
                //Usarei a cláusula using como boas práticas de programação em todos os métodos

                //Instancio a classe FileStream, uso a classe File e o método Create para criar o

                //arquivo passando como parâmetro a variável strPathFile, que contém o arquivo

                using (FileStream fs = File.Create(strPathFile))
                {
                    //Crio outro using, dentro dele instancio o StreamWriter (classe para gravar os dados)

                    //que recebe como parâmetro a variável fs, referente ao FileStream criado anteriormente

                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        //Uso o método Write para escrever algo em nosso arquivo texto

                        sw.Write("Texto adicionado ao exemplo!");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            //Se tudo ocorrer bem, exibo a mensagem ao usuário.

            MessageBox.Show("Arquivo criado com sucesso!!!");
        }

        private void Abrir()

        {
            try
            {
                //Verifico se o arquivo que desejo abrir existe e passo como parâmetro a respectiva variável

                if (File.Exists(strPathFile))
                {
                    //Se existir "starto" um processo do sistema para abrir o arquivo e, sem precisar

                    //passar ao processo o aplicativo a ser aberto, ele abre automaticamente o Notepad

                    System.Diagnostics.Process.Start(strPathFile);
                }
                else
                {
                    //Se não existir exibo a mensagem
                    MessageBox.Show("Arquivo não encontrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Concatenar()
        {
            try
            {
                //Verifico se o arquivo que desejo abrir existe e passo como parâmetro a respectiva variável

                if (File.Exists(strPathFile))
                {
                    //Crio um using, dentro dele instancio o StreamWriter, uso a classe File e o método

                    //AppendText para concatenar o texto, passando como parâmetro a variável strPathFile

                    using (StreamWriter sw = File.AppendText(strPathFile))
                    {
                        //Uso o método Write para escrever o arquivo que será adicionado no arquivo texto

                        sw.Write("\r\nTexto adicionado ao final do arquivo");
                    }
                    //Exibo a mensagem que o arquivo foi atualizado

                    MessageBox.Show("Arquivo atualizado!");
                }
                else
                {
                    //Se não existir exibo a mensagem

                    MessageBox.Show("Arquivo não encontrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Alterar()
        {
            try
            {
                //Verifico se o arquivo que desejo abrir existe e passo como parâmetro a variável respectiva

                if (File.Exists(strPathFile))
                {
                    //Instancio o FileStream passando como parâmetro a variável padrão, o FileMode que será

                    //o modo Open e o FileAccess, que será Read(somente leitura). Este método é diferente dos

                    //demais: primeiro irei abrir o arquivo, depois criar um FileStream temporário que irá

                    //armazenar os novos dados e depois criarei outro FileStream para fazer a junção dos dois

                    using (FileStream fs = new FileStream(strPathFile, FileMode.Open, FileAccess.Read))
                    {
                        //Aqui instancio o StreamReader passando como parâmetro o FileStream criado acima.

                        //Uso o StreamReader já que faço 1º a leitura do arquivo. Irei percorrer o arquivo e

                        //quando encontrar uma string qualquer farei a alteração por outra string qualquer

                        using (StreamReader sr = new StreamReader(fs))
                        {
                            //Crio o FileStream temporário onde irei gravar as informações

                            using (FileStream fsTmp = new FileStream(strPathFile + ".tmp",
                                                       FileMode.Create, FileAccess.Write))
                            {
                                //Instancio o StreamWriter para escrever os dados no arquivo temporário,

                                //passando como parâmetro a variável fsTmp, referente ao FileStream criado

                                using (StreamWriter sw = new StreamWriter(fsTmp))
                                {
                                    //Crio uma variável e a atribuo como nula. Faço um while que percorrerá

                                    //meu arquivo original e enquanto ele estiver diferente de nulo...

                                    string strLinha = null;

                                    while ((strLinha = sr.ReadLine()) != null)
                                    {
                                        //faço um indexof para verificar se existe a palavra adicionado,

                                        //se ela existir, a substituo pela palavra alterado

                                        if (strLinha.IndexOf("adicionado") > -1)
                                        {
                                            //uso o método Replace que espera o valor antigo e valor novo

                                            strLinha = strLinha.Replace("adicionado", "alterado");
                                        }
                                        //Chamo o método Write do StreamWriter passando o strLinha como parâmetro

                                        sw.Write(strLinha);
                                    }
                                }
                            }
                        }
                    }
                    //Ao final excluo o arquivo anterior e movo o temporário no lugar do original

                    //Dessa forma não perco os dados de modificação de meu arquivo

                    File.Delete(strPathFile);
                    
                    //No método Move passo o arquivo de origem, o temporário, e o de destino, o original

                    File.Move(strPathFile + ".tmp", strPathFile);
                    
                    //Exibo a mensagem ao usuário

                    MessageBox.Show("Arquivo alterado com sucesso!");
                }
                else
                {
                    //Se não existir exibo a mensagem

                    MessageBox.Show("Arquivo não encontrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Excluir()
        {
            try
            {
                //Verifico se o arquivo que desejo abrir existe e passo como parâmetro a variável respectiva
                if (File.Exists(strPathFile))
                {
                    //Se existir chamo o método Delete da classe File para apagá-lo e exibo uma msg ao usuário

                    File.Delete(strPathFile);

                    MessageBox.Show("Arquivo excluído com sucesso!");
                }
                else
                {
                    //Se não existir exibo a mensagem

                    MessageBox.Show("Arquivo não encontrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

