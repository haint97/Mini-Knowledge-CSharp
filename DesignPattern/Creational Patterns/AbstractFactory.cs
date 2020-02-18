using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational_Patterns
{
    // creating families of related or dependent objects without specifying their concrete classes.
    class AbstractFactory
    {
        public static void RunDemo()
        {


            TransportFactory yamahaFactory = new YamahaFactory();
            TransportWorld world = new TransportWorld(yamahaFactory);
            world.Produce();

            TransportFactory hondaFactory = new HondaFactory();
             world = new TransportWorld(hondaFactory);
            world.Produce();


        }
    }

    abstract class Bike
    {

    }
    abstract class MotorBike
    {
        public abstract void Specification();
    }

    abstract class TransportFactory
    {
        public abstract Bike ProduceBike();
        public abstract MotorBike ProduceMotorbike();

    }

     class HondaFactory : TransportFactory
    {
        public override Bike ProduceBike()
        {
            return new HondaBike();
        }

        public override MotorBike ProduceMotorbike()
        {
            new HondaMotorBike();
        }
    }
    class YamahaFactory : TransportFactory
    {
        public override Bike ProduceBike()
        {
            return new YamahaBike();
        }

        public override MotorBike ProduceMotorbike()
        {
           return new YamahaMotorBike();
        }
    }


    class HondaBike : Bike
    {

    }
    class YamahaBike : Bike
    {

    }


    class HondaMotorBike : MotorBike
    {
        public override void Specification()
        {
            Console.WriteLine(this.GetType().Name +
        " belong " + " Honda");
        }
    }
    class YamahaMotorBike : MotorBike
    {
        public override void Specification()
        {
            Console.WriteLine(this.GetType().Name +
       " belong " + " yamaha");
        }
    }


    /// <summary>
    /// The 'Client' class 
    /// </summary>

    class TransportWorld

    {
        Bike _bike;
        MotorBike _motorBike;

        // Constructor

        public TransportWorld(TransportFactory factory)
        {
            _bike = factory.ProduceBike();
            _motorBike = factory.ProduceMotorbike();
        }

        public void Produce()
        {
            _bike.ToString();
            _motorBike.ToString();
        }

    }
}
