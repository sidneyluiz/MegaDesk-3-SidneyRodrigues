using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_SidneyRodrigues
{
    public partial class MainMenu : Form
    {
        

        public MainMenu()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DisplayQuote viewQuotes = new DisplayQuote();
            viewQuotes.Tag = this;
            viewQuotes.Show(this);
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchQuotes searchForQuotes = new SearchQuotes();
            searchForQuotes.Tag = this;
            searchForQuotes.Show(this);
            Hide();
        }
    }
}
