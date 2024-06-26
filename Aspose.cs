﻿using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OOP_Course_work
{
    internal class Aspose
    {
        FileStream fstream;
        Workbook workbook;
        MainViewModel mainViewModel;

        public Aspose(string dataDir, MainViewModel mainViewModel) 
        {
            // Путь ввода файла Excel
            string InputPath = dataDir;

            // Создайте поток файлов, содержащий файл Excel для открытия.
            fstream = new FileStream(InputPath, FileMode.Open);

            // Создание экземпляра объекта Workbook
            // Откройте файл Excel через поток файлов
            workbook = new Workbook(fstream);

            this.mainViewModel = mainViewModel;
        }

        ~Aspose()
        {
            save();
        }

        void save()
        {
            fstream.Close();

            // Инициализация Workbook объекта
            Workbook workbook = new Workbook();

            // Создание листа
            Worksheet worksheet = workbook.Worksheets[0];
            worksheet.Name = "WarehouseProducts";

            // Создаем массив колонок шапки листа
            string[] names = new string[] { "Товар", "Описание", "Материал", "Тип", "Цена", "Особенность", "Мера измерения", "Текущее значение" };

            // Заполняем шапку
            for (int col = 0; col < names.Length; col++)
            {
                worksheet.Cells[0, col].PutValue(names[col]);
            }

            // Заполняем лист
            int i = 1;
            foreach (Product product in mainViewModel.get_products())
            {
                worksheet.Cells[i, 0].PutValue(product.get_name());
                worksheet.Cells[i++, 1].PutValue(product.get_description());
                foreach (Material material in product.get_components())
                {
                    if (material != product.get_components().Last())
                    {
                        worksheet.Cells[i, 0].PutValue("*");
                    }
                    else
                    {
                        worksheet.Cells[i, 0].PutValue("**");
                    }

                    worksheet.Cells[i, 1].PutValue("");
                    worksheet.Cells[i, 2].PutValue(material.get_name());
                    worksheet.Cells[i, 3].PutValue(material.GetType().Name);
                    worksheet.Cells[i, 4].PutValue(material.get_price());
                    worksheet.Cells[i, 6].PutValue(material.get_value_max());
                    worksheet.Cells[i, 7].PutValue(material.get_value_current());

                    if (material.GetType() == typeof(Unprocessed))
                    {
                        worksheet.Cells[i, 5].PutValue("");
                    }
                    else if (material.GetType() == typeof(Laser))
                    {
                        worksheet.Cells[i, 5].PutValue(((Laser)material).get_thickness());
                    }
                    else if (material.GetType() == typeof(PrinterFDM))
                    {
                        worksheet.Cells[i, 5].PutValue(((PrinterFDM)material).get_heat_resistant());
                    }
                    // (material.GetType() == typeof(Materials.PrinterSLA))
                    else
                    {
                        worksheet.Cells[i, 5].PutValue(((PrinterSLA)material).get_water_washer());
                    }

                    i++;
                }
            }

            // Создание листа
            workbook.Worksheets.Add();
            worksheet = workbook.Worksheets[1];
            worksheet.Name = "WarehouseMaterials";

            // Создаем массив колонок шапки листа
            names = new string[] { "Название", "Тип", "Цена", "Особенность", "Мера измерения", };

            // Заполняем шапку
            for (int col = 0; col < names.Length; col++)
            {
                worksheet.Cells[0, col].PutValue(names[col]);
            }

            // Заполняем лист
            i = 1;
            foreach (Material material in mainViewModel.get_materials())
            {
                worksheet.Cells[i, 0].PutValue(material.get_name());
                worksheet.Cells[i, 1].PutValue(material.GetType().Name);
                worksheet.Cells[i, 2].PutValue(material.get_price());
                worksheet.Cells[i, 4].PutValue(material.get_value_max());

                if (material.GetType() == typeof(Unprocessed))
                {
                    worksheet.Cells[i, 3].PutValue("");
                }
                else if (material.GetType() == typeof(Laser))
                {
                    worksheet.Cells[i, 3].PutValue(((Laser)material).get_thickness());
                }
                else if (material.GetType() == typeof(PrinterFDM))
                {
                    worksheet.Cells[i, 3].PutValue(((PrinterFDM)material).get_heat_resistant());
                }
                // (material.GetType() == typeof(Materials.PrinterSLA))
                else
                {
                    worksheet.Cells[i, 3].PutValue(((PrinterSLA)material).get_water_washer());
                }

                i++;
            }

            // Создание листа
            workbook.Worksheets.Add();
            worksheet = workbook.Worksheets[2];
            worksheet.Name = "UseMaterials";

            // Создаем массив колонок шапки листа
            names = new string[] { "Название", "Тип", "Цена", "Особенность", "Мера измерения", "Текущее значение" };

            // Заполняем шапку
            for (int col = 0; col < names.Length; col++)
            {
                worksheet.Cells[0, col].PutValue(names[col]);
            }

            // Заполняем лист
            i = 1;
            foreach (Material material in mainViewModel.get_use_materials())
            {
                worksheet.Cells[i, 0].PutValue(material.get_name());
                worksheet.Cells[i, 1].PutValue(material.GetType().Name);
                worksheet.Cells[i, 2].PutValue(material.get_price());
                worksheet.Cells[i, 4].PutValue(material.get_value_max());
                worksheet.Cells[i, 5].PutValue(material.get_value_current());

                if (material.GetType() == typeof(Unprocessed))
                {
                    worksheet.Cells[i, 3].PutValue("");
                }
                else if (material.GetType() == typeof(Laser))
                {
                    worksheet.Cells[i, 3].PutValue(((Laser)material).get_thickness());
                }
                else if (material.GetType() == typeof(PrinterFDM))
                {
                    worksheet.Cells[i, 3].PutValue(((PrinterFDM)material).get_heat_resistant());
                }
                // (material.GetType() == typeof(Materials.PrinterSLA))
                else
                {
                    worksheet.Cells[i, 3].PutValue(((PrinterSLA)material).get_water_washer());
                }

                i++;
            }


            // Создание листа
            workbook.Worksheets.Add();
            worksheet = workbook.Worksheets[3];
            worksheet.Name = "Accounting";

            // Создаем массив колонок шапки листа
            names = new string[] { "Дата", "Поступление/списание", "Описание" };

            // Заполняем шапку
            for (int col = 0; col < names.Length; col++)
            {
                worksheet.Cells[0, col].PutValue(names[col]);
            }

            // Заполняем лист
            i = 1;
            foreach (Operation operation in mainViewModel.get_operations())
            {
                worksheet.Cells[i, 0].PutValue(operation.get_data().ToString());
                worksheet.Cells[i, 1].PutValue(operation.get_value());
                worksheet.Cells[i, 2].PutValue(operation.get_description());

                i++;
            }

            // Сохранение файла
            workbook.Save("book.xlsx");
        }

        public List<Product> warehouse_products(List<Product> products)
        {
            // Доступ к листу, используя его имя листа
            Worksheet worksheet = workbook.Worksheets["WarehouseProducts"];

            string name_product = "";
            string description = "";
            List<Material> materials = new List<Material>(); ;

            // Перебираем строки страницы
            for (int i = 1; i < worksheet.Cells.Rows.Count; i++)
            {
                Cell cell = worksheet.Cells.CheckCell(i, 0);
                List<float> values = new List<float>();

                // Если это товар
                if (cell.Value.ToString() != "*" && cell.Value.ToString() != "**")
                {
                    cell = worksheet.Cells.CheckCell(i, 0);
                    name_product = cell.Value.ToString();

                    cell = worksheet.Cells.CheckCell(i, 1);
                    description = cell.Value.ToString();
                    materials = new List<Material>();
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

                        Unprocessed unprocessed = new Unprocessed(name_material, price);
                        materials.Add(unprocessed);
                    }
                    else if (cell.Value.ToString() == "Laser")
                    {
                        cell = worksheet.Cells.CheckCell(i, 2);
                        string name_material = cell.Value.ToString();

                        cell = worksheet.Cells.CheckCell(i, 4);
                        float price = (float)Convert.ToDouble(cell.Value.ToString());

                        cell = worksheet.Cells.CheckCell(i, 5);
                        float thickness = (float)Convert.ToDouble(cell.Value.ToString());

                        cell = worksheet.Cells.CheckCell(i, 6);
                        float square_max = (float)Convert.ToDouble(cell.Value.ToString());

                        cell = worksheet.Cells.CheckCell(i, 7);
                        float square_current = (float)Convert.ToDouble(cell.Value.ToString());

                        Laser laser = new Laser(name_material, price, thickness, square_max, square_current);
                        materials.Add(laser);
                    }
                    else if (cell.Value.ToString() == "PrinterFDM")
                    {
                        cell = worksheet.Cells.CheckCell(i, 2);
                        string name_material = cell.Value.ToString();

                        cell = worksheet.Cells.CheckCell(i, 4);
                        float price = (float)Convert.ToDouble(cell.Value.ToString());

                        cell = worksheet.Cells.CheckCell(i, 5);
                        string heat_resistant = cell.Value.ToString();

                        cell = worksheet.Cells.CheckCell(i, 6);
                        float square_max = (float)Convert.ToDouble(cell.Value.ToString());

                        cell = worksheet.Cells.CheckCell(i, 7);
                        float square_current = (float)Convert.ToDouble(cell.Value.ToString());

                        PrinterFDM fdm = new PrinterFDM(name_material, price, heat_resistant, square_max, square_current);
                        materials.Add(fdm);
                    }
                    else if (cell.Value.ToString() == "PrinterSLA")
                    {
                        cell = worksheet.Cells.CheckCell(i, 2);
                        string name_material = cell.Value.ToString();

                        cell = worksheet.Cells.CheckCell(i, 4);
                        float price = (float)Convert.ToDouble(cell.Value.ToString());

                        cell = worksheet.Cells.CheckCell(i, 5);
                        string water_washer = cell.Value.ToString();

                        cell = worksheet.Cells.CheckCell(i, 6);
                        float square_max = (float)Convert.ToDouble(cell.Value.ToString());

                        cell = worksheet.Cells.CheckCell(i, 7);
                        float square_current = (float)Convert.ToDouble(cell.Value.ToString());

                        PrinterSLA sla = new PrinterSLA(name_material, price, water_washer, square_max, square_current);
                        materials.Add(sla);
                    }

                    // Если это последний материал
                    if (worksheet.Cells.CheckCell(i, 0).Value.ToString() == "**")
                    {
                        Product product = new Product(name_product, description, materials);
                        products.Add(product);
                    }
                }
            }
            return products;
        }

        public List<Material> warehouse_materials(List<Material> materials)
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

                    Unprocessed unprocessed = new Unprocessed(name_material, price);
                    materials.Add(unprocessed);
                }
                else if (cell.Value.ToString() == "Laser")
                {
                    cell = worksheet.Cells.CheckCell(i, 0);
                    string name_material = cell.Value.ToString();

                    cell = worksheet.Cells.CheckCell(i, 2);
                    float price = (float)Convert.ToDouble(cell.Value.ToString());

                    cell = worksheet.Cells.CheckCell(i, 3);
                    float thickness = (float)Convert.ToDouble(cell.Value.ToString());

                    cell = worksheet.Cells.CheckCell(i, 4);
                    float square_max = (float)Convert.ToDouble(cell.Value.ToString());

                    cell = worksheet.Cells.CheckCell(i, 4);
                    float square_current = (float)Convert.ToDouble(cell.Value.ToString());

                    Laser laser = new Laser(name_material, price, thickness, square_max, square_current);
                    materials.Add(laser);
                }
                else if (cell.Value.ToString() == "PrinterFDM")
                {
                    cell = worksheet.Cells.CheckCell(i, 0);
                    string name_material = cell.Value.ToString();

                    cell = worksheet.Cells.CheckCell(i, 2);
                    float price = (float)Convert.ToDouble(cell.Value.ToString());

                    cell = worksheet.Cells.CheckCell(i, 3);
                    string heat_resistant = cell.Value.ToString();

                    cell = worksheet.Cells.CheckCell(i, 4);
                    float square_max = (float)Convert.ToDouble(cell.Value.ToString());

                    cell = worksheet.Cells.CheckCell(i, 4);
                    float square_current = (float)Convert.ToDouble(cell.Value.ToString());

                    PrinterFDM fdm = new PrinterFDM(name_material, price, heat_resistant, square_max, square_current);
                    materials.Add(fdm);
                }
                else if (cell.Value.ToString() == "PrinterSLA")
                {
                    cell = worksheet.Cells.CheckCell(i, 0);
                    string name_material = cell.Value.ToString();

                    cell = worksheet.Cells.CheckCell(i, 2);
                    float price = (float)Convert.ToDouble(cell.Value.ToString());

                    cell = worksheet.Cells.CheckCell(i, 3);
                    string water_washer = cell.Value.ToString();

                    cell = worksheet.Cells.CheckCell(i, 4);
                    float square_max = (float)Convert.ToDouble(cell.Value.ToString());

                    cell = worksheet.Cells.CheckCell(i, 4);
                    float square_current = (float)Convert.ToDouble(cell.Value.ToString());

                    PrinterSLA sla = new PrinterSLA(name_material, price, water_washer, square_max, square_current);
                    materials.Add(sla);
                }
            }

            return materials;
        }

        public List<Material> use_materials(List<Material > materials)
        {
            // Доступ к листу, используя его имя листа
            Worksheet worksheet = workbook.Worksheets["UseMaterials"];

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

                    Unprocessed unprocessed = new Unprocessed(name_material, price);
                    materials.Add(unprocessed);
                }
                else if (cell.Value.ToString() == "Laser")
                {
                    cell = worksheet.Cells.CheckCell(i, 0);
                    string name_material = cell.Value.ToString();

                    cell = worksheet.Cells.CheckCell(i, 2);
                    float price = (float)Convert.ToDouble(cell.Value.ToString());

                    cell = worksheet.Cells.CheckCell(i, 3);
                    float thickness = (float)Convert.ToDouble(cell.Value.ToString());

                    cell = worksheet.Cells.CheckCell(i, 4);
                    float square_max = (float)Convert.ToDouble(cell.Value.ToString());

                    cell = worksheet.Cells.CheckCell(i, 5);
                    float square_current = (float)Convert.ToDouble(cell.Value.ToString());

                    Laser laser = new Laser(name_material, price, thickness, square_max, square_current);
                    materials.Add(laser);
                }
                else if (cell.Value.ToString() == "PrinterFDM")
                {
                    cell = worksheet.Cells.CheckCell(i, 0);
                    string name_material = cell.Value.ToString();

                    cell = worksheet.Cells.CheckCell(i, 2);
                    float price = (float)Convert.ToDouble(cell.Value.ToString());

                    cell = worksheet.Cells.CheckCell(i, 3);
                    string heat_resistant = cell.Value.ToString();

                    cell = worksheet.Cells.CheckCell(i, 4);
                    float square_max = (float)Convert.ToDouble(cell.Value.ToString());

                    cell = worksheet.Cells.CheckCell(i, 5);
                    float square_current = (float)Convert.ToDouble(cell.Value.ToString());

                    PrinterFDM fdm = new PrinterFDM(name_material, price, heat_resistant, square_max, square_current);
                    materials.Add(fdm);
                }
                else if (cell.Value.ToString() == "PrinterSLA")
                {
                    cell = worksheet.Cells.CheckCell(i, 0);
                    string name_material = cell.Value.ToString();

                    cell = worksheet.Cells.CheckCell(i, 2);
                    float price = (float)Convert.ToDouble(cell.Value.ToString());

                    cell = worksheet.Cells.CheckCell(i, 3);
                    string water_washer = cell.Value.ToString();

                    cell = worksheet.Cells.CheckCell(i, 4);
                    float square_max = (float)Convert.ToDouble(cell.Value.ToString());

                    cell = worksheet.Cells.CheckCell(i, 5);
                    float square_current = (float)Convert.ToDouble(cell.Value.ToString());

                    PrinterSLA sla = new PrinterSLA(name_material, price, water_washer, square_max, square_current);
                    materials.Add(sla);
                }
            }

            return materials;
        }

        public List<Operation> operations(List<Operation> operations)
        {
            // Доступ к листу, используя его имя листа
            Worksheet worksheet = workbook.Worksheets["Accounting"];

            // Перебираем строки страницы
            for (int i = 1; i < worksheet.Cells.Rows.Count; i++)
            {
                Cell cell = worksheet.Cells.CheckCell(i, 0);
                DateTime dateTime = Convert.ToDateTime(cell.Value.ToString());

                cell = worksheet.Cells.CheckCell(i, 1);
                float value = (float)Convert.ToDouble(cell.Value.ToString());

                cell = worksheet.Cells.CheckCell(i, 2);
                string description = cell.Value.ToString();

                Operation operation = new Operation(dateTime, value, description);

                operations.Add(operation);
            }

            return operations;
        }
    }
}
