using System.ComponentModel.DataAnnotations;

namespace AbbyTryout.Model;
public class AlhasrTabel
{
    [Key]
    public string ID { get; set; }
    [Required]

    public string Title { get; set; }
    public string location { get; set; }
    public string building { get; set; }
    public string roomlabel { get; set; }
    public string?department { get; set; }
    public string roomactivity { get; set; }

    public string Floor { get; set; }

    public string gpsurl { get; set; }

    public string?oracelqLabel { get; set; }

    public string?oracelqChairs { get; set; }

    public string?ExtraChairs { get; set; }

    public string?RightChairs { get; set; }

    public string?LeftChairs { get; set; }

    public string?stadiumChairs { get; set; }

    public string?RotatingChairWithBack { get; set; }

    public string?LabChairs { get; set; }

    public string?StageChairs { get; set; }

    public string?TotalChairs { get; set; }

    public string Modified { get; set; }

    public string Created { get; set; }
    //[Display(Name = "Display Order")]
    //[Range(1, 100, ErrorMessage = "Display order must be in range of 1-100!!!")]
}
/*

using System.ComponentModel.DataAnnotations;

namespace AbbyTryout.Model;

public record Hasir(System.String Title, System.String location, System.String building, System.String roomlabel, System.String Floor, System.String department, System.String roomactivity, System.String gpsurl, System.String oracelqLabel, System.String oracelqChairs, System.String ExtraChairs, System.String RightChairs, System.String LeftChairs, System.String stadiumChairs, System.String RotatingChairWithBack, System.String RotatingChairWithoutBack, System.String LabChairs, System.String StageChairs, System.String TotalChairs, System.String Created, System.String ID, System.String Modified);*/