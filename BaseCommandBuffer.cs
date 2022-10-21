public class BaseCommandBuffer : MonoBehaviour // TypeDefIndex: 13039
{
	private Dictionary<Camera, Dictionary<int, CommandBuffer>> cameras; 


	protected CommandBuffer GetCommandBuffer(string name, Camera camera, CameraEvent cameraEvent) { }

	protected void CleanupCamera(string name, Camera camera, CameraEvent cameraEvent) { }

	protected void CleanupCommandBuffer(Camera camera, CameraEvent cameraEvent) { }

	protected void Cleanup() { }

	public void .ctor() { }

}

