using System.ComponentModel.DataAnnotations;

namespace AbbyTryout.Model;
public class AlhasrTabel
{
    [Key]
    public string ID { get; set; }
    [Required]
    public string location { get; set; }
    //[Display(Name = "Display Order")]
    //[Range(1, 100, ErrorMessage = "Display order must be in range of 1-100!!!")]
    public string Title { get; set; }
}
/*

using System.ComponentModel.DataAnnotations;

namespace AbbyTryout.Model;

public record Hasir(System.String Title, System.String location, System.String building, System.String roomlabel, System.String Floor, System.String department, System.String roomactivity, System.String gpsurl, System.String oracelqLabel, System.String oracelqChairs, System.String ExtraChairs, System.String RightChairs, System.String LeftChairs, System.String stadiumChairs, System.String RotatingChairWithBack, System.String RotatingChairWithoutBack, System.String LabChairs, System.String StageChairs, System.String TotalChairs, System.String Created, System.String ID, System.String Modified);*/