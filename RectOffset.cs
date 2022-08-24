public class RectOffset // TypeDefIndex: 3378
{
	[VisibleToOtherModulesAttribute] 
	internal IntPtr m_Ptr; 
	private readonly object m_SourceStyle; 

	[NativePropertyAttribute] 
public int left { get; set; }
	[NativePropertyAttribute] 
public int right { get; set; }
	[NativePropertyAttribute] 
public int top { get; }
	[NativePropertyAttribute] 
public int bottom { get; }
public int horizontal { get; }
public int vertical { get; }


public void .ctor() { }

	[VisibleToOtherModulesAttribute] 
internal void .ctor(object sourceStyle, IntPtr source) { }

protected override void Finalize() { }

public override string ToString() { }

private void Destroy() { }

	[ThreadAndSerializationSafeAttribute] 
private static IntPtr InternalCreate() { }

	[ThreadAndSerializationSafeAttribute] 
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

