public class BaseCommandBuffer : MonoBehaviour // TypeDefIndex: 11285
{	// Fields
	private Dictionary<Camera, Dictionary<int, CommandBuffer>> cameras; // 0x18

	// Methods

	// RVA: 0x7F0D20 Offset: 0x7F0120 VA: 0x1807F0D20
	protected CommandBuffer GetCommandBuffer(string name, Camera camera, CameraEvent cameraEvent) { }

	// RVA: 0x7F0950 Offset: 0x7EFD50 VA: 0x1807F0950
	protected void CleanupCamera(string name, Camera camera, CameraEvent cameraEvent) { }

	// RVA: 0x7F0A20 Offset: 0x7EFE20 VA: 0x1807F0A20
	protected void CleanupCommandBuffer(Camera camera, CameraEvent cameraEvent) { }

	// RVA: 0x7F0AD0 Offset: 0x7EFED0 VA: 0x1807F0AD0
	protected void Cleanup() { }

	// RVA: 0x7F0F20 Offset: 0x7F0320 VA: 0x1807F0F20
	public void .ctor() { }

}

