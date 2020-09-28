using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.Handler;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.ComponentModel;  

namespace Util
{
 
        [ToolboxItem(true)]  
        public class S4UGridControl : GridControl
        {
            protected override BaseView CreateDefaultView()
            {
                return CreateView("S4UGridView");
            }
            protected override void RegisterAvailableViewsCore(InfoCollection collection)
            {
                base.RegisterAvailableViewsCore(collection);
                collection.Add(new MyGridViewInfoRegistrator());
            }
        }

        public class MyGridViewInfoRegistrator : GridInfoRegistrator
        {
            public override string ViewName { get { return "S4UGridView"; } }
            public override BaseView CreateView(GridControl grid)
            {
                return new MyGridView(grid as GridControl);
            }
        }
        public class MyGridView : GridView
        {
            public MyGridView(GridControl ownerGrid) : base(ownerGrid) { }
            public MyGridView() { }


            protected virtual bool RowEqual(int focusedRowHandle, int newRowHandle)
            {
                if (IsDesignMode)
                    return focusedRowHandle == newRowHandle;
                DataRow row1 = GetDataRow(focusedRowHandle);
                DataRow row2 = GetDataRow(newRowHandle);
                return row1 == row2;
            }

            protected override void DoChangeFocusedRowInternal(int newRowHandle, bool updateCurrentRow)
            {
                if (this.lockFocusedRowChange != 0) return;
                if (!IsValidRowHandle(newRowHandle))
                    newRowHandle = DevExpress.Data.DataController.InvalidRow;
                if (RowEqual(FocusedRowHandle, newRowHandle))
                    return;
                int currentRowHandle = FocusedRowHandle;
                BeginLockFocusedRowChange();
                try
                {
                    DoChangeFocusedRow(FocusedRowHandle, newRowHandle, updateCurrentRow);
                }
                finally
                {
                    EndLockFocusedRowChange();
                }
                RaiseFocusedRowChanged(currentRowHandle, newRowHandle);
            }
        }
   


}
