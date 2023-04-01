using Proj.DomainService;
using Proj.Models;
using Proj.Models.DbModels;

namespace Proj
{
    public partial class Form1 : Form
    {
        private NotebookService _NotebookService ;
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

        }
    }
}