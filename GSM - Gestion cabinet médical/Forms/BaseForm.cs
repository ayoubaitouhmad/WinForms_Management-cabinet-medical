using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSM___Gestion_cabinet_médical.Forms
{
    public class BaseForm : Form
    {
        protected void textboxStyling(TextBox textBox)
        {
            textBox.BackColor = Color.White;
            textBox.ForeColor = Color.Navy;
            textBox.Font = new Font("Segoe UI", 10F);
            textBox.BorderStyle = BorderStyle.FixedSingle;
        }

        protected void paneltStyling(Panel panel)
        {
            panel.BackColor = ColorTranslator.FromHtml("#E5E5E5");
        }
        protected void buttontStyling(Button button)
        {
            button.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            // Couleurs
            button.BackColor = ColorTranslator.FromHtml("#FCA311");
            button.ForeColor = ColorTranslator.FromHtml("#14213D");

            // Coins arrondis (nécessite OwnerDraw ou un custom control pour être *vraiment* arrondi)

            // Bordure & apparence
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;

            // Taille
            button.Padding = new Padding(10, 6, 10, 6); // simulate px-4 py-2
            button.AutoSize = true;


            button.Font = new Font("Segoe UI", 13F, FontStyle.Regular);


            // Effet de survol (hover)
            button.MouseEnter += (s, e) => {
                button.BackColor = ColorTranslator.FromHtml("#be7702");
                button.ForeColor = ColorTranslator.FromHtml("#000000");
            };
            button.MouseLeave += (s, e) => {
                button.BackColor = ColorTranslator.FromHtml("#FCA311");
                button.ForeColor = ColorTranslator.FromHtml("#14213D");
            };

        }
    }
}
