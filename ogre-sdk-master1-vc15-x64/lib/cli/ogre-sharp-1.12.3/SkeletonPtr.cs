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

public class SkeletonPtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SkeletonPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SkeletonPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SkeletonPtr() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_SkeletonPtr(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SkeletonPtr(SWIGTYPE_p_std__nullptr_t arg0) : this(OgrePINVOKE.new_SkeletonPtr__SWIG_0(SWIGTYPE_p_std__nullptr_t.getCPtr(arg0)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public SkeletonPtr() : this(OgrePINVOKE.new_SkeletonPtr__SWIG_1(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public SkeletonPtr(SkeletonPtr r) : this(OgrePINVOKE.new_SkeletonPtr__SWIG_2(SkeletonPtr.getCPtr(r)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Skeleton __deref__() {
    global::System.IntPtr cPtr = OgrePINVOKE.SkeletonPtr___deref__(swigCPtr);
    Skeleton ret = (cPtr == global::System.IntPtr.Zero) ? null : new Skeleton(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Bone createBone() {
    global::System.IntPtr cPtr = OgrePINVOKE.SkeletonPtr_createBone__SWIG_0(swigCPtr);
    Bone ret = (cPtr == global::System.IntPtr.Zero) ? null : new Bone(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Bone createBone(ushort handle) {
    global::System.IntPtr cPtr = OgrePINVOKE.SkeletonPtr_createBone__SWIG_1(swigCPtr, handle);
    Bone ret = (cPtr == global::System.IntPtr.Zero) ? null : new Bone(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Bone createBone(string name) {
    global::System.IntPtr cPtr = OgrePINVOKE.SkeletonPtr_createBone__SWIG_2(swigCPtr, name);
    Bone ret = (cPtr == global::System.IntPtr.Zero) ? null : new Bone(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Bone createBone(string name, ushort handle) {
    global::System.IntPtr cPtr = OgrePINVOKE.SkeletonPtr_createBone__SWIG_3(swigCPtr, name, handle);
    Bone ret = (cPtr == global::System.IntPtr.Zero) ? null : new Bone(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ushort getNumBones() {
    ushort ret = OgrePINVOKE.SkeletonPtr_getNumBones(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BoneList getRootBones() {
    BoneList ret = new BoneList(OgrePINVOKE.SkeletonPtr_getRootBones(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BoneList getBones() {
    BoneList ret = new BoneList(OgrePINVOKE.SkeletonPtr_getBones(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Bone getBone(ushort handle) {
    global::System.IntPtr cPtr = OgrePINVOKE.SkeletonPtr_getBone__SWIG_0(swigCPtr, handle);
    Bone ret = (cPtr == global::System.IntPtr.Zero) ? null : new Bone(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Bone getBone(string name) {
    global::System.IntPtr cPtr = OgrePINVOKE.SkeletonPtr_getBone__SWIG_1(swigCPtr, name);
    Bone ret = (cPtr == global::System.IntPtr.Zero) ? null : new Bone(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool hasBone(string name) {
    bool ret = OgrePINVOKE.SkeletonPtr_hasBone(swigCPtr, name);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setBindingPose() {
    OgrePINVOKE.SkeletonPtr_setBindingPose(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void reset(bool resetManualBones) {
    OgrePINVOKE.SkeletonPtr_reset__SWIG_0(swigCPtr, resetManualBones);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void reset() {
    OgrePINVOKE.SkeletonPtr_reset__SWIG_1(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Animation createAnimation(string name, float length) {
    global::System.IntPtr cPtr = OgrePINVOKE.SkeletonPtr_createAnimation(swigCPtr, name, length);
    Animation ret = (cPtr == global::System.IntPtr.Zero) ? null : new Animation(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Animation getAnimation(string name, SWIGTYPE_p_p_Ogre__LinkedSkeletonAnimationSource linker) {
    global::System.IntPtr cPtr = OgrePINVOKE.SkeletonPtr_getAnimation__SWIG_0(swigCPtr, name, SWIGTYPE_p_p_Ogre__LinkedSkeletonAnimationSource.getCPtr(linker));
    Animation ret = (cPtr == global::System.IntPtr.Zero) ? null : new Animation(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Animation getAnimation(string name) {
    global::System.IntPtr cPtr = OgrePINVOKE.SkeletonPtr_getAnimation__SWIG_1(swigCPtr, name);
    Animation ret = (cPtr == global::System.IntPtr.Zero) ? null : new Animation(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Animation getAnimation(ushort index) {
    global::System.IntPtr cPtr = OgrePINVOKE.SkeletonPtr_getAnimation__SWIG_2(swigCPtr, index);
    Animation ret = (cPtr == global::System.IntPtr.Zero) ? null : new Animation(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Animation _getAnimationImpl(string name, SWIGTYPE_p_p_Ogre__LinkedSkeletonAnimationSource linker) {
    global::System.IntPtr cPtr = OgrePINVOKE.SkeletonPtr__getAnimationImpl__SWIG_0(swigCPtr, name, SWIGTYPE_p_p_Ogre__LinkedSkeletonAnimationSource.getCPtr(linker));
    Animation ret = (cPtr == global::System.IntPtr.Zero) ? null : new Animation(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Animation _getAnimationImpl(string name) {
    global::System.IntPtr cPtr = OgrePINVOKE.SkeletonPtr__getAnimationImpl__SWIG_1(swigCPtr, name);
    Animation ret = (cPtr == global::System.IntPtr.Zero) ? null : new Animation(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool hasAnimation(string name) {
    bool ret = OgrePINVOKE.SkeletonPtr_hasAnimation(swigCPtr, name);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void removeAnimation(string name) {
    OgrePINVOKE.SkeletonPtr_removeAnimation(swigCPtr, name);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setAnimationState(AnimationStateSet animSet) {
    OgrePINVOKE.SkeletonPtr_setAnimationState(swigCPtr, AnimationStateSet.getCPtr(animSet));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _initAnimationState(AnimationStateSet animSet) {
    OgrePINVOKE.SkeletonPtr__initAnimationState(swigCPtr, AnimationStateSet.getCPtr(animSet));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _refreshAnimationState(AnimationStateSet animSet) {
    OgrePINVOKE.SkeletonPtr__refreshAnimationState(swigCPtr, AnimationStateSet.getCPtr(animSet));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _getBoneMatrices(Affine3 pMatrices) {
    OgrePINVOKE.SkeletonPtr__getBoneMatrices(swigCPtr, Affine3.getCPtr(pMatrices));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ushort getNumAnimations() {
    ushort ret = OgrePINVOKE.SkeletonPtr_getNumAnimations(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SkeletonAnimationBlendMode getBlendMode() {
    SkeletonAnimationBlendMode ret = (SkeletonAnimationBlendMode)OgrePINVOKE.SkeletonPtr_getBlendMode(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setBlendMode(SkeletonAnimationBlendMode state) {
    OgrePINVOKE.SkeletonPtr_setBlendMode(swigCPtr, (int)state);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _updateTransforms() {
    OgrePINVOKE.SkeletonPtr__updateTransforms(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void optimiseAllAnimations(bool preservingIdentityNodeTracks) {
    OgrePINVOKE.SkeletonPtr_optimiseAllAnimations__SWIG_0(swigCPtr, preservingIdentityNodeTracks);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void optimiseAllAnimations() {
    OgrePINVOKE.SkeletonPtr_optimiseAllAnimations__SWIG_1(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addLinkedSkeletonAnimationSource(string skelName, float scale) {
    OgrePINVOKE.SkeletonPtr_addLinkedSkeletonAnimationSource__SWIG_0(swigCPtr, skelName, scale);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addLinkedSkeletonAnimationSource(string skelName) {
    OgrePINVOKE.SkeletonPtr_addLinkedSkeletonAnimationSource__SWIG_1(swigCPtr, skelName);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeAllLinkedSkeletonAnimationSources() {
    OgrePINVOKE.SkeletonPtr_removeAllLinkedSkeletonAnimationSources(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_Ogre__ConstVectorIteratorT_std__vectorT_Ogre__LinkedSkeletonAnimationSource_t_t getLinkedSkeletonAnimationSourceIterator() {
    SWIGTYPE_p_Ogre__ConstVectorIteratorT_std__vectorT_Ogre__LinkedSkeletonAnimationSource_t_t ret = new SWIGTYPE_p_Ogre__ConstVectorIteratorT_std__vectorT_Ogre__LinkedSkeletonAnimationSource_t_t(OgrePINVOKE.SkeletonPtr_getLinkedSkeletonAnimationSourceIterator(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _notifyManualBonesDirty() {
    OgrePINVOKE.SkeletonPtr__notifyManualBonesDirty(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _notifyManualBoneStateChange(Bone bone) {
    OgrePINVOKE.SkeletonPtr__notifyManualBoneStateChange(swigCPtr, Bone.getCPtr(bone));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getManualBonesDirty() {
    bool ret = OgrePINVOKE.SkeletonPtr_getManualBonesDirty(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool hasManualBones() {
    bool ret = OgrePINVOKE.SkeletonPtr_hasManualBones(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _mergeSkeletonAnimations(Skeleton source, SWIGTYPE_p_std__vectorT_unsigned_short_t boneHandleMap, StringVector animations) {
    OgrePINVOKE.SkeletonPtr__mergeSkeletonAnimations__SWIG_0(swigCPtr, Skeleton.getCPtr(source), SWIGTYPE_p_std__vectorT_unsigned_short_t.getCPtr(boneHandleMap), StringVector.getCPtr(animations));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _mergeSkeletonAnimations(Skeleton source, SWIGTYPE_p_std__vectorT_unsigned_short_t boneHandleMap) {
    OgrePINVOKE.SkeletonPtr__mergeSkeletonAnimations__SWIG_1(swigCPtr, Skeleton.getCPtr(source), SWIGTYPE_p_std__vectorT_unsigned_short_t.getCPtr(boneHandleMap));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _buildMapBoneByHandle(Skeleton source, SWIGTYPE_p_std__vectorT_unsigned_short_t boneHandleMap) {
    OgrePINVOKE.SkeletonPtr__buildMapBoneByHandle(swigCPtr, Skeleton.getCPtr(source), SWIGTYPE_p_std__vectorT_unsigned_short_t.getCPtr(boneHandleMap));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _buildMapBoneByName(Skeleton source, SWIGTYPE_p_std__vectorT_unsigned_short_t boneHandleMap) {
    OgrePINVOKE.SkeletonPtr__buildMapBoneByName(swigCPtr, Skeleton.getCPtr(source), SWIGTYPE_p_std__vectorT_unsigned_short_t.getCPtr(boneHandleMap));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void prepare(bool backgroundThread) {
    OgrePINVOKE.SkeletonPtr_prepare__SWIG_0(swigCPtr, backgroundThread);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void prepare() {
    OgrePINVOKE.SkeletonPtr_prepare__SWIG_1(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void load(bool backgroundThread) {
    OgrePINVOKE.SkeletonPtr_load__SWIG_0(swigCPtr, backgroundThread);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void load() {
    OgrePINVOKE.SkeletonPtr_load__SWIG_1(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void reload(Resource.LoadingFlags flags) {
    OgrePINVOKE.SkeletonPtr_reload__SWIG_0(swigCPtr, (int)flags);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void reload() {
    OgrePINVOKE.SkeletonPtr_reload__SWIG_1(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isReloadable() {
    bool ret = OgrePINVOKE.SkeletonPtr_isReloadable(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isManuallyLoaded() {
    bool ret = OgrePINVOKE.SkeletonPtr_isManuallyLoaded(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void unload() {
    OgrePINVOKE.SkeletonPtr_unload(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getSize() {
    uint ret = OgrePINVOKE.SkeletonPtr_getSize(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void touch() {
    OgrePINVOKE.SkeletonPtr_touch(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getName() {
    string ret = OgrePINVOKE.SkeletonPtr_getName(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ulong getHandle() {
    ulong ret = OgrePINVOKE.SkeletonPtr_getHandle(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isPrepared() {
    bool ret = OgrePINVOKE.SkeletonPtr_isPrepared(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isLoaded() {
    bool ret = OgrePINVOKE.SkeletonPtr_isLoaded(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isLoading() {
    bool ret = OgrePINVOKE.SkeletonPtr_isLoading(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Resource.LoadingState getLoadingState() {
    Resource.LoadingState ret = (Resource.LoadingState)OgrePINVOKE.SkeletonPtr_getLoadingState(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isBackgroundLoaded() {
    bool ret = OgrePINVOKE.SkeletonPtr_isBackgroundLoaded(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setBackgroundLoaded(bool bl) {
    OgrePINVOKE.SkeletonPtr_setBackgroundLoaded(swigCPtr, bl);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void escalateLoading() {
    OgrePINVOKE.SkeletonPtr_escalateLoading(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addListener(Resource.Listener lis) {
    OgrePINVOKE.SkeletonPtr_addListener(swigCPtr, Resource.Listener.getCPtr(lis));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeListener(Resource.Listener lis) {
    OgrePINVOKE.SkeletonPtr_removeListener(swigCPtr, Resource.Listener.getCPtr(lis));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getGroup() {
    string ret = OgrePINVOKE.SkeletonPtr_getGroup(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void changeGroupOwnership(string newGroup) {
    OgrePINVOKE.SkeletonPtr_changeGroupOwnership(swigCPtr, newGroup);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ResourceManager getCreator() {
    global::System.IntPtr cPtr = OgrePINVOKE.SkeletonPtr_getCreator(swigCPtr);
    ResourceManager ret = (cPtr == global::System.IntPtr.Zero) ? null : new ResourceManager(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getOrigin() {
    string ret = OgrePINVOKE.SkeletonPtr_getOrigin(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _notifyOrigin(string origin) {
    OgrePINVOKE.SkeletonPtr__notifyOrigin(swigCPtr, origin);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getStateCount() {
    uint ret = OgrePINVOKE.SkeletonPtr_getStateCount(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _dirtyState() {
    OgrePINVOKE.SkeletonPtr__dirtyState(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _fireLoadingComplete(bool wasBackgroundLoaded) {
    OgrePINVOKE.SkeletonPtr__fireLoadingComplete(swigCPtr, wasBackgroundLoaded);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _firePreparingComplete(bool wasBackgroundLoaded) {
    OgrePINVOKE.SkeletonPtr__firePreparingComplete(swigCPtr, wasBackgroundLoaded);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _fireUnloadingComplete() {
    OgrePINVOKE.SkeletonPtr__fireUnloadingComplete(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ParamDictionary getParamDictionary() {
    global::System.IntPtr cPtr = OgrePINVOKE.SkeletonPtr_getParamDictionary__SWIG_0(swigCPtr);
    ParamDictionary ret = (cPtr == global::System.IntPtr.Zero) ? null : new ParamDictionary(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_Ogre__ParameterDef_t getParameters() {
    SWIGTYPE_p_std__vectorT_Ogre__ParameterDef_t ret = new SWIGTYPE_p_std__vectorT_Ogre__ParameterDef_t(OgrePINVOKE.SkeletonPtr_getParameters(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool setParameter(string name, string value) {
    bool ret = OgrePINVOKE.SkeletonPtr_setParameter(swigCPtr, name, value);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setParameterList(NameValuePairList paramList) {
    OgrePINVOKE.SkeletonPtr_setParameterList(swigCPtr, NameValuePairList.getCPtr(paramList));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getParameter(string name) {
    string ret = OgrePINVOKE.SkeletonPtr_getParameter(swigCPtr, name);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void copyParametersTo(StringInterface dest) {
    OgrePINVOKE.SkeletonPtr_copyParametersTo(swigCPtr, StringInterface.getCPtr(dest));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void cleanupDictionary() {
    OgrePINVOKE.SkeletonPtr_cleanupDictionary(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}