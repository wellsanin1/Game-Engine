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

public class TempBlendedBufferInfo : HardwareBufferLicensee {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal TempBlendedBufferInfo(global::System.IntPtr cPtr, bool cMemoryOwn) : base(OgrePINVOKE.TempBlendedBufferInfo_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TempBlendedBufferInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TempBlendedBufferInfo() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_TempBlendedBufferInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public void extractFrom(VertexData sourceData) {
    OgrePINVOKE.TempBlendedBufferInfo_extractFrom(swigCPtr, VertexData.getCPtr(sourceData));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void checkoutTempCopies(bool positions, bool normals) {
    OgrePINVOKE.TempBlendedBufferInfo_checkoutTempCopies__SWIG_0(swigCPtr, positions, normals);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void checkoutTempCopies(bool positions) {
    OgrePINVOKE.TempBlendedBufferInfo_checkoutTempCopies__SWIG_1(swigCPtr, positions);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void checkoutTempCopies() {
    OgrePINVOKE.TempBlendedBufferInfo_checkoutTempCopies__SWIG_2(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void bindTempCopies(VertexData targetData, bool suppressHardwareUpload) {
    OgrePINVOKE.TempBlendedBufferInfo_bindTempCopies(swigCPtr, VertexData.getCPtr(targetData), suppressHardwareUpload);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void licenseExpired(HardwareBuffer buffer) {
    OgrePINVOKE.TempBlendedBufferInfo_licenseExpired(swigCPtr, HardwareBuffer.getCPtr(buffer));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool buffersCheckedOut(bool positions, bool normals) {
    bool ret = OgrePINVOKE.TempBlendedBufferInfo_buffersCheckedOut__SWIG_0(swigCPtr, positions, normals);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool buffersCheckedOut(bool positions) {
    bool ret = OgrePINVOKE.TempBlendedBufferInfo_buffersCheckedOut__SWIG_1(swigCPtr, positions);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool buffersCheckedOut() {
    bool ret = OgrePINVOKE.TempBlendedBufferInfo_buffersCheckedOut__SWIG_2(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TempBlendedBufferInfo() : this(OgrePINVOKE.new_TempBlendedBufferInfo(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
