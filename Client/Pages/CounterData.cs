using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRelease.Client.Pages
{
    public class CounterData
    {
        public Action<int> CountChanged { get; set; }
        private int count;
        public int Count
        {
            get => this.count;
            set
            {
                if (value != this.count)
                {
                    this.count = value;
                    CountChanged?.Invoke(this.count);
                }
            }
        }
    }
}   
