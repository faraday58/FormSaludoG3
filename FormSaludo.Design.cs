using System;
using System.Windows.Forms;
using System.Drawing;
namespace FormSaludo
{
    partial class FormSaludo:Form
    {
        #region Atributos o Campos
        private Label etIntroduceNombre;
        private TextBox txtNombre;
        private Button btnAceptar;
        private Button btnLimpiar;
        #endregion
        #region Métodos
        private void IniciarComponentes()
        {

            this.Size=new Size(400, 300);
            this.Text = "FormSaludo";
            this.StartPosition = FormStartPosition.CenterScreen;



            etIntroduceNombre = new Label();
            etIntroduceNombre.Text = "Introduce tu nombre";
            etIntroduceNombre.Location = new Point(10,20);
            etIntroduceNombre.Size = new Size(180, 35);
            etIntroduceNombre.TextAlign = ContentAlignment.MiddleLeft;


            this.Controls.Add(etIntroduceNombre);

        }

        #endregion



    }
}
