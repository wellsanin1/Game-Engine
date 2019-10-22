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

public class MaterialPtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MaterialPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MaterialPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MaterialPtr() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_MaterialPtr(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public MaterialPtr(SWIGTYPE_p_std__nullptr_t arg0) : this(OgrePINVOKE.new_MaterialPtr__SWIG_0(SWIGTYPE_p_std__nullptr_t.getCPtr(arg0)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public MaterialPtr() : this(OgrePINVOKE.new_MaterialPtr__SWIG_1(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public MaterialPtr(MaterialPtr r) : this(OgrePINVOKE.new_MaterialPtr__SWIG_2(MaterialPtr.getCPtr(r)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Material __deref__() {
    global::System.IntPtr cPtr = OgrePINVOKE.MaterialPtr___deref__(swigCPtr);
    Material ret = (cPtr == global::System.IntPtr.Zero) ? null : new Material(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isTransparent() {
    bool ret = OgrePINVOKE.MaterialPtr_isTransparent(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setReceiveShadows(bool enabled) {
    OgrePINVOKE.MaterialPtr_setReceiveShadows(swigCPtr, enabled);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getReceiveShadows() {
    bool ret = OgrePINVOKE.MaterialPtr_getReceiveShadows(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setTransparencyCastsShadows(bool enabled) {
    OgrePINVOKE.MaterialPtr_setTransparencyCastsShadows(swigCPtr, enabled);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getTransparencyCastsShadows() {
    bool ret = OgrePINVOKE.MaterialPtr_getTransparencyCastsShadows(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Technique createTechnique() {
    global::System.IntPtr cPtr = OgrePINVOKE.MaterialPtr_createTechnique(swigCPtr);
    Technique ret = (cPtr == global::System.IntPtr.Zero) ? null : new Technique(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Technique getTechnique(ushort index) {
    global::System.IntPtr cPtr = OgrePINVOKE.MaterialPtr_getTechnique__SWIG_0(swigCPtr, index);
    Technique ret = (cPtr == global::System.IntPtr.Zero) ? null : new Technique(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Technique getTechnique(string name) {
    global::System.IntPtr cPtr = OgrePINVOKE.MaterialPtr_getTechnique__SWIG_1(swigCPtr, name);
    Technique ret = (cPtr == global::System.IntPtr.Zero) ? null : new Technique(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ushort getNumTechniques() {
    ushort ret = OgrePINVOKE.MaterialPtr_getNumTechniques(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void removeTechnique(ushort index) {
    OgrePINVOKE.MaterialPtr_removeTechnique(swigCPtr, index);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeAllTechniques() {
    OgrePINVOKE.MaterialPtr_removeAllTechniques(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Techniques getTechniques() {
    Techniques ret = new Techniques(OgrePINVOKE.MaterialPtr_getTechniques(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Techniques getSupportedTechniques() {
    Techniques ret = new Techniques(OgrePINVOKE.MaterialPtr_getSupportedTechniques(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getUnsupportedTechniquesExplanation() {
    string ret = OgrePINVOKE.MaterialPtr_getUnsupportedTechniquesExplanation(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ushort getNumLodLevels(ushort schemeIndex) {
    ushort ret = OgrePINVOKE.MaterialPtr_getNumLodLevels__SWIG_0(swigCPtr, schemeIndex);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ushort getNumLodLevels(string schemeName) {
    ushort ret = OgrePINVOKE.MaterialPtr_getNumLodLevels__SWIG_1(swigCPtr, schemeName);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Technique getBestTechnique(ushort lodIndex, Renderable rend) {
    global::System.IntPtr cPtr = OgrePINVOKE.MaterialPtr_getBestTechnique__SWIG_0(swigCPtr, lodIndex, Renderable.getCPtr(rend));
    Technique ret = (cPtr == global::System.IntPtr.Zero) ? null : new Technique(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Technique getBestTechnique(ushort lodIndex) {
    global::System.IntPtr cPtr = OgrePINVOKE.MaterialPtr_getBestTechnique__SWIG_1(swigCPtr, lodIndex);
    Technique ret = (cPtr == global::System.IntPtr.Zero) ? null : new Technique(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Technique getBestTechnique() {
    global::System.IntPtr cPtr = OgrePINVOKE.MaterialPtr_getBestTechnique__SWIG_2(swigCPtr);
    Technique ret = (cPtr == global::System.IntPtr.Zero) ? null : new Technique(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MaterialPtr clone(string newName, bool changeGroup, string newGroup) {
    MaterialPtr ret = new MaterialPtr(OgrePINVOKE.MaterialPtr_clone__SWIG_0(swigCPtr, newName, changeGroup, newGroup), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MaterialPtr clone(string newName, bool changeGroup) {
    MaterialPtr ret = new MaterialPtr(OgrePINVOKE.MaterialPtr_clone__SWIG_1(swigCPtr, newName, changeGroup), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MaterialPtr clone(string newName) {
    MaterialPtr ret = new MaterialPtr(OgrePINVOKE.MaterialPtr_clone__SWIG_2(swigCPtr, newName), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void copyDetailsTo(MaterialPtr mat) {
    OgrePINVOKE.MaterialPtr_copyDetailsTo(swigCPtr, MaterialPtr.getCPtr(mat));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void compile(bool autoManageTextureUnits) {
    OgrePINVOKE.MaterialPtr_compile__SWIG_0(swigCPtr, autoManageTextureUnits);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void compile() {
    OgrePINVOKE.MaterialPtr_compile__SWIG_1(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setPointSize(float ps) {
    OgrePINVOKE.MaterialPtr_setPointSize(swigCPtr, ps);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setAmbient(float red, float green, float blue) {
    OgrePINVOKE.MaterialPtr_setAmbient__SWIG_0(swigCPtr, red, green, blue);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setAmbient(ColourValue ambient) {
    OgrePINVOKE.MaterialPtr_setAmbient__SWIG_1(swigCPtr, ColourValue.getCPtr(ambient));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setDiffuse(float red, float green, float blue, float alpha) {
    OgrePINVOKE.MaterialPtr_setDiffuse__SWIG_0(swigCPtr, red, green, blue, alpha);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setDiffuse(ColourValue diffuse) {
    OgrePINVOKE.MaterialPtr_setDiffuse__SWIG_1(swigCPtr, ColourValue.getCPtr(diffuse));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSpecular(float red, float green, float blue, float alpha) {
    OgrePINVOKE.MaterialPtr_setSpecular__SWIG_0(swigCPtr, red, green, blue, alpha);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSpecular(ColourValue specular) {
    OgrePINVOKE.MaterialPtr_setSpecular__SWIG_1(swigCPtr, ColourValue.getCPtr(specular));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setShininess(float val) {
    OgrePINVOKE.MaterialPtr_setShininess(swigCPtr, val);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSelfIllumination(float red, float green, float blue) {
    OgrePINVOKE.MaterialPtr_setSelfIllumination__SWIG_0(swigCPtr, red, green, blue);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSelfIllumination(ColourValue selfIllum) {
    OgrePINVOKE.MaterialPtr_setSelfIllumination__SWIG_1(swigCPtr, ColourValue.getCPtr(selfIllum));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setDepthCheckEnabled(bool enabled) {
    OgrePINVOKE.MaterialPtr_setDepthCheckEnabled(swigCPtr, enabled);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setDepthWriteEnabled(bool enabled) {
    OgrePINVOKE.MaterialPtr_setDepthWriteEnabled(swigCPtr, enabled);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setDepthFunction(CompareFunction func) {
    OgrePINVOKE.MaterialPtr_setDepthFunction(swigCPtr, (int)func);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setColourWriteEnabled(bool enabled) {
    OgrePINVOKE.MaterialPtr_setColourWriteEnabled__SWIG_0(swigCPtr, enabled);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setColourWriteEnabled(bool red, bool green, bool blue, bool alpha) {
    OgrePINVOKE.MaterialPtr_setColourWriteEnabled__SWIG_1(swigCPtr, red, green, blue, alpha);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setCullingMode(CullingMode mode) {
    OgrePINVOKE.MaterialPtr_setCullingMode(swigCPtr, (int)mode);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setManualCullingMode(ManualCullingMode mode) {
    OgrePINVOKE.MaterialPtr_setManualCullingMode(swigCPtr, (int)mode);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setLightingEnabled(bool enabled) {
    OgrePINVOKE.MaterialPtr_setLightingEnabled(swigCPtr, enabled);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setShadingMode(ShadeOptions mode) {
    OgrePINVOKE.MaterialPtr_setShadingMode(swigCPtr, (int)mode);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setFog(bool overrideScene, FogMode mode, ColourValue colour, float expDensity, float linearStart, float linearEnd) {
    OgrePINVOKE.MaterialPtr_setFog__SWIG_0(swigCPtr, overrideScene, (int)mode, ColourValue.getCPtr(colour), expDensity, linearStart, linearEnd);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setFog(bool overrideScene, FogMode mode, ColourValue colour, float expDensity, float linearStart) {
    OgrePINVOKE.MaterialPtr_setFog__SWIG_1(swigCPtr, overrideScene, (int)mode, ColourValue.getCPtr(colour), expDensity, linearStart);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setFog(bool overrideScene, FogMode mode, ColourValue colour, float expDensity) {
    OgrePINVOKE.MaterialPtr_setFog__SWIG_2(swigCPtr, overrideScene, (int)mode, ColourValue.getCPtr(colour), expDensity);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setFog(bool overrideScene, FogMode mode, ColourValue colour) {
    OgrePINVOKE.MaterialPtr_setFog__SWIG_3(swigCPtr, overrideScene, (int)mode, ColourValue.getCPtr(colour));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setFog(bool overrideScene, FogMode mode) {
    OgrePINVOKE.MaterialPtr_setFog__SWIG_4(swigCPtr, overrideScene, (int)mode);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setFog(bool overrideScene) {
    OgrePINVOKE.MaterialPtr_setFog__SWIG_5(swigCPtr, overrideScene);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setDepthBias(float constantBias, float slopeScaleBias) {
    OgrePINVOKE.MaterialPtr_setDepthBias(swigCPtr, constantBias, slopeScaleBias);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setTextureFiltering(TextureFilterOptions filterType) {
    OgrePINVOKE.MaterialPtr_setTextureFiltering(swigCPtr, (int)filterType);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setTextureAnisotropy(int maxAniso) {
    OgrePINVOKE.MaterialPtr_setTextureAnisotropy(swigCPtr, maxAniso);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSceneBlending(SceneBlendType sbt) {
    OgrePINVOKE.MaterialPtr_setSceneBlending__SWIG_0(swigCPtr, (int)sbt);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSceneBlending(SceneBlendFactor sourceFactor, SceneBlendFactor destFactor) {
    OgrePINVOKE.MaterialPtr_setSceneBlending__SWIG_1(swigCPtr, (int)sourceFactor, (int)destFactor);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSeparateSceneBlending(SceneBlendType sbt, SceneBlendType sbta) {
    OgrePINVOKE.MaterialPtr_setSeparateSceneBlending__SWIG_0(swigCPtr, (int)sbt, (int)sbta);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSeparateSceneBlending(SceneBlendFactor sourceFactor, SceneBlendFactor destFactor, SceneBlendFactor sourceFactorAlpha, SceneBlendFactor destFactorAlpha) {
    OgrePINVOKE.MaterialPtr_setSeparateSceneBlending__SWIG_1(swigCPtr, (int)sourceFactor, (int)destFactor, (int)sourceFactorAlpha, (int)destFactorAlpha);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _notifyNeedsRecompile() {
    OgrePINVOKE.MaterialPtr__notifyNeedsRecompile(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setLodLevels(SWIGTYPE_p_std__vectorT_float_t lodValues) {
    OgrePINVOKE.MaterialPtr_setLodLevels(swigCPtr, SWIGTYPE_p_std__vectorT_float_t.getCPtr(lodValues));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_std__vectorT_float_t getLodValues() {
    SWIGTYPE_p_std__vectorT_float_t ret = new SWIGTYPE_p_std__vectorT_float_t(OgrePINVOKE.MaterialPtr_getLodValues(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_float_t getUserLodValues() {
    SWIGTYPE_p_std__vectorT_float_t ret = new SWIGTYPE_p_std__vectorT_float_t(OgrePINVOKE.MaterialPtr_getUserLodValues(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ushort getLodIndex(float value) {
    ushort ret = OgrePINVOKE.MaterialPtr_getLodIndex(swigCPtr, value);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Ogre__LodStrategy getLodStrategy() {
    global::System.IntPtr cPtr = OgrePINVOKE.MaterialPtr_getLodStrategy(swigCPtr);
    SWIGTYPE_p_Ogre__LodStrategy ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Ogre__LodStrategy(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setLodStrategy(SWIGTYPE_p_Ogre__LodStrategy lodStrategy) {
    OgrePINVOKE.MaterialPtr_setLodStrategy(swigCPtr, SWIGTYPE_p_Ogre__LodStrategy.getCPtr(lodStrategy));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void touch() {
    OgrePINVOKE.MaterialPtr_touch(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool applyTextureAliases(NameValuePairList aliasList, bool apply) {
    bool ret = OgrePINVOKE.MaterialPtr_applyTextureAliases__SWIG_0(swigCPtr, NameValuePairList.getCPtr(aliasList), apply);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool applyTextureAliases(NameValuePairList aliasList) {
    bool ret = OgrePINVOKE.MaterialPtr_applyTextureAliases__SWIG_1(swigCPtr, NameValuePairList.getCPtr(aliasList));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool getCompilationRequired() {
    bool ret = OgrePINVOKE.MaterialPtr_getCompilationRequired(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void prepare(bool backgroundThread) {
    OgrePINVOKE.MaterialPtr_prepare__SWIG_0(swigCPtr, backgroundThread);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void prepare() {
    OgrePINVOKE.MaterialPtr_prepare__SWIG_1(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void load(bool backgroundThread) {
    OgrePINVOKE.MaterialPtr_load__SWIG_0(swigCPtr, backgroundThread);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void load() {
    OgrePINVOKE.MaterialPtr_load__SWIG_1(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void reload(Resource.LoadingFlags flags) {
    OgrePINVOKE.MaterialPtr_reload__SWIG_0(swigCPtr, (int)flags);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void reload() {
    OgrePINVOKE.MaterialPtr_reload__SWIG_1(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isReloadable() {
    bool ret = OgrePINVOKE.MaterialPtr_isReloadable(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isManuallyLoaded() {
    bool ret = OgrePINVOKE.MaterialPtr_isManuallyLoaded(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void unload() {
    OgrePINVOKE.MaterialPtr_unload(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getSize() {
    uint ret = OgrePINVOKE.MaterialPtr_getSize(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getName() {
    string ret = OgrePINVOKE.MaterialPtr_getName(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ulong getHandle() {
    ulong ret = OgrePINVOKE.MaterialPtr_getHandle(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isPrepared() {
    bool ret = OgrePINVOKE.MaterialPtr_isPrepared(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isLoaded() {
    bool ret = OgrePINVOKE.MaterialPtr_isLoaded(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isLoading() {
    bool ret = OgrePINVOKE.MaterialPtr_isLoading(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Resource.LoadingState getLoadingState() {
    Resource.LoadingState ret = (Resource.LoadingState)OgrePINVOKE.MaterialPtr_getLoadingState(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isBackgroundLoaded() {
    bool ret = OgrePINVOKE.MaterialPtr_isBackgroundLoaded(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setBackgroundLoaded(bool bl) {
    OgrePINVOKE.MaterialPtr_setBackgroundLoaded(swigCPtr, bl);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void escalateLoading() {
    OgrePINVOKE.MaterialPtr_escalateLoading(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addListener(Resource.Listener lis) {
    OgrePINVOKE.MaterialPtr_addListener(swigCPtr, Resource.Listener.getCPtr(lis));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeListener(Resource.Listener lis) {
    OgrePINVOKE.MaterialPtr_removeListener(swigCPtr, Resource.Listener.getCPtr(lis));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getGroup() {
    string ret = OgrePINVOKE.MaterialPtr_getGroup(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void changeGroupOwnership(string newGroup) {
    OgrePINVOKE.MaterialPtr_changeGroupOwnership(swigCPtr, newGroup);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ResourceManager getCreator() {
    global::System.IntPtr cPtr = OgrePINVOKE.MaterialPtr_getCreator(swigCPtr);
    ResourceManager ret = (cPtr == global::System.IntPtr.Zero) ? null : new ResourceManager(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getOrigin() {
    string ret = OgrePINVOKE.MaterialPtr_getOrigin(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _notifyOrigin(string origin) {
    OgrePINVOKE.MaterialPtr__notifyOrigin(swigCPtr, origin);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getStateCount() {
    uint ret = OgrePINVOKE.MaterialPtr_getStateCount(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _dirtyState() {
    OgrePINVOKE.MaterialPtr__dirtyState(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _fireLoadingComplete(bool wasBackgroundLoaded) {
    OgrePINVOKE.MaterialPtr__fireLoadingComplete(swigCPtr, wasBackgroundLoaded);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _firePreparingComplete(bool wasBackgroundLoaded) {
    OgrePINVOKE.MaterialPtr__firePreparingComplete(swigCPtr, wasBackgroundLoaded);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _fireUnloadingComplete() {
    OgrePINVOKE.MaterialPtr__fireUnloadingComplete(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ParamDictionary getParamDictionary() {
    global::System.IntPtr cPtr = OgrePINVOKE.MaterialPtr_getParamDictionary__SWIG_0(swigCPtr);
    ParamDictionary ret = (cPtr == global::System.IntPtr.Zero) ? null : new ParamDictionary(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_Ogre__ParameterDef_t getParameters() {
    SWIGTYPE_p_std__vectorT_Ogre__ParameterDef_t ret = new SWIGTYPE_p_std__vectorT_Ogre__ParameterDef_t(OgrePINVOKE.MaterialPtr_getParameters(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool setParameter(string name, string value) {
    bool ret = OgrePINVOKE.MaterialPtr_setParameter(swigCPtr, name, value);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setParameterList(NameValuePairList paramList) {
    OgrePINVOKE.MaterialPtr_setParameterList(swigCPtr, NameValuePairList.getCPtr(paramList));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getParameter(string name) {
    string ret = OgrePINVOKE.MaterialPtr_getParameter(swigCPtr, name);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void copyParametersTo(StringInterface dest) {
    OgrePINVOKE.MaterialPtr_copyParametersTo(swigCPtr, StringInterface.getCPtr(dest));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void cleanupDictionary() {
    OgrePINVOKE.MaterialPtr_cleanupDictionary(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
