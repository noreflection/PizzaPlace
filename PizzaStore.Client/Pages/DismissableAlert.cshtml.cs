using System;
using Microsoft.AspNetCore.Components;

namespace PizzaStore.Client.Pages
{
    public class AlertViewModel : ComponentBase
    {
        [Parameter]
        protected bool Show { get; set; } = true;

        [Parameter] 
        protected string Name { get; set; }

        [Parameter]
        protected RenderFragment ChildContent { get; set; }
        public void Dismiss()
        {
            Console.WriteLine("Dismissing alert");
            Show = false;
        }
    }
}