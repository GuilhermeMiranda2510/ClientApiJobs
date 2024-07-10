using ClientApiJobs.Models.Empresa;
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
using ClientApiJobs.Models.Candidato;
using System.Runtime.Intrinsics.X86;
using ClientApiJobs.Business;

namespace ClientApiJobs.Forms.Candidato
{
    public partial class Frm_DadosVaga : Form
    {
        TokenModel token = null;
        string VagaID = string.Empty;
        string DataCadastro = string.Empty;
        string TituloVaga = string.Empty;
        string DescricaoVaga = string.Empty;
        string StatusVaga = string.Empty;
        string SalarioVaga = string.Empty;
        string Empresa = string.Empty;
        public Frm_DadosVaga(string VagaID,
                             string DataCadastro,
                             string TituloVaga,
                             string DescricaoVaga,
                             string StatusVaga,
                             string SalarioVaga,
                             string Empresa,
                             TokenModel token)
        {
            this.VagaID = VagaID;
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
        private static CandidatoModel candidato;
        Auxiliar aux = new Auxiliar();
        private void Frm_DadosVaga_Load(object sender, EventArgs e)
        {
            txtTituloVaga.Text = TituloVaga;
            txtSalario.Text = SalarioVaga;
            txtEmpresa.Text = Empresa;
            txtDescricao.Text = DescricaoVaga;
            lb_aberturavaga.Text = Convert.ToDateTime(DataCadastro).ToString("dd-MM-yyyy");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            _urlBase = ConfigurationManager.AppSettings["UrlBase"];
            
            var DataCadastro = DateTime.Now;
            var VagaId = VagaID;
            var UserId = token.data.userToken.id;
            var urlbase = _urlBase + "registrar-na-vaga";

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
                                DataCadastro,
                                VagaId = VagaID,
                                UserId = token.data.userToken.id

                }), Encoding.UTF8, "application/json")).Result;

                    conteudo = respToken.Content.ReadAsStringAsync().Result;

                    if (respToken.StatusCode == HttpStatusCode.OK)
                    {
                        candidato = JsonConvert.DeserializeObject<CandidatoModel>(conteudo);

                        if (candidato.success)
                        {
                            MessageBox.Show($"Candidatura feita com sucesso. Boa sorte!!!!");
                            txtDescricao.Clear();
                            txtEmpresa.Clear(); 
                            txtSalario.Clear();
                            txtTituloVaga.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Falha ao se candidatar...");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro " + ex.Message);
                    aux.WriteLog(token.data.userToken.email, "CANDIDATO", "REGISTRAR", ex.Message.ToString());
                }
            }
        }
    }
}
