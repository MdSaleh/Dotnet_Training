namespace sample2
{
    public class propertiesDemo
    {
        private int age = 10;
        public int readAge {
            get { return age; }
            set { age = value; }
        }
        public decimal balance
        {
            get { return balance; }
            set {
                if (balance <= 20)
                {
                    throw new Exception("Minimam balance shoul;d be mainted");
                }
                balance = value;
            }
        }
    }

    internal class Program 
    {
        static void Main(string[] args)
        {
            HDFCSavingsAccount asmaSBAccount = new HDFCSavingsAccount();
            asmaSBAccount.CreateAccount();
            asmaSBAccount.getUserOnlineDetails();

            HDFCDematAccount salehaDematAcc = new HDFCDematAccount();
            salehaDematAcc.CreateAccount();
            salehaDematAcc.getUserOnlineDetails();
        }
    }

    public interface  HDFCTopCustomers : CoolFeaturesHDFC
    {
        void Homebankingservice();
        void FreeCreditCardService();
    }

    public interface CoolFeaturesHDFC
    {
        void CashBackPoints();
        void payFeesFDorFree();
    }
    public abstract class HDFCCustomer
    {
        public abstract void CreateAccount();
        public abstract void ModifyAccount();
        public abstract void DeleteAccount();
        public abstract void UpdateAccount();
        public void getUserOnlineDetails()
        {
            //get ip address
            //get network name
            //get geo location of customer

            Console.WriteLine("reading customer ip address, network address, geo location");
        }
    }

    public class HDFCNormalSavingsAccount : HDFCCustomer
    {
        public override void CreateAccount()
        {
            //check if adhaar is valid
            //chaeck if dob is in range, minimum 18yrs 
            //create account (in sb account table)
        }

        public override void DeleteAccount()
        {
            throw new NotImplementedException();
        }

        public override void ModifyAccount()
        {
            throw new NotImplementedException();
        }

        public override void UpdateAccount()
        {
            throw new NotImplementedException();
        }
    }


    public class HDFCTopSavingsAccount : HDFCCustomer, HDFCTopCustomers
    {
        public void CashBackPoints()
        {
            throw new NotImplementedException();
        }

        public override void CreateAccount()
        {
            //check if adhaar is valid
            //chaeck if dob is in range, minimum 18yrs 
            //create account (in sb account table)
        }

        public override void DeleteAccount()
        {
            throw new NotImplementedException();
        }

        public void FreeCreditCardService()
        {
            throw new NotImplementedException();
        }

        public void Homebankingservice()
        {
            throw new NotImplementedException();
        }

        public override void ModifyAccount()
        {
            throw new NotImplementedException();
        }

        public void payFeesFDorFree()
        {
            throw new NotImplementedException();
        }

        public override void UpdateAccount()
        {
            throw new NotImplementedException();
        }
    }

    public class HDFCDematAccount : HDFCCustomer
    {
        public override void CreateAccount()
        {
            //check if hdfc account already avalible
            //check if pan is valid 
            //check if no deafultation
            // check if adhaar valid
            //create demat account (demat account table)
        }

        public override void DeleteAccount()
        {
            throw new NotImplementedException();
        }

        public override void ModifyAccount()
        {
            throw new NotImplementedException();
        }

        public override void UpdateAccount()
        {
            throw new NotImplementedException();
        }
    }

}
