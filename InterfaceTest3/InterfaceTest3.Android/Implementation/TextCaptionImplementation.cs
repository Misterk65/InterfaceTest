using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using InterfaceTest3.Droid.Implementation;
using Xamarin.Forms;

using InterfaceTest3.Interfaces;

[assembly: Dependency(typeof(TextCaptionImplementation))]

namespace InterfaceTest3.Droid.Implementation
{
    public class TextCaptionImplementation : ITextCaption
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