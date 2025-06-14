using DeliveryZadacha.Controllers;
using DeliveryZadacha.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DeliveryZadacha
{
    public partial class DishTypes: Form
    {
        DishTypeLogic controller = new DishTypeLogic();
        public DishTypes()
        {
            InitializeComponent();
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId2.Text, out int id))
            {
                MessageBox.Show("Въведете валидно ID за изтриване!!!");
                txtId2.BackColor = Color.Red;
                txtId2.Focus();
                return;
            }

            var typeName = controller.GetDishTypeNameById(id);
            if (typeName == null)
            {
                MessageBox.Show("Типът ястие не съществува!!!");
                txtId2.BackColor = Color.Red;
                txtId2.Focus();
                return;
            }

            DialogResult confirm = MessageBox.Show($"Сигурни ли сте, че искате да изтриете {typeName}?", "Потвърждение", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                controller.Delete(id);
                MessageBox.Show("Успешно изтрито!");
                ClearScreen();
                btnSelectAll_Click(sender, e);
            }
        }

        private void DishTypes_Load(object sender, EventArgs e)
        {
            btnSelectAll_Click(sender, e);
        }
        private void LoadRecord(DishType dishType)
        {
            txtId2.BackColor = Color.White;
            txtId2.Text = dishType.Id.ToString();
            txtNameDish2.Text = dishType.TypeName;
        }
        private void ClearScreen()
        {
            txtId2.BackColor = Color.White;
            txtId2.Clear();
            txtNameDish2.Clear();
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNameDish2.Text))
            {
                MessageBox.Show("Въведете име на типа ястие!!!");
                txtNameDish2.Focus();
                return;
            }

            DishType newType = new DishType
            {
                TypeName = txtNameDish2.Text
            };

            controller.Create(newType);
            MessageBox.Show("Успешно добавен тип ястие!");
            ClearScreen();
            btnSelectAll_Click(sender, e);
        }
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            List<DishType> all = controller.GetAllDishTypes();
            listBox2.Items.Clear();
            foreach (var item in all)
            {
                listBox2.Items.Add($"{item.Id}. {item.TypeName}");
            }
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId2.Text, out int id))
            {
                MessageBox.Show("Въведете валидно ID за търсене!!!");
                txtId2.BackColor = Color.Red;
                txtId2.Focus();
                return;
            }

            var found = controller.GetDishTypeById(id);
            if (found == null)
            {
                MessageBox.Show("Няма такъв тип ястие!!!");
                txtId2.BackColor = Color.Red;
                txtId2.Focus();
                return;
            }

            LoadRecord(found);
        }

        private void btnUpdate2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId2.Text, out int id))
            {
                MessageBox.Show("Въведете валидно ID за актуализация!!!");
                txtId2.BackColor = Color.Red;
                txtId2.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtNameDish2.Text))
            {
                MessageBox.Show("Въведете име на типа ястие!!!");
                txtNameDish2.Focus();
                return;
            }

            DishType updated = new DishType
            {
                TypeName = txtNameDish2.Text
            };

            controller.Update(id, updated);
            MessageBox.Show("Типът ястие е актуализиран!");
            ClearScreen();
            btnSelectAll_Click(sender, e);
        }
    }
}
