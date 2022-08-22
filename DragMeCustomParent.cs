public class DragMeCustomParent : DragMe // TypeDefIndex: 11269
{	public Canvas OverrideCanvas; // 0x20
	public bool ShouldCancelOnDrop; // 0x28

	protected override Canvas TopCanvas { get; }
	public override bool CancelOnDrop { get; }


	protected override Canvas get_TopCanvas() { }

	protected override GameObject CreateDragObject(Canvas topCanvas, IDraggable dragInfo) { }

	public override bool get_CancelOnDrop() { }

	public void .ctor() { }

}

