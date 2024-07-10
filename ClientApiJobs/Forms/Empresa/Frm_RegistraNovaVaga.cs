using ClientApiJobs.Forms.Menu;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientApiJobs.Models.TokenConfiguration;
using ClientApiJobs.Models.Empresa;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Intrinsics.X86;
using ClientApiJobs.Business;

namespace ClientApiJobs.Forms.Empresa
{
    public partial class Frm_RegistraNovaVaga : Form
    {
        TokenModel token = null;
        public Frm_RegistraNovaVaga(TokenModel token)
        {
            this.token = token;
            InitializeComponent();
        }

        private string URI = "";
        private static string _urlBase;
        private static EmpresaVagaModel empresaVaga;

        private void Frm_RegistraNovaVaga_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            _urlBase = ConfigurationManager.AppSettings["UrlBase"];
            var UserID = token.data.userToken.id;
            var DataCadastro = DateTime.Now;
            var TituloVaga = txtTituloVaga.Text.ToString();
            var DescricaoVaga = txtDescricao.Text.ToString();
            var StatusVaga = "Aberta";
            var SalarioVaga = txtSalario.Text.ToString();
            var Empresa = txtEmpresa.Text.ToString();
            var User = "";
            var urlbase = _urlBase + "nova-vaga";
            Auxiliar aux = new Auxiliar();

            if (string.IsNullOrWhiteSpace(txtTituloVaga.Text))
            {
                toolTip1.ToolTipTitle = "Atenção:";
                toolTip1.SetToolTip(txtTituloVaga, "Preencha");
                toolTip1.Show("Preencha este campo", txtTituloVaga, 5000);
                txtTituloVaga.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSalario.Text))
            {
                toolTip1.ToolTipTitle = "Atenção:";
                toolTip1.SetToolTip(txtSalario, "Preencha");
                toolTip1.Show("Preencha este campo", txtSalario, 5000);
                txtSalario.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmpresa.Text))
            {
                toolTip1.ToolTipTitle = "Atenção:";
                toolTip1.SetToolTip(txtEmpresa, "Preencha");
                toolTip1.Show("Preencha este campo", txtEmpresa, 5000);
                txtEmpresa.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                toolTip1.ToolTipTitle = "Atenção:";
                toolTip1.SetToolTip(txtDescricao, "Preencha");
                toolTip1.Show("Preencha este campo", txtDescricao, 5000);
                txtDescricao.Focus();
                return;
            }

            using (var client = new HttpClient())
            {
                string conteudo = "";

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
                            token.data.AccessToken);

                    HttpResponseMessage respToken =
                        client.PostAsync(urlbase, new StringContent(
                            JsonConvert.SerializeObject(new
                            {
                                UserID,
                                DataCadastro,
                                TituloVaga,
                                DescricaoVaga,
                                StatusVaga,
                                SalarioVaga,
                                Empresa,
                                User

                            }), Encoding.UTF8, "application/json")).Result;

                    conteudo = respToken.Content.ReadAsStringAsync().Result;

                    if (respToken.StatusCode == HttpStatusCode.OK)
                    {
                        empresaVaga = JsonConvert.DeserializeObject<EmpresaVagaModel>(conteudo);

                        if (empresaVaga.success)
                        {
                            MessageBox.Show($"Vaga cadastrada com sucesso.");
                            txtDescricao.Clear();
                            txtEmpresa.Clear();
                            txtSalario.Clear();
                            txtTituloVaga.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Falha no cadastro de vaga");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro " + ex.Message);
                    aux.WriteLog(token.data.userToken.email, "EMPRESA", "REGISTRAR VAGA", ex.Message.ToString());
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTituloVaga.Clear();
            txtSalario.Clear();
            txtDescricao.Clear();
            txtEmpresa.Clear();
        }
    }
}

