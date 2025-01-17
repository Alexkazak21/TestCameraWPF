using System.ComponentModel;
using System.Windows.Media;
using TestCameraWPF.Machine;


namespace TestCameraWPF;

public class CamerasSourceModel : INotifyPropertyChanged
{
    private double _speed = 0.0d;
    private double _rpm = 0;
    private MachineStateDTO _machineState;
    private ImageSource _imageSource;
    private GearBrushes _gearBrushes = new GearBrushes();


    public double Speed
    {
        get => _speed;
        set
        {
            if (value != _speed)
            {
                _speed = value;
                OnPropertyChanged(nameof(Speed));
            }
        }
    }

    public double RPM
    {
        get => _rpm;
        set
        {
            if (value != _rpm)
            {
                _rpm = value;
                OnPropertyChanged(nameof(RPM));
            }
        }
    }

    public MachineStateDTO MachineState
    {
        get => _machineState;
        set 
        {
            if (value != _machineState)
            {
                _machineState = value;
                OnPropertyChanged(nameof(MachineState));
            }
        }
    }

    public ImageSource PlatformImageSource
    {
        get => _imageSource;
        set 
        {
            if (value != _imageSource) 
            {
                _imageSource = value;
                OnPropertyChanged(nameof(PlatformImageSource));
            }
        }
    }

    public GearBrushes GearOpacity
    {
        get => _gearBrushes;
        set 
        {
            if (_gearBrushes != value)
            {
                _gearBrushes = value;
                OnPropertyChanged(nameof(GearOpacity));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

}
