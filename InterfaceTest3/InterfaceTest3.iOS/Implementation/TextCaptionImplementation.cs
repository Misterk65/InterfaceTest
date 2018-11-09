using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using InterfaceTest3.iOS.Implementation;
using InterfaceTest3.Interfaces;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(TextCaptionImplementation))]

namespace InterfaceTest3.iOS.Implementation
{
    class TextCaptionImplementation : ITextCaption
    {
        public string GetText(string x)
        {

            if (x != "schlecht Fotze lecken ! :-)))")
            {
                x = "schlecht Fotze lecken ! :-)))";
            }
            else
            {
                x = "Drei Mann in einem Raum...";
            }

            return (x);
        }
    }
}