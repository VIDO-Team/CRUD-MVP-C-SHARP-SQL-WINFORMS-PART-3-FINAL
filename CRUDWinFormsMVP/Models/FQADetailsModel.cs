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
        //Fields
        private int id;
        private int fqaId;
        private string question;
        private int questionType;

        //Properties - Validations
        [DisplayName("ID")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DisplayName("FQA ID")]
        public string FQAId
        {
            get { return FQAId; }
            set { FQAId = value; }
        }

        [DisplayName("Question")]
        public string Question
        {
            get { return Question; }
            set { Question = value; }
        }
        
        [DisplayName("Question Type")]
        public byte QuestionType
        {
            get { return QuestionType; }
            set { QuestionType = value; }
        }
    }
}
