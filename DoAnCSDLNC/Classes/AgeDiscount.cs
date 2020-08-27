using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSDLNC.Classes
{
    class AgeDiscount
    {
        private int discountId;
        private int minAge;
        private int maxAge;
        private int discountRate;

        public AgeDiscount()
        {
            
        }

        public AgeDiscount(int discountId, int minAge, int maxAge, int discountRate)
        {
            this.discountId = discountId;
            this.minAge = minAge;
            this.maxAge = maxAge;
            this.discountRate = discountRate;
        }

        public int DiscountId
        {
            get
            {
                return discountId;
            }

            set
            {
                discountId = value;
            }
        }

        public int MinAge
        {
            get
            {
                return minAge;
            }

            set
            {
                minAge = value;
            }
        }

        public int MaxAge
        {
            get
            {
                return maxAge;
            }

            set
            {
                maxAge = value;
            }
        }

        public int DiscountRate
        {
            get
            {
                return discountRate;
            }

            set
            {
                discountRate = value;
            }
        }
    }
}
