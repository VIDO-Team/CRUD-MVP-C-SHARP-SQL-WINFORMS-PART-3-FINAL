using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDWinFormsMVP.Views
{
    public partial class FQAView : Form, IFQAAppView
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        //Constructor
        public FQAView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageFQADetail);
            tabControl1.TabPages.Remove(tabPageAddQuestion);
            btnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            //Search
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
              {
                  if (e.KeyCode == Keys.Enter)
                      SearchEvent?.Invoke(this, EventArgs.Empty);
              };
            //Add new
            btnAddFQA.Click += delegate
            {
                ClearData();
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageFQAList);
                tabControl1.TabPages.Add(tabPageFQADetail);
                tabPageFQADetail.Text = "Add FQA";
            };
            btnAddQuestion.Click += delegate
            {
                textId.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
                txtviewans.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
                AddQuestionEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageFQAList);
                tabControl1.TabPages.Add(tabPageAddQuestion);
                tabPageAddQuestion.Text = "Add Question";
            };
            btnAddFQADetails.Click += delegate
            {
                AddFQADetails?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageAddQuestion);
                    tabControl1.TabPages.Add(tabPageFQAList);
                }
                MessageBox.Show(Message);
            };
            //Edit
            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageFQAList);
                tabControl1.TabPages.Add(tabPageFQADetail);
                tabPageFQADetail.Text = "Edit FQA";
                textId.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
                txtviewans.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
                txtquestion.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
                cboxquestiontype1.SelectedIndex = (int)dataGridView.CurrentRow.Cells[3].Value;
                lbquestionId.Text =dataGridView.CurrentRow.Cells[4].Value.ToString();
                //dgvans.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            };

            //Save changes
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageFQADetail);
                    tabControl1.TabPages.Add(tabPageFQAList);
                }
                MessageBox.Show(Message);
            };
            //Cancel
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageFQADetail);
                tabControl1.TabPages.Add(tabPageFQAList);
            };
            btncancel1.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageAddQuestion);
                tabControl1.TabPages.Add(tabPageFQAList);
            };
            //Delete
            //btnDelete.Click += delegate
            //{
            //    var result = MessageBox.Show("Are you sure you want to delete the selected question?", "Warning",
            //          MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //    if (result == DialogResult.Yes)
            //    {
            //        DeleteEvent?.Invoke(this, EventArgs.Empty);
            //        MessageBox.Show(Message);
            //    }
            //};
            btnDeleteFQA.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected question?", "Warning",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        private void ClearData()
        {
            txtId.Text = "0";
            tbAnswer.Text = "";
            txtquestion.Text = "";
        }

        

        public string SearchValue
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }

        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }

        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public string Id { get { return txtId.Text; } set { txtId.Text = value; } }
        public string AddQuestionId { get { return textId.Text; } set { textId.Text = value; } }
        public string QuestionId { get { return lbquestionId.Text; } set { lbquestionId.Text = value; } }
        public string Type { get { return cboxquestiontype.Text; } set { cboxquestiontype.Text = value; } }
        public string Answer { get { return tbAnswer.Text; } set { tbAnswer.Text = value; } }
        public string Stt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Answers { get { return tbAnswer.Text; } set { tbAnswer.Text = value; } }
        public string Question { get { return txtquestion.Text; } set { txtquestion.Text = value; } }
        public string QuestionType { get { return cboxquestiontype1.SelectedIndex.ToString(); } set { int index = Int32.Parse(value); cboxquestiontype1.SelectedIndex = index; } }
        public string AddQuestion { get { return textquestion.Text; } set { textquestion.Text = value; } }
        public string AddQuestionType { get { return cboxquestiontype.SelectedIndex.ToString(); } set { int index = Int32.Parse(value); cboxquestiontype.SelectedIndex = index; } }


        string IFQAAppView.QuestionId { get {return lbquestionId.Text; } set { lbquestionId.Text = value; } }
        

        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler AddQuestionEvent;
        public event EventHandler CancelQuestionEvent;
        public event EventHandler AddFQADetails;

        //Methods


        //Singleton pattern (Open a single form instance)
        private static FQAView instance;
        public static FQAView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FQAView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

        /*        public void SetFQAListBindingSource(BindingSource fqaList)
                {
                    dataGridView.DataSource = fqaList;
                }*/

        public void SetFQAAppListBindingSource(BindingSource fqaAppList)
        {
            dataGridView.DataSource = fqaAppList;
            //dgvans.DataSource = fqaAppList;


        }

        public void SetQuestionListBindingSource(BindingSource fqaDetails)
        {
            dgvQuestions.DataSource = fqaDetails;
            //dgvQuestions.Columns.RemoveAt(0);
        }
    }
}
