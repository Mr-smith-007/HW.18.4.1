using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._18._4._1
{
    internal class GetDescriptionCommand : Icommand
    {
        Ireceiver getDescription;
        public GetDescriptionCommand(Ireceiver getDescription) 
        {
            this.getDescription = getDescription;
        }

        public void Run()
        {
            getDescription.Operation();
        }
    }
}
