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

public class ShadowTextureConfig : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ShadowTextureConfig(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ShadowTextureConfig obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ShadowTextureConfig() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_ShadowTextureConfig(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public uint width {
    set {
      OgrePINVOKE.ShadowTextureConfig_width_set(swigCPtr, value);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      uint ret = OgrePINVOKE.ShadowTextureConfig_width_get(swigCPtr);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint height {
    set {
      OgrePINVOKE.ShadowTextureConfig_height_set(swigCPtr, value);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      uint ret = OgrePINVOKE.ShadowTextureConfig_height_get(swigCPtr);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public PixelFormat format {
    set {
      OgrePINVOKE.ShadowTextureConfig_format_set(swigCPtr, (int)value);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      PixelFormat ret = (PixelFormat)OgrePINVOKE.ShadowTextureConfig_format_get(swigCPtr);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint fsaa {
    set {
      OgrePINVOKE.ShadowTextureConfig_fsaa_set(swigCPtr, value);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      uint ret = OgrePINVOKE.ShadowTextureConfig_fsaa_get(swigCPtr);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public ushort depthBufferPoolId {
    set {
      OgrePINVOKE.ShadowTextureConfig_depthBufferPoolId_set(swigCPtr, value);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      ushort ret = OgrePINVOKE.ShadowTextureConfig_depthBufferPoolId_get(swigCPtr);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public ShadowTextureConfig() : this(OgrePINVOKE.new_ShadowTextureConfig(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
