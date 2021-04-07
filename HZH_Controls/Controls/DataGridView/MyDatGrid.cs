using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HZH_Controls.Controls
{
    public class MyDatGrid : System.Windows.Forms.DataGridView
    {
        protected override void OnCellPainting(DataGridViewCellPaintingEventArgs e)
        {
            base.OnCellPainting(e);
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // MyDatGrid
            // 
            this.RowTemplate.Height = 30;
            this.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.MyDatGrid_CellPainting);
            this.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.MyDatGrid_EditingControlShowing);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        private void MyDatGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (this.Columns["ContactName"].Index == e.ColumnIndex && e.RowIndex >= 0)
            {
                Rectangle newRect = new Rectangle(e.CellBounds.X + 1,
                    e.CellBounds.Y + 1, e.CellBounds.Width - 4,
                    e.CellBounds.Height - 4);

                using (
                    Brush gridBrush = new SolidBrush(this.GridColor),
                    backColorBrush = new SolidBrush(e.CellStyle.BackColor))
                {
                    using (Pen gridLinePen = new Pen(gridBrush))
                    {
                        // Erase the cell.
                        e.Graphics.FillRectangle(backColorBrush, e.CellBounds);

                        // Draw the grid lines (only the right and bottom lines;
                        // DataGridView takes care of the others).
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left,
                            e.CellBounds.Bottom - 1, e.CellBounds.Right - 1,
                            e.CellBounds.Bottom - 1);
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1,
                            e.CellBounds.Top, e.CellBounds.Right - 1,
                            e.CellBounds.Bottom);

                        // Draw the inset highlight box.
                        e.Graphics.DrawRectangle(Pens.Blue, newRect);

                        // Draw the text content of the cell, ignoring alignment.
                        if (e.Value != null)
                        {
                            e.Graphics.DrawString((String)e.Value, e.CellStyle.Font,
                                Brushes.Crimson, e.CellBounds.X + 2,
                                e.CellBounds.Y + 2, StringFormat.GenericDefault);
                        }
                        e.Handled = true;
                    }
                }
            }
        }

        private void MyDatGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var a = e.Control;
        }
    }
}
