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

public class Vector2 : VectorBase2 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal Vector2(global::System.IntPtr cPtr, bool cMemoryOwn) : base(OgrePINVOKE.Vector2_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Vector2 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Vector2() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_Vector2(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public Vector2() : this(OgrePINVOKE.new_Vector2__SWIG_0(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector2(float _x, float _y) : this(OgrePINVOKE.new_Vector2__SWIG_1(_x, _y), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector2(float s) : this(OgrePINVOKE.new_Vector2__SWIG_2(s), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public float __getitem__(uint i) {
    float ret = OgrePINVOKE.Vector2___getitem____SWIG_0(swigCPtr, i);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool positionEquals(Vector2 rhs, float tolerance) {
    bool ret = OgrePINVOKE.Vector2_positionEquals__SWIG_0(swigCPtr, Vector2.getCPtr(rhs), tolerance);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool positionEquals(Vector2 rhs) {
    bool ret = OgrePINVOKE.Vector2_positionEquals__SWIG_1(swigCPtr, Vector2.getCPtr(rhs));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void makeFloor(Vector2 cmp) {
    OgrePINVOKE.Vector2_makeFloor(swigCPtr, Vector2.getCPtr(cmp));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void makeCeil(Vector2 cmp) {
    OgrePINVOKE.Vector2_makeCeil(swigCPtr, Vector2.getCPtr(cmp));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public float dotProduct(VectorBase2 vec) {
    float ret = OgrePINVOKE.Vector2_dotProduct(swigCPtr, VectorBase2.getCPtr(vec));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float squaredLength() {
    float ret = OgrePINVOKE.Vector2_squaredLength(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isZeroLength() {
    bool ret = OgrePINVOKE.Vector2_isZeroLength(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float length() {
    float ret = OgrePINVOKE.Vector2_length(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float distance(Vector2 rhs) {
    float ret = OgrePINVOKE.Vector2_distance(swigCPtr, Vector2.getCPtr(rhs));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float squaredDistance(Vector2 rhs) {
    float ret = OgrePINVOKE.Vector2_squaredDistance(swigCPtr, Vector2.getCPtr(rhs));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float normalise() {
    float ret = OgrePINVOKE.Vector2_normalise(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector2 normalisedCopy() {
    Vector2 ret = new Vector2(OgrePINVOKE.Vector2_normalisedCopy(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isNaN() {
    bool ret = OgrePINVOKE.Vector2_isNaN(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Radian angleBetween(Vector2 dest) {
    Radian ret = new Radian(OgrePINVOKE.Vector2_angleBetween(swigCPtr, Vector2.getCPtr(dest)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector2 reflect(Vector2 normal) {
    Vector2 ret = new Vector2(OgrePINVOKE.Vector2_reflect(swigCPtr, Vector2.getCPtr(normal)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override string ToString() {
    string ret = OgrePINVOKE.Vector2_ToString(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
