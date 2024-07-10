using ClientApiJobs.Models.Candidato;
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
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApiJobs.Forms.Empresa
{
    public partial class Frm_DadosCandidatosPorVaga : Form
    {
        TokenModel token = null;
        string VagaID = string.Empty;
        string DataCadastro = string.Empty;
        string TituloVaga = string.Empty;
        string DescricaoVaga = string.Empty;
        string StatusVaga = string.Empty;
        string SalarioVaga = string.Empty;
        string Empresa = string.Empty;
        public Frm_DadosCandidatosPorVaga(
                             string VagaID,
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

        private async void Frm_DadosCandidatosPorVaga_Load(object sender, EventArgs e)
        {
            try
            {
                URI = _urlBase = ConfigurationManager.AppSettings["UrlBase"];
                var urlbase = URI + "busca-candidato-por-vaga/" + VagaID;
                var acessaAPI = new AcessaAPIService();
                List<CandidatoVagaModel> vagas = await acessaAPI.GetCandidatosPorVagas(urlbase, token);
                dtgListaCandidatos.DataSource = vagas;

                dtgListaCandidatos.Columns.Remove("Id");
                dtgListaCandidatos.Columns.Remove("VagaID");
                dtgListaCandidatos.Columns.Remove("DataAbertura");
                dtgListaCandidatos.Columns.Remove("TituloVaga");
                dtgListaCandidatos.Columns.Remove("DescricaoVaga");
                dtgListaCandidatos.Columns.Remove("SalarioVaga");
                dtgListaCandidatos.Columns.Remove("Empresa");

                foreach (var item in vagas)
                {
                    txtTituloVaga.Text = item.TituloVaga.ToString();
                    txtDataAbertura.Text =  item.DataAbertura.ToString("dd/MM/yyyy");
                    txtEmpresa.Text = item.Empresa.ToString();
                    txtSalario.Text = item.SalarioVaga.ToString();
                    txtDescricao.Text = item.DescricaoVaga.ToString();  
                }

                // lbquantidade.Text = (dtgListaCandidatos.RowCount - 0).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
