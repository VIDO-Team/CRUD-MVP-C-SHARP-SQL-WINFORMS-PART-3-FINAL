using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDWinFormsMVP.Views
{
    public interface IFQAAppView
    {
        //Properties - Fields
        string Answer { get; set; }
        string Question { get; set; }
        string Id { get; set; }
        string AddQuestionId { get; set; }
        string QuestionId { get; set; }
        string QuestionType { get; set; }

        string AddQuestionType { get; set; }
        string AddQuestion { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler AddQuestionEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler CancelQuestionEvent;
        event EventHandler AddFQADetails;

        //Methods
        void SetFQAAppListBindingSource(BindingSource fqaAppList);
        void SetQuestionListBindingSource(BindingSource fqaDetails);
        void Show();//Optional

    }
}
