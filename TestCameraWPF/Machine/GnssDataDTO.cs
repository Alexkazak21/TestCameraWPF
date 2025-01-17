using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCameraWPF.Machine;

public class GnssDataDTO : INotifyPropertyChanged
{
    public AttitudeDTO Attitude { get; set; }

    public int SolutionType { get; set; }

    public TimeStampDTO TimeStamp { get; set; }

    public UtmPointDTO UtmPoint { get; set; }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

}
