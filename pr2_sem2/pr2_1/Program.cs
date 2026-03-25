using pr2._2._2;

namespace pr2_sem2
{
    class Program
    {
        //ex1
        static void Main()
        {
            TemperatureSensor sensor = new TemperatureSensor();

            Display display = new Display();
            AirConditioner airConditioner = new AirConditioner();
            SecuritySystem security = new SecuritySystem();

            sensor.TemperatureChanged += display.ShowTemperature;
            sensor.TemperatureChanged += airConditioner.Update;
            sensor.TemperatureChanged += security.CheckTemperature;

            sensor.SetTemperature(10);
            sensor.SetTemperature(20);
            sensor.SetTemperature(30);
            sensor.SetTemperature(45);
            sensor.SetTemperature(2);
        }

    }
}
