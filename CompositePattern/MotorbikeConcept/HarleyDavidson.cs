using System;

namespace CompositePattern.MotorbikeConcept
{
    public class HarleyDavidson : IMotorbike
    {
        private readonly IMotorbike _motorbike;

        public HarleyDavidson(IMotorbike motorbike)
        {
            this._motorbike = motorbike;
        }

        public void OpenSink(bool left)
        {
            _motorbike.OpenSink(left);
        }

        public void PowerOffLights()
        {
            Console.WriteLine("Let's power off Harley lights");
            _motorbike.PowerOffLights();
        }

        public void PowerOnLights()
        {
            Console.WriteLine("Let's power on Harley lights");
            _motorbike.PowerOnLights();
        }

        public void StartEngine()
        {
            _motorbike.StartEngine();
        }

        public void StopEngine()
        {
            _motorbike.StopEngine();
        }
    }
}
