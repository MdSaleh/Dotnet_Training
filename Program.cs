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

    internal class Program : propertiesDemo
    {
        static void Main(string[] args)
        {
            benzCar benzCar = new benzCar();
            benzCar.carCount();

            propertiesDemo propertiesDemo = new propertiesDemo();
            Console.WriteLine(propertiesDemo.readAge);
        }
    }

    public abstract class vehicletempalte 
    {
        public abstract void start();
        public abstract void stop();
        public abstract void horn();
        public string carCount()
        {
            return "3";
        }
    }

    public interface Ivehicleextrafacilicites
    {
        public void startAC();
    }

    public class benzCar : vehicletempalte, Ivehicleextrafacilicites
    {
        public override void start()
        {
            Console.WriteLine("car started");
        }
        public override void stop()
        {
            Console.WriteLine("car stopped");
        }
        public override void horn()
        {
            Console.WriteLine("car hoking");
        }
        public void startAC()
        {
            Console.WriteLine("AC started 30");
        }
    }

    public class AudiCar : benzCar
        public override void start()
        {
            Console.WriteLine("car started");
        }
        public override void stop()
        {
            Console.WriteLine("car stopped");
        }
        public override void horn()
        {
            Console.WriteLine("car hoking");
        }
        public void startAC()
        {
            Console.WriteLine("AC started 15");
        }
    }

}
