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

public class TransformBaseReal : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TransformBaseReal(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TransformBaseReal obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TransformBaseReal() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_TransformBaseReal(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public void makeTrans(Vector3 v) {
    OgrePINVOKE.TransformBaseReal_makeTrans__SWIG_0(swigCPtr, Vector3.getCPtr(v));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void makeTrans(float tx, float ty, float tz) {
    OgrePINVOKE.TransformBaseReal_makeTrans__SWIG_1(swigCPtr, tx, ty, tz);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set3x3Matrix(Matrix3 mat3) {
    OgrePINVOKE.TransformBaseReal_set3x3Matrix(swigCPtr, Matrix3.getCPtr(mat3));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Matrix3 linear() {
    Matrix3 ret = new Matrix3(OgrePINVOKE.TransformBaseReal_linear(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void extract3x3Matrix(Matrix3 m3x3) {
    OgrePINVOKE.TransformBaseReal_extract3x3Matrix(swigCPtr, Matrix3.getCPtr(m3x3));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Quaternion extractQuaternion() {
    Quaternion ret = new Quaternion(OgrePINVOKE.TransformBaseReal_extractQuaternion(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float determinant() {
    float ret = OgrePINVOKE.TransformBaseReal_determinant(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Matrix4 transpose() {
    Matrix4 ret = new Matrix4(OgrePINVOKE.TransformBaseReal_transpose(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void makeTransform(Vector3 position, Vector3 scale, Quaternion orientation) {
    OgrePINVOKE.TransformBaseReal_makeTransform(swigCPtr, Vector3.getCPtr(position), Vector3.getCPtr(scale), Quaternion.getCPtr(orientation));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void makeInverseTransform(Vector3 position, Vector3 scale, Quaternion orientation) {
    OgrePINVOKE.TransformBaseReal_makeInverseTransform(swigCPtr, Vector3.getCPtr(position), Vector3.getCPtr(scale), Quaternion.getCPtr(orientation));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public TransformBaseReal() : this(OgrePINVOKE.new_TransformBaseReal(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}