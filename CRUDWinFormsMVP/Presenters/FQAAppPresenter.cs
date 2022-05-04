using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDWinFormsMVP.Models;
using CRUDWinFormsMVP.Views;

namespace CRUDWinFormsMVP.Presenters
{
    public class FQAAppPresenter
    {
        //Fields
        private IFQAAppView view;
        private IFQAAppRepository repository;
        private BindingSource fqaAppsBindingSource;
        private IEnumerable<FQAAppModel> fqaAppList;

        //Constructor
        public FQAAppPresenter(IFQAAppView view, IFQAAppRepository repository)
        {
            this.fqaAppsBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchPet;
            this.view.AddNewEvent += AddNewPet;
            this.view.EditEvent += LoadSelectedPetToEdit;
            this.view.DeleteEvent += DeleteSelectedPet;
            this.view.SaveEvent += SavePet;
            this.view.CancelEvent += CancelAction;
            //Set pets bindind source
            this.view.SetFQAAppListBindingSource(fqaAppsBindingSource);
            //Load pet list view
            LoadAllFQAAppList();
            //Show view
            this.view.Show();
        }

        //Methods
        private void LoadAllFQAAppList()
        {
            fqaAppList = repository.GetAll();
            fqaAppsBindingSource.DataSource = fqaAppList;//Set data source.
        }
        private void SearchPet(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            var fqaSearchAppList = new List<FQAAppModel>();
            if (emptyValue == false)
            {
                //fqaAppList = repository.GetByValue(this.view.SearchValue);
                fqaSearchAppList.AddRange(fqaAppList.Where(x => x.Answers.Contains(this.view.SearchValue)||x.Question.Contains(this.view.SearchValue)).ToList());
                fqaAppsBindingSource.DataSource = fqaSearchAppList;
            }
            else
            {
                fqaAppList = repository.GetAll();
                //fqaAppList.Any(x => x.Answers.Contains(this.view.SearchValue));
                fqaAppsBindingSource.DataSource = fqaAppList;
            }
            
        }
        private void AddNewPet(object sender, EventArgs e)
        {
            view.IsEdit = false;          
        }
        private void LoadSelectedPetToEdit(object sender, EventArgs e)
        {
            var fqaApp = (FQAAppModel)fqaAppsBindingSource.Current;
            view.Answers = fqaApp.Answers;
            view.Question = fqaApp.Question;
            view.Id = fqaApp.ID.ToString();
            view.QuestionType = fqaApp.QuestionType.ToString();
            view.IsEdit = true;
        }
        private void SavePet(object sender, EventArgs e)
        {
            var model = new FQAAppModel();
            model.Answers = view.Answers;
            model.Question = view.Question;
            model.ID = Convert.ToInt32(view.Id);
            model.QuestionType = Convert.ToByte(view.QuestionType);
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if(view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "FQAApp edited successfuly";
                }
                else //Add new model
                {
                    repository.Add(model);
                    view.Message = "FQAApp added sucessfully";
                }
                view.IsSuccessful = true;
                LoadAllFQAAppList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            view.Answers = "0";
            view.Question = "";
            view.Id = "";
            view.QuestionType = "";            
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }
        private void DeleteSelectedPet(object sender, EventArgs e)
        {
            try
            {
                var fqqApp = (FQAAppModel)fqaAppsBindingSource.Current;
                repository.Delete(fqqApp.ID);
                view.IsSuccessful = true;
                view.Message = "Pet deleted successfully";
                LoadAllFQAAppList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete pet";
            }
        }

    }
}
