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

public class InstanceManager : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal InstanceManager(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(InstanceManager obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~InstanceManager() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_InstanceManager(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public InstanceManager(string customName, SceneManager sceneManager, string meshName, string groupName, InstanceManager.InstancingTechnique instancingTechnique, ushort instancingFlags, uint instancesPerBatch, ushort subMeshIdx, bool useBoneMatrixLookup) : this(OgrePINVOKE.new_InstanceManager__SWIG_0(customName, SceneManager.getCPtr(sceneManager), meshName, groupName, (int)instancingTechnique, instancingFlags, instancesPerBatch, subMeshIdx, useBoneMatrixLookup), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public InstanceManager(string customName, SceneManager sceneManager, string meshName, string groupName, InstanceManager.InstancingTechnique instancingTechnique, ushort instancingFlags, uint instancesPerBatch, ushort subMeshIdx) : this(OgrePINVOKE.new_InstanceManager__SWIG_1(customName, SceneManager.getCPtr(sceneManager), meshName, groupName, (int)instancingTechnique, instancingFlags, instancesPerBatch, subMeshIdx), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getName() {
    string ret = OgrePINVOKE.InstanceManager_getName(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SceneManager getSceneManager() {
    global::System.IntPtr cPtr = OgrePINVOKE.InstanceManager_getSceneManager(swigCPtr);
    SceneManager ret = (cPtr == global::System.IntPtr.Zero) ? null : new SceneManager(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setInstancesPerBatch(uint instancesPerBatch) {
    OgrePINVOKE.InstanceManager_setInstancesPerBatch(swigCPtr, instancesPerBatch);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setMaxLookupTableInstances(uint maxLookupTableInstances) {
    OgrePINVOKE.InstanceManager_setMaxLookupTableInstances(swigCPtr, maxLookupTableInstances);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setNumCustomParams(byte numCustomParams) {
    OgrePINVOKE.InstanceManager_setNumCustomParams(swigCPtr, numCustomParams);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public byte getNumCustomParams() {
    byte ret = OgrePINVOKE.InstanceManager_getNumCustomParams(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public InstanceManager.InstancingTechnique getInstancingTechnique() {
    InstanceManager.InstancingTechnique ret = (InstanceManager.InstancingTechnique)OgrePINVOKE.InstanceManager_getInstancingTechnique(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getMaxOrBestNumInstancesPerBatch(string materialName, uint suggestedSize, ushort flags) {
    uint ret = OgrePINVOKE.InstanceManager_getMaxOrBestNumInstancesPerBatch(swigCPtr, materialName, suggestedSize, flags);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public InstancedEntity createInstancedEntity(string materialName) {
    global::System.IntPtr cPtr = OgrePINVOKE.InstanceManager_createInstancedEntity(swigCPtr, materialName);
    InstancedEntity ret = (cPtr == global::System.IntPtr.Zero) ? null : new InstancedEntity(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void cleanupEmptyBatches() {
    OgrePINVOKE.InstanceManager_cleanupEmptyBatches(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void defragmentBatches(bool optimizeCulling) {
    OgrePINVOKE.InstanceManager_defragmentBatches(swigCPtr, optimizeCulling);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSetting(InstanceManager.BatchSettingId id, bool enabled, string materialName) {
    OgrePINVOKE.InstanceManager_setSetting__SWIG_0(swigCPtr, (int)id, enabled, materialName);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSetting(InstanceManager.BatchSettingId id, bool enabled) {
    OgrePINVOKE.InstanceManager_setSetting__SWIG_1(swigCPtr, (int)id, enabled);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getSetting(InstanceManager.BatchSettingId id, string materialName) {
    bool ret = OgrePINVOKE.InstanceManager_getSetting(swigCPtr, (int)id, materialName);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool hasSettings(string materialName) {
    bool ret = OgrePINVOKE.InstanceManager_hasSettings(swigCPtr, materialName);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setBatchesAsStaticAndUpdate(bool bStatic) {
    OgrePINVOKE.InstanceManager_setBatchesAsStaticAndUpdate(swigCPtr, bStatic);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _addDirtyBatch(InstanceBatch dirtyBatch) {
    OgrePINVOKE.InstanceManager__addDirtyBatch(swigCPtr, InstanceBatch.getCPtr(dirtyBatch));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _updateDirtyBatches() {
    OgrePINVOKE.InstanceManager__updateDirtyBatches(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_Ogre__ConstMapIteratorT_std__mapT_std__string_std__vectorT_Ogre__InstanceBatch_p_t_std__lessT_std__string_t_t_t getInstanceBatchMapIterator() {
    SWIGTYPE_p_Ogre__ConstMapIteratorT_std__mapT_std__string_std__vectorT_Ogre__InstanceBatch_p_t_std__lessT_std__string_t_t_t ret = new SWIGTYPE_p_Ogre__ConstMapIteratorT_std__mapT_std__string_std__vectorT_Ogre__InstanceBatch_p_t_std__lessT_std__string_t_t_t(OgrePINVOKE.InstanceManager_getInstanceBatchMapIterator(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Ogre__ConstVectorIteratorT_std__vectorT_Ogre__InstanceBatch_p_t_t getInstanceBatchIterator(string materialName) {
    SWIGTYPE_p_Ogre__ConstVectorIteratorT_std__vectorT_Ogre__InstanceBatch_p_t_t ret = new SWIGTYPE_p_Ogre__ConstVectorIteratorT_std__vectorT_Ogre__InstanceBatch_p_t_t(OgrePINVOKE.InstanceManager_getInstanceBatchIterator(swigCPtr, materialName), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum InstancingTechnique {
    ShaderBased,
    TextureVTF,
    HWInstancingBasic,
    HWInstancingVTF,
    InstancingTechniquesCount
  }

  public enum BatchSettingId {
    CAST_SHADOWS = 0,
    SHOW_BOUNDINGBOX,
    NUM_SETTINGS
  }

}

}