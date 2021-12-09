using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class Video
    {
        private string _title;
        private bool _checkOutIn;
        private List<double> _raiting;

        public Video(string title)
        {
            _title = title;
            _checkOutIn = true;
            _raiting = new List<double>();
        }

        public bool BeingCheckedOut()
        {
            return _checkOutIn = false;
        }

        public bool BeingReturned()
        {
            return _checkOutIn = true;
        }

        public void ReceivingRating(double rating)
        {
            _raiting.Add(rating);
        }

        public double AverageRating()
        {
            return _raiting.Sum() / _raiting.Count;
        }

        public bool Available()
        {
            return _checkOutIn;
        }

        public string Title => _title;

        public override string ToString()
        {
            return $"{Title} {AverageRating()} {Available()}";
        }
    }
}
