using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSDLNC.Classes
{
    class Contract
    {
        private int contracId;
        private int customerId;
        private int tourId;
        private string draftDate;
        private string temimationDate;
        private string startTime;
        private int quantity;
        private int quantityDiscount;
        private int totalMoney;
        private int deposit;
        private string note;
        private int state;

        public int ContracId
        {
            get
            {
                return contracId;
            }

            set
            {
                contracId = value;
            }
        }

        public int CustomerId
        {
            get
            {
                return customerId;
            }

            set
            {
                customerId = value;
            }
        }

        public int TourId
        {
            get
            {
                return tourId;
            }

            set
            {
                tourId = value;
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

        public string TemimationDate
        {
            get
            {
                return temimationDate;
            }

            set
            {
                temimationDate = value;
            }
        }

        public string StartTime
        {
            get
            {
                return startTime;
            }

            set
            {
                startTime = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public int QuantityDiscount
        {
            get
            {
                return quantityDiscount;
            }

            set
            {
                quantityDiscount = value;
            }
        }

        public int TotalMoney
        {
            get
            {
                return totalMoney;
            }

            set
            {
                totalMoney = value;
            }
        }

        public int Deposit
        {
            get
            {
                return deposit;
            }

            set
            {
                deposit = value;
            }
        }

        public string Note
        {
            get
            {
                return note;
            }

            set
            {
                note = value;
            }
        }

        public int State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }

        public Contract(int contracId, int customerId, int tourId, string draftDate, string temimationDate, string startTime, int quantity, int quantityDiscount, int totalMoney, int deposit, string note, int state, int refunded)
        {
            this.ContracId = contracId;
            this.CustomerId = customerId;
            this.TourId = tourId;
            this.DraftDate = draftDate;
            this.TemimationDate = temimationDate;
            this.StartTime = startTime;
            this.Quantity = quantity;
            this.QuantityDiscount = quantityDiscount;
            this.TotalMoney = totalMoney;
            this.Deposit = deposit;
            this.Note = note;
            this.State = state;
        }

        public Contract()
        {

        }
    }
}
