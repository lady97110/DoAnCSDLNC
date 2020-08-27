using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSDLNC.Classes
{
    class QuantityDiscount
    {
        private int discountId;
        private int minQuantity;
        private int maxQuantity;
        private int discountRate;

        public QuantityDiscount()
        {
            
        }

        public QuantityDiscount(int discountId, int minQuantity, int maxQuantity, int discountRate)
        {
            this.discountId = discountId;
            this.minQuantity = minQuantity;
            this.maxQuantity = maxQuantity;
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

        public int MinQuantity
        {
            get
            {
                return minQuantity;
            }

            set
            {
                minQuantity = value;
            }
        }

        public int MaxQuantity
        {
            get
            {
                return maxQuantity;
            }

            set
            {
                maxQuantity = value;
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
