﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsInCSharp.KataWithPatterns
{
    /// <summary>
    /// Source: https://github.com/emilybache/GildedRose-Refactoring-Kata/tree/master/csharpcore
    /// Instructions: https://github.com/ardalis/kata-catalog/blob/master/katas/Gilded%20Rose.md
    /// Cannot change the Items collection
    /// </summary>
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                UpdateQuality(new ItemProxy(item));
            }
        }
        public void UpdateQuality(ItemProxy item)
        {

                if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (item.Name != "Sulfuras, Hand of Ragnaros")
                    {
                        item.DecrementQuality();
                    }
                }
                else
                {

                        item.IncrementQuality();

                        if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (item.SellIn < 11)
                            {
                                if (item.Quality < 50)
                                {
                                    item.IncrementQuality();
                                }
                            }

                            if (item.SellIn < 6)
                            {

                                    item.IncrementQuality();
                                
                            }
                        }
                    
                }

                if (item.Name != "Sulfuras, Hand of Ragnaros")
                {
                    item.DecrementSellIn();
                }

                if (item.SellIn < 0)
                {
                    if (item.Name != "Aged Brie")
                    {
                        if (item.Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                                if (item.Name != "Sulfuras, Hand of Ragnaros")
                                {
                                    item.DecrementQuality();
                                }
                        }
                        else
                        {
                            item.ResetQuality();
                        }
                    }
                    else
                    {
                            item.IncrementQuality();
                    }
                }
        }
    }
}
