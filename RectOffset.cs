public class RectOffset // TypeDefIndex: 3378
{	[VisibleToOtherModulesAttribute] // RVA: 0x7FB10 Offset: 0x7EF10 VA: 0x18007FB10
	internal IntPtr m_Ptr; // 0x10
	private readonly object m_SourceStyle; // 0x18

	[NativePropertyAttribute] // RVA: 0x7FFE0 Offset: 0x7F3E0 VA: 0x18007FFE0
	public int left { get; set; }
	[NativePropertyAttribute] // RVA: 0x80140 Offset: 0x7F540 VA: 0x180080140
	public int right { get; set; }
	[NativePropertyAttribute] // RVA: 0x80460 Offset: 0x7F860 VA: 0x180080460
	public int top { get; }
	[NativePropertyAttribute] // RVA: 0x804A0 Offset: 0x7F8A0 VA: 0x1800804A0
	public int bottom { get; }
	public int horizontal { get; }
	public int vertical { get; }


	public void .ctor() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x7FD10 Offset: 0x7F110 VA: 0x18007FD10
	internal void .ctor(object sourceStyle, IntPtr source) { }

	protected override void Finalize() { }

	public override string ToString() { }

	private void Destroy() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static IntPtr InternalCreate() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void InternalDestroy(IntPtr ptr) { }

	public int get_left() { }

	public void set_left(int value) { }

	public int get_right() { }

	public void set_right(int value) { }

	public int get_top() { }

	public int get_bottom() { }

	public int get_horizontal() { }

	public int get_vertical() { }

	public Rect Add(Rect rect) { }

	public Rect Remove(Rect rect) { }

	private void Add_Injected(ref Rect rect, out Rect ret) { }

	private void Remove_Injected(ref Rect rect, out Rect ret) { }

}

