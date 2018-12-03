using System;

namespace CompositePattern.MotorbikeConcept
{
    public class Triumph : IMotorbike
    {
        private readonly IMotorbike _motorbike;

        public Triumph(IMotorbike motorbike)
        {
            this._motorbike = motorbike;
        }

        public void OpenSink(bool left)
        {
            _motorbike.OpenSink(left);
        }

        public void PowerOffLights()
        {
            _motorbike.PowerOffLights();
        }

        public void PowerOnLights()
        {
            _motorbike.PowerOnLights();
        }

        public void StartEngine()
        {
            Console.WriteLine("Let's start Triumph Engine!");

            _motorbike.StartEngine();
        }

        public void StopEngine()
        {
            Console.WriteLine("Let's stop Triumph Engine!");

            _motorbike.StopEngine();
        }
    }
}
