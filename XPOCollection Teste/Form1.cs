using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using XPOCollection_Teste.standby_org;

namespace XPOCollection_Teste
{
    public partial class Form1 : Form
    {
        public Session sessao { get; set; }
        public tb_clientes cliente { get; set; }

        public Form1()
        {
            InitializeComponent();

            //1 - Inicializo o XPO, esse parametro aqui basicamente diz se ele vai atualizar a estrutura do banco ou nao
            ConnectionHelper.Connect(AutoCreateOption.None);

            //2 - Inicio uma session com o DataLayer que a linha de cima ja inicializou pra mim
            Session session = new Session(XpoDefault.DataLayer);

            //3 - Botei a session na propriedade publica pra passar pra o proximo form, simulando o trabalho de elzinho
            sessao = session;

            //4 - Agora eu pego um cliente especifico do meu banco de ID 22
            var clienteId22 = session.Query<tb_clientes>().FirstOrDefault(x => x.cl_id == 22);

            //5 - Coloco esse cliente no cliente public tambem pra passar para o proximo form.
            cliente = clienteId22;

            #region testes

            //var resultado = session.Query<tb_clientes>()
            //    .Where(x => x.cl_id == 22)
            //    .Join(session.Query<tb_servicos>(),
            //        cliente => cliente.cl_id,
            //        servico => servico.sv_cl_idcliente.cl_id,
            //        (cliente, servico) => new { Cliente = cliente, Servico = servico })
            //    .ToList();


            //var teste = CriteriaOperator.FromLambda<tb_clientes>(w => w.cl_id != 22);



            //XPQuery<tb_servicos> servicos1 = new XPQuery<tb_servicos>(session);
            //XPQuery<tb_clientes> clientes1 = new XPQuery<tb_clientes>(session);

            //var servicosCliente22 = from s in servicos1
            //            join c in clientes1 on s.sv_cl_idcliente.cl_id equals c.cl_id
            //            where c.cl_id == 22
            //            select new { Servico = s, Cliente = c };

            #endregion
        }

        private void btnAbrirForm2_Click(object sender, EventArgs e)
        {
            //6 - Ao clicar no unico botao do form1, eu faço uma alteração no nome do cliente adicionando o numero 1 no final.
            //mas nessa alteração, o banco continua intacto, estou alterando o dado dentro da sessão (que é uma copia do banco)
            cliente.cl_nome = cliente.cl_nome + "1";


            //7 - Abro o novo form passando a session e o cliente do cliente.
            Form2 form2 = new Form2();
            form2.sessao = sessao;
            form2.objeto = cliente;
            form2.Show();


        }
    }
}
