




using System;

namespace DesignPatternsInCSharp.KataWithPatterns
{
    public class ItemProxy
    {
        private Item _item;

        public ItemProxy(Item item)
        {
            _item = item;
        }

        public string Name => _item.Name;
        public int Quality => _item.Quality;

        public int SellIn => _item.SellIn;

        public void DecrementQuality()
        {
            _item.Quality--;
        }

        public void IncrementQuality()
        {
            _item.Quality++;
        }
        public void DecrementSellIn()
        {
            _item.SellIn--;
        }

        public void IncrementSellIn()
        {
            _item.SellIn--;
        }

        internal void ResetQuality()
        {
            throw new NotImplementedException();
        }
    }
}