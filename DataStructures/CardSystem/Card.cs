﻿using System;
using System.Collections.Generic;
using System.Text;
using OhmsLibraries.DataStructures;

namespace OhmsLibraries.GenericDataStructures.CardSystem {
    public partial class Card<T> where T : CardData {
        public T data;
        private int category;
        public int Category {
            get {
                return category;
            }
        }

        public Card ( T data, int category, int appearance ) {
            this.data = data;
            this.category = category;
            this.appearance = appearance;
        }

        public bool Corresponds<W> ( Card<W> other ) where W : CardData {
            return other.category == category;
        }

        public bool Corresponds ( int other ) {
            return other == category;
        }
    }

    public class CardData {

    }
}
