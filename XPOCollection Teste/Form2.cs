using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Xpo;
using XPOCollection_Teste.standby_org;

namespace XPOCollection_Teste
{
    public partial class Form2 : DevExpress.XtraEditors.XtraForm
    {
        public Session sessao { get; set; }
        public tb_clientes objeto { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //8 - Ao clicar no unico botao do form2, eu pego esse objeto e ele continua o mesmo obviamente,
            //afinal é a mesma session
            var cliente = objeto;

            //9 - Nesse momento, a sessao salva todas alterações do objeto e joga pra o banco.
            sessao.Save(cliente);
        }
    }
}