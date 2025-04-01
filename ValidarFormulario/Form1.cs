using Validacoes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace ValidarFormulario;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

    }
    private void btnEnviar_Click(object sender, EventArgs e)
    {
        Usuario novoUsuario = new Usuario()
        {
            Nome = txtFullName.Text,
            Email = txtEmail.Text,
            Idd = txtIdd.Text,
            Senha = txtSenha.Text,
            ConfirmSenha = txtConfirmSenha.Text
            //Box = checkBoxTermo.Checked
        };

            ValidaNome(novoUsuario);
        if (ValidaNome(novoUsuario))
            return;

            ValidaEmail(novoUsuario);
        if (ValidaEmail(novoUsuario))
            return;

            ValidaIdd(novoUsuario);
        if (ValidaIdd(novoUsuario))
            return;

            ValidaSenha(novoUsuario);
        if (ValidaSenha(novoUsuario))
            return;

            ValidaConfirmSenha(novoUsuario);
        if (ValidaConfirmSenha(novoUsuario))
            return;

        MessageBox.Show("sucesso, todos os campos foram preenchidos com exito!");


    }
    public bool ValidaNome(Usuario nome)
    {
        if (txtFullName.Text == null || txtFullName.Text.Length < 3 || txtFullName.Text == "")

            return false;
        else

            return true;
    }

    public bool ValidaEmail(Usuario Email)
    {
        if (!txtEmail.Text.Contains("@"))
            return false;

        int posicaoDoArroba = txtEmail.Text.IndexOf("@");

        if (posicaoDoArroba > 0)
        {
            string restanteDoEmail = txtEmail.Text.Substring(posicaoDoArroba + 1);

            if (restanteDoEmail.Length > 1 &&
            restanteDoEmail[0] != '.' &&
            !restanteDoEmail.Contains("@") &&
            restanteDoEmail.Contains("."))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        return false;

    }

    public bool ValidaIdd(Usuario Idd)
    {
        int idade = Convert.ToInt32(txtIdd.Text);

        if (idade < 18 || idade > 100)
            return false;
        else
            return true;
    }

    public bool ValidaSenha(Usuario Senha)
    {
        if (txtSenha.Text.Length < 6)
            return false;
        else
            return true;
    }
    public bool ValidaConfirmSenha(Usuario Senha)
    {
        if (txtSenha.Text != txtConfirmSenha.Text)
            return false;
        else
            return true;
    }

    private void btnLimpar_Click(object sender, EventArgs e)
    {
        txtFullName.Text = "";
        txtEmail.Text = "";
        txtIdd.Text = "";
        txtSenha.Text = "";
        txtConfirmSenha.Text = "";
    }
}    

