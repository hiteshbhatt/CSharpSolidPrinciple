namespace LSP
{

    //we have a trial membership we know that trail member is not saved into database as it is a lead it cannot be inculded as memebership 
    // but now our system will work as 
    // To solve it we will do interface seggregation

    public interface ITraining
    {
        int GetTrainings();
    }

    public interface IMembership : ITraining
    {
        void add();
    }
    public class MemberShip : IMembership
    {
        public virtual void add()
        {
            ////Do database operation
        }

        public virtual int GetTrainings()
        {
            return 2;
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
    internal class Program
    {
        static void Main(string[] args)
        {

            List<MemberShip> members = new List<MemberShip>();

            //follow LSP as child class replace parent class object
            members.Add(new PlusMembership());
            members.Add(new ProMembership());
            //  members.Add(new TrialMembership());

            foreach (var member in members)
            {
                member.add(); // for trial it will throw exception LSP rule will break child class replace parent without breaking code
            }

            Console.WriteLine("Hello, World!");
        }
    }
}
