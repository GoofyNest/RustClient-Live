public sealed class SubpixelMorphologicalAntialiasing // TypeDefIndex: 11804
{	// Fields
	[TooltipAttribute] // RVA: 0x760F0 Offset: 0x754F0 VA: 0x1800760F0
	public SubpixelMorphologicalAntialiasing.Quality quality; // 0x10

	// Methods

	// RVA: 0x11DB0B0 Offset: 0x11DA4B0 VA: 0x1811DB0B0
	public bool IsSupported() { }

	// RVA: 0x11DB100 Offset: 0x11DA500 VA: 0x1811DB100
	internal void Render(PostProcessRenderContext context) { }

	// RVA: 0x11DB700 Offset: 0x11DAB00 VA: 0x1811DB700
	public void .ctor() { }

}

private enum SubpixelMorphologicalAntialiasing.Pass // TypeDefIndex: 11805
{	// Fields
	public int value__; // 0x0
	public const SubpixelMorphologicalAntialiasing.Pass EdgeDetection = 0;
	public const SubpixelMorphologicalAntialiasing.Pass BlendWeights = 3;
	public const SubpixelMorphologicalAntialiasing.Pass NeighborhoodBlending = 6;

}

public enum SubpixelMorphologicalAntialiasing.Quality // TypeDefIndex: 11806
{	// Fields
	public int value__; // 0x0
	public const SubpixelMorphologicalAntialiasing.Quality Low = 0;
	public const SubpixelMorphologicalAntialiasing.Quality Medium = 1;
	public const SubpixelMorphologicalAntialiasing.Quality High = 2;

}

