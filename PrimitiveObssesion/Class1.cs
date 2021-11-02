using System;

namespace PrimitiveObsession
{
    public class Class1
    {
       public Celsius temperature;
    }

    public class Celsius : IComparable, IEquatable<Celsius>
    {
        public const double AbsoluteZeroInCelsius = -273.15d;
        private double _value;
        
        public Celsius(double temperature) => this.Temperature = temperature;
        

        public double Temperature
        {
            get
            {
                if (!Validate(_value))
                {
                    throw new Exception();
                }
                return _value;
            }
            set
            { 
                if (!Validate(value))
                {
                    throw new Exception();
                }
                _value = value;
            }
        }

        private bool Validate(double value)
        {
            return value <= AbsoluteZeroInCelsius;
        }


        #region Operators
        public int CompareTo(object? obj)
        {
            if (ReferenceEquals(null, obj)) throw new ArgumentException();
            if (ReferenceEquals(this, obj)) return 0;
            if (obj.GetType() != this.GetType()) throw new ArgumentException();
            return this.Temperature.CompareTo(((Celsius) obj).Temperature);
        }
        
        public bool Equals(Celsius other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Temperature.Equals(other.Temperature);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Celsius) obj);
        }

        public override int GetHashCode()
        {
            return Temperature.GetHashCode();
        }
        
        public static explicit operator Celsius(double other)
        {
            return new Celsius(other);
        }
#endregion

    }
}