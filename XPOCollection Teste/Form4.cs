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
    public partial class Form4 : Form
    {
        public UnitOfWork uowPublicForm4 { get; set; }
        public Form4()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //6 - Agora eu pego novamente o mesmo cliente pra ver se a alteração ainda esta dentro do cliente,
            //como voce pode ver, o numero 1 esta no final do nome mas ainda nao alterou no banco

            //7 - Por fim, eu chamo o "uowPublicForm4.CommitChanges()" e todas alterações na uow, sao levadas pra o banco
            var cliente = uowPublicForm4.Query<tb_clientes>().FirstOrDefault(x => x.cl_id == 22);
















            uowPublicForm4.CommitChanges();
        }
    }
}
