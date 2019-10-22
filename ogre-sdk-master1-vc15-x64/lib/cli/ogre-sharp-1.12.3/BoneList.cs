//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace org.ogre {

public class BoneList : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IList<Bone>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BoneList(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BoneList obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BoneList() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_BoneList(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public BoneList(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (Bone element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public Bone this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(Bone[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(Bone[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, Bone[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  global::System.Collections.Generic.IEnumerator<Bone> global::System.Collections.Generic.IEnumerable<Bone>.GetEnumerator() {
    return new BoneListEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new BoneListEnumerator(this);
  }

  public BoneListEnumerator GetEnumerator() {
    return new BoneListEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class BoneListEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<Bone>
  {
    private BoneList collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public BoneListEnumerator(BoneList collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public Bone Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (Bone)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    OgrePINVOKE.BoneList_Clear(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Add(Bone x) {
    OgrePINVOKE.BoneList_Add(swigCPtr, Bone.getCPtr(x));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = OgrePINVOKE.BoneList_size(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint capacity() {
    uint ret = OgrePINVOKE.BoneList_capacity(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void reserve(uint n) {
    OgrePINVOKE.BoneList_reserve(swigCPtr, n);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public BoneList() : this(OgrePINVOKE.new_BoneList__SWIG_0(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public BoneList(BoneList other) : this(OgrePINVOKE.new_BoneList__SWIG_1(BoneList.getCPtr(other)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public BoneList(int capacity) : this(OgrePINVOKE.new_BoneList__SWIG_2(capacity), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  private Bone getitemcopy(int index) {
    global::System.IntPtr cPtr = OgrePINVOKE.BoneList_getitemcopy(swigCPtr, index);
    Bone ret = (cPtr == global::System.IntPtr.Zero) ? null : new Bone(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private Bone getitem(int index) {
    global::System.IntPtr cPtr = OgrePINVOKE.BoneList_getitem(swigCPtr, index);
    Bone ret = (cPtr == global::System.IntPtr.Zero) ? null : new Bone(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, Bone val) {
    OgrePINVOKE.BoneList_setitem(swigCPtr, index, Bone.getCPtr(val));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(BoneList values) {
    OgrePINVOKE.BoneList_AddRange(swigCPtr, BoneList.getCPtr(values));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public BoneList GetRange(int index, int count) {
    global::System.IntPtr cPtr = OgrePINVOKE.BoneList_GetRange(swigCPtr, index, count);
    BoneList ret = (cPtr == global::System.IntPtr.Zero) ? null : new BoneList(cPtr, true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, Bone x) {
    OgrePINVOKE.BoneList_Insert(swigCPtr, index, Bone.getCPtr(x));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, BoneList values) {
    OgrePINVOKE.BoneList_InsertRange(swigCPtr, index, BoneList.getCPtr(values));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    OgrePINVOKE.BoneList_RemoveAt(swigCPtr, index);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    OgrePINVOKE.BoneList_RemoveRange(swigCPtr, index, count);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public static BoneList Repeat(Bone value, int count) {
    global::System.IntPtr cPtr = OgrePINVOKE.BoneList_Repeat(Bone.getCPtr(value), count);
    BoneList ret = (cPtr == global::System.IntPtr.Zero) ? null : new BoneList(cPtr, true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    OgrePINVOKE.BoneList_Reverse__SWIG_0(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reverse(int index, int count) {
    OgrePINVOKE.BoneList_Reverse__SWIG_1(swigCPtr, index, count);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, BoneList values) {
    OgrePINVOKE.BoneList_SetRange(swigCPtr, index, BoneList.getCPtr(values));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(Bone value) {
    bool ret = OgrePINVOKE.BoneList_Contains(swigCPtr, Bone.getCPtr(value));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int IndexOf(Bone value) {
    int ret = OgrePINVOKE.BoneList_IndexOf(swigCPtr, Bone.getCPtr(value));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int LastIndexOf(Bone value) {
    int ret = OgrePINVOKE.BoneList_LastIndexOf(swigCPtr, Bone.getCPtr(value));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Remove(Bone value) {
    bool ret = OgrePINVOKE.BoneList_Remove(swigCPtr, Bone.getCPtr(value));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}