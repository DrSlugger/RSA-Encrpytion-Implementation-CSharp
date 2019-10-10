using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Crypto.Prng;

namespace RSAEncrpytionImplementation
{
    public partial class RSAImplementationForm : Form
    {
        private Dictionary<string, BigInteger> keyValuePairs;
        private SecureRandom random;
        public RSAImplementationForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            keyValuePairs = new Dictionary<string, BigInteger>();
            random = new SecureRandom();
            keyValuePairs = RSA.GenerateKeyPairs(random);
            string m = tbxEnteredText.Text;
            string encryptedText = RSA.Encrypt(m, keyValuePairs);
            string decryptedText = RSA.Decrypt(encryptedText, keyValuePairs);

            lblEnteredText.Text = m;

            lblEncryptedText.Text = encryptedText;
            lblDecryptedText.Text = decryptedText;
        }

        private void RSAImplementationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxEnteredText.Text = "";
            lblEnteredText.Text = "";
            lblEncryptedText.Text = "";
            lblDecryptedText.Text = "";
        }

        private void btnClearTBX_Click(object sender, EventArgs e)
        {
            tbxEnteredText.Text = "";
        }
    }
}
