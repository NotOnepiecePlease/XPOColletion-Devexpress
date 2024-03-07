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
using DevExpress.Xpo.DB;
using XPOCollection_Teste.standby_org;

namespace XPOCollection_Teste
{
    public partial class Form3 : Form
    {
        public UnitOfWork uowPublicForm3 { get; set; }

        public Form3()
        {
            InitializeComponent();

            //1 - Inicializo o XPO, esse parametro aqui basicamente diz se ele vai atualizar a estrutura do banco ou nao
            ConnectionHelper.Connect(AutoCreateOption.None);

            //2 - Crio uma "unidade de trabalho" ela é um pouco mais amplas que a sessão, voce pode alterar varias coisas de uma vez
            //e depois salvar tudo de uma vez so.
            UnitOfWork uow = new UnitOfWork(XpoDefault.DataLayer);

            //3 - Armazeno na variavel public pra poder acessar no botao e passar para o proximo form.
            uowPublicForm3 = uow;

            //4 - Aqui eu pego um cliente de id 22 e altero o nome dele botando o 1 no final.
            //nesse momento, nenhuma alteração é feita no banco ainda
            var clienteId22 = uow.Query<tb_clientes>().FirstOrDefault(x => x.cl_id == 22);
            clienteId22.cl_nome = clienteId22.cl_nome + 1;
        }

        private void btnAbrirForm4_Click(object sender, EventArgs e)
        {
            //5 - Agora eu abro o novo form e mando essa UOW pra ele.
            Form4 form4 = new Form4();
            form4.uowPublicForm4 = uowPublicForm3;
            form4.Show();
        }
    }
}
