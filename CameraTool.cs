public class CameraTool : HeldEntity // TypeDefIndex: 8542
{	// Fields
	public GameObjectRef screenshotEffect; // 0x1F8
	public float cameraFOV; // 0x200
	public float focalDistance; // 0x204
	internal float focalDistanceSmooth; // 0x208

	// Methods

	// RVA: 0x716340 Offset: 0x715740 VA: 0x180716340 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x715E60 Offset: 0x715260 VA: 0x180715E60 Slot: 135
	public override void EditViewAngles() { }

	// RVA: 0x7160F0 Offset: 0x7154F0 VA: 0x1807160F0 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x716290 Offset: 0x715690 VA: 0x180716290 Slot: 138
	public override void OnInput() { }

	// RVA: 0x715FE0 Offset: 0x7153E0 VA: 0x180715FE0 Slot: 146
	public override void ModifyCamera() { }

	// RVA: 0x716430 Offset: 0x715830 VA: 0x180716430
	public void .ctor() { }

}

