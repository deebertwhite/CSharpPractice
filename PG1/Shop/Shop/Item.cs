//=============================================================================
// Program's Item class
//=============================================================================

using System.Runtime.InteropServices;

namespace Shop
{

    // TODO: Write a class called Item that contains 2 data members:
    //       A string called name and an int called cost.
    //       This class should have a default constructor that sets name to ""
    //       and cost to 0.
    //       It should also have an overloaded constructor.
    //
    //       Write accessors for each data member. They should be called GetName
    //       GetCost.
    //       Write mutators for each data member. They should be called SetName
    //       and SetCost.

    public class Item
    {
        string name;
        int cost;

        public Item()
        {
            name = "";
            cost = 0;
        }

        public Item(string IsName, int IsCost)
        {
            name = IsName;
            cost = IsCost;
        }

        public string GetName()
        {
            return name;
        }

        public int GetCost()
        {
            return cost;
        }

        public void SetName(string WhatName)
        {
            name = WhatName;
        }

        public void SetCost(int WhatCost)
        {
            cost = WhatCost;
        }
    }

}
