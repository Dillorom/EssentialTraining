using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialTraining
{
    class FlowControl
    {
        public bool IsYourFavSongDamascus(string song)
        {
            return (song.ToLower() == "damascus");
        }

        public bool IsYourFavAnimalCat(string animal)
        {
           return (animal.ToLower() == "cat") ? true : false;
        }

        public bool IsYourFavCarTesla(string car)
        {
            if (car.ToLower() == "tesla") return true;
            return false;
        }

        public bool IsYourFavColorSamonPink(string color)
        {
            if(color.ToLower() == "pink")
            {
                return true;
            }else
            {
                return false;
            }
        }
        public string SecondaryOrPrimary(string color)
        {
            var result = "";
            switch(color.ToLower())
            {
                case "red":
                    result = "Primary";
                    break;

                case "yellow":
                    result = "Primary";
                    break;

                case "blue":
                    result = "Primary";
                    break;
                default:
                    result = "Secondary";
                    break;
            }
            return result;
        }

   }
}
