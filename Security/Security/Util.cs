﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security
{
    public static class Acciones
    {
        public enum PrivilegiosGeneralesType
        {
            AccesoAlSistema = 1,
            ModificacionReportes =2,
            Contabilidad = 100
        }
        public enum PrivilegiosContableType
        {
            CatalogoCuentaContable = 101,
            AgregarCuentaContable = 102,
            EditarCuentaContable = 103,
            EliminarCuentaContable = 104,
            CatalogoCentroCosto = 105,
            AgregarCentroCosto = 106,
            EditarCentroCosto = 107,
            EliminarCentroCosto = 108,
            AsientodeDiario = 109,
            AgregarAsientodeDiario = 110,
            EditarAsientodeDiario = 111,
            EliminarAsientodeDiario = 112,
            MayorizarAsientodeDiario = 113,
            RegistrarTipoCambio=114,
            AnularAsientoMayorizado = 115,

        }
    }
}
