using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CRUDWinFormsMVP.Models
{
    public class FQADetailsModel
    {
        
        private string question;
        private int questionType;

        //Properties - Validations

        [DisplayName("Question")]
        public string Question
        {
            get { return question; }
            set { question = value; }
        }
        
        [DisplayName("Question Type")]
        public int QuestionType
        {
            get { return questionType; }
            set { questionType = value; }
        }
    }
}
