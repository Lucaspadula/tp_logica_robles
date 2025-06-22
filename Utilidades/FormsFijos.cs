using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_logica_robles.Utilidades
{
    public static class FormsFijos
    {
        public static void ConfigurarFormFijo(Form form)
        {

            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.ShowIcon = false;
            form.ShowInTaskbar = false;
            form.SizeGripStyle = SizeGripStyle.Hide;
        }
    }
}
