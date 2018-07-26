using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptLibrary
{
    public class PenjualanDAO
    {
        public List<Penjualan> ListData { get; set; } = null;

        public bool ItemIsExist(Penjualan penjualan)
        {
            if (ListData?.Count > 0)
            {
                foreach (Penjualan item in ListData)
                {
                    if (item.Jumlah.ToLower().Trim().Equals(penjualan.Jumlah.ToLower().Trim()) &&
                            item.JenisMakanan.NamaMakanan.ToLower().Trim().Equals(penjualan.JenisMakanan.NamaMakanan.ToLower().Trim()))
                        return true;
                }
            }
            return false;
        }
        public bool InsertItem(Penjualan penjualan)
        {
            bool result = false;
            try
            {          
                ListData.Add(penjualan);
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public bool DeleteItem(Penjualan penjualan)
        {
            bool result = false;
            try
            {
                if (ItemIsExist(penjualan))
                {
                    Penjualan ToDelete = null;
                    for (int i = 0; i < ListData.Count; i++)
                    {
                        ToDelete = ListData[i];
                        if (ToDelete.Jumlah.ToLower().Trim().Equals(penjualan.Jumlah.ToLower().Trim()) &&
                            ToDelete.JenisMakanan.NamaMakanan.ToLower().Trim().Equals(penjualan.JenisMakanan.NamaMakanan.ToLower().Trim()))
                        {
                            break;
                        }
                    }
                    if (ToDelete != null) ListData.Remove(ToDelete);
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public bool UpdateItem(Penjualan lama, Penjualan baru)
        {
            bool result = false;
            try
            {
                if (ItemIsExist(lama))
                {
                    for (int i = 0; i < ListData.Count; i++)
                    {
                        Penjualan item = ListData[i];
                        if (item.Jumlah.ToLower().Trim().Equals(lama.Jumlah.ToLower().Trim()) &&
                            item.JenisMakanan.NamaMakanan.ToLower().Trim().Equals(lama.JenisMakanan.NamaMakanan.ToLower().Trim()))
                        {
                            ListData[i] = baru;
                            result = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }


    }
}
