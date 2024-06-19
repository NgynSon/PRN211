using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvents
{
    internal class Car
    {
        public delegate void CarEngineHandler(object sender, CarEventArgs e);

        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;
        private CarEngineHandler _listOfHandlers { get; set; }

        public void RegisterCarEngine(CarEngineHandler handler)
        {
            if (_listOfHandlers == null)
            {
                _listOfHandlers = handler;
            }
            else
            {
                _listOfHandlers = handler;
            }
        }
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string CarName { get; set; }
        private bool _carIsDead;

        public Car() { }
        public Car(int currentSpeed, int maxSpeed, string carName)
        {
            CurrentSpeed = currentSpeed;
            MaxSpeed = maxSpeed;
            CarName = carName;
        }

        public void Accelerate(int speed)
        {
            if (_carIsDead)
            {
                _listOfHandlers?.EndInvoke("Sorry, this car id dead");
            }
            else
            {
                CurrentSpeed += speed;
                if (10 == (MaxSpeed - CurrentSpeed))
                {
                    _listOfHandlers?.Invoke("Careful buddy!");
                }
                else if (CurrentSpeed >= MaxSpeed)
                {
                    _carIsDead = true;
                }
                else
                {
                    Console.WriteLine("Current Speed = {0}", CurrentSpeed);
                }
            }
}
