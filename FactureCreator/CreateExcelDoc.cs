using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;
using System.Runtime.InteropServices; 

namespace FactureCreator
{
    public class CreateExcelDoc 
    { 
        private Excel.Application app = null; 
        private Excel.Workbook workbook = null; 
        private Excel.Worksheet worksheet = null; 
        private Excel.Range workSheet_range = null;

        public CreateExcelDoc() 
        { 
            createDoc(); 
        } 

        public void createDoc() 
        { 
            try 
            { 
                app = new Excel.Application(); 
                app.Visible = true;
                workbook = app.Workbooks.Add(1); 
                worksheet = (Excel.Worksheet)workbook.Sheets[1];
                app.Windows.get_Item(1).DisplayGridlines = false;

                // Paramètres d'impression
                app.PrintCommunication = false;
                worksheet.PageSetup.LeftMargin = app.Application.InchesToPoints(0);
                worksheet.PageSetup.RightMargin = app.Application.InchesToPoints(0);
                worksheet.PageSetup.TopMargin = app.Application.InchesToPoints(0);
                worksheet.PageSetup.BottomMargin = app.Application.InchesToPoints(0);
                worksheet.PageSetup.FooterMargin = app.Application.InchesToPoints(0);
                worksheet.PageSetup.HeaderMargin = app.Application.InchesToPoints(0);
                worksheet.PageSetup.CenterHorizontally = true;
                worksheet.PageSetup.Zoom = false;
                worksheet.PageSetup.FitToPagesWide = 1;
                worksheet.PageSetup.FitToPagesTall = 1;
                app.PrintCommunication = true;
                          
            } 
            catch (Exception e) 
            { 
                Console.Write("Error : {0}",e); 
            } 

            finally 
            { 
            } 
        }
 
        public Excel.Worksheet Worksheet
        {
            get { return worksheet; }
            set { worksheet = value; }
    }

        public Excel.Workbook Workbook
        {
            get { return workbook; }
            set { workbook = value; }
        }

        public void createHeaders(int row, int col, string htext, string cell1, 
        string cell2, int mergeColumns, string b, bool font, int size, string 
        fcolor) 
        { 
            worksheet.Cells[row, col] = htext; 
            workSheet_range = worksheet.get_Range(cell1, cell2); 
            workSheet_range.Merge(mergeColumns); 

            switch (b) 
            { 
                case "YELLOW": 
                    workSheet_range.Interior.Color = System.Drawing.Color.Yellow.ToArgb(); 
                    break; 
                case "GRAY": 
                    workSheet_range.Interior.Color = System.Drawing.Color.Gray.ToArgb(); 
                    break; 
                case "GAINSBORO": 
                    workSheet_range.Interior.Color = System.Drawing.Color.Gainsboro.ToArgb(); 
                    break; 
                case "Turquoise": 
                    workSheet_range.Interior.Color = System.Drawing.Color.Turquoise.ToArgb(); 
                    break; 
                case "PeachPuff": 
                    workSheet_range.Interior.Color = System.Drawing.Color.PeachPuff.ToArgb(); 
                    break; 

                case "BLUE":
                    workSheet_range.Interior.ColorIndex = 25;
                    break;

                default:
                    workSheet_range.Interior.Color = System.Drawing.Color.White.ToArgb();
                    break; 
            } 

            workSheet_range.Borders.Color = System.Drawing.Color.Black.ToArgb();
            workSheet_range.Font.Size = 8.5;
            workSheet_range.Font.Bold = font; 
            workSheet_range.ColumnWidth = size; 

            if (fcolor.Equals("")) 
            { 
                    workSheet_range.Font.Color = System.Drawing.Color.Black.ToArgb();
            } 

            else 
            {
                workSheet_range.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
            } 
        } 

        public void addData(int row, int col, string data, string cell1, string cell2, string format) 
        { 
            worksheet.Cells[row, col] = data; 
            workSheet_range = worksheet.get_Range(cell1, cell2); 
            workSheet_range.Borders.Color = System.Drawing.Color.Black.ToArgb(); 
            workSheet_range.NumberFormat = format;
            workSheet_range.Font.Size = 8.5;
        }

        public void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                Console.WriteLine("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        } 

        public void EraseBorders(string startcell, string endcell)
        {
            // Retire bordure gauche
            worksheet.get_Range(startcell, endcell).Borders.get_Item(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.Constants.xlNone;

            // Retire bordure droite
            worksheet.get_Range(startcell, endcell).Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.Constants.xlNone;

            // Retire bordure horizontale
            worksheet.get_Range(startcell, endcell).Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.Constants.xlNone;

            // Retire bordure verticale
            worksheet.get_Range(startcell, endcell).Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.Constants.xlNone;


        }

        public void BorderAround(string startcell, string endcell)
        {
            Excel.Range range = worksheet.get_Range(startcell, endcell);
            Excel.Borders borders = range.Borders;
            borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
            borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
            borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
            borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
            borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlLineStyleNone;
            borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlLineStyleNone;
            borders[Excel.XlBordersIndex.xlDiagonalUp].LineStyle = Excel.XlLineStyle.xlLineStyleNone;
            borders[Excel.XlBordersIndex.xlDiagonalDown].LineStyle = Excel.XlLineStyle.xlLineStyleNone;
            borders = null;
        }

        public void TopBorder(string startcell, string endcell)
        {
            // Afficher bordure du haut
            worksheet.get_Range(startcell, endcell).Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;
        }

        public void CenterText(string plage)
        {
            worksheet.get_Range(plage).HorizontalAlignment = Excel.Constants.xlCenter;
            worksheet.get_Range(plage).VerticalAlignment = Excel.Constants.xlCenter;
        }

        public void LeftText(string plage)
        {
            worksheet.get_Range(plage).HorizontalAlignment = Excel.Constants.xlLeft;
            worksheet.get_Range(plage).VerticalAlignment = Excel.Constants.xlCenter;
        }

        public void RightText(string plage)
        {
            worksheet.get_Range(plage).HorizontalAlignment = Excel.Constants.xlRight;
            worksheet.get_Range(plage).VerticalAlignment = Excel.Constants.xlCenter;
        }

        public void ColorGray_PartCell(string plage, int debut, int fin)
        {
            worksheet.get_Range(plage).get_Characters(debut, fin).Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gray);
        }
    } 
}
