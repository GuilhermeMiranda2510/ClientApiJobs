using ClientApiJobs.Business;
using ClientApiJobs.Models.Empresa;
using ClientApiJobs.Models.TokenConfiguration;
using ClientApiJobs.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApiJobs.Forms.Candidato
{
    public partial class Frm_CandidatoxVagas : Form
    {
        TokenModel token = null;
        private string URI = "";
        private static string _urlBase;
        Auxiliar aux = new Auxiliar();
        public Frm_CandidatoxVagas(TokenModel token)
        {
            this.token = token;
            InitializeComponent();
        }

        private async void Frm_CandidatoxVagas_Load(object sender, EventArgs e)
        {
            try
            {
                URI = _urlBase = ConfigurationManager.AppSettings["UrlBase"];
                var urlbase = URI + "busca-vaga-candidato/" +token.data.userToken.id;
                var acessaAPI = new AcessaAPIService();
                List<EmpresaConfigurationModel> vagas = await acessaAPI.GetVagasPorCandidato(urlbase, token);
                dtgMinhasCandidaturas.DataSource = vagas;
                dtgMinhasCandidaturas.Columns.Remove("Id");
                dtgMinhasCandidaturas.Columns.Remove("UserId");

                lbquantidade.Text = (dtgMinhasCandidaturas.RowCount - 0).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
                aux.WriteLog(token.data.userToken.email, "CANDIDATO", "VAGAS DO CANDIDATO", ex.Message.ToString());
            }
        }
    }
}
