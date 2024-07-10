using ClientApiJobs.Forms.Candidato;
using ClientApiJobs.Forms.Empresa;
using ClientApiJobs.Models.TokenConfiguration;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApiJobs.Forms.Menu
{
    public partial class Frm_MenuPrincipal : Form
    {
        TokenModel token = null;
        public Frm_MenuPrincipal(TokenModel token)
        {
            this.token = token;
            InitializeComponent();
        }

        private void Frm_MenuPrincipal_Load(object sender, EventArgs e)
        {
            lb_userlogado.Text = token.data.userToken.email;

            bool adm = false;
            bool candidato = false;
            bool admempresa = false;
            bool rhempresa = false;

            foreach (var item in token.data.userToken.Claims)
            {
                adm = item.Value.Contains("Administrador");
            }

            if (adm == true)
            {
                lbPerfil.Text = "Administrador";
                minhasVagasToolStripMenuItem.Visible = false;
            }

            foreach (var item in token.data.userToken.Claims)
            {
                candidato = item.Value.Contains("Candidato");
            }

            if (candidato == true)
            {
                lbPerfil.Text = "Candidato";
                btnCadastraVaga.Visible = false;
                relatórioToolStripMenuItem.Visible = false;
                btnListaCandidatoVaga.Visible = false;
            }

            foreach (var item in token.data.userToken.Claims)
            {
                admempresa = item.Value.Contains("Adm Empresa");
            }

            if (admempresa == true)
            {
                lbPerfil.Text = "Adm Empresa";
                minhasVagasToolStripMenuItem.Visible = false;
                btnAreaCandidato.Visible = false;
                btnListaCandidatoVaga.Visible = false;
            }

            foreach (var item in token.data.userToken.Claims)
            {
                rhempresa = item.Value.Contains("RH Empresa");
            }

            if (rhempresa == true)
            {
                lbPerfil.Text = "RH Empresa";
                btnCadastraVaga.Visible = false;
                btnAreaCandidato.Visible = false;
                minhasVagasToolStripMenuItem.Visible = false;
                relatórioToolStripMenuItem.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Frm_RegistraNovaVaga(token).ShowDialog();
        }

        private void vagasAbertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_RelatorioVagas(token).ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new Frm_VagasDisponveis(token).ShowDialog();
        }

        private void vagasQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_CandidatoxVagas(token).ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            new Frm_ListarCandidatosPorVaga(token).ShowDialog();
        }
    }
}
