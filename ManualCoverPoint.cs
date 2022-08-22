public class ManualCoverPoint : FacepunchBehaviour // TypeDefIndex: 12128
{	public bool IsDynamic; // 0x18
	public float Score; // 0x1C
	public CoverPointVolume Volume; // 0x20
	public Vector3 Normal; // 0x28
	public CoverPoint.CoverType NormalCoverType; // 0x34

	public Vector3 Position { get; }
	public float DirectionMagnitude { get; }


	public Vector3 get_Position() { }

	public float get_DirectionMagnitude() { }

	private void Awake() { }

	public CoverPoint ToCoverPoint(CoverPointVolume volume) { }

	public void .ctor() { }

}

