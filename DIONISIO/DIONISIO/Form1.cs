using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIONISIO
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        private Dictionary<string, MaterialSkin.Controls.MaterialMaskedTextBox> campos;

        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange700, TextShade.WHITE);

            campos = new Dictionary<string, MaterialSkin.Controls.MaterialMaskedTextBox>
            {
                { "NOMBRE", materialMaskedTextBox1 },
                { "APELLIDO", materialMaskedTextBox2 },
                { "EMAIL", materialMaskedTextBox3 },
                { "PUESTO", materialMaskedTextBox4 },
                { "EMPRESA", materialMaskedTextBox5 },
                { "TELEFONO", materialMaskedTextBox6 },
                { "UBICACION", materialMaskedTextBox7 },
                { "CP", materialMaskedTextBox8 }
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                MessageBox.Show("Todos los campos son válidos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool validarCampos()
        {
            foreach (var campo in campos)
            {
                if (string.IsNullOrEmpty(campo.Value.Text.Trim()))
                {
                    MessageBox.Show($"Te falto llenar el campo {campo.Key}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void materialMaskedTextBox_Click(object sender, EventArgs e)
        {
            MaterialSkin.Controls.MaterialMaskedTextBox textBox = sender as MaterialSkin.Controls.MaterialMaskedTextBox;
            if (textBox != null)
            {
                string nuevaVia = textBox.Text.Trim();
                if (string.IsNullOrEmpty(nuevaVia))
                {
                    MessageBox.Show("Por favor, ingresa un nombre de vía de administración válido.");
                    return;
                }
            }
        }

        private void materialMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaterialSkin.Controls.MaterialMaskedTextBox textBox = sender as MaterialSkin.Controls.MaterialMaskedTextBox;
            if (textBox != null)
            {
                if (textBox == materialMaskedTextBox1 || textBox == materialMaskedTextBox2 || textBox == materialMaskedTextBox3 ||
                    textBox == materialMaskedTextBox7 || textBox == materialMaskedTextBox8)
                {
                    if (!Char.IsLetter(e.KeyChar) && !Char.IsSeparator(e.KeyChar) && !Char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                        MessageBox.Show("SOLO SE PUEDEN UTILIZAR LETRAS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (textBox == materialMaskedTextBox4 || textBox == materialMaskedTextBox6 || textBox == materialMaskedTextBox9 ||
                         textBox == materialMaskedTextBox10 || textBox == materialMaskedTextBox11 || textBox == materialMaskedTextBox12 ||
                         textBox == materialMaskedTextBox13 || textBox == materialMaskedTextBox14)
                {
                    if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                        MessageBox.Show("SOLO SE PUEDEN UTILIZAR NUMEROS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        // Eventos Click para cada MaterialMaskedTextBox
        private void materialMaskedTextBox1_Click(object sender, EventArgs e) => materialMaskedTextBox_Click(sender, e);
        private void materialMaskedTextBox2_Click(object sender, EventArgs e) => materialMaskedTextBox_Click(sender, e);
        private void materialMaskedTextBox3_Click(object sender, EventArgs e) => materialMaskedTextBox_Click(sender, e);
        private void materialMaskedTextBox4_Click(object sender, EventArgs e) => materialMaskedTextBox_Click(sender, e);
        private void materialMaskedTextBox5_Click(object sender, EventArgs e) => materialMaskedTextBox_Click(sender, e);
        private void materialMaskedTextBox6_Click(object sender, EventArgs e) => materialMaskedTextBox_Click(sender, e);
        private void materialMaskedTextBox7_Click(object sender, EventArgs e) => materialMaskedTextBox_Click(sender, e);
        private void materialMaskedTextBox8_Click(object sender, EventArgs e) => materialMaskedTextBox_Click(sender, e);
        private void materialMaskedTextBox9_Click(object sender, EventArgs e) => materialMaskedTextBox_Click(sender, e);
        private void materialMaskedTextBox10_Click(object sender, EventArgs e) => materialMaskedTextBox_Click(sender, e);
        private void materialMaskedTextBox11_Click(object sender, EventArgs e) => materialMaskedTextBox_Click(sender, e);
        private void materialMaskedTextBox12_Click(object sender, EventArgs e) => materialMaskedTextBox_Click(sender, e);
        private void materialMaskedTextBox13_Click(object sender, EventArgs e) => materialMaskedTextBox_Click(sender, e);
        private void materialMaskedTextBox14_Click(object sender, EventArgs e) => materialMaskedTextBox_Click(sender, e);

        // Eventos KeyPress para cada MaterialMaskedTextBox
        private void materialMaskedTextBox1_KeyPress(object sender, KeyPressEventArgs e) => materialMaskedTextBox_KeyPress(sender, e);
        private void materialMaskedTextBox2_KeyPress(object sender, KeyPressEventArgs e) => materialMaskedTextBox_KeyPress(sender, e);
        private void materialMaskedTextBox3_KeyPress(object sender, KeyPressEventArgs e) => materialMaskedTextBox_KeyPress(sender, e);
        private void materialMaskedTextBox4_KeyPress(object sender, KeyPressEventArgs e) => materialMaskedTextBox_KeyPress(sender, e);
        private void materialMaskedTextBox5_KeyPress(object sender, KeyPressEventArgs e) => materialMaskedTextBox_KeyPress(sender, e);
        private void materialMaskedTextBox6_KeyPress(object sender, KeyPressEventArgs e) => materialMaskedTextBox_KeyPress(sender, e);
        private void materialMaskedTextBox7_KeyPress(object sender, KeyPressEventArgs e) => materialMaskedTextBox_KeyPress(sender, e);
        private void materialMaskedTextBox8_KeyPress(object sender, KeyPressEventArgs e) => materialMaskedTextBox_KeyPress(sender, e);
        private void materialMaskedTextBox9_KeyPress(object sender, KeyPressEventArgs e) => materialMaskedTextBox_KeyPress(sender, e);
        private void materialMaskedTextBox10_KeyPress(object sender, KeyPressEventArgs e) => materialMaskedTextBox_KeyPress(sender, e);
        private void materialMaskedTextBox11_KeyPress(object sender, KeyPressEventArgs e) => materialMaskedTextBox_KeyPress(sender, e);
        private void materialMaskedTextBox12_KeyPress(object sender, KeyPressEventArgs e) => materialMaskedTextBox_KeyPress(sender, e);
        private void materialMaskedTextBox13_KeyPress(object sender, KeyPressEventArgs e) => materialMaskedTextBox_KeyPress(sender, e);
        private void materialMaskedTextBox14_KeyPress(object sender, KeyPressEventArgs e) => materialMaskedTextBox_KeyPress(sender, e);

        private void materialButton3_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}