public class RectOffset // TypeDefIndex: 3378
{	// Fields
	[VisibleToOtherModulesAttribute] // RVA: 0x7FB10 Offset: 0x7EF10 VA: 0x18007FB10
	internal IntPtr m_Ptr; // 0x10
	private readonly object m_SourceStyle; // 0x18

	// Properties
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

	// Methods

	// RVA: 0x19A6990 Offset: 0x19A5D90 VA: 0x1819A6990
	public void .ctor() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x7FD10 Offset: 0x7F110 VA: 0x18007FD10
	// RVA: 0x19A6940 Offset: 0x19A5D40 VA: 0x1819A6940
	internal void .ctor(object sourceStyle, IntPtr source) { }

	// RVA: 0x19A6460 Offset: 0x19A5860 VA: 0x1819A6460 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x19A6680 Offset: 0x19A5A80 VA: 0x1819A6680 Slot: 3
	public override string ToString() { }

	// RVA: 0x19A63E0 Offset: 0x19A57E0 VA: 0x1819A63E0
	private void Destroy() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19A6550 Offset: 0x19A5950 VA: 0x1819A6550
	private static IntPtr InternalCreate() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19A6580 Offset: 0x19A5980 VA: 0x1819A6580
	private static void InternalDestroy(IntPtr ptr) { }

	// RVA: 0x19A6A50 Offset: 0x19A5E50 VA: 0x1819A6A50
	public int get_left() { }

	// RVA: 0x19A6B50 Offset: 0x19A5F50 VA: 0x1819A6B50
	public void set_left(int value) { }

	// RVA: 0x19A6A90 Offset: 0x19A5E90 VA: 0x1819A6A90
	public int get_right() { }

	// RVA: 0x19A6B90 Offset: 0x19A5F90 VA: 0x1819A6B90
	public void set_right(int value) { }

	// RVA: 0x19A6AD0 Offset: 0x19A5ED0 VA: 0x1819A6AD0
	public int get_top() { }

	// RVA: 0x19A69D0 Offset: 0x19A5DD0 VA: 0x1819A69D0
	public int get_bottom() { }

	// RVA: 0x19A6A10 Offset: 0x19A5E10 VA: 0x1819A6A10
	public int get_horizontal() { }

	// RVA: 0x19A6B10 Offset: 0x19A5F10 VA: 0x1819A6B10
	public int get_vertical() { }

	// RVA: 0x19A6380 Offset: 0x19A5780 VA: 0x1819A6380
	public Rect Add(Rect rect) { }

	// RVA: 0x19A6620 Offset: 0x19A5A20 VA: 0x1819A6620
	public Rect Remove(Rect rect) { }

	// RVA: 0x19A6320 Offset: 0x19A5720 VA: 0x1819A6320
	private void Add_Injected(ref Rect rect, out Rect ret) { }

	// RVA: 0x19A65C0 Offset: 0x19A59C0 VA: 0x1819A65C0
	private void Remove_Injected(ref Rect rect, out Rect ret) { }

}

