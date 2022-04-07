using OOPEFTekrar_0.DesignPatterns.SingletonPattern;
using OOPEFTekrar_0.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPEFTekrar_0
{
    public partial class Form1 : Form
    {

        NorthwindEntities _db;
       

        public Form1()
        {
            InitializeComponent();
            _db = DBTool.DBInstance;
         
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            ListCategories();
        }

        private void ListCategories()
        {
            dgvResult.DataSource = _db.Categories.ToList();
        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            dgvResult.DataSource = _db.Products.Where(x => x.UnitPrice < 20).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category c = new Category();
            c.CategoryName = txtCatName.Text;
            _db.Categories.Add(c);
            _db.SaveChanges();
            ListCategories();
        }
    }
}
