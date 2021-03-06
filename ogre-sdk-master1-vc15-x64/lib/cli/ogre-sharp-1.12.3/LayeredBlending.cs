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

public class LayeredBlending : FFPTexturing {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal LayeredBlending(global::System.IntPtr cPtr, bool cMemoryOwn) : base(RTShaderPINVOKE.LayeredBlending_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(LayeredBlending obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~LayeredBlending() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RTShaderPINVOKE.delete_LayeredBlending(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public class TextureBlend : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal TextureBlend(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TextureBlend obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~TextureBlend() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            RTShaderPINVOKE.delete_LayeredBlending_TextureBlend(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public TextureBlend() : this(RTShaderPINVOKE.new_LayeredBlending_TextureBlend(), true) {
      if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public LayeredBlending.BlendMode blendMode {
      set {
        RTShaderPINVOKE.LayeredBlending_TextureBlend_blendMode_set(swigCPtr, (int)value);
        if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        LayeredBlending.BlendMode ret = (LayeredBlending.BlendMode)RTShaderPINVOKE.LayeredBlending_TextureBlend_blendMode_get(swigCPtr);
        if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public LayeredBlending.SourceModifier sourceModifier {
      set {
        RTShaderPINVOKE.LayeredBlending_TextureBlend_sourceModifier_set(swigCPtr, (int)value);
        if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        LayeredBlending.SourceModifier ret = (LayeredBlending.SourceModifier)RTShaderPINVOKE.LayeredBlending_TextureBlend_sourceModifier_get(swigCPtr);
        if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public int customNum {
      set {
        RTShaderPINVOKE.LayeredBlending_TextureBlend_customNum_set(swigCPtr, value);
        if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        int ret = RTShaderPINVOKE.LayeredBlending_TextureBlend_customNum_get(swigCPtr);
        if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public SWIGTYPE_p_std__shared_ptrT_Ogre__RTShader__Parameter_t modControlParam {
      set {
        RTShaderPINVOKE.LayeredBlending_TextureBlend_modControlParam_set(swigCPtr, SWIGTYPE_p_std__shared_ptrT_Ogre__RTShader__Parameter_t.getCPtr(value));
        if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        global::System.IntPtr cPtr = RTShaderPINVOKE.LayeredBlending_TextureBlend_modControlParam_get(swigCPtr);
        SWIGTYPE_p_std__shared_ptrT_Ogre__RTShader__Parameter_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__shared_ptrT_Ogre__RTShader__Parameter_t(cPtr, false);
        if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
  }

  public LayeredBlending() : this(RTShaderPINVOKE.new_LayeredBlending(), true) {
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public override string getType() {
    string ret = RTShaderPINVOKE.LayeredBlending_getType(swigCPtr);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setBlendMode(ushort index, LayeredBlending.BlendMode mode) {
    RTShaderPINVOKE.LayeredBlending_setBlendMode(swigCPtr, index, (int)mode);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public LayeredBlending.BlendMode getBlendMode(ushort index) {
    LayeredBlending.BlendMode ret = (LayeredBlending.BlendMode)RTShaderPINVOKE.LayeredBlending_getBlendMode(swigCPtr, index);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setSourceModifier(ushort index, LayeredBlending.SourceModifier modType, int customNum) {
    RTShaderPINVOKE.LayeredBlending_setSourceModifier(swigCPtr, index, (int)modType, customNum);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getSourceModifier(ushort index, SWIGTYPE_p_Ogre__RTShader__LayeredBlending__SourceModifier modType, SWIGTYPE_p_int customNum) {
    bool ret = RTShaderPINVOKE.LayeredBlending_getSourceModifier(swigCPtr, index, SWIGTYPE_p_Ogre__RTShader__LayeredBlending__SourceModifier.getCPtr(modType), SWIGTYPE_p_int.getCPtr(customNum));
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void copyFrom(SubRenderState rhs) {
    RTShaderPINVOKE.LayeredBlending_copyFrom(swigCPtr, SubRenderState.getCPtr(rhs));
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public static string Type {
    set {
      RTShaderPINVOKE.LayeredBlending_Type_set(value);
      if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = RTShaderPINVOKE.LayeredBlending_Type_get();
      if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public enum BlendMode {
    LB_Invalid = -1,
    LB_FFPBlend,
    LB_BlendNormal,
    LB_BlendLighten,
    LB_BlendDarken,
    LB_BlendMultiply,
    LB_BlendAverage,
    LB_BlendAdd,
    LB_BlendSubtract,
    LB_BlendDifference,
    LB_BlendNegation,
    LB_BlendExclusion,
    LB_BlendScreen,
    LB_BlendOverlay,
    LB_BlendSoftLight,
    LB_BlendHardLight,
    LB_BlendColorDodge,
    LB_BlendColorBurn,
    LB_BlendLinearDodge,
    LB_BlendLinearBurn,
    LB_BlendLinearLight,
    LB_BlendVividLight,
    LB_BlendPinLight,
    LB_BlendHardMix,
    LB_BlendReflect,
    LB_BlendGlow,
    LB_BlendPhoenix,
    LB_BlendSaturation,
    LB_BlendColor,
    LB_BlendLuminosity,
    LB_MaxBlendModes
  }

  public enum SourceModifier {
    SM_Invalid = -1,
    SM_None,
    SM_Source1Modulate,
    SM_Source2Modulate,
    SM_Source1InvModulate,
    SM_Source2InvModulate,
    SM_MaxSourceModifiers
  }

}

}
