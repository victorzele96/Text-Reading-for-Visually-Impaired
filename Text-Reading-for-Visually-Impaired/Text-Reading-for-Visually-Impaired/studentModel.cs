using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Reading_for_Visually_Impaired
{
   
    public class studentModel
    {
        public String ID;
        public String userName;
        public String firstName;
        public String lastName;

        public studentModel(String id, String userName,String firstN , String lastN)
        {
            this.ID = id;
            this.userName = userName;
            this.firstName = firstN;
            this.lastName = lastN;
        }
    }
}
