namespace OCP
{

    //we have an required to add more membership pro and plus
    public class MemberShip
    {
        //old way
        //If we have to add new membership then we have to change this class

        //public int GetTrainings(string memberShipType)
        //{
        //    if (memberShipType == "Plus") {

        //        return 4;
        //    }
        //    else if(memberShipType=="Pro"){
        //        return 5;

        //    }
        //    return 2;
        //}

        public virtual int GetTrainings()
        {
            return 2;
        }
    }

    //new way we will use inheritance
    public class PlusMembership: MemberShip
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
        internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
