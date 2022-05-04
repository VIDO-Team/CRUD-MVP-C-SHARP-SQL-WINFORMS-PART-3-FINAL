using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CRUDWinFormsMVP.Models
{
    public class FQAModel
    {
        //Fields
        private int id;
        private string type;
        private string answers;
        private byte stt;

        //Properties - Validations
        [DisplayName("FQA ID")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DisplayName("Type")]
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        [DisplayName("Answers")]
        public string Answers
        {
            get { return answers; }
            set { answers = value; }
        }
        
        [DisplayName("STT")]
        public byte Stt
        {
            get { return stt; }
            set { stt = value; }
        }
    }
}
