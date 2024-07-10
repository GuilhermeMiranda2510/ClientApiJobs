using System.Configuration;
using System.Net.Http.Headers;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using ClientApiJobs.Forms.Menu;
using Microsoft.VisualBasic.ApplicationServices;
using ClientApiJobs.Models.TokenConfiguration;
using System.Runtime.Intrinsics.X86;
using ClientApiJobs.Business;

namespace ClientApiJobs.Forms.Login
{
    public partial class Frm_Login : Form
    {
      
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //txtEmail.Text = "guilherme@teste.com.br";
            //txtSenha.Text = "Escola2018##@@";
        }

        private string URI = "";
        private static string _urlBase;
        private static TokenModel Access;
        Auxiliar aux = new Auxiliar();

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                toolTip1.ToolTipTitle = "Atenção:";
                toolTip1.SetToolTip(txtEmail, "Preencha");
                toolTip1.Show("Preencha este campo", txtEmail, 5000);
                txtEmail.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                toolTip1.ToolTipTitle = "Atenção:";
                toolTip1.SetToolTip(txtSenha, "Preencha");
                toolTip1.Show("Preencha este campo", txtSenha, 5000);
                txtSenha.Focus();
                return;
            }

            _urlBase = ConfigurationManager.AppSettings["UrlBase"];
            var email = txtEmail.Text.ToString();
            var password = txtSenha.Text.ToString();
            var confirmPassword = password;
            var urlbase = _urlBase + "entrar";

            using (var client = new HttpClient())
            {
                string conteudo = "";

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                // Envio da requisição a fim de autenticar
                // e obter o token de acesso
                try
                {
                    HttpResponseMessage respToken =
                        client.PostAsync(urlbase, new StringContent(
                            JsonConvert.SerializeObject(new
                            {
                                email,
                                password,
                                confirmPassword
                            }), Encoding.UTF8, "application/json")).Result;

                    conteudo = respToken.Content.ReadAsStringAsync().Result;

                    if (respToken.StatusCode == HttpStatusCode.OK)
                    {
                        Access = JsonConvert.DeserializeObject<TokenModel>(conteudo);

                        if (Access.success)
                        {
                            // Associar o token aos headers do objeto
                            // do tipo HttpClient
                            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
                            Access.data.AccessToken);

                            this.Hide();
                            Form f = new Frm_MenuPrincipal(Access);
                            f.Closed += (s, args) => this.Close();
                            f.Show();
                        }
                        else
                        {
                            MessageBox.Show("Falha na autenticação");
                            aux.WriteLog(txtEmail.Text, "LOGIN", "GERAR TOKEN", "Falha na autenticação");
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro " + ex.Message);
                    aux.WriteLog(txtEmail.Text, "LOGIN", "LOGIN", ex.Message.ToString());
                }
            }
        }
    }
}
