namespace Login
{
    public partial class Form1 : Form
    {
        List<string> listadeusuarios = new List<string>() { "jessica", "wesley", "lucas" };
        List<string> listsenha = new List<string>() { "321", "123", "111" };

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuariobuscado = textBoxUsuario.Text;
            string senha = Boxsenha.Text;

            if (string.IsNullOrWhiteSpace(usuariobuscado) && string.IsNullOrWhiteSpace(senha))
            {
                labelUsuario.Text = "Nome e Senha são obrigatórios!";
                labelUsuario.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrWhiteSpace(usuariobuscado))
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

            int posicaousuarioencontrado = -1;



            for (int i = 0; i < listadeusuarios.Count; i++)
            {
                if (usuariobuscado == listadeusuarios[i])
                {
                    posicaousuarioencontrado = i;
                }
            }


            if (posicaousuarioencontrado != -1 && senha == listsenha[posicaousuarioencontrado])
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
