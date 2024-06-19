using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace BookPackage
{
    internal class BookPackage
    {
        public delegate void BookHandler(string msg);
        private BookHandler _StatusBook { get; set; }

        public int MaxVolume { get; set; } = 50;
        public int CurrentUsing { get; set; }
        private bool _isFull;
        public void RegisterBook(BookHandler handler)
        {
            if (_StatusBook == null)
            {
                _StatusBook = handler;
            }
            else
            {
                _StatusBook = handler;
            }
        }
        public BookPackage() { }

        public BookPackage(int currentUsing, int maxVolume)
        {
            CurrentUsing = currentUsing;
            MaxVolume = maxVolume;

        }
        public void AddBook(int quantity)
        {
            if (_isFull)
            {
                _StatusBook?.Invoke("The package is full!");
            }
            else
            {
                CurrentUsing += quantity;
                if (CurrentUsing >= MaxVolume - 5)
                {
                    _StatusBook?.Invoke("The package is almost full!");
                }
                else if (CurrentUsing > MaxVolume)
                {
                    _isFull = true;
                }
                else
                {
                    Console.WriteLine("CurrentUsing = {0}", CurrentUsing);
                }
            }
        }
    }
}
