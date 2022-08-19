public sealed class GUIStyleState // TypeDefIndex: 4047
{	// Fields
	internal IntPtr m_Ptr; // 0x10
	private readonly GUIStyle m_SourceStyle; // 0x18

	// Properties
	[NativePropertyAttribute] // RVA: 0xD1CD0 Offset: 0xD10D0 VA: 0x1800D1CD0
	public Color textColor { get; set; }

	// Methods

	// RVA: 0x1A6AB10 Offset: 0x1A69F10 VA: 0x181A6AB10
	public Color get_textColor() { }

	// RVA: 0x1A6ABB0 Offset: 0x1A69FB0 VA: 0x181A6ABB0
	public void set_textColor(Color value) { }

	[FreeFunctionAttribute] // RVA: 0xD1B80 Offset: 0xD0F80 VA: 0x1800D1B80
	// RVA: 0x1A6AA50 Offset: 0x1A69E50 VA: 0x181A6AA50
	private static IntPtr Init() { }

	[FreeFunctionAttribute] // RVA: 0xD1C90 Offset: 0xD1090 VA: 0x1800D1C90
	// RVA: 0x1A6A8D0 Offset: 0x1A69CD0 VA: 0x181A6A8D0
	private void Cleanup() { }

	// RVA: 0x1A6AA80 Offset: 0x1A69E80 VA: 0x181A6AA80
	public void .ctor() { }

	// RVA: 0x19A6940 Offset: 0x19A5D40 VA: 0x1819A6940
	private void .ctor(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x1A6A9E0 Offset: 0x1A69DE0 VA: 0x181A6A9E0
	internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x1A6A910 Offset: 0x1A69D10 VA: 0x181A6A910 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1A6AAC0 Offset: 0x1A69EC0 VA: 0x181A6AAC0
	private void get_textColor_Injected(out Color ret) { }

	// RVA: 0x1A6AB60 Offset: 0x1A69F60 VA: 0x181A6AB60
	private void set_textColor_Injected(ref Color value) { }

}

