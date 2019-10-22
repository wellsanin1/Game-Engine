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

public class AnimationTrack : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal AnimationTrack(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AnimationTrack obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~AnimationTrack() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_AnimationTrack(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public class Listener : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal Listener(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Listener obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~Listener() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            OgrePINVOKE.delete_AnimationTrack_Listener(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public virtual bool getInterpolatedKeyFrame(AnimationTrack t, TimeIndex timeIndex, KeyFrame kf) {
      bool ret = OgrePINVOKE.AnimationTrack_Listener_getInterpolatedKeyFrame(swigCPtr, AnimationTrack.getCPtr(t), TimeIndex.getCPtr(timeIndex), KeyFrame.getCPtr(kf));
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public Listener() : this(OgrePINVOKE.new_AnimationTrack_Listener(), true) {
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      SwigDirectorConnect();
    }
  
    private void SwigDirectorConnect() {
      if (SwigDerivedClassHasMethod("getInterpolatedKeyFrame", swigMethodTypes0))
        swigDelegate0 = new SwigDelegateListener_0(SwigDirectorgetInterpolatedKeyFrame);
      OgrePINVOKE.AnimationTrack_Listener_director_connect(swigCPtr, swigDelegate0);
    }
  
    private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
      global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
      bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(Listener));
      return hasDerivedMethod;
    }
  
    private bool SwigDirectorgetInterpolatedKeyFrame(global::System.IntPtr t, global::System.IntPtr timeIndex, global::System.IntPtr kf) {
      return getInterpolatedKeyFrame((t == global::System.IntPtr.Zero) ? null : new AnimationTrack(t, false), new TimeIndex(timeIndex, false), (kf == global::System.IntPtr.Zero) ? null : new KeyFrame(kf, false));
    }
  
    public delegate bool SwigDelegateListener_0(global::System.IntPtr t, global::System.IntPtr timeIndex, global::System.IntPtr kf);
  
    private SwigDelegateListener_0 swigDelegate0;
  
    private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(AnimationTrack), typeof(TimeIndex), typeof(KeyFrame) };
  }

  public ushort getHandle() {
    ushort ret = OgrePINVOKE.AnimationTrack_getHandle(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ushort getNumKeyFrames() {
    ushort ret = OgrePINVOKE.AnimationTrack_getNumKeyFrames(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual KeyFrame getKeyFrame(ushort index) {
    global::System.IntPtr cPtr = OgrePINVOKE.AnimationTrack_getKeyFrame(swigCPtr, index);
    KeyFrame ret = (cPtr == global::System.IntPtr.Zero) ? null : new KeyFrame(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual float getKeyFramesAtTime(TimeIndex timeIndex, SWIGTYPE_p_p_Ogre__KeyFrame keyFrame1, SWIGTYPE_p_p_Ogre__KeyFrame keyFrame2, SWIGTYPE_p_unsigned_short firstKeyIndex) {
    float ret = OgrePINVOKE.AnimationTrack_getKeyFramesAtTime__SWIG_0(swigCPtr, TimeIndex.getCPtr(timeIndex), SWIGTYPE_p_p_Ogre__KeyFrame.getCPtr(keyFrame1), SWIGTYPE_p_p_Ogre__KeyFrame.getCPtr(keyFrame2), SWIGTYPE_p_unsigned_short.getCPtr(firstKeyIndex));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual float getKeyFramesAtTime(TimeIndex timeIndex, SWIGTYPE_p_p_Ogre__KeyFrame keyFrame1, SWIGTYPE_p_p_Ogre__KeyFrame keyFrame2) {
    float ret = OgrePINVOKE.AnimationTrack_getKeyFramesAtTime__SWIG_1(swigCPtr, TimeIndex.getCPtr(timeIndex), SWIGTYPE_p_p_Ogre__KeyFrame.getCPtr(keyFrame1), SWIGTYPE_p_p_Ogre__KeyFrame.getCPtr(keyFrame2));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual KeyFrame createKeyFrame(float timePos) {
    global::System.IntPtr cPtr = OgrePINVOKE.AnimationTrack_createKeyFrame(swigCPtr, timePos);
    KeyFrame ret = (cPtr == global::System.IntPtr.Zero) ? null : new KeyFrame(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void removeKeyFrame(ushort index) {
    OgrePINVOKE.AnimationTrack_removeKeyFrame(swigCPtr, index);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void removeAllKeyFrames() {
    OgrePINVOKE.AnimationTrack_removeAllKeyFrames(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void getInterpolatedKeyFrame(TimeIndex timeIndex, KeyFrame kf) {
    OgrePINVOKE.AnimationTrack_getInterpolatedKeyFrame(swigCPtr, TimeIndex.getCPtr(timeIndex), KeyFrame.getCPtr(kf));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void apply(TimeIndex timeIndex, float weight, float scale) {
    OgrePINVOKE.AnimationTrack_apply__SWIG_0(swigCPtr, TimeIndex.getCPtr(timeIndex), weight, scale);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void apply(TimeIndex timeIndex, float weight) {
    OgrePINVOKE.AnimationTrack_apply__SWIG_1(swigCPtr, TimeIndex.getCPtr(timeIndex), weight);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void apply(TimeIndex timeIndex) {
    OgrePINVOKE.AnimationTrack_apply__SWIG_2(swigCPtr, TimeIndex.getCPtr(timeIndex));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void _keyFrameDataChanged() {
    OgrePINVOKE.AnimationTrack__keyFrameDataChanged(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool hasNonZeroKeyFrames() {
    bool ret = OgrePINVOKE.AnimationTrack_hasNonZeroKeyFrames(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void optimise() {
    OgrePINVOKE.AnimationTrack_optimise(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void _collectKeyFrameTimes(SWIGTYPE_p_std__vectorT_float_t keyFrameTimes) {
    OgrePINVOKE.AnimationTrack__collectKeyFrameTimes(swigCPtr, SWIGTYPE_p_std__vectorT_float_t.getCPtr(keyFrameTimes));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void _buildKeyFrameIndexMap(SWIGTYPE_p_std__vectorT_float_t keyFrameTimes) {
    OgrePINVOKE.AnimationTrack__buildKeyFrameIndexMap(swigCPtr, SWIGTYPE_p_std__vectorT_float_t.getCPtr(keyFrameTimes));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void _applyBaseKeyFrame(KeyFrame arg0) {
    OgrePINVOKE.AnimationTrack__applyBaseKeyFrame(swigCPtr, KeyFrame.getCPtr(arg0));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setListener(AnimationTrack.Listener l) {
    OgrePINVOKE.AnimationTrack_setListener(swigCPtr, AnimationTrack.Listener.getCPtr(l));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Animation getParent() {
    global::System.IntPtr cPtr = OgrePINVOKE.AnimationTrack_getParent(swigCPtr);
    Animation ret = (cPtr == global::System.IntPtr.Zero) ? null : new Animation(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
