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

public class Ray : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Ray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Ray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Ray() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_Ray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public Ray() : this(OgrePINVOKE.new_Ray__SWIG_0(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Ray(Vector3 origin, Vector3 direction) : this(OgrePINVOKE.new_Ray__SWIG_1(Vector3.getCPtr(origin), Vector3.getCPtr(direction)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setOrigin(Vector3 origin) {
    OgrePINVOKE.Ray_setOrigin(swigCPtr, Vector3.getCPtr(origin));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector3 getOrigin() {
    Vector3 ret = new Vector3(OgrePINVOKE.Ray_getOrigin(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setDirection(Vector3 dir) {
    OgrePINVOKE.Ray_setDirection(swigCPtr, Vector3.getCPtr(dir));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector3 getDirection() {
    Vector3 ret = new Vector3(OgrePINVOKE.Ray_getDirection(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector3 getPoint(float t) {
    Vector3 ret = new Vector3(OgrePINVOKE.Ray_getPoint(swigCPtr, t), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__pairT_bool_float_t intersects(Plane p) {
    SWIGTYPE_p_std__pairT_bool_float_t ret = new SWIGTYPE_p_std__pairT_bool_float_t(OgrePINVOKE.Ray_intersects__SWIG_0(swigCPtr, Plane.getCPtr(p)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__pairT_bool_float_t intersects(PlaneBoundedVolume p) {
    SWIGTYPE_p_std__pairT_bool_float_t ret = new SWIGTYPE_p_std__pairT_bool_float_t(OgrePINVOKE.Ray_intersects__SWIG_1(swigCPtr, PlaneBoundedVolume.getCPtr(p)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__pairT_bool_float_t intersects(Sphere s, bool discardInside) {
    SWIGTYPE_p_std__pairT_bool_float_t ret = new SWIGTYPE_p_std__pairT_bool_float_t(OgrePINVOKE.Ray_intersects__SWIG_2(swigCPtr, Sphere.getCPtr(s), discardInside), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__pairT_bool_float_t intersects(Sphere s) {
    SWIGTYPE_p_std__pairT_bool_float_t ret = new SWIGTYPE_p_std__pairT_bool_float_t(OgrePINVOKE.Ray_intersects__SWIG_3(swigCPtr, Sphere.getCPtr(s)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__pairT_bool_float_t intersects(AxisAlignedBox box) {
    SWIGTYPE_p_std__pairT_bool_float_t ret = new SWIGTYPE_p_std__pairT_bool_float_t(OgrePINVOKE.Ray_intersects__SWIG_4(swigCPtr, AxisAlignedBox.getCPtr(box)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
