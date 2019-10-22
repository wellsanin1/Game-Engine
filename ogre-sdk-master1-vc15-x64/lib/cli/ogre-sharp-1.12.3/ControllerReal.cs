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

public class ControllerReal : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ControllerReal(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ControllerReal obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ControllerReal() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_ControllerReal(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public ControllerReal(ControllerValueRealPtr src, ControllerValueRealPtr dest, ControllerFunctionPtr func) : this(OgrePINVOKE.new_ControllerReal(ControllerValueRealPtr.getCPtr(src), ControllerValueRealPtr.getCPtr(dest), ControllerFunctionPtr.getCPtr(func)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSource(ControllerValueRealPtr src) {
    OgrePINVOKE.ControllerReal_setSource(swigCPtr, ControllerValueRealPtr.getCPtr(src));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ControllerValueRealPtr getSource() {
    ControllerValueRealPtr ret = new ControllerValueRealPtr(OgrePINVOKE.ControllerReal_getSource(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setDestination(ControllerValueRealPtr dest) {
    OgrePINVOKE.ControllerReal_setDestination(swigCPtr, ControllerValueRealPtr.getCPtr(dest));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ControllerValueRealPtr getDestination() {
    ControllerValueRealPtr ret = new ControllerValueRealPtr(OgrePINVOKE.ControllerReal_getDestination(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool getEnabled() {
    bool ret = OgrePINVOKE.ControllerReal_getEnabled(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setEnabled(bool enabled) {
    OgrePINVOKE.ControllerReal_setEnabled(swigCPtr, enabled);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setFunction(ControllerFunctionPtr func) {
    OgrePINVOKE.ControllerReal_setFunction(swigCPtr, ControllerFunctionPtr.getCPtr(func));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ControllerFunctionPtr getFunction() {
    ControllerFunctionPtr ret = new ControllerFunctionPtr(OgrePINVOKE.ControllerReal_getFunction(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void update() {
    OgrePINVOKE.ControllerReal_update(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
