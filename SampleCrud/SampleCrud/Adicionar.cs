using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleCrud
{
    public partial class Adicionar : Form
    {
        public Adicionar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBairro.Clear();
            txtCpf.Clear();
            txtLogradouro.Clear();
            txtNome.Clear();
            txtNumero.Clear();
            txtTelefone.Clear();
            comboUf.ResetText();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Cpf = int.Parse(txtCpf.Text);
            pessoa.Nome = txtNome.Text;
            pessoa.Telefone = txtTelefone.Text;
            pessoa.Logradouro = txtLogradouro.Text;
            pessoa.Numero = txtNumero.Text;
            pessoa.Bairro = txtBairro.Text;
            pessoa.Cidade = txtCidade.Text;
            pessoa.Estado = comboUf.Text;
        }
    }
}
