using System.ComponentModel;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using static TestCameraWPF.WebSocketClient;

namespace TestCameraWPF.Machine;

public class MachineStateDTO : INotifyPropertyChanged
{
    private int _brakeOilPressure;
    private double _cargoWeight;
    private double _coolantTemperature;
    private double _engineOilPressure;
    private int _engineRevolutions;
    private int _fuelLevet;
    private GnssDataDTO _gnssData;
    private int _machineId;
    private double _onBoardNetworkVoltage;
    private int _operationStatus;
    private int _platformElevationAngle;
    private EPlatformOperationStatus _platformOperationStatus;
    private PositionDTO _position;
    private int _powerGridVoltage;
    private int _steeringOilPressure;
    private string _taskName;
    private int _taskStatus;
    private long _timeUnix;
    private TirePressureDTO _tirePressure;
    private int _transmissionOperationStatus;
    private int _velocity;
    private int _wheelPosition;





    public int BrakeOilPressure 
    { 
        get => _brakeOilPressure;
        set
        {
            if (value != _brakeOilPressure)
            {
                _brakeOilPressure = value;
                OnPropertyChanged(nameof(BrakeOilPressure));
            }
        }
    }

    public double CargoWeight 
    {
        get => _cargoWeight;
        set
        {
            if (value != _cargoWeight) 
            {
                _cargoWeight = value;
                OnPropertyChanged(nameof(CargoWeight));
            }
        }
    }

    public double CoolantTemperature 
    {
        get => _coolantTemperature;
        set
        {
            if ( value != _coolantTemperature)
            {
                _coolantTemperature = value;
                OnPropertyChanged(nameof(CoolantTemperature));
            }
        } 
    }

    public double EngineOilPressure 
    { 
        get => _engineOilPressure;
        set
        {
            if (value != _engineOilPressure)
            {
                _engineOilPressure = value;
                OnPropertyChanged(nameof(EngineOilPressure));
            }
        }
    }

    public int EngineRevolutions 
    { 
        get => _engineRevolutions;
        set
        {
            if (_engineRevolutions != value)
            {
                _engineRevolutions = value;
                OnPropertyChanged(nameof(EngineRevolutions));
            }
        } 
    }

    public int FuelLevel 
    { 
        get => _fuelLevet;
        set
        {
            if (_fuelLevet != value)
            {
                _fuelLevet = value;
                OnPropertyChanged(nameof(FuelLevel));
            }
        }
    }

    public GnssDataDTO GnssData 
    {
        get => _gnssData;
        set
        {
            if ( _gnssData != value)
            {
                _gnssData = value;
                OnPropertyChanged(nameof(GnssData));
            }
        }
    }

    public int MachineId
    {
        get => _machineId;
        set 
        {
            if ( value != _machineId)
            {
                _machineId = value;
                OnPropertyChanged(nameof(MachineId));
            }
        }
    }

    public double OnBoardNetworkVoltage 
    {
        get => _onBoardNetworkVoltage;
        set 
        {
            if (value != _onBoardNetworkVoltage)
            {
                _onBoardNetworkVoltage = value;
                OnPropertyChanged(nameof(OnBoardNetworkVoltage));
            }
        }
    }

    public int OperationStatus 
    {
        get => _operationStatus;
        set 
        {
            if (value != _operationStatus) 
            {
                _operationStatus = value;
                OnPropertyChanged(nameof(OperationStatus));
            }
        }
    }

    public int PlatformElevationAngle 
    {
        get => _platformElevationAngle;
        set
        {
            if (value != _platformElevationAngle) 
            {
                _platformElevationAngle = value;
                OnPropertyChanged(nameof(PlatformElevationAngle));
            }
        }
    }

    public EPlatformOperationStatus PlatformOperationStatus 
    {
        get => _platformOperationStatus;
        set
        {
            if (value != _platformOperationStatus) 
            {
                _platformOperationStatus = value;
                OnPropertyChanged(nameof(PlatformOperationStatus));
            }
        }
    }

    public PositionDTO Position 
    {
        get => _position;
        set 
        {
            if (value != _position) 
            {
                _position = value;
                OnPropertyChanged(nameof(Position));
            }
        }
    }

    public int PowerGridVoltage 
    {
        get => _powerGridVoltage;
        set
        {
            if (value != _powerGridVoltage) 
            {
                _powerGridVoltage = value;
                OnPropertyChanged(nameof(PowerGridVoltage));
            }
        }
    }

    public int SteeringOilPressure 
    {
        get => _steeringOilPressure;
        set
        {
            if (_steeringOilPressure != value)
            {
                _steeringOilPressure = value;
                OnPropertyChanged(nameof(SteeringOilPressure));
            }
        }
    }

    public string TaskName 
    {
        get => _taskName;
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                _taskName = value;
                OnPropertyChanged(nameof(TaskName));
            }
        }
    }

    public int TaskStatus 
    {
        get => _taskStatus;
        set 
        {
            if (_taskStatus != value)
            {
                _taskStatus = value;
                OnPropertyChanged(nameof(TaskStatus));
            }
        }
    }

    public long TimeUnix 
    {
        get => _timeUnix;
        set 
        {
            if (_timeUnix != value) 
            {
                _timeUnix = value;
                OnPropertyChanged(nameof(TimeUnix));
            }
        }
    }

    public TirePressureDTO TirePressure 
    { 
        get => _tirePressure;
        set
        {
            if (_tirePressure != value) 
            {
                _tirePressure = value;
                OnPropertyChanged(nameof(TirePressure));
            }
        }
    }

    public int TransmissionOperationStatus 
    { 
        get => _transmissionOperationStatus;
        set
        {
            if (value != _transmissionOperationStatus)
            {
                _transmissionOperationStatus = value;
                OnPropertyChanged(nameof(TransmissionOperationStatus));
            }
        }
    }

    public int Velocity 
    {
        get => _velocity;
        set 
        {
            if (_velocity != value)
            {
                _velocity = value;
                OnPropertyChanged(nameof(Velocity));
            }
        }
    }

    public int WheelPosition 
    {
        get => _wheelPosition;
        set 
        {
            if (_wheelPosition != value)
            {
                _wheelPosition = value;
                OnPropertyChanged(nameof(WheelPosition));
            }
        }
    }

    public ImageSource GetPlatformImage()
    {
        switch (this.PlatformOperationStatus)
        {
            case EPlatformOperationStatus.DOWN_DONE:
                {
                    return new BitmapImage(new Uri("Images/BELAZ_PlatformLowered.png", UriKind.RelativeOrAbsolute));
                }

            case EPlatformOperationStatus.DOWN_IN_PROGRESS:
                {
                    return new BitmapImage(new Uri("Image/BELAZ_PlatformLowering.png", UriKind.RelativeOrAbsolute));
                }

            case EPlatformOperationStatus.UP_DONE:
                {
                    return new BitmapImage(new Uri("Images/BELAZ_PlatformRaised.png", UriKind.RelativeOrAbsolute));
                }

            case EPlatformOperationStatus.UP_IN_PROGRESS:
                {
                    return new BitmapImage(new Uri("Images/BELAZ_PlatformRaising.png", UriKind.RelativeOrAbsolute));
                }

            case EPlatformOperationStatus.UNDEFINED:
            default:
                {
                    return new BitmapImage(new Uri("Images/BELAZ_PlatformLowered.png", UriKind.RelativeOrAbsolute));
                }
        }
    }



    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}