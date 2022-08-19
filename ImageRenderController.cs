public class ImageRenderController : SingletonComponent<ImageRenderController> // TypeDefIndex: 10099
{	// Fields
	public Camera Camera; // 0x18

	// Methods

	// RVA: 0x52F6D0 Offset: 0x52EAD0 VA: 0x18052F6D0
	public void OnEnable() { }

	// RVA: 0x80BA90 Offset: 0x80AE90 VA: 0x18080BA90
	private byte[] RenderImpl(int imageWidth, int imageHeight, Vector3 position, Quaternion rotation, int quality) { }

	// RVA: 0x80B990 Offset: 0x80AD90 VA: 0x18080B990
	private static ImageRenderController GetOrCreate() { }

	// RVA: 0x80BDC0 Offset: 0x80B1C0 VA: 0x18080BDC0
	public static byte[] Render(int imageWidth, int imageHeight, Vector3 position, Quaternion rotation, int quality = 75) { }

	// RVA: 0x80C260 Offset: 0x80B660 VA: 0x18080C260
	private static void SetPlayerModelVisible(BasePlayer player, bool visible) { }

	// RVA: 0x80C600 Offset: 0x80BA00 VA: 0x18080C600
	public void .ctor() { }

}

