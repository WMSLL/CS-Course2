using System;
namespace ClassWork13
{
    abstract class AirTransport
    {
        public int MaxHeight { get; private set; }
        public int CurrentHeight { get; private set; }

        public void SetCurrentHeight(int sets)
        {
            CurrentHeight = sets;
          
        }
        public AirTransport(int maxHeight)
        {

        }
         public  void TakeUpper(int delta)
        {
            if (delta<=0)
            {
                new ArgumentOutOfRangeException();
            }
            if (CurrentHeight+delta> MaxHeight)
            {
                CurrentHeight = MaxHeight;
            }
            else
            {
                CurrentHeight = CurrentHeight + delta;
            }
        }
        public void TakeLower(int delta)
        {
            if (delta <= 0)
            {
                new ArgumentOutOfRangeException();
            }
            if (CurrentHeight - delta > 0)
            {
                CurrentHeight = CurrentHeight - delta;
            }
            else if(CurrentHeight - delta==0)
            {
                CurrentHeight = CurrentHeight - delta;
            }
            else if (CurrentHeight - delta <0)
            {
                new InvalidOperationException("Crash");
            }
        }

        public abstract void WriteAllProperties();
    }
}
