public class SubsurfaceProfileTexture // TypeDefIndex: 10663
{	// Fields
	public const int SUBSURFACE_RADIUS_SCALE = 1024;
	public const int SUBSURFACE_KERNEL_SIZE = 3;
	private List<SubsurfaceProfileTexture.SubsurfaceProfileEntry> entries; // 0x10
	private Texture2D texture; // 0x18

	// Properties
	public Texture2D Texture { get; }

	// Methods

	// RVA: 0x7A2DF0 Offset: 0x7A21F0 VA: 0x1807A2DF0
	public Texture2D get_Texture() { }

	// RVA: 0x7A2CA0 Offset: 0x7A20A0 VA: 0x1807A2CA0
	public void .ctor() { }

	// RVA: 0x7A27E0 Offset: 0x7A1BE0 VA: 0x1807A27E0
	public int FindEntryIndex(SubsurfaceProfile profile) { }

	// RVA: 0x7A1DC0 Offset: 0x7A11C0 VA: 0x1807A1DC0
	public int AddProfile(SubsurfaceProfileData data, SubsurfaceProfile profile) { }

	// RVA: 0x7A2B80 Offset: 0x7A1F80 VA: 0x1807A2B80
	public void UpdateProfile(int id, SubsurfaceProfileData data) { }

	// RVA: 0x7A2990 Offset: 0x7A1D90 VA: 0x1807A2990
	public void RemoveProfile(int id) { }

	// RVA: 0x7A20D0 Offset: 0x7A14D0 VA: 0x1807A20D0
	public static Color ColorClamp(Color color, float min = 0, float max = 1) { }

	// RVA: 0x7A21B0 Offset: 0x7A15B0 VA: 0x1807A21B0
	private Texture2D CreateTexture() { }

	// RVA: 0x7A1FD0 Offset: 0x7A13D0 VA: 0x1807A1FD0
	private void CheckReleaseTexture() { }

	// RVA: 0x7A28E0 Offset: 0x7A1CE0 VA: 0x1807A28E0
	private void ReleaseTexture() { }

}

private struct SubsurfaceProfileTexture.SubsurfaceProfileEntry // TypeDefIndex: 10664
{	// Fields
	public SubsurfaceProfileData data; // 0x0
	public SubsurfaceProfile profile; // 0x28

	// Methods

	// RVA: 0xF6440 Offset: 0xF5840 VA: 0x1800F6440
	public void .ctor(SubsurfaceProfileData data, SubsurfaceProfile profile) { }

}

