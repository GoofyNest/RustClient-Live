public class ManualCoverPoint : FacepunchBehaviour // TypeDefIndex: 12128
{	// Fields
	public bool IsDynamic; // 0x18
	public float Score; // 0x1C
	public CoverPointVolume Volume; // 0x20
	public Vector3 Normal; // 0x28
	public CoverPoint.CoverType NormalCoverType; // 0x34

	// Properties
	public Vector3 Position { get; }
	public float DirectionMagnitude { get; }

	// Methods

	// RVA: 0x2F99E0 Offset: 0x2F8DE0 VA: 0x1802F99E0
	public Vector3 get_Position() { }

	// RVA: 0x4BC020 Offset: 0x4BB420 VA: 0x1804BC020
	public float get_DirectionMagnitude() { }

	// RVA: 0x4BBCD0 Offset: 0x4BB0D0 VA: 0x1804BBCD0
	private void Awake() { }

	// RVA: 0x4BBDA0 Offset: 0x4BB1A0 VA: 0x1804BBDA0
	public CoverPoint ToCoverPoint(CoverPointVolume volume) { }

	// RVA: 0x4BC010 Offset: 0x4BB410 VA: 0x1804BC010
	public void .ctor() { }

}

