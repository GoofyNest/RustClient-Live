public class TrainTrackSpline : WorldSpline // TypeDefIndex: 9773
{	[TooltipAttribute] // RVA: 0x97BA0 Offset: 0x96FA0 VA: 0x180097BA0
	public bool isStation; // 0x40
	[TooltipAttribute] // RVA: 0x97CA0 Offset: 0x970A0 VA: 0x180097CA0
	public bool aboveGroundSpawn; // 0x41
	public bool useNewTangentCalc; // 0x42
	public int hierarchy; // 0x44


	public void .ctor() { }

}

public enum TrainTrackSpline.TrackSelection // TypeDefIndex: 9774
{	public int value__; // 0x0
	public const TrainTrackSpline.TrackSelection Default = 0;
	public const TrainTrackSpline.TrackSelection Left = 1;
	public const TrainTrackSpline.TrackSelection Right = 2;

}

