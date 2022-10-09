public class DragMeCustomParent : DragMe // TypeDefIndex: 13010
{
	public Canvas OverrideCanvas; 
	public bool ShouldCancelOnDrop; 

	protected override Canvas TopCanvas { get; }
	public override bool CancelOnDrop { get; }


	protected override Canvas get_TopCanvas() { }

	protected override GameObject CreateDragObject(Canvas topCanvas, IDraggable dragInfo) { }

	public override bool get_CancelOnDrop() { }

	public void .ctor() { }

}

