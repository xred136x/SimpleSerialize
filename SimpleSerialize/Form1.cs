using System.Text;

namespace SimpleSerialize
{
    public partial class Form1 : Form
    {
        List<Dish> menu = new List<Dish>();
        List<string> printableMenu = new List<string>();
        public Form1()
        {
            InitializeComponent();
            refreshMenu();
            showMenuInBox();
        }

       
        private void btnAddDish_Click(object sender, EventArgs e)
        {
            var dish = new Dish(textBox1.Text, Convert.ToDecimal(maskedTextBox1.Text));
            menu.Add(dish);
        }
        private void refreshMenu(string path = "dish.xml")
        {
            Dish.Deserealize_it(path, out menu);
            lbListOfDish.Items.Clear();
            lbListOfDish.Items.AddRange(updatePrintableMenu());
        }
        private void showMenuInBox()
        {
            StringBuilder sb = new StringBuilder();
            var counter = 0;
            foreach (var item in menu)
            {
                sb.Append($"# {counter++} {item.Name}\t\tцена {item.Price}\n");
            }
            MessageBox.Show(sb.ToString());
        }
        private string[] updatePrintableMenu()
        {
            printableMenu.Clear();
            for (int i = 0; i < menu.Count; i++)
            {
                printableMenu.Add(menu[i].ToString());
            }
            var arr = printableMenu.ToArray();
            return arr;
        }
        private void saveToXml(string path = "dish.xml")
        {
            Dish.Serealize_it(menu, path);
            refreshMenu();
        }
        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            saveToXml();
        }

        private void btnSaveDish_Click(object sender, EventArgs e)
        {
            saveToXml();
        }

        
    }
}