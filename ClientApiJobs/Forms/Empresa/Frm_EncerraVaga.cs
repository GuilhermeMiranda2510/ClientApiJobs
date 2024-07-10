using ClientApiJobs.Models.Candidato;
using ClientApiJobs.Models.TokenConfiguration;
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
using ClientApiJobs.Models.Empresa;
using System.Runtime.Intrinsics.X86;
using ClientApiJobs.Business;

namespace ClientApiJobs.Forms.Empresa
{
    public partial class Frm_EncerraVaga : Form
    {
        TokenModel token = null;
        string Id = string.Empty;
        string DataCadastro = string.Empty;
        string TituloVaga = string.Empty;
        string DescricaoVaga = string.Empty;
        string StatusVaga = string.Empty;
        string SalarioVaga = string.Empty;
        string Empresa = string.Empty;
        public Frm_EncerraVaga(string Id,
                             string DataCadastro,
                             string TituloVaga,
                             string DescricaoVaga,
                             string StatusVaga,
                             string SalarioVaga,
                             string Empresa,
                             TokenModel token)
        {

            this.Id = Id;
            this.DataCadastro = DataCadastro;
            this.TituloVaga = TituloVaga;
            this.DescricaoVaga = DescricaoVaga;
            this.StatusVaga = StatusVaga;
            this.SalarioVaga = SalarioVaga;
            this.Empresa = Empresa;
            this.token = token;
            InitializeComponent();
        }
        
        private string URI = "";
        private static string _urlBase;
        private static EmpresaVagaModel empresavaga;
        Auxiliar aux = new Auxiliar();

        private void Frm_EncerraVaga_Load(object sender, EventArgs e)
        {
            
            txtTituloVaga.Text = TituloVaga;
            txtSalario.Text = SalarioVaga;
            txtEmpresa.Text = Empresa;
            txtDescricao.Text = DescricaoVaga;
            lb_aberturavaga.Text = Convert.ToDateTime(DataCadastro).ToString("dd-MM-yyyy");

            if(StatusVaga == "Fechada")
            {
                btnSalvar.Enabled = false;
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            _urlBase = ConfigurationManager.AppSettings["UrlBase"];
            StatusVaga = "Fechada";
            var DataCadastro = DateTime.Now;
            var VagaId = Id;
            var UserId = token.data.userToken.id;
            var urlbase = _urlBase + "encerra-vaga/" + Id;

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
                        client.PutAsync(urlbase, new StringContent(
                            JsonConvert.SerializeObject(new
                            {
                                Id,
                                UserId,
                                DataCadastro,
                                TituloVaga,
                                DescricaoVaga,
                                StatusVaga,
                                SalarioVaga,
                                Empresa,

                }), Encoding.UTF8, "application/json")).Result;

                    conteudo = respToken.Content.ReadAsStringAsync().Result;

                    if (respToken.StatusCode == HttpStatusCode.OK)
                    {
                        empresavaga = JsonConvert.DeserializeObject<EmpresaVagaModel>(conteudo);

                        if (empresavaga.success)
                        {
                            MessageBox.Show($"Vaga encerrada com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Falha ao encerrar a vaga...");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro " + ex.Message);
                    aux.WriteLog(token.data.userToken.email, "EMPRESA", "ENCERRAR VAGA", ex.Message.ToString());
                }
            }
        }
    }
}
