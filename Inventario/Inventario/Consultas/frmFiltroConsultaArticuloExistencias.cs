﻿using CI.DAC;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CI.Consultas
{
    public partial class frmFiltroConsultaArticuloExistencias : Form
    {
        DataTable DTLote = new DataTable();
        DataTable DTBodega = new DataTable();

        string  sLote, sBodega ;
        int IdProducto = 0;

        List<object> valuesLote = new List<object>();
        List<object> valuesBodega = new List<object>();
        
        public frmFiltroConsultaArticuloExistencias(int IDProducto,String sLote,string sBodega)
        {
            InitializeComponent();
            this.sLote = sLote;
            this.sBodega = sBodega;
            this.IdProducto = IDProducto;
        }

        private void frmFiltroConsultaArticuloExistencias_Load(object sender, EventArgs e)
        {
            DTLote = clsLoteDAC.GetData(-1,IdProducto, "*", "*").Tables[0];
            Util.Util.ConfigLookupEdit(this.slkupLote, DTLote, "LoteProveedor", "IDLote", 350);
            Util.Util.ConfigLookupEditSetViewColumns(this.slkupLote, "[{'ColumnCaption':'IDLote','ColumnField':'IDLote','width':20},{'ColumnCaption':'Lote Proveedor','ColumnField':'LoteProveedor','width':90}]");
            this.slkupLote.Properties.View.OptionsSelection.MultiSelect = true;
            this.slkupLote.Properties.View.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;

            DTBodega = clsBodegaDAC.GetData(-1, "*", -1).Tables[0];
            Util.Util.ConfigLookupEdit(this.slkupBodega, DTBodega, "Descr", "IDBodega", 350);
            Util.Util.ConfigLookupEditSetViewColumns(this.slkupBodega, "[{'ColumnCaption':'IDBodega','ColumnField':'IDBodega','width':20},{'ColumnCaption':'Descripcion','ColumnField':'Descr','width':90}]");
            this.slkupBodega.Properties.View.OptionsSelection.MultiSelect = true;
            this.slkupBodega.Properties.View.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;

            setItemSelected(sLote, this.slkupLote);
            setItemSelected(sBodega, this.slkupBodega);
            
        }

        private List<int> GetSelection(string[] values, string fieldName, GridView view)
        {
            List<int> selection = new List<int>();
            foreach (string val in values)
            {
                for (int i = 0; i < view.RowCount; i++)
                {
                    if (view.GetRowCellValue(i, fieldName).ToString() == val)
                        selection.Add(i);
                }
            }
            return selection;
        }


        private String GetFieldFind(string Nombre)
        {
            if (Nombre == "slkupLote")
                return "IDLote";
            else if (Nombre == "slkupBodega")
                return "IDBodega";
            else
                return "";

        }

        private void setItemSelected(string sLst, SearchLookUpEdit crt)
        {
            if (sLst != "*")
            {
                //HabilitarControles(crt.Name, true);
                String[] valores = sLst.Split(',');
                crt.ShowPopup();
                crt.ClosePopup();
                GridView view = crt.Properties.View;

                List<int> selection = GetSelection(valores, GetFieldFind(crt.Name), view);
                foreach (int rowHandle in selection)
                {
                    view.SelectRow(rowHandle);
                }

            }
        }


        public String getLstFiltro(string sCampo)
        {
            String Result = "";
            switch (sCampo)
            {
                case "Lote":
                        Result = String.Join(",", valuesLote);
                    break;
                case "Bodega":
                        Result = String.Join(",", valuesBodega);
                    break;
                
            }

            return Result;
        }

       

        private void searchLookUpEdit1View_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            //Bodega
            GridView view = sender as GridView;
            object Valor;
            Valor = view.GetRowCellValue(e.ControllerRow, "IDLote");
            if (e.Action == CollectionChangeAction.Add)
                valuesLote.Add(Valor);
            else if (e.Action == CollectionChangeAction.Remove)
                valuesLote.Remove(Valor);
        }

        private void searchLookUpEdit2View_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            //Bodega
            GridView view = sender as GridView;
            object Valor;
            Valor = view.GetRowCellValue(e.ControllerRow, "IDBodega");
            if (e.Action == CollectionChangeAction.Add)
                valuesBodega.Add(Valor);
            else if (e.Action == CollectionChangeAction.Remove)
                valuesBodega.Remove(Valor);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Close();
        }
    }
}
