using System;
using System.IO;
using System.Collections.Generic;

class Player
{
    int win, loss, tie;
    string name;

    public Player(int w, int l, int t, string n)
    {
        this.win = w;
        this.loss = l;
        this.tie = t;
        this.name = n;
    }
}