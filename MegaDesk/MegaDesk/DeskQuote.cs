using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MegaDesk
{

    class DeskQuote
    {
        public const int BASECOST = 200;
        private static String firstName;
        private static String lastName;
        private static int totalCost;
        private static int sizeCost;
        private static int drawerCost;
        private static int materialCost;
        private static int rushCost;
        private static ArrayList quotes;
        private Dictionary<int, int> rushSmallDict;
        private Dictionary<int, int> rushMedDict;
        private Dictionary<int, int> rushLargeDict;
        private static Desk desk;
        private static String purchaseDate;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int TotalCost { get => totalCost; set => totalCost = value; }
        public ArrayList Quotes { get => quotes; set => quotes = value; }
        public int RushCost { get => rushCost; set => rushCost = value; }
        internal Desk Desk { get => desk; set => desk = value; }
        public string PurchaseDate { get => purchaseDate; set => purchaseDate = value; }

        public DeskQuote()
        {
            
        }

        public int buildDesk(int width, int depth)
        {
            desk = new Desk();
            desk.Width = width;
            desk.Depth = depth;
            return width * depth;
        }

        public int calcCost(int area, int drawers, String material)
        {
            switch (material)
            {
                case ("Laminate"):
                    materialCost = 100;
                    break;
                case ("Oak"):
                    materialCost = 200;
                    break;
                case ("Pine"):
                    materialCost = 50;
                    break;
                case ("Rosewood"):
                    materialCost = 300;
                    break;
                default:
                    materialCost = 125;
                    break;
            }
            drawerCost = drawers * 50;

            if (area > 1000)
            {
                sizeCost = area - 1000;
            }

            return area + BASECOST + sizeCost + drawerCost + materialCost;
        }

        public int calcRush(int deskSize, int days)
        {
            rushSmallDict = new Dictionary<int, int>();
            rushSmallDict.Add(3, 60);
            rushSmallDict.Add(5, 40);
            rushSmallDict.Add(7, 30);

            rushMedDict = new Dictionary<int, int>();
            rushMedDict.Add(3, 70);
            rushMedDict.Add(5, 50);
            rushMedDict.Add(7, 35);

            rushLargeDict = new Dictionary<int, int>();
            rushLargeDict.Add(3, 80);
            rushLargeDict.Add(5, 60);
            rushLargeDict.Add(7, 40);

            if (deskSize <= 1000)
            {
                rushCost = rushSmallDict[days];
            }
            else if (deskSize > 1000 && deskSize <= 2000)
            {
                rushCost = rushMedDict[days];
            }
            else
            {
                rushCost = rushLargeDict[days];
            }
            return rushCost;
        }

        public void saveQuote()
        {;
            DeskQuote customerQuote = new DeskQuote();
            customerQuote.Desk = desk;
        }
    }
}
