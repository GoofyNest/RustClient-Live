public struct Touch // TypeDefIndex: 4073
{	private int m_FingerId; // 0x0
	private Vector2 m_Position; // 0x4
	private Vector2 m_RawPosition; // 0xC
	private Vector2 m_PositionDelta; // 0x14
	private float m_TimeDelta; // 0x1C
	private int m_TapCount; // 0x20
	private TouchPhase m_Phase; // 0x24
	private TouchType m_Type; // 0x28
	private float m_Pressure; // 0x2C
	private float m_maximumPossiblePressure; // 0x30
	private float m_Radius; // 0x34
	private float m_RadiusVariance; // 0x38
	private float m_AltitudeAngle; // 0x3C
	private float m_AzimuthAngle; // 0x40

	public int fingerId { get; }
	public Vector2 position { get; }
	public TouchPhase phase { get; }
	public TouchType type { get; }


	public int get_fingerId() { }

	public Vector2 get_position() { }

	public TouchPhase get_phase() { }

	public TouchType get_type() { }

}

