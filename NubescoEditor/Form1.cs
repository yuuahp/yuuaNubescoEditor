using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NubescoEditor
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
           
        }

        public class Stringlist
        {
            
        }

        public string outputstring;
        public string lasttext;
        public string kaomojitext;

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (wcheck.Checked == true)
            {
                lasttext = "!w";
            }
            if (daaacheck.Checked == true)
            {
                lasttext = "だァーーーーーーーーーーーー!!!!!!!(ﾄｩﾙﾛﾛﾃｯﾃﾚｰwwwwwwﾃﾚﾃｯﾃﾃwwwwﾃﾃｰwww)wwwﾄｺｽﾞﾝﾄｺﾄｺｼﾞｮﾝwwwｽﾞｽﾞﾝwwwww(ﾃﾃﾛﾘﾄﾃｯﾃﾛﾃﾃｰwwww)";
            }
            if (nullcheck.Checked == true)
            {
                lasttext = null;
            }


            if (Nubescocheck.Checked == true)
            {
                kaomojitext = "└(՞ةڼ◔)┘";
            }
            if(IMOcheck.Checked == true)
            {
                kaomojitext = "└(┐┘)┌";
            }
            if(nicocheck.Checked == true)
            {
                kaomojitext = "( ◠‿◠ )";
            }

            outputstring = kaomojitext + input + lasttext;

            output.Text = outputstring;
         
        }
        
        //コピー処理
        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText (output.Text);
        }
        //コピー処理おわり！ｗ

        private void nicocheck_CheckedChanged(object sender, EventArgs e)
        {
            outputstring = "└(՞ةڼ◔)┘" + lasttext;
            output.Text = outputstring;
        }

        private void IMOcheck_CheckedChanged(object sender, EventArgs e)
        {
            outputstring = "└(┐┘)┌" + input.Text + lasttext;
            output.Text = outputstring;
        }

        private void Nubescocheck_CheckedChanged(object sender, EventArgs e)
        {
            outputstring = "( ◠‿◠ )" + input.Text + lasttext;
            output.Text = outputstring;
        }

        private void wcheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void daaacheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nullcheck_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
