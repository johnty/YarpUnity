/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class DriverCreator : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DriverCreator(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(DriverCreator obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~DriverCreator() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_DriverCreator(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public new ConstString toString() {
    ConstString ret = new ConstString(yarpPINVOKE.DriverCreator_toString(swigCPtr), true);
    return ret;
  }

  public virtual DeviceDriver create() {
    IntPtr cPtr = yarpPINVOKE.DriverCreator_create(swigCPtr);
    DeviceDriver ret = (cPtr == IntPtr.Zero) ? null : new DeviceDriver(cPtr, false);
    return ret;
  }

  public virtual ConstString getName() {
    ConstString ret = new ConstString(yarpPINVOKE.DriverCreator_getName(swigCPtr), true);
    return ret;
  }

  public virtual ConstString getWrapper() {
    ConstString ret = new ConstString(yarpPINVOKE.DriverCreator_getWrapper(swigCPtr), true);
    return ret;
  }

  public virtual ConstString getCode() {
    ConstString ret = new ConstString(yarpPINVOKE.DriverCreator_getCode(swigCPtr), true);
    return ret;
  }

  public virtual SWIGTYPE_p_yarp__dev__PolyDriver owner() {
    IntPtr cPtr = yarpPINVOKE.DriverCreator_owner(swigCPtr);
    SWIGTYPE_p_yarp__dev__PolyDriver ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_yarp__dev__PolyDriver(cPtr, false);
    return ret;
  }

}
