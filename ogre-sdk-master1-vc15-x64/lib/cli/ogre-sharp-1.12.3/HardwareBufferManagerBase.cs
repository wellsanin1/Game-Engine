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

public class HardwareBufferManagerBase : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal HardwareBufferManagerBase(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(HardwareBufferManagerBase obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~HardwareBufferManagerBase() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_HardwareBufferManagerBase(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual HardwareVertexBufferPtr createVertexBuffer(uint vertexSize, uint numVerts, HardwareBuffer.Usage usage, bool useShadowBuffer) {
    HardwareVertexBufferPtr ret = new HardwareVertexBufferPtr(OgrePINVOKE.HardwareBufferManagerBase_createVertexBuffer__SWIG_0(swigCPtr, vertexSize, numVerts, (int)usage, useShadowBuffer), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual HardwareVertexBufferPtr createVertexBuffer(uint vertexSize, uint numVerts, HardwareBuffer.Usage usage) {
    HardwareVertexBufferPtr ret = new HardwareVertexBufferPtr(OgrePINVOKE.HardwareBufferManagerBase_createVertexBuffer__SWIG_1(swigCPtr, vertexSize, numVerts, (int)usage), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual HardwareIndexBufferPtr createIndexBuffer(HardwareIndexBuffer.IndexType itype, uint numIndexes, HardwareBuffer.Usage usage, bool useShadowBuffer) {
    HardwareIndexBufferPtr ret = new HardwareIndexBufferPtr(OgrePINVOKE.HardwareBufferManagerBase_createIndexBuffer__SWIG_0(swigCPtr, (int)itype, numIndexes, (int)usage, useShadowBuffer), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual HardwareIndexBufferPtr createIndexBuffer(HardwareIndexBuffer.IndexType itype, uint numIndexes, HardwareBuffer.Usage usage) {
    HardwareIndexBufferPtr ret = new HardwareIndexBufferPtr(OgrePINVOKE.HardwareBufferManagerBase_createIndexBuffer__SWIG_1(swigCPtr, (int)itype, numIndexes, (int)usage), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__SharedPtrT_Ogre__RenderToVertexBuffer_t createRenderToVertexBuffer() {
    SWIGTYPE_p_Ogre__SharedPtrT_Ogre__RenderToVertexBuffer_t ret = new SWIGTYPE_p_Ogre__SharedPtrT_Ogre__RenderToVertexBuffer_t(OgrePINVOKE.HardwareBufferManagerBase_createRenderToVertexBuffer(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual HardwareUniformBufferPtr createUniformBuffer(uint sizeBytes, HardwareBuffer.Usage usage, bool useShadowBuffer, string name) {
    HardwareUniformBufferPtr ret = new HardwareUniformBufferPtr(OgrePINVOKE.HardwareBufferManagerBase_createUniformBuffer__SWIG_0(swigCPtr, sizeBytes, (int)usage, useShadowBuffer, name), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual HardwareUniformBufferPtr createUniformBuffer(uint sizeBytes, HardwareBuffer.Usage usage, bool useShadowBuffer) {
    HardwareUniformBufferPtr ret = new HardwareUniformBufferPtr(OgrePINVOKE.HardwareBufferManagerBase_createUniformBuffer__SWIG_1(swigCPtr, sizeBytes, (int)usage, useShadowBuffer), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual HardwareUniformBufferPtr createUniformBuffer(uint sizeBytes, HardwareBuffer.Usage usage) {
    HardwareUniformBufferPtr ret = new HardwareUniformBufferPtr(OgrePINVOKE.HardwareBufferManagerBase_createUniformBuffer__SWIG_2(swigCPtr, sizeBytes, (int)usage), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual HardwareUniformBufferPtr createUniformBuffer(uint sizeBytes) {
    HardwareUniformBufferPtr ret = new HardwareUniformBufferPtr(OgrePINVOKE.HardwareBufferManagerBase_createUniformBuffer__SWIG_3(swigCPtr, sizeBytes), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual HardwareCounterBufferPtr createCounterBuffer(uint sizeBytes, HardwareBuffer.Usage usage, bool useShadowBuffer, string name) {
    HardwareCounterBufferPtr ret = new HardwareCounterBufferPtr(OgrePINVOKE.HardwareBufferManagerBase_createCounterBuffer__SWIG_0(swigCPtr, sizeBytes, (int)usage, useShadowBuffer, name), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual HardwareCounterBufferPtr createCounterBuffer(uint sizeBytes, HardwareBuffer.Usage usage, bool useShadowBuffer) {
    HardwareCounterBufferPtr ret = new HardwareCounterBufferPtr(OgrePINVOKE.HardwareBufferManagerBase_createCounterBuffer__SWIG_1(swigCPtr, sizeBytes, (int)usage, useShadowBuffer), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual HardwareCounterBufferPtr createCounterBuffer(uint sizeBytes, HardwareBuffer.Usage usage) {
    HardwareCounterBufferPtr ret = new HardwareCounterBufferPtr(OgrePINVOKE.HardwareBufferManagerBase_createCounterBuffer__SWIG_2(swigCPtr, sizeBytes, (int)usage), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual HardwareCounterBufferPtr createCounterBuffer(uint sizeBytes) {
    HardwareCounterBufferPtr ret = new HardwareCounterBufferPtr(OgrePINVOKE.HardwareBufferManagerBase_createCounterBuffer__SWIG_3(swigCPtr, sizeBytes), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VertexDeclaration createVertexDeclaration() {
    global::System.IntPtr cPtr = OgrePINVOKE.HardwareBufferManagerBase_createVertexDeclaration(swigCPtr);
    VertexDeclaration ret = (cPtr == global::System.IntPtr.Zero) ? null : new VertexDeclaration(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void destroyVertexDeclaration(VertexDeclaration decl) {
    OgrePINVOKE.HardwareBufferManagerBase_destroyVertexDeclaration(swigCPtr, VertexDeclaration.getCPtr(decl));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public VertexBufferBinding createVertexBufferBinding() {
    global::System.IntPtr cPtr = OgrePINVOKE.HardwareBufferManagerBase_createVertexBufferBinding(swigCPtr);
    VertexBufferBinding ret = (cPtr == global::System.IntPtr.Zero) ? null : new VertexBufferBinding(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void destroyVertexBufferBinding(VertexBufferBinding binding) {
    OgrePINVOKE.HardwareBufferManagerBase_destroyVertexBufferBinding(swigCPtr, VertexBufferBinding.getCPtr(binding));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void registerVertexBufferSourceAndCopy(HardwareVertexBufferPtr sourceBuffer, HardwareVertexBufferPtr copy) {
    OgrePINVOKE.HardwareBufferManagerBase_registerVertexBufferSourceAndCopy(swigCPtr, HardwareVertexBufferPtr.getCPtr(sourceBuffer), HardwareVertexBufferPtr.getCPtr(copy));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public HardwareVertexBufferPtr allocateVertexBufferCopy(HardwareVertexBufferPtr sourceBuffer, HardwareBufferManagerBase.BufferLicenseType licenseType, HardwareBufferLicensee licensee, bool copyData) {
    HardwareVertexBufferPtr ret = new HardwareVertexBufferPtr(OgrePINVOKE.HardwareBufferManagerBase_allocateVertexBufferCopy__SWIG_0(swigCPtr, HardwareVertexBufferPtr.getCPtr(sourceBuffer), (int)licenseType, HardwareBufferLicensee.getCPtr(licensee), copyData), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HardwareVertexBufferPtr allocateVertexBufferCopy(HardwareVertexBufferPtr sourceBuffer, HardwareBufferManagerBase.BufferLicenseType licenseType, HardwareBufferLicensee licensee) {
    HardwareVertexBufferPtr ret = new HardwareVertexBufferPtr(OgrePINVOKE.HardwareBufferManagerBase_allocateVertexBufferCopy__SWIG_1(swigCPtr, HardwareVertexBufferPtr.getCPtr(sourceBuffer), (int)licenseType, HardwareBufferLicensee.getCPtr(licensee)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void releaseVertexBufferCopy(HardwareVertexBufferPtr bufferCopy) {
    OgrePINVOKE.HardwareBufferManagerBase_releaseVertexBufferCopy(swigCPtr, HardwareVertexBufferPtr.getCPtr(bufferCopy));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void touchVertexBufferCopy(HardwareVertexBufferPtr bufferCopy) {
    OgrePINVOKE.HardwareBufferManagerBase_touchVertexBufferCopy(swigCPtr, HardwareVertexBufferPtr.getCPtr(bufferCopy));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _freeUnusedBufferCopies() {
    OgrePINVOKE.HardwareBufferManagerBase__freeUnusedBufferCopies(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _releaseBufferCopies(bool forceFreeUnused) {
    OgrePINVOKE.HardwareBufferManagerBase__releaseBufferCopies__SWIG_0(swigCPtr, forceFreeUnused);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _releaseBufferCopies() {
    OgrePINVOKE.HardwareBufferManagerBase__releaseBufferCopies__SWIG_1(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _forceReleaseBufferCopies(HardwareVertexBufferPtr sourceBuffer) {
    OgrePINVOKE.HardwareBufferManagerBase__forceReleaseBufferCopies(swigCPtr, HardwareVertexBufferPtr.getCPtr(sourceBuffer));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _notifyVertexBufferDestroyed(HardwareVertexBuffer buf) {
    OgrePINVOKE.HardwareBufferManagerBase__notifyVertexBufferDestroyed(swigCPtr, HardwareVertexBuffer.getCPtr(buf));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _notifyIndexBufferDestroyed(HardwareIndexBuffer buf) {
    OgrePINVOKE.HardwareBufferManagerBase__notifyIndexBufferDestroyed(swigCPtr, HardwareIndexBuffer.getCPtr(buf));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _notifyUniformBufferDestroyed(HardwareUniformBuffer buf) {
    OgrePINVOKE.HardwareBufferManagerBase__notifyUniformBufferDestroyed(swigCPtr, HardwareUniformBuffer.getCPtr(buf));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _notifyCounterBufferDestroyed(HardwareCounterBuffer buf) {
    OgrePINVOKE.HardwareBufferManagerBase__notifyCounterBufferDestroyed(swigCPtr, HardwareCounterBuffer.getCPtr(buf));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public enum BufferLicenseType {
    BLT_MANUAL_RELEASE,
    BLT_AUTOMATIC_RELEASE
  }

}

}
