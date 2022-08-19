public class DragMeCustomParent : DragMe // TypeDefIndex: 11269
{	// Fields
	public Canvas OverrideCanvas; // 0x20
	public bool ShouldCancelOnDrop; // 0x28

	// Properties
	protected override Canvas TopCanvas { get; }
	public override bool CancelOnDrop { get; }

	// Methods

	// RVA: 0xAAACE0 Offset: 0xAAA0E0 VA: 0x180AAACE0 Slot: 9
	protected override Canvas get_TopCanvas() { }

	// RVA: 0xAAAAF0 Offset: 0xAA9EF0 VA: 0x180AAAAF0 Slot: 8
	protected override GameObject CreateDragObject(Canvas topCanvas, IDraggable dragInfo) { }

	// RVA: 0x9775C0 Offset: 0x9769C0 VA: 0x1809775C0 Slot: 12
	public override bool get_CancelOnDrop() { }

	// RVA: 0xAAAC90 Offset: 0xAAA090 VA: 0x180AAAC90
	public void .ctor() { }

}

