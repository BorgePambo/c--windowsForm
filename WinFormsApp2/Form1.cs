using WinFormsApp2.Modelo;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtEmail.Text, txtSenha.Text);

            if (controle.tem)
            {
                MessageBox.Show("Logado com sucesso", "Entrada",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                BemVindo bv = new BemVindo();
                bv.Show();
            }
            else
            {
                MessageBox.Show("Login n�o encontrado", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarSe cad = new CadastrarSe();
            cad.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}