using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using DomainLayer;
using PresentationLayer;
using PresentationLayer.Views;

namespace MediaLibraryForms
{
    public partial class Form1 : Form, IView
    {
        public Form1()
        {

            InitializeComponent();
            
            PresentationLayer.BasePresenter basePresenter = new BasePresenter(this, new GameDal(), new MovieDal());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public event EventHandler ShowAllMovies;

        public event EventHandler SearchMovie;

        public event EventHandler SearchAllGames;

        public event EventHandler SearchGame;

        private void button1_Click(object sender, EventArgs e)
        {
            if (SearchMovie != null)
                SearchMovie(sender, e);
        }


        public void DisplayMovie(List<Movie> movies)
        {
            this.datagridViewMovies.DataSource = movies;
        }


        public string GetSearchTitle
        {
            get { return txtSearch.Text; }
        }
    }
}
