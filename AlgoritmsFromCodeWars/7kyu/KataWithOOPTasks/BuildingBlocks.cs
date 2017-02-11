using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._7kyu
{
    public class BuildingBlocks
    {
        /// <summary>
        /// Write a class Block that creates a block (Duh..)
        /// Requirements
        /// The constructor should take an array as an argument, this will contain 3 integers of the form[width, length, height] 
        /// from which the Block should be created.
        /// Define these methods:
        /// `GetWidth()` return the width of the `Block`
        /// `GetLength()` return the length of the `Block`
        /// `GetHeight()` return the height of the `Block`
        /// `GetVolume()` return the volume of the `Block`
        /// `GetSurfaceArea()` return the surface area of the `Block`
        /// Examples
        /// Block b = new Block(new int[]{2,4,6}) -> creates a `Block` object with 
        /// a width of `2` a length of `4` and a height of `6`
        /// b.GetWidth() // -> 2
        /// b.GetLength() // -> 4
        /// b.GetHeight() // -> 6
        /// b.GetVolume() // -> 48
        /// b.GetSurfaceArea() // -> 88
        /// Note: no error checking is needed
        /// </summary>
        public class Block
        {
            private int width, length, hight;

            public Block(int[] block)
            {
                width = block[0];
                length = block[1];
                hight = block[2];
            }

            public int GetWidth()
            {
                return width;
            }

            public int GetLength()
            {
                return length;
            }

            public int GetHeight()
            {
                return hight;
            }

            public int GetVolume()
            {
                return width*length*hight;
            }

            public int GetSurfaceArea()
            {
                return 2*width*hight + 2*length*hight + 2*width*length;
            }
        }

        class Block2Variant
        {
            public int Width { get; private set; }
            public int Length { get; private set; }
            public int Height { get; private set; }

            public Block2Variant(int[] properties)
            {
                this.Width = properties[0];
                this.Length = properties[1];
                this.Height = properties[2];
            }

            public int GetWidth()
            {
                return Width;
            }

            public int GetLength()
            {
                return Length;
            }

            public int GetHeight()
            {
                return Height;
            }

            public int GetVolume()
            {
                return GetWidth()*GetHeight()*GetLength();
            }

            public int GetSurfaceArea()
            {
                return (2*GetLength()*GetWidth())
                       + (2*GetLength()*GetHeight())
                       + (2*GetWidth()*GetHeight());
            }
        }
    }
}
