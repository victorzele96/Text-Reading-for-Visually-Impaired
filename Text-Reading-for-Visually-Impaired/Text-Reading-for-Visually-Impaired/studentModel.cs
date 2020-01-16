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

        public studentModel(String id, String userName)
        {
            this.ID = id;
            this.userName = userName;
        }
    }
}
