using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DigiCompI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Font = new Font(Font.Name, 8.25f * 96f / CreateGraphics().DpiX, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int regA;
            int regB;
            int regC;
            Boolean setATrue;
            Boolean setAFalse;
            Boolean setBTrue;
            Boolean setBFalse;
            Boolean setCTrue;
            Boolean setCFalse;
            Boolean reg1True;
            Boolean reg2True;
            Boolean reg3True;
            Boolean reg4True;
            Boolean reg5True;
            Boolean reg6True;
            regA = Convert.ToInt32(outputA.Text);
            regB = Convert.ToInt32(outputB.Text);
            regC = Convert.ToInt32(outputC.Text);
            setATrue = false;
            setAFalse = false;
            setBTrue = false;
            setBFalse = false;
            setCTrue = false;
            setCFalse = false;
            reg1True = false;
            reg2True = false;
            reg3True = false;
            reg4True = false;
            reg5True = false;
            reg6True = false;
            if (((regA == 0 && regA1False.Checked) ||
                 (regA == 0 && !regA1True.Checked) ||
                 (regA == 1 && regA1True.Checked)  ||
                 (regA == 1 && !regA1False.Checked)) &&
                ((regB == 0 && regB1False.Checked) ||
                 (regB == 0 && !regB1True.Checked) ||
                 (regB == 1 && regB1True.Checked)  ||
                 (regB == 1 && !regB1False.Checked)) &&
                ((regC == 0 && regC1False.Checked) ||
                 (regC == 0 && !regC1True.Checked) ||
                 (regC == 1 && regC1True.Checked)  ||
                 (regC == 1 && !regC1False.Checked))) reg1True = true;
            if (((regA == 0 && regA2False.Checked) ||
                 (regA == 0 && !regA2True.Checked) ||
                 (regA == 1 && regA2True.Checked) ||
                 (regA == 1 && !regA2False.Checked)) &&
                ((regB == 0 && regB2False.Checked) ||
                 (regB == 0 && !regB2True.Checked) ||
                 (regB == 1 && regB2True.Checked) ||
                 (regB == 1 && !regB2False.Checked)) &&
                ((regC == 0 && regC2False.Checked) ||
                 (regC == 0 && !regC2True.Checked) ||
                 (regC == 1 && regC2True.Checked) ||
                 (regC == 1 && !regC2False.Checked))) reg2True = true;

            if (((regA == 0 && regA3False.Checked) ||
                 (regA == 0 && !regA3True.Checked) ||
                 (regA == 1 && regA3True.Checked) ||
                 (regA == 1 && !regA3False.Checked)) &&
                ((regB == 0 && regB3False.Checked) ||
                 (regB == 0 && !regB3True.Checked) ||
                 (regB == 1 && regB3True.Checked) ||
                 (regB == 1 && !regB3False.Checked)) &&
                ((regC == 0 && regC3False.Checked) ||
                 (regC == 0 && !regC3True.Checked) ||
                 (regC == 1 && regC3True.Checked) ||
                 (regC == 1 && !regC3False.Checked))) reg3True = true;
            if (((regA == 0 && regA4False.Checked) ||
                 (regA == 0 && !regA4True.Checked) ||
                 (regA == 1 && regA4True.Checked) ||
                 (regA == 1 && !regA4False.Checked)) &&
                ((regB == 0 && regB4False.Checked) ||
                 (regB == 0 && !regB4True.Checked) ||
                 (regB == 1 && regB4True.Checked) ||
                 (regB == 1 && !regB4False.Checked)) &&
                ((regC == 0 && regC4False.Checked) ||
                 (regC == 0 && !regC4True.Checked) ||
                 (regC == 1 && regC4True.Checked) ||
                 (regC == 1 && !regC4False.Checked))) reg4True = true;

            if (((regA == 0 && regA5False.Checked) ||
                 (regA == 0 && !regA5True.Checked) ||
                 (regA == 1 && regA5True.Checked) ||
                 (regA == 1 && !regA5False.Checked)) &&
                ((regB == 0 && regB5False.Checked) ||
                 (regB == 0 && !regB5True.Checked) ||
                 (regB == 1 && regB5True.Checked) ||
                 (regB == 1 && !regB5False.Checked)) &&
                ((regC == 0 && regC5False.Checked) ||
                 (regC == 0 && !regC5True.Checked) ||
                 (regC == 1 && regC5True.Checked) ||
                 (regC == 1 && !regC5False.Checked))) reg5True = true;
            if (((regA == 0 && regA6False.Checked) ||
                 (regA == 0 && !regA6True.Checked) ||
                 (regA == 1 && regA6True.Checked) ||
                 (regA == 1 && !regA6False.Checked)) &&
                ((regB == 0 && regB6False.Checked) ||
                 (regB == 0 && !regB6True.Checked) ||
                 (regB == 1 && regB6True.Checked) ||
                 (regB == 1 && !regB6False.Checked)) &&
                ((regC == 0 && regC6False.Checked) ||
                 (regC == 0 && !regC6True.Checked) ||
                 (regC == 1 && regC6True.Checked) ||
                 (regC == 1 && !regC6False.Checked))) reg6True = true;

            if (or1Enable.Checked)
            {
                if (reg1True || reg2True)
                {
                    if (or1Reset.Checked && regA1Set.Checked) setAFalse = true;
                    if (or1Reset.Checked && regB1Set.Checked) setBFalse = true;
                    if (or1Reset.Checked && regC1Set.Checked) setCFalse = true;
                    if (or1Set.Checked && regA2Set.Checked) setATrue = true;
                    if (or1Set.Checked && regB2Set.Checked) setBTrue = true;
                    if (or1Set.Checked && regC2Set.Checked) setCTrue = true;
                }
            }
            else
            {
                if (regA1Set.Checked && reg1True) setAFalse = true;
                if (regB1Set.Checked && reg1True) setBFalse = true;
                if (regC1Set.Checked && reg1True) setCFalse = true;
                if (regA2Set.Checked && reg2True) setATrue = true;
                if (regB2Set.Checked && reg2True) setBTrue = true;
                if (regC2Set.Checked && reg2True) setCTrue = true;
            }
            if (or2Enable.Checked)
            {
                if (reg3True || reg4True)
                {
                    if (or2Reset.Checked && regA3Set.Checked) setAFalse = true;
                    if (or2Reset.Checked && regB3Set.Checked) setBFalse = true;
                    if (or2Reset.Checked && regC3Set.Checked) setCFalse = true;
                    if (or2Set.Checked && regA4Set.Checked) setATrue = true;
                    if (or2Set.Checked && regB4Set.Checked) setBTrue = true;
                    if (or2Set.Checked && regC4Set.Checked) setCTrue = true;
                }
            }
            else
            {
                if (regA3Set.Checked && reg3True) setAFalse = true;
                if (regB3Set.Checked && reg3True) setBFalse = true;
                if (regC3Set.Checked && reg3True) setCFalse = true;
                if (regA4Set.Checked && reg4True) setATrue = true;
                if (regB4Set.Checked && reg4True) setBTrue = true;
                if (regC4Set.Checked && reg4True) setCTrue = true;
            }
            if (or3Enable.Checked)
            {
                if (reg5True || reg6True)
                {
                    if (or2Reset.Checked && regA5Set.Checked) setAFalse = true;
                    if (or2Reset.Checked && regB5Set.Checked) setBFalse = true;
                    if (or2Reset.Checked && regC5Set.Checked) setCFalse = true;
                    if (or2Set.Checked && regA6Set.Checked) setATrue = true;
                    if (or2Set.Checked && regB6Set.Checked) setBTrue = true;
                    if (or2Set.Checked && regC6Set.Checked) setCTrue = true;
                }
            }
            else
            {
                if (regA5Set.Checked && reg5True) setAFalse = true;
                if (regB5Set.Checked && reg5True) setBFalse = true;
                if (regC5Set.Checked && reg5True) setCFalse = true;
                if (regA6Set.Checked && reg6True) setATrue = true;
                if (regB6Set.Checked && reg6True) setBTrue = true;
                if (regC6Set.Checked && reg6True) setCTrue = true;
            }

            if (setATrue && !setAFalse) outputA.Text = "1";
            if (!setATrue && setAFalse) outputA.Text = "0";
            if (setBTrue && !setBFalse) outputB.Text = "1";
            if (!setBTrue && setBFalse) outputB.Text = "0";
            if (setCTrue && !setCFalse) outputC.Text = "1";
            if (!setCTrue && setCFalse) outputC.Text = "0";
        }

        private void regA1True_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regA1True.Checked) regA1False.Checked = false;
        }

        private void regA1False_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regA1False.Checked) regA1True.Checked = false;
        }

        private void regB1True_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regB1True.Checked) regB1False.Checked = false;
        }

        private void regB1False_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regB1False.Checked) regB1True.Checked = false;
        }

        private void regC1True_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regC1True.Checked) regC1False.Checked = false;
        }

        private void regC1False_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regC1False.Checked) regC1True.Checked = false;
        }

        private void regA2True_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regA2True.Checked) regA2False.Checked = false;
        }

        private void regA2False_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regA2False.Checked) regA2True.Checked = false;
        }

        private void regB2True_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regB2True.Checked) regB2False.Checked = false;
        }

        private void regB2False_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regB2False.Checked) regB2True.Checked = false;
        }

        private void regC2True_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regC2True.Checked) regC2False.Checked = false;
        }

        private void regC2False_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regC2False.Checked) regC2True.Checked = false;
        }

        private void outputA_MouseClick(object sender, MouseEventArgs e)
        {
            outputA.Text = (outputA.Text == "0") ? "1" : "0";
        }

        private void outputB_MouseClick(object sender, MouseEventArgs e)
        {
            outputB.Text = (outputB.Text == "0") ? "1" : "0";
        }

        private void outputC_MouseClick(object sender, MouseEventArgs e)
        {
            outputC.Text = (outputC.Text == "0") ? "1" : "0";
        }

        private void regA3True_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regA3True.Checked) regA3False.Checked = false;
        }

        private void regA3False_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regA3False.Checked) regA3True.Checked = false;
        }

        private void regB3True_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regB3True.Checked) regB3False.Checked = false;
        }

        private void regB3False_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regB3False.Checked) regB3True.Checked = false;
        }

        private void regC3True_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regC3True.Checked) regC3False.Checked = false;
        }

        private void regC3False_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regC3False.Checked) regC3True.Checked = false;
        }

        private void regA4True_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regA4True.Checked) regA4False.Checked = false;
        }

        private void regA4False_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regA4False.Checked) regA4True.Checked = false;
        }

        private void regB4True_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regB4True.Checked) regB4False.Checked = false;
        }

        private void regB4False_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regB4False.Checked) regB4True.Checked = false;
        }

        private void regC4True_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regC4True.Checked) regC4False.Checked = false;
        }

        private void regC4False_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regC4False.Checked) regC4True.Checked = false;
        }

        private void regA5True_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regA5True.Checked) regA5False.Checked = false;
        }

        private void regA5False_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regA5False.Checked) regA5True.Checked = false;
        }

        private void regB5True_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regB5True.Checked) regB5False.Checked = false;
        }

        private void regB5False_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regB5False.Checked) regB5True.Checked = false;
        }

        private void regC5True_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regC5True.Checked) regC5False.Checked = false;
        }

        private void regC5False_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regC5False.Checked) regC5True.Checked = false;
        }

        private void regA6True_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regA6True.Checked) regA6False.Checked = false;
        }

        private void regA6False_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regA6False.Checked) regA6True.Checked = false;
        }

        private void regB6True_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regB6True.Checked) regB6False.Checked = false;
        }

        private void regB6False_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regB6False.Checked) regB6True.Checked = false;
        }

        private void regC6True_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regC6True.Checked) regC6False.Checked = false;
        }

        private void regC6False_MouseDown(object sender, MouseEventArgs e)
        {
            if (!regC6False.Checked) regC6True.Checked = false;
        }

        private void or1Reset_MouseDown(object sender, MouseEventArgs e)
        {
            if (!or1Reset.Checked) or1Set.Checked = false;
        }

        private void or1Set_MouseDown(object sender, MouseEventArgs e)
        {
            if (!or1Set.Checked) or1Reset.Checked = false;
        }

        private void or2Reset_MouseDown(object sender, MouseEventArgs e)
        {
            if (!or2Reset.Checked) or2Set.Checked = false;
        }

        private void or2Set_MouseDown(object sender, MouseEventArgs e)
        {
            if (!or2Set.Checked) or2Reset.Checked = false;
        }

        private void or3Reset_MouseDown(object sender, MouseEventArgs e)
        {
            if (!or3Reset.Checked) or3Set.Checked = false;
        }

        private void or3Set_MouseDown(object sender, MouseEventArgs e)
        {
            if (!or3Set.Checked) or3Reset.Checked = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            BinaryWriter file;
            FileStream fs;
            saveFileDialog1.Filter = "DCI files|*.dci";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Text = "Digi-Comp I - " + openFileDialog1.FileName;
                fs = File.Create(saveFileDialog1.FileName, 1024, FileOptions.None);
                file = new BinaryWriter(fs);
                file.Write(or1Enable.Checked);
                file.Write(or2Enable.Checked);
                file.Write(or3Enable.Checked);
                file.Write(or1Reset.Checked);
                file.Write(or2Reset.Checked);
                file.Write(or3Reset.Checked);
                file.Write(or1Set.Checked);
                file.Write(or2Set.Checked);
                file.Write(or3Set.Checked);
                file.Write(regA1False.Checked);
                file.Write(regA1True.Checked);
                file.Write(regA1Set.Checked);
                file.Write(regA2False.Checked);
                file.Write(regA2True.Checked);
                file.Write(regA2Set.Checked);
                file.Write(regA3False.Checked);
                file.Write(regA3True.Checked);
                file.Write(regA3Set.Checked);
                file.Write(regA4False.Checked);
                file.Write(regA4True.Checked);
                file.Write(regA4Set.Checked);
                file.Write(regA5False.Checked);
                file.Write(regA5True.Checked);
                file.Write(regA5Set.Checked);
                file.Write(regA6False.Checked);
                file.Write(regA6True.Checked);
                file.Write(regA6Set.Checked);
                file.Write(regB1False.Checked);
                file.Write(regB1True.Checked);
                file.Write(regB1Set.Checked);
                file.Write(regB2False.Checked);
                file.Write(regB2True.Checked);
                file.Write(regB2Set.Checked);
                file.Write(regB3False.Checked);
                file.Write(regB3True.Checked);
                file.Write(regB3Set.Checked);
                file.Write(regB4False.Checked);
                file.Write(regB4True.Checked);
                file.Write(regB4Set.Checked);
                file.Write(regB5False.Checked);
                file.Write(regB5True.Checked);
                file.Write(regB5Set.Checked);
                file.Write(regB6False.Checked);
                file.Write(regB6True.Checked);
                file.Write(regB6Set.Checked);
                file.Write(regC1False.Checked);
                file.Write(regC1True.Checked);
                file.Write(regC1Set.Checked);
                file.Write(regC2False.Checked);
                file.Write(regC2True.Checked);
                file.Write(regC2Set.Checked);
                file.Write(regC3False.Checked);
                file.Write(regC3True.Checked);
                file.Write(regC3Set.Checked);
                file.Write(regC4False.Checked);
                file.Write(regC4True.Checked);
                file.Write(regC4Set.Checked);
                file.Write(regC5False.Checked);
                file.Write(regC5True.Checked);
                file.Write(regC5Set.Checked);
                file.Write(regC6False.Checked);
                file.Write(regC6True.Checked);
                file.Write(regC6Set.Checked);
                file.Close();
                fs.Close();
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            BinaryReader file;
            FileStream fs;
            openFileDialog1.Filter = "DCI files|*.dci";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Text = "Digi-Comp I - " + openFileDialog1.FileName;
                fs = File.Open(openFileDialog1.FileName, FileMode.Open);
                file = new BinaryReader(fs);
                or1Enable.Checked = file.ReadBoolean();
                or2Enable.Checked = file.ReadBoolean();
                or3Enable.Checked = file.ReadBoolean();
                or1Reset.Checked = file.ReadBoolean();
                or2Reset.Checked = file.ReadBoolean();
                or3Reset.Checked = file.ReadBoolean();
                or1Set.Checked = file.ReadBoolean();
                or2Set.Checked = file.ReadBoolean();
                or3Set.Checked = file.ReadBoolean();
                regA1False.Checked = file.ReadBoolean();
                regA1True.Checked = file.ReadBoolean();
                regA1Set.Checked = file.ReadBoolean();
                regA2False.Checked = file.ReadBoolean();
                regA2True.Checked = file.ReadBoolean();
                regA2Set.Checked = file.ReadBoolean();
                regA3False.Checked = file.ReadBoolean();
                regA3True.Checked = file.ReadBoolean();
                regA3Set.Checked = file.ReadBoolean();
                regA4False.Checked = file.ReadBoolean();
                regA4True.Checked = file.ReadBoolean();
                regA4Set.Checked = file.ReadBoolean();
                regA5False.Checked = file.ReadBoolean();
                regA5True.Checked = file.ReadBoolean();
                regA5Set.Checked = file.ReadBoolean();
                regA6False.Checked = file.ReadBoolean();
                regA6True.Checked = file.ReadBoolean();
                regA6Set.Checked = file.ReadBoolean();
                regB1False.Checked = file.ReadBoolean();
                regB1True.Checked = file.ReadBoolean();
                regB1Set.Checked = file.ReadBoolean();
                regB2False.Checked = file.ReadBoolean();
                regB2True.Checked = file.ReadBoolean();
                regB2Set.Checked = file.ReadBoolean();
                regB3False.Checked = file.ReadBoolean();
                regB3True.Checked = file.ReadBoolean();
                regB3Set.Checked = file.ReadBoolean();
                regB4False.Checked = file.ReadBoolean();
                regB4True.Checked = file.ReadBoolean();
                regB4Set.Checked = file.ReadBoolean();
                regB5False.Checked = file.ReadBoolean();
                regB5True.Checked = file.ReadBoolean();
                regB5Set.Checked = file.ReadBoolean();
                regB6False.Checked = file.ReadBoolean();
                regB6True.Checked = file.ReadBoolean();
                regB6Set.Checked = file.ReadBoolean();
                regC1False.Checked = file.ReadBoolean();
                regC1True.Checked = file.ReadBoolean();
                regC1Set.Checked = file.ReadBoolean();
                regC2False.Checked = file.ReadBoolean();
                regC2True.Checked = file.ReadBoolean();
                regC2Set.Checked = file.ReadBoolean();
                regC3False.Checked = file.ReadBoolean();
                regC3True.Checked = file.ReadBoolean();
                regC3Set.Checked = file.ReadBoolean();
                regC4False.Checked = file.ReadBoolean();
                regC4True.Checked = file.ReadBoolean();
                regC4Set.Checked = file.ReadBoolean();
                regC5False.Checked = file.ReadBoolean();
                regC5True.Checked = file.ReadBoolean();
                regC5Set.Checked = file.ReadBoolean();
                regC6False.Checked = file.ReadBoolean();
                regC6True.Checked = file.ReadBoolean();
                regC6Set.Checked = file.ReadBoolean();
                file.Close();
                fs.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Text = "Digi-Comp I";
            or1Enable.Checked = false;
            or2Enable.Checked = false;
            or3Enable.Checked = false;
            or1Reset.Checked = false;
            or2Reset.Checked = false;
            or3Reset.Checked = false;
            or1Set.Checked = false;
            or2Set.Checked = false;
            or3Set.Checked = false;
            regA1False.Checked = false;
            regA1True.Checked = false;
            regA1Set.Checked = false;
            regA2False.Checked = false;
            regA2True.Checked = false;
            regA2Set.Checked = false;
            regA3False.Checked = false;
            regA3True.Checked = false;
            regA3Set.Checked = false;
            regA4False.Checked = false;
            regA4True.Checked = false;
            regA4Set.Checked = false;
            regA5False.Checked = false;
            regA5True.Checked = false;
            regA5Set.Checked = false;
            regA6False.Checked = false;
            regA6True.Checked = false;
            regA6Set.Checked = false;
            regB1False.Checked = false;
            regB1True.Checked = false;
            regB1Set.Checked = false;
            regB2False.Checked = false;
            regB2True.Checked = false;
            regB2Set.Checked = false;
            regB3False.Checked = false;
            regB3True.Checked = false;
            regB3Set.Checked = false;
            regB4False.Checked = false;
            regB4True.Checked = false;
            regB4Set.Checked = false;
            regB5False.Checked = false;
            regB5True.Checked = false;
            regB5Set.Checked = false;
            regB6False.Checked = false;
            regB6True.Checked = false;
            regB6Set.Checked = false;
            regC1False.Checked = false;
            regC1True.Checked = false;
            regC1Set.Checked = false;
            regC2False.Checked = false;
            regC2True.Checked = false;
            regC2Set.Checked = false;
            regC3False.Checked = false;
            regC3True.Checked = false;
            regC3Set.Checked = false;
            regC4False.Checked = false;
            regC4True.Checked = false;
            regC4Set.Checked = false;
            regC5False.Checked = false;
            regC5True.Checked = false;
            regC5Set.Checked = false;
            regC6False.Checked = false;
            regC6True.Checked = false;
            regC6Set.Checked = false;
            outputA.Text = "0";
            outputB.Text = "0";
            outputC.Text = "0";
        }


 

    }
}
