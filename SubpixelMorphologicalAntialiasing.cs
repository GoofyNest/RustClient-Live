public sealed class SubpixelMorphologicalAntialiasing // TypeDefIndex: 13543
{
	[TooltipAttribute] 
	public SubpixelMorphologicalAntialiasing.Quality quality; 


	public bool IsSupported() { }

	internal void Render(PostProcessRenderContext context) { }

	public void .ctor() { }

}

private enum SubpixelMorphologicalAntialiasing.Pass // TypeDefIndex: 13544
{
	public int value__; 
	public const SubpixelMorphologicalAntialiasing.Pass EdgeDetection = 0;
	public const SubpixelMorphologicalAntialiasing.Pass BlendWeights = 3;
	public const SubpixelMorphologicalAntialiasing.Pass NeighborhoodBlending = 6;

}

public enum SubpixelMorphologicalAntialiasing.Quality // TypeDefIndex: 13545
{
	public int value__; 
	public const SubpixelMorphologicalAntialiasing.Quality Low = 0;
	public const SubpixelMorphologicalAntialiasing.Quality Medium = 1;
	public const SubpixelMorphologicalAntialiasing.Quality High = 2;

}

