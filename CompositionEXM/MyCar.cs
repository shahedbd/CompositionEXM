
namespace CompositionEXM
{
    public class MyCar
    {
        private Engine _Engine = new();
        private Wheel[] _Wheel = new Wheel[4];

        public MyCar()
        {
            for (int i = 0; i < 4; i++)
            {
                _Wheel[i] = new Wheel();
            }
        }

        public void StartCar()
        {
            _Engine.Start();
            Console.WriteLine("Car started.");
        }

        public void Drive()
        {
            foreach (var item in _Wheel)
            {
                item.Rotate();
            }
            Console.WriteLine("Car is driving.");
        }
    }
}
