internal class ReflectionMethodsCache // TypeDefIndex: 5022
{	// Fields
	public ReflectionMethodsCache.Raycast3DCallback raycast3D; // 0x10
	public ReflectionMethodsCache.RaycastAllCallback raycast3DAll; // 0x18
	public ReflectionMethodsCache.Raycast2DCallback raycast2D; // 0x20
	public ReflectionMethodsCache.GetRayIntersectionAllCallback getRayIntersectionAll; // 0x28
	public ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback getRayIntersectionAllNonAlloc; // 0x30
	public ReflectionMethodsCache.GetRaycastNonAllocCallback getRaycastNonAlloc; // 0x38
	private static ReflectionMethodsCache s_ReflectionMethodsCache; // 0x0

	// Properties
	public static ReflectionMethodsCache Singleton { get; }

	// Methods

	// RVA: 0x1714CF0 Offset: 0x17140F0 VA: 0x181714CF0
	public void .ctor() { }

	// RVA: 0x1715C00 Offset: 0x1715000 VA: 0x181715C00
	public static ReflectionMethodsCache get_Singleton() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

public sealed class ReflectionMethodsCache.Raycast3DCallback : MulticastDelegate // TypeDefIndex: 5023
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17132B0 Offset: 0x17126B0 VA: 0x1817132B0 Slot: 12
	public virtual bool Invoke(Ray r, out RaycastHit hit, float f, int i) { }

	// RVA: 0x17131A0 Offset: 0x17125A0 VA: 0x1817131A0 Slot: 13
	public virtual IAsyncResult BeginInvoke(Ray r, out RaycastHit hit, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x1713270 Offset: 0x1712670 VA: 0x181713270 Slot: 14
	public virtual bool EndInvoke(out RaycastHit hit, IAsyncResult result) { }

}

public sealed class ReflectionMethodsCache.Raycast2DCallback : MulticastDelegate // TypeDefIndex: 5024
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1712DB0 Offset: 0x17121B0 VA: 0x181712DB0 Slot: 12
	public virtual RaycastHit2D Invoke(Vector2 p1, Vector2 p2, float f, int i) { }

	// RVA: 0x1712CA0 Offset: 0x17120A0 VA: 0x181712CA0 Slot: 13
	public virtual IAsyncResult BeginInvoke(Vector2 p1, Vector2 p2, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x1712D60 Offset: 0x1712160 VA: 0x181712D60 Slot: 14
	public virtual RaycastHit2D EndInvoke(IAsyncResult result) { }

}

public sealed class ReflectionMethodsCache.RaycastAllCallback : MulticastDelegate // TypeDefIndex: 5025
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x170ABB0 Offset: 0x1709FB0 VA: 0x18170ABB0 Slot: 12
	public virtual RaycastHit[] Invoke(Ray r, float f, int i) { }

	// RVA: 0x1713700 Offset: 0x1712B00 VA: 0x181713700 Slot: 13
	public virtual IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual RaycastHit[] EndInvoke(IAsyncResult result) { }

}

public sealed class ReflectionMethodsCache.GetRayIntersectionAllCallback : MulticastDelegate // TypeDefIndex: 5026
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x170ABB0 Offset: 0x1709FB0 VA: 0x18170ABB0 Slot: 12
	public virtual RaycastHit2D[] Invoke(Ray r, float f, int i) { }

	// RVA: 0x170AB00 Offset: 0x1709F00 VA: 0x18170AB00 Slot: 13
	public virtual IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual RaycastHit2D[] EndInvoke(IAsyncResult result) { }

}

public sealed class ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback : MulticastDelegate // TypeDefIndex: 5027
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x170B070 Offset: 0x170A470 VA: 0x18170B070 Slot: 12
	public virtual int Invoke(Ray r, RaycastHit2D[] results, float f, int i) { }

	// RVA: 0x170AFB0 Offset: 0x170A3B0 VA: 0x18170AFB0 Slot: 13
	public virtual IAsyncResult BeginInvoke(Ray r, RaycastHit2D[] results, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0xB95EA0 Offset: 0xB952A0 VA: 0x180B95EA0 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

public sealed class ReflectionMethodsCache.GetRaycastNonAllocCallback : MulticastDelegate // TypeDefIndex: 5028
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x170B070 Offset: 0x170A470 VA: 0x18170B070 Slot: 12
	public virtual int Invoke(Ray r, RaycastHit[] results, float f, int i) { }

	// RVA: 0x170B4C0 Offset: 0x170A8C0 VA: 0x18170B4C0 Slot: 13
	public virtual IAsyncResult BeginInvoke(Ray r, RaycastHit[] results, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0xB95EA0 Offset: 0xB952A0 VA: 0x180B95EA0 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

