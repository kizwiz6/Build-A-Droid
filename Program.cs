namespace Build_A_Droid
{
    public class Droid
    {
        string name;
        int batteryLevel;

        public Droid(string droidName)
        {
            name = droidName;
            batteryLevel = 100;
        }

        public override string ToString()
        {
            return "Hello, I'm the droid: " + name;
        }

        public void performTask(string task)
        {
            Console.WriteLine(name + " is performing task: " + task);
            batteryLevel = batteryLevel - 10;
        }

        public void energyReport()
        {
            Console.WriteLine("Battery level: " + batteryLevel);
        }

        public static void Main(string[] args)
        {
            Droid Codey = new Droid("Codey");
            Console.WriteLine(Codey);
            Codey.performTask("Dancing");
            Codey.energyReport();
            Codey.performTask("Shake ya booty");
            Codey.energyReport();
        }
    }
}