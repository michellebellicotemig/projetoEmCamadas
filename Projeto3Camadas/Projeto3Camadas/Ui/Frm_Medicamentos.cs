using System;
using System.Windows.Forms;

//Importação da camada de negócio
using Projeto3Camadas.Code.BLL; 
using Projeto3Camadas.Code.DTO; //nomeProjeto.nomeDaPasta.nomeDaPasta

namespace Projeto3Camadas.Ui
{
    public partial class Frm_Medicamentos : Form
    {

        //Criação dos objetos que acessam a camada de negócio
        MedicamentoBLL medbll = new MedicamentoBLL();
        MedicamentoDTO meddto = new MedicamentoDTO();

        public Frm_Medicamentos()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto
            meddto.Medicamento = txtMedicamento.Text;
            meddto.Composicao = txtComposicao.Text;

            //Envio do dto preenchido para o método inserir
            medbll.Inserir(meddto);

            //Mensagem de sucesso
            MessageBox.Show("Cadastrado com sucesso!", "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Limpeza dos componentes
            txtId.Clear();
            txtMedicamento.Clear();
            txtComposicao.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            //Preenchimento do objeto
            meddto.Id = int.Parse(txtId.Text);
            meddto.Medicamento = txtMedicamento.Text;
            meddto.Composicao = txtComposicao.Text;

            //Envio do dto preenchido para o método editar
            medbll.Editar(meddto);

            //Mensagem de sucesso
            MessageBox.Show("Alterado com sucesso!", "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Atualização do GridView
            medbll.Listar();

            //Limpeza dos componentes
            txtId.Clear();
            txtMedicamento.Clear();
            txtComposicao.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        { 
            //Preenchimento do objeto
            meddto.Id = int.Parse(txtId.Text);
         
            //Envio do dto preenchido para o método editar
            medbll.Excluir(meddto);

            //Mensagem de sucesso
            MessageBox.Show("Excluido com sucesso!", "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Atualização do GridView
            medbll.Listar();

            //Limpeza dos componentes
            txtId.Clear();
            txtMedicamento.Clear();
            txtComposicao.Clear();
        }

        private void Frm_Medicamentos_Load(object sender, EventArgs e)
        {
            dgvMedicamentos.DataSource = medbll.Listar();
        }

        private void dgvMedicamentos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //Quando o usuário clicar em um registro da lista, os dados serão preenchidos
            txtId.Text = dgvMedicamentos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMedicamento.Text = dgvMedicamentos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtComposicao.Text = dgvMedicamentos.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
