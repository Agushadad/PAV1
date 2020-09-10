﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV1_TP.Clases
{
    class TratamientosEspeciales
    {
        public enum Validacion { correcta, incorrecta }

        public Validacion validar (Control.ControlCollection controles)
        {
            foreach (var item in controles)
            {
                if(item.GetType().Name == "TextBox01")
                {
                    if(((TextBox01)item).Pp_validable == true)
                    {
                        if(((TextBox01)item).Text == "")
                        {
                            MessageBox.Show(((TextBox01)item).Pp_mensajeError);
                            ((TextBox01)item).Focus();
                            return Validacion.incorrecta;
                        }
                    }
                }
            }
            return Validacion.correcta;
        }
    }
}