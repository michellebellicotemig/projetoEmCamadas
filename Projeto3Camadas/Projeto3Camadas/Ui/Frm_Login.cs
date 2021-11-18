using System;
using System.Windows.Forms;
using System.Net; //Envio de e-mail
using System.Net.Mail; //Envio de e-mail

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

        private void lnkLabEsqueceu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Configura o client Gmail
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("michellebelli@cotemig.com.br", "lwkejdlxawtwpnjc"),
                EnableSsl = true
            };


            loginDTO.Email = txtEmail.Text;
            string senha = loginBBL.RetornarSenha(loginDTO); 


            //TODO: Altere para enviar o e-mail e senha recuperados do banco
            //Send ("quem envia", "para quem envia", "assunto", "corpo");
            client.Send("michellebelli@cotemig.com.br", $"{txtEmail.Text}", "Redefinição de Senha", $"Seu e-mail é {txtEmail.Text} com senha {senha}");
            
            
            MessageBox.Show("E-mail e senha enviados com sucesso.", "E-mail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
