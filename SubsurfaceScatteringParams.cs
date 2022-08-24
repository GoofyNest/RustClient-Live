public struct SubsurfaceScatteringParams // TypeDefIndex: 10653
{
	public bool enabled; 
	public SubsurfaceScatteringParams.Quality quality; 
	public bool halfResolution; 
	public float radiusScale; 
	public static SubsurfaceScatteringParams Default; 


	private static void .cctor() { }

}

public enum SubsurfaceScatteringParams.Quality // TypeDefIndex: 10654
{
	public int value__; 
	public const SubsurfaceScatteringParams.Quality Low = 0;
	public const SubsurfaceScatteringParams.Quality Medium = 1;
	public const SubsurfaceScatteringParams.Quality High = 2;

}

