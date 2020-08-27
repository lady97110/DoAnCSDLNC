using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSDLNC.Classes
{
    class Member
    {
        private int contracId;
        private int memberId;
        private string name;
        private string dob;
        private string identification;
        private int ageDiscount;
        private int memberPrice;

        public Member()
        {
            
        }

        public Member(int contracId, int memberId, string name, string dob, string identification, int ageDiscount, int memberPrice)
        {
            this.contracId = contracId;
            this.memberId = memberId;
            this.name = name;
            this.dob = dob;
            this.identification = identification;
            this.ageDiscount = ageDiscount;
            this.memberPrice = memberPrice;
        }

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

        public int MemberId
        {
            get
            {
                return memberId;
            }

            set
            {
                memberId = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Dob
        {
            get
            {
                return dob;
            }

            set
            {
                dob = value;
            }
        }

        public string Identification
        {
            get
            {
                return identification;
            }

            set
            {
                identification = value;
            }
        }

        public int AgeDiscount
        {
            get
            {
                return ageDiscount;
            }

            set
            {
                ageDiscount = value;
            }
        }

        public int MemberPrice
        {
            get
            {
                return memberPrice;
            }

            set
            {
                memberPrice = value;
            }
        }
    }
}
