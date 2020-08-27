using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSDLNC.Classes
{
    class Refund
    {
        private int refundId;
        private int minDay;
        private int maxDay;
        private int refundRate;

        public Refund()
        {
            
        }

        public Refund(int refundId, int minDay, int maxDay, int refundRate)
        {
            this.refundId = refundId;
            this.minDay = minDay;
            this.maxDay = maxDay;
            this.refundRate = refundRate;
        }

        public int RefundId
        {
            get
            {
                return refundId;
            }

            set
            {
                refundId = value;
            }
        }

        public int MinDay
        {
            get
            {
                return minDay;
            }

            set
            {
                minDay = value;
            }
        }

        public int MaxDay
        {
            get
            {
                return maxDay;
            }

            set
            {
                maxDay = value;
            }
        }

        public int RefundRate
        {
            get
            {
                return refundRate;
            }

            set
            {
                refundRate = value;
            }
        }
    }
}
