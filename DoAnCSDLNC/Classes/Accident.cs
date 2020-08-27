using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSDLNC.Classes
{
    class Accident
    {
        private int accidentId;
        private int contractId;
        private string accidentName;
        private string draftDate;
        private int payDamage;

        public Accident()
        {
            
        }

        public Accident(int accidentId, int contractId, string accidentName, string draftDate, int payDamage)
        {
            this.accidentId = accidentId;
            this.contractId = contractId;
            this.accidentName = accidentName;
            this.draftDate = draftDate;
            this.payDamage = payDamage;
        }

        public int AccidentId
        {
            get
            {
                return accidentId;
            }

            set
            {
                accidentId = value;
            }
        }

        public int ContractId
        {
            get
            {
                return contractId;
            }

            set
            {
                contractId = value;
            }
        }

        public string AccidentName
        {
            get
            {
                return accidentName;
            }

            set
            {
                accidentName = value;
            }
        }

        public string DraftDate
        {
            get
            {
                return draftDate;
            }

            set
            {
                draftDate = value;
            }
        }

        public int PayDamage
        {
            get
            {
                return payDamage;
            }

            set
            {
                payDamage = value;
            }
        }
    }
}
