using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CRUDWinFormsMVP.Models
{
    public class FQAAppModel
    {
        //Fields
        private string answers;
        private string question;
        private int id;
        private int questionType;

        //Properties - Validations
        [DisplayName("Answers")]
        public string Answers
        {
            get { return answers; }
            set { answers = value; }
        }

        [DisplayName("Question")]
        public string Question
        {
            get { return question; }
            set { question = value; }
        }

        [DisplayName("ID")]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        
        [DisplayName("Question Type")]
        public int QuestionType
        {
            get { return questionType; }
            set { questionType = value; }
        }
    }
}
