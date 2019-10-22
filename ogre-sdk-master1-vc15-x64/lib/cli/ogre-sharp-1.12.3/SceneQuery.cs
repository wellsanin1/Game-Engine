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

public class SceneQuery : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SceneQuery(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SceneQuery obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SceneQuery() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_SceneQuery(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public class WorldFragment : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal WorldFragment(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(WorldFragment obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~WorldFragment() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            OgrePINVOKE.delete_SceneQuery_WorldFragment(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public SceneQuery.WorldFragmentType fragmentType {
      set {
        OgrePINVOKE.SceneQuery_WorldFragment_fragmentType_set(swigCPtr, (int)value);
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        SceneQuery.WorldFragmentType ret = (SceneQuery.WorldFragmentType)OgrePINVOKE.SceneQuery_WorldFragment_fragmentType_get(swigCPtr);
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public Vector3 singleIntersection {
      set {
        OgrePINVOKE.SceneQuery_WorldFragment_singleIntersection_set(swigCPtr, Vector3.getCPtr(value));
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        global::System.IntPtr cPtr = OgrePINVOKE.SceneQuery_WorldFragment_singleIntersection_get(swigCPtr);
        Vector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector3(cPtr, false);
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public SWIGTYPE_p_std__vectorT_Ogre__Plane_t planes {
      set {
        OgrePINVOKE.SceneQuery_WorldFragment_planes_set(swigCPtr, SWIGTYPE_p_std__vectorT_Ogre__Plane_t.getCPtr(value));
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        global::System.IntPtr cPtr = OgrePINVOKE.SceneQuery_WorldFragment_planes_get(swigCPtr);
        SWIGTYPE_p_std__vectorT_Ogre__Plane_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__vectorT_Ogre__Plane_t(cPtr, false);
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public SWIGTYPE_p_void geometry {
      set {
        OgrePINVOKE.SceneQuery_WorldFragment_geometry_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        global::System.IntPtr cPtr = OgrePINVOKE.SceneQuery_WorldFragment_geometry_get(swigCPtr);
        SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public RenderOperation renderOp {
      set {
        OgrePINVOKE.SceneQuery_WorldFragment_renderOp_set(swigCPtr, RenderOperation.getCPtr(value));
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        global::System.IntPtr cPtr = OgrePINVOKE.SceneQuery_WorldFragment_renderOp_get(swigCPtr);
        RenderOperation ret = (cPtr == global::System.IntPtr.Zero) ? null : new RenderOperation(cPtr, false);
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public WorldFragment() : this(OgrePINVOKE.new_SceneQuery_WorldFragment(), true) {
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    }
  
  }

  public SceneQuery(SceneManager mgr) : this(OgrePINVOKE.new_SceneQuery(SceneManager.getCPtr(mgr)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setQueryMask(uint mask) {
    OgrePINVOKE.SceneQuery_setQueryMask(swigCPtr, mask);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual uint getQueryMask() {
    uint ret = OgrePINVOKE.SceneQuery_getQueryMask(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void setQueryTypeMask(uint mask) {
    OgrePINVOKE.SceneQuery_setQueryTypeMask(swigCPtr, mask);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual uint getQueryTypeMask() {
    uint ret = OgrePINVOKE.SceneQuery_getQueryTypeMask(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void setWorldFragmentType(SceneQuery.WorldFragmentType wft) {
    OgrePINVOKE.SceneQuery_setWorldFragmentType(swigCPtr, (int)wft);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual SceneQuery.WorldFragmentType getWorldFragmentType() {
    SceneQuery.WorldFragmentType ret = (SceneQuery.WorldFragmentType)OgrePINVOKE.SceneQuery_getWorldFragmentType(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_std__setT_Ogre__SceneQuery__WorldFragmentType_t getSupportedWorldFragmentTypes() {
    global::System.IntPtr cPtr = OgrePINVOKE.SceneQuery_getSupportedWorldFragmentTypes(swigCPtr);
    SWIGTYPE_p_std__setT_Ogre__SceneQuery__WorldFragmentType_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__setT_Ogre__SceneQuery__WorldFragmentType_t(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum WorldFragmentType {
    WFT_NONE,
    WFT_PLANE_BOUNDED_REGION,
    WFT_SINGLE_INTERSECTION,
    WFT_CUSTOM_GEOMETRY,
    WFT_RENDER_OPERATION
  }

}

}