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

public class LiSPSMShadowCameraSetup : FocusedShadowCameraSetup {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal LiSPSMShadowCameraSetup(global::System.IntPtr cPtr, bool cMemoryOwn) : base(OgrePINVOKE.LiSPSMShadowCameraSetup_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(LiSPSMShadowCameraSetup obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~LiSPSMShadowCameraSetup() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_LiSPSMShadowCameraSetup(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public LiSPSMShadowCameraSetup(float n, bool useSimpleNOpt, Degree angle) : this(OgrePINVOKE.new_LiSPSMShadowCameraSetup__SWIG_0(n, useSimpleNOpt, Degree.getCPtr(angle)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public LiSPSMShadowCameraSetup(float n, bool useSimpleNOpt) : this(OgrePINVOKE.new_LiSPSMShadowCameraSetup__SWIG_1(n, useSimpleNOpt), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public LiSPSMShadowCameraSetup(float n) : this(OgrePINVOKE.new_LiSPSMShadowCameraSetup__SWIG_2(n), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public LiSPSMShadowCameraSetup() : this(OgrePINVOKE.new_LiSPSMShadowCameraSetup__SWIG_3(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public static ShadowCameraSetupPtr create(float n, bool useSimpleNOpt, Degree angle) {
    ShadowCameraSetupPtr ret = new ShadowCameraSetupPtr(OgrePINVOKE.LiSPSMShadowCameraSetup_create__SWIG_0(n, useSimpleNOpt, Degree.getCPtr(angle)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static ShadowCameraSetupPtr create(float n, bool useSimpleNOpt) {
    ShadowCameraSetupPtr ret = new ShadowCameraSetupPtr(OgrePINVOKE.LiSPSMShadowCameraSetup_create__SWIG_1(n, useSimpleNOpt), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static ShadowCameraSetupPtr create(float n) {
    ShadowCameraSetupPtr ret = new ShadowCameraSetupPtr(OgrePINVOKE.LiSPSMShadowCameraSetup_create__SWIG_2(n), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static ShadowCameraSetupPtr create() {
    ShadowCameraSetupPtr ret = new ShadowCameraSetupPtr(OgrePINVOKE.LiSPSMShadowCameraSetup_create__SWIG_3(), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void getShadowCamera(SceneManager sm, Camera cam, Viewport vp, Light light, Camera texCam, uint iteration) {
    OgrePINVOKE.LiSPSMShadowCameraSetup_getShadowCamera(swigCPtr, SceneManager.getCPtr(sm), Camera.getCPtr(cam), Viewport.getCPtr(vp), Light.getCPtr(light), Camera.getCPtr(texCam), iteration);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setOptimalAdjustFactor(float n) {
    OgrePINVOKE.LiSPSMShadowCameraSetup_setOptimalAdjustFactor(swigCPtr, n);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual float getOptimalAdjustFactor() {
    float ret = OgrePINVOKE.LiSPSMShadowCameraSetup_getOptimalAdjustFactor(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void setUseSimpleOptimalAdjust(bool s) {
    OgrePINVOKE.LiSPSMShadowCameraSetup_setUseSimpleOptimalAdjust(swigCPtr, s);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool getUseSimpleOptimalAdjust() {
    bool ret = OgrePINVOKE.LiSPSMShadowCameraSetup_getUseSimpleOptimalAdjust(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void setCameraLightDirectionThreshold(Degree angle) {
    OgrePINVOKE.LiSPSMShadowCameraSetup_setCameraLightDirectionThreshold(swigCPtr, Degree.getCPtr(angle));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual Degree getCameraLightDirectionThreshold() {
    Degree ret = new Degree(OgrePINVOKE.LiSPSMShadowCameraSetup_getCameraLightDirectionThreshold(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
