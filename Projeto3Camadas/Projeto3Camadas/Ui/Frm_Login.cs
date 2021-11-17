using System;
using System.Windows.Forms;

//Importação da camada de negócio
using Projeto3Camadas.Code.BLL; //nomeProjeto.nomeDaPasta.nomeDaPasta
using Projeto3Camadas.Code.DTO; //nomeProjeto.nomeDaPasta.nomeDaPasta

namespace Projeto3Camadas.Ui
{
    public partial class Frm_Login : Form
    {


        //Criação dos objetos que acessam a camada de negócio
        LoginBLL loginBBL = new LoginBLL();
        LoginDTO loginDTO = new LoginDTO();

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Capturar dados da tela
            loginDTO.Email = txtEmail.Text;
            loginDTO.Senha = txtSenha.Text;


            //Chamada do método para verificar o acesso: 
            if (loginBBL.RealizarLogin(loginDTO) == true)
            {

                Frm_Medicamentos frm_Medicamentos = new Frm_Medicamentos();
                frm_Medicamentos.ShowDialog();
            }
            else
            {
                //Mensagem de sucesso
                MessageBox.Show("Verifique e-mail e senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
