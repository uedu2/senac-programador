namespace CadastroClientes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LabelNome = new Label();
            LabelData = new Label();
            LabelTelefone = new Label();
            LabelEmail = new Label();
            LabelGenero = new Label();
            LabelNomeSocial = new Label();
            LabelEtinia = new Label();
            LabelEstrangeiro = new Label();
            LabelTipo = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            TextBoxNome = new TextBox();
            TextBoxData = new MaskedTextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            ComboBoxEtnia = new ComboBox();
            TextBoxNomeSocial = new TextBox();
            TextBoxEmail = new TextBox();
            TextBoxTelefone = new MaskedTextBox();
            ComboBoxGenero = new ComboBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            RadioButtonPessoaFisica = new RadioButton();
            RadioButtonPessoaJuridica = new RadioButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            CheckBoxEstrangeiroSim = new CheckBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            LabelCEP = new Label();
            LabelEstado = new Label();
            LabelMunicipio = new Label();
            LabelBairro = new Label();
            LabelComplemento = new Label();
            LabelNumero = new Label();
            LabelLogradouro = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            TextBoxMunicipio = new TextBox();
            TextBoxBairro = new TextBox();
            TextBoxComplemento = new TextBox();
            TextBoxNumero = new TextBox();
            TextBoxLogradouro = new TextBox();
            ComboBoxEstado = new ComboBox();
            TextBoxCEP = new MaskedTextBox();
            Botao_Cadastrar = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            label1 = new Label();
            dataGridViewClientes = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // LabelNome
            // 
            LabelNome.Anchor = AnchorStyles.None;
            LabelNome.AutoSize = true;
            LabelNome.Font = new Font("Elephant", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelNome.Location = new Point(76, 22);
            LabelNome.Name = "LabelNome";
            LabelNome.Size = new Size(68, 25);
            LabelNome.TabIndex = 0;
            LabelNome.Text = "Nome";
            // 
            // LabelData
            // 
            LabelData.Anchor = AnchorStyles.None;
            LabelData.AutoSize = true;
            LabelData.Font = new Font("Elephant", 14.25F);
            LabelData.Location = new Point(8, 92);
            LabelData.Name = "LabelData";
            LabelData.Size = new Size(204, 25);
            LabelData.TabIndex = 2;
            LabelData.Text = "Data de Nascimento";
            // 
            // LabelTelefone
            // 
            LabelTelefone.Anchor = AnchorStyles.None;
            LabelTelefone.AutoSize = true;
            LabelTelefone.Font = new Font("Elephant", 14.25F);
            LabelTelefone.Location = new Point(64, 162);
            LabelTelefone.Name = "LabelTelefone";
            LabelTelefone.Size = new Size(93, 25);
            LabelTelefone.TabIndex = 4;
            LabelTelefone.Text = "Telefone";
            // 
            // LabelEmail
            // 
            LabelEmail.Anchor = AnchorStyles.None;
            LabelEmail.AutoSize = true;
            LabelEmail.Font = new Font("Elephant", 14.25F);
            LabelEmail.Location = new Point(76, 232);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(69, 25);
            LabelEmail.TabIndex = 6;
            LabelEmail.Text = "Email";
            // 
            // LabelGenero
            // 
            LabelGenero.Anchor = AnchorStyles.None;
            LabelGenero.AutoSize = true;
            LabelGenero.Font = new Font("Elephant", 14.25F);
            LabelGenero.Location = new Point(69, 302);
            LabelGenero.Name = "LabelGenero";
            LabelGenero.Size = new Size(82, 25);
            LabelGenero.TabIndex = 8;
            LabelGenero.Text = "Genero";
            // 
            // LabelNomeSocial
            // 
            LabelNomeSocial.Anchor = AnchorStyles.None;
            LabelNomeSocial.AutoSize = true;
            LabelNomeSocial.Font = new Font("Elephant", 14.25F);
            LabelNomeSocial.Location = new Point(45, 372);
            LabelNomeSocial.Name = "LabelNomeSocial";
            LabelNomeSocial.Size = new Size(130, 25);
            LabelNomeSocial.TabIndex = 10;
            LabelNomeSocial.Text = "Nome Social";
            // 
            // LabelEtinia
            // 
            LabelEtinia.Anchor = AnchorStyles.None;
            LabelEtinia.AutoSize = true;
            LabelEtinia.Font = new Font("Elephant", 14.25F);
            LabelEtinia.Location = new Point(78, 442);
            LabelEtinia.Name = "LabelEtinia";
            LabelEtinia.Size = new Size(65, 25);
            LabelEtinia.TabIndex = 12;
            LabelEtinia.Text = "Etnia";
            // 
            // LabelEstrangeiro
            // 
            LabelEstrangeiro.Anchor = AnchorStyles.None;
            LabelEstrangeiro.AutoSize = true;
            LabelEstrangeiro.Font = new Font("Elephant", 14.25F);
            LabelEstrangeiro.Location = new Point(48, 512);
            LabelEstrangeiro.Name = "LabelEstrangeiro";
            LabelEstrangeiro.Size = new Size(125, 25);
            LabelEstrangeiro.TabIndex = 14;
            LabelEstrangeiro.Text = "Estrangeiro";
            // 
            // LabelTipo
            // 
            LabelTipo.Anchor = AnchorStyles.None;
            LabelTipo.AutoSize = true;
            LabelTipo.Font = new Font("Elephant", 14.25F);
            LabelTipo.Location = new Point(82, 583);
            LabelTipo.Name = "LabelTipo";
            LabelTipo.Size = new Size(56, 25);
            LabelTipo.TabIndex = 16;
            LabelTipo.Text = "Tipo";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(LabelTipo, 0, 8);
            tableLayoutPanel1.Controls.Add(LabelEstrangeiro, 0, 7);
            tableLayoutPanel1.Controls.Add(LabelEtinia, 0, 6);
            tableLayoutPanel1.Controls.Add(LabelNomeSocial, 0, 5);
            tableLayoutPanel1.Controls.Add(LabelGenero, 0, 4);
            tableLayoutPanel1.Controls.Add(LabelEmail, 0, 3);
            tableLayoutPanel1.Controls.Add(LabelTelefone, 0, 2);
            tableLayoutPanel1.Controls.Add(LabelData, 0, 1);
            tableLayoutPanel1.Controls.Add(LabelNome, 0, 0);
            tableLayoutPanel1.Location = new Point(-4, -4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.Size = new Size(221, 631);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // TextBoxNome
            // 
            TextBoxNome.Anchor = AnchorStyles.None;
            TextBoxNome.Location = new Point(3, 23);
            TextBoxNome.Name = "TextBoxNome";
            TextBoxNome.Size = new Size(209, 23);
            TextBoxNome.TabIndex = 2;
            // 
            // TextBoxData
            // 
            TextBoxData.Anchor = AnchorStyles.None;
            TextBoxData.Location = new Point(57, 93);
            TextBoxData.Mask = "00/00/0000";
            TextBoxData.Name = "TextBoxData";
            TextBoxData.Size = new Size(100, 23);
            TextBoxData.TabIndex = 3;
            TextBoxData.Text = "13122011";
            TextBoxData.ValidatingType = typeof(DateTime);
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(ComboBoxEtnia, 0, 6);
            tableLayoutPanel2.Controls.Add(TextBoxNomeSocial, 0, 5);
            tableLayoutPanel2.Controls.Add(TextBoxEmail, 0, 3);
            tableLayoutPanel2.Controls.Add(TextBoxTelefone, 0, 2);
            tableLayoutPanel2.Controls.Add(TextBoxNome, 0, 0);
            tableLayoutPanel2.Controls.Add(TextBoxData, 0, 1);
            tableLayoutPanel2.Controls.Add(ComboBoxGenero, 0, 4);
            tableLayoutPanel2.Location = new Point(220, -4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.Size = new Size(215, 491);
            tableLayoutPanel2.TabIndex = 17;
            // 
            // ComboBoxEtnia
            // 
            ComboBoxEtnia.Anchor = AnchorStyles.None;
            ComboBoxEtnia.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxEtnia.FormattingEnabled = true;
            ComboBoxEtnia.Items.AddRange(new object[] { "Branco", "Negro", "Pardo", "Asiatico", "Indigena" });
            ComboBoxEtnia.Location = new Point(47, 444);
            ComboBoxEtnia.Name = "ComboBoxEtnia";
            ComboBoxEtnia.Size = new Size(121, 23);
            ComboBoxEtnia.TabIndex = 8;
            // 
            // TextBoxNomeSocial
            // 
            TextBoxNomeSocial.Anchor = AnchorStyles.None;
            TextBoxNomeSocial.Location = new Point(3, 373);
            TextBoxNomeSocial.Name = "TextBoxNomeSocial";
            TextBoxNomeSocial.Size = new Size(209, 23);
            TextBoxNomeSocial.TabIndex = 7;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Anchor = AnchorStyles.None;
            TextBoxEmail.Location = new Point(3, 233);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(209, 23);
            TextBoxEmail.TabIndex = 5;
            // 
            // TextBoxTelefone
            // 
            TextBoxTelefone.Anchor = AnchorStyles.None;
            TextBoxTelefone.Location = new Point(57, 163);
            TextBoxTelefone.Mask = "(99)0000-0000";
            TextBoxTelefone.Name = "TextBoxTelefone";
            TextBoxTelefone.Size = new Size(100, 23);
            TextBoxTelefone.TabIndex = 4;
            TextBoxTelefone.Text = "1140028922";
            // 
            // ComboBoxGenero
            // 
            ComboBoxGenero.Anchor = AnchorStyles.None;
            ComboBoxGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxGenero.FormattingEnabled = true;
            ComboBoxGenero.Items.AddRange(new object[] { "Masculino", "Feminino", "Outro" });
            ComboBoxGenero.Location = new Point(47, 303);
            ComboBoxGenero.Name = "ComboBoxGenero";
            ComboBoxGenero.Size = new Size(121, 23);
            ComboBoxGenero.TabIndex = 6;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(RadioButtonPessoaFisica, 0, 0);
            tableLayoutPanel4.Controls.Add(RadioButtonPessoaJuridica, 1, 0);
            tableLayoutPanel4.Location = new Point(220, 555);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(215, 72);
            tableLayoutPanel4.TabIndex = 19;
            // 
            // RadioButtonPessoaFisica
            // 
            RadioButtonPessoaFisica.Anchor = AnchorStyles.None;
            RadioButtonPessoaFisica.AutoSize = true;
            RadioButtonPessoaFisica.Checked = true;
            RadioButtonPessoaFisica.Location = new Point(34, 26);
            RadioButtonPessoaFisica.Name = "RadioButtonPessoaFisica";
            RadioButtonPessoaFisica.Size = new Size(38, 19);
            RadioButtonPessoaFisica.TabIndex = 2;
            RadioButtonPessoaFisica.TabStop = true;
            RadioButtonPessoaFisica.Text = "PF";
            RadioButtonPessoaFisica.UseVisualStyleBackColor = true;
            // 
            // RadioButtonPessoaJuridica
            // 
            RadioButtonPessoaJuridica.Anchor = AnchorStyles.None;
            RadioButtonPessoaJuridica.AutoSize = true;
            RadioButtonPessoaJuridica.Location = new Point(143, 26);
            RadioButtonPessoaJuridica.Name = "RadioButtonPessoaJuridica";
            RadioButtonPessoaJuridica.Size = new Size(35, 19);
            RadioButtonPessoaJuridica.TabIndex = 1;
            RadioButtonPessoaJuridica.Text = "PJ";
            RadioButtonPessoaJuridica.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(CheckBoxEstrangeiroSim, 0, 0);
            tableLayoutPanel3.Location = new Point(220, 484);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(215, 73);
            tableLayoutPanel3.TabIndex = 20;
            // 
            // CheckBoxEstrangeiroSim
            // 
            CheckBoxEstrangeiroSim.Anchor = AnchorStyles.None;
            CheckBoxEstrangeiroSim.AutoSize = true;
            CheckBoxEstrangeiroSim.Location = new Point(84, 27);
            CheckBoxEstrangeiroSim.Name = "CheckBoxEstrangeiroSim";
            CheckBoxEstrangeiroSim.Size = new Size(46, 19);
            CheckBoxEstrangeiroSim.TabIndex = 0;
            CheckBoxEstrangeiroSim.Text = "Sim";
            CheckBoxEstrangeiroSim.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(LabelCEP, 0, 6);
            tableLayoutPanel8.Controls.Add(LabelEstado, 0, 5);
            tableLayoutPanel8.Controls.Add(LabelMunicipio, 0, 4);
            tableLayoutPanel8.Controls.Add(LabelBairro, 0, 3);
            tableLayoutPanel8.Controls.Add(LabelComplemento, 0, 2);
            tableLayoutPanel8.Controls.Add(LabelNumero, 0, 1);
            tableLayoutPanel8.Controls.Add(LabelLogradouro, 0, 0);
            tableLayoutPanel8.Location = new Point(447, -4);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 7;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Size = new Size(217, 561);
            tableLayoutPanel8.TabIndex = 21;
            // 
            // LabelCEP
            // 
            LabelCEP.Anchor = AnchorStyles.None;
            LabelCEP.AutoSize = true;
            LabelCEP.Font = new Font("Elephant", 14.25F);
            LabelCEP.Location = new Point(79, 508);
            LabelCEP.Name = "LabelCEP";
            LabelCEP.Size = new Size(58, 25);
            LabelCEP.TabIndex = 12;
            LabelCEP.Text = "CEP";
            // 
            // LabelEstado
            // 
            LabelEstado.Anchor = AnchorStyles.None;
            LabelEstado.AutoSize = true;
            LabelEstado.Font = new Font("Elephant", 14.25F);
            LabelEstado.Location = new Point(69, 427);
            LabelEstado.Name = "LabelEstado";
            LabelEstado.Size = new Size(79, 25);
            LabelEstado.TabIndex = 10;
            LabelEstado.Text = "Estado";
            // 
            // LabelMunicipio
            // 
            LabelMunicipio.Anchor = AnchorStyles.None;
            LabelMunicipio.AutoSize = true;
            LabelMunicipio.Font = new Font("Elephant", 14.25F);
            LabelMunicipio.Location = new Point(54, 347);
            LabelMunicipio.Name = "LabelMunicipio";
            LabelMunicipio.Size = new Size(108, 25);
            LabelMunicipio.TabIndex = 8;
            LabelMunicipio.Text = "Municipio";
            // 
            // LabelBairro
            // 
            LabelBairro.Anchor = AnchorStyles.None;
            LabelBairro.AutoSize = true;
            LabelBairro.Font = new Font("Elephant", 14.25F);
            LabelBairro.Location = new Point(70, 267);
            LabelBairro.Name = "LabelBairro";
            LabelBairro.Size = new Size(77, 25);
            LabelBairro.TabIndex = 6;
            LabelBairro.Text = "Bairro";
            // 
            // LabelComplemento
            // 
            LabelComplemento.Anchor = AnchorStyles.None;
            LabelComplemento.AutoSize = true;
            LabelComplemento.Font = new Font("Elephant", 14.25F);
            LabelComplemento.Location = new Point(37, 187);
            LabelComplemento.Name = "LabelComplemento";
            LabelComplemento.Size = new Size(143, 25);
            LabelComplemento.TabIndex = 4;
            LabelComplemento.Text = "Complemento";
            // 
            // LabelNumero
            // 
            LabelNumero.Anchor = AnchorStyles.None;
            LabelNumero.AutoSize = true;
            LabelNumero.Font = new Font("Elephant", 14.25F);
            LabelNumero.Location = new Point(63, 107);
            LabelNumero.Name = "LabelNumero";
            LabelNumero.Size = new Size(90, 25);
            LabelNumero.TabIndex = 2;
            LabelNumero.Text = "Número";
            // 
            // LabelLogradouro
            // 
            LabelLogradouro.Anchor = AnchorStyles.None;
            LabelLogradouro.AutoSize = true;
            LabelLogradouro.Font = new Font("Elephant", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelLogradouro.Location = new Point(45, 27);
            LabelLogradouro.Name = "LabelLogradouro";
            LabelLogradouro.Size = new Size(126, 25);
            LabelLogradouro.TabIndex = 0;
            LabelLogradouro.Text = "Logradouro";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(TextBoxMunicipio, 0, 4);
            tableLayoutPanel5.Controls.Add(TextBoxBairro, 0, 3);
            tableLayoutPanel5.Controls.Add(TextBoxComplemento, 0, 2);
            tableLayoutPanel5.Controls.Add(TextBoxNumero, 0, 1);
            tableLayoutPanel5.Controls.Add(TextBoxLogradouro, 0, 0);
            tableLayoutPanel5.Controls.Add(ComboBoxEstado, 0, 5);
            tableLayoutPanel5.Controls.Add(TextBoxCEP, 0, 6);
            tableLayoutPanel5.Location = new Point(670, -4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 7;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel5.Size = new Size(217, 561);
            tableLayoutPanel5.TabIndex = 22;
            // 
            // TextBoxMunicipio
            // 
            TextBoxMunicipio.Anchor = AnchorStyles.None;
            TextBoxMunicipio.Location = new Point(3, 348);
            TextBoxMunicipio.Name = "TextBoxMunicipio";
            TextBoxMunicipio.Size = new Size(211, 23);
            TextBoxMunicipio.TabIndex = 4;
            // 
            // TextBoxBairro
            // 
            TextBoxBairro.Anchor = AnchorStyles.None;
            TextBoxBairro.Location = new Point(3, 268);
            TextBoxBairro.Name = "TextBoxBairro";
            TextBoxBairro.Size = new Size(211, 23);
            TextBoxBairro.TabIndex = 3;
            // 
            // TextBoxComplemento
            // 
            TextBoxComplemento.Anchor = AnchorStyles.None;
            TextBoxComplemento.Location = new Point(53, 188);
            TextBoxComplemento.Name = "TextBoxComplemento";
            TextBoxComplemento.Size = new Size(111, 23);
            TextBoxComplemento.TabIndex = 2;
            // 
            // TextBoxNumero
            // 
            TextBoxNumero.Anchor = AnchorStyles.None;
            TextBoxNumero.Location = new Point(53, 108);
            TextBoxNumero.Name = "TextBoxNumero";
            TextBoxNumero.Size = new Size(111, 23);
            TextBoxNumero.TabIndex = 1;
            // 
            // TextBoxLogradouro
            // 
            TextBoxLogradouro.Anchor = AnchorStyles.None;
            TextBoxLogradouro.Location = new Point(3, 28);
            TextBoxLogradouro.Name = "TextBoxLogradouro";
            TextBoxLogradouro.Size = new Size(211, 23);
            TextBoxLogradouro.TabIndex = 0;
            // 
            // ComboBoxEstado
            // 
            ComboBoxEstado.Anchor = AnchorStyles.None;
            ComboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxEstado.FormattingEnabled = true;
            ComboBoxEstado.Items.AddRange(new object[] { "Acre-AC", "Alagoas-AL", "Amapá-AP", "Amazonas-AM", "Bahia-BA", "Ceará-CE", "Espírito Santo-ES", "Goiás-GO", "Maranhão-MA", "Mato Grosso-MT", "Mato Grosso do Sul-MS", "Minas Gerais-MG", "Pará-PA", "Paraíba-PB", "Paraná-PR", "Pernambuco-PE", "Piauí-PI", "Rio de Janeiro-RJ", "Rio Grande do Norte-RN", "Rio Grande do Sul-RS", "Rondônia-RO", "Roraima-RR", "Santa Catarina-SC", "São Paulo-SP", "Sergipe-SE", "Tocantins-TO", "Distrito Federal-DF" });
            ComboBoxEstado.Location = new Point(48, 428);
            ComboBoxEstado.Name = "ComboBoxEstado";
            ComboBoxEstado.Size = new Size(121, 23);
            ComboBoxEstado.TabIndex = 5;
            // 
            // TextBoxCEP
            // 
            TextBoxCEP.Anchor = AnchorStyles.None;
            TextBoxCEP.Location = new Point(74, 509);
            TextBoxCEP.Mask = "00000-9999";
            TextBoxCEP.Name = "TextBoxCEP";
            TextBoxCEP.Size = new Size(68, 23);
            TextBoxCEP.TabIndex = 6;
            // 
            // Botao_Cadastrar
            // 
            Botao_Cadastrar.Anchor = AnchorStyles.None;
            Botao_Cadastrar.Location = new Point(182, 24);
            Botao_Cadastrar.Name = "Botao_Cadastrar";
            Botao_Cadastrar.Size = new Size(75, 23);
            Botao_Cadastrar.TabIndex = 23;
            Botao_Cadastrar.Text = "Cadastrar";
            Botao_Cadastrar.UseVisualStyleBackColor = true;
            Botao_Cadastrar.Click += Botao_Cadastrar_Click;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(Botao_Cadastrar, 0, 0);
            tableLayoutPanel6.Location = new Point(447, 555);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(440, 72);
            tableLayoutPanel6.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(907, 579);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 25;
            label1.Text = "TUDO CERTO???";
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.AllowUserToAddRows = false;
            dataGridViewClientes.AllowUserToDeleteRows = false;
            dataGridViewClientes.AllowUserToResizeRows = false;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(907, 18);
            dataGridViewClientes.MultiSelect = false;
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.ReadOnly = true;
            dataGridViewClientes.Size = new Size(507, 539);
            dataGridViewClientes.TabIndex = 26;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1426, 626);
            Controls.Add(dataGridViewClientes);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel5);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel8);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel6);
            Name = "Form1";
            Text = "cadastro";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelNome;
        private Label LabelData;
        private Label LabelTelefone;
        private Label LabelEmail;
        private Label LabelGenero;
        private Label LabelNomeSocial;
        private Label LabelEtinia;
        private Label LabelEstrangeiro;
        private Label LabelTipo;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox TextBoxNome;
        private MaskedTextBox TextBoxData;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox TextBoxNomeSocial;
        private TextBox TextBoxEmail;
        private MaskedTextBox TextBoxTelefone;
        private ComboBox ComboBoxGenero;
        private ComboBox ComboBoxEtnia;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel3;
        private CheckBox CheckBoxEstrangeiroSim;
        private CheckBox CheckBoxEstrangeiroNão;
        private RadioButton radioButton1;
        private RadioButton RadioButtonPessoaJuridica;
        private TableLayoutPanel tableLayoutPanel8;
        private Label LabelCEP;
        private Label LabelEstado;
        private Label LabelMunicipio;
        private Label LabelBairro;
        private Label LabelComplemento;
        private Label LabelNumero;
        private Label LabelLogradouro;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox TextBoxMunicipio;
        private TextBox TextBoxBairro;
        private TextBox TextBoxComplemento;
        private TextBox TextBoxNumero;
        private TextBox TextBoxLogradouro;
        private ComboBox ComboBoxEstado;
        private MaskedTextBox TextBoxCEP;
        private RadioButton RadioButtonPessoaFisica;
        private Button Botao_Cadastrar;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label1;
        private DataGridView dataGridViewClientes;
    }
}
