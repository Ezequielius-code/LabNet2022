namespace EjercicioPOO.Classes
{
    public abstract class PublicTransport
    {
        private int numberOfPassengers;
        private byte unitNumber;

        public PublicTransport(byte unitNumber, int numberOfPassengers)
        {
            this.unitNumber = unitNumber;
            this.numberOfPassengers = numberOfPassengers;
        }

        public int NumberOfPassengers
        {
            get { return numberOfPassengers; }
            set { numberOfPassengers = value; }
        }

        public string MoveForward()
        {
            string message = "Vehicle is moving...";
            return message;
        }

        public string Stop()
        {
            string message = "The vehicle has stopped.";
            return message;
        }
    }
}
