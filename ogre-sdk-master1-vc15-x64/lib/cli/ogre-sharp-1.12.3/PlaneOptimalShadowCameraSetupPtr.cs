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

public class PlaneOptimalShadowCameraSetupPtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PlaneOptimalShadowCameraSetupPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PlaneOptimalShadowCameraSetupPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PlaneOptimalShadowCameraSetupPtr() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_PlaneOptimalShadowCameraSetupPtr(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PlaneOptimalShadowCameraSetupPtr(SWIGTYPE_p_std__nullptr_t arg0) : this(OgrePINVOKE.new_PlaneOptimalShadowCameraSetupPtr__SWIG_0(SWIGTYPE_p_std__nullptr_t.getCPtr(arg0)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public PlaneOptimalShadowCameraSetupPtr() : this(OgrePINVOKE.new_PlaneOptimalShadowCameraSetupPtr__SWIG_1(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public PlaneOptimalShadowCameraSetupPtr(PlaneOptimalShadowCameraSetupPtr r) : this(OgrePINVOKE.new_PlaneOptimalShadowCameraSetupPtr__SWIG_2(PlaneOptimalShadowCameraSetupPtr.getCPtr(r)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public PlaneOptimalShadowCameraSetup __deref__() {
    global::System.IntPtr cPtr = OgrePINVOKE.PlaneOptimalShadowCameraSetupPtr___deref__(swigCPtr);
    PlaneOptimalShadowCameraSetup ret = (cPtr == global::System.IntPtr.Zero) ? null : new PlaneOptimalShadowCameraSetup(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ShadowCameraSetupPtr create(MovablePlane plane) {
    ShadowCameraSetupPtr ret = new ShadowCameraSetupPtr(OgrePINVOKE.PlaneOptimalShadowCameraSetupPtr_create(swigCPtr, MovablePlane.getCPtr(plane)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void getShadowCamera(SceneManager sm, Camera cam, Viewport vp, Light light, Camera texCam, uint iteration) {
    OgrePINVOKE.PlaneOptimalShadowCameraSetupPtr_getShadowCamera(swigCPtr, SceneManager.getCPtr(sm), Camera.getCPtr(cam), Viewport.getCPtr(vp), Light.getCPtr(light), Camera.getCPtr(texCam), iteration);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}