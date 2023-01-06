using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Yagmur_180201028;

namespace Yagmur_180201028
{
    static class Item
    {
        public static string CPU_Type { get; set; }
        public static double CPU_Price { get; set; }

        public static string Storage_Type { get; set; }
        public static string Storage_Size { get; set; }
        public static double Storage_Price { get; set; }

        public static int Monitor_Type { get; set; }
        public static string Monitor_Size { get; set; } = "17";
        public static double Monitor_Price { get; set; }

        public static string Memory_Size { get; set; } = "4";
        public static double Memory_Price { get; set; }

        public static string Name { get; set; }
        public static int Card_No { get; set; }
        public static DateTime dateTime { get; set; }
        public static int CVV { get; set; }

        public static double Total { get; set; }

        public static void Calculate()
        {
            if (Item.CPU_Type == "Core i3") Item.CPU_Price = 1500;
            else if (Item.CPU_Type == "Core i5") Item.CPU_Price = 1700;
            else if (Item.CPU_Type == "Core i7") Item.CPU_Price = 2000;
            else if (Item.CPU_Type == "Core i9") Item.CPU_Price = 2500;

            if (Item.Storage_Type == "HDD" && Item.Storage_Size == "500") Item.Storage_Price = 300;
            else if (Item.Storage_Type == "HDD" && Item.Storage_Size == "1000") Item.Storage_Price = 600;
            else if (Item.Storage_Type == "SSD" && Item.Storage_Size == "500") Item.Storage_Price = 500;
            else if (Item.Storage_Type == "SSD" && Item.Storage_Size == "1000") Item.Storage_Price = 1000;

            if (Item.Memory_Size == "4") Item.Memory_Price = 150;
            else if (Item.Memory_Size == "8") Item.Memory_Price = 300;
            else if (Item.Memory_Size == "12") Item.Memory_Price = 450;
            else if (Item.Memory_Size == "16") Item.Memory_Price = 600;

            if (Item.Monitor_Size == "17") Item.Monitor_Price = 450;
            else if (Item.Monitor_Size == "20") Item.Monitor_Price = 900;
            else if (Item.Monitor_Size == "23") Item.Monitor_Price = 1350;

            Total = Item.CPU_Price + Item.Memory_Price + Item.Storage_Price + Item.Monitor_Price;
        }

        public static void SectionCalculate()
        {
            Item.Calculate();
            Page4.TotalString = Item.Total.ToString("C");
        }
    }
}




