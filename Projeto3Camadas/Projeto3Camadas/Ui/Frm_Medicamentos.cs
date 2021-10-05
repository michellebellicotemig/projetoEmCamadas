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

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
