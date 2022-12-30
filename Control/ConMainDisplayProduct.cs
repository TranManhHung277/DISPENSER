using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEMV_Dispencer_V1.Control
{
    public partial class ConMainDisplayProduct : UserControl
    {
        public ConMainDisplayProduct()
        {
            InitializeComponent();
            //Create_Table();
            Event();
        }
        private TableLayoutPanel table;
        private int arrayX1;
        private int arrayY1;
        private int arrayX2;
        private int arrayY2;
        private void Create_Table()
        {
            int x2 = (int)RunProgram.ModelActive.ArrayX2;
            int y2= (int)RunProgram.ModelActive.ArrayY2;
            for(int i = 0; i < x2; i++)
            {
                for(int j = 0; j < y2; j++)
                {
                    Label label = new Label();
                    label.AutoSize = false;
                    label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    label.Location = new System.Drawing.Point(30 * j, 30 * i);
                    label.Name = String.Format("lb{0}",i*y2+j+1);
                    label.Size = new System.Drawing.Size(30, 30);
                    label.TabIndex = 0;
                    label.Text = String.Format("{0}", i * y2 + j + 1);
                    label.BorderStyle = BorderStyle.FixedSingle;
                    this.Controls.Add(label);
                }    
                
            }    
        }
        private void Event()
        {
            arrayX1 = (int)RunProgram.ModelActive.ArrayX1;
            arrayY1 = (int)RunProgram.ModelActive.ArrayY1;
            arrayX2 = (int)RunProgram.ModelActive.ArrayX2;
            arrayY2 = (int)RunProgram.ModelActive.ArrayY2;
            table = new TableLayoutPanel();
            table.Dock = DockStyle.Fill;
            table.ColumnCount = arrayY2;
            table.RowCount = arrayX2;
            for (int i = 0; i < arrayX1* arrayX2; i++)
            {
                table.RowStyles.Add(new RowStyle(SizeType.Percent, 100/ arrayX1*arrayX2));
            }
            for (int j = 0; j < arrayY1* arrayY2; j++)
            {
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / arrayY1*arrayY2));
            }
            for (int i = 0; i < arrayX1 * arrayX2; i++)
            {
                for (int j = 0; j < arrayY1*arrayY2; j++)
                {
                    table.Controls.Add(new Panel() { Dock = DockStyle.Fill },j,i);
                }

            }
            table.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            this.Controls.Add(table);

        }

        private void ConMainDisplayProduct_Load(object sender, EventArgs e)
        {
           timerState.Start();
           
        }

        private void timerState_Tick(object sender, EventArgs e)
        {
            int x = (int)UIControl.UIValueTranform.Int32ToDouble(RunProgram._readPLC[4008], RunProgram._readPLC[4009], 100);
            int y = (int)UIControl.UIValueTranform.Int32ToDouble(RunProgram._readPLC[4010], RunProgram._readPLC[4011], 100);
            if (x > 0 && x <= arrayX2* arrayX1 && y > 0 && y <= arrayY1* arrayY2)
            {
                if (table.GetControlFromPosition(y-1,x-1).BackColor == Color.White)
                    table.GetControlFromPosition(y-1,x-1).BackColor = Color.Blue;
                else table.GetControlFromPosition(y-1,x-1).BackColor = Color.White;

            }
            
        }
    }
}
