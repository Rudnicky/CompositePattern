namespace CompositePattern.MotorbikeConcept
{
    public class Motorbike : IMotorbike
    {
        public Motorbike()
        {

        }

        public void OpenSink(bool left)
        {
            if (left)
            {
                System.Console.WriteLine("Sink opened");
            }
            else
            {
                System.Console.WriteLine("Sink closed");
            }
        }

        public void PowerOffLights()
        {
            System.Console.WriteLine("Light's are turned off");
        }

        public void PowerOnLights()
        {
            System.Console.WriteLine("Light's are turned on");
        }

        public void StartEngine()
        {
            System.Console.WriteLine("Engine has started");
        }

        public void StopEngine()
        {
            System.Console.WriteLine("Engine has started");
        }
    }
}
