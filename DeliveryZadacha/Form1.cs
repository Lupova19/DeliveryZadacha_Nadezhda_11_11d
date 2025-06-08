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

namespace DeliveryZadacha
{
    public partial class Form1 : Form
    {
        DishLogic dishController = new DishLogic();
        DishTypeLogic dishTypeController = new DishTypeLogic();
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadRecord(Dish dish)
        {
            txtId.BackColor = Color.White;
            txtId.Text = dish.Id.ToString();
            txtNameDish.Text = dish.Name;    //
            rtxDescription.Text = dish.Description;
            numericUpDownPrice.Value = dish.Price;
            numericUpDownWeight.Value = dish.Weight;
            cmbKindDish.SelectedValue = dish.DishTypeId;
        }
        private void ClearScreen()
        {
            txtId.BackColor = Color.White;
            txtId.Clear();
            txtNameDish.Clear();
            rtxDescription.Clear();
            numericUpDownPrice.Value = numericUpDownPrice.Minimum; //
            numericUpDownWeight.Value = numericUpDownWeight.Minimum;
            cmbKindDish.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<DishType> allDishTypes = dishTypeController.GetAllDishTypes();
            cmbKindDish.DataSource = allDishTypes;
            cmbKindDish.DisplayMember = "Name";
            cmbKindDish.ValueMember = "Id";

            //btnSelectAll(sender, e);
            btnSelectAll_Click(this, EventArgs.Empty);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNameDish.Text))
            {
                MessageBox.Show("Въведете име на ястието!");
                txtNameDish.Focus();
                return;
            }

            Dish newDish = new Dish()
            {
                Name = txtNameDish.Text,
                Description = rtxDescription.Text,
                Price = numericUpDownPrice.Value,
                Weight = (int)numericUpDownWeight.Value,
                DishTypeId = (int)cmbKindDish.SelectedValue
            };

            dishController.Create(newDish);
            MessageBox.Show("Записът е успешно добавен!");
            ClearScreen();
            btnSelectAll_Click(sender, e);
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            List<Dish> allDishes = dishController.GetAll();
            listBox1.Items.Clear();
            foreach (var item in allDishes)
            {
                listBox1.Items.Add($"{item.Id}. {item.Name} - {item.DishType.TypeName} - {item.Price} лв.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || !txtId.Text.All(char.IsDigit))
            {
                MessageBox.Show("Въведете валиден Id за търсене!");
                txtId.BackColor = Color.Red;
                txtId.Focus();
                return;
            }

            int findId = int.Parse(txtId.Text);
            Dish foundDish = dishController.Get(findId);
            if (foundDish == null)
            {
                MessageBox.Show("Няма такъв запис в базата!");
                txtId.BackColor = Color.Red;
                txtId.Focus();
                return;
            }
            LoadRecord(foundDish);
            ClearScreen();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int findId))
            {
                MessageBox.Show("Въведете валидно ID за изтриване!");
                txtId.BackColor = Color.Red;
                txtId.Focus();
                return;
            }

            Dish foundDish = dishController.Get(findId);
            if (foundDish == null)
            {
                MessageBox.Show("Няма такъв запис в базата!");
                txtId.BackColor = Color.Red;
                txtId.Focus();
                return;
            }

            DialogResult answer = MessageBox.Show($"Наистина ли искате да изтриете запис No {findId}?",
                "Потвърждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                dishController.Delete(findId);
                MessageBox.Show("Записът е изтрит успешно!");
                ClearScreen();
                btnSelectAll_Click(sender, e);
            }
        }
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int findId))
            {
                MessageBox.Show("Въведете валидно ID за актуализация!");
                txtId.BackColor = Color.Red;
                txtId.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtNameDish.Text))
            {
                MessageBox.Show("Въведете име на ястието!");
                txtNameDish.Focus();
                return;
            }
            if (cmbKindDish.SelectedItem == null)
            {
                MessageBox.Show("Изберете вид на ястието!");
                cmbKindDish.Focus();
                return;
            }

            if (numericUpDownPrice.Value < 0)
            {
                MessageBox.Show("Въведете валидна цена (по-голяма от 0)!");
                numericUpDownPrice.Focus();
                return;
            }

            if (numericUpDownWeight.Value < 0)
            {
                MessageBox.Show("Въведете валидно тегло (по-голямо от 0)!");
                numericUpDownWeight.Focus();
                return;
            }

            Dish updatedDish = new Dish()
            {
                Name = txtNameDish.Text,
                Description = rtxDescription.Text,
                DishTypeId = (int)cmbKindDish.SelectedValue,
                Price = numericUpDownPrice.Value,
                Weight = (int)numericUpDownWeight.Value
            };

            dishController.Update(findId, updatedDish);
            MessageBox.Show("Записът е успешно актуализиран!");
            btnSelectAll_Click(sender, e);
            ClearScreen();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
