using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Atividade01_Aula_João
{
    public partial class CadastroEmpresa : Form
    {
        public CadastroEmpresa()
        {
            InitializeComponent();
        }

        private void CadastroEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox13.Text) || String.IsNullOrEmpty(textBox2.Text) ||
                String.IsNullOrEmpty(maskedTextBox1.Text) || String.IsNullOrEmpty(comboBox1.Text) || String.IsNullOrEmpty(maskedTextBox4.Text) ||
                String.IsNullOrEmpty(maskedTextBox3.Text) || String.IsNullOrEmpty(textBox8.Text) || String.IsNullOrEmpty(textBox9.Text) ||
                String.IsNullOrEmpty(comboBox3.Text) || String.IsNullOrEmpty(comboBox2.Text) || String.IsNullOrEmpty(groupBox1.Text) ||
                String.IsNullOrEmpty(groupBox2.Text) || String.IsNullOrEmpty(maskedTextBox2.Text) || String.IsNullOrEmpty(groupBox3.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Empresa novoFuncionario = new Empresa();
                {
                    novoFuncionario.nomeFantasia = textBox1.Text;
                    novoFuncionario.nomeProprietario = textBox13.Text;
                    novoFuncionario.razaoSocial = textBox2.Text;
                    novoFuncionario.cnpj = maskedTextBox1.Text;
                    novoFuncionario.situacaoCadastral = comboBox1.Text;
                    novoFuncionario.cpfProprietario = maskedTextBox4.Text;
                    novoFuncionario.telefone = maskedTextBox3.Text;
                    novoFuncionario.capitalSocial = textBox8.Text;
                    novoFuncionario.endereco = textBox9.Text;
                    novoFuncionario.estado = comboBox3.Text;
                    novoFuncionario.naturezaJuridica = comboBox2.Text;
                    novoFuncionario.regimeTributario = groupBox1.Text;
                    novoFuncionario.tipo = groupBox2.Text;
                    novoFuncionario.data = maskedTextBox2.Text;
                    novoFuncionario.porteEmpresa = groupBox3.Text;

                };

                MessageBox.Show("Funcionário cadastrado com sucesso!", "Cadastro efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string texto = @"C:\Users\gabri\Documents\TrabalhoEmpresa\trabalho.txt";
                using (StreamWriter sw = new StreamWriter(texto))
                {
                    sw.WriteLine($"CNPJ = {novoFuncionario.cpfProprietario}\n" + $"Razão Social:{novoFuncionario.razaoSocial}\n" + $"Nome Fatasia:{novoFuncionario.nomeFantasia}\n" + $"Situação cadastral:{novoFuncionario.situacaoCadastral}\n" +
                $"Regime Tributário:{novoFuncionario.regimeTributario}\n" + $"Data de iníco:{novoFuncionario.data}\n" + $"Telefone:{novoFuncionario.telefone}\n" + $"Capital social:{novoFuncionario.capitalSocial}\n" +
                 $"Endereço:{novoFuncionario.endereco}\n" + $"Tipo:{novoFuncionario.tipo}\n" + $"Porte da Empresa:{novoFuncionario.porteEmpresa}\n" + $"Natureza juridica:{novoFuncionario.naturezaJuridica}\n"
                 + $"Nome propreteratio:{novoFuncionario.nomeProprietario}\n" + $"Cpf do propretério:{novoFuncionario.cpfProprietario}\n");
                }



            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
