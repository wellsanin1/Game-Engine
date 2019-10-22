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

public class ParticleSystem : StringInterface {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal ParticleSystem(global::System.IntPtr cPtr, bool cMemoryOwn) : base(OgrePINVOKE.ParticleSystem_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ParticleSystem obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ParticleSystem() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_ParticleSystem(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public ParticleSystem() : this(OgrePINVOKE.new_ParticleSystem__SWIG_0(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ParticleSystem(string name, string resourceGroupName) : this(OgrePINVOKE.new_ParticleSystem__SWIG_1(name, resourceGroupName), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setRenderer(string typeName) {
    OgrePINVOKE.ParticleSystem_setRenderer(swigCPtr, typeName);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_Ogre__ParticleSystemRenderer getRenderer() {
    global::System.IntPtr cPtr = OgrePINVOKE.ParticleSystem_getRenderer(swigCPtr);
    SWIGTYPE_p_Ogre__ParticleSystemRenderer ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Ogre__ParticleSystemRenderer(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getRendererName() {
    string ret = OgrePINVOKE.ParticleSystem_getRendererName(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ParticleEmitter addEmitter(string emitterType) {
    global::System.IntPtr cPtr = OgrePINVOKE.ParticleSystem_addEmitter(swigCPtr, emitterType);
    ParticleEmitter ret = (cPtr == global::System.IntPtr.Zero) ? null : new ParticleEmitter(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ParticleEmitter getEmitter(ushort index) {
    global::System.IntPtr cPtr = OgrePINVOKE.ParticleSystem_getEmitter(swigCPtr, index);
    ParticleEmitter ret = (cPtr == global::System.IntPtr.Zero) ? null : new ParticleEmitter(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ushort getNumEmitters() {
    ushort ret = OgrePINVOKE.ParticleSystem_getNumEmitters(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void removeEmitter(ushort index) {
    OgrePINVOKE.ParticleSystem_removeEmitter__SWIG_0(swigCPtr, index);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeAllEmitters() {
    OgrePINVOKE.ParticleSystem_removeAllEmitters(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeEmitter(ParticleEmitter emitter) {
    OgrePINVOKE.ParticleSystem_removeEmitter__SWIG_1(swigCPtr, ParticleEmitter.getCPtr(emitter));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ParticleAffector addAffector(string affectorType) {
    global::System.IntPtr cPtr = OgrePINVOKE.ParticleSystem_addAffector(swigCPtr, affectorType);
    ParticleAffector ret = (cPtr == global::System.IntPtr.Zero) ? null : new ParticleAffector(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ParticleAffector getAffector(ushort index) {
    global::System.IntPtr cPtr = OgrePINVOKE.ParticleSystem_getAffector(swigCPtr, index);
    ParticleAffector ret = (cPtr == global::System.IntPtr.Zero) ? null : new ParticleAffector(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ushort getNumAffectors() {
    ushort ret = OgrePINVOKE.ParticleSystem_getNumAffectors(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void removeAffector(ushort index) {
    OgrePINVOKE.ParticleSystem_removeAffector(swigCPtr, index);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeAllAffectors() {
    OgrePINVOKE.ParticleSystem_removeAllAffectors(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void clear() {
    OgrePINVOKE.ParticleSystem_clear(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getNumParticles() {
    uint ret = OgrePINVOKE.ParticleSystem_getNumParticles(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Particle createParticle() {
    global::System.IntPtr cPtr = OgrePINVOKE.ParticleSystem_createParticle(swigCPtr);
    Particle ret = (cPtr == global::System.IntPtr.Zero) ? null : new Particle(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Particle createEmitterParticle(string emitterName) {
    global::System.IntPtr cPtr = OgrePINVOKE.ParticleSystem_createEmitterParticle(swigCPtr, emitterName);
    Particle ret = (cPtr == global::System.IntPtr.Zero) ? null : new Particle(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Particle getParticle(uint index) {
    global::System.IntPtr cPtr = OgrePINVOKE.ParticleSystem_getParticle(swigCPtr, index);
    Particle ret = (cPtr == global::System.IntPtr.Zero) ? null : new Particle(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getParticleQuota() {
    uint ret = OgrePINVOKE.ParticleSystem_getParticleQuota(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setParticleQuota(uint quota) {
    OgrePINVOKE.ParticleSystem_setParticleQuota(swigCPtr, quota);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getEmittedEmitterQuota() {
    uint ret = OgrePINVOKE.ParticleSystem_getEmittedEmitterQuota(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setEmittedEmitterQuota(uint quota) {
    OgrePINVOKE.ParticleSystem_setEmittedEmitterQuota(swigCPtr, quota);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _update(float timeElapsed) {
    OgrePINVOKE.ParticleSystem__update(swigCPtr, timeElapsed);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ParticleIterator _getIterator() {
    ParticleIterator ret = new ParticleIterator(OgrePINVOKE.ParticleSystem__getIterator(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void setMaterialName(string name, string groupName) {
    OgrePINVOKE.ParticleSystem_setMaterialName__SWIG_0(swigCPtr, name, groupName);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setMaterialName(string name) {
    OgrePINVOKE.ParticleSystem_setMaterialName__SWIG_1(swigCPtr, name);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual string getMaterialName() {
    string ret = OgrePINVOKE.ParticleSystem_getMaterialName(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _notifyCurrentCamera(Camera cam) {
    OgrePINVOKE.ParticleSystem__notifyCurrentCamera(swigCPtr, Camera.getCPtr(cam));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _notifyAttached(Node parent, bool isTagPoint) {
    OgrePINVOKE.ParticleSystem__notifyAttached__SWIG_0(swigCPtr, Node.getCPtr(parent), isTagPoint);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _notifyAttached(Node parent) {
    OgrePINVOKE.ParticleSystem__notifyAttached__SWIG_1(swigCPtr, Node.getCPtr(parent));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public AxisAlignedBox getBoundingBox() {
    AxisAlignedBox ret = new AxisAlignedBox(OgrePINVOKE.ParticleSystem_getBoundingBox(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getBoundingRadius() {
    float ret = OgrePINVOKE.ParticleSystem_getBoundingRadius(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _updateRenderQueue(RenderQueue queue) {
    OgrePINVOKE.ParticleSystem__updateRenderQueue(swigCPtr, RenderQueue.getCPtr(queue));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void visitRenderables(Renderable.Visitor visitor, bool debugRenderables) {
    OgrePINVOKE.ParticleSystem_visitRenderables__SWIG_0(swigCPtr, Renderable.Visitor.getCPtr(visitor), debugRenderables);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void visitRenderables(Renderable.Visitor visitor) {
    OgrePINVOKE.ParticleSystem_visitRenderables__SWIG_1(swigCPtr, Renderable.Visitor.getCPtr(visitor));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void fastForward(float time, float interval) {
    OgrePINVOKE.ParticleSystem_fastForward__SWIG_0(swigCPtr, time, interval);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void fastForward(float time) {
    OgrePINVOKE.ParticleSystem_fastForward__SWIG_1(swigCPtr, time);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSpeedFactor(float speedFactor) {
    OgrePINVOKE.ParticleSystem_setSpeedFactor(swigCPtr, speedFactor);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getSpeedFactor() {
    float ret = OgrePINVOKE.ParticleSystem_getSpeedFactor(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setIterationInterval(float iterationInterval) {
    OgrePINVOKE.ParticleSystem_setIterationInterval(swigCPtr, iterationInterval);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getIterationInterval() {
    float ret = OgrePINVOKE.ParticleSystem_getIterationInterval(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void setDefaultIterationInterval(float iterationInterval) {
    OgrePINVOKE.ParticleSystem_setDefaultIterationInterval(iterationInterval);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public static float getDefaultIterationInterval() {
    float ret = OgrePINVOKE.ParticleSystem_getDefaultIterationInterval();
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setNonVisibleUpdateTimeout(float timeout) {
    OgrePINVOKE.ParticleSystem_setNonVisibleUpdateTimeout(swigCPtr, timeout);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getNonVisibleUpdateTimeout() {
    float ret = OgrePINVOKE.ParticleSystem_getNonVisibleUpdateTimeout(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void setDefaultNonVisibleUpdateTimeout(float timeout) {
    OgrePINVOKE.ParticleSystem_setDefaultNonVisibleUpdateTimeout(timeout);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public static float getDefaultNonVisibleUpdateTimeout() {
    float ret = OgrePINVOKE.ParticleSystem_getDefaultNonVisibleUpdateTimeout();
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getMovableType() {
    string ret = OgrePINVOKE.ParticleSystem_getMovableType(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void _notifyParticleResized() {
    OgrePINVOKE.ParticleSystem__notifyParticleResized(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void _notifyParticleRotated() {
    OgrePINVOKE.ParticleSystem__notifyParticleRotated(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setDefaultDimensions(float width, float height) {
    OgrePINVOKE.ParticleSystem_setDefaultDimensions(swigCPtr, width, height);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setDefaultWidth(float width) {
    OgrePINVOKE.ParticleSystem_setDefaultWidth(swigCPtr, width);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual float getDefaultWidth() {
    float ret = OgrePINVOKE.ParticleSystem_getDefaultWidth(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void setDefaultHeight(float height) {
    OgrePINVOKE.ParticleSystem_setDefaultHeight(swigCPtr, height);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual float getDefaultHeight() {
    float ret = OgrePINVOKE.ParticleSystem_getDefaultHeight(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool getCullIndividually() {
    bool ret = OgrePINVOKE.ParticleSystem_getCullIndividually(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void setCullIndividually(bool cullIndividual) {
    OgrePINVOKE.ParticleSystem_setCullIndividually(swigCPtr, cullIndividual);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual string getResourceGroupName() {
    string ret = OgrePINVOKE.ParticleSystem_getResourceGroupName(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getOrigin() {
    string ret = OgrePINVOKE.ParticleSystem_getOrigin(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _notifyOrigin(string origin) {
    OgrePINVOKE.ParticleSystem__notifyOrigin(swigCPtr, origin);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setRenderQueueGroup(byte queueID) {
    OgrePINVOKE.ParticleSystem_setRenderQueueGroup(swigCPtr, queueID);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setRenderQueueGroupAndPriority(byte queueID, ushort priority) {
    OgrePINVOKE.ParticleSystem_setRenderQueueGroupAndPriority(swigCPtr, queueID, priority);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSortingEnabled(bool enabled) {
    OgrePINVOKE.ParticleSystem_setSortingEnabled(swigCPtr, enabled);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getSortingEnabled() {
    bool ret = OgrePINVOKE.ParticleSystem_getSortingEnabled(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setBounds(AxisAlignedBox aabb) {
    OgrePINVOKE.ParticleSystem_setBounds(swigCPtr, AxisAlignedBox.getCPtr(aabb));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setBoundsAutoUpdated(bool autoUpdate, float stopIn) {
    OgrePINVOKE.ParticleSystem_setBoundsAutoUpdated__SWIG_0(swigCPtr, autoUpdate, stopIn);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setBoundsAutoUpdated(bool autoUpdate) {
    OgrePINVOKE.ParticleSystem_setBoundsAutoUpdated__SWIG_1(swigCPtr, autoUpdate);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setKeepParticlesInLocalSpace(bool keepLocal) {
    OgrePINVOKE.ParticleSystem_setKeepParticlesInLocalSpace(swigCPtr, keepLocal);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getKeepParticlesInLocalSpace() {
    bool ret = OgrePINVOKE.ParticleSystem_getKeepParticlesInLocalSpace(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _updateBounds() {
    OgrePINVOKE.ParticleSystem__updateBounds(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setEmitting(bool v) {
    OgrePINVOKE.ParticleSystem_setEmitting(swigCPtr, v);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getEmitting() {
    bool ret = OgrePINVOKE.ParticleSystem_getEmitting(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getTypeFlags() {
    uint ret = OgrePINVOKE.ParticleSystem_getTypeFlags(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
