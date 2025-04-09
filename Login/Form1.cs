using MySql.Data.MySqlClient;

namespace Login
{
    public partial class Form1 : Form
    {

        private static readonly string ConnectionString = "datasource=localhost;username=root;password=;database=senac;";
        private readonly MySqlConnection Connection = new MySqlConnection(ConnectionString);


        List<Usuario> usuarios = new List<Usuario>();

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Busca o usu�rio e senha digitados
            string usuarioBuscado = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;

            // Verifica se o usu�rio foi digitado
            if (string.IsNullOrWhiteSpace(usuarioBuscado))
            {
                // Exibe mensagem de erro
                labelResultado.Text = "Usuario eh obrigatorio!!!";
                // Muda a cor da mensagem para vermelho
                labelResultado.ForeColor = Color.Red;
                // Encerra a execu��o do m�todo
                return;
            }

            // Verifica se a senha foi digitada
            if (string.IsNullOrWhiteSpace(senha))
            {
                // Exibe mensagem de erro
                labelResultado.Text = "Senha eh obrigatoria!!!";
                // Muda a cor da mensagem para vermelho
                labelResultado.ForeColor = Color.Red;
                // Encerra a execu��o do m�todo
                return;
            }

            // Verifica se o usu�rio e senha est�o corretos
            // Inicializa a vari�vel autenticado como false
            bool autenticado = false;

            try
            {
                Connection.Open();

                string query = $"SELECT senha FROM usuario WHERE email = '{usuarioBuscado}';";

                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                autenticado = reader.Read() && reader.GetString(0) == senha;
            }
            catch
            {
                MessageBox.Show("Erro de banco de dados");
            }
            finally
            {
                Connection.Close();
            }

            // Verifica se o usu�rio e senha n�o foram encontrados
            if (!autenticado)
            {
                // Exibe mensagem de erro
                labelResultado.Text = "Usuario ou Senha incorretos...";
                // Muda a cor da mensagem para vermelho
                labelResultado.ForeColor = Color.Red;
                // Encerra a execu��o do m�todo
                return;
            }

            // Se o usu�rio e senha foram encontrados, exibe mensagem de sucesso
            labelResultado.Text = "Autenticado com sucesso!";
            // Muda a cor da mensagem para verde
            labelResultado.ForeColor = Color.Green;

            // Limpa os campos de texto
            textBoxUsuario.Clear();
            textBoxSenha.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Busca o novo usu�rio e senha digitados
            string novoUsuario = textBoxNovoUsuario.Text;
            string novaSenha = textBoxNovaSenha.Text;


            // Verifica se o novo usu�rio foi digitado
            if (string.IsNullOrWhiteSpace(novoUsuario))
            {
                labelResultado.Text = "Usuario eh obrigatorio!!!";
                return;
            }

            // Verifica se a nova senha foi digitada
            if (string.IsNullOrWhiteSpace(novaSenha))
            {
                labelResultado.Text = "Senha eh obrigatoria!!!";
                return;
            }

            // Verifica se a senha tem pelo menos 8 caracteres
            if (novaSenha.Length < 8)
            {
                labelResultado.Text = "A senha deve ter pelo menos 8 caracteres";
                return;
            }

            // Verifica se a senha tem pelo menos uma letra mai�scula
            if (!novaSenha.Any(char.IsUpper))
            {
                labelResultado.Text = "A senha deve ter pelo menos uma letra maiuscula";
                return;
            }

            // Verifica se a senha tem pelo menos uma letra min�scula
            if (!novaSenha.Any(char.IsLower))
            {
                labelResultado.Text = "A senha deve ter pelo menos uma letra minuscula";
                return;
            }

            // Verifica se a senha tem pelo menos um n�mero
            if (!novaSenha.Any(char.IsNumber))
            {
                labelResultado.Text = "A senha deve ter pelo menos um numero";
                return;
            }

            // Verifica se a senha tem pelo menos um caracter especial
            if (!novaSenha.Any(char.IsPunctuation) && !novaSenha.Any(char.IsSymbol) && !novaSenha.Contains('@'))
            {
                labelResultado.Text = "A senha deve ter pelo menos um caracter especial";
                return;
            }

            // Verifica se a senha tem espa�os em branco
            if (novaSenha.Any(char.IsWhiteSpace))
            {
                labelResultado.Text = "A senha nao deve ter espacos em branco";
                return;
            }

            // Verifica se o novo usu�rio j� est� cadastrado
            bool encontrado = false;

            try
            {
                Connection.Open();

                string query = $"SELECT email FROM usuario WHERE email = '{novoUsuario}';";

                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                encontrado = reader.Read();
            }
            catch
            {
                MessageBox.Show("Erro de banco de dados");
            }
            finally
            {
                Connection.Close();
            }

            // Se o usu�rio j� estiver cadastrado, exibe mensagem de erro
            if (encontrado)
            {
                labelResultado.Text = "J� existe um usu�rio cadastrado";
                return;
            }

            // Adiciona o novo usu�rio na lista
            try
            {
                Connection.Open();

                string query = $"INSERT INTO usuario (email, senha) VALUES ('{novoUsuario}', '{novaSenha}');";

                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                mySqlCommand.ExecuteNonQuery();

                labelResultado.Text = "Usu�rio cadastrado com sucesso!";
                textBoxNovoUsuario.Clear();
                textBoxNovaSenha.Clear();
            }
            catch
            {
                MessageBox.Show("Erro de banco de dados");
            }
            finally
            {
                Connection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
