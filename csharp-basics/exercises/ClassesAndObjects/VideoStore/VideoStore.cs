using System;
using System.Collections.Generic;

namespace VideoStore
{
    class VideoStore
    {
        private List<Video> _videos;

        public VideoStore()
        {
            _videos = new List<Video>();
        }

        public void AddVideo(string title)
        {
            _videos.Add(new Video(title));
        }

        public void Checkout(string title)
        {
            foreach (var video in _videos)
            {
                if (video.Title == title)
                {
                    video.BeingCheckedOut();
                }
            }
        }

        public void ReturnVideo(string title)
        {
            foreach (var video in _videos)
            {
                if (video.Title == title)
                {
                    video.BeingReturned();
                }
            }
        }

        public void TakeUsersRating(double rating, string title)
        {
            foreach (var video in _videos)
            {
                if (video.Title == title)
                {
                    video.ReceivingRating(rating);
                }
            }
        }

        public void ListInventory()
        {
            foreach (var video in _videos)
            {
                Console.WriteLine(Convert.ToString(video));
            }
        }
    }
}
