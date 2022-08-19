public struct SubsurfaceScatteringParams // TypeDefIndex: 10653
{	// Fields
	public bool enabled; // 0x0
	public SubsurfaceScatteringParams.Quality quality; // 0x4
	public bool halfResolution; // 0x8
	public float radiusScale; // 0xC
	public static SubsurfaceScatteringParams Default; // 0x0

	// Methods

	// RVA: 0x7A36D0 Offset: 0x7A2AD0 VA: 0x1807A36D0
	private static void .cctor() { }

}

public enum SubsurfaceScatteringParams.Quality // TypeDefIndex: 10654
{	// Fields
	public int value__; // 0x0
	public const SubsurfaceScatteringParams.Quality Low = 0;
	public const SubsurfaceScatteringParams.Quality Medium = 1;
	public const SubsurfaceScatteringParams.Quality High = 2;

}

