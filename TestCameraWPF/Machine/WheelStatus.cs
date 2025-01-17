using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCameraWPF.Machine;

public class WheelStatus :INotifyPropertyChanged
{
    private double _acelerator = default;
    private double _brake = default;
    private double _clutch = default;

    public double Acelerator
    {
        get { return _acelerator; }
        set
        {
            if (_acelerator != value)
            {
                _acelerator = value;
                OnPropertyChanged(nameof(Acelerator));
            }
        }
    }

    public double Brake
    {
        get { return _brake; }
        set 
        {
            if (_brake != value)
            {
                _brake = value;
                OnPropertyChanged(nameof(Brake));
            }
        }
    }

    public double Clutch
    {
        get { return _clutch; }
        set
        {
            if (_clutch != value)
            {
                _clutch = value;
                OnPropertyChanged(nameof(Clutch));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
