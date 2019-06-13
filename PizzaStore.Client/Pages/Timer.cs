using System;
using Microsoft.AspNetCore.Components;

namespace PizzaStore.Client.Pages
{
    public class Timer : ComponentBase
    {
        [Parameter]
        protected double TimeInSeconds { get; set; }
        
        [Parameter]
        protected Action Tick { get; set; }

        protected override void OnInit()
        {
            base.OnInit();
            
            var timer = new System.Threading.Timer(
                  callback: _=> Tick.Invoke(),
                  state: null,
                  dueTime: TimeSpan.FromSeconds(TimeInSeconds),
                  period: System.Threading.Timeout.InfiniteTimeSpan);
            
        }
        
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