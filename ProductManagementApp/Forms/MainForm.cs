﻿using ProductManagementApp.Forms;
using System;
using System.Windows.Forms;

namespace ProductManagementApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnMenuCategory_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show(this);
        }
    }
}
