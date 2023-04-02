using Proj.DomainService;
using Proj.Models;
using Proj.Models.DbModels;
using Word = Microsoft.Office.Interop.Word;
namespace Proj
{
    public partial class Form1 : Form
    {
        private NotebookService _NotebookService;
        private UserService _userService;

        public Form1()
        {
            InitializeComponent();
            var context = new ApplicationDbContext();
            _NotebookService = new NotebookService(context);
            _userService = new UserService(context);

        }

        private List<PC> getPCDataForGrid(PcFiltrEnum pcFiltr = PcFiltrEnum.None)
        {
            return _NotebookService
                .getAllNotebooks(pcFiltr);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Word.Application word = new Word.Application();
            word.Visible = true;
            word.WindowState = Word.WdWindowState.wdWindowStateNormal;
            Word.Document doc = word.Documents.Add();
            Word.Paragraph paragraph;
            paragraph = doc.Paragraphs.Add();
            doc.SaveAs2(@"C:\New folder\DPS.doc");
            doc.Close();
            word.Quit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}