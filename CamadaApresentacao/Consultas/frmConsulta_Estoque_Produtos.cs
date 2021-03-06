using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaNegocio;

namespace CamadaApresentacao.Consultas
{
    public partial class frmConsulta_Estoque_Produtos : Form
    {
        public frmConsulta_Estoque_Produtos()
        {
            InitializeComponent();
        }


        //Ocultar as Colunas do Grid
        private void ocultarColunas()
        {
            this.dataLista.Columns[0].Visible = false;
            
        }


        //Mostrar no Data Grid
        private void Mostrar()
        {
            this.dataLista.DataSource = NProduto.EstoqueProduto();
            this.ocultarColunas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.Rows.Count);
        }

        private void frmConsulta_Estoque_Produtos_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }
    }
}
