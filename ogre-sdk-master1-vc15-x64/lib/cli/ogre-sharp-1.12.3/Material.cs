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

public class Material : Resource {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal Material(global::System.IntPtr cPtr, bool cMemoryOwn) : base(OgrePINVOKE.Material_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Material obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Material() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_Material(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public Material(ResourceManager creator, string name, ulong handle, string group, bool isManual, ManualResourceLoader loader) : this(OgrePINVOKE.new_Material__SWIG_0(ResourceManager.getCPtr(creator), name, handle, group, isManual, ManualResourceLoader.getCPtr(loader)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Material(ResourceManager creator, string name, ulong handle, string group, bool isManual) : this(OgrePINVOKE.new_Material__SWIG_1(ResourceManager.getCPtr(creator), name, handle, group, isManual), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Material(ResourceManager creator, string name, ulong handle, string group) : this(OgrePINVOKE.new_Material__SWIG_2(ResourceManager.getCPtr(creator), name, handle, group), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isTransparent() {
    bool ret = OgrePINVOKE.Material_isTransparent(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setReceiveShadows(bool enabled) {
    OgrePINVOKE.Material_setReceiveShadows(swigCPtr, enabled);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getReceiveShadows() {
    bool ret = OgrePINVOKE.Material_getReceiveShadows(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setTransparencyCastsShadows(bool enabled) {
    OgrePINVOKE.Material_setTransparencyCastsShadows(swigCPtr, enabled);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getTransparencyCastsShadows() {
    bool ret = OgrePINVOKE.Material_getTransparencyCastsShadows(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Technique createTechnique() {
    global::System.IntPtr cPtr = OgrePINVOKE.Material_createTechnique(swigCPtr);
    Technique ret = (cPtr == global::System.IntPtr.Zero) ? null : new Technique(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Technique getTechnique(ushort index) {
    global::System.IntPtr cPtr = OgrePINVOKE.Material_getTechnique__SWIG_0(swigCPtr, index);
    Technique ret = (cPtr == global::System.IntPtr.Zero) ? null : new Technique(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Technique getTechnique(string name) {
    global::System.IntPtr cPtr = OgrePINVOKE.Material_getTechnique__SWIG_1(swigCPtr, name);
    Technique ret = (cPtr == global::System.IntPtr.Zero) ? null : new Technique(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ushort getNumTechniques() {
    ushort ret = OgrePINVOKE.Material_getNumTechniques(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void removeTechnique(ushort index) {
    OgrePINVOKE.Material_removeTechnique(swigCPtr, index);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeAllTechniques() {
    OgrePINVOKE.Material_removeAllTechniques(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Techniques getTechniques() {
    Techniques ret = new Techniques(OgrePINVOKE.Material_getTechniques(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Techniques getSupportedTechniques() {
    Techniques ret = new Techniques(OgrePINVOKE.Material_getSupportedTechniques(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getUnsupportedTechniquesExplanation() {
    string ret = OgrePINVOKE.Material_getUnsupportedTechniquesExplanation(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ushort getNumLodLevels(ushort schemeIndex) {
    ushort ret = OgrePINVOKE.Material_getNumLodLevels__SWIG_0(swigCPtr, schemeIndex);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ushort getNumLodLevels(string schemeName) {
    ushort ret = OgrePINVOKE.Material_getNumLodLevels__SWIG_1(swigCPtr, schemeName);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Technique getBestTechnique(ushort lodIndex, Renderable rend) {
    global::System.IntPtr cPtr = OgrePINVOKE.Material_getBestTechnique__SWIG_0(swigCPtr, lodIndex, Renderable.getCPtr(rend));
    Technique ret = (cPtr == global::System.IntPtr.Zero) ? null : new Technique(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Technique getBestTechnique(ushort lodIndex) {
    global::System.IntPtr cPtr = OgrePINVOKE.Material_getBestTechnique__SWIG_1(swigCPtr, lodIndex);
    Technique ret = (cPtr == global::System.IntPtr.Zero) ? null : new Technique(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Technique getBestTechnique() {
    global::System.IntPtr cPtr = OgrePINVOKE.Material_getBestTechnique__SWIG_2(swigCPtr);
    Technique ret = (cPtr == global::System.IntPtr.Zero) ? null : new Technique(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MaterialPtr clone(string newName, bool changeGroup, string newGroup) {
    MaterialPtr ret = new MaterialPtr(OgrePINVOKE.Material_clone__SWIG_0(swigCPtr, newName, changeGroup, newGroup), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MaterialPtr clone(string newName, bool changeGroup) {
    MaterialPtr ret = new MaterialPtr(OgrePINVOKE.Material_clone__SWIG_1(swigCPtr, newName, changeGroup), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MaterialPtr clone(string newName) {
    MaterialPtr ret = new MaterialPtr(OgrePINVOKE.Material_clone__SWIG_2(swigCPtr, newName), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void copyDetailsTo(MaterialPtr mat) {
    OgrePINVOKE.Material_copyDetailsTo(swigCPtr, MaterialPtr.getCPtr(mat));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void compile(bool autoManageTextureUnits) {
    OgrePINVOKE.Material_compile__SWIG_0(swigCPtr, autoManageTextureUnits);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void compile() {
    OgrePINVOKE.Material_compile__SWIG_1(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setPointSize(float ps) {
    OgrePINVOKE.Material_setPointSize(swigCPtr, ps);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setAmbient(float red, float green, float blue) {
    OgrePINVOKE.Material_setAmbient__SWIG_0(swigCPtr, red, green, blue);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setAmbient(ColourValue ambient) {
    OgrePINVOKE.Material_setAmbient__SWIG_1(swigCPtr, ColourValue.getCPtr(ambient));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setDiffuse(float red, float green, float blue, float alpha) {
    OgrePINVOKE.Material_setDiffuse__SWIG_0(swigCPtr, red, green, blue, alpha);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setDiffuse(ColourValue diffuse) {
    OgrePINVOKE.Material_setDiffuse__SWIG_1(swigCPtr, ColourValue.getCPtr(diffuse));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSpecular(float red, float green, float blue, float alpha) {
    OgrePINVOKE.Material_setSpecular__SWIG_0(swigCPtr, red, green, blue, alpha);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSpecular(ColourValue specular) {
    OgrePINVOKE.Material_setSpecular__SWIG_1(swigCPtr, ColourValue.getCPtr(specular));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setShininess(float val) {
    OgrePINVOKE.Material_setShininess(swigCPtr, val);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSelfIllumination(float red, float green, float blue) {
    OgrePINVOKE.Material_setSelfIllumination__SWIG_0(swigCPtr, red, green, blue);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSelfIllumination(ColourValue selfIllum) {
    OgrePINVOKE.Material_setSelfIllumination__SWIG_1(swigCPtr, ColourValue.getCPtr(selfIllum));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setDepthCheckEnabled(bool enabled) {
    OgrePINVOKE.Material_setDepthCheckEnabled(swigCPtr, enabled);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setDepthWriteEnabled(bool enabled) {
    OgrePINVOKE.Material_setDepthWriteEnabled(swigCPtr, enabled);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setDepthFunction(CompareFunction func) {
    OgrePINVOKE.Material_setDepthFunction(swigCPtr, (int)func);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setColourWriteEnabled(bool enabled) {
    OgrePINVOKE.Material_setColourWriteEnabled__SWIG_0(swigCPtr, enabled);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setColourWriteEnabled(bool red, bool green, bool blue, bool alpha) {
    OgrePINVOKE.Material_setColourWriteEnabled__SWIG_1(swigCPtr, red, green, blue, alpha);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setCullingMode(CullingMode mode) {
    OgrePINVOKE.Material_setCullingMode(swigCPtr, (int)mode);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setManualCullingMode(ManualCullingMode mode) {
    OgrePINVOKE.Material_setManualCullingMode(swigCPtr, (int)mode);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setLightingEnabled(bool enabled) {
    OgrePINVOKE.Material_setLightingEnabled(swigCPtr, enabled);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setShadingMode(ShadeOptions mode) {
    OgrePINVOKE.Material_setShadingMode(swigCPtr, (int)mode);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setFog(bool overrideScene, FogMode mode, ColourValue colour, float expDensity, float linearStart, float linearEnd) {
    OgrePINVOKE.Material_setFog__SWIG_0(swigCPtr, overrideScene, (int)mode, ColourValue.getCPtr(colour), expDensity, linearStart, linearEnd);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setFog(bool overrideScene, FogMode mode, ColourValue colour, float expDensity, float linearStart) {
    OgrePINVOKE.Material_setFog__SWIG_1(swigCPtr, overrideScene, (int)mode, ColourValue.getCPtr(colour), expDensity, linearStart);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setFog(bool overrideScene, FogMode mode, ColourValue colour, float expDensity) {
    OgrePINVOKE.Material_setFog__SWIG_2(swigCPtr, overrideScene, (int)mode, ColourValue.getCPtr(colour), expDensity);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setFog(bool overrideScene, FogMode mode, ColourValue colour) {
    OgrePINVOKE.Material_setFog__SWIG_3(swigCPtr, overrideScene, (int)mode, ColourValue.getCPtr(colour));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setFog(bool overrideScene, FogMode mode) {
    OgrePINVOKE.Material_setFog__SWIG_4(swigCPtr, overrideScene, (int)mode);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setFog(bool overrideScene) {
    OgrePINVOKE.Material_setFog__SWIG_5(swigCPtr, overrideScene);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setDepthBias(float constantBias, float slopeScaleBias) {
    OgrePINVOKE.Material_setDepthBias(swigCPtr, constantBias, slopeScaleBias);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setTextureFiltering(TextureFilterOptions filterType) {
    OgrePINVOKE.Material_setTextureFiltering(swigCPtr, (int)filterType);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setTextureAnisotropy(int maxAniso) {
    OgrePINVOKE.Material_setTextureAnisotropy(swigCPtr, maxAniso);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSceneBlending(SceneBlendType sbt) {
    OgrePINVOKE.Material_setSceneBlending__SWIG_0(swigCPtr, (int)sbt);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSeparateSceneBlending(SceneBlendType sbt, SceneBlendType sbta) {
    OgrePINVOKE.Material_setSeparateSceneBlending__SWIG_0(swigCPtr, (int)sbt, (int)sbta);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSceneBlending(SceneBlendFactor sourceFactor, SceneBlendFactor destFactor) {
    OgrePINVOKE.Material_setSceneBlending__SWIG_1(swigCPtr, (int)sourceFactor, (int)destFactor);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSeparateSceneBlending(SceneBlendFactor sourceFactor, SceneBlendFactor destFactor, SceneBlendFactor sourceFactorAlpha, SceneBlendFactor destFactorAlpha) {
    OgrePINVOKE.Material_setSeparateSceneBlending__SWIG_1(swigCPtr, (int)sourceFactor, (int)destFactor, (int)sourceFactorAlpha, (int)destFactorAlpha);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _notifyNeedsRecompile() {
    OgrePINVOKE.Material__notifyNeedsRecompile(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setLodLevels(SWIGTYPE_p_std__vectorT_float_t lodValues) {
    OgrePINVOKE.Material_setLodLevels(swigCPtr, SWIGTYPE_p_std__vectorT_float_t.getCPtr(lodValues));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_std__vectorT_float_t getLodValues() {
    SWIGTYPE_p_std__vectorT_float_t ret = new SWIGTYPE_p_std__vectorT_float_t(OgrePINVOKE.Material_getLodValues(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_float_t getUserLodValues() {
    SWIGTYPE_p_std__vectorT_float_t ret = new SWIGTYPE_p_std__vectorT_float_t(OgrePINVOKE.Material_getUserLodValues(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ushort getLodIndex(float value) {
    ushort ret = OgrePINVOKE.Material_getLodIndex(swigCPtr, value);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Ogre__LodStrategy getLodStrategy() {
    global::System.IntPtr cPtr = OgrePINVOKE.Material_getLodStrategy(swigCPtr);
    SWIGTYPE_p_Ogre__LodStrategy ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Ogre__LodStrategy(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setLodStrategy(SWIGTYPE_p_Ogre__LodStrategy lodStrategy) {
    OgrePINVOKE.Material_setLodStrategy(swigCPtr, SWIGTYPE_p_Ogre__LodStrategy.getCPtr(lodStrategy));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void touch() {
    OgrePINVOKE.Material_touch(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool applyTextureAliases(NameValuePairList aliasList, bool apply) {
    bool ret = OgrePINVOKE.Material_applyTextureAliases__SWIG_0(swigCPtr, NameValuePairList.getCPtr(aliasList), apply);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool applyTextureAliases(NameValuePairList aliasList) {
    bool ret = OgrePINVOKE.Material_applyTextureAliases__SWIG_1(swigCPtr, NameValuePairList.getCPtr(aliasList));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool getCompilationRequired() {
    bool ret = OgrePINVOKE.Material_getCompilationRequired(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}