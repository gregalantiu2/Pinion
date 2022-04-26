using System;
using Microsoft.AspNetCore.Components;
using Pinion.Models;

namespace Pinion.Pages.Home
{
    public partial class HomeContent : ComponentBase
    {
        public HomeContent()
        {
        }

        private PinionModel pinionModel = new();

        private void HandleValidSubmit()
        {
            throw new Exception();
        }
    }
}
