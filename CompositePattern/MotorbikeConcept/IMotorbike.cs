namespace CompositePattern.MotorbikeConcept
{
    public interface IMotorbike
    {
        void StartEngine();

        void StopEngine();

        void PowerOnLights();

        void PowerOffLights();

        void OpenSink(bool left);
    }
}
