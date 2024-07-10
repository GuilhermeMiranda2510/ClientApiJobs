using ClientApiJobs.Business;
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

namespace ClientApiJobs.Forms.Candidato
{
    public partial class Frm_VagasDisponveis : Form
    {
        TokenModel token = null;
        private string URI = "";
        private static string _urlBase;
        Auxiliar aux = new Auxiliar();

        public Frm_VagasDisponveis(TokenModel token)
        {
            this.token = token;
            InitializeComponent();
        }

        private async void Frm_VagasxCandidato_Load(object sender, EventArgs e)
        {
            try
            {
                URI = _urlBase = ConfigurationManager.AppSettings["UrlBase"];
                var urlbase = URI + "full-vagas-disponiveis";
                var acessaAPI = new AcessaAPIService();
                List<EmpresaConfigurationModel> vagas = await acessaAPI.GetAllVagasDisponiveis(urlbase, token);
                dtgVagasDisponiveis.DataSource = vagas;
               // dtgVagasDisponiveis.Columns.Remove("UserID");

                lbquantidade.Text = (dtgVagasDisponiveis.RowCount - 0).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
                aux.WriteLog(token.data.userToken.email, "CANDIDATO", "VAGAS DISPONIVEIS", ex.Message.ToString());

            }
        }

        private void dtgVagasDisponiveis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgVagasDisponiveis.Rows.Count > 0)
                {
                    new Frm_DadosVaga(
                        dtgVagasDisponiveis.CurrentRow.Cells[0].Value.ToString(), //vagaID
                        dtgVagasDisponiveis.CurrentRow.Cells[2].Value.ToString(), //DataCadastro
                        dtgVagasDisponiveis.CurrentRow.Cells[3].Value.ToString(), //TituloVaga 
                        dtgVagasDisponiveis.CurrentRow.Cells[4].Value.ToString(), //DescricaoVaga
                        dtgVagasDisponiveis.CurrentRow.Cells[5].Value.ToString(), //StatusVaga
                        dtgVagasDisponiveis.CurrentRow.Cells[6].Value.ToString(), //SalarioVaga
                        dtgVagasDisponiveis.CurrentRow.Cells[7].Value.ToString(), //Empresa
                        token).ShowDialog();
                        Frm_VagasxCandidato_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
