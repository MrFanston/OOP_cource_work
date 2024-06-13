using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace OOP_Course_work
{
    public class MainViewModel
    {
        MainForm mainForm;

        // Список всех товаров на складе
        List<Product> products = new List<Product>();

        // Список всех материалов на складе
        List<Material> materials = new List<Material>();

        // Список используемых материалов
        List<Material> use_materials = new List<Material>();

        // Список поступлений и списаний
        List<Operation> operations = new List<Operation>();

        public MainViewModel(MainForm mainForm)
        {
            this.mainForm = mainForm;

            // Считываем данные с таблицы
            string dataDir = Application.StartupPath + "\\book.xlsx";

            Aspose aspose = new Aspose(dataDir, this);

            products = aspose.warehouse_products(products);

            materials = aspose.warehouse_materials(materials);

            use_materials = aspose.use_materials(use_materials);

            operations = aspose.operations(operations);
        }

        public List<Material> get_materials()
        {
            return materials;
        }

        public void add_materials(List<Material> materials)
        {
            foreach (Material material in materials)
            {
                this.materials.Add(material);

                mainForm.add_materials(material);

                Operation operation = new Operation(DateTime.Now, -materials.Last().get_price(), materials.Last().get_name());
                operations.Add(operation);
                
                mainForm.add_operation(operation);
            }
        }

        public void remove_material(Material material)
        {
            materials.Remove(material);
        }

        public List<Product> get_products()
        {
            return products;
        }

        public void add_product(Product product)
        {
            this.products.Add(product);
        }

        public void remove_product(Product product)
        {
            products.Remove(product);
        }

        public List<Material> get_use_materials()
        {
            return use_materials;
        }

        public void add_use_materials(Material material)
        {
            this.use_materials.Add(material);
        }

        public void remove_use_material(Material material)
        {
            use_materials.Remove(material);
        }

        public List<Operation> get_operations()
        {
            return operations;
        }

        public void add_operatin(Operation operation)
        {
            operations.Add(operation);
        }

        public List<Operation> calculation_operations_filtr(DateTime left, DateTime right)
        {
            List<Operation> operations_filtr = new List<Operation>();

            foreach (var operation in get_operations())
            {
                if (operation.get_data() > left)
                {
                    if (operation.get_data() < right)
                    { 
                        operations_filtr.Add(operation);
                    }
                }
            }

            return operations_filtr;
        }

        public List<float> calculation_increments(List<Operation> operations_filtr)
        {
            Accounting calculation = new Accounting(operations_filtr);

            List<float> increments = calculation.get_y();
            float mean = calculation.extrapolation();

            increments.Add(mean);

            return increments;
        }
    }
}
