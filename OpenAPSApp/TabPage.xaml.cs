using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OpenAPSApp
{
    public partial class TabPage : TabbedPage
    {
        public TabPage()
        {
            InitializeComponent();

            //Navigation.PushAsync(new OpenAPSAppPage());


        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();    
        }
    }
}
