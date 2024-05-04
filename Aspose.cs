using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course_work
{
    internal class Aspose
    {
        FileStream fstream;
        Workbook workbook;

        public Aspose(string dataDir) 
        {
            // Путь ввода файла Excel
            string InputPath = dataDir;

            // Создайте поток файлов, содержащий файл Excel для открытия.
            fstream = new FileStream(InputPath, FileMode.Open);

            // Создание экземпляра объекта Workbook
            // Откройте файл Excel через поток файлов
            workbook = new Workbook(fstream);
        }

        public List<Product> warehouseProducts(List<Product> products)
        {
            // Доступ к листу, используя его имя листа
            Worksheet worksheet = workbook.Worksheets["WarehouseProducts"];

            string name_product = "";
            string description = "";
            List<Materials.Material> materials = new List<Materials.Material>();

            // Перебираем строки страницы
            for (int i = 1; i < worksheet.Cells.Rows.Count; i++)
            {
                Cell cell = worksheet.Cells.CheckCell(i, 0);

                // Если это товар
                if (cell.Value.ToString() != "*" && cell.Value.ToString() != "**")
                {
                    cell = worksheet.Cells.CheckCell(i, 0);
                    name_product = cell.Value.ToString();

                    cell = worksheet.Cells.CheckCell(i, 1);
                    description = cell.Value.ToString();
                }
                // Если это материал
                else
                {
                    cell = worksheet.Cells.CheckCell(i, 3);

                    if (cell.Value.ToString() == "Unprocessed")
                    {
                        cell = worksheet.Cells.CheckCell(i, 2);
                        string name_material = cell.Value.ToString();

                        cell = worksheet.Cells.CheckCell(i, 4);
                        float price = (float)Convert.ToDouble(cell.Value.ToString());

                        Materials.Unprocessed unprocessed = new Materials.Unprocessed(name_material, price);
                        materials.Add(unprocessed);
                    }
                    else if (cell.Value.ToString() == "Laser")
                    {
                        cell = worksheet.Cells.CheckCell(i, 2);
                        string name_material = cell.Value.ToString();

                        cell = worksheet.Cells.CheckCell(i, 4);
                        float price = (float)Convert.ToDouble(cell.Value.ToString());

                        cell = worksheet.Cells.CheckCell(i, 5);
                        string color = cell.Value.ToString();

                        cell = worksheet.Cells.CheckCell(i, 6);
                        float thickness = (float)Convert.ToDouble(cell.Value.ToString());

                        cell = worksheet.Cells.CheckCell(i, 7);
                        float square_max = (float)Convert.ToDouble(cell.Value.ToString());

                        cell = worksheet.Cells.CheckCell(i, 8);
                        float square_current = (float)Convert.ToDouble(cell.Value.ToString());

                        Materials.Laser laser = new Materials.Laser(name_material, price, color, thickness, square_max, square_current);
                        materials.Add(laser);
                    }
                    else if (cell.Value.ToString() == "PrinterFDM")
                    {
                        cell = worksheet.Cells.CheckCell(i, 2);
                        string name_material = cell.Value.ToString();

                        cell = worksheet.Cells.CheckCell(i, 4);
                        float price = (float)Convert.ToDouble(cell.Value.ToString());

                        cell = worksheet.Cells.CheckCell(i, 5);
                        string color = cell.Value.ToString();

                        cell = worksheet.Cells.CheckCell(i, 7);
                        float square_max = (float)Convert.ToDouble(cell.Value.ToString());

                        cell = worksheet.Cells.CheckCell(i, 8);
                        float square_current = (float)Convert.ToDouble(cell.Value.ToString());

                        Materials.PrinterFDM fdm = new Materials.PrinterFDM(name_material, price, color, square_max, square_current);
                        materials.Add(fdm);
                    }
                    else if (cell.Value.ToString() == "PrinterSLA")
                    {
                        cell = worksheet.Cells.CheckCell(i, 2);
                        string name_material = cell.Value.ToString();

                        cell = worksheet.Cells.CheckCell(i, 4);
                        float price = (float)Convert.ToDouble(cell.Value.ToString());

                        cell = worksheet.Cells.CheckCell(i, 5);
                        string color = cell.Value.ToString();

                        cell = worksheet.Cells.CheckCell(i, 7);
                        float square_max = (float)Convert.ToDouble(cell.Value.ToString());

                        cell = worksheet.Cells.CheckCell(i, 8);
                        float square_current = (float)Convert.ToDouble(cell.Value.ToString());

                        Materials.PrinterSLA sla = new Materials.PrinterSLA(name_material, price, color, square_max, square_current);
                        materials.Add(sla);
                    }

                    // Если это последний материал
                    if (worksheet.Cells.CheckCell(i, 0).Value.ToString() == "**")
                    {
                        Product product = new Product(name_product, description, materials.ToArray());
                        products.Add(product);
                    }
                }
            }
            return products;
        }

        public List<Materials.Material> warehouseMaterials(List<Materials.Material> materials)
        {
            // Доступ к листу, используя его имя листа
            Worksheet worksheet = workbook.Worksheets["WarehouseMaterials"];

            // Перебираем строки страницы
            for (int i = 1; i < worksheet.Cells.Rows.Count; i++)
            {
                Cell cell = worksheet.Cells.CheckCell(i, 1);

                if (cell.Value.ToString() == "Unprocessed")
                {
                    cell = worksheet.Cells.CheckCell(i, 0);
                    string name_material = cell.Value.ToString();

                    cell = worksheet.Cells.CheckCell(i, 2);
                    float price = (float)Convert.ToDouble(cell.Value.ToString());

                    Materials.Unprocessed unprocessed = new Materials.Unprocessed(name_material, price);
                    materials.Add(unprocessed);
                }
                else if (cell.Value.ToString() == "Laser")
                {
                    cell = worksheet.Cells.CheckCell(i, 2);
                    string name_material = cell.Value.ToString();

                    cell = worksheet.Cells.CheckCell(i, 4);
                    float price = (float)Convert.ToDouble(cell.Value.ToString());

                    cell = worksheet.Cells.CheckCell(i, 5);
                    string color = cell.Value.ToString();

                    cell = worksheet.Cells.CheckCell(i, 6);
                    float thickness = (float)Convert.ToDouble(cell.Value.ToString());

                    cell = worksheet.Cells.CheckCell(i, 7);
                    float square_max = (float)Convert.ToDouble(cell.Value.ToString());

                    cell = worksheet.Cells.CheckCell(i, 8);
                    float square_current = (float)Convert.ToDouble(cell.Value.ToString());

                    Materials.Laser laser = new Materials.Laser(name_material, price, color, thickness, square_max, square_current);
                    materials.Add(laser);
                }
                else if (cell.Value.ToString() == "PrinterFDM")
                {
                    cell = worksheet.Cells.CheckCell(i, 2);
                    string name_material = cell.Value.ToString();

                    cell = worksheet.Cells.CheckCell(i, 4);
                    float price = (float)Convert.ToDouble(cell.Value.ToString());

                    cell = worksheet.Cells.CheckCell(i, 5);
                    string color = cell.Value.ToString();

                    cell = worksheet.Cells.CheckCell(i, 7);
                    float square_max = (float)Convert.ToDouble(cell.Value.ToString());

                    cell = worksheet.Cells.CheckCell(i, 8);
                    float square_current = (float)Convert.ToDouble(cell.Value.ToString());

                    Materials.PrinterFDM fdm = new Materials.PrinterFDM(name_material, price, color, square_max, square_current);
                    materials.Add(fdm);
                }
                else if (cell.Value.ToString() == "PrinterSLA")
                {
                    cell = worksheet.Cells.CheckCell(i, 2);
                    string name_material = cell.Value.ToString();

                    cell = worksheet.Cells.CheckCell(i, 4);
                    float price = (float)Convert.ToDouble(cell.Value.ToString());

                    cell = worksheet.Cells.CheckCell(i, 5);
                    string color = cell.Value.ToString();

                    cell = worksheet.Cells.CheckCell(i, 7);
                    float square_max = (float)Convert.ToDouble(cell.Value.ToString());

                    cell = worksheet.Cells.CheckCell(i, 8);
                    float square_current = (float)Convert.ToDouble(cell.Value.ToString());

                    Materials.PrinterSLA sla = new Materials.PrinterSLA(name_material, price, color, square_max, square_current);
                    materials.Add(sla);
                }
            }

            return materials;
        }

        public List<Materials.Material> useMaterials(List<Materials.Material> materials)
        {
            // Доступ к листу, используя его имя листа
            Worksheet worksheet = workbook.Worksheets["WarehouseMaterials"];

            // Перебираем строки страницы
            for (int i = 1; i < worksheet.Cells.Rows.Count; i++)
            {
                Cell cell = worksheet.Cells.CheckCell(i, 3);

                if (cell.Value.ToString() == "Unprocessed")
                {
                    cell = worksheet.Cells.CheckCell(i, 2);
                    string name_material = cell.Value.ToString();

                    cell = worksheet.Cells.CheckCell(i, 4);
                    float price = (float)Convert.ToDouble(cell.Value.ToString());

                    Materials.Unprocessed unprocessed = new Materials.Unprocessed(name_material, price);
                    materials.Add(unprocessed);
                }
                else if (cell.Value.ToString() == "Laser")
                {
                    cell = worksheet.Cells.CheckCell(i, 2);
                    string name_material = cell.Value.ToString();

                    cell = worksheet.Cells.CheckCell(i, 4);
                    float price = (float)Convert.ToDouble(cell.Value.ToString());

                    cell = worksheet.Cells.CheckCell(i, 5);
                    string color = cell.Value.ToString();

                    cell = worksheet.Cells.CheckCell(i, 6);
                    float thickness = (float)Convert.ToDouble(cell.Value.ToString());

                    cell = worksheet.Cells.CheckCell(i, 7);
                    float square_max = (float)Convert.ToDouble(cell.Value.ToString());

                    cell = worksheet.Cells.CheckCell(i, 8);
                    float square_current = (float)Convert.ToDouble(cell.Value.ToString());

                    Materials.Laser laser = new Materials.Laser(name_material, price, color, thickness, square_max, square_current);
                    materials.Add(laser);
                }
                else if (cell.Value.ToString() == "PrinterFDM")
                {
                    cell = worksheet.Cells.CheckCell(i, 2);
                    string name_material = cell.Value.ToString();

                    cell = worksheet.Cells.CheckCell(i, 4);
                    float price = (float)Convert.ToDouble(cell.Value.ToString());

                    cell = worksheet.Cells.CheckCell(i, 5);
                    string color = cell.Value.ToString();

                    cell = worksheet.Cells.CheckCell(i, 7);
                    float square_max = (float)Convert.ToDouble(cell.Value.ToString());

                    cell = worksheet.Cells.CheckCell(i, 8);
                    float square_current = (float)Convert.ToDouble(cell.Value.ToString());

                    Materials.PrinterFDM fdm = new Materials.PrinterFDM(name_material, price, color, square_max, square_current);
                    materials.Add(fdm);
                }
                else if (cell.Value.ToString() == "PrinterSLA")
                {
                    cell = worksheet.Cells.CheckCell(i, 2);
                    string name_material = cell.Value.ToString();

                    cell = worksheet.Cells.CheckCell(i, 4);
                    float price = (float)Convert.ToDouble(cell.Value.ToString());

                    cell = worksheet.Cells.CheckCell(i, 5);
                    string color = cell.Value.ToString();

                    cell = worksheet.Cells.CheckCell(i, 7);
                    float square_max = (float)Convert.ToDouble(cell.Value.ToString());

                    cell = worksheet.Cells.CheckCell(i, 8);
                    float square_current = (float)Convert.ToDouble(cell.Value.ToString());

                    Materials.PrinterSLA sla = new Materials.PrinterSLA(name_material, price, color, square_max, square_current);
                    materials.Add(sla);
                }
            }

            return materials;
        }
    }
}
