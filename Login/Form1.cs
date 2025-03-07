namespace Login
{
    public partial class Form1 : Form
    {
        List<string> listadeusuarios = new List<string>() { "jessica", "wesley", "lucas" };
        List<string> listsenha = new List<string>() { "Lucas23!", "Biw@w2000", "42Vida!!" };
        List<string> chara = new List<string>() { "@","!","#","$","%","&","*","(",")","_","-","=","+","?" };
        List<string> numb = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0",};
        List<string> letra = new List<string>() { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f","g","h","j","k","l","�","z","x","c","v","b","n","m" };
        List<string> LETRA = new List<string>() { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "�", "Z", "X", "C", "V", "B", "N", "M" };

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
                labelUsuario.Text = "Nome e Senha s�o obrigat�rios!";
                labelUsuario.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrWhiteSpace(usuariobuscado))
            {
                labelUsuario.Text = "Nome � obrigat�rio!";
                labelUsuario.ForeColor = Color.Red;
                return;
            }



            if (string.IsNullOrWhiteSpace(senha))
            {
                labelUsuario.Text = "Senha � obrigat�rio!";
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

            /*if (textBoxUsuario.Text.Contains(" "))
             {
                textBoxUsuario.Text = "";
                 return;
             }*/


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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string novo_usuario = novonome.Text, nova_senha = novasenha.Text;
            bool usuario_encontrado = false, characterue = false, numbtrue = false, letratrue = false, LETRAtrue = false;

            //continue;
            if (nova_senha.Length < 8)
            {
                aut.Text = "no minimo 8 caracteres";
                return;

            }
            if (nova_senha.Contains (" "))
            {
                aut.Text = "n�o pode conter espa�os!";
                return;
            }

           

            string encharar = novasenha.Text;

            for (int i = 0; i < chara.Count; i++)//
            {
                if (encharar.Contains(chara[i]))
                {
                    characterue = true;
                }
            }
            
            if (!characterue) 
            {
                aut.Text = "n�o tem o character"; 
                return ;
            }


            for (int i = 0; i < numb.Count; i++)//
            {
                if (encharar.Contains(numb[i]))
                {
                    numbtrue = true;
                }
            }
            
            if (!numbtrue)
            {
                aut.Text = "n�o tem o numeros";
                return;
            }


            for (int i = 0; i < letra.Count; i++)//
            {
                if (encharar.Contains(letra[i]))
                {
                    letratrue = true;
                }
            }
            
            if (!letratrue)
            {
                aut.Text = "n�o tem letras min";
                return;
            }


            for (int i = 0; i < LETRA.Count; i++)//
            {
                if (encharar.Contains(LETRA[i]))
                {
                    LETRAtrue = true;
                }
            }
            
            if (!LETRAtrue)
            {
                aut.Text = "n�o letras mai";
                return ;
            }



            for (int i = 0; i < listadeusuarios.Count; i++)
            {
                if (novo_usuario == listadeusuarios[i])
                {
                    usuario_encontrado = true;
                }
            }
            if (usuario_encontrado == false)
            {
                listadeusuarios.Add(novo_usuario);
                listsenha.Add(nova_senha);

            }
            else
            {

            }
        }

        private void Boxsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void novasenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
