using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{

    enum DesktopMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }

    class Desk
    {
        private static int width;
        private static int depth;
        private static int drawerNum;
        private static String materialType;
        public const int MIN_WIDTH = 24;
        public const int MAX_WIDTH = 96;
        public const int MIN_DEPTH = 12;
        public const int MAX_DEPTH = 48;
        public const int HEIGHT = 36; // Maybe change to a private int
        public const int DRAWER_MIN = 0;
        public const int DRAWER_MAX = 7;

        public int Width { get => width; set => width = value; }
        public int Depth { get => depth; set => depth = value; }
        public int DrawerNum { get => drawerNum; set => drawerNum = value; }
        public string MaterialType { get => materialType; set => materialType = value; }

        public Desk()
        {

        }


    }
}
