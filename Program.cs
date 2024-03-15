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

        public void energyTransfer(Droid otherDroid)
        {
            int transferAmount = (batteryLevel + otherDroid.batteryLevel) / 2;
            batteryLevel = transferAmount;
            otherDroid.batteryLevel = transferAmount;
        }

        public static void Main(string[] args)
        {
            Droid Codey = new Droid("Codey");
            Droid R2D2 = new Droid("R2D2");

            Console.WriteLine(Codey);
            Codey.performTask("Dancing");
            Codey.energyReport();

            Console.WriteLine(R2D2);
            R2D2.performTask("Calculating hyperspace routes");
            R2D2.energyReport();


            Codey.energyTransfer(R2D2);

            Console.WriteLine("After energy transfer:");
            Codey.energyReport();
            R2D2.energyReport();

        }
    }
}