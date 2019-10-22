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

public class Bone : Node {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal Bone(global::System.IntPtr cPtr, bool cMemoryOwn) : base(OgrePINVOKE.Bone_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Bone obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Bone() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_Bone(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public Bone(ushort handle, Skeleton creator) : this(OgrePINVOKE.new_Bone__SWIG_0(handle, Skeleton.getCPtr(creator)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Bone(string name, ushort handle, Skeleton creator) : this(OgrePINVOKE.new_Bone__SWIG_1(name, handle, Skeleton.getCPtr(creator)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Bone createChild(ushort handle, Vector3 translate, Quaternion rotate) {
    global::System.IntPtr cPtr = OgrePINVOKE.Bone_createChild__SWIG_0(swigCPtr, handle, Vector3.getCPtr(translate), Quaternion.getCPtr(rotate));
    Bone ret = (cPtr == global::System.IntPtr.Zero) ? null : new Bone(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Bone createChild(ushort handle, Vector3 translate) {
    global::System.IntPtr cPtr = OgrePINVOKE.Bone_createChild__SWIG_1(swigCPtr, handle, Vector3.getCPtr(translate));
    Bone ret = (cPtr == global::System.IntPtr.Zero) ? null : new Bone(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Bone createChild(ushort handle) {
    global::System.IntPtr cPtr = OgrePINVOKE.Bone_createChild__SWIG_2(swigCPtr, handle);
    Bone ret = (cPtr == global::System.IntPtr.Zero) ? null : new Bone(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ushort getHandle() {
    ushort ret = OgrePINVOKE.Bone_getHandle(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setBindingPose() {
    OgrePINVOKE.Bone_setBindingPose(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void reset() {
    OgrePINVOKE.Bone_reset(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setManuallyControlled(bool manuallyControlled) {
    OgrePINVOKE.Bone_setManuallyControlled(swigCPtr, manuallyControlled);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isManuallyControlled() {
    bool ret = OgrePINVOKE.Bone_isManuallyControlled(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _getOffsetTransform(Affine3 m) {
    OgrePINVOKE.Bone__getOffsetTransform(swigCPtr, Affine3.getCPtr(m));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector3 _getBindingPoseInverseScale() {
    Vector3 ret = new Vector3(OgrePINVOKE.Bone__getBindingPoseInverseScale(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector3 _getBindingPoseInversePosition() {
    Vector3 ret = new Vector3(OgrePINVOKE.Bone__getBindingPoseInversePosition(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Quaternion _getBindingPoseInverseOrientation() {
    Quaternion ret = new Quaternion(OgrePINVOKE.Bone__getBindingPoseInverseOrientation(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void needUpdate(bool forceParentUpdate) {
    OgrePINVOKE.Bone_needUpdate__SWIG_0(swigCPtr, forceParentUpdate);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void needUpdate() {
    OgrePINVOKE.Bone_needUpdate__SWIG_1(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
