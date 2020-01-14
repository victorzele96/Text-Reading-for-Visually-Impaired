using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Reading_for_Visually_Impaired
{
    public class question
    {
        public String ID;
        public String questionString;
        public List<String> answers;
        public int CorrectAnsIndex;
        public Boolean answered = false;
        public Boolean rightAnswered = false;

        public question(String name, String question,List<String> answers)
        {
            this.ID = name;
            this.questionString = question;
            this.answers = answers;
        }
    }


    
}
