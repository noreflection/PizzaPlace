using System;
using Microsoft.AspNetCore.Components;

namespace PizzaStore.Client.Pages
{
    public class DismissibleAlertViewModel : ComponentBase
    {
        private bool show = true;
        
        [Parameter]
        protected bool Show
        {
            get => show;
            set
            {
                if (show != value)
                {
                    show = value;
                    ShowChanged?.Invoke(show);
                }
            }
        }
        
        [Parameter]
        protected Action<bool> ShowChanged { get; set; }
        [Parameter]
        protected RenderFragment ChildContent { get; set; }
        public void Dismiss()
        {
            Show = false;
        }
    }
}