using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogStore.Services
{
    public static class ImagesService
    {
        //image encoding is {0} = dog id, {1} = photo name, {2} = url
        private static string urlTemplate = @"{0}#{1}#{2}";
        public static string createUrl(string photoName, int dogId) { 
            return string.Format(urlTemplate, dogId, photoName, @"~/DogImages/");
        }
    }
}
