using Q1_Demo.Models;
using Button = Q1_Demo.Models.Button;

namespace Q1_Demo
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Button btNewButton;
        public Form1()
        {
            InitializeComponent();
            LoadDB();
        }

        public void LoadDB()
        {
            PE_PRN211_23SprB1Context con = new PE_PRN211_23SprB1Context();

            var button = con.Buttons.Select(x => new
            {
                Id = x.Id,
                Text = x.Text,
                Color = x.Color
            });
            dataGridView1.DataSource = button.ToList();
        }

        /*void dynamicButton_Click()
        {
            btNewButton = new System.Windows.Forms.Button();
            btNewButton.Text = "New Button";
            btNewButton.Size = new Size(btClick.Size.Width, btClick.Size.Height);
            btNewButton.Location = new Point(btClick.Location.X, btClick.Location.Y + btClick.Size.Height + 20);
            this.Controls.Add(btNewButton);
        }*/

        private void btn_Add_Click(object sender, EventArgs e)
        {
            PE_PRN211_23SprB1Context con = new PE_PRN211_23SprB1Context();
            List<Button> buttons = new List<Button>();
            buttons = con.Buttons.ToList();
            for (int i = 0; i < buttons.Count; i++)
            {
                System.Windows.Forms.Button newButton = new System.Windows.Forms.Button();
                newButton.BackColor = ColorTranslator.FromHtml(buttons[i].Color);
                newButton.Text = buttons[i].Text;
                newButton.Size = new Size(btn_Add.Size.Width, btn_Add.Size.Height);
                flowLayoutPanel1.Controls.Add(newButton);

            }

        }

    }
}