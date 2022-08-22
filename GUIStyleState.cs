public sealed class GUIStyleState // TypeDefIndex: 4047
{	internal IntPtr m_Ptr; // 0x10
	private readonly GUIStyle m_SourceStyle; // 0x18

	[NativePropertyAttribute] // RVA: 0xD1CD0 Offset: 0xD10D0 VA: 0x1800D1CD0
	public Color textColor { get; set; }


	public Color get_textColor() { }

	public void set_textColor(Color value) { }

	[FreeFunctionAttribute] // RVA: 0xD1B80 Offset: 0xD0F80 VA: 0x1800D1B80
	private static IntPtr Init() { }

	[FreeFunctionAttribute] // RVA: 0xD1C90 Offset: 0xD1090 VA: 0x1800D1C90
	private void Cleanup() { }

	public void .ctor() { }

	private void .ctor(GUIStyle sourceStyle, IntPtr source) { }

	internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source) { }

	protected override void Finalize() { }

	private void get_textColor_Injected(out Color ret) { }

	private void set_textColor_Injected(ref Color value) { }

}

