public class PieShape : Graphic // TypeDefIndex: 12938
{
	[RangeAttribute] 
	public float outerSize; 
	[RangeAttribute] 
	public float innerSize; 
	public float startRadius; 
	public float endRadius; 
	public float border; 
	public bool debugDrawing; 


	protected override void OnPopulateMesh(VertexHelper vbo) { }

	public void .ctor() { }

}

