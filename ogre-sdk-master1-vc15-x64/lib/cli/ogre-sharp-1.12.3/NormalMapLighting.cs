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

public class NormalMapLighting : PerPixelLighting {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal NormalMapLighting(global::System.IntPtr cPtr, bool cMemoryOwn) : base(RTShaderPINVOKE.NormalMapLighting_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NormalMapLighting obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~NormalMapLighting() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RTShaderPINVOKE.delete_NormalMapLighting(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public NormalMapLighting() : this(RTShaderPINVOKE.new_NormalMapLighting(), true) {
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public override string getType() {
    string ret = RTShaderPINVOKE.NormalMapLighting_getType(swigCPtr);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void updateGpuProgramsParams(Renderable rend, Pass pass, SWIGTYPE_p_Ogre__AutoParamDataSource source, SWIGTYPE_p_Ogre__HashedVectorT_Ogre__Light_p_t pLightList) {
    RTShaderPINVOKE.NormalMapLighting_updateGpuProgramsParams(swigCPtr, Renderable.getCPtr(rend), Pass.getCPtr(pass), SWIGTYPE_p_Ogre__AutoParamDataSource.getCPtr(source), SWIGTYPE_p_Ogre__HashedVectorT_Ogre__Light_p_t.getCPtr(pLightList));
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void copyFrom(SubRenderState rhs) {
    RTShaderPINVOKE.NormalMapLighting_copyFrom(swigCPtr, SubRenderState.getCPtr(rhs));
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public override bool preAddToRenderState(RenderState renderState, Pass srcPass, Pass dstPass) {
    bool ret = RTShaderPINVOKE.NormalMapLighting_preAddToRenderState(swigCPtr, RenderState.getCPtr(renderState), Pass.getCPtr(srcPass), Pass.getCPtr(dstPass));
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setTexCoordIndex(uint index) {
    RTShaderPINVOKE.NormalMapLighting_setTexCoordIndex(swigCPtr, index);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getTexCoordIndex() {
    uint ret = RTShaderPINVOKE.NormalMapLighting_getTexCoordIndex(swigCPtr);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string Type {
    set {
      RTShaderPINVOKE.NormalMapLighting_Type_set(value);
      if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = RTShaderPINVOKE.NormalMapLighting_Type_get();
      if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public void setNormalMapSpace(NormalMapLighting.NormalMapSpace normalMapSpace) {
    RTShaderPINVOKE.NormalMapLighting_setNormalMapSpace(swigCPtr, (int)normalMapSpace);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public NormalMapLighting.NormalMapSpace getNormalMapSpace() {
    NormalMapLighting.NormalMapSpace ret = (NormalMapLighting.NormalMapSpace)RTShaderPINVOKE.NormalMapLighting_getNormalMapSpace(swigCPtr);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setNormalMapTextureName(string textureName) {
    RTShaderPINVOKE.NormalMapLighting_setNormalMapTextureName(swigCPtr, textureName);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public string getNormalMapTextureName() {
    string ret = RTShaderPINVOKE.NormalMapLighting_getNormalMapTextureName(swigCPtr);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setNormalMapFiltering(FilterOptions minFilter, FilterOptions magFilter, FilterOptions mipFilter) {
    RTShaderPINVOKE.NormalMapLighting_setNormalMapFiltering(swigCPtr, (int)minFilter, (int)magFilter, (int)mipFilter);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setNormalMapAnisotropy(uint anisotropy) {
    RTShaderPINVOKE.NormalMapLighting_setNormalMapAnisotropy(swigCPtr, anisotropy);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setNormalMapMipBias(float mipBias) {
    RTShaderPINVOKE.NormalMapLighting_setNormalMapMipBias(swigCPtr, mipBias);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_std__shared_ptrT_Ogre__Sampler_t getNormalMapSampler() {
    SWIGTYPE_p_std__shared_ptrT_Ogre__Sampler_t ret = new SWIGTYPE_p_std__shared_ptrT_Ogre__Sampler_t(RTShaderPINVOKE.NormalMapLighting_getNormalMapSampler(swigCPtr), false);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setNormalMapSampler(SWIGTYPE_p_std__shared_ptrT_Ogre__Sampler_t sampler) {
    RTShaderPINVOKE.NormalMapLighting_setNormalMapSampler(swigCPtr, SWIGTYPE_p_std__shared_ptrT_Ogre__Sampler_t.getCPtr(sampler));
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public enum NormalMapSpace {
    NMS_TANGENT,
    NMS_OBJECT
  }

}

}
