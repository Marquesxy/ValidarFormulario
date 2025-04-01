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
            ConfirmSenha = txtConfirmSenha.Text,
            BoxTrueFalse = checkBoxTermo.Checked
        };

        if (!ValidaNome(novoUsuario.Nome))
        {
            MessageBox.Show("Nome Invalido");
            return;
        }

        if (!ValidaEmail(novoUsuario.Email))
        {
            MessageBox.Show("Email Invalido");
            return;
        }

        if (!ValidaIdd(novoUsuario.Idd))
        {
            MessageBox.Show("Idade Invalido");
            return;
        }

        if (!ValidaSenha(novoUsuario.Senha))
        {
            MessageBox.Show("Senha Invalido");
            return;
        }

        if (!ValidaConfirmSenha(novoUsuario.ConfirmSenha))
        {
            MessageBox.Show("As senhas não condizem");
            return;
        }

        if (!ValidaTermo(novoUsuario))
        {
            MessageBox.Show("Impossivel continuar, Termo de Uso não aceito");
            return;
        }

        MessageBox.Show("Sucesso, todos os campos foram preenchidos com exito!");
    }
    public bool ValidaNome(string nome)
    {
        if (nome == null || nome.Length < 3 || nome == "")

            return false;
        else

            return true;
    }

    public bool ValidaEmail(string email)
    {
        if (!email.Contains("@"))
            return false;

        int posicaoDoArroba = email.IndexOf("@");

        if (posicaoDoArroba > 0)
        {
            string restanteDoEmail = email.Substring(posicaoDoArroba + 1);

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

    public bool ValidaIdd(string idd)
    {
        int idade = Convert.ToInt32(idd);

        if (idade < 18 || idade > 100)
            return false;
        else
            return true;
    }

    public bool ValidaSenha(string senha)
    {
        if (senha.Length < 6)
            return false;
        else
            return true;
    }
    public bool ValidaConfirmSenha(string ConfimSenha)
    {
        if (ConfimSenha != txtSenha.Text)
            return false;
        else
            return true;
    }

    public bool ValidaTermo(Usuario BoxTrueFalse)
    {
        return checkBoxTermo.Checked;
            
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

