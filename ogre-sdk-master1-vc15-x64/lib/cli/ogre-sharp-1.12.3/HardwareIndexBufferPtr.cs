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

public class HardwareIndexBufferPtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal HardwareIndexBufferPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(HardwareIndexBufferPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~HardwareIndexBufferPtr() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_HardwareIndexBufferPtr(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public HardwareIndexBufferPtr(SWIGTYPE_p_std__nullptr_t arg0) : this(OgrePINVOKE.new_HardwareIndexBufferPtr__SWIG_0(SWIGTYPE_p_std__nullptr_t.getCPtr(arg0)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public HardwareIndexBufferPtr() : this(OgrePINVOKE.new_HardwareIndexBufferPtr__SWIG_1(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public HardwareIndexBufferPtr(HardwareIndexBufferPtr r) : this(OgrePINVOKE.new_HardwareIndexBufferPtr__SWIG_2(HardwareIndexBufferPtr.getCPtr(r)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public HardwareIndexBuffer __deref__() {
    global::System.IntPtr cPtr = OgrePINVOKE.HardwareIndexBufferPtr___deref__(swigCPtr);
    HardwareIndexBuffer ret = (cPtr == global::System.IntPtr.Zero) ? null : new HardwareIndexBuffer(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HardwareBufferManagerBase getManager() {
    global::System.IntPtr cPtr = OgrePINVOKE.HardwareIndexBufferPtr_getManager(swigCPtr);
    HardwareBufferManagerBase ret = (cPtr == global::System.IntPtr.Zero) ? null : new HardwareBufferManagerBase(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HardwareIndexBuffer.IndexType getType() {
    HardwareIndexBuffer.IndexType ret = (HardwareIndexBuffer.IndexType)OgrePINVOKE.HardwareIndexBufferPtr_getType(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getNumIndexes() {
    uint ret = OgrePINVOKE.HardwareIndexBufferPtr_getNumIndexes(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getIndexSize() {
    uint ret = OgrePINVOKE.HardwareIndexBufferPtr_getIndexSize(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_void lock_(uint offset, uint length, HardwareBuffer.LockOptions options) {
    global::System.IntPtr cPtr = OgrePINVOKE.HardwareIndexBufferPtr_lock___SWIG_0(swigCPtr, offset, length, (int)options);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_void lock_(HardwareBuffer.LockOptions options) {
    global::System.IntPtr cPtr = OgrePINVOKE.HardwareIndexBufferPtr_lock___SWIG_1(swigCPtr, (int)options);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void unlock() {
    OgrePINVOKE.HardwareIndexBufferPtr_unlock(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void readData(uint offset, uint length, SWIGTYPE_p_void pDest) {
    OgrePINVOKE.HardwareIndexBufferPtr_readData(swigCPtr, offset, length, SWIGTYPE_p_void.getCPtr(pDest));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void writeData(uint offset, uint length, SWIGTYPE_p_void pSource, bool discardWholeBuffer) {
    OgrePINVOKE.HardwareIndexBufferPtr_writeData__SWIG_0(swigCPtr, offset, length, SWIGTYPE_p_void.getCPtr(pSource), discardWholeBuffer);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void writeData(uint offset, uint length, SWIGTYPE_p_void pSource) {
    OgrePINVOKE.HardwareIndexBufferPtr_writeData__SWIG_1(swigCPtr, offset, length, SWIGTYPE_p_void.getCPtr(pSource));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void copyData(HardwareBuffer srcBuffer, uint srcOffset, uint dstOffset, uint length, bool discardWholeBuffer) {
    OgrePINVOKE.HardwareIndexBufferPtr_copyData__SWIG_0(swigCPtr, HardwareBuffer.getCPtr(srcBuffer), srcOffset, dstOffset, length, discardWholeBuffer);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void copyData(HardwareBuffer srcBuffer, uint srcOffset, uint dstOffset, uint length) {
    OgrePINVOKE.HardwareIndexBufferPtr_copyData__SWIG_1(swigCPtr, HardwareBuffer.getCPtr(srcBuffer), srcOffset, dstOffset, length);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void copyData(HardwareBuffer srcBuffer) {
    OgrePINVOKE.HardwareIndexBufferPtr_copyData__SWIG_2(swigCPtr, HardwareBuffer.getCPtr(srcBuffer));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _updateFromShadow() {
    OgrePINVOKE.HardwareIndexBufferPtr__updateFromShadow(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getSizeInBytes() {
    uint ret = OgrePINVOKE.HardwareIndexBufferPtr_getSizeInBytes(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HardwareBuffer.Usage getUsage() {
    HardwareBuffer.Usage ret = (HardwareBuffer.Usage)OgrePINVOKE.HardwareIndexBufferPtr_getUsage(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isSystemMemory() {
    bool ret = OgrePINVOKE.HardwareIndexBufferPtr_isSystemMemory(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool hasShadowBuffer() {
    bool ret = OgrePINVOKE.HardwareIndexBufferPtr_hasShadowBuffer(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isLocked() {
    bool ret = OgrePINVOKE.HardwareIndexBufferPtr_isLocked(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void suppressHardwareUpdate(bool suppress) {
    OgrePINVOKE.HardwareIndexBufferPtr_suppressHardwareUpdate(swigCPtr, suppress);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
