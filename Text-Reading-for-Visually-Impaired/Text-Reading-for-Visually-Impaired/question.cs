using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Reading_for_Visually_Impaired
{
    public class question
    {
        public String name;
        public String questionString;
        public List<String> answers;
        public int CorrectAnsIndex;

        public question(String name, String question,List<String> answers, int correctAns)
        {
            this.name = name;
            this.questionString = question;
            this.answers = answers;
            this.CorrectAnsIndex = correctAns;

        }
    }


    
}
