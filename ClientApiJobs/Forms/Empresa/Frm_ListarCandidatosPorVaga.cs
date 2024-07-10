using ClientApiJobs.Business;
using ClientApiJobs.Forms.Candidato;
using ClientApiJobs.Models.Empresa;
using ClientApiJobs.Models.TokenConfiguration;
using ClientApiJobs.Services;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApiJobs.Forms.Empresa
{
    public partial class Frm_ListarCandidatosPorVaga : Form
    {
        TokenModel token = null;
        public Frm_ListarCandidatosPorVaga(TokenModel token)
        {
            this.token = token;
            InitializeComponent();
        }

        private string URI = "";
        private static string _urlBase;
        Auxiliar aux = new Auxiliar();

        private async void Frm_ListarCandidatosPorVaga_Load(object sender, EventArgs e)
        {
            try
            {
                URI = _urlBase = ConfigurationManager.AppSettings["UrlBase"];
                var urlbase = URI + "full-vagas";
                var acessaAPI = new AcessaAPIService();
                List<EmpresaConfigurationModel> vagas = await acessaAPI.GetAllVagas(urlbase, token);
                dtgListaCandidatosVaga.DataSource = vagas;
                lbquantidade.Text = (dtgListaCandidatosVaga.RowCount - 0).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
                aux.WriteLog(token.data.userToken.email, "EMPRESA", "LISTAR CANDIDATO POR VAGA", ex.Message.ToString());

            }
        }

        private void dtgListaCandidatosVaga_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow etapa in dtgListaCandidatosVaga.Rows)
            {
                if (etapa.Cells[5].Value.ToString() == "Aberta")
                    etapa.DefaultCellStyle.BackColor = Color.LightGreen;

                else if (etapa.Cells[5].Value.ToString() == "Fechada")
                    etapa.DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void dtgListaCandidatosVaga_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgListaCandidatosVaga.Rows.Count > 0)
                {
                    new Frm_DadosCandidatosPorVaga(
                        dtgListaCandidatosVaga.CurrentRow.Cells[0].Value.ToString(), //vagaID
                        dtgListaCandidatosVaga.CurrentRow.Cells[2].Value.ToString(), //DataCadastro
                        dtgListaCandidatosVaga.CurrentRow.Cells[3].Value.ToString(), //TituloVaga 
                        dtgListaCandidatosVaga.CurrentRow.Cells[4].Value.ToString(), //DescricaoVaga
                        dtgListaCandidatosVaga.CurrentRow.Cells[5].Value.ToString(), //StatusVaga
                        dtgListaCandidatosVaga.CurrentRow.Cells[6].Value.ToString(), //SalarioVaga
                        dtgListaCandidatosVaga.CurrentRow.Cells[7].Value.ToString(), //Empresa
                        token).ShowDialog();
                    Frm_ListarCandidatosPorVaga_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                aux.WriteLog(token.data.userToken.email, "EMPRESA", "LISTAR CANDIDATO POR VAGA", ex.Message.ToString());
            }
        }
    }
}
