using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DinnamusMe
{
    public partial class GerarArquivoInventario : Form
    {
        public GerarArquivoInventario()
        {
            InitializeComponent();
            InicializarUI(true);
        }
        public Boolean InicializarUI(bool bIgnorarMsg)
        {
            try
            {
                
                DataTable dt = DAO.getDataSet("SELECT     d.codigo Codigo, f.NomeFilial,f.codigofilial , CASE WHEN d .feito IS NULL THEN 'ABERTO' ELSE 'FECHADO' END AS situacao, d.datainicio  " +
                                                        "FROM         dadosinvent d, Filial f " +
                                                        "WHERE     f.CodigoFilial = d.filial and d.feito ='S'", "Inventario").Tables["Inventario"];
                dbgInventarios.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    if (!bIgnorarMsg)
                    {
                        MessageBox.Show("Não foi encontrado nenhum inventário Fechado");
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



            return true;
        }

        private void btFecharContagem_Click(object sender, EventArgs e)
        {

        }

        private void btGerarArquivos_Click(object sender, EventArgs e)
        {
            try 
	        {	        
        		if(dbgInventarios.CurrentRowIndex >=0)  
                {
                    if(MessageBox.Show("Confirma a geração dos arquivo do inventário?","Gerar Arquivo PC",MessageBoxButtons.YesNo,MessageBoxIcon.Question ,MessageBoxDefaultButton.Button1)==DialogResult.Yes)
                    {
                        Int32 nCodigoInventario;
                        DataTable dt = (DataTable)dbgInventarios.DataSource;
                        nCodigoInventario = Int32.Parse(dt.Rows[dbgInventarios.CurrentRowIndex]["codigo"].ToString());
                        if(Inventario.GravarArquivosInventarioPC(nCodigoInventario))
                        {
                            MessageBox.Show("dadosinvent" + nCodigoInventario.ToString() + ".din , itensinvent" + nCodigoInventario+ ".din , estão na pasta [inventários]" ,"Geração OK",MessageBoxButtons.OK ,MessageBoxIcon.Exclamation ,MessageBoxDefaultButton.Button1 );
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível gravar os arquivos");
                        }


    

                    }
                    
                }

	        }
	        catch (Exception ex)
	        {
        		
		        MessageBox.Show(ex.Message);
	        }
            
        }

    }
}