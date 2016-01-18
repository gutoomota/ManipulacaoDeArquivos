using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipulandoArquivosTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnCriar_Click(object sender, EventArgs e)
        {
            Criar();
        }
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }
        private void btnConcatenar_Click(object sender, EventArgs e)
        {
            Concatenar();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }
    }
}
