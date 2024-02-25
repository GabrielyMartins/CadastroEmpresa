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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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
                String.IsNullOrEmpty(comboBox3.Text) || String.IsNullOrEmpty(comboBox2.Text) || String.IsNullOrEmpty(maskedTextBox2.Text) || 
                String.IsNullOrEmpty(groupBoxOpcoes.Text) || String.IsNullOrEmpty(groupBoxOpcoes2.Text) || String.IsNullOrEmpty(groupBoxOpcoes3.Text))
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
                    novoFuncionario.data = maskedTextBox2.Text;
                    novoFuncionario.situacaoCadastral = comboBox1.Text;
                    novoFuncionario.cpfProprietario = maskedTextBox4.Text;
                    novoFuncionario.telefone = maskedTextBox3.Text;
                    novoFuncionario.capitalSocial = textBox8.Text;
                    novoFuncionario.endereco = textBox9.Text;
                    novoFuncionario.estado = comboBox3.Text;
                    novoFuncionario.naturezaJuridica = comboBox2.Text;
                    novoFuncionario.regimeTributario = groupBoxOpcoes.Text;
                    novoFuncionario.tipo = groupBoxOpcoes2.Text;
                    novoFuncionario.porteEmpresa = groupBoxOpcoes3.Text;

                };

                string opcaoSelecionada = ObterOpcaoSelecionada();
                string opSelecionada = ObterOpSelecionada();
                string opcSelecionada = ObterOpcSelecionada();

                MessageBox.Show("Funcionário cadastrado com sucesso!", "Cadastro efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);


                MessageBox.Show($"Nome Fatasia: {novoFuncionario.nomeFantasia}\n" + 
                    $"Nome propreteratio: {novoFuncionario.nomeProprietario}\n" + 
                    $"CNPJ: {novoFuncionario.cpfProprietario}\n" + 
                    $"Cpf do propretério: {novoFuncionario.cpfProprietario}\n" + 
                    $"Razão Social: {novoFuncionario.razaoSocial}\n" + 
                    $"Situação cadastral: {novoFuncionario.situacaoCadastral}\n" + 
                    $"Endereço: {novoFuncionario.endereco}\n" + 
                    $"Data de iníco: {novoFuncionario.data}\n" + 
                    $"Telefone: {novoFuncionario.telefone}\n" + 
                    $"Capital social: {novoFuncionario.capitalSocial}\n" + 
                    $"Tipo: {opSelecionada}\n" + 
                    $"Porte da Empresa: {opcSelecionada}\n" + 
                    $"Natureza juridica: {novoFuncionario.naturezaJuridica}\n" + 
                    $"Regime Tributário: {opcaoSelecionada}", 
                    $"Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private string ObterOpcaoSelecionada()
        {
            foreach (System.Windows.Forms.RadioButton radioButton in groupBoxOpcoes.Controls)
            {
                if (radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }

            return "";
        }

        private string ObterOpSelecionada()
        {
            foreach (System.Windows.Forms.RadioButton radioButton in groupBoxOpcoes2.Controls)
            {
                if (radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }

            return "";
        }

        private string ObterOpcSelecionada()
        {
            foreach (System.Windows.Forms.RadioButton radioButton in groupBoxOpcoes3.Controls)
            {
                if (radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }

            return "";
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
