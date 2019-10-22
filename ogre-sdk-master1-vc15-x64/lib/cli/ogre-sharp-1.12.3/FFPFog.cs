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

public class FFPFog : SubRenderState {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FFPFog(global::System.IntPtr cPtr, bool cMemoryOwn) : base(RTShaderPINVOKE.FFPFog_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FFPFog obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FFPFog() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RTShaderPINVOKE.delete_FFPFog(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public FFPFog() : this(RTShaderPINVOKE.new_FFPFog(), true) {
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public override string getType() {
    string ret = RTShaderPINVOKE.FFPFog_getType(swigCPtr);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int getExecutionOrder() {
    int ret = RTShaderPINVOKE.FFPFog_getExecutionOrder(swigCPtr);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void updateGpuProgramsParams(Renderable rend, Pass pass, SWIGTYPE_p_Ogre__AutoParamDataSource source, SWIGTYPE_p_Ogre__HashedVectorT_Ogre__Light_p_t pLightList) {
    RTShaderPINVOKE.FFPFog_updateGpuProgramsParams(swigCPtr, Renderable.getCPtr(rend), Pass.getCPtr(pass), SWIGTYPE_p_Ogre__AutoParamDataSource.getCPtr(source), SWIGTYPE_p_Ogre__HashedVectorT_Ogre__Light_p_t.getCPtr(pLightList));
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void copyFrom(SubRenderState rhs) {
    RTShaderPINVOKE.FFPFog_copyFrom(swigCPtr, SubRenderState.getCPtr(rhs));
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public override bool preAddToRenderState(RenderState renderState, Pass srcPass, Pass dstPass) {
    bool ret = RTShaderPINVOKE.FFPFog_preAddToRenderState(swigCPtr, RenderState.getCPtr(renderState), Pass.getCPtr(srcPass), Pass.getCPtr(dstPass));
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setFogProperties(FogMode fogMode, ColourValue fogColour, float fogStart, float fogEnd, float fogDensity) {
    RTShaderPINVOKE.FFPFog_setFogProperties(swigCPtr, (int)fogMode, ColourValue.getCPtr(fogColour), fogStart, fogEnd, fogDensity);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setCalcMode(FFPFog.CalcMode calcMode) {
    RTShaderPINVOKE.FFPFog_setCalcMode(swigCPtr, (int)calcMode);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public FFPFog.CalcMode getCalcMode() {
    FFPFog.CalcMode ret = (FFPFog.CalcMode)RTShaderPINVOKE.FFPFog_getCalcMode(swigCPtr);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string Type {
    set {
      RTShaderPINVOKE.FFPFog_Type_set(value);
      if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = RTShaderPINVOKE.FFPFog_Type_get();
      if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public enum CalcMode {
    CM_PER_VERTEX = 1,
    CM_PER_PIXEL = 2
  }

}

}
