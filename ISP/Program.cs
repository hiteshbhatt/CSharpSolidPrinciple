namespace LSP
{

   //suppose we want to introduce LiveTraining functionality that should be include in PremiumMemberShip
   //if we include LiveTrainig in ITraining then Trial will fail so we will create seprate interface for it

   
    public interface ITraining
    {
        int GetTrainings();
    }

    public interface IMembership : ITraining
    {
        void add();
    }

    public interface ILiveTraining: IMembership 
    {
        void LiveTraining();
    }
    public class MemberShip : IMembership, ILiveTraining
    {
        public virtual void add()
        {
            ////Do database operation
        }

        public virtual int GetTrainings()
        {
            return 2;
        }

        public void LiveTraining()
        {
            
        }
    }

    //new way we will use inheritance
    public class PlusMembership : MemberShip
    {
        public override int GetTrainings()
        {
            return 4;
        }
    }

    public class ProMembership : MemberShip
    {
        public override int GetTrainings()
        {
            return 5;
        }
    }

    //public class TrialMembership : MemberShip
    //{
    //    // we cannot do any databse operation we will throw not implemented operation
    //    public override void add()
    //    {
    //        throw new NotImplementedException("Trial membership data cannot be saved into database");
    //    }
    //    public override int GetTrainings()
    //    {
    //        return 2;
    //    }
    //}

    public class TrailMemberShip : ITraining
    {


        public int GetTrainings()
        {
            return 2;
        }
    }

    public class PremiumMemberShip : ILiveTraining
    {
        public void add()
        {
            //db operation
        }

        public int GetTrainings()
        {
            return 4;
        }

        public void LiveTraining()
        {
           
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //100 old clients : self-paced
            IMembership membership1 = new MemberShip();
            membership1.add();

            //new clients Livetraining + self-paced
            ILiveTraining membership2 = new MemberShip();
            membership2.LiveTraining();
        }
    }
}

