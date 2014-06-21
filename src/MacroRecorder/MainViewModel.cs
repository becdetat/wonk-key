using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroRecorder
{
    public class MainViewModel
    {
        public ObservableCollection<string> Keystrokes { get; private set; }

        public MainViewModel()
        {
            Keystrokes = new ObservableCollection<string>(new []
            {
                "a","b","c"
            });
        }
    }
}
