public class ImageRenderController : SingletonComponent<ImageRenderController> // TypeDefIndex: 10099
{
	public Camera Camera; 


public void OnEnable() { }

private byte[] RenderImpl(int imageWidth, int imageHeight, Vector3 position, Quaternion rotation, int quality) { }

private static ImageRenderController GetOrCreate() { }

public static byte[] Render(int imageWidth, int imageHeight, Vector3 position, Quaternion rotation, int quality = 75) { }

private static void SetPlayerModelVisible(BasePlayer player, bool visible) { }

public void .ctor() { }

}

