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
        string QuestionId { get; set; }
        string QuestionType { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void SetFQAAppListBindingSource(BindingSource fqaAppList);
        void Show();//Optional

    }
}
