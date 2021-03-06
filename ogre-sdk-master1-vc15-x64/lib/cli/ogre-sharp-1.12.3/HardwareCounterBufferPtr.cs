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

public class HardwareCounterBufferPtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal HardwareCounterBufferPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(HardwareCounterBufferPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~HardwareCounterBufferPtr() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_HardwareCounterBufferPtr(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public HardwareCounterBufferPtr(SWIGTYPE_p_std__nullptr_t arg0) : this(OgrePINVOKE.new_HardwareCounterBufferPtr__SWIG_0(SWIGTYPE_p_std__nullptr_t.getCPtr(arg0)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public HardwareCounterBufferPtr() : this(OgrePINVOKE.new_HardwareCounterBufferPtr__SWIG_1(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public HardwareCounterBufferPtr(HardwareCounterBufferPtr r) : this(OgrePINVOKE.new_HardwareCounterBufferPtr__SWIG_2(HardwareCounterBufferPtr.getCPtr(r)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public HardwareCounterBuffer __deref__() {
    global::System.IntPtr cPtr = OgrePINVOKE.HardwareCounterBufferPtr___deref__(swigCPtr);
    HardwareCounterBuffer ret = (cPtr == global::System.IntPtr.Zero) ? null : new HardwareCounterBuffer(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HardwareBufferManagerBase getManager() {
    global::System.IntPtr cPtr = OgrePINVOKE.HardwareCounterBufferPtr_getManager(swigCPtr);
    HardwareBufferManagerBase ret = (cPtr == global::System.IntPtr.Zero) ? null : new HardwareBufferManagerBase(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getName() {
    string ret = OgrePINVOKE.HardwareCounterBufferPtr_getName(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_void lock_(uint offset, uint length, HardwareBuffer.LockOptions options) {
    global::System.IntPtr cPtr = OgrePINVOKE.HardwareCounterBufferPtr_lock___SWIG_0(swigCPtr, offset, length, (int)options);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_void lock_(HardwareBuffer.LockOptions options) {
    global::System.IntPtr cPtr = OgrePINVOKE.HardwareCounterBufferPtr_lock___SWIG_1(swigCPtr, (int)options);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void unlock() {
    OgrePINVOKE.HardwareCounterBufferPtr_unlock(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void readData(uint offset, uint length, SWIGTYPE_p_void pDest) {
    OgrePINVOKE.HardwareCounterBufferPtr_readData(swigCPtr, offset, length, SWIGTYPE_p_void.getCPtr(pDest));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void writeData(uint offset, uint length, SWIGTYPE_p_void pSource, bool discardWholeBuffer) {
    OgrePINVOKE.HardwareCounterBufferPtr_writeData__SWIG_0(swigCPtr, offset, length, SWIGTYPE_p_void.getCPtr(pSource), discardWholeBuffer);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void writeData(uint offset, uint length, SWIGTYPE_p_void pSource) {
    OgrePINVOKE.HardwareCounterBufferPtr_writeData__SWIG_1(swigCPtr, offset, length, SWIGTYPE_p_void.getCPtr(pSource));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void copyData(HardwareBuffer srcBuffer, uint srcOffset, uint dstOffset, uint length, bool discardWholeBuffer) {
    OgrePINVOKE.HardwareCounterBufferPtr_copyData__SWIG_0(swigCPtr, HardwareBuffer.getCPtr(srcBuffer), srcOffset, dstOffset, length, discardWholeBuffer);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void copyData(HardwareBuffer srcBuffer, uint srcOffset, uint dstOffset, uint length) {
    OgrePINVOKE.HardwareCounterBufferPtr_copyData__SWIG_1(swigCPtr, HardwareBuffer.getCPtr(srcBuffer), srcOffset, dstOffset, length);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void copyData(HardwareBuffer srcBuffer) {
    OgrePINVOKE.HardwareCounterBufferPtr_copyData__SWIG_2(swigCPtr, HardwareBuffer.getCPtr(srcBuffer));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _updateFromShadow() {
    OgrePINVOKE.HardwareCounterBufferPtr__updateFromShadow(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getSizeInBytes() {
    uint ret = OgrePINVOKE.HardwareCounterBufferPtr_getSizeInBytes(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HardwareBuffer.Usage getUsage() {
    HardwareBuffer.Usage ret = (HardwareBuffer.Usage)OgrePINVOKE.HardwareCounterBufferPtr_getUsage(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isSystemMemory() {
    bool ret = OgrePINVOKE.HardwareCounterBufferPtr_isSystemMemory(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool hasShadowBuffer() {
    bool ret = OgrePINVOKE.HardwareCounterBufferPtr_hasShadowBuffer(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isLocked() {
    bool ret = OgrePINVOKE.HardwareCounterBufferPtr_isLocked(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void suppressHardwareUpdate(bool suppress) {
    OgrePINVOKE.HardwareCounterBufferPtr_suppressHardwareUpdate(swigCPtr, suppress);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
