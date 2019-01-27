using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_SidneyRodrigues
{
    class Desk
    {
     
        private int width;
        private int depth;
        private int drawers;
        private int size;

        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;

        public enum Material
        {
            Oak = 200,
            Laminate = 100,
            Pine = 50,
            Rosewood = 300,
            Veneer = 125
        }

        public int getDeskWidth()
        {
            return this.width;
        }

        public void setDeskWidth(int width)
        {
            this.width = width;
        }

        public int getDeskDepth()
        {
            return this.depth;
        }

        public void setDeskDepth(int depth)
        {
            this.depth = depth;
        }

        public int getDrawers()
        {
            return this.drawers;
        }

        public void setDrawers(int drawers)
        {
            this.drawers = drawers;
        }

        public int getSize()
        {
            return this.size;
        }

        public void setSize(int size)
        {
            this.size = size;
        }

    }
}
