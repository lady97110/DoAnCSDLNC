using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSDLNC.Classes
{
    class Tour
    {
        private int tourId;
        private string startLocation;
        private string destination;
        private string startDate;
        private string endDate;
        private int totalSeat;
        private int emptySeat;
        private int price;

        public Tour()
        {

        }

        public Tour(int tourId, string startLocation, string destination, string startDate, string endDate, int totalSeat, int emptySeat, int price)
        {
            this.tourId = tourId;
            this.startLocation = startLocation;
            this.destination = destination;
            this.startDate = startDate;
            this.endDate = endDate;
            this.totalSeat = totalSeat;
            this.emptySeat = emptySeat;
            this.price = price;
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

        public string StartLocation
        {
            get
            {
                return startLocation;
            }

            set
            {
                startLocation = value;
            }
        }

        public string Destination
        {
            get
            {
                return destination;
            }

            set
            {
                destination = value;
            }
        }

        public string StartDate
        {
            get
            {
                return startDate;
            }

            set
            {
                startDate = value;
            }
        }

        public string EndDate
        {
            get
            {
                return endDate;
            }

            set
            {
                endDate = value;
            }
        }

        public int TotalSeat
        {
            get
            {
                return totalSeat;
            }

            set
            {
                totalSeat = value;
            }
        }

        public int EmptySeat
        {
            get
            {
                return emptySeat;
            }

            set
            {
                emptySeat = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
    }
}
