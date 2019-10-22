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

public class SkeletonInstance : Skeleton {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal SkeletonInstance(global::System.IntPtr cPtr, bool cMemoryOwn) : base(OgrePINVOKE.SkeletonInstance_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SkeletonInstance obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SkeletonInstance() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_SkeletonInstance(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public SkeletonInstance(SkeletonPtr masterCopy) : this(OgrePINVOKE.new_SkeletonInstance(SkeletonPtr.getCPtr(masterCopy)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ushort getNumAnimations() {
    ushort ret = OgrePINVOKE.SkeletonInstance_getNumAnimations(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Animation getAnimation(ushort index) {
    global::System.IntPtr cPtr = OgrePINVOKE.SkeletonInstance_getAnimation__SWIG_0(swigCPtr, index);
    Animation ret = (cPtr == global::System.IntPtr.Zero) ? null : new Animation(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override Animation _getAnimationImpl(string name, SWIGTYPE_p_p_Ogre__LinkedSkeletonAnimationSource linker) {
    global::System.IntPtr cPtr = OgrePINVOKE.SkeletonInstance__getAnimationImpl__SWIG_0(swigCPtr, name, SWIGTYPE_p_p_Ogre__LinkedSkeletonAnimationSource.getCPtr(linker));
    Animation ret = (cPtr == global::System.IntPtr.Zero) ? null : new Animation(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override Animation _getAnimationImpl(string name) {
    global::System.IntPtr cPtr = OgrePINVOKE.SkeletonInstance__getAnimationImpl__SWIG_1(swigCPtr, name);
    Animation ret = (cPtr == global::System.IntPtr.Zero) ? null : new Animation(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Animation createAnimation(string name, float length) {
    global::System.IntPtr cPtr = OgrePINVOKE.SkeletonInstance_createAnimation(swigCPtr, name, length);
    Animation ret = (cPtr == global::System.IntPtr.Zero) ? null : new Animation(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Animation getAnimation(string name, SWIGTYPE_p_p_Ogre__LinkedSkeletonAnimationSource linker) {
    global::System.IntPtr cPtr = OgrePINVOKE.SkeletonInstance_getAnimation__SWIG_1(swigCPtr, name, SWIGTYPE_p_p_Ogre__LinkedSkeletonAnimationSource.getCPtr(linker));
    Animation ret = (cPtr == global::System.IntPtr.Zero) ? null : new Animation(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Animation getAnimation(string name) {
    global::System.IntPtr cPtr = OgrePINVOKE.SkeletonInstance_getAnimation__SWIG_2(swigCPtr, name);
    Animation ret = (cPtr == global::System.IntPtr.Zero) ? null : new Animation(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void removeAnimation(string name) {
    OgrePINVOKE.SkeletonInstance_removeAnimation(swigCPtr, name);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_Ogre__TagPoint createTagPointOnBone(Bone bone, Quaternion offsetOrientation, Vector3 offsetPosition) {
    global::System.IntPtr cPtr = OgrePINVOKE.SkeletonInstance_createTagPointOnBone__SWIG_0(swigCPtr, Bone.getCPtr(bone), Quaternion.getCPtr(offsetOrientation), Vector3.getCPtr(offsetPosition));
    SWIGTYPE_p_Ogre__TagPoint ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Ogre__TagPoint(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Ogre__TagPoint createTagPointOnBone(Bone bone, Quaternion offsetOrientation) {
    global::System.IntPtr cPtr = OgrePINVOKE.SkeletonInstance_createTagPointOnBone__SWIG_1(swigCPtr, Bone.getCPtr(bone), Quaternion.getCPtr(offsetOrientation));
    SWIGTYPE_p_Ogre__TagPoint ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Ogre__TagPoint(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Ogre__TagPoint createTagPointOnBone(Bone bone) {
    global::System.IntPtr cPtr = OgrePINVOKE.SkeletonInstance_createTagPointOnBone__SWIG_2(swigCPtr, Bone.getCPtr(bone));
    SWIGTYPE_p_Ogre__TagPoint ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Ogre__TagPoint(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void freeTagPoint(SWIGTYPE_p_Ogre__TagPoint tagPoint) {
    OgrePINVOKE.SkeletonInstance_freeTagPoint(swigCPtr, SWIGTYPE_p_Ogre__TagPoint.getCPtr(tagPoint));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void addLinkedSkeletonAnimationSource(string skelName, float scale) {
    OgrePINVOKE.SkeletonInstance_addLinkedSkeletonAnimationSource__SWIG_0(swigCPtr, skelName, scale);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void addLinkedSkeletonAnimationSource(string skelName) {
    OgrePINVOKE.SkeletonInstance_addLinkedSkeletonAnimationSource__SWIG_1(swigCPtr, skelName);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void removeAllLinkedSkeletonAnimationSources() {
    OgrePINVOKE.SkeletonInstance_removeAllLinkedSkeletonAnimationSources(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public override SWIGTYPE_p_Ogre__ConstVectorIteratorT_std__vectorT_Ogre__LinkedSkeletonAnimationSource_t_t getLinkedSkeletonAnimationSourceIterator() {
    SWIGTYPE_p_Ogre__ConstVectorIteratorT_std__vectorT_Ogre__LinkedSkeletonAnimationSource_t_t ret = new SWIGTYPE_p_Ogre__ConstVectorIteratorT_std__vectorT_Ogre__LinkedSkeletonAnimationSource_t_t(OgrePINVOKE.SkeletonInstance_getLinkedSkeletonAnimationSourceIterator(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void _initAnimationState(AnimationStateSet animSet) {
    OgrePINVOKE.SkeletonInstance__initAnimationState(swigCPtr, AnimationStateSet.getCPtr(animSet));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void _refreshAnimationState(AnimationStateSet animSet) {
    OgrePINVOKE.SkeletonInstance__refreshAnimationState(swigCPtr, AnimationStateSet.getCPtr(animSet));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public override string getName() {
    string ret = OgrePINVOKE.SkeletonInstance_getName(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ulong getHandle() {
    ulong ret = OgrePINVOKE.SkeletonInstance_getHandle(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override string getGroup() {
    string ret = OgrePINVOKE.SkeletonInstance_getGroup(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
