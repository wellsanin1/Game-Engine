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

public class ShadowCameraSetupPtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ShadowCameraSetupPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ShadowCameraSetupPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ShadowCameraSetupPtr() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_ShadowCameraSetupPtr(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public ShadowCameraSetupPtr(SWIGTYPE_p_std__nullptr_t arg0) : this(OgrePINVOKE.new_ShadowCameraSetupPtr__SWIG_0(SWIGTYPE_p_std__nullptr_t.getCPtr(arg0)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ShadowCameraSetupPtr() : this(OgrePINVOKE.new_ShadowCameraSetupPtr__SWIG_1(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ShadowCameraSetupPtr(ShadowCameraSetupPtr r) : this(OgrePINVOKE.new_ShadowCameraSetupPtr__SWIG_2(ShadowCameraSetupPtr.getCPtr(r)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ShadowCameraSetup __deref__() {
    global::System.IntPtr cPtr = OgrePINVOKE.ShadowCameraSetupPtr___deref__(swigCPtr);
    ShadowCameraSetup ret = (cPtr == global::System.IntPtr.Zero) ? null : new ShadowCameraSetup(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void getShadowCamera(SceneManager sm, Camera cam, Viewport vp, Light light, Camera texCam, uint iteration) {
    OgrePINVOKE.ShadowCameraSetupPtr_getShadowCamera(swigCPtr, SceneManager.getCPtr(sm), Camera.getCPtr(cam), Viewport.getCPtr(vp), Light.getCPtr(light), Camera.getCPtr(texCam), iteration);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
