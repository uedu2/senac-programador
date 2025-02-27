namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string senha = Boxsenha.Text;

            if (string.IsNullOrWhiteSpace(usuario) && string.IsNullOrWhiteSpace(senha))
            {
                labelUsuario.Text = "Nome e Senha são obrigatórios!";
                labelUsuario.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrWhiteSpace(usuario))
            {
                labelUsuario.Text = "Nome é obrigatório!";
                labelUsuario.ForeColor = Color.Red;
                return;
            }


            if (string.IsNullOrWhiteSpace(senha))
            {
                labelUsuario.Text = "Senha é obrigatório!";
                labelUsuario.ForeColor = Color.Red;
                return;
            }

            if (usuario == "Keanu" && senha == "123")
            {
                labelUsuario.Text = "Autentificado com sucesso!";
                labelUsuario.ForeColor = Color.Blue;
            }
            else
            {
                labelUsuario.Text = "Senha ou nome incorretos!";
                labelUsuario.ForeColor = Color.Red;
            }



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            //lembrar de fazer os bagulhos!!!
            var l = textBoxUsuario.Text;

            if (l == " ")
            {
                textBoxUsuario.Text = "";
                return;
            }

            //if (string.)
           // {
            //    textBoxUsuario.Text = "";
           //     return;
           // }


        }
    }
}
