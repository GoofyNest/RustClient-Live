public class ManualCoverPoint : FacepunchBehaviour // TypeDefIndex: 12128
{
	public bool IsDynamic; 
	public float Score; 
	public CoverPointVolume Volume; 
	public Vector3 Normal; 
	public CoverPoint.CoverType NormalCoverType; 

	public Vector3 Position { get; }
	public float DirectionMagnitude { get; }


	public Vector3 get_Position() { }

	public float get_DirectionMagnitude() { }

	private void Awake() { }

	public CoverPoint ToCoverPoint(CoverPointVolume volume) { }

	public void .ctor() { }

}

