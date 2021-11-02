using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DRY
{
    public class Hands
    {
        private List<Hand> hands = new() {new Hand(), new Hand()};

        public Hand LeftHand => hands[0];
        public Hand RightHand => hands[1];

        public IEnumerator<Hand> GetEnumerator() => hands.GetEnumerator();
    }

    public class Hand
    {
        public object heldItem { get; }
    }
}