using App12.Model;
using Stimulsoft.Client.Designer;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static Stimulsoft.Report.StiOptions;

namespace App12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            loadData();
        }

        private void loadData()
        {
            using (var context = new NorthWindEntities())
            {
                var query = context.Products.Include(x => x.Category);
                if (!String.IsNullOrEmpty(textBoxPrice.Text))
                {
                    var price = Convert.ToInt32(textBoxPrice.Text);
                    query = query.Where(x => x.UnitPrice > price);
                }
                dataGridView1.DataSource = query
                    .Select(x => new
                    {
                        ProductName = x.ProductName,
                        CategoryName = x.Category.CategoryName,
                        Price = x.UnitPrice
                    })
                    .ToList();
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            var report = new StiReport();
            report.RegBusinessObject("Products", dataGridView1.DataSource);
            //report.Load("Report.mrt");

            var reportStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("App12.report.Report.mrt");
            report.Load(reportStream);
            report.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var designer = new StiDesigner();
            var reportStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("App12.report.Report.mrt");
            //designer.Load(reportStream);
            //designer.ShowDesigner();
        }

        private void buttonTransactionFail_Click(object sender, EventArgs e)
        {
            //Transaction - همه دستورات اجرا بشن، یا اگه اجرا نشدن، وضعت به حالت اولیه برگردد

            AddProduct();
            AddCategory();
        }

        private void buttonTransactionScopr_Click(object sender, EventArgs e)
        {
            using (var ts = new TransactionScope())
            {
                AddProduct();
                AddCategory();

                ts.Complete(); //commit
            }
        }

        private void buttonTransactionGR_Click(object sender, EventArgs e)
        {
            //var repoCategory = new Repository<Category>();
            //var repoProduct = new Repository<Product>();

            var repo = new Repository();

            var prodct = new Product { ProductName = "Transaction test 66", UnitPrice = 1 };
            var cat = new Category { CategoryName = "test catgory tolani 1234567890" };
            
            repo.Create(prodct);
            repo.Create(cat);

            repo.SaveChanges();
        }


        private void buttonTransactionEF_Click(object sender, EventArgs e)
        {
            using (var context = new NorthWindEntities())
            {
                var prodct = new Product { ProductName = "Transaction test2", UnitPrice = 1 };
                context.Products.Add(prodct);


                var cat = new Category { CategoryName = "test catgory tolani 1234567890" };
                context.Categories.Add(cat);

                context.SaveChanges();
            }
        }

        


        private void AddCategory()
        {
            using (var context = new NorthWindEntities())
            {
                var cat = new Category { CategoryName = "test catgory tolani 1234567890" };
                context.Categories.Add(cat);
                context.SaveChanges();
            }
        }


        private void AddProduct()
        {
            using (var context = new NorthWindEntities())
            {
                var prodct = new Product { ProductName = "Transaction test", UnitPrice = 1 };
                context.Products.Add(prodct);
                context.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var regexEMAIL = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (Regex.IsMatch(textBoxRegex.Text, regexEMAIL))
            {
                MessageBox.Show("Valid");
            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }
    }
}
