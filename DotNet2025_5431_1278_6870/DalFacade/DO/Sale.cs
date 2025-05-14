using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    /// :אובייקט מבצע המכיל את התכונות
    /// מזהה מבצע - מספור אוטומתי
    /// מזהה מוצר
    /// כמות נדרשת לקבלת המבצע
    /// מחיר כולל מבצע
    /// האם המבצע מיועד ללקוחות מועדון
    /// תאריך תחילת המבצע
    /// תאריך סיום המבצע
   public record Sale
        (int SaleCode,                    
        int ProductId,
        int QuantityForSale,
        double SalePrice,
        bool? IsClub,
        DateTime? StartSale = null,
        DateTime? EndSale = null)
    {
        

        //public Sale(int ProductId, int QuantityForSale,///האם זה מתנהג כבנאי מלא???
        //    int SalePrice,
        //    bool IsClub,
        //    DateTime StartSale,
        //    DateTime EndSale)
        //{
        //    this.SaleId = CODE++;
        //}
        public Sale(): this(0,0,0,0,false) 
        {
        }
    }
}
