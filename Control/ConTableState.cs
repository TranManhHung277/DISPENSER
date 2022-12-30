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
    public partial class ConTableState : UserControl
    {
        private TableLayoutPanel table;
        private int arrayX1;
        private int arrayY1;
        private int arrayX2;
        private int arrayY2;
        private int row;
        private int col;
        private int prdCount = 0;
        private int index = -1;
        private string[] display = new string[3] { "-", "OK", "NG" };
        public ConTableState()
        {
            InitializeComponent();
            dgvData.AutoGenerateColumns = false;
            dgvData.AllowUserToAddRows = false;
            RunProgram.Instance.OnStartUp += ClearRow;
            RunProgram.Instance.OnStartUp += AddRow;
            RunProgram.Instance.OnStartUp += UpdateRow;
            //CreateTable();
        }
        private void ClearRow()
        {
            if(RunProgram._readPLC[4200] == 0 && index != -1)
            {
                dgvData.Rows.Clear();
                index = -1;
                for (int i = 0; i < arrayX2; i++)
                {
                    for (int j = 0; j < arrayY2; j++)
                    {
                        table.GetControlFromPosition(j, i).BackColor = Color.White;
                    }

                }
            }
        }
        private void AddRow()
        {
            if(RunProgram._readPLC[4200] != prdCount)
            {
                index++;
                prdCount = RunProgram._readPLC[4200];
                dgvData.Rows.Insert(0, 
                    prdCount,
                    UIControl.UILabel.Int16String(RunProgram._readPLC[4202], display),
                    UIControl.UILabel.Int16String(RunProgram._readPLC[4203], display),
                    UIControl.UILabel.Int16String(RunProgram._readPLC[4204], display),
                    UIControl.UILabel.Int16String(RunProgram._readPLC[4205], display),
                    UIControl.UILabel.Int16String(RunProgram._readPLC[4206], display)
                );
                // dgvData. = true;
                if (prdCount % (arrayY1* arrayY2) == 0)
                {
                    col = (arrayY1 * arrayY2);
                    row = (prdCount - arrayY1 * arrayY2) / (arrayY1 * arrayY2) + 1;
                }
                else
                {
                    col = prdCount % (arrayY1 * arrayY2);
                    row = prdCount / (arrayY1 * arrayY2) + 1;
                }
                
                for (int i = 1; i < dgvData.RowCount;i++)
                {
                    int y;
                    int x;
                    int data = (int)dgvData[0, i].Value;
                    if (data % (arrayY1 * arrayY2) == 0)
                    {
                        y = arrayY1 * arrayY2 - 1;
                        x = (data - arrayY1 * arrayY2) / (arrayY1 * arrayY2);
                    }
                    else
                    {
                        y = data % (arrayY1 * arrayY2) - 1;
                        x = data / (arrayY1 * arrayY2);
                    }
                    if(x < (arrayX1 * arrayX2) && y < (arrayY1 * arrayY2))
                    {
                        int result = 0;
                        bool NG = false;
                        for (int j = 1; j < 6; j++)
                        {
                            if ((string)dgvData[j, i].Value == "OK") result++;
                            if ((string)dgvData[j, i].Value == "NG") NG = true;
                        }
                        if (result == 0) table.GetControlFromPosition(y, x).BackColor = Color.White;
                        else if (NG) table.GetControlFromPosition(y, x).BackColor = Color.Red;
                        else table.GetControlFromPosition(y, x).BackColor = Color.Green;
                    }    
                    
                }    
            }
            
        }
        private void UpdateRow()
        {
            try
            {
                if(index >= 0)
                {
                    dgvData.Rows[0].Cells[1].Value = UIControl.UILabel.Int16String(RunProgram._readPLC[4202], display);
                    dgvData.Rows[0].Cells[2].Value = UIControl.UILabel.Int16String(RunProgram._readPLC[4203], display);
                    dgvData.Rows[0].Cells[3].Value = UIControl.UILabel.Int16String(RunProgram._readPLC[4204], display);
                    dgvData.Rows[0].Cells[4].Value = UIControl.UILabel.Int16String(RunProgram._readPLC[4205], display);
                    dgvData.Rows[0].Cells[5].Value = UIControl.UILabel.Int16String(RunProgram._readPLC[4206], display);
                }
            }
            catch
            {

            }
        }
        private void CreateTable()
        {
            try
            {
                tableLayoutPanel1.Controls.Remove(table);
            }
            catch
            {

            }
            arrayX1 = (int)RunProgram.ModelActive.ArrayX1;
            arrayY1 = (int)RunProgram.ModelActive.ArrayY1;
            arrayX2 = (int)RunProgram.ModelActive.ArrayX2;
            arrayY2 = (int)RunProgram.ModelActive.ArrayY2;
            table = new TableLayoutPanel();
            table.Dock = DockStyle.Fill;
            table.ColumnCount = arrayY2* arrayY1;
            table.RowCount = arrayX2* arrayX1;
            for (int i = 0; i < arrayX1* arrayX2; i++)
            {
                table.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / arrayX1* arrayX2));
            }
            for (int j = 0; j < arrayY1*arrayY2; j++)
            {
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / arrayY1* arrayY2));
            }
            for (int i = 0; i < arrayX1*arrayX2; i++)
            {
                for (int j = 0; j < arrayY1*arrayY2; j++)
                {
                    table.Controls.Add(new Panel() { Dock = DockStyle.Fill }, j, i);
                }

            }
            table.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayoutPanel1.Controls.Add(table,1,0);
            //this.Controls.Add(table);

        }
        private void timerState_Tick(object sender, EventArgs e)
        {
            if(RunProgram.ChangeModel)
            {
                CreateTable();
                RunProgram.ChangeModel = false;
            }    
            else
            {
                if (row > 0 && row <= arrayX1*arrayX2 && col > 0 && col <= arrayY1*arrayY2)
                {
                    if (table.GetControlFromPosition(col - 1, row - 1).BackColor == Color.White)
                        table.GetControlFromPosition(col - 1, row - 1).BackColor = Color.Blue;
                    else table.GetControlFromPosition(col - 1, row - 1).BackColor = Color.White;
                }
            }
            
        }

        private void ConTableState_Load(object sender, EventArgs e)
        {
            timerState.Start();
        }
    }
}
