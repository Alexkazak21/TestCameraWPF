using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCameraWPF.Machine;

public class TirePressureDTO : INotifyPropertyChanged
{
    private byte _tireBackLeftInnerPressure;
    private byte _tireBackLeftOuterPressure;
    private byte _tireBackRightInnerPressure;
    private byte _tireBackRightOuterPressure;
    private byte _tireFrontLeftPressure;
    private byte _tireFrontRightPressure;

    public byte TireBackLeftInnerPressure 
    {
        get => _tireBackLeftInnerPressure;
        set
        {
            if (_tireBackLeftInnerPressure != value)
            {
                _tireBackLeftInnerPressure = value;
                OnPropertyChanged(nameof(TireBackLeftInnerPressure));
            }
        }
    }

    public byte TireBackLeftOuterPressure 
    {
        get => _tireBackLeftOuterPressure;
        set
        {
            if ( _tireBackLeftOuterPressure != value)
            {
                _tireBackLeftOuterPressure = value;
                OnPropertyChanged(nameof(TireBackLeftOuterPressure));
            }
        }
    }

    public byte TireBackRightInnerPressure 
    {
        get => _tireBackRightInnerPressure;
        set
        {
            if (_tireBackRightInnerPressure != value)
            {
                _tireBackRightInnerPressure = value;
                OnPropertyChanged(nameof(TireBackRightInnerPressure));
            }
        }
    }

    public byte TireBackRightOuterPressure 
    { 
        get => _tireBackRightOuterPressure;
        set
        {
            if (_tireBackRightOuterPressure != value)
            {
                _tireBackRightOuterPressure = value;
                OnPropertyChanged(nameof(TireBackRightOuterPressure));
            }
        }
    }

    public byte TireFrontLeftPressure 
    {
        get => _tireFrontLeftPressure;
        set 
        {
            if (_tireFrontLeftPressure != value)
            {
                _tireFrontLeftPressure = value;
                OnPropertyChanged(nameof(TireFrontLeftPressure));
            }
        }
    }

    public byte TireFrontRightPressure
    {
        get => _tireFrontRightPressure;
        set
        {
            if (_tireFrontRightPressure != value)
            {
                _tireFrontRightPressure = value;
                OnPropertyChanged(nameof(TireFrontRightPressure));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
