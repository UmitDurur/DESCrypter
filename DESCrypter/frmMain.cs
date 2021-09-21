using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESSifreleCoz
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCoz_Click(object sender, EventArgs e)
        {
            if (txtKey.Text.Length == 8)
                txtCikti.Text = DESCoz(txtGirdi.Text);

        }

        public string DESSifrele(string strGiris)
        {
            string sonuc = "";
            if (string.IsNullOrWhiteSpace(strGiris))
                throw new ArgumentNullException(nameof(strGiris),"Şifrelenecek veri yok");

            byte[] aryKey = Byte8(txtKey.Text); // BURAYA 8 bit string DEĞER GİRİN
            byte[] aryIV = Byte8(txtKey.Text); // BURAYA 8 bit string DEĞER GİRİN
            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, cryptoProvider.CreateEncryptor(aryKey, aryIV), CryptoStreamMode.Write);
            StreamWriter writer = new StreamWriter(cs);
            writer.Write(strGiris);
            writer.Flush();
            cs.FlushFinalBlock();
            writer.Flush();
            sonuc = Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
            writer.Dispose();
            cs.Dispose();
            ms.Dispose();
            return sonuc;
        }

        public string DESCoz(string strGiris)
        {
            string strSonuc = "";
            if (string.IsNullOrWhiteSpace(strGiris))
            {
                throw new ArgumentNullException(nameof(strGiris),"Şifrelenecek veri yok.");
            }
            else
            {
                byte[] aryKey = Byte8(txtKey.Text);
                byte[] aryIV = Byte8(txtKey.Text);
                DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
                MemoryStream ms = new MemoryStream(Convert.FromBase64String(strGiris));
                CryptoStream cs = new CryptoStream(ms, cryptoProvider.CreateDecryptor(aryKey, aryIV), CryptoStreamMode.Read);
                StreamReader reader = new StreamReader(cs);
                strSonuc = reader.ReadToEnd();
                reader.Dispose();
                cs.Dispose();
                ms.Dispose();
            }
            return strSonuc;
        }

        private byte[] ByteDonustur(string deger)
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            return ByteConverter.GetBytes(deger);
        }

        private byte[] Byte8(string deger)
        {
            char[] arrayChar = deger.ToCharArray();
            byte[] arrayByte = new byte[arrayChar.Length];
            for (int i = 0; i < arrayByte.Length; i++)
            {
                arrayByte[i] = Convert.ToByte(arrayChar[i]);
            }
            return arrayByte;
        }

        private void btnSifrele_Click(object sender, EventArgs e)
        {
            if (txtKey.Text.Length == 8)
                txtCikti.Text = DESSifrele(txtGirdi.Text);
        }
    }
}
