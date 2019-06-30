using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using MainProgram.Annotations;

namespace MainProgram
{
    public class Clock:INotifyPropertyChanged
    {
        public  string CurrentTime=> DateTime.Now.ToLongTimeString();
        public event PropertyChangedEventHandler PropertyChanged;
        private DispatcherTimer _timer;

        public Clock()
        {
            _timer =new DispatcherTimer{Interval = TimeSpan.FromSeconds(1)};
            _timer.Tick += (sender, o) =>
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentTime)));
            _timer.Start();
        }
    }
}
