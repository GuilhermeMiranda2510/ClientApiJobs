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
using ClientApiJobs.Services;
using ClientApiJobs.Models.TokenConfiguration;
using ClientApiJobs.Models.Empresa;
using ClientApiJobs.Forms.Candidato;
using ClientApiJobs.Forms.Empresa;
using System.Runtime.Intrinsics.X86;
using ClientApiJobs.Business;

namespace ClientApiJobs
{
    public partial class Frm_RelatorioVagas : Form
    {
        TokenModel token = null;
        public Frm_RelatorioVagas(TokenModel token)
        {
            this.token = token;
            InitializeComponent();
        }

        private string URI = "";
        private static string _urlBase;
        Auxiliar aux = new Auxiliar();

        private async void Frm_RelatorioVagas_Load(object sender, EventArgs e)
        {
            try
            {
                URI = _urlBase = ConfigurationManager.AppSettings["UrlBase"];
                var urlbase = URI + "full-vagas";
                var acessaAPI = new AcessaAPIService();
                List<EmpresaConfigurationModel> vagas = await acessaAPI.GetAllVagas(urlbase, token);
                dtgVagas.DataSource = vagas;
                lbquantidade.Text = (dtgVagas.RowCount - 0).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
                aux.WriteLog(token.data.userToken.email, "EMPRESA", "RELATÓRIO DE VAGAS", ex.Message.ToString());

            }
        }

        private void dtgVagas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgVagas.Rows.Count > 0)
                {
                    new Frm_EncerraVaga(
                        dtgVagas.CurrentRow.Cells[0].Value.ToString(), //vagaID
                        dtgVagas.CurrentRow.Cells[2].Value.ToString(), //DataCadastro
                        dtgVagas.CurrentRow.Cells[3].Value.ToString(), //TituloVaga 
                        dtgVagas.CurrentRow.Cells[4].Value.ToString(), //DescricaoVaga
                        dtgVagas.CurrentRow.Cells[5].Value.ToString(), //StatusVaga
                        dtgVagas.CurrentRow.Cells[6].Value.ToString(), //SalarioVaga
                        dtgVagas.CurrentRow.Cells[7].Value.ToString(), //Empresa
                        token).ShowDialog();
                    Frm_RelatorioVagas_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                aux.WriteLog(token.data.userToken.email, "EMPRESA", "RELATÓRIO DE VAGAS", ex.Message.ToString());
            }
        }

        private void dtgVagas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow etapa in dtgVagas.Rows)
            {
                if (etapa.Cells[5].Value.ToString() == "Aberta")
                    etapa.DefaultCellStyle.BackColor = Color.LightGreen;

                else if (etapa.Cells[5].Value.ToString() == "Fechada")
                    etapa.DefaultCellStyle.BackColor = Color.Red;
            }
        }
    }
}
