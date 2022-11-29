public struct Touch // TypeDefIndex: 4078
{
	private int m_FingerId; 
	private Vector2 m_Position; 
	private Vector2 m_RawPosition; 
	private Vector2 m_PositionDelta; 
	private float m_TimeDelta; 
	private int m_TapCount; 
	private TouchPhase m_Phase; 
	private TouchType m_Type; 
	private float m_Pressure; 
	private float m_maximumPossiblePressure; 
	private float m_Radius; 
	private float m_RadiusVariance; 
	private float m_AltitudeAngle; 
	private float m_AzimuthAngle; 

	public int fingerId { get; }
	public Vector2 position { get; }
	public TouchPhase phase { get; }
	public TouchType type { get; }


	public int get_fingerId() { }

	public Vector2 get_position() { }

	public TouchPhase get_phase() { }

	public TouchType get_type() { }

}

