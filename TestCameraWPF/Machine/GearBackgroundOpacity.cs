using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace TestCameraWPF.Machine;

public class GearBackgroundOpacity :INotifyPropertyChanged
{
    private bool _p1_Opacity = default;
    private bool _p2_Opacity = default;
    private bool _d_Opacity = default;
    private bool _n_Opacity = true;
    private bool _r_Opacity = default;

    public bool P1_Opacity
    {
        get => _p1_Opacity;
        set
        {
            if (_p1_Opacity != value)
            {
                _p1_Opacity = value;
                OnPropertyChanged(nameof(P1_Opacity));
            }
        }
    }

    public bool P2_Opacity
    {
        get => _p2_Opacity;
        set 
        {
            if ( _p2_Opacity != value)
            {
                _p2_Opacity = value;
                OnPropertyChanged(nameof(P2_Opacity));
            }
        }
    }

    public bool D_Opacity
    {
        get => _d_Opacity;
        set
        {
            if (_d_Opacity != value)
            {
                _d_Opacity = value;
                OnPropertyChanged(nameof(D_Opacity));
            }
        }
    }

    public bool N_Opacity
    {
        get => _n_Opacity;
        set
        {
            if (_n_Opacity != value)
            {
                _n_Opacity = value;
                OnPropertyChanged(nameof(N_Opacity));
            }
        } 
    }

    public bool R_Opacity
    {
        get => _r_Opacity;
        set
        {
            if (_r_Opacity != value)
            {
                _r_Opacity = value;
                OnPropertyChanged(nameof(R_Opacity));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
